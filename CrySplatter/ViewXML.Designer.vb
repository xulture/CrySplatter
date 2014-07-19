<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewXML
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
        Me.RichTextBoxXMLContent = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBoxXMLContent
        '
        Me.RichTextBoxXMLContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxXMLContent.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxXMLContent.Name = "RichTextBoxXMLContent"
        Me.RichTextBoxXMLContent.Size = New System.Drawing.Size(825, 543)
        Me.RichTextBoxXMLContent.TabIndex = 0
        Me.RichTextBoxXMLContent.Text = ""
        '
        'ViewXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(825, 543)
        Me.Controls.Add(Me.RichTextBoxXMLContent)
        Me.KeyPreview = True
        Me.Name = "ViewXML"
        Me.Text = "CrySplatter v0.1 - ViewXML"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBoxXMLContent As System.Windows.Forms.RichTextBox
End Class
