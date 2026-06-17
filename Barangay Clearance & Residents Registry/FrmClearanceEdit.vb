Option Strict On

Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class FrmClearanceEdit
    Private _dtTemplates As DataTable

    Private Sub FrmClearanceEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdowns()
        CboPaymentMethod.SelectedIndex = 0 ' Default: Cash
        DtpIssueDate.Value = DateTime.Today
    End Sub

    ''' <summary>
    ''' Load and bind residents and templates from the database.
    ''' </summary>
    Private Sub LoadDropdowns()
        Try
            ' 1. Bind Residents
            Dim sqlResidents As String = "SELECT ResidentID, FullName FROM Residents ORDER BY FullName ASC"
            Dim dtResidents As DataTable = DbHelper.GetTable(sqlResidents)
            
            CboResident.DisplayMember = "FullName"
            CboResident.ValueMember = "ResidentID"
            CboResident.DataSource = dtResidents
            If dtResidents.Rows.Count > 0 Then
                CboResident.SelectedIndex = 0
            End If

            ' 2. Bind Clearance Types
            Dim sqlTemplates As String = "SELECT ClearanceTypeID, TypeName, DefaultFee FROM ClearanceTypes ORDER BY TypeName ASC"
            _dtTemplates = DbHelper.GetTable(sqlTemplates)
            
            CboClearanceType.DisplayMember = "TypeName"
            CboClearanceType.ValueMember = "ClearanceTypeID"
            CboClearanceType.DataSource = _dtTemplates
            If _dtTemplates.Rows.Count > 0 Then
                CboClearanceType.SelectedIndex = 0
                ' Force initial fee load
                UpdateFeeDisplay()
            End If

        Catch ex As Exception
            MessageBox.Show("Error initializing form dropdowns: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub CboClearanceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboClearanceType.SelectedIndexChanged
        UpdateFeeDisplay()
    End Sub

    ''' <summary>
    ''' Updates the Fee read-only input box based on the selected clearance type.
    ''' </summary>
    Private Sub UpdateFeeDisplay()
        If CboClearanceType.SelectedValue IsNot Nothing AndAlso TypeOf CboClearanceType.SelectedValue Is Integer Then
            Dim typeId As Integer = Convert.ToInt32(CboClearanceType.SelectedValue)
            If _dtTemplates IsNot Nothing Then
                For Each r As DataRow In _dtTemplates.Rows
                    If Convert.ToInt32(r("ClearanceTypeID")) = typeId Then
                        Dim fee As Decimal = Convert.ToDecimal(r("DefaultFee"))
                        TxtFee.Text = fee.ToString("N2")
                        Exit Sub
                    End If
                Next
            End If
        End If
        TxtFee.Text = "0.00"
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateInput() Then
            Try
                Dim residentId As Integer = Convert.ToInt32(CboResident.SelectedValue)
                Dim typeId As Integer = Convert.ToInt32(CboClearanceType.SelectedValue)
                Dim purpose As String = TxtPurpose.Text.Trim()
                Dim orNo As String = TxtORNo.Text.Trim()
                Dim issueDate As DateTime = DtpIssueDate.Value.Date
                Dim fee As Decimal = Convert.ToDecimal(TxtFee.Text)
                Dim payMethod As String = CboPaymentMethod.SelectedItem.ToString()
                Dim simulateError As Boolean = ChkSimulateError.Checked

                ' Call transaction wrapped data saver
                Dim success As Boolean = DbHelper.SaveClearanceWithPayment(
                    residentId, typeId, purpose, orNo, issueDate, fee, payMethod, simulateError
                )

                If success Then
                    MessageBox.Show("Clearance certificate issued and payment recorded successfully.", "Transaction Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If

            Catch ex As Exception
                ' Transaction handles rollback internally and logs it; we notify the user.
                MessageBox.Show(ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' Validates inputs and checks for duplicate receipt numbers.
    ''' </summary>
    Private Function ValidateInput() As Boolean
        Dim isValid As Boolean = True
        ErrorProvider1.Clear()

        ' Resident Selection
        If CboResident.SelectedValue Is Nothing OrElse Convert.ToInt32(CboResident.SelectedValue) = 0 Then
            ErrorProvider1.SetError(CboResident, "Please select a resident.")
            isValid = False
        End If

        ' Clearance Type Selection
        If CboClearanceType.SelectedValue Is Nothing OrElse Convert.ToInt32(CboClearanceType.SelectedValue) = 0 Then
            ErrorProvider1.SetError(CboClearanceType, "Please select a clearance type.")
            isValid = False
        End If

        ' Receipt OR Number
        If String.IsNullOrWhiteSpace(TxtORNo.Text) Then
            ErrorProvider1.SetError(TxtORNo, "OR number is required.")
            isValid = False
        Else
            ' Check database if OR number is already used (excluding cancelled certificates if allowed, or absolute unique check)
            Try
                Dim dupSql As String = "SELECT COUNT(*) FROM Clearances WHERE ORNo = ? AND Status <> 'Cancelled'"
                Dim dupParams As New List(Of OleDbParameter) From {
                    New OleDbParameter("@or", OleDbType.VarWChar) With {.Value = TxtORNo.Text.Trim()}
                }
                Dim count As Integer = Convert.ToInt32(DbHelper.ExecScalar(dupSql, dupParams))
                If count > 0 Then
                    ErrorProvider1.SetError(TxtORNo, "This OR number is already assigned to another active certificate.")
                    isValid = False
                End If
            Catch ex As Exception
                ' Let database errors pass through or log
            End Try
        End If

        ' Purpose
        If String.IsNullOrWhiteSpace(TxtPurpose.Text) Then
            ErrorProvider1.SetError(TxtPurpose, "Purpose of clearance is required.")
            isValid = False
        ElseIf TxtPurpose.Text.Trim().Length < 5 Then
            ErrorProvider1.SetError(TxtPurpose, "Purpose must be at least 5 characters.")
            isValid = False
        End If

        ' Payment Method
        If CboPaymentMethod.SelectedItem Is Nothing Then
            ErrorProvider1.SetError(CboPaymentMethod, "Please select a payment method.")
            isValid = False
        End If

        Return isValid
    End Function
End Class
