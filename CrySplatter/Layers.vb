Imports System.Xml
Imports System.IO
Imports System.Text

Public Class Layers

    Private xmlContent As String
    Private heightmapContent As Byte()
    Private layermapContent As Byte()
    Private heightmapFilePos As Integer
    Private layermapFilePos As Integer

    Private Structure LayerRec
        Public Name As String
        Public Id As Byte
        Public SplatFilename As String
        Public SplatLoaded As Byte()
        Public SplatGenerated As Byte()
    End Structure

    Private Structure LayerStr
        Public Size As Integer
        Public Arr As LayerRec()
    End Structure

    Private LayersInfo As LayerStr

    Private Sub Layers_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If Me.Visible = True Then
            Try
                LoadHeightmapDatFile()
                ParseXml()
                DisplayLayersInfo()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Layers_OnClose(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub


    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Visible = 0
        Main.Visible = 1
    End Sub

    Private Sub LoadHeightmapDatFile()
        Dim fileContent As Byte() = My.Computer.FileSystem.ReadAllBytes(Main.SelectedPath & "\Levels\" & Main.SelectedLevel & "\LevelData\Heightmap.dat")

        Dim readPos As Integer = 1 ' to skip 0xff from the start of file
        Dim xmlLength As Integer = BitConverter.ToInt16(fileContent, readPos)
        readPos += 2

        ' read the xml
        Dim xmlArray(xmlLength) As Byte
        Array.Copy(fileContent, readPos, xmlArray, 0, xmlLength - 1)
        xmlContent = System.Text.Encoding.UTF8.GetString(xmlArray)
        TextBoxFileContent.Text = xmlContent
        readPos += xmlLength

        ' read the heightmap
        readPos += 19 ' 4 bytes, 0x0e, and HeightmapDataW
        Dim heightmapLength As Integer = BitConverter.ToInt32(fileContent, readPos)
        readPos += 12 ' 4-byte length, 4-byte length again, 4-byte 0's
        heightmapFilePos = readPos
        ReDim heightmapContent(heightmapLength)
        Array.Copy(fileContent, readPos, heightmapContent, 0, heightmapLength)
        readPos += heightmapLength

        ' read the layer map
        readPos += 28 ' 0x1b and HeightmapLayerIdBitmap_ver2
        Dim layermapLength As Integer = BitConverter.ToInt32(fileContent, readPos)
        readPos += 12 ' 4-byte length, 4-byte length again, 4-byte 0's
        layermapFilePos = readPos
        ReDim layermapContent(layermapLength)
        Array.Copy(fileContent, readPos, layermapContent, 0, layermapLength)
        readPos += layermapLength

        ' what follows is TerrainCompiledData, we don't know how to make use of it, so leave it as is -- it will be written back intact
    End Sub

    Private Sub ParseXml()
        Dim LayerName As String = "", LayerId As String = ""

        ReDim LayersInfo.Arr(-1)
        LayersInfo.Size = -1

        Using reader As XmlReader = XmlReader.Create(New StringReader(xmlContent))
            Try
                While reader.ReadToFollowing("Layer")

                    While reader.MoveToNextAttribute()
                        If reader.Name = "Name" Then
                            LayerName = reader.Value
                        ElseIf reader.Name = "LayerId" Then
                            LayerId = reader.Value

                            ReDim Preserve LayersInfo.Arr(LayersInfo.Size + 1)
                            LayersInfo.Size += 1
                            LayersInfo.Arr(LayersInfo.Size).Name = LayerName
                            LayersInfo.Arr(LayersInfo.Size).Id = LayerId

                        End If
                    End While
                End While
            Catch ex As Exception
                ' do nothing
                'MessageBox.Show(ex.ToString())
            End Try
        End Using
    End Sub

    Private Sub DisplayLayersInfo()

        ListBox1.Items.Clear()
        For Each layer As LayerRec In LayersInfo.Arr
            ListBox1.Items.Add(layer.Name & "-" & layer.Id)
        Next

    End Sub
End Class