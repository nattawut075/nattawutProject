Public Class Myproject2
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim total, totalmis, misVistra, misComputer, Computer, Vistra As Double

        Vistra = Val(txtVistra.Text)
        Computer = Val(txtComputer.Text)
        total = Val(lblTotal.Text)
        totalmis = Val(lbltotalmis.Text)
        misVistra = Val(lblVismis.Text)
        misComputer = Val(lblComputer.Text)

        misVistra = Vistra * 5 / 100
        misComputer = Computer * 10 / 100

        total = Vistra + Computer
        totalmis = misVistra + misComputer

        lblTotal.Text = total
        lbltotalmis.Text = totalmis
        lblVismis.Text = misVistra
        lblComputer.Text = misComputer







    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class