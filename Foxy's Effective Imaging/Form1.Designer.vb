<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SqlabC_Button1 = New SQLABC_ModernUI.SQLABC_Button()
        Me.SqlabC_ContextMenuStrip1 = New SQLABC_ModernUI.SQLABC_ContextMenuStrip()
        Me.InvertImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SqlabC_Button3 = New SQLABC_ModernUI.SQLABC_Button()
        Me.SqlabC_Button2 = New SQLABC_ModernUI.SQLABC_Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SqlabC_ContextMenuStrip2 = New SQLABC_ModernUI.SQLABC_ContextMenuStrip()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.prgBlurProgress = New System.Windows.Forms.ProgressBar()
        Me.RotateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SqlabC_ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SqlabC_ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlabC_Button1
        '
        Me.SqlabC_Button1.BackColor = System.Drawing.Color.Transparent
        Me.SqlabC_Button1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SqlabC_Button1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SqlabC_Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SqlabC_Button1.Location = New System.Drawing.Point(3, 2)
        Me.SqlabC_Button1.Name = "SqlabC_Button1"
        Me.SqlabC_Button1.Rounded = False
        Me.SqlabC_Button1.Size = New System.Drawing.Size(106, 32)
        Me.SqlabC_Button1.TabIndex = 0
        Me.SqlabC_Button1.Text = "Effects"
        Me.SqlabC_Button1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'SqlabC_ContextMenuStrip1
        '
        Me.SqlabC_ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SqlabC_ContextMenuStrip1.ForeColor = System.Drawing.Color.White
        Me.SqlabC_ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvertImageToolStripMenuItem, Me.BlurToolStripMenuItem, Me.RotateToolStripMenuItem})
        Me.SqlabC_ContextMenuStrip1.Name = "SqlabC_ContextMenuStrip1"
        Me.SqlabC_ContextMenuStrip1.ShowImageMargin = False
        Me.SqlabC_ContextMenuStrip1.Size = New System.Drawing.Size(164, 70)
        '
        'InvertImageToolStripMenuItem
        '
        Me.InvertImageToolStripMenuItem.Name = "InvertImageToolStripMenuItem"
        Me.InvertImageToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.InvertImageToolStripMenuItem.Text = "Invert Image"
        '
        'BlurToolStripMenuItem
        '
        Me.BlurToolStripMenuItem.Name = "BlurToolStripMenuItem"
        Me.BlurToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BlurToolStripMenuItem.Text = "Blur"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.SqlabC_Button3)
        Me.Panel1.Controls.Add(Me.SqlabC_Button2)
        Me.Panel1.Controls.Add(Me.SqlabC_Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 36)
        Me.Panel1.TabIndex = 2
        '
        'SqlabC_Button3
        '
        Me.SqlabC_Button3.BackColor = System.Drawing.Color.Transparent
        Me.SqlabC_Button3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SqlabC_Button3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SqlabC_Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SqlabC_Button3.Location = New System.Drawing.Point(227, 2)
        Me.SqlabC_Button3.Name = "SqlabC_Button3"
        Me.SqlabC_Button3.Rounded = False
        Me.SqlabC_Button3.Size = New System.Drawing.Size(106, 32)
        Me.SqlabC_Button3.TabIndex = 2
        Me.SqlabC_Button3.Text = "Options"
        Me.SqlabC_Button3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'SqlabC_Button2
        '
        Me.SqlabC_Button2.BackColor = System.Drawing.Color.Transparent
        Me.SqlabC_Button2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SqlabC_Button2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SqlabC_Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SqlabC_Button2.Location = New System.Drawing.Point(115, 2)
        Me.SqlabC_Button2.Name = "SqlabC_Button2"
        Me.SqlabC_Button2.Rounded = False
        Me.SqlabC_Button2.Size = New System.Drawing.Size(106, 32)
        Me.SqlabC_Button2.TabIndex = 1
        Me.SqlabC_Button2.Text = "File"
        Me.SqlabC_Button2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(473, 296)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'SqlabC_ContextMenuStrip2
        '
        Me.SqlabC_ContextMenuStrip2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SqlabC_ContextMenuStrip2.ForeColor = System.Drawing.Color.White
        Me.SqlabC_ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.SqlabC_ContextMenuStrip2.Name = "SqlabC_ContextMenuStrip2"
        Me.SqlabC_ContextMenuStrip2.ShowImageMargin = False
        Me.SqlabC_ContextMenuStrip2.Size = New System.Drawing.Size(79, 48)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "PNG Images (*.png)|*.png"
        '
        'prgBlurProgress
        '
        Me.prgBlurProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prgBlurProgress.ForeColor = System.Drawing.Color.Turquoise
        Me.prgBlurProgress.Location = New System.Drawing.Point(0, 285)
        Me.prgBlurProgress.Name = "prgBlurProgress"
        Me.prgBlurProgress.Size = New System.Drawing.Size(473, 47)
        Me.prgBlurProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgBlurProgress.TabIndex = 5
        '
        'RotateToolStripMenuItem
        '
        Me.RotateToolStripMenuItem.Name = "RotateToolStripMenuItem"
        Me.RotateToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RotateToolStripMenuItem.Text = "Rotate (by 90 degrees)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(473, 332)
        Me.Controls.Add(Me.prgBlurProgress)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Foxy's Extreme Imaging"
        Me.SqlabC_ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SqlabC_ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlabC_Button1 As SQLABC_ModernUI.SQLABC_Button
    Friend WithEvents SqlabC_ContextMenuStrip1 As SQLABC_ModernUI.SQLABC_ContextMenuStrip
    Friend WithEvents InvertImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SqlabC_Button2 As SQLABC_ModernUI.SQLABC_Button
    Friend WithEvents SqlabC_ContextMenuStrip2 As SQLABC_ModernUI.SQLABC_ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SqlabC_Button3 As SQLABC_ModernUI.SQLABC_Button
    Friend WithEvents BlurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents prgBlurProgress As ProgressBar
    Friend WithEvents RotateToolStripMenuItem As ToolStripMenuItem
End Class
