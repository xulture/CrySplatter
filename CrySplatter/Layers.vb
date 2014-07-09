Public Class Layers

    Private Sub Layers_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If Me.Visible = True Then

            Dim fileContent As Byte() = My.Computer.FileSystem.ReadAllBytes(Main.SelectedPath & "\Levels\" & Main.SelectedLevel & "\LevelData\Heightmap.dat")

            Dim length As Integer = fileContent(1) + fileContent(2) * 256

            Dim substr(length) As Byte

            Array.Copy(fileContent, 3, substr, 0, length)
            TextBoxFileContent.Text = System.Text.Encoding.UTF8.GetString(substr)
        End If
    End Sub

    Private Sub Layers_OnClose(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub


    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Visible = 0
        Main.Visible = 1
    End Sub
End Class