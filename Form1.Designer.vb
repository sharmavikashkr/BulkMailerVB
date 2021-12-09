<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BulkMailer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BulkMailer))
        Me.WorkFolderLabel = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.WorkFolderPicker = New System.Windows.Forms.FolderBrowserDialog()
        Me.WorkFolderPath = New System.Windows.Forms.TextBox()
        Me.WorkFolderDialogOpener = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WorkFolderLabel
        '
        Me.WorkFolderLabel.AutoSize = True
        Me.WorkFolderLabel.Location = New System.Drawing.Point(29, 38)
        Me.WorkFolderLabel.Name = "WorkFolderLabel"
        Me.WorkFolderLabel.Size = New System.Drawing.Size(89, 17)
        Me.WorkFolderLabel.TabIndex = 1
        Me.WorkFolderLabel.Text = "Work Folder:"
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.LimeGreen
        Me.Start.Location = New System.Drawing.Point(32, 159)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(86, 33)
        Me.Start.TabIndex = 2
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.ForeColor = System.Drawing.Color.Red
        Me.StatusLabel.Location = New System.Drawing.Point(29, 123)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(48, 17)
        Me.StatusLabel.TabIndex = 4
        Me.StatusLabel.Text = "Status"
        '
        'WorkFolderPicker
        '
        Me.WorkFolderPicker.ShowNewFolderButton = False
        '
        'WorkFolderPath
        '
        Me.WorkFolderPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.WorkFolderPath.Location = New System.Drawing.Point(32, 77)
        Me.WorkFolderPath.Name = "WorkFolderPath"
        Me.WorkFolderPath.Size = New System.Drawing.Size(464, 22)
        Me.WorkFolderPath.TabIndex = 5
        '
        'WorkFolderDialogOpener
        '
        Me.WorkFolderDialogOpener.Location = New System.Drawing.Point(421, 77)
        Me.WorkFolderDialogOpener.Name = "WorkFolderDialogOpener"
        Me.WorkFolderDialogOpener.Size = New System.Drawing.Size(75, 23)
        Me.WorkFolderDialogOpener.TabIndex = 6
        Me.WorkFolderDialogOpener.Text = "Select"
        Me.WorkFolderDialogOpener.UseVisualStyleBackColor = True
        '
        'BulkMailer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 231)
        Me.Controls.Add(Me.WorkFolderDialogOpener)
        Me.Controls.Add(Me.WorkFolderPath)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.WorkFolderLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BulkMailer"
        Me.Text = "BulkMailer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WorkFolderLabel As Label
    Friend WithEvents Start As Button
    Friend WithEvents StatusLabel As Label
    Friend WithEvents WorkFolderPicker As FolderBrowserDialog
    Friend WithEvents WorkFolderPath As TextBox
    Friend WithEvents WorkFolderDialogOpener As Button
End Class
