<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SetCEFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.CEFolderTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSet = New System.Windows.Forms.Button()
        Me.ButtonScan = New System.Windows.Forms.Button()
        Me.ListBoxLevels = New System.Windows.Forms.ListBox()
        Me.ButtonOpenLevel = New System.Windows.Forms.Button()
        Me.LabelLevels = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SetCEFolderDialog
        '
        Me.SetCEFolderDialog.Description = "Please locate your CRYENGINE directory"
        Me.SetCEFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.SetCEFolderDialog.SelectedPath = "C:\Program Files (x86)\Steam\SteamApps\common\CRYENGINE\GameSDK"
        Me.SetCEFolderDialog.ShowNewFolderButton = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Location = New System.Drawing.Point(12, 221)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(102, 29)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'CEFolderTextBox
        '
        Me.CEFolderTextBox.Location = New System.Drawing.Point(26, 38)
        Me.CEFolderTextBox.Name = "CEFolderTextBox"
        Me.CEFolderTextBox.Size = New System.Drawing.Size(528, 20)
        Me.CEFolderTextBox.TabIndex = 1
        Me.CEFolderTextBox.Text = "C:\Program Files (x86)\Steam\SteamApps\common\CRYENGINE\GameSDK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CRYENGINE Game Folder"
        '
        'ButtonSet
        '
        Me.ButtonSet.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSet.Location = New System.Drawing.Point(622, 36)
        Me.ButtonSet.Name = "ButtonSet"
        Me.ButtonSet.Size = New System.Drawing.Size(39, 23)
        Me.ButtonSet.TabIndex = 3
        Me.ButtonSet.Text = "Set"
        Me.ButtonSet.UseVisualStyleBackColor = False
        '
        'ButtonScan
        '
        Me.ButtonScan.BackColor = System.Drawing.Color.Transparent
        Me.ButtonScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScan.Location = New System.Drawing.Point(560, 36)
        Me.ButtonScan.Name = "ButtonScan"
        Me.ButtonScan.Size = New System.Drawing.Size(56, 23)
        Me.ButtonScan.TabIndex = 2
        Me.ButtonScan.Text = "Scan"
        Me.ButtonScan.UseVisualStyleBackColor = False
        '
        'ListBoxLevels
        '
        Me.ListBoxLevels.FormattingEnabled = True
        Me.ListBoxLevels.Location = New System.Drawing.Point(26, 77)
        Me.ListBoxLevels.Name = "ListBoxLevels"
        Me.ListBoxLevels.Size = New System.Drawing.Size(528, 95)
        Me.ListBoxLevels.TabIndex = 4
        '
        'ButtonOpenLevel
        '
        Me.ButtonOpenLevel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonOpenLevel.Enabled = False
        Me.ButtonOpenLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenLevel.Location = New System.Drawing.Point(573, 221)
        Me.ButtonOpenLevel.Name = "ButtonOpenLevel"
        Me.ButtonOpenLevel.Size = New System.Drawing.Size(99, 29)
        Me.ButtonOpenLevel.TabIndex = 5
        Me.ButtonOpenLevel.Text = "Open Level >>"
        Me.ButtonOpenLevel.UseVisualStyleBackColor = False
        '
        'LabelLevels
        '
        Me.LabelLevels.AutoSize = True
        Me.LabelLevels.Location = New System.Drawing.Point(23, 61)
        Me.LabelLevels.Name = "LabelLevels"
        Me.LabelLevels.Size = New System.Drawing.Size(41, 13)
        Me.LabelLevels.TabIndex = 7
        Me.LabelLevels.Text = "Levels:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.CrySplatter.My.Resources.Resources.round_logo300
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(684, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelButton = Me.ButtonExit
        Me.ClientSize = New System.Drawing.Size(684, 262)
        Me.Controls.Add(Me.LabelLevels)
        Me.Controls.Add(Me.ButtonOpenLevel)
        Me.Controls.Add(Me.ListBoxLevels)
        Me.Controls.Add(Me.ButtonScan)
        Me.Controls.Add(Me.ButtonSet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CEFolderTextBox)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrySplatter v0.1 - Open Level"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SetCEFolderDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents CEFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSet As System.Windows.Forms.Button
    Friend WithEvents ButtonScan As System.Windows.Forms.Button
    Friend WithEvents ListBoxLevels As System.Windows.Forms.ListBox
    Friend WithEvents ButtonOpenLevel As System.Windows.Forms.Button
    Friend WithEvents LabelLevels As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
