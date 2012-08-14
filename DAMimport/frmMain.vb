Public Class frmMain

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowseImages_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseImages.Click
        dlgSelectImages.ShowDialog()
    End Sub

    Private Sub dlgSelectImages_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles dlgSelectImages.FileOk
        lstImages.Items.Clear()
        lstImages.Items.AddRange(dlgSelectImages.FileNames)
    End Sub



    Private Sub btnSelectShowfile_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectShowfile.Click
        Dim showfileResult As DialogResult = dlgSelectShowfile.ShowDialog()

        If (showfileResult = Windows.Forms.DialogResult.OK) Then
            txtShowfilePath.Text = dlgSelectShowfile.SelectedPath
        End If
    End Sub

    
    Private Sub btnImport_Click(sender As System.Object, e As System.EventArgs) Handles btnImport.Click
        If (txtShowfilePath.Text.Length > 0 And lstImages.Items.Count > 0) Then
            For Each imagePath As String In lstImages.Items
                If (System.IO.File.Exists(imagePath) = True) Then
                    Dim imageName As String = System.IO.Path.GetFileName(imagePath)
                    Dim newImageName As String = txtShowName.Text & "-" & imageName
                    Dim newImagePath As String = txtShowfilePath.Text & newImageName

                    System.IO.File.Copy(imagePath, newImagePath)
                End If
            Next
        Else
            MessageBox.Show("Please select images and a show name before importing")
        End If
    End Sub
End Class
