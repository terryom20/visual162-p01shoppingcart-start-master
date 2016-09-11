Public Class MainForm




    Private Sub BtnHombre_Click(sender As Object, e As EventArgs) Handles BtnHombre.Click
        BtnHombre.ForeColor = Color.SteelBlue
        BtnMujeres.ForeColor = Color.Black
    End Sub

    Private Sub BtnMujeres_Click(sender As Object, e As EventArgs) Handles BtnMujeres.Click
        BtnHombre.ForeColor = Color.SteelBlue
        BtnMujeres.ForeColor = Color.Black


    End Sub

    Private Sub btnCalzados_Click(sender As Object, e As EventArgs) Handles btnCalzados.Click

        btnCalzados.ForeColor = Color.SteelBlue
    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click

        btnAccesorios.ForeColor = Color.SteelBlue
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        MsgBox("¡COMPRA SATISFACTORIA! ;)")
    End Sub



End Class





