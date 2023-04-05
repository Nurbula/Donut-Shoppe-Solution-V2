
Option Strict On
Option Infer Off
Option Explicit On
Public Class Form1
    Private Function SalesTax(ByVal decTax As Decimal) As Decimal

        decTax *= 0.06D
        Return decTax
    End Function
    Private Sub Subtotal(ByRef decsubtotal As Decimal)

        Select Case True
            Case radGlazed.Checked, radSuger.Checked
                decsubtotal = 1.05D
            Case radChocolate.Checked
                decsubtotal = 1.25D
            Case radFilled.Checked
                decsubtotal = 1.5D
        End Select

        Select Case True
            Case radRegular.Checked
                decsubtotal += 1.5D
            Case radCappuccino.Checked
                decsubtotal += 2.75D
        End Select
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal

        Subtotal(decSubtotal)

        decSubtotal

        decTotal = decTax + decSubtotal
    End Sub
End Class
radCappuccino.CheckedChanged, radFilled.CheckedChanged, radGlazed.CheckedChanged, radChocolate.CheckedChanged, .CheckedChanged, radRegular.CheckedChanged, radSuger.CheckedChanged