Public Class Form1
    Dim num1 As Integer, num2 As Integer, operand As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResultLabel.Text = ResultLabel.Text + "1"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ResultLabel.Text = ResultLabel.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResultLabel.Text = ResultLabel.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ResultLabel.Text = ResultLabel.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ResultLabel.Text = ResultLabel.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ResultLabel.Text = ResultLabel.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ResultLabel.Text = ResultLabel.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ResultLabel.Text = ResultLabel.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ResultLabel.Text = ResultLabel.Text + "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        ResultLabel.Text = ResultLabel.Text + "0"
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        operand = 1
        num1 = CInt(ResultLabel.Text)
        ResultLabel.Text = ""
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        operand = 2
        num1 = CInt(ResultLabel.Text)
        ResultLabel.Text = ""
    End Sub

    Private Sub ButtonTimes_Click(sender As Object, e As EventArgs) Handles ButtonTimes.Click
        operand = 3
        num1 = CInt(ResultLabel.Text)
        ResultLabel.Text = ""
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        operand = 4
        num1 = CInt(ResultLabel.Text)
        ResultLabel.Text = ""
    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        num2 = CInt(ResultLabel.Text)
        MsgBox(num1)
    End Sub
End Class
