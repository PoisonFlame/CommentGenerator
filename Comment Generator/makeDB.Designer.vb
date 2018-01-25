<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class makeDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(makeDB))
        Me.lblDatabaseCreation = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.lblDatabseFile = New System.Windows.Forms.Label()
        Me.grpAddStudents = New System.Windows.Forms.GroupBox()
        Me.lblNumOfStudents = New System.Windows.Forms.Label()
        Me.lblStudentGrade = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblAddStudentInfo = New System.Windows.Forms.Label()
        Me.btnAddStudents = New System.Windows.Forms.Button()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog()
        Me.grpAddStudents.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDatabaseCreation
        '
        Me.lblDatabaseCreation.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabaseCreation.Font = New System.Drawing.Font("Papyrus", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseCreation.Location = New System.Drawing.Point(0, 0)
        Me.lblDatabaseCreation.Name = "lblDatabaseCreation"
        Me.lblDatabaseCreation.Size = New System.Drawing.Size(637, 48)
        Me.lblDatabaseCreation.TabIndex = 0
        Me.lblDatabaseCreation.Text = "Database Creation"
        Me.lblDatabaseCreation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(532, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 23)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "Save Database"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(454, 329)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(302, 75)
        Me.txtDatabase.Multiline = True
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.ReadOnly = True
        Me.txtDatabase.Size = New System.Drawing.Size(324, 248)
        Me.txtDatabase.TabIndex = 37
        '
        'lblDatabseFile
        '
        Me.lblDatabseFile.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabseFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabseFile.Location = New System.Drawing.Point(302, 53)
        Me.lblDatabseFile.Name = "lblDatabseFile"
        Me.lblDatabseFile.Size = New System.Drawing.Size(335, 21)
        Me.lblDatabseFile.TabIndex = 38
        Me.lblDatabseFile.Text = "Database File"
        Me.lblDatabseFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpAddStudents
        '
        Me.grpAddStudents.BackColor = System.Drawing.Color.Transparent
        Me.grpAddStudents.Controls.Add(Me.lblNumOfStudents)
        Me.grpAddStudents.Controls.Add(Me.lblStudentGrade)
        Me.grpAddStudents.Controls.Add(Me.lblStudentName)
        Me.grpAddStudents.Controls.Add(Me.lblAddStudentInfo)
        Me.grpAddStudents.Controls.Add(Me.btnAddStudents)
        Me.grpAddStudents.Controls.Add(Me.txtStudentName)
        Me.grpAddStudents.Controls.Add(Me.txtGrade)
        Me.grpAddStudents.Location = New System.Drawing.Point(12, 75)
        Me.grpAddStudents.Name = "grpAddStudents"
        Me.grpAddStudents.Size = New System.Drawing.Size(284, 248)
        Me.grpAddStudents.TabIndex = 39
        Me.grpAddStudents.TabStop = False
        Me.grpAddStudents.Text = "Add Students to Database"
        '
        'lblNumOfStudents
        '
        Me.lblNumOfStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfStudents.Location = New System.Drawing.Point(0, 183)
        Me.lblNumOfStudents.Name = "lblNumOfStudents"
        Me.lblNumOfStudents.Size = New System.Drawing.Size(278, 62)
        Me.lblNumOfStudents.TabIndex = 46
        Me.lblNumOfStudents.Text = "Number of Students in Database: 0"
        '
        'lblStudentGrade
        '
        Me.lblStudentGrade.AutoSize = True
        Me.lblStudentGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentGrade.Location = New System.Drawing.Point(7, 134)
        Me.lblStudentGrade.Name = "lblStudentGrade"
        Me.lblStudentGrade.Size = New System.Drawing.Size(186, 13)
        Me.lblStudentGrade.TabIndex = 45
        Me.lblStudentGrade.Text = "Student Grade(without % sign): "
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(7, 108)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(95, 13)
        Me.lblStudentName.TabIndex = 40
        Me.lblStudentName.Text = "Student Name: "
        '
        'lblAddStudentInfo
        '
        Me.lblAddStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddStudentInfo.Location = New System.Drawing.Point(0, 16)
        Me.lblAddStudentInfo.Name = "lblAddStudentInfo"
        Me.lblAddStudentInfo.Size = New System.Drawing.Size(284, 58)
        Me.lblAddStudentInfo.TabIndex = 41
        Me.lblAddStudentInfo.Text = "Enter Name and Grade to add to database"
        Me.lblAddStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddStudents
        '
        Me.btnAddStudents.Location = New System.Drawing.Point(199, 157)
        Me.btnAddStudents.Name = "btnAddStudents"
        Me.btnAddStudents.Size = New System.Drawing.Size(79, 23)
        Me.btnAddStudents.TabIndex = 42
        Me.btnAddStudents.Text = "Add Student"
        Me.btnAddStudents.UseVisualStyleBackColor = True
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(108, 105)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(170, 20)
        Me.txtStudentName.TabIndex = 43
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(199, 131)
        Me.txtGrade.MaxLength = 3
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(79, 20)
        Me.txtGrade.TabIndex = 44
        '
        'SFDialog
        '
        '
        'makeDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 364)
        Me.Controls.Add(Me.grpAddStudents)
        Me.Controls.Add(Me.lblDatabseFile)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDatabaseCreation)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "makeDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Database - Comment Generator"
        Me.grpAddStudents.ResumeLayout(False)
        Me.grpAddStudents.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDatabaseCreation As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents lblDatabseFile As Label
    Friend WithEvents grpAddStudents As GroupBox
    Friend WithEvents lblNumOfStudents As Label
    Friend WithEvents lblStudentGrade As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblAddStudentInfo As Label
    Friend WithEvents btnAddStudents As Button
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents SFDialog As SaveFileDialog
End Class
