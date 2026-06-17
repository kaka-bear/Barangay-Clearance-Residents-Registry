Option Strict On

Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class FrmClearanceTypesList

    Private Sub FrmClearanceTypesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadData()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtSearch.Clear()
        LoadData()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadData()
    End Sub

    ''' <summary>
    ''' Queries the database for clearance templates, filtering by name if specified.
    ''' </summary>
    Private Sub LoadData()
        Dim query As String = "SELECT ClearanceTypeID, TypeName, DefaultFee, CreatedAt FROM ClearanceTypes"
        Dim params As New List(Of OleDbParameter)()

        If Not String.IsNullOrWhiteSpace(TxtSearch.Text) Then
            query &= " WHERE TypeName LIKE ?"
            params.Add(New OleDbParameter("@search", OleDbType.VarWChar) With {.Value = "%" & TxtSearch.Text.Trim() & "%"})
        End If

        query &= " ORDER BY TypeName ASC"

        Dim dt As DataTable = DbHelper.GetTable(query, params)
        DgvTypes.DataSource = dt

        ' Formatting
        If DgvTypes.Columns.Contains("ClearanceTypeID") Then
            DgvTypes.Columns("ClearanceTypeID").HeaderText = "Type ID"
            DgvTypes.Columns("ClearanceTypeID").Width = 80
        End If
        If DgvTypes.Columns.Contains("TypeName") Then
            DgvTypes.Columns("TypeName").HeaderText = "Clearance Template Name"
        End If
        If DgvTypes.Columns.Contains("DefaultFee") Then
            DgvTypes.Columns("DefaultFee").HeaderText = "Default Fee"
            DgvTypes.Columns("DefaultFee").DefaultCellStyle.Format = "C2"
            DgvTypes.Columns("DefaultFee").Width = 120
        End If
        If DgvTypes.Columns.Contains("CreatedAt") Then
            DgvTypes.Columns("CreatedAt").HeaderText = "Date Created"
            DgvTypes.Columns("CreatedAt").DefaultCellStyle.Format = "yyyy-MM-dd"
            DgvTypes.Columns("CreatedAt").Width = 120
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Using fEdit As New FrmClearanceTypeEdit(0)
            If fEdit.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If DgvTypes.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a clearance type to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim typeId As Integer = Convert.ToInt32(DgvTypes.CurrentRow.Cells("ClearanceTypeID").Value)
        Using fEdit As New FrmClearanceTypeEdit(typeId)
            If fEdit.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DgvTypes.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a clearance type to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim typeId As Integer = Convert.ToInt32(DgvTypes.CurrentRow.Cells("ClearanceTypeID").Value)
        Dim typeName As String = DgvTypes.CurrentRow.Cells("TypeName").Value.ToString()

        ' Check if this template is referenced in clearances table
        Dim checkSql As String = "SELECT COUNT(*) FROM Clearances WHERE ClearanceTypeID = ?"
        Dim checkParams As New List(Of OleDbParameter) From {
            New OleDbParameter("@ctId", OleDbType.Integer) With {.Value = typeId}
        }
        Dim usedCount As Integer = Convert.ToInt32(DbHelper.ExecScalar(checkSql, checkParams))

        If usedCount > 0 Then
            MessageBox.Show($"Clearance Type '{typeName}' cannot be deleted because it has been used to issue {usedCount} clearances. " & vbCrLf &
                            "Archive or edit the name instead if you want to deactivate it.", "Delete Prevented", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ask for confirmation
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to permanently delete clearance type '{typeName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Try
                Dim deleteSql As String = "DELETE FROM ClearanceTypes WHERE ClearanceTypeID = ?"
                Dim delParams As New List(Of OleDbParameter) From {
                    New OleDbParameter("@ctId", OleDbType.Integer) With {.Value = typeId}
                }
                Dim rows As Integer = DbHelper.Exec(deleteSql, delParams)
                If rows > 0 Then
                    MessageBox.Show("Clearance type deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to delete clearance type: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
