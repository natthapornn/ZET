Public Class frmLab4
    Dim today As Date = Date.Now
    Private Sub frmLab4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim day As String = Now.Date
        lblDate.Text = day
        radGenDate.Checked = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = FormatDateTime(today, DateFormat.GeneralDate)
    End Sub

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = FormatDateTime(today, DateFormat.ShortDate)
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Dim sarary, sale, saleday, bonut, totalsarary, deduct, vat As Double
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07

        sarary = Val(txtSalary.Text)
        sale = Val(txtSale.Text)

        saleday = sarary * 12
        bonut = sale * decR_BONUS
        totalsarary = saleday + bonut
        deduct = totalsarary * decR_ALLOW
        vat = (totalsarary - deduct) * decR_TAX


        lblYearSalary.Text = FormatNumber(saleday, 2)
        lblBonus.Text = FormatNumber(bonut, 2)
        lblAllIncome.Text = FormatNumber(totalsarary, 2)
        lblAllowance.Text = FormatNumber(deduct, 2)
        lblTax.Text = FormatNumber(vat, 2)



    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub
End Class