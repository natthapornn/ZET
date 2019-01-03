Public Class frmJob6
    Dim car As Double
    Dim net, f2, f1, f3, s1, s2, s3 As Double
    Dim Mes As DialogResult
    Dim Mes2 As DialogResult

    Private Sub chkItemsAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked = True Then
            net = net + Val(lblItemsPrice3.Text)
        Else
            net = net - Val(lblItemsPrice3.Text)
        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked = True Then
            net = net + Val(lblItemsPrice4.Text)
        Else
            net = net - Val(lblItemsPrice4.Text)
        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkCarForMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForMe.CheckedChanged





    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lblFree1_Click(sender As Object, e As EventArgs) Handles lblFree1.Click

    End Sub

    Private Sub chkCarForMe_Click(sender As Object, e As EventArgs) Handles chkCarForMe.Click
        If chkCarForMe.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            f1 = Val(lblFree1.Text)
            f2 = Val(lblFree2.Text)
            f3 = Val(lblFree3.Text)
            car = Val(lblSartPrice.Text)
            net = (car + f1) + f2 + f3

            lblPaidPrice.Text = net

        Else
            If MessageBox.Show("ต้องการยกเลิกซื้อรถใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                chkCarForMe.Checked = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = 0

            Else
                chkCarForMe.Checked = True

            End If
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked = True Then
            net = net + Val(lblItemsPrice2.Text)
        Else
            net = net - Val(lblItemsPrice2.Text)
        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked = True Then
            net = net + Val(lblItemsPrice1.Text)
        Else
            net = net - Val(lblItemsPrice1.Text)
        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkFree3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked = True Then
            net = net - Val(lblFree3.Text)

        Else
            net = net + Val(lblFree3.Text)

        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkFree2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked = True Then
            net = net - Val(lblFree2.Text)
        Else
            net = net + Val(lblFree2.Text)

        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub chkFree1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked = True Then
            Net = Net - Val(lblFree1.Text)

        Else
            Net = Net + Val(lblFree1.Text)

        End If
        lblPaidPrice.Text = net
    End Sub
End Class