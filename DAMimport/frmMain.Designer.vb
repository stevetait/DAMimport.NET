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
        Me.btnBrowseImages = New System.Windows.Forms.Button()
        Me.lblImages = New System.Windows.Forms.Label()
        Me.lstImages = New System.Windows.Forms.ListBox()
        Me.dlgSelectImages = New System.Windows.Forms.OpenFileDialog()
        Me.txtShowfilePath = New System.Windows.Forms.TextBox()
        Me.btnSelectShowfile = New System.Windows.Forms.Button()
        Me.lblShowfile = New System.Windows.Forms.Label()
        Me.dlgSelectShowfile = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.txtShowName = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBrowseImages
        '
        Me.btnBrowseImages.Location = New System.Drawing.Point(131, 12)
        Me.btnBrowseImages.Name = "btnBrowseImages"
        Me.btnBrowseImages.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseImages.TabIndex = 1
        Me.btnBrowseImages.Text = "Browse"
        Me.btnBrowseImages.UseVisualStyleBackColor = True
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
        Me.lstImages.HorizontalScrollbar = True
        Me.lstImages.Location = New System.Drawing.Point(12, 41)
        Me.lstImages.Name = "lstImages"
        Me.lstImages.ScrollAlwaysVisible = True
        Me.lstImages.Size = New System.Drawing.Size(406, 212)
        Me.lstImages.TabIndex = 3
        '
        'dlgSelectImages
        '
        Me.dlgSelectImages.FileName = "Select Images"
        Me.dlgSelectImages.Filter = "JPG|*.jpg|JPEG|*.jpeg|BMP|*.bmp|GIF|*.gif|PNG|*.PNG|All files|*.*"
        Me.dlgSelectImages.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.Personal)"
        Me.dlgSelectImages.Multiselect = True
        '
        'txtShowfilePath
        '
        Me.txtShowfilePath.Location = New System.Drawing.Point(83, 259)
        Me.txtShowfilePath.Name = "txtShowfilePath"
        Me.txtShowfilePath.Size = New System.Drawing.Size(254, 20)
        Me.txtShowfilePath.TabIndex = 4
        '
        'btnSelectShowfile
        '
        Me.btnSelectShowfile.Location = New System.Drawing.Point(343, 256)
        Me.btnSelectShowfile.Name = "btnSelectShowfile"
        Me.btnSelectShowfile.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectShowfile.TabIndex = 5
        Me.btnSelectShowfile.Text = "Browse"
        Me.btnSelectShowfile.UseVisualStyleBackColor = True
        '
        'lblShowfile
        '
        Me.lblShowfile.AutoSize = True
        Me.lblShowfile.Location = New System.Drawing.Point(9, 262)
        Me.lblShowfile.Name = "lblShowfile"
        Me.lblShowfile.Size = New System.Drawing.Size(47, 13)
        Me.lblShowfile.TabIndex = 6
        Me.lblShowfile.Text = "Showfile"
        '
        'dlgSelectShowfile
        '
        Me.dlgSelectShowfile.SelectedPath = "\\fs01\showfile"
        '
        'lblShowName
        '
        Me.lblShowName.AutoSize = True
        Me.lblShowName.Location = New System.Drawing.Point(9, 288)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(65, 13)
        Me.lblShowName.TabIndex = 7
        Me.lblShowName.Text = "Show Name"
        '
        'txtShowName
        '
        Me.txtShowName.Location = New System.Drawing.Point(83, 285)
        Me.txtShowName.Name = "txtShowName"
        Me.txtShowName.Size = New System.Drawing.Size(335, 20)
        Me.txtShowName.TabIndex = 8
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 322)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(405, 45)
        Me.btnImport.TabIndex = 9
        Me.btnImport.Text = "Import Images"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 379)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.txtShowName)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.lblShowfile)
        Me.Controls.Add(Me.btnSelectShowfile)
        Me.Controls.Add(Me.txtShowfilePath)
        Me.Controls.Add(Me.lstImages)
        Me.Controls.Add(Me.lblImages)
        Me.Controls.Add(Me.btnBrowseImages)
        Me.Name = "frmMain"
        Me.Text = "Image Import"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowseImages As System.Windows.Forms.Button
    Friend WithEvents lblImages As System.Windows.Forms.Label
    Friend WithEvents lstImages As System.Windows.Forms.ListBox
    Friend WithEvents dlgSelectImages As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtShowfilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectShowfile As System.Windows.Forms.Button
    Friend WithEvents lblShowfile As System.Windows.Forms.Label
    Friend WithEvents dlgSelectShowfile As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblShowName As System.Windows.Forms.Label
    Friend WithEvents txtShowName As System.Windows.Forms.TextBox
    Friend WithEvents btnImport As System.Windows.Forms.Button

End Class
