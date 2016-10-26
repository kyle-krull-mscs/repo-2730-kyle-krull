<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.btnConvertEq = New System.Windows.Forms.Button()
        Me.btnCovertNE = New System.Windows.Forms.Button()
        Me.txtAmdollar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.txtOrdered = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnCalcTea = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAmdollar)
        Me.GroupBox1.Controls.Add(Me.btnCovertNE)
        Me.GroupBox1.Controls.Add(Me.btnConvertEq)
        Me.GroupBox1.Controls.Add(Me.lblRand)
        Me.GroupBox1.Controls.Add(Me.lblPound)
        Me.GroupBox1.Controls.Add(Me.lblEuro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p231 #1 Currency Converter"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "American &dollar:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(215, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Euro:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(319, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "British &Pound:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(425, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "South African &rand:"
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(218, 59)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(76, 23)
        Me.lblEuro.TabIndex = 4
        '
        'lblPound
        '
        Me.lblPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPound.Location = New System.Drawing.Point(322, 58)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(84, 23)
        Me.lblPound.TabIndex = 5
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(428, 58)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(87, 23)
        Me.lblRand.TabIndex = 6
        '
        'btnConvertEq
        '
        Me.btnConvertEq.Location = New System.Drawing.Point(117, 20)
        Me.btnConvertEq.Name = "btnConvertEq"
        Me.btnConvertEq.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertEq.TabIndex = 7
        Me.btnConvertEq.Text = "Convert ="
        Me.btnConvertEq.UseVisualStyleBackColor = True
        '
        'btnCovertNE
        '
        Me.btnCovertNE.Location = New System.Drawing.Point(117, 58)
        Me.btnCovertNE.Name = "btnCovertNE"
        Me.btnCovertNE.Size = New System.Drawing.Size(75, 23)
        Me.btnCovertNE.TabIndex = 8
        Me.btnCovertNE.Text = "Convert <>"
        Me.btnCovertNE.UseVisualStyleBackColor = True
        '
        'txtAmdollar
        '
        Me.txtAmdollar.Location = New System.Drawing.Point(27, 61)
        Me.txtAmdollar.Name = "txtAmdollar"
        Me.txtAmdollar.Size = New System.Drawing.Size(62, 20)
        Me.txtAmdollar.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCalcTea)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.txtOrdered)
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p231 #3 Tea Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pound"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Price/lb"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(319, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total due"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(322, 41)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalDue.TabIndex = 3
        '
        'txtOrdered
        '
        Me.txtOrdered.Location = New System.Drawing.Point(27, 45)
        Me.txtOrdered.Name = "txtOrdered"
        Me.txtOrdered.Size = New System.Drawing.Size(68, 20)
        Me.txtOrdered.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(117, 44)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtPrice.TabIndex = 5
        '
        'btnCalcTea
        '
        Me.btnCalcTea.Location = New System.Drawing.Point(218, 43)
        Me.btnCalcTea.Name = "btnCalcTea"
        Me.btnCalcTea.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcTea.TabIndex = 6
        Me.btnCalcTea.Text = "Calculate"
        Me.btnCalcTea.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(547, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 389)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "kkull2d1 if-else statements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAmdollar As TextBox
    Friend WithEvents btnCovertNE As Button
    Friend WithEvents btnConvertEq As Button
    Friend WithEvents lblRand As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalcTea As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtOrdered As TextBox
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
