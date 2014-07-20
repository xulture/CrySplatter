<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Layers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Layers))
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListBoxLayersList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBoxLayerProperties = New System.Windows.Forms.RichTextBox()
        Me.PictureBoxMaskPreview = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialogBitmap = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonLoadBitmap = New System.Windows.Forms.Button()
        Me.ButtonSaveBitmap = New System.Windows.Forms.Button()
        Me.SaveFileDialogBitmap = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonWriteLevel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonViewXml = New System.Windows.Forms.Button()
        Me.CheckBoxRotateMaps = New System.Windows.Forms.CheckBox()
        Me.TrackBarCutoff = New System.Windows.Forms.TrackBar()
        Me.ButtonDiscardChanges = New System.Windows.Forms.Button()
        Me.ButtonAbout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMaskPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarCutoff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Location = New System.Drawing.Point(12, 434)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(102, 29)
        Me.ButtonBack.TabIndex = 7
        Me.ButtonBack.Text = "<< Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.CrySplatter.My.Resources.Resources.round_logo300
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(769, 475)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'ListBoxLayersList
        '
        Me.ListBoxLayersList.FormattingEnabled = True
        Me.ListBoxLayersList.Location = New System.Drawing.Point(12, 25)
        Me.ListBoxLayersList.Name = "ListBoxLayersList"
        Me.ListBoxLayersList.Size = New System.Drawing.Size(133, 394)
        Me.ListBoxLayersList.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Layers"
        '
        'RichTextBoxLayerProperties
        '
        Me.RichTextBoxLayerProperties.Location = New System.Drawing.Point(157, 25)
        Me.RichTextBoxLayerProperties.Name = "RichTextBoxLayerProperties"
        Me.RichTextBoxLayerProperties.Size = New System.Drawing.Size(177, 190)
        Me.RichTextBoxLayerProperties.TabIndex = 14
        Me.RichTextBoxLayerProperties.Text = ""
        '
        'PictureBoxMaskPreview
        '
        Me.PictureBoxMaskPreview.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBoxMaskPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxMaskPreview.Location = New System.Drawing.Point(349, 25)
        Me.PictureBoxMaskPreview.Name = "PictureBoxMaskPreview"
        Me.PictureBoxMaskPreview.Size = New System.Drawing.Size(405, 405)
        Me.PictureBoxMaskPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMaskPreview.TabIndex = 15
        Me.PictureBoxMaskPreview.TabStop = False
        '
        'OpenFileDialogBitmap
        '
        Me.OpenFileDialogBitmap.FileName = "*.bmp"
        '
        'ButtonLoadBitmap
        '
        Me.ButtonLoadBitmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLoadBitmap.Location = New System.Drawing.Point(157, 251)
        Me.ButtonLoadBitmap.Name = "ButtonLoadBitmap"
        Me.ButtonLoadBitmap.Size = New System.Drawing.Size(80, 29)
        Me.ButtonLoadBitmap.TabIndex = 16
        Me.ButtonLoadBitmap.Text = "Load Bitmap"
        Me.ButtonLoadBitmap.UseVisualStyleBackColor = True
        '
        'ButtonSaveBitmap
        '
        Me.ButtonSaveBitmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveBitmap.Location = New System.Drawing.Point(254, 251)
        Me.ButtonSaveBitmap.Name = "ButtonSaveBitmap"
        Me.ButtonSaveBitmap.Size = New System.Drawing.Size(80, 29)
        Me.ButtonSaveBitmap.TabIndex = 17
        Me.ButtonSaveBitmap.Text = "Save Bitmap"
        Me.ButtonSaveBitmap.UseVisualStyleBackColor = True
        '
        'SaveFileDialogBitmap
        '
        '
        'ButtonWriteLevel
        '
        Me.ButtonWriteLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonWriteLevel.Location = New System.Drawing.Point(241, 434)
        Me.ButtonWriteLevel.Name = "ButtonWriteLevel"
        Me.ButtonWriteLevel.Size = New System.Drawing.Size(102, 29)
        Me.ButtonWriteLevel.TabIndex = 18
        Me.ButtonWriteLevel.Text = "Save To Engine"
        Me.ButtonWriteLevel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Layer Info"
        '
        'ButtonViewXml
        '
        Me.ButtonViewXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonViewXml.Location = New System.Drawing.Point(158, 286)
        Me.ButtonViewXml.Name = "ButtonViewXml"
        Me.ButtonViewXml.Size = New System.Drawing.Size(80, 29)
        Me.ButtonViewXml.TabIndex = 20
        Me.ButtonViewXml.Text = "View XML"
        Me.ButtonViewXml.UseVisualStyleBackColor = True
        '
        'CheckBoxRotateMaps
        '
        Me.CheckBoxRotateMaps.AutoSize = True
        Me.CheckBoxRotateMaps.Checked = True
        Me.CheckBoxRotateMaps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRotateMaps.Location = New System.Drawing.Point(158, 228)
        Me.CheckBoxRotateMaps.Name = "CheckBoxRotateMaps"
        Me.CheckBoxRotateMaps.Size = New System.Drawing.Size(160, 17)
        Me.CheckBoxRotateMaps.TabIndex = 21
        Me.CheckBoxRotateMaps.Text = "Rotate Maps When Loading"
        Me.CheckBoxRotateMaps.UseVisualStyleBackColor = True
        '
        'TrackBarCutoff
        '
        Me.TrackBarCutoff.LargeChange = 16
        Me.TrackBarCutoff.Location = New System.Drawing.Point(349, 430)
        Me.TrackBarCutoff.Maximum = 255
        Me.TrackBarCutoff.Name = "TrackBarCutoff"
        Me.TrackBarCutoff.Size = New System.Drawing.Size(405, 45)
        Me.TrackBarCutoff.TabIndex = 22
        Me.TrackBarCutoff.TickFrequency = 16
        Me.TrackBarCutoff.Value = 128
        '
        'ButtonDiscardChanges
        '
        Me.ButtonDiscardChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDiscardChanges.Location = New System.Drawing.Point(120, 434)
        Me.ButtonDiscardChanges.Name = "ButtonDiscardChanges"
        Me.ButtonDiscardChanges.Size = New System.Drawing.Size(115, 29)
        Me.ButtonDiscardChanges.TabIndex = 23
        Me.ButtonDiscardChanges.Text = "Discard and Reload"
        Me.ButtonDiscardChanges.UseVisualStyleBackColor = True
        '
        'ButtonAbout
        '
        Me.ButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAbout.Location = New System.Drawing.Point(314, 399)
        Me.ButtonAbout.Name = "ButtonAbout"
        Me.ButtonAbout.Size = New System.Drawing.Size(29, 29)
        Me.ButtonAbout.TabIndex = 24
        Me.ButtonAbout.Text = "?"
        Me.ButtonAbout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Layer Mask Preview"
        '
        'Layers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(769, 475)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonAbout)
        Me.Controls.Add(Me.ButtonDiscardChanges)
        Me.Controls.Add(Me.TrackBarCutoff)
        Me.Controls.Add(Me.CheckBoxRotateMaps)
        Me.Controls.Add(Me.ButtonViewXml)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonWriteLevel)
        Me.Controls.Add(Me.ButtonSaveBitmap)
        Me.Controls.Add(Me.ButtonLoadBitmap)
        Me.Controls.Add(Me.PictureBoxMaskPreview)
        Me.Controls.Add(Me.RichTextBoxLayerProperties)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxLayersList)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Layers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrySplatter v0.1 - Layers"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMaskPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarCutoff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBoxLayersList As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxLayerProperties As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBoxMaskPreview As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialogBitmap As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonLoadBitmap As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveBitmap As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialogBitmap As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ButtonWriteLevel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonViewXml As System.Windows.Forms.Button
    Friend WithEvents CheckBoxRotateMaps As System.Windows.Forms.CheckBox
    Friend WithEvents TrackBarCutoff As System.Windows.Forms.TrackBar
    Friend WithEvents ButtonDiscardChanges As System.Windows.Forms.Button
    Friend WithEvents ButtonAbout As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
