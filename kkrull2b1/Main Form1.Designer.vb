<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStraw = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtRasp = New System.Windows.Forms.TextBox()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRasp = New System.Windows.Forms.Label()
        Me.txtProjIncrease = New System.Windows.Forms.TextBox()
        Me.lblProjStraw = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblProjIncrease = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Strawberries:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Blueberriers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Rasberries:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(110, 72)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(70, 13)
        Me.lbl.TabIndex = 11
        Me.lbl.Text = "Current Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Projected Sales"
        '
        'txtStraw
        '
        Me.txtStraw.Location = New System.Drawing.Point(113, 102)
        Me.txtStraw.Name = "txtStraw"
        Me.txtStraw.Size = New System.Drawing.Size(74, 20)
        Me.txtStraw.TabIndex = 2
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(113, 143)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(74, 20)
        Me.txtBlue.TabIndex = 4
        '
        'txtRasp
        '
        Me.txtRasp.Location = New System.Drawing.Point(113, 187)
        Me.txtRasp.Name = "txtRasp"
        Me.txtRasp.Size = New System.Drawing.Size(74, 20)
        Me.txtRasp.TabIndex = 6
        '
        'lblBlue
        '
        Me.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlue.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblBlue.Location = New System.Drawing.Point(240, 140)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(75, 23)
        Me.lblBlue.TabIndex = 14
        '
        'lblRasp
        '
        Me.lblRasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRasp.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblRasp.Location = New System.Drawing.Point(240, 187)
        Me.lblRasp.Name = "lblRasp"
        Me.lblRasp.Size = New System.Drawing.Size(75, 23)
        Me.lblRasp.TabIndex = 15
        '
        'txtProjIncrease
        '
        Me.txtProjIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProjIncrease.Location = New System.Drawing.Point(268, 29)
        Me.txtProjIncrease.Name = "txtProjIncrease"
        Me.txtProjIncrease.Size = New System.Drawing.Size(47, 20)
        Me.txtProjIncrease.TabIndex = 0
        Me.txtProjIncrease.Text = "0.05"
        '
        'lblProjStraw
        '
        Me.lblProjStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjStraw.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblProjStraw.Location = New System.Drawing.Point(240, 99)
        Me.lblProjStraw.Name = "lblProjStraw"
        Me.lblProjStraw.Size = New System.Drawing.Size(75, 23)
        Me.lblProjStraw.TabIndex = 13
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(22, 227)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(113, 227)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblProjIncrease
        '
        Me.lblProjIncrease.AutoSize = True
        Me.lblProjIncrease.Location = New System.Drawing.Point(52, 31)
        Me.lblProjIncrease.Name = "lblProjIncrease"
        Me.lblProjIncrease.Size = New System.Drawing.Size(185, 13)
        Me.lblProjIncrease.TabIndex = 10
        Me.lblProjIncrease.Text = "Projected &incease % (in decmial form):"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 262)
        Me.Controls.Add(Me.lblProjIncrease)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblProjStraw)
        Me.Controls.Add(Me.txtProjIncrease)
        Me.Controls.Add(Me.lblRasp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.txtRasp)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtStraw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Craston Berries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStraw As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtRasp As TextBox
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRasp As Label
    Friend WithEvents txtProjIncrease As TextBox
    Friend WithEvents lblProjStraw As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblProjIncrease As Label
End Class
