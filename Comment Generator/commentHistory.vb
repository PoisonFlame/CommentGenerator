Imports iTextSharp.text.pdf
Imports iTextSharp.text
Public Class commentHistory
    Private Sub commentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not System.IO.Directory.Exists(Application.StartupPath & "\logs") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\logs")
        End If


        Dim dir As New System.IO.DirectoryInfo(Application.StartupPath & "\logs")
        Dim fileNames As System.IO.FileInfo() = dir.GetFiles()
        Dim fileName As System.IO.FileInfo

        'list the names of all files in the specified directory
        For Each fileName In fileNames
            If fileName.Extension = ".pdf" Then
                cmbDates.Items.Add(fileName)
            End If
        Next

        If cmbDates.Items.Count = 0 Then
            cmbDates.Items.Add("No Comment History Found.")
        End If

        wbPDFViewer.Navigate(Application.StartupPath & "\logs")

    End Sub

    Private Sub cmbDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDates.SelectedIndexChanged
        If Not cmbDates.SelectedItem.ToString = "No Comment History Found." Then
            wbPDFViewer.Navigate(Application.StartupPath & "\logs\" & cmbDates.SelectedItem.ToString)
        End If

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MsgBox("Comments will appear in history after saving the file through either method when making comments.", MsgBoxStyle.Information)
    End Sub
End Class