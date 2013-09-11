Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click
        Dim weight As String
        Dim height As String
        Dim bmi As Double
        Dim w As Double
        Dim h As Double
        weight = txtWeight.Text
        w = CDbl(weight)
        height = txtHeight.Text
        h = CDbl(height)
        bmi = (w * 703) / (h ^ 2)
        TextBox1.Text = CStr(bmi)

    End Sub
End Class
