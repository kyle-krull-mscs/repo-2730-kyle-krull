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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblShip = New System.Windows.Forms.Label()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.btnCalcAnd = New System.Windows.Forms.Button()
        Me.btnCalcOr = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalcOr)
        Me.GroupBox1.Controls.Add(Me.btnCalcAnd)
        Me.GroupBox1.Controls.Add(Me.txtCard)
        Me.GroupBox1.Controls.Add(Me.txtOrder)
        Me.GroupBox1.Controls.Add(Me.lblShip)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free shipping for orders over $100 with Savannah CC"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(13, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Order amount:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(122, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Savannah (Y):"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(253, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Shipping charge:"
        '
        'lblShip
        '
        Me.lblShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShip.Location = New System.Drawing.Point(253, 60)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(100, 23)
        Me.lblShip.TabIndex = 3
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(7, 63)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(99, 20)
        Me.txtOrder.TabIndex = 4
        '
        'txtCard
        '
        Me.txtCard.Location = New System.Drawing.Point(125, 63)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(29, 20)
        Me.txtCard.TabIndex = 5
        '
        'btnCalcAnd
        '
        Me.btnCalcAnd.Location = New System.Drawing.Point(383, 29)
        Me.btnCalcAnd.Name = "btnCalcAnd"
        Me.btnCalcAnd.Size = New System.Drawing.Size(87, 23)
        Me.btnCalcAnd.TabIndex = 6
        Me.btnCalcAnd.Text = "Calculate (And)"
        Me.btnCalcAnd.UseVisualStyleBackColor = True
        '
        'btnCalcOr
        '
        Me.btnCalcOr.Location = New System.Drawing.Point(383, 59)
        Me.btnCalcOr.Name = "btnCalcOr"
        Me.btnCalcOr.Size = New System.Drawing.Size(87, 23)
        Me.btnCalcOr.TabIndex = 7
        Me.btnCalcOr.Text = "Calculate(Or)"
        Me.btnCalcOr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 262)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "kkrull2e1 AndAlso, OrElse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalcOr As Button
    Friend WithEvents btnCalcAnd As Button
    Friend WithEvents txtCard As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents lblShip As Label
End Class
