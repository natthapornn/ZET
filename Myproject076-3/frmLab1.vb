﻿Public Class frmLab1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salary, salaryperyear, tex As Double
        salary = txtSalary.Text
        salary = Val(salary * 12)


        salaryperyear = Val(salary * 5) / 100


        tex = Val(salary) - Val(salaryperyear)

        lblSalaryperyear.Text = salary
        lblTex.Text = salaryperyear
        lblNetsalary.Text = tex



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
