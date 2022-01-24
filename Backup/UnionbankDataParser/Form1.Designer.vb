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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cmdInclude = New System.Windows.Forms.Button
        Me.cmdDontInclude = New System.Windows.Forms.Button
        Me.cmdProceed = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(536, 221)
        Me.DataGridView1.TabIndex = 0
        '
        'cmdInclude
        '
        Me.cmdInclude.Location = New System.Drawing.Point(12, 235)
        Me.cmdInclude.Name = "cmdInclude"
        Me.cmdInclude.Size = New System.Drawing.Size(88, 35)
        Me.cmdInclude.TabIndex = 1
        Me.cmdInclude.Text = "Include"
        Me.cmdInclude.UseVisualStyleBackColor = True
        '
        'cmdDontInclude
        '
        Me.cmdDontInclude.Location = New System.Drawing.Point(109, 235)
        Me.cmdDontInclude.Name = "cmdDontInclude"
        Me.cmdDontInclude.Size = New System.Drawing.Size(88, 35)
        Me.cmdDontInclude.TabIndex = 2
        Me.cmdDontInclude.Text = "Do not include"
        Me.cmdDontInclude.UseVisualStyleBackColor = True
        '
        'cmdProceed
        '
        Me.cmdProceed.Location = New System.Drawing.Point(426, 235)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(98, 35)
        Me.cmdProceed.TabIndex = 3
        Me.cmdProceed.Text = "Proceed"
        Me.cmdProceed.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdProceed)
        Me.Controls.Add(Me.cmdDontInclude)
        Me.Controls.Add(Me.cmdInclude)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdInclude As System.Windows.Forms.Button
    Friend WithEvents cmdDontInclude As System.Windows.Forms.Button
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
