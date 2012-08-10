Public Class frmMain

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        dlgSelectImages.ShowDialog()
    End Sub

    Private Sub dlgSelectImages_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles dlgSelectImages.FileOk
        lstImages.Items.Clear()
        lstImages.Items.AddRange(dlgSelectImages.FileNames)
    End Sub
End Class
