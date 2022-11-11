Imports System.Configuration

Public Class Form1

    Dim FirstNumber, SecondNumber, Operation, Result As String

    Dim NumberOfNumbers As Integer = 1


    Public Function Number(addedNumber As String)
        If NumberOfNumbers = 2 Then
            SecondNumber += addedNumber
        Else
            FirstNumber += addedNumber
        End If
        TextBox1.Text += addedNumber
    End Function
    Public Function Operatoor(Sign As String)
        NumberOfNumbers = 2
        TextBox1.Text += Sign
        Operation = Sign
    End Function

    Public Function Calculate(FirstNum As Decimal, SecondNum As Decimal, Operations As String)

        If Operations = "+" Then
            Result = FirstNum + SecondNum
            Return Result
        ElseIf Operations = "-" Then
            Result = FirstNum - SecondNum
            Return Result
        ElseIf Operations = "*" Then
            Result = FirstNum * SecondNum
            Return Result
        ElseIf Operations = "/" Then
            If SecondNum = 0 Then
                MessageBox.Show("Cann't Devide By Zero!!")
                Beep()
            Else
                Result = FirstNum / SecondNum
                Return Result
            End If
        Else
            MsgBox("Invalid Operation")
            Beep()
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Number(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Number(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Number(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Number(4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Number(5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Number(6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Number(7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Number(8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Number(9)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Number(0)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Number(".")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Operatoor("+")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Operatoor("-")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Operatoor("*")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Operatoor("/")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MsgBox(Calculate(FirstNumber, SecondNumber, Operation))
        MsgBox(FirstNumber)
        MsgBox(SecondNumber)
        FirstNumber = " "
        SecondNumber = " "
        TextBox1.Text = " "
    End Sub
End Class
