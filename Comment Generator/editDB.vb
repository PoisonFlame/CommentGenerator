Imports System.IO

Public Class editDB
    Dim sr As StreamReader
    Dim tempName, tempGrade As String

    Private Sub editDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tBox In Controls
            If TypeOf tBox Is TextBox Then
                tBox.Text = ""
            End If
        Next tBox
        txtDatabase.Text = ""
        txtGrade.Text = ""
        txtStudentName.Text = ""
        cmbStudents.Items.Clear()
        MsgBox("Please Open the Database file you want to edit.", MsgBoxStyle.OkOnly, "Open File")
        OFDialog.FileName = ""
        OFDialog.Title = "Import Student Database - Comment Generator"
        OFDialog.DefaultExt = "txt"
        OFDialog.Filter = "Student Database Text Files|*.txt"
        Dim openFileResult As String = OFDialog.ShowDialog.ToString
        If openFileResult = "Cancel" Then
            Me.Close()
        End If
    End Sub

    Private Sub OFDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFDialog.FileOk
        Try
            cmbStudents.Items.Clear()
            'sr = New StreamReader(OFDialog.FileName)
            Dim numOfLines As Integer = File.ReadAllLines(OFDialog.FileName).Length
            sr = New StreamReader(OFDialog.FileName)
            Dim lines() As String = IO.File.ReadAllLines(OFDialog.FileName)
            txtDatabase.Text = sr.ReadToEnd & " "
            'txtComment.Text = sr.ReadToEnd
            'txtComment.Text = txtComment.Text & " " & numOfLines & " lines"
            For i As Integer = 0 To numOfLines - 1
                'txtComment.Text += lines(i)
                If Not String.IsNullOrWhiteSpace(lines(i)) Then
                    cmbStudents.Items.Add(lines(i))
                End If
                'lstStudentNames.Items.Add(i)
                i += 1
                'Console.WriteLine(i)
            Next
            sr.Close()
        Catch ex As Exception
            ' MsgBox("The file specified could not be opened." & vbNewLine & "Error message:" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.OK, "File Could Not Be Opened!")
        End Try
    End Sub

    Private Sub cmbStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudents.SelectedIndexChanged
        Dim grade As String
        txtGrade.Enabled = True
        txtStudentName.Enabled = True
        txtStudentName.Text = cmbStudents.Text

        'Dim gradeIndex As Integer = gradesFile.IndexOf(selectedName) + selectedName.Length + 2
        'Dim grade As String = gradesFile.Substring(gradeIndex, 2)
        Dim nameIndex As Integer = txtDatabase.Text.IndexOf(cmbStudents.Text) + cmbStudents.Text.Length + 2
        grade = txtDatabase.Text.Substring(nameIndex, 3)
        txtGrade.Text = grade

        tempGrade = grade
        tempName = cmbStudents.Text

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        For Each tBox In Controls
            If TypeOf tBox Is TextBox Then
                tBox.Text = ""
            End If
        Next tBox
    End Sub

    Private Sub editDB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '' e.Cancel = True
        'Dim saveChangesResult As MsgBoxResult
        'sr = New StreamReader(OFDialog.FileName)
        '' Dim originalFile As String = sr.ReadToEnd
        'If txtDatabase.Text = originalFile & " " Then
        '    e.Cancel = False
        'Else
        '    ' If closeMe = 1 Then
        '    saveChangesResult = MsgBox("Do you want to save changes to your grades database?", MsgBoxStyle.YesNoCancel, "Comment Generator")
        '    'End If
        '    If saveChangesResult.ToString = "Yes" Then
        '        e.Cancel = True
        '        SFDialog.FileName = "grades"
        '        SFDialog.Title = "Save Student Grades - Comment Generator"
        '        SFDialog.DefaultExt = "txt"
        '        SFDialog.Filter = "Student Database Text Files|*.txt"
        '        SFDialog.ShowDialog()
        '    ElseIf saveChangesResult.ToString = "No" Then
        '        txtDatabase.Text = ""
        '        Me.Close()
        '    ElseIf saveChangesResult.ToString = "Cancel" Then
        '        e.Cancel = True
        '    End If
        Try
            sr.Close()
        Catch ex As Exception

        End Try

        'End If
    End Sub

    Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click

        If txtStudentName.Text = Nothing Or txtGrade.Text = Nothing Then
            MsgBox("Please fill all the empty text fields.")
            'btnAddStudents.Focus()
        Else
            'Success Do Shttuff
            If Int(txtGrade.Text) > 100 Or Int(txtGrade.Text) < 0 Then
                MsgBox("Please enter a valid grade between 0% and 100%")
                btnSaveStudent.Focus()
            Else
                Dim nameIndex As Integer = txtDatabase.Text.IndexOf(tempName) + tempName.Length
                'Dim grade As String = txtDatabase.Text.Remove(nameIndex + 3).Insert(nameIndex, txtGrade.Text)
                If Not tempGrade = txtGrade.Text Then

                    If tempGrade.Trim.Length = 3 Then
                        'MsgBox("A")
                        txtDatabase.Text = txtDatabase.Text.Remove(nameIndex + 2, tempGrade.Length).Insert(nameIndex + 2, txtGrade.Text).Trim
                        txtDatabase.Text += " "
                    Else
                        'MsgBox("B")
                        txtDatabase.Text = txtDatabase.Text.Remove(nameIndex + 2, tempGrade.Length).Insert(nameIndex + 2, txtGrade.Text & vbCr).Trim 'vvv ' & vbCrLf
                        txtDatabase.Text += " "
                    End If
                End If
                'txtDatabase.Text = Replace(txtDatabase.Text, tempGrade, txtGrade.Text, nameIndex + 1 + nameIndex, 1)
                If Not txtStudentName.Text = tempName Then
                    txtDatabase.Text = txtDatabase.Text.Replace(tempName, txtStudentName.Text).Trim
                End If

                'txtDatabase.Text += " "
                'MsgBox(grade)
                txtGrade.Text = Nothing
                txtStudentName.Text = Nothing
                cmbStudents.Text = ""

                reloadStudents()

            End If

        End If

    End Sub
    Function reloadStudents()
        cmbStudents.Items.Clear()
        txtDatabase.Refresh()
        Dim numOfLines As Integer = txtDatabase.Text.Split(vbCrLf).Length
        Dim lines() As String = txtDatabase.Text.Split(vbCrLf)
        'txtDatabase.Text = sr.ReadToEnd & " "
        'txtComment.Text = sr.ReadToEnd
        'txtComment.Text = txtComment.Text & " " & numOfLines & " lines"
        '/MsgBox(numOfLines - 1)

        For i As Integer = 0 To numOfLines - 1
            'txtComment.Text += lines(i)
            If Not String.IsNullOrWhiteSpace(lines(i)) Then
                cmbStudents.Items.Add(lines(i))
            End If

            '  cmbStudents.Items.Remove(" ")
            ' MsgBox(lines(i))
            'lstStudentNames.Items.Add(i)
            i += 1
            'Console.WriteLine(i)
        Next
    End Function
    Private Sub txtStudentName_TextChanged(sender As Object, e As EventArgs) Handles txtStudentName.TextChanged

    End Sub

    Private Sub txtGrade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrade.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs) Handles txtGrade.TextChanged

    End Sub

    Private Sub tmrTasks_Tick(sender As Object, e As EventArgs) Handles tmrTasks.Tick
        If txtGrade.Text = Nothing Or txtStudentName.Text = Nothing Then
            btnSaveStudent.Enabled = False
            btnRemove.Enabled = False
        Else
            btnSaveStudent.Enabled = True
            btnRemove.Enabled = True
        End If

        If cmbStudents.Text = Nothing Then
            txtStudentName.Enabled = False
        Else
            txtStudentName.Enabled = True
        End If

        If cmbStudents.Text = Nothing Then
            txtGrade.Enabled = False
        Else
            txtGrade.Enabled = True
        End If

    End Sub
    Private Sub txtStudentName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtStudentName.KeyUp
        If e.KeyCode = Keys.Return Then
            If txtStudentName.Focus = True Then
                btnSaveStudent.PerformClick()
            End If
        End If
    End Sub
    Private Sub txtGrades_KeyUp(sender As Object, e As KeyEventArgs) Handles txtGrade.KeyUp
        If e.KeyCode = Keys.Return Then
            If txtStudentName.Focus = True Then
                btnSaveStudent.PerformClick()
            End If
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If System.IO.File.Exists(OFDialog.FileName) = True Then
                sr.Close()
                Dim objWriter As New System.IO.StreamWriter(OFDialog.FileName)
                'If txtDatabase.Text.Contains(" ") Then
                'MsgBox("dum")
                'End If
                objWriter.Write(txtDatabase.Text.Trim & Space(1))
                objWriter.Close()
                MsgBox("Database update successful.")
                Me.Close()
            Else

                MsgBox("An Error Occured. Error: ")

            End If
        Catch ex As Exception
            MsgBox("An Error Occured." & ex.ToString)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim confirmRemove As MsgBoxResult = MsgBox("Are you sure you want to remove " & cmbStudents.Text & " from the database file?", MsgBoxStyle.YesNo)

        If confirmRemove.ToString = "Yes" Then
            'MsgBox("Get Removed Scrub")
            Dim nameIndex As Integer = txtDatabase.Text.IndexOf(tempName) '+ tempName.Length
            'txtDatabase.Text.Insert(nameIndex, vbCrLf)
            'txtDatabase.Text = txtDatabase.Text.Remove(nameIndex - tempName.Length, tempName.Length + tempGrade.Trim.Length + 3).Insert(nameIndex, vbCrLf)
            '- tempName.Length                                                                      '+3         .Trim.Insert(nameIndex, "").Trim
            txtDatabase.Text = txtDatabase.Text.Remove(nameIndex, tempName.Length + tempGrade.Trim.Length + 4).Trim
            ' txtDatabase.Text.Remove(1, )
            txtGrade.Text = Nothing
            txtStudentName.Text = Nothing
            'txtDatabase.Text += " "
            reloadStudents()
        Else
            'MsgBox("Safe")
        End If

    End Sub
End Class