Public Class FrmLab8
    Dim sumScore As Integer
    Dim sumCredit As Integer

    Private Sub frmWork8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intScore As Decimal = 150
        Dim intCredit As Decimal = 50
        Dim intGPA As Decimal
        lblOldTotalScore.Text = intScore
        lblOldTotalCredit.Text = intCredit
        intGPA = intScore / intCredit
        lblOldGPA.Text = FormatNumber(intGPA)

        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()

        txtSubject.Clear()
        txtScore.Clear()
        txtCredit.Clear()
        lblNewGPA.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSubject.Text = "" Or txtCredit.Text = "" Or txtScore.Text = "" Then
            MessageBox.Show("กรุณาป้อนใหม่")
            Exit Sub
        Else
            If Not IsNumeric(txtCredit.Text) Or Not IsNumeric(txtScore.Text) Then
                MessageBox.Show("กรุณาป้อนหมายเลขที่ถูกต้อง")
                Exit Sub
            End If
        End If
        lstSubject.Items.Add(txtSubject.Text)
        lstScore.Items.Add(txtScore.Text)
        lstCredit.Items.Add(txtCredit.Text)
        lstGrade.Items.Add(getGrade(txtScore.Text))

        lstSubject.SelectedIndex = lstSubject.Items.Count - 1
        lstScore.SelectedIndex = lstScore.Items.Count - 1
        lstCredit.SelectedIndex = lstCredit.Items.Count - 1
        lstGrade.SelectedIndex = lstGrade.Items.Count - 1
        Call calData()
        txtCredit.Clear()
        txtScore.Clear()
        txtSubject.Clear()

    End Sub
    Private Sub calData()
        Dim grade As String
        Dim douGR1, douGR2, douGR3, douGRTotal, sumGrade, i, douA, douB, douC As Double
        i = lstCredit.Items.Count
        For intGR = 0 To i - 1
            sumScore = lstScore.Items(intGR)
            sumCredit = lstCredit.Items(intGR)
            grade = lstGrade.Items(intGR)
            Select Case grade
                Case "A"
                    sumGrade = 4
                Case "B+"
                    sumGrade = 3.5
                Case "B"
                    sumGrade = 3
                Case "C+"
                    sumGrade = 2.5
                Case "C"
                    sumGrade = 2
                Case "D+"
                    sumGrade = 1.5
                Case "D"
                    sumGrade = 1
                Case "F"
                    sumGrade = 0
            End Select
            douA = sumCredit * sumGrade
            douB = douA + douB
            douC = sumCredit + douC
        Next

        douGR2 = lblOldTotalScore.Text + douB
        douGR3 = lblOldTotalCredit.Text + douC
        douGRTotal = douGR2 / douGR3

        lblNewGPA.Text = FormatNumber(douGRTotal)

    End Sub


    Private Function getGrade(ByVal score As Integer) As String
        Dim Grade As String = ""
        If score >= 80 Then
            Grade = "A"
        ElseIf score >= 75 Then
            Grade = "B+"
        ElseIf score >= 70 Then
            Grade = "B"
        ElseIf score >= 65 Then
            Grade = "C+"
        ElseIf score >= 60 Then
            Grade = "C"
        ElseIf score >= 55 Then
            Grade = "D+"
        ElseIf score >= 50 Then
            Grade = "D"
        Else
            Grade = "F"
        End If
        Return Grade
    End Function


    Private Sub lstSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSubject.SelectedIndexChanged
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
    End Sub

    Private Sub lstScore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstScore.SelectedIndexChanged
        lstSubject.SelectedIndex = lstScore.SelectedIndex
        lstCredit.SelectedIndex = lstScore.SelectedIndex
        lstGrade.SelectedIndex = lstScore.SelectedIndex
    End Sub

    Private Sub lstCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCredit.SelectedIndexChanged
        lstSubject.SelectedIndex = lstCredit.SelectedIndex
        lstScore.SelectedIndex = lstCredit.SelectedIndex
        lstGrade.SelectedIndex = lstCredit.SelectedIndex
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstGrade.SelectedIndexChanged
        lstScore.SelectedIndex = lstGrade.SelectedIndex
        lstSubject.SelectedIndex = lstGrade.SelectedIndex
        lstCredit.SelectedIndex = lstGrade.SelectedIndex
    End Sub




    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstCredit.Items.Clear()
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstGrade.Items.Clear()
        txtCredit.Text = ""
        txtScore.Text = ""
        txtSubject.Text = ""
        lblNewGPA.Text = ""

    End Sub
End Class