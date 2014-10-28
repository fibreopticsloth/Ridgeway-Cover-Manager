<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.remember = New System.Windows.Forms.CheckBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.timer_fadeout = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn_signup
        '
        Me.btn_signup.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_signup.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_signup.FlatAppearance.BorderSize = 0
        Me.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_signup.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signup.ForeColor = System.Drawing.Color.White
        Me.btn_signup.Location = New System.Drawing.Point(243, 326)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(157, 30)
        Me.btn_signup.TabIndex = 3
        Me.btn_signup.TabStop = False
        Me.btn_signup.Text = "Sign Up"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_username.Location = New System.Drawing.Point(243, 163)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(157, 22)
        Me.txt_username.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_password.Location = New System.Drawing.Point(243, 219)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(157, 22)
        Me.txt_password.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(240, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(233, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Log In to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ridgeway Cover Manager"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'remember
        '
        Me.remember.AutoSize = True
        Me.remember.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remember.ForeColor = System.Drawing.Color.White
        Me.remember.Location = New System.Drawing.Point(243, 256)
        Me.remember.Name = "remember"
        Me.remember.Size = New System.Drawing.Size(110, 21)
        Me.remember.TabIndex = 4
        Me.remember.Text = "Remember me"
        Me.remember.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(243, 290)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(157, 30)
        Me.btn_login.TabIndex = 7
        Me.btn_login.TabStop = False
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'timer_fadeout
        '
        Me.timer_fadeout.Interval = 40
        '
        'frm_login
        '
        Me.AcceptButton = Me.btn_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(642, 451)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.remember)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_signup As System.Windows.Forms.Button
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents remember As System.Windows.Forms.CheckBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents timer_fadeout As System.Windows.Forms.Timer

End Class
