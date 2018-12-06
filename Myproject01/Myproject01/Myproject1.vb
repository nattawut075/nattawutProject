Public Class Myproject1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim money, total, salary As Double

        money = Val(txtMoney.Text)
        salary = Val(lbl2.Text)
        total = Val(lblTotal.Text)

        salary = money * 12
        total = salary * 5 / 100



        lbl2.Text = salary
        lblTotal.Text = (salary - total)









    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class