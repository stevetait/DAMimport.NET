<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblImages = New System.Windows.Forms.Label()
        Me.lstImages = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(131, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblImages
        '
        Me.lblImages.AutoSize = True
        Me.lblImages.Location = New System.Drawing.Point(12, 17)
        Me.lblImages.Name = "lblImages"
        Me.lblImages.Size = New System.Drawing.Size(112, 13)
        Me.lblImages.TabIndex = 2
        Me.lblImages.Text = "Images to be Imported"
        '
        'lstImages
        '
        Me.lstImages.FormattingEnabled = True
        Me.lstImages.Location = New System.Drawing.Point(12, 41)
        Me.lstImages.Name = "lstImages"
        Me.lstImages.Size = New System.Drawing.Size(194, 212)
        Me.lstImages.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 262)
        Me.Controls.Add(Me.lstImages)
        Me.Controls.Add(Me.lblImages)
        Me.Controls.Add(Me.btnBrowse)
        Me.Name = "frmMain"
        Me.Text = "Image Import"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblImages As System.Windows.Forms.Label
    Friend WithEvents lstImages As System.Windows.Forms.ListBox

End Class
