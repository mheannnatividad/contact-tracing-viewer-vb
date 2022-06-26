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
        Me.filenameLabel = New System.Windows.Forms.Label()
        Me.filenameBox = New System.Windows.Forms.TextBox()
        Me.StudentInfoLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.readTextBox = New System.Windows.Forms.RichTextBox()
        Me.readBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'filenameLabel
        '
        Me.filenameLabel.AutoSize = True
        Me.filenameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filenameLabel.Location = New System.Drawing.Point(6, 8)
        Me.filenameLabel.Name = "filenameLabel"
        Me.filenameLabel.Size = New System.Drawing.Size(94, 24)
        Me.filenameLabel.TabIndex = 0
        Me.filenameLabel.Text = "Filename:"
        '
        'filenameBox
        '
        Me.filenameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filenameBox.Location = New System.Drawing.Point(100, 10)
        Me.filenameBox.Name = "filenameBox"
        Me.filenameBox.Size = New System.Drawing.Size(116, 23)
        Me.filenameBox.TabIndex = 1
        '
        'StudentInfoLabel
        '
        Me.StudentInfoLabel.AutoSize = True
        Me.StudentInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentInfoLabel.Location = New System.Drawing.Point(3, 0)
        Me.StudentInfoLabel.Name = "StudentInfoLabel"
        Me.StudentInfoLabel.Size = New System.Drawing.Size(171, 24)
        Me.StudentInfoLabel.TabIndex = 0
        Me.StudentInfoLabel.Text = "Student Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.StudentInfoLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 31)
        Me.Panel1.TabIndex = 2
        '
        'readTextBox
        '
        Me.readTextBox.Location = New System.Drawing.Point(13, 91)
        Me.readTextBox.Name = "readTextBox"
        Me.readTextBox.Size = New System.Drawing.Size(373, 285)
        Me.readTextBox.TabIndex = 3
        Me.readTextBox.Text = ""
        '
        'readBtn
        '
        Me.readBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readBtn.Location = New System.Drawing.Point(205, 392)
        Me.readBtn.Name = "readBtn"
        Me.readBtn.Size = New System.Drawing.Size(80, 37)
        Me.readBtn.TabIndex = 4
        Me.readBtn.Text = "Read Text"
        Me.readBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(300, 392)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(80, 37)
        Me.clearBtn.TabIndex = 4
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.readBtn)
        Me.Controls.Add(Me.readTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.filenameBox)
        Me.Controls.Add(Me.filenameLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents filenameLabel As Label
    Friend WithEvents filenameBox As TextBox
    Friend WithEvents StudentInfoLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents readTextBox As RichTextBox
    Friend WithEvents readBtn As Button
    Friend WithEvents clearBtn As Button
End Class
