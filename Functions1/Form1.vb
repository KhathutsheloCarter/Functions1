Public Class Form1
    Private Sub btnCalCulate_Click(sender As Object, e As EventArgs) Handles btnCalCulate.Click

        Dim num1 As Integer = txtNumber1.Text
        Dim num2 As Integer = txtNumber2.Text
        Dim Answer As Integer = AddNumber(num1, num2)
        Dim MulAnswer As Integer = Multiply(num1, num2)
        Dim Choose As String = txtChoose.Text.ToUpper


        If Choose = "ADD" Then

            MessageBox.Show(Answer)

        ElseIf Choose = "MULTIPLY" Then
            MessageBox.Show(MulAnswer)
        Else
            MsgBox("please type add or Multiply")

        End If

    End Sub
    Function AddNumber(Fnumber As Integer, Snumber As Integer) As Integer
        Dim Results As Integer = Fnumber + Snumber
        Return Results
    End Function

    Function Multiply(Fnumber As Integer, Snumber As Integer) As Integer

        Dim Results As Integer = Fnumber * Snumber

        Return Results
    End Function
End Class
