<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.serverPortTextBox = New System.Windows.Forms.TextBox()
        Me.serverHostTextBox = New System.Windows.Forms.TextBox()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.portTextBox = New System.Windows.Forms.TextBox()
        Me.hostTextBox = New System.Windows.Forms.TextBox()
        Me.sendButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resTextBox = New System.Windows.Forms.TextBox()
        Me.msgTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(807, 456)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.serverPortTextBox)
        Me.TabPage1.Controls.Add(Me.serverHostTextBox)
        Me.TabPage1.Controls.Add(Me.stopButton)
        Me.TabPage1.Controls.Add(Me.startButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(799, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Server"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(144, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "IP address: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(514, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = ":"
        '
        'serverPortTextBox
        '
        Me.serverPortTextBox.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.serverPortTextBox.Location = New System.Drawing.Point(533, 148)
        Me.serverPortTextBox.Name = "serverPortTextBox"
        Me.serverPortTextBox.Size = New System.Drawing.Size(99, 27)
        Me.serverPortTextBox.TabIndex = 35
        '
        'serverHostTextBox
        '
        Me.serverHostTextBox.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.serverHostTextBox.Location = New System.Drawing.Point(230, 148)
        Me.serverHostTextBox.Name = "serverHostTextBox"
        Me.serverHostTextBox.Size = New System.Drawing.Size(278, 27)
        Me.serverHostTextBox.TabIndex = 34
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(470, 199)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 23)
        Me.stopButton.TabIndex = 23
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(249, 199)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 22
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.portTextBox)
        Me.TabPage2.Controls.Add(Me.hostTextBox)
        Me.TabPage2.Controls.Add(Me.sendButton)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.resTextBox)
        Me.TabPage2.Controls.Add(Me.msgTextBox)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(799, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Client"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "IP address: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = ":"
        '
        'portTextBox
        '
        Me.portTextBox.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.portTextBox.Location = New System.Drawing.Point(515, 49)
        Me.portTextBox.Name = "portTextBox"
        Me.portTextBox.Size = New System.Drawing.Size(99, 27)
        Me.portTextBox.TabIndex = 31
        '
        'hostTextBox
        '
        Me.hostTextBox.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.hostTextBox.Location = New System.Drawing.Point(212, 49)
        Me.hostTextBox.Name = "hostTextBox"
        Me.hostTextBox.Size = New System.Drawing.Size(278, 27)
        Me.hostTextBox.TabIndex = 30
        '
        'sendButton
        '
        Me.sendButton.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.sendButton.Location = New System.Drawing.Point(539, 203)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(75, 23)
        Me.sendButton.TabIndex = 29
        Me.sendButton.Text = "Send"
        Me.sendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.sendButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(73, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Response message: "
        '
        'resTextBox
        '
        Me.resTextBox.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.resTextBox.Location = New System.Drawing.Point(212, 255)
        Me.resTextBox.Multiline = True
        Me.resTextBox.Name = "resTextBox"
        Me.resTextBox.Size = New System.Drawing.Size(402, 87)
        Me.resTextBox.TabIndex = 27
        '
        'msgTextBox
        '
        Me.msgTextBox.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.msgTextBox.Location = New System.Drawing.Point(212, 107)
        Me.msgTextBox.Multiline = True
        Me.msgTextBox.Name = "msgTextBox"
        Me.msgTextBox.Size = New System.Drawing.Size(402, 90)
        Me.msgTextBox.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(136, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Message: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents sendButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents resTextBox As TextBox
    Friend WithEvents msgTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents portTextBox As TextBox
    Friend WithEvents hostTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents stopButton As Button
    Friend WithEvents startButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents serverPortTextBox As TextBox
    Friend WithEvents serverHostTextBox As TextBox
End Class
