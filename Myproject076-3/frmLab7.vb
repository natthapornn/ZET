Public Class frmLab7

    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text <> "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
        txtAdd.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim a, b As Integer
        a = ListBox1.Items.Count
        If a = 0 Then
            MessageBox.Show("ไม่มีตัวเลือกแล้ว")
        Else
            ComboBox1.Items.Add(ListBox1.SelectedItem)
            b = ListBox1.SelectedIndex
            If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            Else
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = b
            End If
            ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim a, b As Integer
        a = ComboBox1.Items.Count
        If a < 1 Then
            MessageBox.Show("ไม่มีตัวเลือกแล้ว")
        Else
            ComboBox1.Text = ""
            ListBox1.Items.Add(ComboBox1.SelectedItem)
            ' b = ListBox1.SelectedIndex
            ' If ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1 Then
            ' ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
            ' ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
            ' Else
            'ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
            'ComboBox1.SelectedIndex = b
            'End If
            ComboBox1.Items.Remove(ComboBox1.SelectedItem)
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
        End If
        lblOutput.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        Dim a As Integer
        a = ListBox1.Items.Count
        If a < 1 Then
            MessageBox.Show("ไม่มีตัวเลือกแล้ว")
        Else
            For aa = 1 To ListBox1.Items.Count
                ComboBox1.Items.Add(ListBox1.SelectedItem)
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
            Next
            lblOutput.Text = ComboBox1.SelectedItem
        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        Dim b As Integer
        b = ComboBox1.Items.Count
        If b < 1 Then
            MessageBox.Show("ไม่มีตัวเลือกแล้ว")
        Else
            For bb = 1 To ComboBox1.Items.Count
                ListBox1.Items.Add(ComboBox1.SelectedItem)
                ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
                ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            Next
            ComboBox1.Text = ""
            lblOutput.Text = ComboBox1.SelectedItem
        End If
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs)
        lblOutput.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ListBox1.Items.Add(txtAdd.Text)
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        txtAdd.Clear()
    End Sub
End Class