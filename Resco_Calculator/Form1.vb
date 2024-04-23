Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TxtBox1.Text = TxtBox1.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TxtBox1.Text = TxtBox1.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TxtBox1.Text = TxtBox1.Text + "3"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TxtBox1.Text = TxtBox1.Text + "4"
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        TxtBox1.Text = ""
    End Sub

    Private Sub bnt6_Click(sender As Object, e As EventArgs) Handles bnt6.Click
        TxtBox1.Text = TxtBox1.Text + "5"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TxtBox1.Text = TxtBox1.Text + "6"
    End Sub

    Private Sub bnt9_Click(sender As Object, e As EventArgs) Handles bnt9.Click
        TxtBox1.Text = TxtBox1.Text + "7"
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        TxtBox1.Text = TxtBox1.Text + "8"
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        TxtBox1.Text = TxtBox1.Text + "9"
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        TxtBox1.Text = TxtBox1.Text + "0"
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        TxtBox1.Text = TxtBox1.Text + "."
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        Label1.Text = TxtBox1.Text
        Label2.Text = "/"
        TxtBox1.Text = ""
    End Sub

    Private Sub bntmultiple_Click(sender As Object, e As EventArgs) Handles bntmultiple.Click
        Label1.Text = TxtBox1.Text
        Label2.Text = "*"
        TxtBox1.Text = ""
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Label1.Text = TxtBox1.Text
        Label2.Text = "-"
        TxtBox1.Text = ""
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Label1.Text = TxtBox1.Text
        Label2.Text = "+"
        TxtBox1.Text = ""
    End Sub

    Private Sub bntequal_Click(sender As Object, e As EventArgs) Handles bntequal.Click
        If Label2.Text = "/" Then
            TxtBox1.Text = Val(Label1.Text) / Val(TxtBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
        If Label2.Text = "*" Then
            TxtBox1.Text = Val(Label1.Text) * Val(TxtBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
        If Label2.Text = "-" Then
            TxtBox1.Text = Val(Label1.Text) - Val(TxtBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
        If Label2.Text = "+" Then
            TxtBox1.Text = Val(Label1.Text) + Val(TxtBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
    End Sub
End Class
