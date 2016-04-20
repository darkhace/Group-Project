<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
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
        Me.Btn_View = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.List_Score = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Btn_View
        '
        Me.Btn_View.Location = New System.Drawing.Point(12, 198)
        Me.Btn_View.Name = "Btn_View"
        Me.Btn_View.Size = New System.Drawing.Size(75, 23)
        Me.Btn_View.TabIndex = 0
        Me.Btn_View.Text = "View"
        Me.Btn_View.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(114, 198)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 1
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_Back.Location = New System.Drawing.Point(207, 198)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(75, 23)
        Me.btn_Back.TabIndex = 2
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'List_Score
        '
        Me.List_Score.FormattingEnabled = True
        Me.List_Score.Location = New System.Drawing.Point(0, 0)
        Me.List_Score.Name = "List_Score"
        Me.List_Score.Size = New System.Drawing.Size(233, 134)
        Me.List_Score.TabIndex = 3
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.List_Score)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.Btn_View)

        Me.Text = "Score"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_View As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents List_Score As System.Windows.Forms.ListBox
End Class
