Public Class Main

    Public SelectedPath As String
    Private SelectedIndex As Integer
    Public SelectedLevel As String

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonSet_Click(sender As Object, e As EventArgs) Handles ButtonSet.Click
        Dim result As DialogResult = SetCEFolderDialog.ShowDialog()
        Dim selectedPath As String
        If (result = Windows.Forms.DialogResult.OK) Then
            selectedPath = SetCEFolderDialog.SelectedPath
            CEFolderTextBox.Text = selectedPath
            CEFolderTextBox.Update()

            PopulateLevelsList(selectedPath)
        End If
    End Sub

    Private Sub PopulateLevelsList(path As String)
        ListBoxLevels.Items.Clear()

        Me.Update()

        For Each levelPath As String In IO.Directory.GetDirectories(path, "Levels", IO.SearchOption.TopDirectoryOnly)

            For Each heightmapFile As String In IO.Directory.GetFiles(levelPath, "Heightmap.dat", IO.SearchOption.AllDirectories)
                Dim levelName As String = Replace(heightmapFile, levelPath & "\", "")
                levelName = Replace(levelName, "\LevelData\Heightmap.dat", "")
                ListBoxLevels.Items.Add(levelName)
                Me.Update()
                SelectedPath = path
            Next

            ListBoxLevels.Focus()
        Next
        My.Settings.CEGameFolder = path
        My.Settings.Save()

    End Sub

    Private Sub ButtonScan_Click(sender As Object, e As EventArgs) Handles ButtonScan.Click
        PopulateLevelsList(CEFolderTextBox.Text)
    End Sub

    Private Sub CEFolderTextBox_OnEnter(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CEFolderTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonScan.Focus()
            PopulateLevelsList(CEFolderTextBox.Text)
        End If
    End Sub

    Private Sub ListBoxLevels_OnSelect(sender As Object, e As EventArgs) Handles ListBoxLevels.SelectedIndexChanged
        SelectedIndex = ListBoxLevels.SelectedIndex

        If SelectedIndex >= 0 Then
            SelectedLevel = ListBoxLevels.Items.Item(SelectedIndex)
            ButtonOpenLevel.Enabled = True
        Else
            SelectedLevel = ""
        End If

    End Sub

    Private Sub ListBoxLevels_OnDoubleClick(sender As Object, e As EventArgs) Handles ListBoxLevels.DoubleClick
        If SelectedIndex >= 0 Then
            OpenLayersForm()
        End If
    End Sub


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        Dim savedFolder As String = My.Settings.CEGameFolder
        If savedFolder <> "" Then
            CEFolderTextBox.Text = savedFolder
            PopulateLevelsList(savedFolder)
        End If
    End Sub

    Private Sub OpenLayersForm()
        Me.Visible = 0

        Layers.Show()
    End Sub

    Private Sub ButtonOpenLevel_Click(sender As Object, e As EventArgs) Handles ButtonOpenLevel.Click
        OpenLayersForm()
    End Sub
End Class
