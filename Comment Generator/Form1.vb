Imports System.IO
Imports System.Collections
Imports System.Text.RegularExpressions
Imports System.Xml
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Public Class Form1
    Dim sr As StreamReader
    Dim gradeLevel As Integer ' 4, 3 ,2 ,1
    Dim average As Double
    Dim failComments As String = My.Resources.failComments
    Dim random As New Random
    Dim tempPraiseOne, tempPraiseTwo, tempPraiseThree, tempPraiseFour As String
    Dim tempCriticismOne, tempCriticismTwo, tempCriticismThree, tempCriticismFour As String
    Dim tempPraiseforUnitOne, tempPraiseforUnitTwo, tempPraiseforUnitThree, tempPraiseforUnitFour, tempPraiseforUnitFive, tempPraiseforUnitSix, tempPraiseforUnitSeven, tempPraiseforUnitEight, tempPraiseforUnitNine, tempPraiseforUnitTen As String
    Dim tempCriticismforUnitOne, tempCriticismforUnitTwo, tempCriticismforUnitThree, tempCriticismforUnitFour, tempCriticismforUnitFive, tempCriticismforUnitSix, tempCriticismforUnitSeven, tempCriticismforUnitEight, tempCriticismforUnitNine, tempCriticismforUnitTen As String
    Dim selectedStudent As String
    Dim unitComments As ArrayList
    Dim thesaurus = New NHunspell.MyThes("th_en_US_new.dat")
    Dim fileURL As String
    Dim randNumFail As Integer
    Dim randNumAlmostFail As Integer
    Dim randNumSuccess As Integer
    Dim randNumAlmostSuccess As Integer
    Dim studentPickedFromLIST As Integer = -1
    Dim improvingStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim goodUnderstandingStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim classTimeStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim greatListenerStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim distractingStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim needsHelpStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim notPayingAttentionStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim lateAssignmentsStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitOneStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitTwoStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitThreeStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitFourStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitFiveStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitSixStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitSevenStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitEightStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitNineStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim praiseForUnitTenStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitOneStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitTwoStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitThreeStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitFourStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitFiveStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitSixStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitSevenStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitEightStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitNineStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim criticismForUnitTenStudentsInList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim startingIndexes As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim endingIndexes As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim studentsInPraiseOne, studentsInPraiseTwo, studentsInPraiseThree, studentsInPraiseFour, studentsInPraiseFive, studentsInPraiseSix, studentsInPraiseSeven, studentsInPraiseEight, studentsInPraiseNine, studentsInPraiseTen As ArrayList
    Dim studentsInCriticismOne, studentsInCriticismTwo, studentsInCriticismThree, studentsInCriticismFour, studentsInCriticismFive, studentsInCriticismSix, studentsInCriticismSeven, studentsInCriticismEight, studentsInCriticismNine, studentsInCriticismTen As List(Of String)
    Dim defaultText = "Please Choose a Student From the List to the Left after Importing a database from above the list."
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        OFDialog.FileName = ""
        OFDialog.Title = "Import Student Database - Comment Generator"
        OFDialog.DefaultExt = "txt"
        OFDialog.Filter = "Student Database Text Files|*.txt"
        OFDialog.ShowDialog()

    End Sub

    Private Sub opnFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFDialog.FileOk
        Try
            Dim gradestotal As Integer
            Dim numOfStudents As Integer
            lstStudentNames.Items.Clear()
            Dim numOfLines As Integer = File.ReadAllLines(OFDialog.FileName).Length
            fileURL = OFDialog.FileName
            sr = New StreamReader(OFDialog.FileName)
            Dim lines() As String = System.IO.File.ReadAllLines(OFDialog.FileName)
            For i As Integer = 0 To numOfLines - 1
                lstStudentNames.Items.Add(lines(i))
                i += 1
            Next
            For i As Integer = 1 To numOfLines - 1
                gradestotal += lines(i)
                numOfStudents += 1
                i += 1
            Next
            average = gradestotal / numOfStudents
            txtComment.Text = defaultText
            sr.Close()
        Catch ex As Exception
            ' MsgBox("The file specified could Not be opened." & vbNewLine & "Error message:" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.OK, "File Could Not Be Opened!")
        End Try

    End Sub

    Private Sub lstStudentNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudentNames.SelectedIndexChanged
        Try
            sr = New StreamReader(OFDialog.FileName)
            Dim selectedName As String = lstStudentNames.SelectedItem.ToString
            Dim extraIndex As Integer
            Dim gradesFile As String = sr.ReadToEnd
            Dim found As MatchCollection = Regex.Matches(gradesFile, "\b" & selectedName & "\b")

            If found.Count > 0 Then
                For Each f In found
                    Console.WriteLine("'{0}' found at position {1} in given testString.", f.Value, f.Index)
                    extraIndex = f.Index

                Next
            Else
                Console.WriteLine("No matches in given testString.")
                extraIndex = gradesFile.IndexOf(selectedName)
            End If
            Dim gradeIndex As Integer = extraIndex + selectedName.Length + 2
            Dim grade As String = gradesFile.Substring(gradeIndex, 3).Trim
            lblTitle.Text = "Currently Selected: " & selectedName & ", Grade: " & grade & " %"
            selectedStudent = lstStudentNames.SelectedItem.ToString

            If lstStudentNames.SelectedIndex <> studentPickedFromLIST Then

                If Not txtComment.Text.Contains(selectedName) Then

                    studentPickedFromLIST = lstStudentNames.SelectedIndex
                    If grade >= 86 Then
                        gradeLevel = 4

                        If txtComment.Text = defaultText Then
                            txtComment.Text = selectedName & vbCrLf & successfulComment(selectedName, grade) & vbCrLf
                        Else
                            txtComment.Text += vbCrLf & selectedName & vbCrLf & successfulComment(selectedName, grade) & vbCrLf
                        End If

                        grpCriticism.Enabled = True
                        grpPraises.Enabled = True
                        grpCriticismUnits.Enabled = True
                        grpUnitPraise.Enabled = True
                    ElseIf grade >= 60 AndAlso grade <= 85 Then
                        gradeLevel = 3
                        If txtComment.Text = defaultText Then
                            txtComment.Text = selectedName & vbCrLf & almostSuccessfulComment(selectedName, grade) & vbCrLf
                        Else
                            txtComment.Text += vbCrLf & selectedName & vbCrLf & almostSuccessfulComment(selectedName, grade) & vbCrLf
                        End If

                        grpCriticism.Enabled = True
                        grpPraises.Enabled = True
                        grpCriticismUnits.Enabled = True
                        grpUnitPraise.Enabled = True
                    ElseIf grade >= 50 AndAlso grade <= 59 Then

                        gradeLevel = 2
                        If txtComment.Text = defaultText Then
                            txtComment.Text = selectedName & vbCrLf & almostFailComment(selectedName, grade) & vbCrLf
                        Else
                            txtComment.Text += vbCrLf & selectedName & vbCrLf & almostFailComment(selectedName, grade) & vbCrLf
                        End If

                        grpCriticism.Enabled = True
                        grpPraises.Enabled = True
                        grpCriticismUnits.Enabled = True
                        grpUnitPraise.Enabled = True
                    ElseIf grade < 50 Then

                        gradeLevel = 1
                        If txtComment.Text = defaultText Then
                            txtComment.Text = selectedName & vbCrLf & failingComment(selectedName, grade) & vbCrLf
                        Else
                            txtComment.Text += vbCrLf & selectedName & vbCrLf & failingComment(selectedName, grade) & vbCrLf
                        End If

                        grpCriticism.Enabled = True
                        grpPraises.Enabled = True
                        grpCriticismUnits.Enabled = True
                        grpUnitPraise.Enabled = True
                    Else
                        gradeLevel = -1

                    End If
                End If
                txtComment.DeselectAll()
                Dim startIndex As Integer = txtComment.Text.IndexOf(selectedName)
                txtComment.SelectionStart = startIndex
                Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(selectedName) + selectedName.Length + 4)
                txtComment.SelectionLength = endIndex - startIndex
                startingIndexes(lstStudentNames.SelectedItem.ToString) = txtComment.Text.IndexOf(selectedName)
                endingIndexes(lstStudentNames.SelectedItem.ToString) = endIndex
                Console.WriteLine("Start Index: " & txtComment.Text.IndexOf(selectedName) & "End Index: " & endIndex)
                txtComment.ScrollToCaret()

            End If

            resetBoxes()
            If improvingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseOne.Checked = True

            Else
                chkPraiseOne.Checked = False
            End If
            If goodUnderstandingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseTwo.Checked = True

            Else
                chkPraiseTwo.Checked = False
            End If

            If classTimeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseThree.Checked = True

            Else
                chkPraiseThree.Checked = False
            End If

            If greatListenerStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseFour.Checked = True

            Else
                chkPraiseFour.Checked = False
            End If

            If distractingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismOne.Checked = True

            Else
                chkCriticismOne.Checked = False
            End If

            If needsHelpStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismTwo.Checked = True

            Else
                chkCriticismTwo.Checked = False
            End If

            If notPayingAttentionStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismThree.Checked = True

            Else
                chkCriticismThree.Checked = False
            End If

            If lateAssignmentsStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismFour.Checked = True

            Else
                chkCriticismFour.Checked = False
            End If

            If praiseForUnitOneStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitOne.Checked = True

            Else
                chkPraiseUnitOne.Checked = False
            End If

            If praiseForUnitTwoStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitTwo.Checked = True

            Else
                chkPraiseUnitTwo.Checked = False
            End If

            If praiseForUnitThreeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitThree.Checked = True

            Else
                chkPraiseUnitThree.Checked = False
            End If

            If praiseForUnitFourStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitFour.Checked = True

            Else
                chkPraiseUnitFour.Checked = False
            End If

            If praiseForUnitFiveStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitFive.Checked = True

            Else
                chkPraiseUnitFive.Checked = False
            End If

            If praiseForUnitSixStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitSix.Checked = True

            Else
                chkPraiseUnitSix.Checked = False
            End If

            If praiseForUnitSevenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitSeven.Checked = True

            Else
                chkPraiseUnitSeven.Checked = False
            End If

            If praiseForUnitEightStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitEight.Checked = True

            Else
                chkPraiseUnitEight.Checked = False
            End If

            If praiseForUnitNineStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitNine.Checked = True

            Else
                chkPraiseUnitNine.Checked = False
            End If

            If praiseForUnitTenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkPraiseUnitTen.Checked = True

            Else
                chkPraiseUnitTen.Checked = False
            End If

            If criticismForUnitOneStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitOne.Checked = True

            Else
                chkCriticismUnitOne.Checked = False
            End If

            If criticismForUnitTwoStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitTwo.Checked = True

            Else
                chkCriticismUnitTwo.Checked = False
            End If

            If criticismForUnitThreeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitThree.Checked = True

            Else
                chkCriticismUnitThree.Checked = False
            End If

            If criticismForUnitFourStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitFour.Checked = True

            Else
                chkCriticismUnitFour.Checked = False
            End If

            If criticismForUnitFiveStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitFive.Checked = True

            Else
                chkCriticismUnitFive.Checked = False
            End If

            If criticismForUnitSixStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitSix.Checked = True

            Else
                chkCriticismUnitSix.Checked = False
            End If

            If criticismForUnitSevenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitSeven.Checked = True

            Else
                chkCriticismUnitSeven.Checked = False
            End If

            If criticismForUnitEightStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitEight.Checked = True

            Else
                chkCriticismUnitEight.Checked = False
            End If

            If criticismForUnitNineStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitNine.Checked = True

            Else
                chkCriticismUnitNine.Checked = False
            End If

            If criticismForUnitTenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                chkCriticismUnitTen.Checked = True

            Else
                chkCriticismUnitTen.Checked = False
            End If

        Catch ex As Exception
            MsgBox("Please choose a name from the list. If error persists, import your students again.")

        End Try

    End Sub
    Function failingComment(ByVal studentName As String, ByVal studentGrade As String)
        Randomize()
        Dim comment As String
        Dim failCommentLines() As String = My.Resources.failComments.Split(vbCrLf)
        Dim lineCount As Integer = My.Resources.failComments.Split(vbCrLf).Length
        Dim rNum As Integer = random.Next(1, lineCount)
        If rNum = randNumFail Then
            comment = failCommentLines(rNum).Replace("#student", studentName).Replace("#grade", studentGrade).Replace("#course", My.Settings.lastSavedCourseName)
        Else
            comment = failCommentLines(rNum).Replace("#student", studentName).Replace("#grade", studentGrade).Replace("#course", My.Settings.lastSavedCourseName)
            randNumFail = rNum
        End If
        Return comment

    End Function
    Function successfulComment(ByVal studentName As String, ByVal studentGrade As String)
        Randomize()
        Dim comment As String
        Dim successCommentLines() As String = My.Resources.successComments.Split(vbCrLf)
        Dim lineCount As Integer = My.Resources.successComments.Split(vbCrLf).Length
        Dim rNum As Integer = random.Next(1, lineCount)
        If rNum = randNumSuccess Then
            comment = successCommentLines(rNum).Replace("#student", studentName).Replace("#grade", studentGrade).Replace("#course", My.Settings.lastSavedCourseName)
        Else
            comment = successCommentLines(rNum).Replace("#student", studentName).Replace("#grade", studentGrade).Replace("#course", My.Settings.lastSavedCourseName)
            randNumSuccess = rNum
        End If
        Return comment
    End Function
    Function almostSuccessfulComment(ByVal studentName As String, ByVal studentGrade As String)
        Randomize()
        Dim comment As String
        Dim almostSuccessCommentLines() As String = My.Resources.almostSuccessComments.Split(vbCrLf)
        Dim lineCount As Integer = My.Resources.almostSuccessComments.Split(vbCrLf).Length
        Dim rNum As Integer = random.Next(1, lineCount)
        If rNum = randNumAlmostSuccess Then
            comment = almostSuccessCommentLines(rNum).Replace("#student", studentName).Replace("#grade", studentGrade).Replace("#course", My.Settings.lastSavedCourseName)
        Else
            comment = almostSuccessCommentLines(rNum).Replace("#student", studentName).Replace("#grade", studentGrade).Replace("#course", My.Settings.lastSavedCourseName)
            randNumAlmostSuccess = rNum
        End If
        Return comment
    End Function
    Function almostFailComment(ByVal studentName As String, ByVal studentGrade As String)
        Randomize()
        Dim comment As String
        Dim almostFailCommentLines() As String = My.Resources.almostFailComments.Split(vbCrLf)
        Dim lineCount As Integer = My.Resources.almostFailComments.Split(vbCrLf).Length
        Dim rNum As Integer = random.Next(1, lineCount)
        If rNum = randNumAlmostFail Then
            comment = almostFailCommentLines(rNum).Replace("#student", studentName).Replace("#grade", studentGrade).Replace("#course", My.Settings.lastSavedCourseName)
        Else
            comment = almostFailCommentLines(rNum).Replace("#student", studentName).Replace("#grade", studentGrade).Replace("#course", My.Settings.lastSavedCourseName)
            randNumAlmostFail = rNum
        End If
        Return comment
    End Function
    Function addPraise(praiseKeyword As String, praiseNum As Integer)
        Randomize()
        Dim praise As String
        Dim startIndex As Integer = txtComment.Text.IndexOf(lstStudentNames.SelectedItem.ToString) + +lstStudentNames.SelectedItem.ToString.Length + 3
        Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(lstStudentNames.SelectedItem.ToString) + lstStudentNames.SelectedItem.Length + 4)
        Dim raw_comment = txtComment.Text.Substring(startIndex, endIndex - startIndex)
        Dim endOfSentence() As String = raw_comment.Split(". ")
        Dim sentenceCount As Integer = raw_comment.Split(". ").Length
        Dim rNum As Integer = random.Next(1, sentenceCount - 2)
        Dim index As Integer = txtComment.Text.IndexOf(endOfSentence(rNum))
        praise = Space(1) & choosePraise(praiseNum) & Space(1)
        txtComment.Text = txtComment.Text.Insert(index, praise)

        If praiseNum = 1 Then
            tempPraiseOne = praise

        ElseIf praiseNum = 2 Then
            tempPraiseTwo = praise
        ElseIf praiseNum = 3 Then
            tempPraiseThree = praise
        ElseIf praiseNum = 4 Then
            tempPraiseFour = praise
        End If

        Return praise
    End Function
    Function getStringData(dataString() As String)
        Dim stringLength As Integer = dataString.Length
        Dim newString As String
        For i As Integer = 0 To stringLength - 1
            If newString = "" Then
                newString += dataString(i)
            Else
                newString += "," & dataString(i)
            End If
        Next
        Return newString
    End Function
    Function choosePraise(praiseNum As Integer)
        Dim praisesFile As String = My.Resources.praises
        Dim praiseSection As String
        Dim praiseOneStartIndex As Integer = praisesFile.IndexOf("---improving---")
        Dim praiseOneEndIndex As Integer = praisesFile.IndexOf("---end improving---")
        Dim praiseTwoStartIndex As Integer = praisesFile.IndexOf("---good understanding---")
        Dim praiseTwoEndIndex As Integer = praisesFile.IndexOf("---end good understanding---")
        Dim praiseThreeStartIndex As Integer = praisesFile.IndexOf("---uses classtime well---")
        Dim praiseThreeEndIndex As Integer = praisesFile.LastIndexOf("---end uses classtime well---")
        Dim praiseFourStartIndex As Integer = praisesFile.IndexOf("---great listener---")
        Dim praiseFourEndIndex As Integer = praisesFile.LastIndexOf("---end great listener---")

        Dim improvingPraises As String = praisesFile.Substring(praiseOneStartIndex + 15, praiseOneEndIndex - 15)
        Dim goodUnderstandingPraises As String = praisesFile.Substring(praiseTwoStartIndex + 24, praiseTwoEndIndex - praiseTwoStartIndex - 24)
        Dim usesClasstimeWellPraises As String = praisesFile.Substring(praiseThreeStartIndex + 25, praiseThreeEndIndex - praiseThreeStartIndex - 25)
        Dim greatListenerPraises As String = praisesFile.Substring(praiseFourStartIndex + 20, praiseFourEndIndex - praiseFourStartIndex - 20)

        If praiseNum = 1 Then
            Randomize()
            Dim praise As String
            Dim improvingPraisesSection() As String = improvingPraises.Split(vbCrLf)
            Dim lineCount As Integer = improvingPraises.Split(vbCrLf).Length
            Dim rNum As Integer = random.Next(1, lineCount - 1)
            praise = improvingPraisesSection(rNum).Replace("#student", selectedStudent)
            addUserstoList(0, 1, praise)
            Return praise
        ElseIf praiseNum = 2 Then
            Randomize()
            Dim praise As String
            Dim goodUnderstandingPraisesSection() As String = goodUnderstandingPraises.Split(vbCrLf)
            Dim lineCount As Integer = goodUnderstandingPraises.Split(vbCrLf).Length
            Dim rNum As Integer = random.Next(1, lineCount - 1)
            praise = goodUnderstandingPraisesSection(rNum).Replace("#student", selectedStudent)
            addUserstoList(0, 2, praise)
            Return praise
        ElseIf praiseNum = 3 Then
            Randomize()
            Dim praise As String
            Dim usesClasstimeWellPraisesSection() As String = usesClasstimeWellPraises.Split(vbCrLf)
            Dim lineCount As Integer = usesClasstimeWellPraises.Split(vbCrLf).Length
            Dim rNum As Integer = random.Next(1, lineCount - 1)
            praise = usesClasstimeWellPraisesSection(rNum).Replace("#student", selectedStudent)
            addUserstoList(0, 3, praise)
            Return praise
        ElseIf praiseNum = 4 Then
            Randomize()
            Dim praise As String
            Dim greatListenerPraisesSection() As String = greatListenerPraises.Split(vbCrLf)
            Dim lineCount As Integer = greatListenerPraises.Split(vbCrLf).Length
            Dim rNum As Integer = random.Next(1, lineCount - 1)
            praise = greatListenerPraisesSection(rNum).Replace("#student", selectedStudent)
            addUserstoList(0, 4, praise)
            Return praise
        End If

        Return ""
    End Function
    Function addUserstoList(category As Integer, categoryNum As Integer, categorySentence As String)

        If category = 0 Then
            'Praises

            If categoryNum = 1 Then
                If Not improvingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    improvingStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Improving")
                End If
            ElseIf categoryNum = 2 Then
                If Not goodUnderstandingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    goodUnderstandingStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Good Understanding")
                End If
            ElseIf categoryNum = 3 Then
                If Not classTimeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    classTimeStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to ClassTime Spent Well")
                End If
            ElseIf categoryNum = 4 Then
                If Not greatListenerStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    greatListenerStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Great Listener")
                End If
            End If
        ElseIf category = 1 Then
            'Criticism
            If categoryNum = 1 Then
                If Not distractingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    distractingStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Distracting")
                End If
            ElseIf categoryNum = 2 Then
                If Not needsHelpStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    needsHelpStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Needs Help")
                End If
            ElseIf categoryNum = 3 Then
                If Not notPayingAttentionStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    notPayingAttentionStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Not Payin Attention")
                End If
            ElseIf categoryNum = 4 Then
                If Not lateAssignmentsStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    lateAssignmentsStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to lateAssignment")
                End If
            End If
        ElseIf category = 2 Then
            ' Praise for Units
            If categoryNum = 1 Then
                If Not praiseForUnitOneStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitOneStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 2 Then
                If Not praiseForUnitTwoStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitTwoStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 3 Then
                If Not praiseForUnitThreeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitThreeStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 4 Then
                If Not praiseForUnitFourStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitFourStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 5 Then
                If Not praiseForUnitFiveStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitFiveStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 6 Then
                If Not praiseForUnitSixStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitSixStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 7 Then
                If Not praiseForUnitSevenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitSevenStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 8 Then
                If Not praiseForUnitEightStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitEightStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 9 Then
                If Not praiseForUnitNineStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitNineStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            ElseIf categoryNum = 10 Then
                If Not praiseForUnitTenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    praiseForUnitTenStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " Praise")
                End If
            End If
        ElseIf category = 3 Then
            ' Criticism for Units
            If categoryNum = 1 Then
                If Not criticismForUnitOneStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitOneStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 2 Then
                If Not criticismForUnitTwoStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitTwoStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 3 Then
                If Not criticismForUnitThreeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitThreeStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 4 Then
                If Not criticismForUnitFourStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitFourStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 5 Then
                If Not criticismForUnitFiveStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitFiveStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 6 Then
                If Not criticismForUnitSixStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitSixStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 7 Then
                If Not criticismForUnitSevenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitSevenStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 8 Then
                If Not criticismForUnitEightStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitEightStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 9 Then
                If Not criticismForUnitNineStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitNineStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            ElseIf categoryNum = 10 Then
                If Not criticismForUnitTenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
                    criticismForUnitTenStudentsInList(lstStudentNames.SelectedItem.ToString) = categorySentence
                    Console.WriteLine("Adding " & lstStudentNames.SelectedItem.ToString & " to Unit " & categoryNum & " criticism")
                End If
            End If
        End If

    End Function
    Function chooseCriticism(criticismNum As Integer)
        Dim criticismFile As String = My.Resources.criticisms
        Dim criticismSection As String
        Dim praiseOneStartIndex As Integer = criticismFile.IndexOf("---distracting---")
        Dim praiseOneEndIndex As Integer = criticismFile.IndexOf("---end distracting---")
        Dim praiseTwoStartIndex As Integer = criticismFile.IndexOf("---seekHelp---")
        Dim praiseTwoEndIndex As Integer = criticismFile.IndexOf("---end seekHelp---")
        Dim praiseThreeStartIndex As Integer = criticismFile.IndexOf("---payAttention---")
        Dim praiseThreeEndIndex As Integer = criticismFile.LastIndexOf("---end payAttention---")
        Dim praiseFourStartIndex As Integer = criticismFile.IndexOf("---lateAssignments---")
        Dim praiseFourEndIndex As Integer = criticismFile.LastIndexOf("---end lateAssignments---")

        Dim distracting As String = criticismFile.Substring(praiseOneStartIndex + 17, praiseOneEndIndex - 17)
        Dim seekHelp As String = criticismFile.Substring(praiseTwoStartIndex + 15, praiseTwoEndIndex - praiseTwoStartIndex - 15)
        Dim payAttention As String = criticismFile.Substring(praiseThreeStartIndex + 18, praiseThreeEndIndex - praiseThreeStartIndex - 18)
        Dim lateAssignments As String = criticismFile.Substring(praiseFourStartIndex + 21, praiseFourEndIndex - praiseFourStartIndex - 21)

        If criticismNum = 1 Then
            Randomize()
            Dim criticism As String
            Dim distractingSection() As String = distracting.Split(vbCrLf)
            Dim lineCount As Integer = distracting.Split(vbCrLf).Length
            Dim rNum As Integer = random.Next(1, lineCount - 1)
            criticism = distractingSection(rNum).Replace("#student", selectedStudent)
            addUserstoList(1, 1, criticism)
            Return criticism
        ElseIf criticismNum = 2 Then
            Randomize()
            Dim criticism As String
            Dim seekHelpSection() As String = seekHelp.Split(vbCrLf)
            Dim lineCount As Integer = seekHelp.Split(vbCrLf).Length
            Dim rNum As Integer = random.Next(1, lineCount - 1)
            criticism = seekHelpSection(rNum).Replace("#student", selectedStudent)
            addUserstoList(1, 2, criticism)
            Return criticism
        ElseIf criticismNum = 3 Then
            Randomize()
            Dim criticism As String
            Dim payAttentionSection() As String = payAttention.Split(vbCrLf)
            Dim lineCount As Integer = payAttention.Split(vbCrLf).Length
            Dim rNum As Integer = random.Next(1, lineCount - 1)
            criticism = payAttentionSection(rNum).Replace("#student", selectedStudent)
            addUserstoList(1, 3, criticism)
            Return criticism
        ElseIf criticismNum = 4 Then
            Randomize()
            Dim criticism As String
            Dim lateAssignmentsSection() As String = lateAssignments.Split(vbCrLf)
            Dim lineCount As Integer = lateAssignments.Split(vbCrLf).Length
            Dim rNum As Integer = random.Next(1, lineCount - 1)
            criticism = lateAssignmentsSection(rNum).Replace("#student", selectedStudent)
            addUserstoList(1, 4, criticism)
            Return criticism
        End If
        Return ""
    End Function
    Function addCriticism(criticismKeyword As String, criticismNum As Integer)
        Randomize()
        Dim criticism As String
        Dim startIndex As Integer = txtComment.Text.IndexOf(lstStudentNames.SelectedItem.ToString) + +lstStudentNames.SelectedItem.ToString.Length + 3
        Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(lstStudentNames.SelectedItem.ToString) + lstStudentNames.SelectedItem.Length + 4)
        Dim raw_comment = txtComment.Text.Substring(startIndex, endIndex - startIndex)
        Dim endOfSentence() As String = raw_comment.Split(". ")
        Dim sentenceCount As Integer = raw_comment.Split(". ").Length
        Dim rNum As Integer = random.Next(1, sentenceCount - 1)
        Dim index As Integer = txtComment.Text.IndexOf(endOfSentence(rNum))
        criticism = Space(1) & chooseCriticism(criticismNum) & Space(1)
        txtComment.Text = txtComment.Text.Insert(index, criticism)

        If criticismNum = 1 Then
            tempCriticismOne = criticism
        ElseIf criticismNum = 2 Then
            tempCriticismTwo = criticism
        ElseIf criticismNum = 3 Then
            tempCriticismThree = criticism
        ElseIf criticismNum = 4 Then
            tempCriticismFour = criticism
        End If

        Return criticism
    End Function
    Function resetBoxes()
        chkCriticismOne.Checked = False
        chkCriticismTwo.Checked = False
        chkCriticismThree.Checked = False
        chkCriticismFour.Checked = False
        chkPraiseOne.Checked = False
        chkPraiseTwo.Checked = False
        chkPraiseThree.Checked = False
        chkPraiseFour.Checked = False
        chkPraiseUnitOne.Checked = False
        chkPraiseUnitTwo.Checked = False
        chkPraiseUnitThree.Checked = False
        chkPraiseUnitFour.Checked = False
        chkPraiseUnitFive.Checked = False
        chkPraiseUnitSix.Checked = False
        chkPraiseUnitSeven.Checked = False
        chkPraiseUnitEight.Checked = False
        chkPraiseUnitNine.Checked = False
        chkPraiseUnitTen.Checked = False
        chkCriticismUnitOne.Checked = False
        chkCriticismUnitTwo.Checked = False
        chkCriticismUnitThree.Checked = False
        chkCriticismUnitFour.Checked = False
        chkCriticismUnitFive.Checked = False
        chkCriticismUnitSix.Checked = False
        chkCriticismUnitSeven.Checked = False
        chkCriticismUnitEight.Checked = False
        chkCriticismUnitNine.Checked = False
        chkCriticismUnitTen.Checked = False
        chkPraiseUnitOne.Enabled = True
        chkPraiseUnitTwo.Enabled = True
        chkPraiseUnitThree.Enabled = True
        chkPraiseUnitFour.Enabled = True
        chkPraiseUnitFive.Enabled = True
        chkPraiseUnitSix.Enabled = True
        chkPraiseUnitSeven.Enabled = True
        chkPraiseUnitEight.Enabled = True
        chkPraiseUnitNine.Enabled = True
        chkPraiseUnitTen.Enabled = True
        chkCriticismUnitOne.Enabled = True
        chkCriticismUnitTwo.Enabled = True
        chkCriticismUnitThree.Enabled = True
        chkCriticismUnitFour.Enabled = True
        chkCriticismUnitFive.Enabled = True
        chkCriticismUnitSix.Enabled = True
        chkCriticismUnitSeven.Enabled = True
        chkCriticismUnitEight.Enabled = True
        chkCriticismUnitNine.Enabled = True
        chkCriticismUnitTen.Enabled = True
    End Function
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtComment.ReadOnly = False Then
            txtComment.ReadOnly = True
            btnEdit.Text = "Edit"
        Else
            txtComment.ReadOnly = False
            btnEdit.Text = "Stop Edit"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SFDialog.FileName = "Comments" & " " & Date.Now.Hour & "_" & Date.Now.Minute & "_" & Date.Now.Second & "_" & Date.Now.Month & "_" & Date.Now.Day & "_" & Date.Now.Year
        SFDialog.Title = "Save Student Comments - Comment Generator"
        SFDialog.DefaultExt = "txt"
        SFDialog.Filter = "Student Database Text Files|*.txt"
        SFDialog.ShowDialog()
    End Sub

    Private Sub SFDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SFDialog.FileOk
        Dim objWriter As New System.IO.StreamWriter(SFDialog.FileName)

        objWriter.Write(txtComment.Text)
        objWriter.Close()
    End Sub

    Private Sub lblHelp2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblHelp2.LinkClicked
        MsgBox("How to Add Prasies")
    End Sub

    Private Sub lblHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblHelp.LinkClicked
        MsgBox("How to Add Criticism")
    End Sub

    Private Sub btnDoSomething_Click(sender As Object, e As EventArgs) Handles btnClassAverage.Click
        MsgBox("Class Average is " & Format(average, "0.00") & "%")
    End Sub

    Private Sub btnDoSomething_Click_1(sender As Object, e As EventArgs) Handles btnSpecifyCourseName.Click
        Dim courseName As String = InputBox("What is the name of the course these comments are for?", "Course Name", My.Settings.lastSavedCourseName)

        If Not courseName = "" Then
            My.Settings.lastSavedCourseName = courseName
            My.Settings.Save()
            MsgBox("Course Name Updated.")
        End If

    End Sub
    Private Sub btnCreateDB_Click(sender As Object, e As EventArgs) Handles btnCreateDB.Click
        makeDB.ShowDialog()
    End Sub
    Private Sub tsmInstructions_Click(sender As Object, e As EventArgs) Handles tsmInstructions.Click
        MsgBox("To use this feature, find a suitable spot in the comments textbox where you want to include your comment about a unit. Place the arrow cursoe there and then right click and show praise or criticism towards a unit.")
    End Sub

    Private Sub btnEditDatabase_Click(sender As Object, e As EventArgs) Handles btnEditDatabase.Click
        Try
            sr.Close()
        Catch ex As Exception

        End Try
        editDB.ShowDialog()

    End Sub

    Private Sub btnAddUnits_Click(sender As Object, e As EventArgs) Handles btnAddUnits.Click

        Dim changeUnits As MsgBoxResult = MsgBox("Your current Subjects are:" & vbCrLf & getUnits() & "Would You Like to resubmit the Units for this course?", MsgBoxStyle.YesNo, "Resubmit Units?")

        If changeUnits = MsgBoxResult.Yes Then
            Dim inputUnits As String = InputBox("Which units are a part of this course? Type :f to finish adding units.", "Add Units")
            Dim tempSavedCourseUnits As String = My.Settings.lastSavedCourseUnits
            My.Settings.lastSavedCourseUnits = ""
            Do While inputUnits <> ":f"
                If inputUnits = "" Then
                    inputUnits = InputBox("Which units are a part of this course? Type :f to finish adding units.", "Add Units")
                Else

                    If My.Settings.lastSavedCourseUnits.Trim = "" Then
                        My.Settings.lastSavedCourseUnits = inputUnits
                        inputUnits = InputBox("Which units are a part of this course? Type :f to finish adding units.", "Add Units")
                    Else
                        My.Settings.lastSavedCourseUnits += "," & inputUnits
                        inputUnits = InputBox("Which units are a part of this course? Type :f to finish adding units.", "Add Units")
                    End If

                End If

            Loop

            If My.Settings.lastSavedCourseUnits.Trim = "" Then
                My.Settings.lastSavedCourseUnits = tempSavedCourseUnits
            End If

            My.Settings.Save()
            tsmPraise.DropDownItems.Clear()
            tsmCriticism.DropDownItems.Clear()
            Dim units() As String = My.Settings.lastSavedCourseUnits.Split(",")
            Dim numOfUnits As Integer = My.Settings.lastSavedCourseUnits.Split(",").Length
            Dim unitsM As String
            For i As Integer = 0 To numOfUnits - 1
                If Not units(i) = "" Then
                    tsmPraise.DropDownItems.Add(units(i))
                    tsmCriticism.DropDownItems.Add(units(i))
                Else
                    tsmPraise.DropDownItems.Add("No Units Found.")
                    tsmPraise.DropDownItems.Add("Please Add them from the ")
                    tsmPraise.DropDownItems.Add("options button found below.")
                    tsmCriticism.DropDownItems.Add("No Units Found.")
                    tsmCriticism.DropDownItems.Add("Please Add them from the ")
                    tsmCriticism.DropDownItems.Add("options button found below.")
                End If
            Next

            Try
                chkPraiseUnitOne.Text = units(0)
                chkCriticismUnitOne.Text = units(0)
                chkPraiseUnitOne.Visible = True
                chkCriticismUnitOne.Visible = True
            Catch ex As Exception
                chkPraiseUnitOne.Visible = False
                chkCriticismUnitOne.Visible = False
            End Try
            Try
                chkPraiseUnitTwo.Text = units(1)
                chkCriticismUnitTwo.Text = units(1)
                chkPraiseUnitTwo.Visible = True
                chkCriticismUnitTwo.Visible = True
            Catch ex As Exception
                chkPraiseUnitTwo.Visible = False
                chkCriticismUnitTwo.Visible = False
            End Try

            Try
                chkPraiseUnitThree.Text = units(2)
                chkCriticismUnitThree.Text = units(2)
                chkPraiseUnitThree.Visible = True
                chkCriticismUnitThree.Visible = True

            Catch ex As Exception
                chkPraiseUnitThree.Visible = False
                chkCriticismUnitThree.Visible = False
            End Try

            Try
                chkPraiseUnitFour.Text = units(3)
                chkCriticismUnitFour.Text = units(3)
                chkPraiseUnitFour.Visible = True
                chkCriticismUnitFour.Visible = True
            Catch ex As Exception
                chkPraiseUnitFour.Visible = False
                chkCriticismUnitFour.Visible = False
            End Try

            Try
                chkPraiseUnitFive.Text = units(4)
                chkCriticismUnitFive.Text = units(4)
                chkPraiseUnitFive.Visible = True
                chkCriticismUnitFive.Visible = True
            Catch ex As Exception
                chkPraiseUnitFive.Visible = False
                chkCriticismUnitFive.Visible = False
            End Try

            Try
                chkPraiseUnitSix.Text = units(5)
                chkCriticismUnitSix.Text = units(5)
                chkPraiseUnitSix.Visible = True
                chkCriticismUnitSix.Visible = True
            Catch ex As Exception
                chkPraiseUnitSix.Visible = False
                chkCriticismUnitSix.Visible = False
            End Try

            Try
                chkPraiseUnitSeven.Text = units(6)
                chkCriticismUnitSeven.Text = units(6)
                chkPraiseUnitSeven.Visible = True
                chkCriticismUnitSeven.Visible = True
            Catch ex As Exception
                chkPraiseUnitSeven.Visible = False
                chkCriticismUnitSeven.Visible = False
            End Try

            Try
                chkPraiseUnitEight.Text = units(7)
                chkCriticismUnitEight.Text = units(7)
                chkPraiseUnitEight.Visible = True
                chkCriticismUnitEight.Visible = True
            Catch ex As Exception
                chkPraiseUnitEight.Visible = False
                chkCriticismUnitEight.Visible = False
            End Try

            Try
                chkPraiseUnitNine.Text = units(8)
                chkCriticismUnitNine.Text = units(8)
                chkPraiseUnitNine.Visible = True
                chkCriticismUnitNine.Visible = True
            Catch ex As Exception
                chkPraiseUnitNine.Visible = False
                chkCriticismUnitNine.Visible = False
            End Try

            Try
                chkPraiseUnitTen.Text = units(9)
                chkCriticismUnitTen.Text = units(9)
                chkPraiseUnitTen.Visible = True
                chkCriticismUnitTen.Visible = True
            Catch ex As Exception
                chkPraiseUnitTen.Visible = False
                chkCriticismUnitTen.Visible = False
            End Try

            MsgBox("Units Updated")
        End If
    End Sub
    Function getUnits()
        Dim units() As String = My.Settings.lastSavedCourseUnits.Split(", ")
        Dim numOfUnits As Integer = My.Settings.lastSavedCourseUnits.Split(", ").Length
        Dim unitsM As String
        For i As Integer = 0 To numOfUnits - 1

            unitsM += (i + 1) & ". " & units(i) & vbCrLf
        Next
        Return unitsM
    End Function
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        'improvingStudentsInList("as") = "dang"
        'MsgBox(improvingStudentsInList("as"))
        'sr = New StreamReader(OFDialog.FileName)
        'For Each ch As Char In sr.ReadToEnd.ToString
        ' MessageBox.Show(ch & " = " & Asc(ch))
        ' Next ch
        '  MsgBox(sr.ReadToEnd)

        'MsgBox(fileURL)

        '  For Each value As String In studentsInPraiseOne
        'MsgBox(value)
        ' Next
        'MsgBox(lstStudentNames.SelectedItem.ToString())
        'MsgBox(getStringData(studentsInPraiseOne))

        'For Each student As KeyValuePair(Of String, String) In greatListenerStudentsInList
        'Console.WriteLine("Key: {0}, Value: {1}", student.Key, student.Value)
        '  MsgBox("Key: {0}, Value: {1}", student.Key, student.Value)
        ''Next

        'MsgBox(startingIndexes.Count)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.lastSavedCourseName = String.Empty Then
            MsgBox("No Course Name Selected. Please enter the course for these comments.")
            btnSpecifyCourseName.PerformClick()
        End If

        If My.Settings.lastSavedCourseUnits = String.Empty Then
            MsgBox("No Course Units Inputted. Please enter the units for this course.")
            btnAddUnits.PerformClick()
        End If

        Dim units() As String = My.Settings.lastSavedCourseUnits.Split(", ")
        Dim numOfUnits As Integer = My.Settings.lastSavedCourseUnits.Split(", ").Length
        Dim unitsM As String
        For i As Integer = 0 To numOfUnits - 1

            If Not units(i) = "" Then
                tsmPraise.DropDownItems.Add(units(i))
                tsmCriticism.DropDownItems.Add(units(i))
            Else
                tsmPraise.DropDownItems.Add("No Units Found.")
                tsmPraise.DropDownItems.Add("Please Add them from the ")
                tsmPraise.DropDownItems.Add("options button found below.")
                tsmCriticism.DropDownItems.Add("No Units Found.")
                tsmCriticism.DropDownItems.Add("Please Add them from the ")
                tsmCriticism.DropDownItems.Add("options button found below.")
            End If

        Next

        Try
            chkPraiseUnitOne.Text = units(0)
            chkCriticismUnitOne.Text = units(0)
        Catch ex As Exception
            chkPraiseUnitOne.Visible = False
            chkCriticismUnitOne.Visible = False
        End Try
        Try
            chkPraiseUnitTwo.Text = units(1)
            chkCriticismUnitTwo.Text = units(1)
        Catch ex As Exception
            chkPraiseUnitTwo.Visible = False
            chkCriticismUnitTwo.Visible = False
        End Try

        Try
            chkPraiseUnitThree.Text = units(2)
            chkCriticismUnitThree.Text = units(2)

        Catch ex As Exception
            chkPraiseUnitThree.Visible = False
            chkCriticismUnitThree.Visible = False
        End Try

        Try
            chkPraiseUnitFour.Text = units(3)
            chkCriticismUnitFour.Text = units(3)
        Catch ex As Exception
            chkPraiseUnitFour.Visible = False
            chkCriticismUnitFour.Visible = False
        End Try

        Try
            chkPraiseUnitFive.Text = units(4)
            chkCriticismUnitFive.Text = units(4)
        Catch ex As Exception
            chkPraiseUnitFive.Visible = False
            chkCriticismUnitFive.Visible = False
        End Try

        Try
            chkPraiseUnitSix.Text = units(5)
            chkCriticismUnitSix.Text = units(5)
        Catch ex As Exception
            chkPraiseUnitSix.Visible = False
            chkCriticismUnitSix.Visible = False
        End Try

        Try
            chkPraiseUnitSeven.Text = units(6)
            chkCriticismUnitSeven.Text = units(6)
        Catch ex As Exception
            chkPraiseUnitSeven.Visible = False
            chkCriticismUnitSeven.Visible = False
        End Try

        Try
            chkPraiseUnitEight.Text = units(7)
            chkCriticismUnitEight.Text = units(7)
        Catch ex As Exception
            chkPraiseUnitEight.Visible = False
            chkCriticismUnitEight.Visible = False
        End Try

        Try
            chkPraiseUnitNine.Text = units(8)
            chkCriticismUnitNine.Text = units(8)
        Catch ex As Exception
            chkPraiseUnitNine.Visible = False
            chkCriticismUnitNine.Visible = False
        End Try
        Try
            chkPraiseUnitTen.Text = units(9)
            chkCriticismUnitTen.Text = units(9)
        Catch ex As Exception
            chkPraiseUnitTen.Visible = False
            chkCriticismUnitTen.Visible = False
        End Try
    End Sub

    Private Sub btnInsertPraises_Click(sender As Object, e As EventArgs) Handles btnInsertPraises.Click

    End Sub

    Private Sub btnCommentHistory_Click(sender As Object, e As EventArgs) Handles btnCommentHistory.Click
        ' open a new form containing a dropdown box with eveyr single time the form was open.
        ' each time the form was closed, save the form into a pdf file
        ' make the form open the pdf file into an internal pdf viewer on the form
        ' make sure to make a new file at formclosing named in the format: fileName_timestamp_lastSession.txt saved to
        ' the directory of the file.
        commentHistory.ShowDialog()
    End Sub

    Private Sub cmsComments_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsComments.Opening
        If txtComment.SelectedText = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub tsmPraise_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsmPraise.DropDownItemClicked

        Randomize()

        Dim startIndex As Integer = txtComment.SelectionStart
        Dim commentString() As String = {" You breezed through " & e.ClickedItem.ToString & " with a good understanding. ",
                                         " You worked hard on the " & e.ClickedItem.ToString & " unit And showed great skills. ",
                                         " " & e.ClickedItem.ToString & " was one of your best units during this course. ",
                                        " You showed great success in the " & e.ClickedItem.ToString & " unit. "}
        Dim rndNum As Integer = random.Next(0, commentString.Length - 1)

        If DirectCast(tsmPraise.DropDownItems(tsmPraise.DropDownItems.IndexOf(e.ClickedItem)), ToolStripMenuItem).Checked = True Then

            txtComment.Text = txtComment.Text.Replace(commentString(1), "")
            DirectCast(tsmPraise.DropDownItems(tsmPraise.DropDownItems.IndexOf(e.ClickedItem)), ToolStripMenuItem).Checked = False
        Else
            txtComment.Text = txtComment.Text.Insert(startIndex, commentString(rndNum))
            DirectCast(tsmPraise.DropDownItems(tsmPraise.DropDownItems.IndexOf(e.ClickedItem)), ToolStripMenuItem).Checked = True
        End If

    End Sub

    Private Sub tsmCriticism_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsmCriticism.DropDownItemClicked
        Randomize()
        Dim startIndex As Integer = txtComment.SelectionStart

        Dim commentString() As String = {" Something that need improvement Is " & e.ClickedItem.ToString & ". ",
                                        " You had difficulty with the " & e.ClickedItem.ToString & " unit which could use some work.",
                                        " " & e.ClickedItem.ToString & " was one of your lowest scoring units during this course. ",
                                       " You showed a strong weakness in the " & e.ClickedItem.ToString & " unit. "}
        Dim rndNum As Integer = random.Next(0, commentString.Length - 1)

        txtComment.Text = txtComment.Text.Insert(startIndex, commentString(rndNum))

    End Sub
    Function showPraiseForUnits(praiseUnit As String, praiseNum As Integer)
        Randomize()
        Dim praise As String

        Dim raw_comment = txtComment.Text.Substring(startingIndexes(lstStudentNames.SelectedItem.ToString), endingIndexes(lstStudentNames.SelectedItem.ToString) - startingIndexes(lstStudentNames.SelectedItem.ToString))
        Dim endOfSentence() As String = raw_comment.Split(". ")
        Dim sentenceCount As Integer = raw_comment.Split(". ").Length
        Dim rNum As Integer = random.Next(1, sentenceCount - 1)
        Dim index As Integer = txtComment.Text.IndexOf(endOfSentence(rNum))
        Dim commentString() As String = {"You breezed through " & praiseUnit & " with a good understanding.",
                                         "You worked hard on the " & praiseUnit & " unit And showed great skills.",
                                         praiseUnit & " was one of your best units during this course.",
                                        "You showed great success in the " & praiseUnit & " unit."}
        Randomize()
        Dim rndNum As Integer = random.Next(0, commentString.Length - 1)

        praise = Space(1) & commentString(rndNum) & Space(1)
        txtComment.Text = txtComment.Text.Insert(index, praise)

        If praiseNum = 1 Then
            tempPraiseforUnitOne = praise
            addUserstoList(2, 1, praise)
        ElseIf praiseNum = 2 Then
            tempPraiseforUnitTwo = praise
            addUserstoList(2, 2, praise)
        ElseIf praiseNum = 3 Then
            tempPraiseforUnitThree = praise
            addUserstoList(2, 3, praise)
        ElseIf praiseNum = 4 Then
            tempPraiseforUnitFour = praise
            addUserstoList(2, 4, praise)
        ElseIf praiseNum = 5 Then
            tempPraiseforUnitFive = praise
            addUserstoList(2, 5, praise)
        ElseIf praiseNum = 6 Then
            tempPraiseforUnitSix = praise
            addUserstoList(2, 6, praise)
        ElseIf praiseNum = 7 Then
            tempPraiseforUnitSeven = praise
            addUserstoList(2, 7, praise)
        ElseIf praiseNum = 8 Then
            tempPraiseforUnitEight = praise
            addUserstoList(2, 8, praise)
        ElseIf praiseNum = 9 Then
            tempPraiseforUnitNine = praise
            addUserstoList(2, 9, praise)
        ElseIf praiseNum = 10 Then
            tempPraiseforUnitTen = praise
            addUserstoList(2, 10, praise)
        End If

        Return praise
    End Function
    Function showCriticismForUnits(criticismUnit As String, criticismNum As Integer)
        Randomize()
        Dim criticism As String

        Dim raw_comment = txtComment.Text.Substring(startingIndexes(lstStudentNames.SelectedItem.ToString), endingIndexes(lstStudentNames.SelectedItem.ToString) - startingIndexes(lstStudentNames.SelectedItem.ToString))
        Dim endOfSentence() As String = raw_comment.Split(". ")
        Dim sentenceCount As Integer = raw_comment.Split(". ").Length
        Dim rNum As Integer = random.Next(1, sentenceCount - 1)
        Dim index As Integer = txtComment.Text.IndexOf(endOfSentence(rNum))
        Dim commentString() As String = {"Something that need improvement Is " & criticismUnit & ".",
                                       "You had difficulty with the " & criticismUnit & " unit which could use some work.",
                                       criticismUnit & " was one of your lowest scoring units during this course.",
                                      "You showed a strong weakness in the " & criticismUnit & " unit."}
        Randomize()
        Dim rndNum As Integer = random.Next(0, commentString.Length - 1)

        criticism = Space(1) & commentString(rndNum) & Space(1)
        txtComment.Text = txtComment.Text.Insert(index, criticism)

        If criticismNum = 1 Then
            tempCriticismforUnitOne = criticism
            addUserstoList(3, 1, criticism)
        ElseIf criticismNum = 2 Then
            tempCriticismforUnitTwo = criticism
            addUserstoList(3, 2, criticism)
        ElseIf criticismNum = 3 Then
            tempCriticismforUnitThree = criticism
            addUserstoList(3, 3, criticism)
        ElseIf criticismNum = 4 Then
            tempCriticismforUnitFour = criticism
            addUserstoList(3, 4, criticism)
        ElseIf criticismNum = 5 Then
            tempCriticismforUnitFive = criticism
            addUserstoList(3, 5, criticism)
        ElseIf criticismNum = 6 Then
            tempCriticismforUnitSix = criticism
            addUserstoList(3, 6, criticism)
        ElseIf criticismNum = 7 Then
            tempCriticismforUnitSeven = criticism
            addUserstoList(3, 7, criticism)
        ElseIf criticismNum = 8 Then
            tempCriticismforUnitEight = criticism
            addUserstoList(3, 8, criticism)
        ElseIf criticismNum = 9 Then
            tempCriticismforUnitNine = criticism
            addUserstoList(3, 9, criticism)
        ElseIf criticismNum = 10 Then
            tempCriticismforUnitTen = criticism
            addUserstoList(3, 10, criticism)
        End If

        Return criticism
    End Function

    Private Sub chkPraiseUnitOne_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitOne.CheckedChanged

        If chkPraiseUnitOne.Checked = True Then
            chkCriticismUnitOne.Enabled = False
        Else
            chkCriticismUnitOne.Enabled = True
        End If

    End Sub

    Private Sub chkPraiseUnitTwo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitTwo.CheckedChanged

        If chkPraiseUnitTwo.Checked = True Then
            chkCriticismUnitTwo.Enabled = False
        Else
            chkCriticismUnitTwo.Enabled = True
        End If

    End Sub

    Private Sub chkPraiseUnitThree_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitThree.CheckedChanged

        If chkPraiseUnitThree.Checked = True Then
            chkCriticismUnitThree.Enabled = False
        Else
            chkCriticismUnitThree.Enabled = True
        End If

    End Sub

    Private Sub chkPraiseUnitFour_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitFour.CheckedChanged

        If chkPraiseUnitFour.Checked = True Then
            chkCriticismUnitFour.Enabled = False
        Else
            chkCriticismUnitFour.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitFive_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitFive.CheckedChanged

        If chkPraiseUnitFive.Checked = True Then
            chkCriticismUnitFive.Enabled = False
        Else
            chkCriticismUnitFive.Enabled = True
        End If

    End Sub

    Private Sub chkPraiseUnitSix_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitSix.CheckedChanged

        If chkPraiseUnitSix.Checked = True Then
            chkCriticismUnitSix.Enabled = False
        Else
            chkCriticismUnitSix.Enabled = True
        End If

    End Sub

    Private Sub chkPraiseUnitSeven_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitSeven.CheckedChanged

        If chkPraiseUnitSeven.Checked = True Then
            chkCriticismUnitSeven.Enabled = False
        Else
            chkCriticismUnitSeven.Enabled = True
        End If

    End Sub

    Private Sub chkPraiseUnitEight_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitEight.CheckedChanged

        If chkPraiseUnitEight.Checked = True Then
            chkCriticismUnitEight.Enabled = False
        Else
            chkCriticismUnitEight.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitNine_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitNine.CheckedChanged

        If chkPraiseUnitNine.Checked = True Then
            chkCriticismUnitNine.Enabled = False
        Else
            chkCriticismUnitNine.Enabled = True
        End If

    End Sub

    Private Sub chkPraiseUnitTen_CheckedChanged(sender As Object, e As EventArgs) Handles chkPraiseUnitTen.CheckedChanged

        If chkPraiseUnitTen.Checked = True Then
            chkCriticismUnitTen.Enabled = False
        Else
            chkCriticismUnitTen.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitOne_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitOne.CheckedChanged

        If chkCriticismUnitOne.Checked = True Then
            chkPraiseUnitOne.Enabled = False
        Else
            chkPraiseUnitOne.Enabled = True
        End If

    End Sub

    Private Sub chkCriticismUnitTwo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitTwo.CheckedChanged

        If chkCriticismUnitTwo.Checked = True Then
            chkPraiseUnitTwo.Enabled = False
        Else
            chkPraiseUnitTwo.Enabled = True
        End If

    End Sub

    Private Sub chkCriticismUnitThree_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitThree.CheckedChanged

        If chkCriticismUnitThree.Checked = True Then
            chkPraiseUnitThree.Enabled = False
        Else
            chkPraiseUnitThree.Enabled = True
        End If

    End Sub

    Private Sub SFDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SFDialog2.FileOk
        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(SFDialog2.FileName, FileMode.Create))
        Dim normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12)
        Dim boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
        pdfDoc.Open()
        pdfDoc.AddAuthor("Comment Generator")
        pdfDoc.AddTitle(My.Settings.lastSavedCourseName & " Report Card Comments")
        Dim title = New Paragraph(My.Settings.lastSavedCourseName & " Report Card Comments", boldFont)
        title.SpacingBefore = 20
        title.SpacingAfter = 20
        title.Alignment = 1
        pdfDoc.Add(title)
        For i As Integer = 0 To lstStudentNames.Items.Count - 1

            If txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) <> -1 Then
                Dim startIndex As Integer = txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + +lstStudentNames.Items(i).ToString.Length + 3
                Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + lstStudentNames.Items(i).Length + 4)
                Dim comment As String = txtComment.Text.Substring(startIndex, endIndex - startIndex)
                Dim name As String = lstStudentNames.Items(i).ToString
                pdfDoc.Add(New Paragraph(name, boldFont))
                pdfDoc.Add(New Paragraph(comment, normalFont))
                pdfDoc.Add(New Paragraph(vbNewLine, normalFont))
            End If

        Next
        pdfDoc.Close()
    End Sub

    Private Sub SFDialog3_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SFDialog3.FileOk
        Dim writer As New XmlTextWriter(SFDialog3.FileName, System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Comments")
        For i As Integer = 0 To lstStudentNames.Items.Count - 1

            If txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) <> -1 Then
                Dim startIndex As Integer = txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + +lstStudentNames.Items(i).ToString.Length + 3
                Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + lstStudentNames.Items(i).Length + 4)
                Dim comment As String = txtComment.Text.Substring(startIndex, endIndex - startIndex)
                Dim name As String = lstStudentNames.Items(i).ToString
                createNode(name, comment, writer)
            End If

        Next
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()

    End Sub
    Private Sub createNode(ByVal name As String, ByVal comment As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement(My.Settings.lastSavedCourseName.Replace(" ", "_") & "_Report_Card_Comments")
        writer.WriteStartElement("Name")
        writer.WriteString(name)
        writer.WriteEndElement()
        writer.WriteStartElement("Comment")
        writer.WriteString(comment)
        writer.WriteEndElement()
        writer.WriteEndElement()
    End Sub
    Private Sub chkCriticismUnitFour_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitFour.CheckedChanged

        If chkCriticismUnitFour.Checked = True Then
            chkPraiseUnitFour.Enabled = False
        Else
            chkPraiseUnitFour.Enabled = True
        End If

    End Sub

    Private Sub chkCriticismUnitFive_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitFive.CheckedChanged

        If chkCriticismUnitFive.Checked = True Then
            chkPraiseUnitFive.Enabled = False
        Else
            chkPraiseUnitFive.Enabled = True
        End If

    End Sub

    Private Sub chkCriticismUnitSix_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitSix.CheckedChanged

        If chkCriticismUnitSix.Checked = True Then
            chkPraiseUnitSix.Enabled = False
        Else
            chkPraiseUnitSix.Enabled = True
        End If

    End Sub

    Private Sub chkCriticismUnitSeven_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitSeven.CheckedChanged

        If chkCriticismUnitSeven.Checked = True Then
            chkPraiseUnitSeven.Enabled = False
        Else
            chkPraiseUnitSeven.Enabled = True
        End If

    End Sub

    Private Sub chkCriticismUnitEight_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitEight.CheckedChanged

        If chkCriticismUnitEight.Checked = True Then
            chkPraiseUnitEight.Enabled = False
        Else
            chkPraiseUnitEight.Enabled = True
        End If

    End Sub

    Private Sub chkCriticismUnitNine_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitNine.CheckedChanged

        If chkCriticismUnitNine.Checked = True Then
            chkPraiseUnitNine.Enabled = False
        Else
            chkPraiseUnitNine.Enabled = True
        End If

    End Sub

    Private Sub chkCriticismUnitTen_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriticismUnitTen.CheckedChanged

        If chkCriticismUnitTen.Checked = True Then
            chkPraiseUnitTen.Enabled = False
        Else
            chkPraiseUnitTen.Enabled = True
        End If

    End Sub

    Private Sub txtComment_MouseDown(sender As Object, e As MouseEventArgs) Handles txtComment.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Dim charIndex As Integer
            Dim startPos As Integer
            Dim endPos As Integer
            charIndex = txtComment.GetCharIndexFromPosition(e.Location)
            endPos = txtComment.Text.IndexOf(" ", charIndex)
            startPos = txtComment.Text.LastIndexOf(" ", charIndex)
            If endPos = -1 Then
                endPos = 0
            End If
            If startPos = -1 Then
                startPos = 0
            End If
            If startPos > endPos Then
                Exit Sub
            End If
            charIndex -= startPos
            txtComment.Select(startPos, endPos - startPos)
            Dim word As String = txtComment.Text.Substring(startPos, endPos - startPos)
            searchThesaurus(word.Trim)
        End If
    End Sub
    Function searchThesaurus(word As String)
        cmsComments.Items.Clear()
        Try
            Dim NewWords As NHunspell.ThesResult = thesaurus.Lookup(word)
            Dim WordList As List(Of NHunspell.ThesMeaning) = NewWords.Meanings
            For i = 0 To WordList.Count - 1
                cmsComments.Items.Add(WordList(i).Description)
            Next
        Catch ex As Exception
            cmsComments.Items.Add("No Suggestions Available")
        End Try
        Return True
    End Function

    Private Sub cmsComments_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsComments.ItemClicked
        Dim selectedText As String = txtComment.SelectedText
        If Not e.ClickedItem.ToString = "No Suggestions Available" Then
            txtComment.Text = txtComment.Text.Replace(selectedText, Space(1) & e.ClickedItem.ToString)
        End If

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try

            sr = New StreamReader(OFDialog.FileName)
            Dim selectedName As String = lstStudentNames.SelectedItem.ToString
            Dim gradesFile As String = sr.ReadToEnd
            Dim gradeIndex As Integer = gradesFile.IndexOf(selectedName) + selectedName.Length + 2
            Dim grade As String = gradesFile.Substring(gradeIndex, 3).Trim
            lblTitle.Text = "Currently Selected: " & selectedName & ", Grade: " & grade & " %"
            selectedStudent = lstStudentNames.SelectedItem.ToString
            Dim startIndex As Integer = txtComment.Text.IndexOf(selectedStudent) + +selectedStudent.Length + 3
            Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(selectedStudent) + selectedStudent.Length + 4)
            Dim commentToReplace As String = txtComment.Text.Substring(startIndex, endIndex - startIndex)

            If grade >= 86 Then
                gradeLevel = 4
                txtComment.Text = txtComment.Text.Replace(commentToReplace, successfulComment(selectedName, grade))
                grpCriticism.Enabled = True
                grpPraises.Enabled = True
                grpCriticismUnits.Enabled = True
                grpUnitPraise.Enabled = True
            ElseIf grade >= 60 AndAlso grade <= 85 Then
                gradeLevel = 3
                txtComment.Text = txtComment.Text.Replace(commentToReplace, almostSuccessfulComment(selectedName, grade))
                grpCriticism.Enabled = True
                grpPraises.Enabled = True
                grpCriticismUnits.Enabled = True
                grpUnitPraise.Enabled = True
            ElseIf grade >= 50 AndAlso grade <= 59 Then
                gradeLevel = 2
                txtComment.Text = txtComment.Text.Replace(commentToReplace, almostFailComment(selectedName, grade))
                grpCriticism.Enabled = True
                grpPraises.Enabled = True
                grpCriticismUnits.Enabled = True
                grpUnitPraise.Enabled = True
            ElseIf grade < 50 Then
                gradeLevel = 1
                txtComment.Text = txtComment.Text.Replace(commentToReplace, failingComment(selectedName, grade))
                grpCriticism.Enabled = True
                grpPraises.Enabled = True
                grpCriticismUnits.Enabled = True
                grpUnitPraise.Enabled = True
            Else
                gradeLevel = -1
            End If
            improvingStudentsInList.Remove(selectedStudent)
            goodUnderstandingStudentsInList.Remove(selectedStudent)
            classTimeStudentsInList.Remove(selectedStudent)
            greatListenerStudentsInList.Remove(selectedStudent)
            distractingStudentsInList.Remove(selectedStudent)
            needsHelpStudentsInList.Remove(selectedStudent)
            notPayingAttentionStudentsInList.Remove(selectedStudent)
            lateAssignmentsStudentsInList.Remove(selectedStudent)
            praiseForUnitOneStudentsInList.Remove(selectedStudent)
            praiseForUnitTwoStudentsInList.Remove(selectedStudent)
            praiseForUnitThreeStudentsInList.Remove(selectedStudent)
            praiseForUnitFourStudentsInList.Remove(selectedStudent)
            praiseForUnitFiveStudentsInList.Remove(selectedStudent)
            praiseForUnitSixStudentsInList.Remove(selectedStudent)
            praiseForUnitSevenStudentsInList.Remove(selectedStudent)
            praiseForUnitEightStudentsInList.Remove(selectedStudent)
            praiseForUnitNineStudentsInList.Remove(selectedStudent)
            praiseForUnitTenStudentsInList.Remove(selectedStudent)
            criticismForUnitOneStudentsInList.Remove(selectedStudent)
            criticismForUnitTwoStudentsInList.Remove(selectedStudent)
            criticismForUnitThreeStudentsInList.Remove(selectedStudent)
            criticismForUnitFourStudentsInList.Remove(selectedStudent)
            criticismForUnitFiveStudentsInList.Remove(selectedStudent)
            criticismForUnitSixStudentsInList.Remove(selectedStudent)
            criticismForUnitSevenStudentsInList.Remove(selectedStudent)
            criticismForUnitEightStudentsInList.Remove(selectedStudent)
            criticismForUnitNineStudentsInList.Remove(selectedStudent)
            criticismForUnitTenStudentsInList.Remove(selectedStudent)
            resetBoxes()

        Catch ex As Exception
            MsgBox("Please choose a name from the list. If error persists, import your students again.")
        End Try
    End Sub
    Private Sub btnExportFile_Click(sender As Object, e As EventArgs) Handles btnExportFile.Click
        If lstStudentNames.Items.Count <= 0 Or txtComment.Text = defaultText Then
            MsgBox("Please make some progress before trying to save.")
        Else
            SFDialog.FileName = My.Settings.lastSavedCourseName.Replace(" ", "-") & "-Report-Card-Comments-" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-" & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second
            SFDialog.Title = "Save Student Comments - Comment Generator"
            SFDialog.DefaultExt = "txt"
            SFDialog.Filter = "Student Database Text Files|*.txt"
            SFDialog.ShowDialog()
        End If
        ' log file
        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(Application.StartupPath & "\logs\" & My.Settings.lastSavedCourseName.Replace(" ", "-") & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-" & "T-" & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second & ".pdf", FileMode.Create))
        Dim normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12)
        Dim boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
        pdfDoc.Open()
        pdfDoc.AddAuthor("Comment Generator")
        pdfDoc.AddTitle(My.Settings.lastSavedCourseName & " Report Card Comments")
        Dim title = New Paragraph(My.Settings.lastSavedCourseName & " Report Card Comments", boldFont)
        title.SpacingBefore = 20
        title.SpacingAfter = 20
        title.Alignment = 1
        pdfDoc.Add(title)
        For i As Integer = 0 To lstStudentNames.Items.Count - 1

            If txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) <> -1 Then
                Dim startIndex As Integer = txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + +lstStudentNames.Items(i).ToString.Length + 3
                Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + lstStudentNames.Items(i).Length + 4)
                Dim comment As String = txtComment.Text.Substring(startIndex, endIndex - startIndex)
                Dim name As String = lstStudentNames.Items(i).ToString
                pdfDoc.Add(New Paragraph(name, boldFont))
                pdfDoc.Add(New Paragraph(comment, normalFont))
                pdfDoc.Add(New Paragraph(vbNewLine, normalFont))
            End If

        Next
        pdfDoc.Close()

    End Sub
    Private Function GetMonthName(ByVal monthNum As Integer) As String
        Try
            Dim strDate As New DateTime(1, monthNum, 1)
            Return strDate.ToString("MMM")
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnExportToPDF_Click(sender As Object, e As EventArgs) Handles btnExportToPDF.Click
        If lstStudentNames.Items.Count <= 0 Or txtComment.Text = defaultText Then
            MsgBox("Please make some progress before trying to save.")
        Else
            SFDialog2.FileName = My.Settings.lastSavedCourseName.Replace(" ", "-") & "-Report-Card-Comments-" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-" & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second
            SFDialog2.Title = "Save Student Comments - Comment Generator"
            SFDialog2.DefaultExt = "pdf"
            SFDialog2.Filter = "Student Database Pdf Files|*.pdf"
            SFDialog2.ShowDialog()
        End If

        ' log file
        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(Application.StartupPath & "\logs\" & My.Settings.lastSavedCourseName.Replace(" ", "-") & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-" & "T-" & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second & ".pdf", FileMode.Create))
        Dim normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12)
        Dim boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
        pdfDoc.Open()
        pdfDoc.AddAuthor("Comment Generator")
        pdfDoc.AddTitle(My.Settings.lastSavedCourseName & " Report Card Comments")
        Dim title = New Paragraph(My.Settings.lastSavedCourseName & " Report Card Comments", boldFont)
        title.SpacingBefore = 20
        title.SpacingAfter = 20
        title.Alignment = 1
        pdfDoc.Add(title)
        For i As Integer = 0 To lstStudentNames.Items.Count - 1

            If txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) <> -1 Then
                Dim startIndex As Integer = txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + +lstStudentNames.Items(i).ToString.Length + 3
                Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + lstStudentNames.Items(i).Length + 4)
                Dim comment As String = txtComment.Text.Substring(startIndex, endIndex - startIndex)
                Dim name As String = lstStudentNames.Items(i).ToString
                pdfDoc.Add(New Paragraph(name, boldFont))
                pdfDoc.Add(New Paragraph(comment, normalFont))
                pdfDoc.Add(New Paragraph(vbNewLine, normalFont))
            End If

        Next
        pdfDoc.Close()


    End Sub

    Private Sub bnExportToXML_Click(sender As Object, e As EventArgs) Handles bnExportToXML.Click
        If lstStudentNames.Items.Count <= 0 Or txtComment.Text = defaultText Then
            MsgBox("Please make some progress before trying to save.")
        Else
            SFDialog3.FileName = My.Settings.lastSavedCourseName.Replace(" ", "-") & "-Report-Card-Comments-" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-" & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second
            SFDialog3.Title = "Save Student Comments - Comment Generator"
            SFDialog3.DefaultExt = "xml"
            SFDialog3.Filter = "Student Database XML Files|*.xml"
            SFDialog3.ShowDialog()
        End If

        ' log file
        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(Application.StartupPath & "\logs\" & My.Settings.lastSavedCourseName.Replace(" ", "-") & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-" & "T-" & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second & ".pdf", FileMode.Create))
        Dim normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12)
        Dim boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
        pdfDoc.Open()
        pdfDoc.AddAuthor("Comment Generator")
        pdfDoc.AddTitle(My.Settings.lastSavedCourseName & " Report Card Comments")
        Dim title = New Paragraph(My.Settings.lastSavedCourseName & " Report Card Comments", boldFont)
        title.SpacingBefore = 20
        title.SpacingAfter = 20
        title.Alignment = 1
        pdfDoc.Add(title)
        For i As Integer = 0 To lstStudentNames.Items.Count - 1

            If txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) <> -1 Then
                Dim startIndex As Integer = txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + +lstStudentNames.Items(i).ToString.Length + 3
                Dim endIndex As Integer = txtComment.Text.IndexOf(vbCrLf, txtComment.Text.IndexOf(lstStudentNames.Items(i).ToString) + lstStudentNames.Items(i).Length + 4)
                Dim comment As String = txtComment.Text.Substring(startIndex, endIndex - startIndex)
                Dim name As String = lstStudentNames.Items(i).ToString
                pdfDoc.Add(New Paragraph(name, boldFont))
                pdfDoc.Add(New Paragraph(comment, normalFont))
                pdfDoc.Add(New Paragraph(vbNewLine, normalFont))
            End If

        Next
        pdfDoc.Close()


    End Sub

    Private Sub chkPraiseOne_Click(sender As Object, e As EventArgs) Handles chkPraiseOne.Click
        If chkPraiseOne.Checked = True And Not improvingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then

            addPraise(chkPraiseOne.Text.ToLower, 1)
        Else
            txtComment.Text = txtComment.Text.Replace(Space(1) & improvingStudentsInList(lstStudentNames.SelectedItem.ToString) & Space(1), "")
            improvingStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            Console.WriteLine("Removing User from LstI")
        End If
    End Sub

    Private Sub chkPraiseTwo_Click(sender As Object, e As EventArgs) Handles chkPraiseTwo.Click
        If chkPraiseTwo.Checked = True And Not goodUnderstandingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            addPraise(chkPraiseTwo.Text.ToLower, 2)
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(Space(1) & goodUnderstandingStudentsInList(lstStudentNames.SelectedItem.ToString) & Space(1), "")
            goodUnderstandingStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
        End If
    End Sub

    Private Sub chkPraiseThree_Click(sender As Object, e As EventArgs) Handles chkPraiseThree.Click
        If chkPraiseThree.Checked = True And Not classTimeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            addPraise(chkPraiseThree.Text.ToLower, 3)
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(Space(1) & classTimeStudentsInList(lstStudentNames.SelectedItem.ToString) & Space(1), "")
            classTimeStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
        End If
    End Sub

    Private Sub chkPraiseFour_Click(sender As Object, e As EventArgs) Handles chkPraiseFour.Click
        If chkPraiseFour.Checked = True And Not greatListenerStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            addPraise(chkPraiseFour.Text.ToLower, 4)
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(Space(1) & greatListenerStudentsInList(lstStudentNames.SelectedItem.ToString & Space(1)), "")
            greatListenerStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
        End If
    End Sub

    Private Sub chkCriticismOne_Click(sender As Object, e As EventArgs) Handles chkCriticismOne.Click
        If chkCriticismOne.Checked = True And Not distractingStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            addCriticism(chkCriticismOne.Text.ToLower, 1)
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(Space(1) & distractingStudentsInList(lstStudentNames.SelectedItem.ToString & Space(1)), "")
            distractingStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
        End If
    End Sub

    Private Sub chkCriticismTwo_Click(sender As Object, e As EventArgs) Handles chkCriticismTwo.Click
        If chkCriticismTwo.Checked = True And Not needsHelpStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            addCriticism(chkCriticismTwo.Text.ToLower, 2)
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(Space(1) & needsHelpStudentsInList(lstStudentNames.SelectedItem.ToString & Space(1)), "")
            needsHelpStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
        End If
    End Sub

    Private Sub chkCriticismThree_Click(sender As Object, e As EventArgs) Handles chkCriticismThree.Click
        If chkCriticismThree.Checked = True And Not notPayingAttentionStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            addCriticism(chkCriticismThree.Text.ToLower, 3)
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(Space(1) & notPayingAttentionStudentsInList(lstStudentNames.SelectedItem.ToString & Space(1)), "")
            notPayingAttentionStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
        End If
    End Sub

    Private Sub chkCriticismFour_Click(sender As Object, e As EventArgs) Handles chkCriticismFour.Click
        If chkCriticismFour.Checked = True And Not lateAssignmentsStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            addCriticism(chkCriticismFour.Text.ToLower, 4)
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(Space(1) & lateAssignmentsStudentsInList(lstStudentNames.SelectedItem.ToString & Space(1)), "")
            lateAssignmentsStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
        End If
    End Sub
    Private Sub chkPraiseUnitOne_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitOne.Click
        If chkPraiseUnitOne.Checked = True And Not praiseForUnitOneStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitOne.Text, 1)
            chkCriticismUnitOne.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitOneStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitOneStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitOne.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitTwo_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitTwo.Click
        If chkPraiseUnitTwo.Checked = True And Not praiseForUnitTwoStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitTwo.Text, 2)
            chkCriticismUnitTwo.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitTwoStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitTwoStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitTwo.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitThree_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitThree.Click
        If chkPraiseUnitThree.Checked = True And Not praiseForUnitThreeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitThree.Text, 3)
            chkCriticismUnitThree.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitThreeStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitThreeStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitThree.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitFour_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitFour.Click
        If chkPraiseUnitFour.Checked = True And Not praiseForUnitFourStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitFour.Text, 4)
            chkCriticismUnitFour.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitFourStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitFourStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitFour.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitFive_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitFive.Click
        If chkPraiseUnitFive.Checked = True And Not praiseForUnitFiveStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitFive.Text, 5)
            chkCriticismUnitFive.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitFiveStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitFiveStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitFive.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitSix_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitSix.Click
        If chkPraiseUnitSix.Checked = True And Not praiseForUnitSixStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitSix.Text, 6)
            chkCriticismUnitSix.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitSixStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitSixStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitSix.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitSeven_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitSeven.Click
        If chkPraiseUnitSeven.Checked = True And Not praiseForUnitSevenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitSeven.Text, 7)
            chkCriticismUnitSeven.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitSevenStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitSevenStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitSeven.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitEight_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitEight.Click
        If chkPraiseUnitEight.Checked = True And Not praiseForUnitEightStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitEight.Text, 8)
            chkCriticismUnitEight.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitEightStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitEightStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitEight.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitNine_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitNine.Click
        If chkPraiseUnitNine.Checked = True And Not praiseForUnitNineStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitNine.Text, 9)
            chkCriticismUnitNine.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitNineStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitNineStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitNine.Enabled = True
        End If
    End Sub

    Private Sub chkPraiseUnitTen_Click(sender As Object, e As EventArgs) Handles chkPraiseUnitTen.Click
        If chkPraiseUnitTen.Checked = True And Not praiseForUnitTenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showPraiseForUnits(chkPraiseUnitTen.Text, 10)
            chkCriticismUnitTen.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(praiseForUnitTenStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            praiseForUnitTenStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkCriticismUnitTen.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitOne_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitOne.Click
        If chkCriticismUnitOne.Checked = True And Not criticismForUnitOneStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitOne.Text, 1)
            chkPraiseUnitOne.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitOneStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitOneStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitOne.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitTwo_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitTwo.Click
        If chkCriticismUnitTwo.Checked = True And Not criticismForUnitTwoStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitTwo.Text, 2)
            chkPraiseUnitTwo.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitTwoStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitTwoStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitTwo.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitThree_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitThree.Click
        If chkCriticismUnitThree.Checked = True And Not criticismForUnitThreeStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitThree.Text, 3)
            chkPraiseUnitThree.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitThreeStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitThreeStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitThree.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitFour_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitFour.Click
        If chkCriticismUnitFour.Checked = True And Not criticismForUnitFourStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitFour.Text, 4)
            chkPraiseUnitFour.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitFourStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitFourStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitFour.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitFive_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitFive.Click
        If chkCriticismUnitFive.Checked = True And Not criticismForUnitFiveStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitFive.Text, 5)
            chkPraiseUnitFive.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitFiveStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitFiveStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitFive.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitSix_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitSix.Click
        If chkCriticismUnitSix.Checked = True And Not criticismForUnitSixStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitSix.Text, 6)
            chkPraiseUnitSix.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitSixStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitSixStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitSix.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitSeven_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitSeven.Click
        If chkCriticismUnitSeven.Checked = True And Not criticismForUnitSevenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitSeven.Text, 7)
            chkPraiseUnitSeven.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitSevenStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitSevenStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitSeven.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitEight_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitEight.Click
        If chkCriticismUnitEight.Checked = True And Not criticismForUnitEightStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitEight.Text, 8)
            chkPraiseUnitEight.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitEightStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitEightStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitEight.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitNine_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitNine.Click
        If chkCriticismUnitNine.Checked = True And Not criticismForUnitNineStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitNine.Text, 9)
            chkPraiseUnitNine.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitNineStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitNineStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitNine.Enabled = True
        End If
    End Sub

    Private Sub chkCriticismUnitTen_Click(sender As Object, e As EventArgs) Handles chkCriticismUnitTen.Click
        If chkCriticismUnitTen.Checked = True And Not criticismForUnitTenStudentsInList.ContainsKey(lstStudentNames.SelectedItem.ToString) Then
            'add the sentence to the paragraph
            showCriticismForUnits(chkCriticismUnitTen.Text, 10)
            chkPraiseUnitTen.Enabled = False
        Else
            'delete the sentence from the paragraph
            txtComment.Text = txtComment.Text.Replace(criticismForUnitTenStudentsInList(lstStudentNames.SelectedItem.ToString), "")
            criticismForUnitTenStudentsInList.Remove(lstStudentNames.SelectedItem.ToString)
            chkPraiseUnitTen.Enabled = True
        End If
    End Sub
End Class