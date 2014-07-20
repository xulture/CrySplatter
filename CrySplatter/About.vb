Public Class About

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim AboutContent As String = "CrySplatter lets you import splatmaps and assign them to your terrain layer." & Environment.NewLine &
            "Output is then saved back into level, and CRYENGINE Sandbox can re-open the level" & Environment.NewLine &
            "" & Environment.NewLine &
            "Note that only Editor functionality is enhanced, modified levels will need to be exported to Engine for final gameplay" & Environment.NewLine &
            "" & Environment.NewLine &
            "For further information and binary download visit CryDev forums at http://www.crydev.net/viewtopic.php?f=311&t=125214" & Environment.NewLine &
            "" & Environment.NewLine &
            "Source code available at https://github.com/xulture/CrySplatter"


        Dim LicenceContent As String = "CrySplatter - CRYENGINE Splatmap load tool" & Environment.NewLine &
            "Copyright (C) 2014  Allegra Games" & Environment.NewLine &
            "" & Environment.NewLine &
            "This program is free software: you can redistribute it and/or modify" & Environment.NewLine &
            "it under the terms of the GNU General Public License as published by" & Environment.NewLine &
            "the Free Software Foundation, either version 3 of the License, or" & Environment.NewLine &
            "(at your option) any later version." & Environment.NewLine &
            "        " & Environment.NewLine &
            "This program is distributed in the hope that it will be useful," & Environment.NewLine &
            "but WITHOUT ANY WARRANTY; without even the implied warranty of" & Environment.NewLine &
            "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" & Environment.NewLine &
            "GNU General Public License for more details." & Environment.NewLine &
            "        " & Environment.NewLine &
            "You should have received a copy of the GNU General Public License" & Environment.NewLine &
            "along with this program.  If not, see <http://www.gnu.org/licenses/>."

        RichTextBoxAbout.Clear()
        RichTextBoxAbout.AppendText(AboutContent)

        RichTextBoxLicence.Clear()
        RichTextBoxLicence.AppendText(LicenceContent)

    End Sub

    Private Sub RichTextBoxLicence_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBoxLicence.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub RichTextBoxAbout_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBoxAbout.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

End Class