<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Decryption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Decryption))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.checkbox_FileDecrypted = New System.Windows.Forms.CheckBox
        Me.button_Browse = New System.Windows.Forms.Button
        Me.textbox_FilePath = New System.Windows.Forms.TextBox
        Me.tabcontrol_UBP = New System.Windows.Forms.TabControl
        Me.tabpage_Encrypted = New System.Windows.Forms.TabPage
        Me.progress_Decryption = New System.Windows.Forms.ProgressBar
        Me.button_Decrypt = New System.Windows.Forms.Button
        Me.richtextbox_Encrypted = New System.Windows.Forms.RichTextBox
        Me.tabpage_Decrypted = New System.Windows.Forms.TabPage
        Me.progress_Parsing = New System.Windows.Forms.ProgressBar
        Me.button_Parse = New System.Windows.Forms.Button
        Me.button_Save = New System.Windows.Forms.Button
        Me.richtextbox_Decrypted = New System.Windows.Forms.RichTextBox
        Me.tabpage_Parsed = New System.Windows.Forms.TabPage
        Me.button_SaveParsed = New System.Windows.Forms.Button
        Me.richtextbox_Parsed = New System.Windows.Forms.RichTextBox
        Me.tabpage_Segregate = New System.Windows.Forms.TabPage
        Me.cmdSegregate = New System.Windows.Forms.Button
        Me.progressbarSegregate = New System.Windows.Forms.ProgressBar
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tabcontrol_UBP.SuspendLayout()
        Me.tabpage_Encrypted.SuspendLayout()
        Me.tabpage_Decrypted.SuspendLayout()
        Me.tabpage_Parsed.SuspendLayout()
        Me.tabpage_Segregate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 77)
        Me.Panel1.TabIndex = 45
        Me.Panel1.TabStop = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(713, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 14)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Powered By"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(601, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.checkbox_FileDecrypted)
        Me.GroupBox1.Controls.Add(Me.button_Browse)
        Me.GroupBox1.Controls.Add(Me.textbox_FilePath)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 50)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unionbank Text File"
        '
        'checkbox_FileDecrypted
        '
        Me.checkbox_FileDecrypted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkbox_FileDecrypted.AutoSize = True
        Me.checkbox_FileDecrypted.Location = New System.Drawing.Point(599, 21)
        Me.checkbox_FileDecrypted.Name = "checkbox_FileDecrypted"
        Me.checkbox_FileDecrypted.Size = New System.Drawing.Size(82, 18)
        Me.checkbox_FileDecrypted.TabIndex = 49
        Me.checkbox_FileDecrypted.Text = "Decrypted"
        Me.checkbox_FileDecrypted.UseVisualStyleBackColor = True
        '
        'button_Browse
        '
        Me.button_Browse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_Browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Browse.Location = New System.Drawing.Point(687, 18)
        Me.button_Browse.Name = "button_Browse"
        Me.button_Browse.Size = New System.Drawing.Size(75, 23)
        Me.button_Browse.TabIndex = 1
        Me.button_Browse.Text = "Browse"
        Me.button_Browse.UseVisualStyleBackColor = True
        '
        'textbox_FilePath
        '
        Me.textbox_FilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_FilePath.BackColor = System.Drawing.Color.White
        Me.textbox_FilePath.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_FilePath.Location = New System.Drawing.Point(10, 19)
        Me.textbox_FilePath.Name = "textbox_FilePath"
        Me.textbox_FilePath.ReadOnly = True
        Me.textbox_FilePath.Size = New System.Drawing.Size(583, 22)
        Me.textbox_FilePath.TabIndex = 0
        '
        'tabcontrol_UBP
        '
        Me.tabcontrol_UBP.Controls.Add(Me.tabpage_Encrypted)
        Me.tabcontrol_UBP.Controls.Add(Me.tabpage_Decrypted)
        Me.tabcontrol_UBP.Controls.Add(Me.tabpage_Parsed)
        Me.tabcontrol_UBP.Controls.Add(Me.tabpage_Segregate)
        Me.tabcontrol_UBP.Location = New System.Drawing.Point(12, 139)
        Me.tabcontrol_UBP.Name = "tabcontrol_UBP"
        Me.tabcontrol_UBP.SelectedIndex = 0
        Me.tabcontrol_UBP.Size = New System.Drawing.Size(768, 64)
        Me.tabcontrol_UBP.TabIndex = 47
        '
        'tabpage_Encrypted
        '
        Me.tabpage_Encrypted.Controls.Add(Me.progress_Decryption)
        Me.tabpage_Encrypted.Controls.Add(Me.button_Decrypt)
        Me.tabpage_Encrypted.Controls.Add(Me.richtextbox_Encrypted)
        Me.tabpage_Encrypted.Location = New System.Drawing.Point(4, 23)
        Me.tabpage_Encrypted.Name = "tabpage_Encrypted"
        Me.tabpage_Encrypted.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_Encrypted.Size = New System.Drawing.Size(760, 37)
        Me.tabpage_Encrypted.TabIndex = 0
        Me.tabpage_Encrypted.Text = "Encrypted Data"
        Me.tabpage_Encrypted.UseVisualStyleBackColor = True
        '
        'progress_Decryption
        '
        Me.progress_Decryption.Location = New System.Drawing.Point(181, 6)
        Me.progress_Decryption.MarqueeAnimationSpeed = 10
        Me.progress_Decryption.Name = "progress_Decryption"
        Me.progress_Decryption.Size = New System.Drawing.Size(573, 23)
        Me.progress_Decryption.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progress_Decryption.TabIndex = 50
        Me.progress_Decryption.Visible = False
        '
        'button_Decrypt
        '
        Me.button_Decrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Decrypt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Decrypt.Location = New System.Drawing.Point(6, 6)
        Me.button_Decrypt.Name = "button_Decrypt"
        Me.button_Decrypt.Size = New System.Drawing.Size(169, 23)
        Me.button_Decrypt.TabIndex = 49
        Me.button_Decrypt.Text = "Start Decryption"
        Me.button_Decrypt.UseVisualStyleBackColor = True
        '
        'richtextbox_Encrypted
        '
        Me.richtextbox_Encrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.richtextbox_Encrypted.Location = New System.Drawing.Point(6, 38)
        Me.richtextbox_Encrypted.Name = "richtextbox_Encrypted"
        Me.richtextbox_Encrypted.ReadOnly = True
        Me.richtextbox_Encrypted.Size = New System.Drawing.Size(748, 353)
        Me.richtextbox_Encrypted.TabIndex = 48
        Me.richtextbox_Encrypted.Text = ""
        Me.richtextbox_Encrypted.Visible = False
        Me.richtextbox_Encrypted.WordWrap = False
        '
        'tabpage_Decrypted
        '
        Me.tabpage_Decrypted.Controls.Add(Me.progress_Parsing)
        Me.tabpage_Decrypted.Controls.Add(Me.button_Parse)
        Me.tabpage_Decrypted.Controls.Add(Me.button_Save)
        Me.tabpage_Decrypted.Controls.Add(Me.richtextbox_Decrypted)
        Me.tabpage_Decrypted.Location = New System.Drawing.Point(4, 23)
        Me.tabpage_Decrypted.Name = "tabpage_Decrypted"
        Me.tabpage_Decrypted.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_Decrypted.Size = New System.Drawing.Size(760, 37)
        Me.tabpage_Decrypted.TabIndex = 1
        Me.tabpage_Decrypted.Text = "Decrypted Data"
        Me.tabpage_Decrypted.UseVisualStyleBackColor = True
        '
        'progress_Parsing
        '
        Me.progress_Parsing.Location = New System.Drawing.Point(355, 6)
        Me.progress_Parsing.MarqueeAnimationSpeed = 10
        Me.progress_Parsing.Name = "progress_Parsing"
        Me.progress_Parsing.Size = New System.Drawing.Size(399, 23)
        Me.progress_Parsing.TabIndex = 52
        Me.progress_Parsing.Visible = False
        '
        'button_Parse
        '
        Me.button_Parse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Parse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Parse.Location = New System.Drawing.Point(181, 6)
        Me.button_Parse.Name = "button_Parse"
        Me.button_Parse.Size = New System.Drawing.Size(169, 23)
        Me.button_Parse.TabIndex = 51
        Me.button_Parse.Text = "Parse Data"
        Me.button_Parse.UseVisualStyleBackColor = True
        '
        'button_Save
        '
        Me.button_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Save.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Save.Location = New System.Drawing.Point(6, 6)
        Me.button_Save.Name = "button_Save"
        Me.button_Save.Size = New System.Drawing.Size(169, 23)
        Me.button_Save.TabIndex = 50
        Me.button_Save.Text = "Save"
        Me.button_Save.UseVisualStyleBackColor = True
        '
        'richtextbox_Decrypted
        '
        Me.richtextbox_Decrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.richtextbox_Decrypted.Location = New System.Drawing.Point(6, 35)
        Me.richtextbox_Decrypted.Name = "richtextbox_Decrypted"
        Me.richtextbox_Decrypted.ReadOnly = True
        Me.richtextbox_Decrypted.Size = New System.Drawing.Size(748, 353)
        Me.richtextbox_Decrypted.TabIndex = 49
        Me.richtextbox_Decrypted.Text = ""
        Me.richtextbox_Decrypted.Visible = False
        Me.richtextbox_Decrypted.WordWrap = False
        '
        'tabpage_Parsed
        '
        Me.tabpage_Parsed.Controls.Add(Me.button_SaveParsed)
        Me.tabpage_Parsed.Controls.Add(Me.richtextbox_Parsed)
        Me.tabpage_Parsed.Location = New System.Drawing.Point(4, 23)
        Me.tabpage_Parsed.Name = "tabpage_Parsed"
        Me.tabpage_Parsed.Size = New System.Drawing.Size(760, 37)
        Me.tabpage_Parsed.TabIndex = 2
        Me.tabpage_Parsed.Text = "Parsed Data"
        Me.tabpage_Parsed.UseVisualStyleBackColor = True
        '
        'button_SaveParsed
        '
        Me.button_SaveParsed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_SaveParsed.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_SaveParsed.Location = New System.Drawing.Point(6, 6)
        Me.button_SaveParsed.Name = "button_SaveParsed"
        Me.button_SaveParsed.Size = New System.Drawing.Size(169, 23)
        Me.button_SaveParsed.TabIndex = 51
        Me.button_SaveParsed.Text = "Save"
        Me.button_SaveParsed.UseVisualStyleBackColor = True
        '
        'richtextbox_Parsed
        '
        Me.richtextbox_Parsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.richtextbox_Parsed.Location = New System.Drawing.Point(6, 35)
        Me.richtextbox_Parsed.Name = "richtextbox_Parsed"
        Me.richtextbox_Parsed.ReadOnly = True
        Me.richtextbox_Parsed.Size = New System.Drawing.Size(748, 353)
        Me.richtextbox_Parsed.TabIndex = 50
        Me.richtextbox_Parsed.Text = ""
        Me.richtextbox_Parsed.Visible = False
        Me.richtextbox_Parsed.WordWrap = False
        '
        'tabpage_Segregate
        '
        Me.tabpage_Segregate.Controls.Add(Me.progressbarSegregate)
        Me.tabpage_Segregate.Controls.Add(Me.cmdSegregate)
        Me.tabpage_Segregate.Location = New System.Drawing.Point(4, 23)
        Me.tabpage_Segregate.Name = "tabpage_Segregate"
        Me.tabpage_Segregate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_Segregate.Size = New System.Drawing.Size(760, 37)
        Me.tabpage_Segregate.TabIndex = 3
        Me.tabpage_Segregate.Text = "Segregate"
        Me.tabpage_Segregate.UseVisualStyleBackColor = True
        '
        'cmdSegregate
        '
        Me.cmdSegregate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSegregate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSegregate.Location = New System.Drawing.Point(6, 7)
        Me.cmdSegregate.Name = "cmdSegregate"
        Me.cmdSegregate.Size = New System.Drawing.Size(169, 23)
        Me.cmdSegregate.TabIndex = 51
        Me.cmdSegregate.Text = "Start Segregation"
        Me.cmdSegregate.UseVisualStyleBackColor = True
        '
        'progressbarSegregate
        '
        Me.progressbarSegregate.Location = New System.Drawing.Point(181, 7)
        Me.progressbarSegregate.Name = "progressbarSegregate"
        Me.progressbarSegregate.Size = New System.Drawing.Size(573, 23)
        Me.progressbarSegregate.TabIndex = 53
        '
        'form_Decryption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 209)
        Me.Controls.Add(Me.tabcontrol_UBP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_Decryption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Card Tech - UBP Data Decryption Tool"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabcontrol_UBP.ResumeLayout(False)
        Me.tabpage_Encrypted.ResumeLayout(False)
        Me.tabpage_Decrypted.ResumeLayout(False)
        Me.tabpage_Parsed.ResumeLayout(False)
        Me.tabpage_Segregate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents button_Browse As System.Windows.Forms.Button
    Friend WithEvents textbox_FilePath As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrol_UBP As System.Windows.Forms.TabControl
    Friend WithEvents tabpage_Encrypted As System.Windows.Forms.TabPage
    Friend WithEvents richtextbox_Encrypted As System.Windows.Forms.RichTextBox
    Friend WithEvents tabpage_Decrypted As System.Windows.Forms.TabPage
    Friend WithEvents richtextbox_Decrypted As System.Windows.Forms.RichTextBox
    Friend WithEvents progress_Decryption As System.Windows.Forms.ProgressBar
    Friend WithEvents button_Decrypt As System.Windows.Forms.Button
    Friend WithEvents button_Save As System.Windows.Forms.Button
    Friend WithEvents progress_Parsing As System.Windows.Forms.ProgressBar
    Friend WithEvents button_Parse As System.Windows.Forms.Button
    Friend WithEvents tabpage_Parsed As System.Windows.Forms.TabPage
    Friend WithEvents button_SaveParsed As System.Windows.Forms.Button
    Friend WithEvents richtextbox_Parsed As System.Windows.Forms.RichTextBox
    Friend WithEvents checkbox_FileDecrypted As System.Windows.Forms.CheckBox
    Friend WithEvents tabpage_Segregate As System.Windows.Forms.TabPage
    Friend WithEvents cmdSegregate As System.Windows.Forms.Button
    Friend WithEvents progressbarSegregate As System.Windows.Forms.ProgressBar

End Class
