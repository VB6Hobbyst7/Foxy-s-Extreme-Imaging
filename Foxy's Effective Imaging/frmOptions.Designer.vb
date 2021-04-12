<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.SqlabC_ComboBox1 = New SQLABC_ModernUI.SQLABC_ComboBox()
        Me.SqlabC_Button1 = New SQLABC_ModernUI.SQLABC_Button()
        Me.SuspendLayout()
        '
        'SqlabC_ComboBox1
        '
        Me.SqlabC_ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.SqlabC_ComboBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SqlabC_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SqlabC_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SqlabC_ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SqlabC_ComboBox1.ForeColor = System.Drawing.Color.White
        Me.SqlabC_ComboBox1.FormattingEnabled = True
        Me.SqlabC_ComboBox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SqlabC_ComboBox1.ItemHeight = 18
        Me.SqlabC_ComboBox1.Items.AddRange(New Object() {"None", "Scaled (Aliasing)"})
        Me.SqlabC_ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.SqlabC_ComboBox1.Name = "SqlabC_ComboBox1"
        Me.SqlabC_ComboBox1.Size = New System.Drawing.Size(313, 24)
        Me.SqlabC_ComboBox1.TabIndex = 0
        '
        'SqlabC_Button1
        '
        Me.SqlabC_Button1.BackColor = System.Drawing.Color.Transparent
        Me.SqlabC_Button1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SqlabC_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SqlabC_Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SqlabC_Button1.Location = New System.Drawing.Point(219, 220)
        Me.SqlabC_Button1.Name = "SqlabC_Button1"
        Me.SqlabC_Button1.Rounded = False
        Me.SqlabC_Button1.Size = New System.Drawing.Size(106, 32)
        Me.SqlabC_Button1.TabIndex = 1
        Me.SqlabC_Button1.Text = "OK"
        Me.SqlabC_Button1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(337, 264)
        Me.Controls.Add(Me.SqlabC_Button1)
        Me.Controls.Add(Me.SqlabC_ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlabC_ComboBox1 As SQLABC_ModernUI.SQLABC_ComboBox
    Friend WithEvents SqlabC_Button1 As SQLABC_ModernUI.SQLABC_Button
End Class
