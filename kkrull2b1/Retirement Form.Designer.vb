<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.txtEmployer = New System.Windows.Forms.TextBox()
        Me.lblEmpolyee = New System.Windows.Forms.Label()
        Me.lblEmployer = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Gross weekly Pay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Employee contribution rate (decimal Form:)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employe&r contribution rate (decimal form):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee annual contribution:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Emloyer annual contribution:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(148, 257)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(321, 258)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "E&xit"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'txtGross
        '
        Me.txtGross.Location = New System.Drawing.Point(296, 30)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(100, 20)
        Me.txtGross.TabIndex = 7
        Me.txtGross.Text = "1000"
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(296, 69)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployee.TabIndex = 8
        Me.txtEmployee.Text = "0.05"
        Me.txtEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployer
        '
        Me.txtEmployer.Location = New System.Drawing.Point(296, 109)
        Me.txtEmployer.Name = "txtEmployer"
        Me.txtEmployer.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployer.TabIndex = 9
        Me.txtEmployer.Text = "0.07"
        Me.txtEmployer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmpolyee
        '
        Me.lblEmpolyee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpolyee.Location = New System.Drawing.Point(296, 145)
        Me.lblEmpolyee.Name = "lblEmpolyee"
        Me.lblEmpolyee.Size = New System.Drawing.Size(100, 23)
        Me.lblEmpolyee.TabIndex = 10
        '
        'lblEmployer
        '
        Me.lblEmployer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployer.Location = New System.Drawing.Point(296, 180)
        Me.lblEmployer.Name = "lblEmployer"
        Me.lblEmployer.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployer.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Totoal annual contribution:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(296, 212)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 13
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 305)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblEmployer)
        Me.Controls.Add(Me.lblEmpolyee)
        Me.Controls.Add(Me.txtEmployer)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents txtGross As TextBox
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents txtEmployer As TextBox
    Friend WithEvents lblEmpolyee As Label
    Friend WithEvents lblEmployer As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotal As Label
End Class
