Public Class Form1
    Private m_Previous As System.Nullable(Of Point) = Nothing
    Dim m_shapes As New Collection
    Dim c As Color
    Dim w As Integer
    Dim type As String


    Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        m_Previous = e.Location
        pictureBox1_MouseMove(sender, e)
    End Sub

    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m_Previous IsNot Nothing Then
            Dim D As Object
            D = New Line(PictureBox1.Image, m_Previous, e.Location)
            D.pen = New Pen(c, w)
            If Type = "Line" Then
                D = New Line(PictureBox1.Image, m_Previous, e.Location)
                D.pen = New Pen(c, w)
            End If
            If Type = "Rectangle" Then
                D = New Rectangle(PictureBox1.Image, m_Previous, e.Location)
                D.pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If Type = "Circle" Then
                D = New Circle(PictureBox1.Image, m_Previous, e.Location)
                D.pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "Arc" Then
                D = New Arc(PictureBox1.Image, m_Previous, e.Location)
                D.pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "Pie" Then
                D = New Pie(PictureBox1.Image, m_Previous, e.Location)
                D.pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "Triangle" Then
                D = New Triangle(PictureBox1.Image, m_Previous, e.Location)
                D.pen = New Pen(c, w)
                D.radius = TrackBar4.Value
                D.sides = TrackBar3.Value
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "En_gon" Then
                D = New En_gon(PictureBox1.Image, m_Previous, e.Location)
                D.pen = New Pen(c, w)
            End If
            If type = "Picture" Then
                D = New PBox(PictureBox1.Image, m_Previous, e.Location)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
                D.picture = PictureBox2.Image
            End If

            m_shapes.Add(D)
                PictureBox1.Invalidate()
                m_Previous = e.Location
            End If
    End Sub

    Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        m_Previous = Nothing
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PictureBox1.Image Is Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            PictureBox1.Image = bmp
        End If

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        For Each s As Object In m_shapes
            s.Draw()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        Button1.BackColor = c

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = sender.backcolor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = sender.backcolor
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c = sender.backcolor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = sender.backcolor
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        c = sender.backcolor
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        c = sender.backcolor
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        c = sender.backcolor
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        c = sender.backcolor
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        w = TrackBar1.Value
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveFileDialog1.ShowDialog()
        PictureBox1.Image.Save(SaveFileDialog1.FileName)
    End Sub

    Private Sub LineButton_Click(sender As Object, e As EventArgs) Handles LineButton.Click
        type = "Line"
    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        type = "Circle"
    End Sub

    Private Sub SquareButton_Click(sender As Object, e As EventArgs) Handles RectangleButton.Click
        type = "Rectangle"
    End Sub

    Private Sub ArcButton_Click(sender As Object, e As EventArgs) Handles ArcButton.Click
        type = "Arc"
    End Sub

    Private Sub PieButton_Click(sender As Object, e As EventArgs) Handles PieButton.Click
        type = "Pie"
    End Sub

    Private Sub TriangleButton_Click(sender As Object, e As EventArgs) Handles TriangleButton.Click
        type = "Triangle"
    End Sub

    Private Sub EngonButton_Click(sender As Object, e As EventArgs) Handles EnGonButton.Click
        type = "En_gon"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        type = "Picture"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles PictureButton.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox2.Load(OpenFileDialog1.FileName)
    End Sub
End Class
