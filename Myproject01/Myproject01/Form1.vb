Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblTotal.Text = Val(txthoure.Text) * Val(txtWork.Text)
        lblTax.Text = Val(lblTotal.Text) * 3 / 100


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCal2.Click
        Dim hours As Integer
        Dim work, total, tax As Double

        hours = Val(txthoure.Text)
        work = Val(txtWork.Text)

        total = hours * work
        tax = total * 3 / 100


        lblTotal.Text = total
        lblTax.Text = tax











    End Sub
End Class
