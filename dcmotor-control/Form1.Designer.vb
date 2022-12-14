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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.fbtn = New System.Windows.Forms.Button()
        Me.rbtn = New System.Windows.Forms.Button()
        Me.lbtn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.com_btn = New System.Windows.Forms.Button()
        Me.sbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'fbtn
        '
        Me.fbtn.Location = New System.Drawing.Point(548, 205)
        Me.fbtn.Name = "fbtn"
        Me.fbtn.Size = New System.Drawing.Size(188, 144)
        Me.fbtn.TabIndex = 0
        Me.fbtn.Text = "FORWARD"
        Me.fbtn.UseVisualStyleBackColor = True
        '
        'rbtn
        '
        Me.rbtn.Location = New System.Drawing.Point(752, 380)
        Me.rbtn.Name = "rbtn"
        Me.rbtn.Size = New System.Drawing.Size(152, 144)
        Me.rbtn.TabIndex = 2
        Me.rbtn.Text = "RIGHT"
        Me.rbtn.UseVisualStyleBackColor = True
        '
        'lbtn
        '
        Me.lbtn.Location = New System.Drawing.Point(372, 380)
        Me.lbtn.Name = "lbtn"
        Me.lbtn.Size = New System.Drawing.Size(152, 144)
        Me.lbtn.TabIndex = 3
        Me.lbtn.Text = "LEFT"
        Me.lbtn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(1137, 738)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(190, 96)
        Me.exit_btn.TabIndex = 5
        Me.exit_btn.Text = "EXIT"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 654)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Port"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 704)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 38)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "COM6"
        '
        'com_btn
        '
        Me.com_btn.Location = New System.Drawing.Point(29, 760)
        Me.com_btn.Name = "com_btn"
        Me.com_btn.Size = New System.Drawing.Size(190, 96)
        Me.com_btn.TabIndex = 8
        Me.com_btn.Text = "OK"
        Me.com_btn.UseVisualStyleBackColor = True
        '
        'sbtn
        '
        Me.sbtn.Location = New System.Drawing.Point(563, 380)
        Me.sbtn.Name = "sbtn"
        Me.sbtn.Size = New System.Drawing.Size(152, 144)
        Me.sbtn.TabIndex = 9
        Me.sbtn.Text = "STOP"
        Me.sbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(548, 578)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 144)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "BACKWARD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 881)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sbtn)
        Me.Controls.Add(Me.com_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.lbtn)
        Me.Controls.Add(Me.rbtn)
        Me.Controls.Add(Me.fbtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents fbtn As Button
    Friend WithEvents rbtn As Button
    Friend WithEvents lbtn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents com_btn As Button
    Friend WithEvents sbtn As Button
    Friend WithEvents Button1 As Button
End Class
