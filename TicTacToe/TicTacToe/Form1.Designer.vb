<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameMenu
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
        Me.vsPlayerBtn = New System.Windows.Forms.Button()
        Me.vsVaderBtn = New System.Windows.Forms.Button()
        Me.registerBtn = New System.Windows.Forms.Button()
        Me.historyBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'vsPlayerBtn
        '
        Me.vsPlayerBtn.Location = New System.Drawing.Point(117, 68)
        Me.vsPlayerBtn.Name = "vsPlayerBtn"
        Me.vsPlayerBtn.Size = New System.Drawing.Size(112, 38)
        Me.vsPlayerBtn.TabIndex = 0
        Me.vsPlayerBtn.Text = "vs Player"
        Me.vsPlayerBtn.UseVisualStyleBackColor = True
        '
        'vsVaderBtn
        '
        Me.vsVaderBtn.Location = New System.Drawing.Point(117, 112)
        Me.vsVaderBtn.Name = "vsVaderBtn"
        Me.vsVaderBtn.Size = New System.Drawing.Size(112, 38)
        Me.vsVaderBtn.TabIndex = 1
        Me.vsVaderBtn.Text = "vs Vader"
        Me.vsVaderBtn.UseVisualStyleBackColor = True
        '
        'registerBtn
        '
        Me.registerBtn.Location = New System.Drawing.Point(117, 156)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(112, 38)
        Me.registerBtn.TabIndex = 2
        Me.registerBtn.Text = "Register"
        Me.registerBtn.UseVisualStyleBackColor = True
        '
        'historyBtn
        '
        Me.historyBtn.Location = New System.Drawing.Point(117, 200)
        Me.historyBtn.Name = "historyBtn"
        Me.historyBtn.Size = New System.Drawing.Size(112, 38)
        Me.historyBtn.TabIndex = 3
        Me.historyBtn.Text = "History"
        Me.historyBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(307, 279)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(52, 38)
        Me.exitBtn.TabIndex = 4
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tic Tac Toe"
        '
        'gameMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 329)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.historyBtn)
        Me.Controls.Add(Me.registerBtn)
        Me.Controls.Add(Me.vsVaderBtn)
        Me.Controls.Add(Me.vsPlayerBtn)
        Me.Name = "gameMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vsPlayerBtn As System.Windows.Forms.Button
    Friend WithEvents vsVaderBtn As System.Windows.Forms.Button
    Friend WithEvents registerBtn As System.Windows.Forms.Button
    Friend WithEvents historyBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
