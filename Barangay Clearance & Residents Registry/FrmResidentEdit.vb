Option Strict On

Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class FrmResidentEdit
    Private _residentId As Integer = 0
    Private _isEditMode As Boolean = False

    Public Sub New(id As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Set Mode based on ID
        _residentId = id
        _isEditMode = (id > 0)
    End Sub

    Private Sub FrmResidentEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _isEditMode Then
            Me.Text = "Edit Resident Profile"
            LblHeader.Text = "Modify Resident Details"
            LoadResidentData()
        Else
            Me.Text = "Register New Resident"
            LblHeader.Text = "Enter New Resident Details"
            ' Set default selections
            CboSex.SelectedIndex = 0
            CboCivilStatus.SelectedIndex = 0
            DtpBirthDate.Value = DateTime.Today.AddYears(-20) ' Default to a reasonable starting age
        End If
    End Sub

    ''' <summary>
    ''' Load resident details if editing.
    ''' </summary>
    Private Sub LoadResidentData()
        Try
            Dim sql As String = "SELECT * FROM Residents WHERE ResidentID = ?"
            Dim params As New List(Of OleDbParameter) From {
                New OleDbParameter("@rId", _residentId)
            }
            Dim dt As DataTable = DbHelper.GetTable(sql, params)

            If dt.Rows.Count > 0 Then
                Dim r As DataRow = dt.Rows(0)
                TxtFullName.Text = r("FullName").ToString()
                CboSex.SelectedItem = r("Sex").ToString()
                DtpBirthDate.Value = Convert.ToDateTime(r("BirthDate"))
                TxtAddress.Text = r("Address").ToString()
                TxtContact.Text = r("ContactNumber").ToString()
                CboCivilStatus.SelectedItem = r("CivilStatus").ToString()
            Else
                MessageBox.Show("Resident record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading resident record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles MyBase.Click, BtnSave.Click
        If ValidateInput() Then
            Try
                Dim sql As String
                Dim params As New List(Of OleDbParameter)()

                params.Add(New OleDbParameter("@name", OleDbType.VarWChar) With {.Value = TxtFullName.Text.Trim()})
                params.Add(New OleDbParameter("@sex", OleDbType.VarWChar) With {.Value = CboSex.SelectedItem.ToString()})
                params.Add(New OleDbParameter("@bdate", OleDbType.Date) With {.Value = DtpBirthDate.Value.Date})
                params.Add(New OleDbParameter("@addr", OleDbType.VarWChar) With {.Value = TxtAddress.Text.Trim()})

                Dim pContact As New OleDbParameter("@contact", OleDbType.VarWChar)
                pContact.Value = If(String.IsNullOrWhiteSpace(TxtContact.Text), CObj(DBNull.Value), TxtContact.Text.Trim())
                params.Add(pContact)

                params.Add(New OleDbParameter("@civil", OleDbType.VarWChar) With {.Value = CboCivilStatus.SelectedItem.ToString()})

                If _isEditMode Then
                    ' UPDATE Mode
                    sql = "UPDATE Residents SET FullName = ?, Sex = ?, BirthDate = ?, Address = ?, ContactNumber = ?, CivilStatus = ?, UpdatedAt = ? WHERE ResidentID = ?"
                    params.Add(New OleDbParameter("@uAt", OleDbType.Date) With {.Value = DateTime.Now})
                    params.Add(New OleDbParameter("@rId", OleDbType.Integer) With {.Value = _residentId})
                Else
                    ' INSERT Mode
                    sql = "INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                    params.Add(New OleDbParameter("@cAt", OleDbType.Date) With {.Value = DateTime.Now})
                    params.Add(New OleDbParameter("@uAt", OleDbType.Date) With {.Value = DateTime.Now})
                End If

                Dim rows As Integer = DbHelper.Exec(sql, params)
                If rows > 0 Then
                    MessageBox.Show(If(_isEditMode, "Resident details updated successfully.", "New resident registered successfully."), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error saving resident profile: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' Performs client-side validation using the ErrorProvider control.
    ''' </summary>
    Private Function ValidateInput() As Boolean
        Dim isValid As Boolean = True
        ErrorProvider1.Clear()

        ' Full Name Validation
        If String.IsNullOrWhiteSpace(TxtFullName.Text) Then
            ErrorProvider1.SetError(TxtFullName, "Full Name is required.")
            isValid = False
        ElseIf TxtFullName.Text.Trim().Length < 3 Then
            ErrorProvider1.SetError(TxtFullName, "Full Name must be at least 3 characters.")
            isValid = False
        End If

        ' Sex Validation
        If CboSex.SelectedItem Is Nothing Then
            ErrorProvider1.SetError(CboSex, "Please select Sex.")
            isValid = False
        End If

        ' BirthDate Validation
        If DtpBirthDate.Value.Date >= DateTime.Today Then
            ErrorProvider1.SetError(DtpBirthDate, "Birth Date must be in the past.")
            isValid = False
        End If

        ' Address Validation
        If String.IsNullOrWhiteSpace(TxtAddress.Text) Then
            ErrorProvider1.SetError(TxtAddress, "Address is required.")
            isValid = False
        End If

        ' Civil Status Validation
        If CboCivilStatus.SelectedItem Is Nothing Then
            ErrorProvider1.SetError(CboCivilStatus, "Please select Civil Status.")
            isValid = False
        End If

        Return isValid
    End Function
End Class
