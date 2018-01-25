Public Class makeDB
    Dim numOfEntries As Integer
    Private Sub btnCancel_click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        For Each tBox In Controls
            If TypeOf tBox Is TextBox Then
                tBox.Text = ""
            End If
        Next tBox
    End Sub

    Private Sub makeDB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' e.Cancel = True
        Dim saveChangesResult As MsgBoxResult
        If txtDatabase.Text = Nothing Then
            e.Cancel = False
        Else
            ' If closeMe = 1 Then
            saveChangesResult = MsgBox("Do you want to save changes to your grades database?", MsgBoxStyle.YesNoCancel, "Comment Generator")
            'End If
            If saveChangesResult.ToString = "Yes" Then
                e.Cancel = True
                SFDialog.FileName = "grades"
                SFDialog.Title = "Save Student Grades - Comment Generator"
                SFDialog.DefaultExt = "txt"
                SFDialog.Filter = "Student Database Text Files|*.txt"
                SFDialog.ShowDialog()
            ElseIf saveChangesResult.ToString = "No" Then
                txtDatabase.Text = ""
                Me.Close()
            ElseIf saveChangesResult.ToString = "Cancel" Then
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub setDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tBox In Controls
            If TypeOf tBox Is TextBox Then
                tBox.Text = ""
            End If
        Next tBox
        lblNumOfStudents.Text = "Number of Students in Database: 0"
        numOfEntries = 0
    End Sub

    Private Sub btnAddStudents_Click(sender As Object, e As EventArgs) Handles btnAddStudents.Click
        If txtStudentName.Text = Nothing Or txtGrade.Text = Nothing Then
            MsgBox("Please fill all the empty text fields.")
            'btnAddStudents.Focus()
        Else
            'Success Do Shttuff
            If Int(txtGrade.Text) > 100 Or Int(txtGrade.Text) < 0 Then
                MsgBox("Please enter a valid grade between 0% and 100%")
                btnAddStudents.Focus()
            Else
                If txtDatabase.Text = Nothing Then
                    txtDatabase.Text += txtStudentName.Text + vbCrLf + txtGrade.Text
                    txtGrade.Text = Nothing
                    txtStudentName.Text = Nothing
                    txtStudentName.Focus()
                    numOfEntries += 1
                    lblNumOfStudents.Text = "Number of Students in Database: " & numOfEntries
                Else
                    txtDatabase.Text += vbCrLf + txtStudentName.Text + vbCrLf + txtGrade.Text
                    txtGrade.Text = Nothing
                    txtStudentName.Text = Nothing
                    txtStudentName.Focus()
                    numOfEntries += 1
                    lblNumOfStudents.Text = "Number of Students in Database: " & numOfEntries
                End If
            End If

        End If
    End Sub
    Private Sub txtGrade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrade.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtStudentName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtStudentName.KeyUp
        If e.KeyCode = Keys.Return Then
            If txtStudentName.Focus = True Then
                btnAddStudents.PerformClick()
            End If
        End If
    End Sub
    Private Sub txtGrades_KeyUp(sender As Object, e As KeyEventArgs) Handles txtGrade.KeyUp
        If e.KeyCode = Keys.Return Then
            If txtStudentName.Focus = True Then
                btnAddStudents.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SFDialog.FileName = "grades"
        SFDialog.Title = "Save Student Grades - Comment Generator"
        SFDialog.DefaultExt = "txt"
        SFDialog.Filter = "Student Database Text Files|*.txt"
        SFDialog.ShowDialog()
    End Sub

    Private Sub SFDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SFDialog.FileOk
        Try
            Dim objWriter As New System.IO.StreamWriter(SFDialog.FileName)
            objWriter.Write(txtDatabase.Text)
            objWriter.Close()
            MsgBox("Databse File Created Successfuly.")
            txtDatabase.Text = Nothing
            Me.Close()
        Catch ex As Exception
            MsgBox("An Error Occured while Saving File. Please Try Again")
        End Try
    End Sub
End Class