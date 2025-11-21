<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxHiddenID = New System.Windows.Forms.TextBox()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(289, 26)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(200, 58)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(330, 116)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxName.TabIndex = 2
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(330, 142)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxAge.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(330, 168)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxEmail.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email:"
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(50, 203)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(160, 58)
        Me.ButtonCreate.TabIndex = 7
        Me.ButtonCreate.Text = "Create (Insert Data)"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(238, 203)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(160, 58)
        Me.ButtonRead.TabIndex = 8
        Me.ButtonRead.Text = "Read (Get Data)"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 136)
        Me.DataGridView1.TabIndex = 9
        '
        'TextBoxHiddenID
        '
        Me.TextBoxHiddenID.Location = New System.Drawing.Point(330, 90)
        Me.TextBoxHiddenID.Name = "TextBoxHiddenID"
        Me.TextBoxHiddenID.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxHiddenID.TabIndex = 10
        Me.TextBoxHiddenID.Visible = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(431, 203)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(160, 58)
        Me.ButtonUpdate.TabIndex = 11
        Me.ButtonUpdate.Text = "Update (Modify Existing Data)"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(608, 203)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(160, 58)
        Me.ButtonRemove.TabIndex = 12
        Me.ButtonRemove.Text = "Remove (Remove Data)"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.TextBoxHiddenID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxHiddenID As TextBox
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonRemove As Button
End Class
