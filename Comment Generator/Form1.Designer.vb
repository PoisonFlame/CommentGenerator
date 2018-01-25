<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lstStudentNames = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.cmsComments = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsComment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPraise = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCriticism = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpPraises = New System.Windows.Forms.GroupBox()
        Me.lblHelp2 = New System.Windows.Forms.LinkLabel()
        Me.btnInsertPraises = New System.Windows.Forms.Button()
        Me.txtCustomPraise = New System.Windows.Forms.TextBox()
        Me.lblCustomPraises = New System.Windows.Forms.Label()
        Me.chkPraiseFour = New System.Windows.Forms.CheckBox()
        Me.chkPraiseThree = New System.Windows.Forms.CheckBox()
        Me.chkPraiseTwo = New System.Windows.Forms.CheckBox()
        Me.chkPraiseOne = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpCriticism = New System.Windows.Forms.GroupBox()
        Me.lblHelp = New System.Windows.Forms.LinkLabel()
        Me.btnInsertCriticism = New System.Windows.Forms.Button()
        Me.chkCriticismTwo = New System.Windows.Forms.CheckBox()
        Me.txtCriticism = New System.Windows.Forms.TextBox()
        Me.chkCriticismOne = New System.Windows.Forms.CheckBox()
        Me.lblCriticism = New System.Windows.Forms.Label()
        Me.chkCriticismThree = New System.Windows.Forms.CheckBox()
        Me.chkCriticismFour = New System.Windows.Forms.CheckBox()
        Me.grpOtherOptions = New System.Windows.Forms.GroupBox()
        Me.btnAddUnits = New System.Windows.Forms.Button()
        Me.btnSpecifyCourseName = New System.Windows.Forms.Button()
        Me.btnClassAverage = New System.Windows.Forms.Button()
        Me.btnCommentHistory = New System.Windows.Forms.Button()
        Me.btnEditDatabase = New System.Windows.Forms.Button()
        Me.btnCreateDB = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.OFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.grpUnitPraise = New System.Windows.Forms.GroupBox()
        Me.chkPraiseUnitTen = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitNine = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitSix = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitFive = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitSeven = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitEight = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitTwo = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitOne = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitThree = New System.Windows.Forms.CheckBox()
        Me.chkPraiseUnitFour = New System.Windows.Forms.CheckBox()
        Me.grpCriticismUnits = New System.Windows.Forms.GroupBox()
        Me.chkCriticismUnitTen = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitNine = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitSix = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitFive = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitSeven = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitEight = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitTwo = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitOne = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitThree = New System.Windows.Forms.CheckBox()
        Me.chkCriticismUnitFour = New System.Windows.Forms.CheckBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.grpExport = New System.Windows.Forms.GroupBox()
        Me.btnExportToHomelogic = New System.Windows.Forms.Button()
        Me.bnExportToXML = New System.Windows.Forms.Button()
        Me.btnExportToPDF = New System.Windows.Forms.Button()
        Me.btnExportFile = New System.Windows.Forms.Button()
        Me.SFDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.SFDialog3 = New System.Windows.Forms.SaveFileDialog()
        Me.cmsComment.SuspendLayout()
        Me.grpPraises.SuspendLayout()
        Me.grpCriticism.SuspendLayout()
        Me.grpOtherOptions.SuspendLayout()
        Me.grpUnitPraise.SuspendLayout()
        Me.grpCriticismUnits.SuspendLayout()
        Me.grpExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(165, 23)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import from Student Database"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'lstStudentNames
        '
        Me.lstStudentNames.FormattingEnabled = True
        Me.lstStudentNames.Location = New System.Drawing.Point(12, 41)
        Me.lstStudentNames.Name = "lstStudentNames"
        Me.lstStudentNames.Size = New System.Drawing.Size(165, 550)
        Me.lstStudentNames.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(183, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(602, 23)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "                   Comment Generator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtComment
        '
        Me.txtComment.ContextMenuStrip = Me.cmsComments
        Me.txtComment.Location = New System.Drawing.Point(183, 41)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ReadOnly = True
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComment.Size = New System.Drawing.Size(411, 329)
        Me.txtComment.TabIndex = 3
        Me.txtComment.Text = "Please Choose a Student From the List to the Left after Importing a database from" & _
    " above the list."
        '
        'cmsComments
        '
        Me.cmsComments.Name = "cmsComments"
        Me.cmsComments.Size = New System.Drawing.Size(61, 4)
        '
        'cmsComment
        '
        Me.cmsComment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmInstructions, Me.tsmPraise, Me.tsmCriticism})
        Me.cmsComment.Name = "cmsComment"
        Me.cmsComment.Size = New System.Drawing.Size(237, 70)
        '
        'tsmInstructions
        '
        Me.tsmInstructions.Name = "tsmInstructions"
        Me.tsmInstructions.Size = New System.Drawing.Size(236, 22)
        Me.tsmInstructions.Text = "CLICK ME FOR INSTRUCTIONS"
        '
        'tsmPraise
        '
        Me.tsmPraise.Name = "tsmPraise"
        Me.tsmPraise.Size = New System.Drawing.Size(236, 22)
        Me.tsmPraise.Text = "Praise for Units"
        '
        'tsmCriticism
        '
        Me.tsmCriticism.Name = "tsmCriticism"
        Me.tsmCriticism.Size = New System.Drawing.Size(236, 22)
        Me.tsmCriticism.Text = "Criticism for Units"
        '
        'grpPraises
        '
        Me.grpPraises.BackColor = System.Drawing.Color.Transparent
        Me.grpPraises.Controls.Add(Me.lblHelp2)
        Me.grpPraises.Controls.Add(Me.btnInsertPraises)
        Me.grpPraises.Controls.Add(Me.txtCustomPraise)
        Me.grpPraises.Controls.Add(Me.lblCustomPraises)
        Me.grpPraises.Controls.Add(Me.chkPraiseFour)
        Me.grpPraises.Controls.Add(Me.chkPraiseThree)
        Me.grpPraises.Controls.Add(Me.chkPraiseTwo)
        Me.grpPraises.Controls.Add(Me.chkPraiseOne)
        Me.grpPraises.Controls.Add(Me.btnSave)
        Me.grpPraises.Enabled = False
        Me.grpPraises.Location = New System.Drawing.Point(600, 41)
        Me.grpPraises.Name = "grpPraises"
        Me.grpPraises.Size = New System.Drawing.Size(185, 110)
        Me.grpPraises.TabIndex = 4
        Me.grpPraises.TabStop = False
        Me.grpPraises.Text = "Praises"
        '
        'lblHelp2
        '
        Me.lblHelp2.AutoSize = True
        Me.lblHelp2.Enabled = False
        Me.lblHelp2.Location = New System.Drawing.Point(6, 152)
        Me.lblHelp2.Name = "lblHelp2"
        Me.lblHelp2.Size = New System.Drawing.Size(35, 13)
        Me.lblHelp2.TabIndex = 17
        Me.lblHelp2.TabStop = True
        Me.lblHelp2.Text = "Help?"
        '
        'btnInsertPraises
        '
        Me.btnInsertPraises.Enabled = False
        Me.btnInsertPraises.Location = New System.Drawing.Point(101, 147)
        Me.btnInsertPraises.Name = "btnInsertPraises"
        Me.btnInsertPraises.Size = New System.Drawing.Size(78, 23)
        Me.btnInsertPraises.TabIndex = 8
        Me.btnInsertPraises.Text = "Insert Praises"
        Me.btnInsertPraises.UseVisualStyleBackColor = True
        '
        'txtCustomPraise
        '
        Me.txtCustomPraise.Enabled = False
        Me.txtCustomPraise.Location = New System.Drawing.Point(6, 124)
        Me.txtCustomPraise.Name = "txtCustomPraise"
        Me.txtCustomPraise.Size = New System.Drawing.Size(173, 20)
        Me.txtCustomPraise.TabIndex = 7
        '
        'lblCustomPraises
        '
        Me.lblCustomPraises.AutoSize = True
        Me.lblCustomPraises.Location = New System.Drawing.Point(3, 108)
        Me.lblCustomPraises.Name = "lblCustomPraises"
        Me.lblCustomPraises.Size = New System.Drawing.Size(33, 13)
        Me.lblCustomPraises.TabIndex = 6
        Me.lblCustomPraises.Text = "Other"
        '
        'chkPraiseFour
        '
        Me.chkPraiseFour.AutoSize = True
        Me.chkPraiseFour.Location = New System.Drawing.Point(6, 88)
        Me.chkPraiseFour.Name = "chkPraiseFour"
        Me.chkPraiseFour.Size = New System.Drawing.Size(92, 17)
        Me.chkPraiseFour.TabIndex = 3
        Me.chkPraiseFour.Text = "Great Listener"
        Me.chkPraiseFour.UseVisualStyleBackColor = True
        '
        'chkPraiseThree
        '
        Me.chkPraiseThree.AutoSize = True
        Me.chkPraiseThree.Location = New System.Drawing.Point(6, 65)
        Me.chkPraiseThree.Name = "chkPraiseThree"
        Me.chkPraiseThree.Size = New System.Drawing.Size(121, 17)
        Me.chkPraiseThree.TabIndex = 2
        Me.chkPraiseThree.Text = "Uses Classtime Well"
        Me.chkPraiseThree.UseVisualStyleBackColor = True
        '
        'chkPraiseTwo
        '
        Me.chkPraiseTwo.AutoSize = True
        Me.chkPraiseTwo.Location = New System.Drawing.Point(6, 42)
        Me.chkPraiseTwo.Name = "chkPraiseTwo"
        Me.chkPraiseTwo.Size = New System.Drawing.Size(124, 17)
        Me.chkPraiseTwo.TabIndex = 1
        Me.chkPraiseTwo.Text = "Good Understanding"
        Me.chkPraiseTwo.UseVisualStyleBackColor = True
        '
        'chkPraiseOne
        '
        Me.chkPraiseOne.AutoSize = True
        Me.chkPraiseOne.Location = New System.Drawing.Point(6, 19)
        Me.chkPraiseOne.Name = "chkPraiseOne"
        Me.chkPraiseOne.Size = New System.Drawing.Size(72, 17)
        Me.chkPraiseOne.TabIndex = 0
        Me.chkPraiseOne.Text = "Improving"
        Me.chkPraiseOne.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(84, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 23)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'grpCriticism
        '
        Me.grpCriticism.BackColor = System.Drawing.Color.Transparent
        Me.grpCriticism.Controls.Add(Me.lblHelp)
        Me.grpCriticism.Controls.Add(Me.btnInsertCriticism)
        Me.grpCriticism.Controls.Add(Me.chkCriticismTwo)
        Me.grpCriticism.Controls.Add(Me.txtCriticism)
        Me.grpCriticism.Controls.Add(Me.chkCriticismOne)
        Me.grpCriticism.Controls.Add(Me.lblCriticism)
        Me.grpCriticism.Controls.Add(Me.chkCriticismThree)
        Me.grpCriticism.Controls.Add(Me.chkCriticismFour)
        Me.grpCriticism.Enabled = False
        Me.grpCriticism.Location = New System.Drawing.Point(600, 157)
        Me.grpCriticism.Name = "grpCriticism"
        Me.grpCriticism.Size = New System.Drawing.Size(185, 109)
        Me.grpCriticism.TabIndex = 5
        Me.grpCriticism.TabStop = False
        Me.grpCriticism.Text = "Criticism"
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Enabled = False
        Me.lblHelp.Location = New System.Drawing.Point(6, 152)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(35, 13)
        Me.lblHelp.TabIndex = 16
        Me.lblHelp.TabStop = True
        Me.lblHelp.Text = "Help?"
        '
        'btnInsertCriticism
        '
        Me.btnInsertCriticism.Enabled = False
        Me.btnInsertCriticism.Location = New System.Drawing.Point(95, 147)
        Me.btnInsertCriticism.Name = "btnInsertCriticism"
        Me.btnInsertCriticism.Size = New System.Drawing.Size(84, 23)
        Me.btnInsertCriticism.TabIndex = 15
        Me.btnInsertCriticism.Text = "Insert Criticism"
        Me.btnInsertCriticism.UseVisualStyleBackColor = True
        '
        'chkCriticismTwo
        '
        Me.chkCriticismTwo.AutoSize = True
        Me.chkCriticismTwo.Location = New System.Drawing.Point(6, 42)
        Me.chkCriticismTwo.Name = "chkCriticismTwo"
        Me.chkCriticismTwo.Size = New System.Drawing.Size(122, 17)
        Me.chkCriticismTwo.TabIndex = 10
        Me.chkCriticismTwo.Text = "Needs to Seek Help"
        Me.chkCriticismTwo.UseVisualStyleBackColor = True
        '
        'txtCriticism
        '
        Me.txtCriticism.Enabled = False
        Me.txtCriticism.Location = New System.Drawing.Point(6, 124)
        Me.txtCriticism.Name = "txtCriticism"
        Me.txtCriticism.Size = New System.Drawing.Size(173, 20)
        Me.txtCriticism.TabIndex = 14
        '
        'chkCriticismOne
        '
        Me.chkCriticismOne.AutoSize = True
        Me.chkCriticismOne.Location = New System.Drawing.Point(6, 19)
        Me.chkCriticismOne.Name = "chkCriticismOne"
        Me.chkCriticismOne.Size = New System.Drawing.Size(122, 17)
        Me.chkCriticismOne.TabIndex = 9
        Me.chkCriticismOne.Text = "Distracting to Others"
        Me.chkCriticismOne.UseVisualStyleBackColor = True
        '
        'lblCriticism
        '
        Me.lblCriticism.AutoSize = True
        Me.lblCriticism.Location = New System.Drawing.Point(3, 108)
        Me.lblCriticism.Name = "lblCriticism"
        Me.lblCriticism.Size = New System.Drawing.Size(33, 13)
        Me.lblCriticism.TabIndex = 13
        Me.lblCriticism.Text = "Other"
        '
        'chkCriticismThree
        '
        Me.chkCriticismThree.AutoSize = True
        Me.chkCriticismThree.Location = New System.Drawing.Point(6, 65)
        Me.chkCriticismThree.Name = "chkCriticismThree"
        Me.chkCriticismThree.Size = New System.Drawing.Size(123, 17)
        Me.chkCriticismThree.TabIndex = 11
        Me.chkCriticismThree.Text = "Not Paying Attention"
        Me.chkCriticismThree.UseVisualStyleBackColor = True
        '
        'chkCriticismFour
        '
        Me.chkCriticismFour.AutoSize = True
        Me.chkCriticismFour.Location = New System.Drawing.Point(6, 88)
        Me.chkCriticismFour.Name = "chkCriticismFour"
        Me.chkCriticismFour.Size = New System.Drawing.Size(166, 17)
        Me.chkCriticismFour.TabIndex = 12
        Me.chkCriticismFour.Text = "Late/Incomplete Assignments"
        Me.chkCriticismFour.UseVisualStyleBackColor = True
        '
        'grpOtherOptions
        '
        Me.grpOtherOptions.BackColor = System.Drawing.Color.Transparent
        Me.grpOtherOptions.Controls.Add(Me.btnAddUnits)
        Me.grpOtherOptions.Controls.Add(Me.btnSpecifyCourseName)
        Me.grpOtherOptions.Controls.Add(Me.btnClassAverage)
        Me.grpOtherOptions.Controls.Add(Me.btnCommentHistory)
        Me.grpOtherOptions.Controls.Add(Me.btnEditDatabase)
        Me.grpOtherOptions.Controls.Add(Me.btnCreateDB)
        Me.grpOtherOptions.Location = New System.Drawing.Point(600, 405)
        Me.grpOtherOptions.Name = "grpOtherOptions"
        Me.grpOtherOptions.Size = New System.Drawing.Size(185, 186)
        Me.grpOtherOptions.TabIndex = 16
        Me.grpOtherOptions.TabStop = False
        Me.grpOtherOptions.Text = "Other Options"
        '
        'btnAddUnits
        '
        Me.btnAddUnits.Location = New System.Drawing.Point(6, 159)
        Me.btnAddUnits.Name = "btnAddUnits"
        Me.btnAddUnits.Size = New System.Drawing.Size(173, 23)
        Me.btnAddUnits.TabIndex = 22
        Me.btnAddUnits.Text = "Add Course Units"
        Me.btnAddUnits.UseVisualStyleBackColor = True
        '
        'btnSpecifyCourseName
        '
        Me.btnSpecifyCourseName.Location = New System.Drawing.Point(6, 132)
        Me.btnSpecifyCourseName.Name = "btnSpecifyCourseName"
        Me.btnSpecifyCourseName.Size = New System.Drawing.Size(173, 23)
        Me.btnSpecifyCourseName.TabIndex = 21
        Me.btnSpecifyCourseName.Text = "Edit Course Name"
        Me.btnSpecifyCourseName.UseVisualStyleBackColor = True
        '
        'btnClassAverage
        '
        Me.btnClassAverage.Location = New System.Drawing.Point(6, 104)
        Me.btnClassAverage.Name = "btnClassAverage"
        Me.btnClassAverage.Size = New System.Drawing.Size(173, 23)
        Me.btnClassAverage.TabIndex = 20
        Me.btnClassAverage.Text = "Check Class Average"
        Me.btnClassAverage.UseVisualStyleBackColor = True
        '
        'btnCommentHistory
        '
        Me.btnCommentHistory.Location = New System.Drawing.Point(6, 75)
        Me.btnCommentHistory.Name = "btnCommentHistory"
        Me.btnCommentHistory.Size = New System.Drawing.Size(173, 23)
        Me.btnCommentHistory.TabIndex = 19
        Me.btnCommentHistory.Text = "Comment History"
        Me.btnCommentHistory.UseVisualStyleBackColor = True
        '
        'btnEditDatabase
        '
        Me.btnEditDatabase.Location = New System.Drawing.Point(6, 46)
        Me.btnEditDatabase.Name = "btnEditDatabase"
        Me.btnEditDatabase.Size = New System.Drawing.Size(173, 23)
        Me.btnEditDatabase.TabIndex = 18
        Me.btnEditDatabase.Text = "Edit Student Database"
        Me.btnEditDatabase.UseVisualStyleBackColor = True
        '
        'btnCreateDB
        '
        Me.btnCreateDB.Location = New System.Drawing.Point(6, 17)
        Me.btnCreateDB.Name = "btnCreateDB"
        Me.btnCreateDB.Size = New System.Drawing.Size(173, 23)
        Me.btnCreateDB.TabIndex = 17
        Me.btnCreateDB.Text = "Make Student Database"
        Me.btnCreateDB.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(183, 376)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(205, 23)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'OFDialog
        '
        Me.OFDialog.FileName = "OpenFileDialog1"
        Me.OFDialog.InitialDirectory = "C:/"
        '
        'SFDialog
        '
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(710, 14)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 23
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        Me.btnTest.Visible = False
        '
        'grpUnitPraise
        '
        Me.grpUnitPraise.BackColor = System.Drawing.Color.Transparent
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitTen)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitNine)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitSix)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitFive)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitSeven)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitEight)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitTwo)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitOne)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitThree)
        Me.grpUnitPraise.Controls.Add(Me.chkPraiseUnitFour)
        Me.grpUnitPraise.Enabled = False
        Me.grpUnitPraise.Location = New System.Drawing.Point(183, 405)
        Me.grpUnitPraise.Name = "grpUnitPraise"
        Me.grpUnitPraise.Size = New System.Drawing.Size(205, 186)
        Me.grpUnitPraise.TabIndex = 17
        Me.grpUnitPraise.TabStop = False
        Me.grpUnitPraise.Text = "Show Praise for Units"
        '
        'chkPraiseUnitTen
        '
        Me.chkPraiseUnitTen.AutoSize = True
        Me.chkPraiseUnitTen.Location = New System.Drawing.Point(10, 166)
        Me.chkPraiseUnitTen.Name = "chkPraiseUnitTen"
        Me.chkPraiseUnitTen.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitTen.TabIndex = 18
        Me.chkPraiseUnitTen.Text = "Unit"
        Me.chkPraiseUnitTen.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitNine
        '
        Me.chkPraiseUnitNine.AutoSize = True
        Me.chkPraiseUnitNine.Location = New System.Drawing.Point(10, 149)
        Me.chkPraiseUnitNine.Name = "chkPraiseUnitNine"
        Me.chkPraiseUnitNine.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitNine.TabIndex = 17
        Me.chkPraiseUnitNine.Text = "Unit"
        Me.chkPraiseUnitNine.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitSix
        '
        Me.chkPraiseUnitSix.AutoSize = True
        Me.chkPraiseUnitSix.Location = New System.Drawing.Point(10, 99)
        Me.chkPraiseUnitSix.Name = "chkPraiseUnitSix"
        Me.chkPraiseUnitSix.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitSix.TabIndex = 14
        Me.chkPraiseUnitSix.Text = "Unit"
        Me.chkPraiseUnitSix.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitFive
        '
        Me.chkPraiseUnitFive.AutoSize = True
        Me.chkPraiseUnitFive.Location = New System.Drawing.Point(10, 82)
        Me.chkPraiseUnitFive.Name = "chkPraiseUnitFive"
        Me.chkPraiseUnitFive.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitFive.TabIndex = 13
        Me.chkPraiseUnitFive.Text = "Unit"
        Me.chkPraiseUnitFive.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitSeven
        '
        Me.chkPraiseUnitSeven.AutoSize = True
        Me.chkPraiseUnitSeven.Location = New System.Drawing.Point(10, 116)
        Me.chkPraiseUnitSeven.Name = "chkPraiseUnitSeven"
        Me.chkPraiseUnitSeven.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitSeven.TabIndex = 15
        Me.chkPraiseUnitSeven.Text = "Unit"
        Me.chkPraiseUnitSeven.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitEight
        '
        Me.chkPraiseUnitEight.AutoSize = True
        Me.chkPraiseUnitEight.Location = New System.Drawing.Point(10, 133)
        Me.chkPraiseUnitEight.Name = "chkPraiseUnitEight"
        Me.chkPraiseUnitEight.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitEight.TabIndex = 16
        Me.chkPraiseUnitEight.Text = "Unit"
        Me.chkPraiseUnitEight.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitTwo
        '
        Me.chkPraiseUnitTwo.AutoSize = True
        Me.chkPraiseUnitTwo.Location = New System.Drawing.Point(10, 31)
        Me.chkPraiseUnitTwo.Name = "chkPraiseUnitTwo"
        Me.chkPraiseUnitTwo.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitTwo.TabIndex = 10
        Me.chkPraiseUnitTwo.Text = "Unit"
        Me.chkPraiseUnitTwo.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitOne
        '
        Me.chkPraiseUnitOne.AutoSize = True
        Me.chkPraiseUnitOne.Location = New System.Drawing.Point(10, 14)
        Me.chkPraiseUnitOne.Name = "chkPraiseUnitOne"
        Me.chkPraiseUnitOne.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitOne.TabIndex = 9
        Me.chkPraiseUnitOne.Text = "Unit"
        Me.chkPraiseUnitOne.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitThree
        '
        Me.chkPraiseUnitThree.AutoSize = True
        Me.chkPraiseUnitThree.Location = New System.Drawing.Point(10, 48)
        Me.chkPraiseUnitThree.Name = "chkPraiseUnitThree"
        Me.chkPraiseUnitThree.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitThree.TabIndex = 11
        Me.chkPraiseUnitThree.Text = "Unit"
        Me.chkPraiseUnitThree.UseVisualStyleBackColor = True
        '
        'chkPraiseUnitFour
        '
        Me.chkPraiseUnitFour.AutoSize = True
        Me.chkPraiseUnitFour.Location = New System.Drawing.Point(10, 65)
        Me.chkPraiseUnitFour.Name = "chkPraiseUnitFour"
        Me.chkPraiseUnitFour.Size = New System.Drawing.Size(45, 17)
        Me.chkPraiseUnitFour.TabIndex = 12
        Me.chkPraiseUnitFour.Text = "Unit"
        Me.chkPraiseUnitFour.UseVisualStyleBackColor = True
        '
        'grpCriticismUnits
        '
        Me.grpCriticismUnits.BackColor = System.Drawing.Color.Transparent
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitTen)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitNine)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitSix)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitFive)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitSeven)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitEight)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitTwo)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitOne)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitThree)
        Me.grpCriticismUnits.Controls.Add(Me.chkCriticismUnitFour)
        Me.grpCriticismUnits.Enabled = False
        Me.grpCriticismUnits.Location = New System.Drawing.Point(394, 405)
        Me.grpCriticismUnits.Name = "grpCriticismUnits"
        Me.grpCriticismUnits.Size = New System.Drawing.Size(200, 186)
        Me.grpCriticismUnits.TabIndex = 19
        Me.grpCriticismUnits.TabStop = False
        Me.grpCriticismUnits.Text = "Show Criticism for Units"
        '
        'chkCriticismUnitTen
        '
        Me.chkCriticismUnitTen.AutoSize = True
        Me.chkCriticismUnitTen.Location = New System.Drawing.Point(6, 166)
        Me.chkCriticismUnitTen.Name = "chkCriticismUnitTen"
        Me.chkCriticismUnitTen.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitTen.TabIndex = 18
        Me.chkCriticismUnitTen.Text = "Unit"
        Me.chkCriticismUnitTen.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitNine
        '
        Me.chkCriticismUnitNine.AutoSize = True
        Me.chkCriticismUnitNine.Location = New System.Drawing.Point(6, 150)
        Me.chkCriticismUnitNine.Name = "chkCriticismUnitNine"
        Me.chkCriticismUnitNine.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitNine.TabIndex = 17
        Me.chkCriticismUnitNine.Text = "Unit"
        Me.chkCriticismUnitNine.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitSix
        '
        Me.chkCriticismUnitSix.AutoSize = True
        Me.chkCriticismUnitSix.Location = New System.Drawing.Point(6, 100)
        Me.chkCriticismUnitSix.Name = "chkCriticismUnitSix"
        Me.chkCriticismUnitSix.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitSix.TabIndex = 14
        Me.chkCriticismUnitSix.Text = "Unit"
        Me.chkCriticismUnitSix.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitFive
        '
        Me.chkCriticismUnitFive.AutoSize = True
        Me.chkCriticismUnitFive.Location = New System.Drawing.Point(6, 83)
        Me.chkCriticismUnitFive.Name = "chkCriticismUnitFive"
        Me.chkCriticismUnitFive.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitFive.TabIndex = 13
        Me.chkCriticismUnitFive.Text = "Unit"
        Me.chkCriticismUnitFive.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitSeven
        '
        Me.chkCriticismUnitSeven.AutoSize = True
        Me.chkCriticismUnitSeven.Location = New System.Drawing.Point(6, 117)
        Me.chkCriticismUnitSeven.Name = "chkCriticismUnitSeven"
        Me.chkCriticismUnitSeven.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitSeven.TabIndex = 15
        Me.chkCriticismUnitSeven.Text = "Unit"
        Me.chkCriticismUnitSeven.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitEight
        '
        Me.chkCriticismUnitEight.AutoSize = True
        Me.chkCriticismUnitEight.Location = New System.Drawing.Point(6, 134)
        Me.chkCriticismUnitEight.Name = "chkCriticismUnitEight"
        Me.chkCriticismUnitEight.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitEight.TabIndex = 16
        Me.chkCriticismUnitEight.Text = "Unit"
        Me.chkCriticismUnitEight.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitTwo
        '
        Me.chkCriticismUnitTwo.AutoSize = True
        Me.chkCriticismUnitTwo.Location = New System.Drawing.Point(6, 32)
        Me.chkCriticismUnitTwo.Name = "chkCriticismUnitTwo"
        Me.chkCriticismUnitTwo.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitTwo.TabIndex = 10
        Me.chkCriticismUnitTwo.Text = "Unit"
        Me.chkCriticismUnitTwo.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitOne
        '
        Me.chkCriticismUnitOne.AutoSize = True
        Me.chkCriticismUnitOne.Location = New System.Drawing.Point(6, 15)
        Me.chkCriticismUnitOne.Name = "chkCriticismUnitOne"
        Me.chkCriticismUnitOne.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitOne.TabIndex = 9
        Me.chkCriticismUnitOne.Text = "Unit"
        Me.chkCriticismUnitOne.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitThree
        '
        Me.chkCriticismUnitThree.AutoSize = True
        Me.chkCriticismUnitThree.Location = New System.Drawing.Point(6, 49)
        Me.chkCriticismUnitThree.Name = "chkCriticismUnitThree"
        Me.chkCriticismUnitThree.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitThree.TabIndex = 11
        Me.chkCriticismUnitThree.Text = "Unit"
        Me.chkCriticismUnitThree.UseVisualStyleBackColor = True
        '
        'chkCriticismUnitFour
        '
        Me.chkCriticismUnitFour.AutoSize = True
        Me.chkCriticismUnitFour.Location = New System.Drawing.Point(6, 66)
        Me.chkCriticismUnitFour.Name = "chkCriticismUnitFour"
        Me.chkCriticismUnitFour.Size = New System.Drawing.Size(45, 17)
        Me.chkCriticismUnitFour.TabIndex = 12
        Me.chkCriticismUnitFour.Text = "Unit"
        Me.chkCriticismUnitFour.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(394, 376)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(200, 23)
        Me.btnGenerate.TabIndex = 18
        Me.btnGenerate.Text = "Generate New Comment"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'grpExport
        '
        Me.grpExport.BackColor = System.Drawing.Color.Transparent
        Me.grpExport.Controls.Add(Me.btnExportToHomelogic)
        Me.grpExport.Controls.Add(Me.bnExportToXML)
        Me.grpExport.Controls.Add(Me.btnExportToPDF)
        Me.grpExport.Controls.Add(Me.btnExportFile)
        Me.grpExport.Location = New System.Drawing.Point(600, 268)
        Me.grpExport.Name = "grpExport"
        Me.grpExport.Size = New System.Drawing.Size(185, 131)
        Me.grpExport.TabIndex = 17
        Me.grpExport.TabStop = False
        Me.grpExport.Text = "Export Tools"
        '
        'btnExportToHomelogic
        '
        Me.btnExportToHomelogic.Location = New System.Drawing.Point(6, 101)
        Me.btnExportToHomelogic.Name = "btnExportToHomelogic"
        Me.btnExportToHomelogic.Size = New System.Drawing.Size(173, 23)
        Me.btnExportToHomelogic.TabIndex = 28
        Me.btnExportToHomelogic.Text = "Export to Homelogic?"
        Me.btnExportToHomelogic.UseVisualStyleBackColor = True
        '
        'bnExportToXML
        '
        Me.bnExportToXML.Location = New System.Drawing.Point(6, 72)
        Me.bnExportToXML.Name = "bnExportToXML"
        Me.bnExportToXML.Size = New System.Drawing.Size(173, 23)
        Me.bnExportToXML.TabIndex = 27
        Me.bnExportToXML.Text = "Export to XML"
        Me.bnExportToXML.UseVisualStyleBackColor = True
        '
        'btnExportToPDF
        '
        Me.btnExportToPDF.Location = New System.Drawing.Point(6, 43)
        Me.btnExportToPDF.Name = "btnExportToPDF"
        Me.btnExportToPDF.Size = New System.Drawing.Size(173, 23)
        Me.btnExportToPDF.TabIndex = 26
        Me.btnExportToPDF.Text = "Export to PDF"
        Me.btnExportToPDF.UseVisualStyleBackColor = True
        '
        'btnExportFile
        '
        Me.btnExportFile.Location = New System.Drawing.Point(6, 14)
        Me.btnExportFile.Name = "btnExportFile"
        Me.btnExportFile.Size = New System.Drawing.Size(173, 23)
        Me.btnExportFile.TabIndex = 25
        Me.btnExportFile.Text = "Export to File"
        Me.btnExportFile.UseVisualStyleBackColor = True
        '
        'SFDialog2
        '
        '
        'SFDialog3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 603)
        Me.Controls.Add(Me.grpExport)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.grpCriticismUnits)
        Me.Controls.Add(Me.grpUnitPraise)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.grpOtherOptions)
        Me.Controls.Add(Me.grpCriticism)
        Me.Controls.Add(Me.grpPraises)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lstStudentNames)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comment Gen V.9000 Build 1"
        Me.cmsComment.ResumeLayout(False)
        Me.grpPraises.ResumeLayout(False)
        Me.grpPraises.PerformLayout()
        Me.grpCriticism.ResumeLayout(False)
        Me.grpCriticism.PerformLayout()
        Me.grpOtherOptions.ResumeLayout(False)
        Me.grpUnitPraise.ResumeLayout(False)
        Me.grpUnitPraise.PerformLayout()
        Me.grpCriticismUnits.ResumeLayout(False)
        Me.grpCriticismUnits.PerformLayout()
        Me.grpExport.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents lstStudentNames As System.Windows.Forms.ListBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents grpPraises As System.Windows.Forms.GroupBox
    Friend WithEvents chkPraiseFour As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseThree As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseTwo As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseOne As System.Windows.Forms.CheckBox
    Friend WithEvents grpCriticism As System.Windows.Forms.GroupBox
    Friend WithEvents btnInsertPraises As System.Windows.Forms.Button
    Friend WithEvents txtCustomPraise As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomPraises As System.Windows.Forms.Label
    Friend WithEvents btnInsertCriticism As System.Windows.Forms.Button
    Friend WithEvents chkCriticismTwo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCriticism As System.Windows.Forms.TextBox
    Friend WithEvents chkCriticismOne As System.Windows.Forms.CheckBox
    Friend WithEvents lblCriticism As System.Windows.Forms.Label
    Friend WithEvents chkCriticismThree As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismFour As System.Windows.Forms.CheckBox
    Friend WithEvents grpOtherOptions As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddUnits As System.Windows.Forms.Button
    Friend WithEvents btnSpecifyCourseName As System.Windows.Forms.Button
    Friend WithEvents btnClassAverage As System.Windows.Forms.Button
    Friend WithEvents btnCommentHistory As System.Windows.Forms.Button
    Friend WithEvents btnEditDatabase As System.Windows.Forms.Button
    Friend WithEvents btnCreateDB As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents OFDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFDialog As SaveFileDialog
    Friend WithEvents lblHelp2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents cmsComment As ContextMenuStrip
    Friend WithEvents tsmPraise As ToolStripMenuItem
    Friend WithEvents tsmCriticism As ToolStripMenuItem
    Friend WithEvents tsmInstructions As ToolStripMenuItem
    Friend WithEvents grpUnitPraise As System.Windows.Forms.GroupBox
    Friend WithEvents chkPraiseUnitTen As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitNine As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitSix As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitFive As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitSeven As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitEight As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitTwo As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitOne As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitThree As System.Windows.Forms.CheckBox
    Friend WithEvents chkPraiseUnitFour As System.Windows.Forms.CheckBox
    Friend WithEvents grpCriticismUnits As System.Windows.Forms.GroupBox
    Friend WithEvents chkCriticismUnitTen As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitNine As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitSix As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitFive As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitSeven As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitEight As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitTwo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitOne As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitThree As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriticismUnitFour As System.Windows.Forms.CheckBox
    Friend WithEvents cmsComments As ContextMenuStrip
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents grpExport As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportToHomelogic As System.Windows.Forms.Button
    Friend WithEvents bnExportToXML As System.Windows.Forms.Button
    Friend WithEvents btnExportToPDF As System.Windows.Forms.Button
    Friend WithEvents btnExportFile As System.Windows.Forms.Button
    Friend WithEvents SFDialog2 As SaveFileDialog
    Friend WithEvents SFDialog3 As SaveFileDialog
End Class
