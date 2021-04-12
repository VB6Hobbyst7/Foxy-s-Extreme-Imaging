Public Class frmOptions
    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SqlabC_ComboBox1.SelectedIndex = Nothing Then
            SqlabC_ComboBox1.SelectedIndex = 1
        End If
    End Sub

    Private Sub SqlabC_Button1_Click(sender As Object, e As EventArgs) Handles SqlabC_Button1.Click
        If SqlabC_ComboBox1.SelectedIndex = 0 Then
            Form1.PictureBox1.BackgroundImageLayout = BackgroundImageLayout.None
        ElseIf SqlabC_ComboBox1.SelectedIndex = 1 Then
            Form1.PictureBox1.BackgroundImageLayout = BackgroundImageLayout.Stretch
        End If
        Me.Close()
    End Sub

End Class