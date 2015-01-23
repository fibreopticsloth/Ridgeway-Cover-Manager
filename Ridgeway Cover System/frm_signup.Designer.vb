<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_signup))
        Me.txt_confirmpassword = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tt_back = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_back = New System.Windows.Forms.PictureBox()
        Me.txt_type = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_signup = New System.Windows.Forms.Panel()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        CType(Me.btn_back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_signup.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_confirmpassword
        '
        Me.txt_confirmpassword.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txt_confirmpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txt_confirmpassword.Location = New System.Drawing.Point(292, 124)
        Me.txt_confirmpassword.Name = "txt_confirmpassword"
        Me.txt_confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmpassword.Size = New System.Drawing.Size(217, 33)
        Me.txt_confirmpassword.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txt_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(36, 124)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(217, 33)
        Me.txt_password.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(288, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Confirm Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password"
        '
        'tt_back
        '
        Me.tt_back.ToolTipTitle = "Back"
        '
        'btn_back
        '
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.back_white
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(20, 20)
        Me.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_back.TabIndex = 51
        Me.btn_back.TabStop = False
        Me.tt_back.SetToolTip(Me.btn_back, "Go back to the login menu")
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txt_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txt_type.FormattingEnabled = True
        Me.txt_type.Items.AddRange(New Object() {"Teacher", "Faculty Leader", "Cover Manager"})
        Me.txt_type.Location = New System.Drawing.Point(292, 51)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(217, 33)
        Me.txt_type.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(288, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Account Type"
        '
        'panel_signup
        '
        Me.panel_signup.BackColor = System.Drawing.Color.White
        Me.panel_signup.Controls.Add(Me.txt_username)
        Me.panel_signup.Controls.Add(Me.Label1)
        Me.panel_signup.Controls.Add(Me.btn_login)
        Me.panel_signup.Controls.Add(Me.Label2)
        Me.panel_signup.Controls.Add(Me.txt_type)
        Me.panel_signup.Controls.Add(Me.txt_password)
        Me.panel_signup.Controls.Add(Me.Label3)
        Me.panel_signup.Controls.Add(Me.Label4)
        Me.panel_signup.Controls.Add(Me.txt_confirmpassword)
        Me.panel_signup.Location = New System.Drawing.Point(46, 160)
        Me.panel_signup.Name = "panel_signup"
        Me.panel_signup.Size = New System.Drawing.Size(551, 233)
        Me.panel_signup.TabIndex = 81
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txt_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.txt_username.Location = New System.Drawing.Point(36, 51)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(217, 33)
        Me.txt_username.TabIndex = 61
        Me.txt_username.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Username"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(431, 177)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(78, 30)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Sign Up"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'pic_logo
        '
        Me.pic_logo.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.schoollogoblue
        Me.pic_logo.Location = New System.Drawing.Point(242, 42)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(158, 79)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 80
        Me.pic_logo.TabStop = False
        '
        'frm_signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(642, 451)
        Me.Controls.Add(Me.panel_signup)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        CType(Me.btn_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_signup.ResumeLayout(False)
        Me.panel_signup.PerformLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.PictureBox
    Friend WithEvents tt_back As System.Windows.Forms.ToolTip
    Friend WithEvents txt_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents panel_signup As System.Windows.Forms.Panel
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
