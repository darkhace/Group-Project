<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setupMenu
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
        Me.player1RadioButton = New System.Windows.Forms.RadioButton()
        Me.player2RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.redRadioButton = New System.Windows.Forms.RadioButton()
        Me.greenRadioButton = New System.Windows.Forms.RadioButton()
        Me.yellowRadioButton = New System.Windows.Forms.RadioButton()
        Me.blueRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.hardRadioButton = New System.Windows.Forms.RadioButton()
        Me.medRadioButton = New System.Windows.Forms.RadioButton()
        Me.easyRadioButton = New System.Windows.Forms.RadioButton()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'player1RadioButton
        '
        Me.player1RadioButton.AutoSize = True
        Me.player1RadioButton.Location = New System.Drawing.Point(49, 33)
        Me.player1RadioButton.Name = "player1RadioButton"
        Me.player1RadioButton.Size = New System.Drawing.Size(80, 21)
        Me.player1RadioButton.TabIndex = 4
        Me.player1RadioButton.TabStop = True
        Me.player1RadioButton.Text = "player 1"
        Me.player1RadioButton.UseVisualStyleBackColor = True
        '
        'player2RadioButton
        '
        Me.player2RadioButton.AutoSize = True
        Me.player2RadioButton.Location = New System.Drawing.Point(49, 60)
        Me.player2RadioButton.Name = "player2RadioButton"
        Me.player2RadioButton.Size = New System.Drawing.Size(80, 21)
        Me.player2RadioButton.TabIndex = 5
        Me.player2RadioButton.TabStop = True
        Me.player2RadioButton.Text = "player 2"
        Me.player2RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.player2RadioButton)
        Me.GroupBox1.Controls.Add(Me.player1RadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 135)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Who will go first?"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.redRadioButton)
        Me.GroupBox2.Controls.Add(Me.greenRadioButton)
        Me.GroupBox2.Controls.Add(Me.yellowRadioButton)
        Me.GroupBox2.Controls.Add(Me.blueRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 162)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose your color"
        Me.GroupBox2.Visible = False
        '
        'redRadioButton
        '
        Me.redRadioButton.AutoSize = True
        Me.redRadioButton.Location = New System.Drawing.Point(56, 116)
        Me.redRadioButton.Name = "redRadioButton"
        Me.redRadioButton.Size = New System.Drawing.Size(55, 21)
        Me.redRadioButton.TabIndex = 3
        Me.redRadioButton.TabStop = True
        Me.redRadioButton.Text = "Red"
        Me.redRadioButton.UseVisualStyleBackColor = True
        '
        'greenRadioButton
        '
        Me.greenRadioButton.AutoSize = True
        Me.greenRadioButton.Location = New System.Drawing.Point(56, 89)
        Me.greenRadioButton.Name = "greenRadioButton"
        Me.greenRadioButton.Size = New System.Drawing.Size(69, 21)
        Me.greenRadioButton.TabIndex = 2
        Me.greenRadioButton.TabStop = True
        Me.greenRadioButton.Text = "Green"
        Me.greenRadioButton.UseVisualStyleBackColor = True
        '
        'yellowRadioButton
        '
        Me.yellowRadioButton.AutoSize = True
        Me.yellowRadioButton.Location = New System.Drawing.Point(56, 62)
        Me.yellowRadioButton.Name = "yellowRadioButton"
        Me.yellowRadioButton.Size = New System.Drawing.Size(69, 21)
        Me.yellowRadioButton.TabIndex = 1
        Me.yellowRadioButton.TabStop = True
        Me.yellowRadioButton.Text = "Yellow"
        Me.yellowRadioButton.UseVisualStyleBackColor = True
        '
        'blueRadioButton
        '
        Me.blueRadioButton.AutoSize = True
        Me.blueRadioButton.Location = New System.Drawing.Point(56, 35)
        Me.blueRadioButton.Name = "blueRadioButton"
        Me.blueRadioButton.Size = New System.Drawing.Size(57, 21)
        Me.blueRadioButton.TabIndex = 0
        Me.blueRadioButton.TabStop = True
        Me.blueRadioButton.Text = "Blue"
        Me.blueRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.hardRadioButton)
        Me.GroupBox3.Controls.Add(Me.medRadioButton)
        Me.GroupBox3.Controls.Add(Me.easyRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 126)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Difficulty"
        Me.GroupBox3.Visible = False
        '
        'hardRadioButton
        '
        Me.hardRadioButton.AutoSize = True
        Me.hardRadioButton.Location = New System.Drawing.Point(49, 87)
        Me.hardRadioButton.Name = "hardRadioButton"
        Me.hardRadioButton.Size = New System.Drawing.Size(60, 21)
        Me.hardRadioButton.TabIndex = 3
        Me.hardRadioButton.TabStop = True
        Me.hardRadioButton.Text = "Hard"
        Me.hardRadioButton.UseVisualStyleBackColor = True
        '
        'medRadioButton
        '
        Me.medRadioButton.AutoSize = True
        Me.medRadioButton.Location = New System.Drawing.Point(49, 60)
        Me.medRadioButton.Name = "medRadioButton"
        Me.medRadioButton.Size = New System.Drawing.Size(78, 21)
        Me.medRadioButton.TabIndex = 2
        Me.medRadioButton.TabStop = True
        Me.medRadioButton.Text = "Medium"
        Me.medRadioButton.UseVisualStyleBackColor = True
        '
        'easyRadioButton
        '
        Me.easyRadioButton.AutoSize = True
        Me.easyRadioButton.Location = New System.Drawing.Point(49, 33)
        Me.easyRadioButton.Name = "easyRadioButton"
        Me.easyRadioButton.Size = New System.Drawing.Size(60, 21)
        Me.easyRadioButton.TabIndex = 1
        Me.easyRadioButton.TabStop = True
        Me.easyRadioButton.Text = "Easy"
        Me.easyRadioButton.UseVisualStyleBackColor = True
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(276, 132)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(91, 35)
        Me.enterButton.TabIndex = 10
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(276, 32)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(91, 35)
        Me.backButton.TabIndex = 11
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'setupMenu
        '
        Me.AcceptButton = Me.enterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(435, 273)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "setupMenu"
        Me.Text = "setupMenu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents player1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents player2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents redRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents greenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents yellowRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents blueRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents hardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents medRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents easyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents backButton As System.Windows.Forms.Button
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
