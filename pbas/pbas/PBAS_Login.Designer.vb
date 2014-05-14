<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PBAS_Login
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.log_sup = New System.Windows.Forms.TabControl
        Me.Login_Tab = New System.Windows.Forms.TabPage
        Me.Signup_Link = New System.Windows.Forms.LinkLabel
        Me.Cancelbtn = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lpwd = New System.Windows.Forms.TextBox
        Me.luid = New System.Windows.Forms.TextBox
        Me.Loginbtn = New System.Windows.Forms.Button
        Me.Signup_Tab = New System.Windows.Forms.TabPage
        Me.Login_Link = New System.Windows.Forms.LinkLabel
        Me.Button6 = New System.Windows.Forms.Button
        Me.signupbtn = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.spwd = New System.Windows.Forms.TextBox
        Me.srpwd = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.suid = New System.Windows.Forms.TextBox
        Me.log_sup.SuspendLayout()
        Me.Login_Tab.SuspendLayout()
        Me.Signup_Tab.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 304)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "About PBAS"
        '
        'log_sup
        '
        Me.log_sup.Controls.Add(Me.Login_Tab)
        Me.log_sup.Controls.Add(Me.Signup_Tab)
        Me.log_sup.Location = New System.Drawing.Point(266, 12)
        Me.log_sup.Name = "log_sup"
        Me.log_sup.SelectedIndex = 0
        Me.log_sup.Size = New System.Drawing.Size(337, 283)
        Me.log_sup.TabIndex = 3
        '
        'Login_Tab
        '
        Me.Login_Tab.Controls.Add(Me.Signup_Link)
        Me.Login_Tab.Controls.Add(Me.Cancelbtn)
        Me.Login_Tab.Controls.Add(Me.Label6)
        Me.Login_Tab.Controls.Add(Me.Label7)
        Me.Login_Tab.Controls.Add(Me.lpwd)
        Me.Login_Tab.Controls.Add(Me.luid)
        Me.Login_Tab.Controls.Add(Me.Loginbtn)
        Me.Login_Tab.Location = New System.Drawing.Point(4, 22)
        Me.Login_Tab.Name = "Login_Tab"
        Me.Login_Tab.Padding = New System.Windows.Forms.Padding(3)
        Me.Login_Tab.Size = New System.Drawing.Size(329, 257)
        Me.Login_Tab.TabIndex = 0
        Me.Login_Tab.Text = "LOGIN"
        Me.Login_Tab.UseVisualStyleBackColor = True
        '
        'Signup_Link
        '
        Me.Signup_Link.AutoSize = True
        Me.Signup_Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup_Link.Location = New System.Drawing.Point(88, 199)
        Me.Signup_Link.Name = "Signup_Link"
        Me.Signup_Link.Size = New System.Drawing.Size(145, 17)
        Me.Signup_Link.TabIndex = 5
        Me.Signup_Link.TabStop = True
        Me.Signup_Link.Text = "Not yet registered???"
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelbtn.Location = New System.Drawing.Point(173, 132)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(94, 25)
        Me.Cancelbtn.TabIndex = 3
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "User Name"
        '
        'lpwd
        '
        Me.lpwd.Location = New System.Drawing.Point(166, 82)
        Me.lpwd.Name = "lpwd"
        Me.lpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.lpwd.Size = New System.Drawing.Size(117, 20)
        Me.lpwd.TabIndex = 1
        '
        'luid
        '
        Me.luid.Location = New System.Drawing.Point(164, 41)
        Me.luid.Name = "luid"
        Me.luid.Size = New System.Drawing.Size(119, 20)
        Me.luid.TabIndex = 0
        '
        'Loginbtn
        '
        Me.Loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.Location = New System.Drawing.Point(49, 132)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(93, 24)
        Me.Loginbtn.TabIndex = 2
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = True
        '
        'Signup_Tab
        '
        Me.Signup_Tab.Controls.Add(Me.Login_Link)
        Me.Signup_Tab.Controls.Add(Me.Button6)
        Me.Signup_Tab.Controls.Add(Me.signupbtn)
        Me.Signup_Tab.Controls.Add(Me.Label11)
        Me.Signup_Tab.Controls.Add(Me.Label12)
        Me.Signup_Tab.Controls.Add(Me.spwd)
        Me.Signup_Tab.Controls.Add(Me.srpwd)
        Me.Signup_Tab.Controls.Add(Me.Label13)
        Me.Signup_Tab.Controls.Add(Me.suid)
        Me.Signup_Tab.Location = New System.Drawing.Point(4, 22)
        Me.Signup_Tab.Name = "Signup_Tab"
        Me.Signup_Tab.Padding = New System.Windows.Forms.Padding(3)
        Me.Signup_Tab.Size = New System.Drawing.Size(329, 257)
        Me.Signup_Tab.TabIndex = 1
        Me.Signup_Tab.Text = "SIGN UP"
        Me.Signup_Tab.UseVisualStyleBackColor = True
        '
        'Login_Link
        '
        Me.Login_Link.AutoSize = True
        Me.Login_Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Link.Location = New System.Drawing.Point(102, 219)
        Me.Login_Link.Name = "Login_Link"
        Me.Login_Link.Size = New System.Drawing.Size(113, 17)
        Me.Login_Link.TabIndex = 5
        Me.Login_Link.TabStop = True
        Me.Login_Link.Text = "Go to login page"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(173, 168)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'signupbtn
        '
        Me.signupbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupbtn.Location = New System.Drawing.Point(56, 168)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(89, 23)
        Me.signupbtn.TabIndex = 3
        Me.signupbtn.Text = "Sign Up"
        Me.signupbtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 17)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "User ID"
        '
        'spwd
        '
        Me.spwd.Location = New System.Drawing.Point(180, 62)
        Me.spwd.Name = "spwd"
        Me.spwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.spwd.Size = New System.Drawing.Size(116, 20)
        Me.spwd.TabIndex = 1
        '
        'srpwd
        '
        Me.srpwd.Location = New System.Drawing.Point(182, 104)
        Me.srpwd.Name = "srpwd"
        Me.srpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.srpwd.Size = New System.Drawing.Size(114, 20)
        Me.srpwd.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 17)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Re-type Password"
        '
        'suid
        '
        Me.suid.Location = New System.Drawing.Point(179, 20)
        Me.suid.Name = "suid"
        Me.suid.Size = New System.Drawing.Size(116, 20)
        Me.suid.TabIndex = 0
        '
        'PBAS_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 377)
        Me.Controls.Add(Me.log_sup)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "PBAS_Login"
        Me.Text = "PBAS LOGIN"
        Me.log_sup.ResumeLayout(False)
        Me.Login_Tab.ResumeLayout(False)
        Me.Login_Tab.PerformLayout()
        Me.Signup_Tab.ResumeLayout(False)
        Me.Signup_Tab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents log_sup As System.Windows.Forms.TabControl
    Friend WithEvents Login_Tab As System.Windows.Forms.TabPage
    Friend WithEvents Signup_Link As System.Windows.Forms.LinkLabel
    Friend WithEvents Cancelbtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lpwd As System.Windows.Forms.TextBox
    Friend WithEvents luid As System.Windows.Forms.TextBox
    Friend WithEvents Loginbtn As System.Windows.Forms.Button
    Friend WithEvents Signup_Tab As System.Windows.Forms.TabPage
    Friend WithEvents Login_Link As System.Windows.Forms.LinkLabel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents signupbtn As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents spwd As System.Windows.Forms.TextBox
    Friend WithEvents srpwd As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents suid As System.Windows.Forms.TextBox
End Class
