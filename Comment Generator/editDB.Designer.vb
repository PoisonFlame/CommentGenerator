<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editDB))
        Me.lblDatabaseEdit = New System.Windows.Forms.Label()
        Me.lblDatabseFile = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpEditStudentsStudents = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cmbStudents = New System.Windows.Forms.ComboBox()
        Me.lblStudentGrade = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblEditStudentInfo = New System.Windows.Forms.Label()
        Me.btnSaveStudent = New System.Windows.Forms.Button()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.tmrTasks = New System.Windows.Forms.Timer(Me.components)
        Me.grpEditStudentsStudents.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDatabaseEdit
        '
        Me.lblDatabaseEdit.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabaseEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDatabaseEdit.Font = New System.Drawing.Font("Papyrus", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseEdit.Location = New System.Drawing.Point(0, 0)
        Me.lblDatabaseEdit.Name = "lblDatabaseEdit"
        Me.lblDatabaseEdit.Size = New System.Drawing.Size(638, 48)
        Me.lblDatabaseEdit.TabIndex = 1
        Me.lblDatabaseEdit.Text = "Edit Database"
        Me.lblDatabaseEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDatabseFile
        '
        Me.lblDatabseFile.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabseFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabseFile.Location = New System.Drawing.Point(302, 54)
        Me.lblDatabseFile.Name = "lblDatabseFile"
        Me.lblDatabseFile.Size = New System.Drawing.Size(335, 21)
        Me.lblDatabseFile.TabIndex = 42
        Me.lblDatabseFile.Text = "Database File"
        Me.lblDatabseFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(302, 76)
        Me.txtDatabase.Multiline = True
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.ReadOnly = True
        Me.txtDatabase.Size = New System.Drawing.Size(324, 248)
        Me.txtDatabase.TabIndex = 41
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(454, 330)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(532, 330)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 23)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save Database"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpEditStudentsStudents
        '
        Me.grpEditStudentsStudents.BackColor = System.Drawing.Color.Transparent
        Me.grpEditStudentsStudents.Controls.Add(Me.btnRemove)
        Me.grpEditStudentsStudents.Controls.Add(Me.cmbStudents)
        Me.grpEditStudentsStudents.Controls.Add(Me.lblStudentGrade)
        Me.grpEditStudentsStudents.Controls.Add(Me.lblStudentName)
        Me.grpEditStudentsStudents.Controls.Add(Me.lblEditStudentInfo)
        Me.grpEditStudentsStudents.Controls.Add(Me.btnSaveStudent)
        Me.grpEditStudentsStudents.Controls.Add(Me.txtStudentName)
        Me.grpEditStudentsStudents.Controls.Add(Me.txtGrade)
        Me.grpEditStudentsStudents.Location = New System.Drawing.Point(8, 76)
        Me.grpEditStudentsStudents.Name = "grpEditStudentsStudents"
        Me.grpEditStudentsStudents.Size = New System.Drawing.Size(284, 248)
        Me.grpEditStudentsStudents.TabIndex = 43
        Me.grpEditStudentsStudents.TabStop = False
        Me.grpEditStudentsStudents.Text = "Edit Students in Database"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(138, 213)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(67, 23)
        Me.btnRemove.TabIndex = 46
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'cmbStudents
        '
        Me.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudents.FormattingEnabled = True
        Me.cmbStudents.Location = New System.Drawing.Point(6, 111)
        Me.cmbStudents.Name = "cmbStudents"
        Me.cmbStudents.Size = New System.Drawing.Size(272, 21)
        Me.cmbStudents.TabIndex = 44
        '
        'lblStudentGrade
        '
        Me.lblStudentGrade.AutoSize = True
        Me.lblStudentGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentGrade.Location = New System.Drawing.Point(7, 190)
        Me.lblStudentGrade.Name = "lblStudentGrade"
        Me.lblStudentGrade.Size = New System.Drawing.Size(186, 13)
        Me.lblStudentGrade.TabIndex = 45
        Me.lblStudentGrade.Text = "Student Grade(without % sign): "
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(7, 164)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(95, 13)
        Me.lblStudentName.TabIndex = 40
        Me.lblStudentName.Text = "Student Name: "
        '
        'lblEditStudentInfo
        '
        Me.lblEditStudentInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEditStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditStudentInfo.Location = New System.Drawing.Point(3, 16)
        Me.lblEditStudentInfo.Name = "lblEditStudentInfo"
        Me.lblEditStudentInfo.Size = New System.Drawing.Size(278, 92)
        Me.lblEditStudentInfo.TabIndex = 41
        Me.lblEditStudentInfo.Text = "Choose a Student from the dropdown to edit below"
        Me.lblEditStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveStudent
        '
        Me.btnSaveStudent.Location = New System.Drawing.Point(211, 213)
        Me.btnSaveStudent.Name = "btnSaveStudent"
        Me.btnSaveStudent.Size = New System.Drawing.Size(67, 23)
        Me.btnSaveStudent.TabIndex = 42
        Me.btnSaveStudent.Text = "Save"
        Me.btnSaveStudent.UseVisualStyleBackColor = True
        '
        'txtStudentName
        '
        Me.txtStudentName.Enabled = False
        Me.txtStudentName.Location = New System.Drawing.Point(108, 161)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(170, 20)
        Me.txtStudentName.TabIndex = 43
        '
        'txtGrade
        '
        Me.txtGrade.Enabled = False
        Me.txtGrade.Location = New System.Drawing.Point(199, 187)
        Me.txtGrade.MaxLength = 3
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(79, 20)
        Me.txtGrade.TabIndex = 44
        '
        'OFDialog
        '
        Me.OFDialog.FileName = "OpenFileDialog1"
        '
        'tmrTasks
        '
        Me.tmrTasks.Enabled = True
        '
        'editDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 364)
        Me.Controls.Add(Me.grpEditStudentsStudents)
        Me.Controls.Add(Me.lblDatabseFile)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDatabaseEdit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Database - Comment Generator"
        Me.grpEditStudentsStudents.ResumeLayout(False)
        Me.grpEditStudentsStudents.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatabaseEdit As System.Windows.Forms.Label
    Friend WithEvents lblDatabseFile As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpEditStudentsStudents As System.Windows.Forms.GroupBox
    Friend WithEvents lblStudentGrade As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblEditStudentInfo As System.Windows.Forms.Label
    Friend WithEvents btnSaveStudent As System.Windows.Forms.Button
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents cmbStudents As System.Windows.Forms.ComboBox
    Friend WithEvents SFDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OFDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnRemove As Button
    Friend WithEvents tmrTasks As System.Windows.Forms.Timer
End Class
