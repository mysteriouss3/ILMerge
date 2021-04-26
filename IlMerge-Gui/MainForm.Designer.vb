<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LinkILMerge = New System.Windows.Forms.LinkLabel()
        Me.TxtKeyFile = New System.Windows.Forms.TextBox()
        Me.LinkHomepage = New System.Windows.Forms.LinkLabel()
        Me.LblPrimaryAssembly = New System.Windows.Forms.Label()
        Me.LblPrimaryAssemblyInfo = New System.Windows.Forms.Label()
        Me.BoxOutput = New System.Windows.Forms.GroupBox()
        Me.ImgLoading = New System.Windows.Forms.PictureBox()
        Me.LblOutputPath = New System.Windows.Forms.Label()
        Me.TxtOutputPath = New System.Windows.Forms.TextBox()
        Me.ButOutputPath = New System.Windows.Forms.Button()
        Me.ButMerge = New System.Windows.Forms.Button()
        Me.CboDebug = New System.Windows.Forms.ComboBox()
        Me.LblDebug = New System.Windows.Forms.Label()
        Me.LblTargetFramework = New System.Windows.Forms.Label()
        Me.CboTargetFramework = New System.Windows.Forms.ComboBox()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.LblAssemblyList = New System.Windows.Forms.Label()
        Me.ListAssembly = New System.Windows.Forms.ListBox()
        Me.WorkerILMerge = New System.ComponentModel.BackgroundWorker()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.ChkDelayedSign = New System.Windows.Forms.CheckBox()
        Me.ChkUnionDuplicates = New System.Windows.Forms.CheckBox()
        Me.ChkCopyAttributes = New System.Windows.Forms.CheckBox()
        Me.ChkSignKeyFile = New System.Windows.Forms.CheckBox()
        Me.ChkGenerateLog = New System.Windows.Forms.CheckBox()
        Me.TxtLogFile = New System.Windows.Forms.TextBox()
        Me.ButLogFile = New System.Windows.Forms.Button()
        Me.ButKeyFile = New System.Windows.Forms.Button()
        Me.ButAddFile = New System.Windows.Forms.Button()
        Me.BoxOptions = New System.Windows.Forms.GroupBox()
        Me.BoxOutput.SuspendLayout()
        CType(Me.ImgLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BoxOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkILMerge
        '
        Me.LinkILMerge.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkILMerge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkILMerge.AutoSize = True
        Me.LinkILMerge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkILMerge.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkILMerge.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkILMerge.Location = New System.Drawing.Point(197, 445)
        Me.LinkILMerge.Name = "LinkILMerge"
        Me.LinkILMerge.Size = New System.Drawing.Size(285, 13)
        Me.LinkILMerge.TabIndex = 27
        Me.LinkILMerge.TabStop = True
        Me.LinkILMerge.Text = "http://research.microsoft.com/~mbarnett/ilmerge.aspx"
        Me.ToolTips.SetToolTip(Me.LinkILMerge, "ILMerge homepage")
        Me.LinkILMerge.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'TxtKeyFile
        '
        Me.TxtKeyFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtKeyFile.Enabled = False
        Me.TxtKeyFile.Location = New System.Drawing.Point(6, 68)
        Me.TxtKeyFile.MaxLength = 255
        Me.TxtKeyFile.Name = "TxtKeyFile"
        Me.TxtKeyFile.Size = New System.Drawing.Size(427, 22)
        Me.TxtKeyFile.TabIndex = 9
        Me.ToolTips.SetToolTip(Me.TxtKeyFile, "Path to the key file")
        '
        'LinkHomepage
        '
        Me.LinkHomepage.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkHomepage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkHomepage.AutoSize = True
        Me.LinkHomepage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkHomepage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkHomepage.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkHomepage.Location = New System.Drawing.Point(333, 426)
        Me.LinkHomepage.Name = "LinkHomepage"
        Me.LinkHomepage.Size = New System.Drawing.Size(149, 13)
        Me.LinkHomepage.TabIndex = 26
        Me.LinkHomepage.TabStop = True
        Me.LinkHomepage.Text = "http://ilmerge-gui.devv.com"
        Me.ToolTips.SetToolTip(Me.LinkHomepage, "ILMerge-GUI homepage")
        Me.LinkHomepage.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'LblPrimaryAssembly
        '
        Me.LblPrimaryAssembly.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPrimaryAssembly.AutoSize = True
        Me.LblPrimaryAssembly.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblPrimaryAssembly.Location = New System.Drawing.Point(111, 117)
        Me.LblPrimaryAssembly.Name = "LblPrimaryAssembly"
        Me.LblPrimaryAssembly.Size = New System.Drawing.Size(16, 13)
        Me.LblPrimaryAssembly.TabIndex = 0
        Me.LblPrimaryAssembly.Text = "..."
        '
        'LblPrimaryAssemblyInfo
        '
        Me.LblPrimaryAssemblyInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPrimaryAssemblyInfo.AutoSize = True
        Me.LblPrimaryAssemblyInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblPrimaryAssemblyInfo.Location = New System.Drawing.Point(9, 117)
        Me.LblPrimaryAssemblyInfo.Name = "LblPrimaryAssemblyInfo"
        Me.LblPrimaryAssemblyInfo.Size = New System.Drawing.Size(96, 13)
        Me.LblPrimaryAssemblyInfo.TabIndex = 0
        Me.LblPrimaryAssemblyInfo.Text = "Primary assembly:"
        '
        'BoxOutput
        '
        Me.BoxOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxOutput.Controls.Add(Me.ImgLoading)
        Me.BoxOutput.Controls.Add(Me.LblOutputPath)
        Me.BoxOutput.Controls.Add(Me.TxtOutputPath)
        Me.BoxOutput.Controls.Add(Me.ButOutputPath)
        Me.BoxOutput.Controls.Add(Me.ButMerge)
        Me.BoxOutput.Controls.Add(Me.CboDebug)
        Me.BoxOutput.Controls.Add(Me.LblDebug)
        Me.BoxOutput.Controls.Add(Me.LblTargetFramework)
        Me.BoxOutput.Controls.Add(Me.CboTargetFramework)
        Me.BoxOutput.Location = New System.Drawing.Point(12, 301)
        Me.BoxOutput.Name = "BoxOutput"
        Me.BoxOutput.Size = New System.Drawing.Size(470, 110)
        Me.BoxOutput.TabIndex = 9
        Me.BoxOutput.TabStop = False
        Me.BoxOutput.Text = "Output"
        '
        'ImgLoading
        '
        Me.ImgLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgLoading.Image = Global.Devv.ILMergeGUI.My.Resources.Resources.IconLoading
        Me.ImgLoading.Location = New System.Drawing.Point(370, 76)
        Me.ImgLoading.Name = "ImgLoading"
        Me.ImgLoading.Size = New System.Drawing.Size(16, 16)
        Me.ImgLoading.TabIndex = 28
        Me.ImgLoading.TabStop = False
        Me.ImgLoading.Visible = False
        '
        'LblOutputPath
        '
        Me.LblOutputPath.AutoSize = True
        Me.LblOutputPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblOutputPath.Location = New System.Drawing.Point(3, 21)
        Me.LblOutputPath.Name = "LblOutputPath"
        Me.LblOutputPath.Size = New System.Drawing.Size(97, 13)
        Me.LblOutputPath.TabIndex = 0
        Me.LblOutputPath.Text = "Output assembly:"
        '
        'TxtOutputPath
        '
        Me.TxtOutputPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOutputPath.Location = New System.Drawing.Point(6, 37)
        Me.TxtOutputPath.MaxLength = 255
        Me.TxtOutputPath.Name = "TxtOutputPath"
        Me.TxtOutputPath.Size = New System.Drawing.Size(427, 22)
        Me.TxtOutputPath.TabIndex = 2
        Me.ToolTips.SetToolTip(Me.TxtOutputPath, "Path to the output generated assembly")
        '
        'ButOutputPath
        '
        Me.ButOutputPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButOutputPath.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButOutputPath.Image = Global.Devv.ILMergeGUI.My.Resources.Resources.IconFolder
        Me.ButOutputPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButOutputPath.Location = New System.Drawing.Point(439, 37)
        Me.ButOutputPath.Name = "ButOutputPath"
        Me.ButOutputPath.Size = New System.Drawing.Size(25, 21)
        Me.ButOutputPath.TabIndex = 4
        Me.ToolTips.SetToolTip(Me.ButOutputPath, "Click to select the path to the output assembly")
        Me.ButOutputPath.UseVisualStyleBackColor = True
        '
        'ButMerge
        '
        Me.ButMerge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButMerge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButMerge.Enabled = False
        Me.ButMerge.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButMerge.Image = Global.Devv.ILMergeGUI.My.Resources.Resources.IconV
        Me.ButMerge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButMerge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButMerge.Location = New System.Drawing.Point(392, 69)
        Me.ButMerge.Name = "ButMerge"
        Me.ButMerge.Size = New System.Drawing.Size(72, 28)
        Me.ButMerge.TabIndex = 10
        Me.ButMerge.Text = "Merge!"
        Me.ButMerge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.ButMerge, "Click to start merging")
        Me.ButMerge.UseVisualStyleBackColor = True
        '
        'CboDebug
        '
        Me.CboDebug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDebug.FormattingEnabled = True
        Me.CboDebug.Items.AddRange(New Object() {"True", "False"})
        Me.CboDebug.Location = New System.Drawing.Point(54, 72)
        Me.CboDebug.Name = "CboDebug"
        Me.CboDebug.Size = New System.Drawing.Size(64, 21)
        Me.CboDebug.TabIndex = 6
        Me.ToolTips.SetToolTip(Me.CboDebug, "Set the debug parameter")
        '
        'LblDebug
        '
        Me.LblDebug.AutoSize = True
        Me.LblDebug.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblDebug.Location = New System.Drawing.Point(3, 75)
        Me.LblDebug.Name = "LblDebug"
        Me.LblDebug.Size = New System.Drawing.Size(45, 13)
        Me.LblDebug.TabIndex = 0
        Me.LblDebug.Text = "Debug:"
        '
        'LblTargetFramework
        '
        Me.LblTargetFramework.AutoSize = True
        Me.LblTargetFramework.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTargetFramework.Location = New System.Drawing.Point(135, 75)
        Me.LblTargetFramework.Name = "LblTargetFramework"
        Me.LblTargetFramework.Size = New System.Drawing.Size(67, 13)
        Me.LblTargetFramework.TabIndex = 0
        Me.LblTargetFramework.Text = "Framework:"
        '
        'CboTargetFramework
        '
        Me.CboTargetFramework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTargetFramework.FormattingEnabled = True
        Me.CboTargetFramework.Items.AddRange(New Object() {".NET 2.0", ".NET 3.0", ".NET 3.5", ".NET 4.0"})
        Me.CboTargetFramework.Location = New System.Drawing.Point(208, 72)
        Me.CboTargetFramework.Name = "CboTargetFramework"
        Me.CboTargetFramework.Size = New System.Drawing.Size(93, 21)
        Me.CboTargetFramework.TabIndex = 8
        Me.ToolTips.SetToolTip(Me.CboTargetFramework, "Set the target framework")
        '
        'OpenFile
        '
        '
        'LblAssemblyList
        '
        Me.LblAssemblyList.AutoSize = True
        Me.LblAssemblyList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAssemblyList.Location = New System.Drawing.Point(9, 9)
        Me.LblAssemblyList.Name = "LblAssemblyList"
        Me.LblAssemblyList.Size = New System.Drawing.Size(115, 13)
        Me.LblAssemblyList.TabIndex = 0
        Me.LblAssemblyList.Text = "Assemblies to merge:"
        '
        'ListAssembly
        '
        Me.ListAssembly.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListAssembly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListAssembly.FormattingEnabled = True
        Me.ListAssembly.HorizontalScrollbar = True
        Me.ListAssembly.Location = New System.Drawing.Point(12, 25)
        Me.ListAssembly.Name = "ListAssembly"
        Me.ListAssembly.Size = New System.Drawing.Size(470, 80)
        Me.ListAssembly.Sorted = True
        Me.ListAssembly.TabIndex = 2
        Me.ToolTips.SetToolTip(Me.ListAssembly, "Assemblies to be merged")
        '
        'WorkerILMerge
        '
        '
        'ToolTips
        '
        Me.ToolTips.AutomaticDelay = 800
        Me.ToolTips.IsBalloon = True
        '
        'ChkDelayedSign
        '
        Me.ChkDelayedSign.AutoSize = True
        Me.ChkDelayedSign.Enabled = False
        Me.ChkDelayedSign.Location = New System.Drawing.Point(126, 49)
        Me.ChkDelayedSign.Name = "ChkDelayedSign"
        Me.ChkDelayedSign.Size = New System.Drawing.Size(87, 17)
        Me.ChkDelayedSign.TabIndex = 7
        Me.ChkDelayedSign.Text = "Delayed sign"
        Me.ToolTips.SetToolTip(Me.ChkDelayedSign, "Use delayed sign")
        Me.ChkDelayedSign.UseVisualStyleBackColor = True
        '
        'ChkUnionDuplicates
        '
        Me.ChkUnionDuplicates.AutoSize = True
        Me.ChkUnionDuplicates.Checked = True
        Me.ChkUnionDuplicates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUnionDuplicates.Location = New System.Drawing.Point(126, 21)
        Me.ChkUnionDuplicates.Name = "ChkUnionDuplicates"
        Me.ChkUnionDuplicates.Size = New System.Drawing.Size(105, 17)
        Me.ChkUnionDuplicates.TabIndex = 3
        Me.ChkUnionDuplicates.Text = "Union duplicates"
        Me.ToolTips.SetToolTip(Me.ChkUnionDuplicates, "Union duplicate classes and references")
        Me.ChkUnionDuplicates.UseVisualStyleBackColor = True
        '
        'ChkCopyAttributes
        '
        Me.ChkCopyAttributes.AutoSize = True
        Me.ChkCopyAttributes.Checked = True
        Me.ChkCopyAttributes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCopyAttributes.Location = New System.Drawing.Point(6, 21)
        Me.ChkCopyAttributes.Name = "ChkCopyAttributes"
        Me.ChkCopyAttributes.Size = New System.Drawing.Size(96, 17)
        Me.ChkCopyAttributes.TabIndex = 1
        Me.ChkCopyAttributes.Text = "Copy attributes"
        Me.ToolTips.SetToolTip(Me.ChkCopyAttributes, "Copy assembly attributes")
        Me.ChkCopyAttributes.UseVisualStyleBackColor = True
        '
        'ChkSignKeyFile
        '
        Me.ChkSignKeyFile.AutoSize = True
        Me.ChkSignKeyFile.Location = New System.Drawing.Point(6, 49)
        Me.ChkSignKeyFile.Name = "ChkSignKeyFile"
        Me.ChkSignKeyFile.Size = New System.Drawing.Size(105, 17)
        Me.ChkSignKeyFile.TabIndex = 5
        Me.ChkSignKeyFile.Text = "Sign with key file"
        Me.ToolTips.SetToolTip(Me.ChkSignKeyFile, "Sign the output assembly with a key file")
        Me.ChkSignKeyFile.UseVisualStyleBackColor = True
        '
        'ChkGenerateLog
        '
        Me.ChkGenerateLog.AutoSize = True
        Me.ChkGenerateLog.Location = New System.Drawing.Point(6, 99)
        Me.ChkGenerateLog.Name = "ChkGenerateLog"
        Me.ChkGenerateLog.Size = New System.Drawing.Size(103, 17)
        Me.ChkGenerateLog.TabIndex = 13
        Me.ChkGenerateLog.Text = "Generate log file"
        Me.ToolTips.SetToolTip(Me.ChkGenerateLog, "Write results to a log file")
        Me.ChkGenerateLog.UseVisualStyleBackColor = True
        '
        'TxtLogFile
        '
        Me.TxtLogFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLogFile.Enabled = False
        Me.TxtLogFile.Location = New System.Drawing.Point(6, 118)
        Me.TxtLogFile.MaxLength = 255
        Me.TxtLogFile.Name = "TxtLogFile"
        Me.TxtLogFile.Size = New System.Drawing.Size(427, 22)
        Me.TxtLogFile.TabIndex = 15
        Me.ToolTips.SetToolTip(Me.TxtLogFile, "Path to the log file")
        '
        'ButLogFile
        '
        Me.ButLogFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButLogFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButLogFile.Image = Global.Devv.ILMergeGUI.My.Resources.Resources.IconFolder
        Me.ButLogFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButLogFile.Location = New System.Drawing.Point(439, 119)
        Me.ButLogFile.Name = "ButLogFile"
        Me.ButLogFile.Size = New System.Drawing.Size(25, 21)
        Me.ButLogFile.TabIndex = 17
        Me.ToolTips.SetToolTip(Me.ButLogFile, "Click to select a log path")
        Me.ButLogFile.UseVisualStyleBackColor = True
        '
        'ButKeyFile
        '
        Me.ButKeyFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButKeyFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButKeyFile.Image = Global.Devv.ILMergeGUI.My.Resources.Resources.IconFolder
        Me.ButKeyFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButKeyFile.Location = New System.Drawing.Point(439, 68)
        Me.ButKeyFile.Name = "ButKeyFile"
        Me.ButKeyFile.Size = New System.Drawing.Size(25, 21)
        Me.ButKeyFile.TabIndex = 11
        Me.ToolTips.SetToolTip(Me.ButKeyFile, "Click to select a key file")
        Me.ButKeyFile.UseVisualStyleBackColor = True
        '
        'ButAddFile
        '
        Me.ButAddFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButAddFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButAddFile.Image = Global.Devv.ILMergeGUI.My.Resources.Resources.IconAdd
        Me.ButAddFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButAddFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButAddFile.Location = New System.Drawing.Point(370, 112)
        Me.ButAddFile.Name = "ButAddFile"
        Me.ButAddFile.Size = New System.Drawing.Size(112, 23)
        Me.ButAddFile.TabIndex = 4
        Me.ButAddFile.Text = "Add assemblies"
        Me.ButAddFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.ButAddFile, "Click to select and add assemblies to the list")
        Me.ButAddFile.UseVisualStyleBackColor = True
        '
        'BoxOptions
        '
        Me.BoxOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxOptions.Controls.Add(Me.ChkSignKeyFile)
        Me.BoxOptions.Controls.Add(Me.ChkGenerateLog)
        Me.BoxOptions.Controls.Add(Me.ChkDelayedSign)
        Me.BoxOptions.Controls.Add(Me.ButLogFile)
        Me.BoxOptions.Controls.Add(Me.TxtKeyFile)
        Me.BoxOptions.Controls.Add(Me.ChkUnionDuplicates)
        Me.BoxOptions.Controls.Add(Me.TxtLogFile)
        Me.BoxOptions.Controls.Add(Me.ButKeyFile)
        Me.BoxOptions.Controls.Add(Me.ChkCopyAttributes)
        Me.BoxOptions.Location = New System.Drawing.Point(12, 143)
        Me.BoxOptions.Name = "BoxOptions"
        Me.BoxOptions.Size = New System.Drawing.Size(470, 152)
        Me.BoxOptions.TabIndex = 7
        Me.BoxOptions.TabStop = False
        Me.BoxOptions.Text = "Options"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 468)
        Me.Controls.Add(Me.BoxOptions)
        Me.Controls.Add(Me.LinkILMerge)
        Me.Controls.Add(Me.LinkHomepage)
        Me.Controls.Add(Me.LblPrimaryAssembly)
        Me.Controls.Add(Me.LblPrimaryAssemblyInfo)
        Me.Controls.Add(Me.BoxOutput)
        Me.Controls.Add(Me.ButAddFile)
        Me.Controls.Add(Me.LblAssemblyList)
        Me.Controls.Add(Me.ListAssembly)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(430, 470)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ILMerge-GUI"
        Me.BoxOutput.ResumeLayout(False)
        Me.BoxOutput.PerformLayout()
        CType(Me.ImgLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxOptions.ResumeLayout(False)
        Me.BoxOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents LinkILMerge As System.Windows.Forms.LinkLabel
	Friend WithEvents TxtKeyFile As System.Windows.Forms.TextBox
	Friend WithEvents LinkHomepage As System.Windows.Forms.LinkLabel
	Friend WithEvents LblPrimaryAssembly As System.Windows.Forms.Label
	Friend WithEvents LblPrimaryAssemblyInfo As System.Windows.Forms.Label
	Friend WithEvents BoxOutput As System.Windows.Forms.GroupBox
	Friend WithEvents ButKeyFile As System.Windows.Forms.Button
	Friend WithEvents CboDebug As System.Windows.Forms.ComboBox
	Friend WithEvents LblDebug As System.Windows.Forms.Label
	Friend WithEvents LblTargetFramework As System.Windows.Forms.Label
	Friend WithEvents TxtOutputPath As System.Windows.Forms.TextBox
	Friend WithEvents CboTargetFramework As System.Windows.Forms.ComboBox
	Friend WithEvents ButOutputPath As System.Windows.Forms.Button
	Friend WithEvents ButMerge As System.Windows.Forms.Button
	Friend WithEvents ButAddFile As System.Windows.Forms.Button
	Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
	Friend WithEvents LblAssemblyList As System.Windows.Forms.Label
	Friend WithEvents ListAssembly As System.Windows.Forms.ListBox
	Friend WithEvents WorkerILMerge As System.ComponentModel.BackgroundWorker
	Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
	Friend WithEvents BoxOptions As System.Windows.Forms.GroupBox
	Friend WithEvents ChkUnionDuplicates As System.Windows.Forms.CheckBox
	Friend WithEvents ChkCopyAttributes As System.Windows.Forms.CheckBox
	Friend WithEvents LblOutputPath As System.Windows.Forms.Label
	Friend WithEvents ChkDelayedSign As System.Windows.Forms.CheckBox
	Friend WithEvents ChkGenerateLog As System.Windows.Forms.CheckBox
	Friend WithEvents ButLogFile As System.Windows.Forms.Button
	Friend WithEvents TxtLogFile As System.Windows.Forms.TextBox
	Friend WithEvents ChkSignKeyFile As System.Windows.Forms.CheckBox
	Friend WithEvents ImgLoading As System.Windows.Forms.PictureBox
End Class
