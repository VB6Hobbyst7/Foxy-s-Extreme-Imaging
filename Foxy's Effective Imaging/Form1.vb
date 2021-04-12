Public Class Form1
    Private Sub SqlabC_Button1_Click(sender As Object, e As EventArgs) Handles SqlabC_Button1.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Select an image first!", vbCritical, "Error")
        Else
            SqlabC_ContextMenuStrip1.Show(SqlabC_Button1, 0, SqlabC_Button1.Height)
        End If
    End Sub

    Private Sub SqlabC_Button2_Click(sender As Object, e As EventArgs) Handles SqlabC_Button2.Click
        SqlabC_ContextMenuStrip2.Show(SqlabC_Button2, 0, SqlabC_Button2.Height)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            If PictureBox1.Image Is Nothing Then
                PictureBox1.Image = Nothing
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Else
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub SqlabC_Button3_Click(sender As Object, e As EventArgs) Handles SqlabC_Button3.Click
        frmOptions.ShowDialog()
    End Sub

    Private Sub InvertImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertImageToolStripMenuItem.Click
        Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Me.PictureBox1.Image)
        Dim bitmap1 As System.Drawing.Bitmap = bitmap
        Dim width As Integer = bitmap1.Width - 1
        Dim num As Integer = 0
        Do
            Dim height As Integer = bitmap1.Height - 1
            Dim num1 As Integer = 0
            Do
                Dim pixel As System.Drawing.Color = bitmap1.GetPixel(num, num1)
                Dim num2 As Integer = Conversion.Int(CShort(pixel.R))
                Dim color As System.Drawing.Color = bitmap1.GetPixel(num, num1)
                Dim num3 As Integer = Conversion.Int(CShort(color.G))
                color = bitmap1.GetPixel(num, num1)
                Dim num4 As Integer = Conversion.Int(CShort(color.B))
                bitmap1.SetPixel(num, num1, System.Drawing.Color.FromArgb(255 - num2, 255 - num3, 255 - num4))
                num1 = num1 + 1
            Loop While num1 <= height
            num = num + 1
        Loop While num <= width
        bitmap1 = Nothing
        Me.PictureBox1.Refresh()
        Me.PictureBox1.Image = bitmap
    End Sub

    Private Sub BlurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlurToolStripMenuItem.Click
        GaussianBlur(False, New Size(8, 8))
    End Sub
    Private Function ColourAvg(ByVal szAvgSize As Size, ByVal szfImageSize As SizeF, ByVal intX As Integer, ByVal intY As Integer) As Color

        Dim arrlPixels As New ArrayList 'Host All Pixels

        Dim x As Integer 'X Location
        Dim y As Integer 'Y Location

        Dim bmpBlurDest As Bitmap = PictureBox1.Image.Clone 'Image To Be Cloned

        'Find Each Pixel's Colour And Add To ArrayList
        For x = intX - CInt(szAvgSize.Width / 2) To intX + CInt(szAvgSize.Width / 2) 'Left To Right

            For y = intY - CInt(szAvgSize.Height / 2) To intY + CInt(szAvgSize.Height / 2) 'Up To Down

                If (x > 0 And x < szfImageSize.Width) And (y > 0 And y < szfImageSize.Height) Then 'If Not Out Of Bounds

                    arrlPixels.Add(bmpBlurDest.GetPixel(x, y)) 'Add To ArrayList

                End If

            Next

        Next

        Dim clrCurrColour As Color 'Current Colour

        Dim intAlpha As Integer = 0 'Alpha Channel
        Dim intRed As Integer = 0 'Red Channel
        Dim intGreen As Integer = 0 'Green Channel
        Dim intBlue As Integer = 0 'Blue Channel

        For Each clrCurrColour In arrlPixels 'Loop Through Each Colour

            'Store Each Colour
            intAlpha += clrCurrColour.A
            intRed += clrCurrColour.R
            intGreen += clrCurrColour.G
            intBlue += clrCurrColour.B

        Next

        ' Return Average A, R, G, B  
        Return Color.FromArgb(intAlpha / arrlPixels.Count, intRed / arrlPixels.Count, intGreen / arrlPixels.Count, intBlue / arrlPixels.Count)

    End Function
    Private Sub GaussianBlur(ByVal blnAlphaEdges As Boolean, ByVal szBlurSize As Size)
        Try
            Dim Y As Integer 'Y
            Dim X As Integer 'X

            Dim bmpBlurDest As Bitmap = PictureBox1.Image.Clone 'Clone Of Image
            prgBlurProgress.Maximum = bmpBlurDest.Height * bmpBlurDest.Width 'Set Max

            prgBlurProgress.Minimum = 0 'Set Min

            prgBlurProgress.Value = 0 'Initialize Value

            'Loop Through Image
            For Y = 0 To bmpBlurDest.Width - 1 'Top To Bottom

                ' Left To Right
                For X = 0 To bmpBlurDest.Height - 1

                    If Not blnAlphaEdges Then 'AlphaEdges Not Chosen

                        bmpBlurDest.SetPixel(X, Y, ColourAvg(szBlurSize, bmpBlurDest.PhysicalDimension, X, Y)) 'Do Blur

                    ElseIf bmpBlurDest.GetPixel(X, Y).A <> 255 Then 'Alpha Is Not Set To 255

                        bmpBlurDest.SetPixel(X, Y, ColourAvg(szBlurSize, bmpBlurDest.PhysicalDimension, X, Y)) 'Do Blur

                    End If

                    prgBlurProgress.Value += 1 'Update Progress

                    Application.DoEvents() 'Ensure App Doesn't Hang

                Next

            Next

            PictureBox1.Image = bmpBlurDest.Clone 'Update Blurred Image

            bmpBlurDest.Dispose() 'Remove From Memory

        Catch ex As Exception
            frmError.Show()
        End Try

    End Sub

    Private Sub prgBlurProgress_Click(sender As Object, e As EventArgs)
        If prgBlurProgress.Value = prgBlurProgress.Maximum Then
            prgBlurProgress.Value = 0
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                If PictureBox1.Image Is Nothing Then
                    frmError.Show()
                Else
                    Dim bmp As New Bitmap(PictureBox1.ClientSize.Width, PictureBox1.ClientSize.Height)
                    PictureBox1.DrawToBitmap(bmp, PictureBox1.ClientRectangle)
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
                    MsgBox("Image Saved!", vbInformation, "Cool!")
                End If

            End If
        Catch ex As Exception
            frmError.Show()
        End Try
    End Sub

    Private Sub RotateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RotateToolStripMenuItem.Click
        Dim w As Integer
        Dim h As Integer

        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)

        PictureBox1.Width = w
        PictureBox1.Height = h

        PictureBox1.Refresh()
    End Sub
End Class
