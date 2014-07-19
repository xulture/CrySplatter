Imports System.Xml
Imports System.IO
Imports System.Text

Public Class Layers

    Private fileContent As Byte()
    Private filename As String
    Private xmlContent As String
    Private heightmapContent As Byte()
    Private layermapContent As Byte()
    Private heightmapFilePos As Integer
    Private layermapFilePos As Integer
    Private currentBitmap As Bitmap

    Private Structure LayerRec
        Public Name As String
        Public Id As Byte ' layer id in Heightmap.dat
        Public SplatFilename As String
        Public SplatLoaded As Byte()
        Public SplatGenerated As Byte()
    End Structure

    Private Structure LayerStr
        Public Size As Integer
        Public Width As Integer
        Public Height As Integer
        Public Arr As LayerRec()
    End Structure

    Private LayersInfo As LayerStr

    Private Sub Layers_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If Me.Visible = True Then
            Try
                ButtonLoadBitmap.Enabled = False
                ButtonSaveBitmap.Enabled = False
                ButtonWriteLevel.Enabled = False
                LoadHeightmapDatFile()
                ParseXml()
                DisplayLayersInfo()
                RichTextBoxLayerProperties.Clear()
                RichTextBoxLayerProperties.AppendText("Level Name: " & Main.SelectedLevel & Environment.NewLine)
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
        filename = Main.SelectedPath & "\Levels\" & Main.SelectedLevel & "\LevelData\Heightmap.dat"
        fileContent = My.Computer.FileSystem.ReadAllBytes(filename)

        Dim readPos As Integer = 1 ' to skip 0xff from the start of file
        Dim xmlLength As Integer = BitConverter.ToInt16(fileContent, readPos)
        readPos += 2

        ' read the xml
        Dim xmlArray(xmlLength) As Byte
        Array.Copy(fileContent, readPos, xmlArray, 0, xmlLength - 1)
        xmlContent = System.Text.Encoding.UTF8.GetString(xmlArray)
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
                While reader.ReadToFollowing("Heightmap")
                    While reader.MoveToNextAttribute()
                        If reader.Name = "Width" Then
                            LayersInfo.Width = reader.Value
                        ElseIf reader.Name = "Height" Then
                            LayersInfo.Height = reader.Value
                        End If
                    End While

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
                End While
            Catch ex As Exception
                ' do nothing
                'MessageBox.Show(ex.ToString())
            End Try
        End Using
    End Sub

    Private Sub DisplayLayersInfo()

        ListBoxLayersList.Items.Clear()
        RichTextBoxLayerProperties.Clear()
        PictureBoxMaskPreview.Image = New Bitmap(1, 1)
        For Idx As Integer = 0 To LayersInfo.Size
            ListBoxLayersList.Items.Add(LayersInfo.Arr(Idx).Id & ": " & LayersInfo.Arr(Idx).Name)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLayersList.SelectedIndexChanged
        RichTextBoxLayerProperties.Clear()
        RichTextBoxLayerProperties.AppendText("Level Name: " & Main.SelectedLevel & Environment.NewLine)

        Dim layer As LayerRec = LayersInfo.Arr(ListBoxLayersList.SelectedIndex)
        RichTextBoxLayerProperties.AppendText("Heightmap size " & LayersInfo.Width & "x" & LayersInfo.Height & Environment.NewLine)
        RichTextBoxLayerProperties.AppendText(layer.Id & ": " & layer.Name & Environment.NewLine)

        ' count how many times used in bitmap
        Dim count As Integer = 0
        For Each id As Byte In layermapContent
            If id = layer.Id Then
                count += 1
            End If
        Next
        RichTextBoxLayerProperties.AppendText("Number of tiles: " & count & Environment.NewLine)

        Dim map As New Bitmap(LayersInfo.Width, LayersInfo.Height)
        Dim mapGraphics As Graphics = Graphics.FromImage(map)
        mapGraphics.Clear(Color.Black)

        Dim rect As New Rectangle(0, 0, map.Width, map.Height)
        Dim mapData As System.Drawing.Imaging.BitmapData = map.LockBits(rect, Drawing.Imaging.ImageLockMode.ReadWrite, map.PixelFormat)

        Dim bytes As Integer = Math.Abs(mapData.Stride) * map.Height
        Dim rgbValues(bytes - 1) As Byte

        Dim ptr As IntPtr = mapData.Scan0
        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes)

        For Idx As Integer = 0 To rgbValues.Length - 1 Step 4
            If layer.Id = layermapContent(Idx / 4) Then
                rgbValues(Idx) = 255
                rgbValues(Idx + 1) = 255
                rgbValues(Idx + 2) = 255
            End If
        Next

        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes)
        map.UnlockBits(mapData)

        PictureBoxMaskPreview.Image = map
        currentBitmap = map
        ButtonLoadBitmap.Enabled = True
        ButtonSaveBitmap.Enabled = True

    End Sub

    Private Sub ButtonLoadBitmap_Click(sender As Object, e As EventArgs) Handles ButtonLoadBitmap.Click
        OpenFileDialogBitmap.FileName = "*.bmp"
        OpenFileDialogBitmap.Filter = "Bitmap|*.bmp"
        OpenFileDialogBitmap.ShowDialog()
    End Sub

    Private Sub OpenFileDialogBitmap_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogBitmap.FileOk
        ' load bitmap & display
        Dim bmp As New Bitmap(OpenFileDialogBitmap.FileName)
        PictureBoxMaskPreview.Image = bmp
        currentBitmap = bmp
        ButtonWriteLevel.Enabled = True

        ' rewrite layer map data
        Dim rect As New Rectangle(0, 0, bmp.Width, bmp.Height)
        Dim mapData As System.Drawing.Imaging.BitmapData = bmp.LockBits(rect, Drawing.Imaging.ImageLockMode.ReadOnly, bmp.PixelFormat)

        Dim bytes As Integer = Math.Abs(mapData.Stride) * bmp.Height
        Dim rgbValues(bytes - 1) As Byte

        Dim bytesPerPixel As Integer = Math.Abs(mapData.Stride) / bmp.Width

        Dim ptr As IntPtr = mapData.Scan0
        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes)

        Dim layer As LayerRec = LayersInfo.Arr(ListBoxLayersList.SelectedIndex)
        For Idx As Integer = 0 To rgbValues.Length - 1 Step bytesPerPixel
            Dim weight As Single = 1.0
            For j As Integer = 0 To bytesPerPixel - 1
                weight *= rgbValues(Idx + j) / 128 ' result of 1.0 is exactly half way
            Next

            If weight > 1.0 Then
                layermapContent(Idx / bytesPerPixel) = layer.Id
            End If

        Next
        bmp.UnlockBits(mapData)

    End Sub

    Private Sub ButtonSaveBitmap_Click(sender As Object, e As EventArgs) Handles ButtonSaveBitmap.Click
        SaveFileDialogBitmap.Filter = "Bitmap|*.bmp"
        SaveFileDialogBitmap.ShowDialog()
    End Sub

    Private Sub SaveFileDialogBitmap_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialogBitmap.FileOk
        currentBitmap.Save(SaveFileDialogBitmap.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

    Private Sub ButtonWriteLevel_Click(sender As Object, e As EventArgs) Handles ButtonWriteLevel.Click

        Array.Copy(layermapContent, 0, fileContent, layermapFilePos, layermapContent.Length)
        System.IO.File.Copy(filename, filename & ".crysplat.bak", True)
        My.Computer.FileSystem.WriteAllBytes(filename, fileContent, False)
    End Sub

    Private Sub ButtonViewXml_Click(sender As Object, e As EventArgs) Handles ButtonViewXml.Click
        ViewXML.RichTextBoxXMLContent.Clear()
        ViewXML.RichTextBoxXMLContent.Text = xmlContent
        ViewXML.Show()
    End Sub

End Class