<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commentHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(commentHistory))
        Me.cmbDates = New System.Windows.Forms.ComboBox()
        Me.lblCommentHistory = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.wbPDFViewer = New System.Windows.Forms.WebBrowser()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbDates
        '
        Me.cmbDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDates.FormattingEnabled = True
        Me.cmbDates.Location = New System.Drawing.Point(125, 38)
        Me.cmbDates.Name = "cmbDates"
        Me.cmbDates.Size = New System.Drawing.Size(547, 21)
        Me.cmbDates.TabIndex = 0
        '
        'lblCommentHistory
        '
        Me.lblCommentHistory.BackColor = System.Drawing.Color.Transparent
        Me.lblCommentHistory.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommentHistory.Location = New System.Drawing.Point(-1, 2)
        Me.lblCommentHistory.Name = "lblCommentHistory"
        Me.lblCommentHistory.Size = New System.Drawing.Size(685, 33)
        Me.lblCommentHistory.TabIndex = 1
        Me.lblCommentHistory.Text = "Comment History"
        Me.lblCommentHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(2, 41)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(123, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Corresponding Date:"
        '
        'wbPDFViewer
        '
        Me.wbPDFViewer.Location = New System.Drawing.Point(0, 65)
        Me.wbPDFViewer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbPDFViewer.Name = "wbPDFViewer"
        Me.wbPDFViewer.Size = New System.Drawing.Size(684, 376)
        Me.wbPDFViewer.TabIndex = 3
        Me.wbPDFViewer.Url = New System.Uri("", System.UriKind.Relative)
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(12, 10)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnInfo.TabIndex = 4
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'commentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 441)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.wbPDFViewer)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblCommentHistory)
        Me.Controls.Add(Me.cmbDates)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "commentHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comment History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDates As System.Windows.Forms.ComboBox
    Friend WithEvents lblCommentHistory As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents wbPDFViewer As WebBrowser
    Friend WithEvents btnInfo As Button
End Class
