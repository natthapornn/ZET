<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSalaryperyear = New System.Windows.Forms.Label()
        Me.lblNetsalary = New System.Windows.Forms.Label()
        Me.lblTex = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(37, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เงินเดือนพนักงาน"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(37, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เงินเดือนพนักงาน/ปี"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(37, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เงินเดือนพนักงาน"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(37, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ภาษีที่ต้องชำระ"
        '
        'lblSalaryperyear
        '
        Me.lblSalaryperyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSalaryperyear.Location = New System.Drawing.Point(204, 118)
        Me.lblSalaryperyear.Name = "lblSalaryperyear"
        Me.lblSalaryperyear.Size = New System.Drawing.Size(100, 23)
        Me.lblSalaryperyear.TabIndex = 0
        '
        'lblNetsalary
        '
        Me.lblNetsalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNetsalary.Location = New System.Drawing.Point(204, 186)
        Me.lblNetsalary.Name = "lblNetsalary"
        Me.lblNetsalary.Size = New System.Drawing.Size(100, 23)
        Me.lblNetsalary.TabIndex = 0
        '
        'lblTex
        '
        Me.lblTex.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTex.Location = New System.Drawing.Point(204, 153)
        Me.lblTex.Name = "lblTex"
        Me.lblTex.Size = New System.Drawing.Size(100, 23)
        Me.lblTex.TabIndex = 0
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(200, 80)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(107, 20)
        Me.txtSalary.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 21)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(200, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 21)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "โปรแกรมคำนวนหารายได้ทั้งปี"
        '
        'frmLab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 311)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblTex)
        Me.Controls.Add(Me.lblNetsalary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSalaryperyear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSalaryperyear As Label
    Friend WithEvents lblNetsalary As Label
    Friend WithEvents lblTex As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
End Class
