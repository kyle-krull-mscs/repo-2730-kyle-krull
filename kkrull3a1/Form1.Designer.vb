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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPretestDoWhile = New System.Windows.Forms.Button()
        Me.btnPretestDoUntil = New System.Windows.Forms.Button()
        Me.btnPosttestLoopWhile = New System.Windows.Forms.Button()
        Me.btnPosttestLoopUntil = New System.Windows.Forms.Button()
        Me.btnPretestFor = New System.Windows.Forms.Button()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Controls.Add(Me.btnPretestFor)
        Me.GroupBox1.Controls.Add(Me.btnPosttestLoopUntil)
        Me.GroupBox1.Controls.Add(Me.btnPosttestLoopWhile)
        Me.GroupBox1.Controls.Add(Me.btnPretestDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnPretestDoWhile)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347 #13 Loop 2-20"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 238)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnPretestDoWhile
        '
        Me.btnPretestDoWhile.Location = New System.Drawing.Point(127, 23)
        Me.btnPretestDoWhile.Name = "btnPretestDoWhile"
        Me.btnPretestDoWhile.Size = New System.Drawing.Size(111, 23)
        Me.btnPretestDoWhile.TabIndex = 0
        Me.btnPretestDoWhile.Text = "Pretest: Do While"
        Me.btnPretestDoWhile.UseVisualStyleBackColor = True
        '
        'btnPretestDoUntil
        '
        Me.btnPretestDoUntil.Location = New System.Drawing.Point(127, 65)
        Me.btnPretestDoUntil.Name = "btnPretestDoUntil"
        Me.btnPretestDoUntil.Size = New System.Drawing.Size(111, 23)
        Me.btnPretestDoUntil.TabIndex = 1
        Me.btnPretestDoUntil.Text = "Pretest: Do Until"
        Me.btnPretestDoUntil.UseVisualStyleBackColor = True
        '
        'btnPosttestLoopWhile
        '
        Me.btnPosttestLoopWhile.Location = New System.Drawing.Point(127, 105)
        Me.btnPosttestLoopWhile.Name = "btnPosttestLoopWhile"
        Me.btnPosttestLoopWhile.Size = New System.Drawing.Size(111, 23)
        Me.btnPosttestLoopWhile.TabIndex = 2
        Me.btnPosttestLoopWhile.Text = "Postest: Loop While"
        Me.btnPosttestLoopWhile.UseVisualStyleBackColor = True
        '
        'btnPosttestLoopUntil
        '
        Me.btnPosttestLoopUntil.Location = New System.Drawing.Point(127, 143)
        Me.btnPosttestLoopUntil.Name = "btnPosttestLoopUntil"
        Me.btnPosttestLoopUntil.Size = New System.Drawing.Size(111, 23)
        Me.btnPosttestLoopUntil.TabIndex = 3
        Me.btnPosttestLoopUntil.Text = "Posttest: Loop Until"
        Me.btnPosttestLoopUntil.UseVisualStyleBackColor = True
        '
        'btnPretestFor
        '
        Me.btnPretestFor.Location = New System.Drawing.Point(127, 182)
        Me.btnPretestFor.Name = "btnPretestFor"
        Me.btnPretestFor.Size = New System.Drawing.Size(111, 23)
        Me.btnPretestFor.TabIndex = 4
        Me.btnPretestFor.Text = "Pretest: For"
        Me.btnPretestFor.UseVisualStyleBackColor = True
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(7, 23)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(114, 158)
        Me.lblEven.TabIndex = 5
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(170, 45)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(51, 36)
        Me.lblCount.TabIndex = 0
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Location = New System.Drawing.Point(116, 45)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(48, 36)
        Me.lblAvg.TabIndex = 1
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(116, 85)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(105, 23)
        Me.btnSumDoWhile.TabIndex = 2
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(116, 132)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(105, 23)
        Me.btnSumLoopUntil.TabIndex = 3
        Me.btnSumLoopUntil.Text = "Sum, Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(116, 182)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(105, 23)
        Me.btnSumForNext.TabIndex = 4
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(6, 45)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ReadOnly = True
        Me.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtList.Size = New System.Drawing.Size(100, 151)
        Me.txtList.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Average:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Count:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 262)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblEven As Label
    Friend WithEvents btnPretestFor As Button
    Friend WithEvents btnPosttestLoopUntil As Button
    Friend WithEvents btnPosttestLoopWhile As Button
    Friend WithEvents btnPretestDoUntil As Button
    Friend WithEvents btnPretestDoWhile As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtList As TextBox
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblCount As Label
End Class
