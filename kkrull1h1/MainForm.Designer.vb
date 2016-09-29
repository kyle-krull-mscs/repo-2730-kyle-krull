<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFWT = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblFI = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblhours = New System.Windows.Forms.Label()
        Me.lblPayRate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(57, 247)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(87, 27)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(230, 247)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 27)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(402, 247)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(134, 85)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 23)
        Me.txtName.TabIndex = 0
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(329, 85)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(62, 23)
        Me.txtHours.TabIndex = 1
        Me.txtHours.Text = "0.00"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(402, 85)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(62, 23)
        Me.txtRate.TabIndex = 2
        Me.txtRate.Text = "0.00"
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Location = New System.Drawing.Point(35, 165)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(73, 15)
        Me.lblGross.TabIndex = 18
        Me.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFWT
        '
        Me.lblFWT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFWT.Location = New System.Drawing.Point(134, 165)
        Me.lblFWT.Name = "lblFWT"
        Me.lblFWT.Size = New System.Drawing.Size(73, 15)
        Me.lblFWT.TabIndex = 17
        Me.lblFWT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFICA
        '
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFICA.Location = New System.Drawing.Point(230, 165)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(73, 15)
        Me.lblFICA.TabIndex = 16
        Me.lblFICA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Location = New System.Drawing.Point(332, 165)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(73, 15)
        Me.lblState.TabIndex = 15
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNet
        '
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Location = New System.Drawing.Point(433, 165)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(73, 15)
        Me.lblNet.TabIndex = 14
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Location = New System.Drawing.Point(32, 150)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(39, 15)
        Me.lblG.TabIndex = 9
        Me.lblG.Text = "Gross:"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Location = New System.Drawing.Point(131, 150)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(34, 15)
        Me.lblF.TabIndex = 10
        Me.lblF.Text = "FWT:"
        '
        'lblFI
        '
        Me.lblFI.AutoSize = True
        Me.lblFI.Location = New System.Drawing.Point(227, 150)
        Me.lblFI.Name = "lblFI"
        Me.lblFI.Size = New System.Drawing.Size(35, 15)
        Me.lblFI.TabIndex = 11
        Me.lblFI.Text = "FICA:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(329, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "State:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(430, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Net:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(131, 67)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 15)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "&Name"
        '
        'lblhours
        '
        Me.lblhours.AutoSize = True
        Me.lblhours.Location = New System.Drawing.Point(326, 67)
        Me.lblhours.Name = "lblhours"
        Me.lblhours.Size = New System.Drawing.Size(39, 15)
        Me.lblhours.TabIndex = 7
        Me.lblhours.Text = "H&ours"
        '
        'lblPayRate
        '
        Me.lblPayRate.AutoSize = True
        Me.lblPayRate.Location = New System.Drawing.Point(399, 67)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(49, 15)
        Me.lblPayRate.TabIndex = 8
        Me.lblPayRate.Text = "Pay &rate"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 302)
        Me.Controls.Add(Me.lblPayRate)
        Me.Controls.Add(Me.lblhours)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblFI)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblFWT)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "kkrul1h1\Photo Workshop Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblGross As Label
    Friend WithEvents lblFWT As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblG As Label
    Friend WithEvents lblF As Label
    Friend WithEvents lblFI As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblhours As Label
    Friend WithEvents lblPayRate As Label
End Class
