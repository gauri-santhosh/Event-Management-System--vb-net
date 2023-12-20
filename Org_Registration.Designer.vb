<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Org_Registration
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
        Me.Register = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.username = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.username1 = New System.Windows.Forms.TextBox()
        Me.phone1 = New System.Windows.Forms.TextBox()
        Me.email1 = New System.Windows.Forms.TextBox()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.gender1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.address1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(212, 623)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(94, 29)
        Me.Register.TabIndex = 13
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(310, 559)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(134, 24)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(175, 150)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(75, 20)
        Me.username.TabIndex = 15
        Me.username.Text = "Username"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Location = New System.Drawing.Point(175, 213)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(57, 20)
        Me.gender.TabIndex = 16
        Me.gender.Text = "Gender"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(175, 276)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(50, 20)
        Me.phone.TabIndex = 17
        Me.phone.Text = "Phone"
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(172, 338)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(62, 20)
        Me.Address.TabIndex = 18
        Me.Address.Text = "Address"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(175, 446)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(46, 20)
        Me.password.TabIndex = 19
        Me.password.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(283, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "ORGANISER REGISTRATION"
        '
        'username1
        '
        Me.username1.Location = New System.Drawing.Point(306, 143)
        Me.username1.Name = "username1"
        Me.username1.Size = New System.Drawing.Size(155, 27)
        Me.username1.TabIndex = 21
        '
        'phone1
        '
        Me.phone1.Location = New System.Drawing.Point(306, 273)
        Me.phone1.Name = "phone1"
        Me.phone1.Size = New System.Drawing.Size(155, 27)
        Me.phone1.TabIndex = 22
        '
        'email1
        '
        Me.email1.Location = New System.Drawing.Point(310, 439)
        Me.email1.Name = "email1"
        Me.email1.Size = New System.Drawing.Size(151, 27)
        Me.email1.TabIndex = 23
        '
        'password1
        '
        Me.password1.Location = New System.Drawing.Point(310, 500)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(151, 27)
        Me.password1.TabIndex = 24
        Me.password1.UseSystemPasswordChar = True
        '
        'gender1
        '
        Me.gender1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender1.FormattingEnabled = True
        Me.gender1.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.gender1.Location = New System.Drawing.Point(310, 205)
        Me.gender1.Name = "gender1"
        Me.gender1.Size = New System.Drawing.Size(151, 28)
        Me.gender1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 503)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Password"
        '
        'address1
        '
        Me.address1.Location = New System.Drawing.Point(310, 335)
        Me.address1.Name = "address1"
        Me.address1.Size = New System.Drawing.Size(155, 66)
        Me.address1.TabIndex = 27
        Me.address1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 623)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Org_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 682)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.address1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gender1)
        Me.Controls.Add(Me.password1)
        Me.Controls.Add(Me.email1)
        Me.Controls.Add(Me.phone1)
        Me.Controls.Add(Me.username1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Register)
        Me.Name = "Org_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Register As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents username As Label
    Friend WithEvents gender As Label
    Friend WithEvents phone As Label
    Friend WithEvents Address As Label
    Friend WithEvents password As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents username1 As TextBox
    Friend WithEvents phone1 As TextBox
    Friend WithEvents gender1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents password1 As TextBox
    Friend WithEvents email1 As TextBox
    Friend WithEvents address1 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
