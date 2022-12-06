Imports System.Math
Public Class Form1
    Dim num1 As Integer, num2 As Integer, operand As Integer, ans As Decimal
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ResultLabel.Text = ""
        num1 = Nothing
        num2 = Nothing
        operand = Nothing
    End Sub

    Private Sub ButtonANS_Click(sender As Object, e As EventArgs) Handles ButtonANS.Click
        ResultLabel.Text = ans
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        writeNumber("1")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        writeNumber("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        writeNumber("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        writeNumber("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        writeNumber("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        writeNumber("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        writeNumber("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        writeNumber("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        writeNumber("9")
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        writeNumber("0")
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
        Try
            num2 = CInt(ResultLabel.Text)
        Catch
            Return
        End Try

        If operand = 1 Then
            ans = num1 + num2
        ElseIf operand = 2 Then
            ans = num1 - num2
        ElseIf operand = 3 Then
            ans = num1 * num2
        ElseIf operand = 4 Then
            ans = num1 / num2
        Else
            Return
        End If
        ResultLabel.Text = ans
    End Sub

    Private Sub ButtonSQRT_Click(sender As Object, e As EventArgs) Handles ButtonSQRT.Click
        num1 = CInt(ResultLabel.Text)
        ans = Sqrt(num1)
        ResultLabel.Text = ans
    End Sub

    Private Sub writeNumber(number As String)
        ResultLabel.Text = ResultLabel.Text + number
    End Sub

    Private Sub setAnsLabel(text As String)

    End Sub
End Class
