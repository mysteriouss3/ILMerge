Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports ILMerging

Public Class MainForm

#Region "Main methods"

    ''' <summary>
    ''' Gets a friendly assembly version.
    ''' </summary>
    ''' <returns>Major.Minor.Build version</returns>
    Public Shared Function GetFriendlyVersion(ByVal objAssembly As Assembly) As String

        Dim version As Version = objAssembly.GetName().Version
        Return version.Major & "." & version.Minor & "." & version.Build

    End Function

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.FirstRun Then
            My.Settings.Upgrade()
            My.Settings.FirstRun = False
        End If

        Text &= " " & GetFriendlyVersion(Assembly.GetExecutingAssembly())

        ChkCopyAttributes.Checked = My.Settings.CopyAttributes
        ChkUnionDuplicates.Checked = My.Settings.UnionDuplicates
        CboTargetFramework.SelectedIndex = My.Settings.FrameworkIndex

        If My.Settings.Debug Then
            CboDebug.SelectedIndex = 1
        Else
            CboDebug.SelectedIndex = 0
        End If

        If Not String.IsNullOrEmpty(My.Settings.LastFolder) Then
            OpenFile.InitialDirectory = My.Settings.LastFolder
        End If

    End Sub

    Private Sub MainForm_HelpRequested(ByVal sender As System.Object, ByVal hlpevent As HelpEventArgs) Handles MyBase.HelpRequested

        Process.Start("http://ilmerge-gui.devv.com/")
        hlpevent.Handled = True

    End Sub

    Private Sub OpenFile_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFile.FileOk

        My.Settings.LastFolder = Path.GetDirectoryName(OpenFile.FileName)

    End Sub

#End Region

#Region "Add assembiles"

    Private Sub ButAddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAddFile.Click

        Dim arrFiles() As String
        Dim blnDuplicate As Boolean
        Dim strExtension As String
        Dim i As Integer
        Dim z As Integer

        OpenFile.CheckFileExists = True
        OpenFile.Multiselect = True
        OpenFile.FileName = String.Empty
        OpenFile.Filter = ".NET Assembly|*.dll;*.exe"

        If OpenFile.ShowDialog() = DialogResult.OK Then

            ButMerge.Enabled = True

            arrFiles = OpenFile.FileNames()

            For i = 0 To arrFiles.Length - 1

                strExtension = Path.GetExtension(arrFiles(i)).ToLower().Replace(".", "")

                If strExtension <> "dll" AndAlso strExtension <> "exe" Then
                    Continue For
                End If

                blnDuplicate = False

                For z = 0 To ListAssembly.Items.Count - 1
                    If arrFiles(i) = ListAssembly.Items(z).ToString() Then
                        blnDuplicate = True
                    End If
                Next

                If Not blnDuplicate Then
                    ListAssembly.Items.Add(arrFiles(i))
                End If

            Next

        End If

    End Sub

    Private Sub ListAssembly_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListAssembly.SelectedIndexChanged

        If ListAssembly.Items.Count > 0 Then
            ButMerge.Enabled = True
        Else
            ButMerge.Enabled = False
        End If

        If Not ListAssembly.SelectedItem Is Nothing Then
            LblPrimaryAssembly.Text = Path.GetFileName(ListAssembly.SelectedItem.ToString())
        Else
            LblPrimaryAssembly.Text = "..."
        End If

    End Sub

    Private Sub ListAssembly_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles ListAssembly.KeyDown

        If e.KeyCode = Keys.Delete AndAlso Not ListAssembly.SelectedItem Is Nothing Then
            ListAssembly.Items.Remove(ListAssembly.SelectedItem)
        End If

    End Sub

#End Region

#Region "Options"

    Private Sub ChkSignKeyFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSignKeyFile.CheckedChanged

        ChkDelayedSign.Enabled = ChkSignKeyFile.Checked
        TxtKeyFile.Enabled = ChkSignKeyFile.Checked

    End Sub

    Private Sub ButKeyFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButKeyFile.Click

        SelectKeyFile()

    End Sub

    Private Sub TxtKeyFile_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKeyFile.Leave

        If Not String.IsNullOrEmpty(TxtKeyFile.Text) Then
            TxtKeyFile.Text = TxtKeyFile.Text.Trim()
        End If

    End Sub

    Private Sub ChkGenerateLog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGenerateLog.CheckedChanged

        TxtLogFile.Enabled = ChkGenerateLog.Checked

    End Sub

    Private Sub ButLogFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButLogFile.Click

        SelectLogFile()

    End Sub

    Private Sub TxtLogFile_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLogFile.Leave

        If Not String.IsNullOrEmpty(TxtLogFile.Text) Then
            TxtLogFile.Text = TxtLogFile.Text.Trim()
        End If

    End Sub

    Private Sub SelectKeyFile()

        SetOpenFileDefaults("Strong Name Key|*.snk")

        If Not String.IsNullOrEmpty(TxtKeyFile.Text) Then
            OpenFile.FileName = Path.GetFileName(TxtKeyFile.Text)
        End If

        If TxtKeyFile.Text.Length > 3 Then
            OpenFile.InitialDirectory = Path.GetDirectoryName(TxtKeyFile.Text)
        End If

        If OpenFile.ShowDialog() = DialogResult.OK Then
            ChkSignKeyFile.Checked = True
            TxtKeyFile.Text = OpenFile.FileName
            TxtKeyFile.Focus()
        End If

    End Sub

    Private Sub SelectLogFile()

        SetOpenFileDefaults("Log file|*.log")

        If Not String.IsNullOrEmpty(TxtLogFile.Text) Then
            OpenFile.FileName = Path.GetFileName(TxtLogFile.Text)
        End If

        If TxtLogFile.Text.Length > 3 Then
            OpenFile.InitialDirectory = Path.GetDirectoryName(TxtLogFile.Text)
        End If

        If OpenFile.ShowDialog() = DialogResult.OK Then
            ChkGenerateLog.Checked = True
            TxtLogFile.Text = OpenFile.FileName
            TxtLogFile.Focus()
        End If

    End Sub

#End Region

#Region "Output"

    Private Sub ButOutputPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButOutputPath.Click

        SelectOutputPath()

    End Sub

    Private Sub TxtOutputPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOutputPath.TextChanged

        If Not String.IsNullOrEmpty(TxtOutputPath.Text) Then
            TxtOutputPath.Text = TxtOutputPath.Text.Trim()
        End If

    End Sub

    Private Sub SelectOutputPath()

        SetOpenFileDefaults("Assembly|*.dll;*.exe")

        If Not ListAssembly.SelectedItem Is Nothing Then
            OpenFile.DefaultExt = Path.GetExtension(ListAssembly.SelectedItem.ToString())
        End If

        If Not String.IsNullOrEmpty(TxtOutputPath.Text.Trim()) Then
            OpenFile.FileName = Path.GetFileName(TxtOutputPath.Text)
        End If

        If TxtOutputPath.Text.Length > 3 Then
            OpenFile.InitialDirectory = Path.GetDirectoryName(TxtOutputPath.Text)
        End If

        If OpenFile.ShowDialog() = DialogResult.OK Then
            TxtOutputPath.Text = OpenFile.FileName
            TxtOutputPath.Focus()
        End If

    End Sub

#End Region

#Region "Merge"

    Private Sub ButMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMerge.Click

        Dim objILMerge As New ILMerge
        Dim objFile As FileInfo
        Dim arrAssemblies(ListAssembly.Items.Count - 1) As String
        Dim i As Integer = 0
        Dim a As Integer = 1

        PreMerge()

        If Not Directory.Exists(TxtOutputPath.Text) Then
            MessageBox.Show(My.Resources.Messages.Error_NoOutputPath, My.Resources.Messages.ErrorTerm, MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtOutputPath.Focus()
            Exit Sub
        Else
            TxtOutputPath.Text = TxtOutputPath.Text.Trim()
        End If

        If File.Exists(TxtKeyFile.Text) AndAlso Not File.Exists(TxtKeyFile.Text) Then
            MessageBox.Show(My.Resources.Messages.Error_KeyFileNotExists, My.Resources.Messages.ErrorTerm, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If File.Exists(TxtOutputPath.Text) Then

            Try
                objFile = New FileInfo(TxtOutputPath.Text)
                objFile.Attributes = FileAttributes.Normal
                objFile.Delete()
                objFile = Nothing
            Catch
                MessageBox.Show(My.Resources.Messages.Error_OutputPathInUse, My.Resources.Messages.ErrorTerm, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If

        If ListAssembly.SelectedItem Is Nothing Then
            For i = 0 To ListAssembly.Items.Count - 1
                If Path.GetExtension(ListAssembly.Items(i).ToString).ToLower() = ".exe" Then
                    ListAssembly.SelectedIndex = i
                    i = ListAssembly.Items.Count
                End If
            Next
        End If

        If ListAssembly.SelectedItem Is Nothing Then
            ListAssembly.SelectedIndex = 0
        End If

        arrAssemblies(0) = ListAssembly.SelectedItem.ToString()

        For i = 0 To ListAssembly.Items.Count - 1

            If TxtOutputPath.Text = ListAssembly.Items(i).ToString() Then

                i = ListAssembly.Items.Count

                MessageBox.Show(My.Resources.Messages.Error_OutputConflict, My.Resources.Messages.ErrorTerm, MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtOutputPath.Focus()

                Exit Sub

            ElseIf i <> ListAssembly.SelectedIndex Then

                arrAssemblies(a) = ListAssembly.Items(i).ToString()
                a += 1

            End If

        Next

        objILMerge.CopyAttributes = ChkCopyAttributes.Checked
        objILMerge.UnionMerge = ChkUnionDuplicates.Checked

        If ChkSignKeyFile.Checked Then
            objILMerge.KeyFile = TxtKeyFile.Text
            objILMerge.DelaySign = ChkDelayedSign.Checked
        End If

        Select Case CboDebug.SelectedIndex
            Case 0
                objILMerge.DebugInfo = True
            Case 1
                objILMerge.DebugInfo = False
        End Select

        Select Case CboTargetFramework.SelectedIndex
            Case 0
                objILMerge.SetTargetPlatform("2.0", "C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727")
            Case 1
                objILMerge.SetTargetPlatform("4.0", "C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727")
            Case 2
                objILMerge.SetTargetPlatform("4.0", "C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727")
            Case 3
                objILMerge.SetTargetPlatform("4.0", "C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319")
        End Select

        objILMerge.TargetKind = ILMerge.Kind.SameAsPrimaryAssembly
        objILMerge.OutputFile = TxtOutputPath.Text
        objILMerge.SetInputAssemblies(arrAssemblies)

        Cursor = Cursors.WaitCursor
        EnableForm(False)

        WorkerILMerge.RunWorkerAsync(objILMerge)

    End Sub

    Private Sub WorkerILMerge_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles WorkerILMerge.DoWork

        Try
            CType(e.Argument, ILMerge).Merge()
            e.Result = Nothing
        Catch ex As Exception
            e.Result = ex
        End Try

    End Sub

    Private Sub WorkerILMerge_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles WorkerILMerge.RunWorkerCompleted

        Dim objFile As New FileInfo(TxtOutputPath.Text)

        Cursor = Cursors.Default
        EnableForm(True)

        If Not e.Error Is Nothing Then
            'ErrorHandler.Handle(e.Error)
        End If

        If Not e.Result Is Nothing Then
            MessageBox.Show(My.Resources.Messages.Error_MergeException & Environment.NewLine & CType(e.Result, Exception).Message, My.Resources.Messages.ErrorTerm, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not objFile.Exists Or objFile.Length < 4096 Then
            MessageBox.Show(My.Resources.Messages.Error_CantMerge, My.Resources.Messages.ErrorTerm, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '	MessageBox.Show(My.Resources.Messages.AssembliesMerged, My.Resources.Messages.Done, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub PreMerge()

        If String.IsNullOrEmpty(TxtKeyFile.Text) Then
            ChkSignKeyFile.Checked = False
        End If

        If String.IsNullOrEmpty(TxtLogFile.Text) Then
            ChkGenerateLog.Checked = False
        End If

        If TxtOutputPath.Text.Length < 5 Then
            SelectOutputPath()
        End If

    End Sub

    Private Sub EnableForm(ByVal Enable As Boolean)

        ListAssembly.Enabled = Enable
        ButAddFile.Enabled = Enable
        BoxOptions.Enabled = Enable
        BoxOutput.Enabled = Enable
        ButMerge.Enabled = Enable
        ImgLoading.Visible = Not Enable
        ImgLoading.Enabled = Not Enable

        Application.DoEvents()

    End Sub

#End Region

#Region "Links"

    Private Sub ImgDonate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Process.Start("http://devv.com/Donate.aspx?ILMerge-GUI")

    End Sub

    Private Sub LinkHomepage_LinkClicked(ByVal sender As System.Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkHomepage.LinkClicked

        Process.Start(LinkHomepage.Text)

    End Sub

    Private Sub LinkILMerge_LinkClicked(ByVal sender As System.Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkILMerge.LinkClicked

        Process.Start(LinkILMerge.Text)

    End Sub

#End Region

#Region "Helper methods"

    Private Sub SetOpenFileDefaults(ByVal filter As String)

        OpenFile.CheckFileExists = False
        OpenFile.Multiselect = False
        OpenFile.Filter = filter

    End Sub

#End Region

End Class