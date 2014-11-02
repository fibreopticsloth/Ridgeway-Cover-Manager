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
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_sidebar = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tt_back = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_type = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_sidebar.SuspendLayout()
        CType(Me.btn_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_confirmpassword
        '
        Me.txt_confirmpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmpassword.Location = New System.Drawing.Point(46, 289)
        Me.txt_confirmpassword.Name = "txt_confirmpassword"
        Me.txt_confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmpassword.Size = New System.Drawing.Size(157, 22)
        Me.txt_confirmpassword.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(46, 233)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(157, 22)
        Me.txt_password.TabIndex = 0
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(45, 140)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(155, 51)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Your username has been" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automatically detected as:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "username"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(43, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(43, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password:"
        '
        'btn_signup
        '
        Me.btn_signup.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_signup.FlatAppearance.BorderSize = 0
        Me.btn_signup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_signup.ForeColor = System.Drawing.Color.Black
        Me.btn_signup.Location = New System.Drawing.Point(43, 384)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(157, 30)
        Me.btn_signup.TabIndex = 3
        Me.btn_signup.Text = "Sign Up"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 42)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Sign Up for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ridgeway Cover Scheduler"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_sidebar
        '
        Me.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.panel_sidebar.Controls.Add(Me.btn_back)
        Me.panel_sidebar.Controls.Add(Me.PictureBox2)
        Me.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_sidebar.Location = New System.Drawing.Point(0, 0)
        Me.panel_sidebar.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_sidebar.Name = "panel_sidebar"
        Me.panel_sidebar.Padding = New System.Windows.Forms.Padding(7)
        Me.panel_sidebar.Size = New System.Drawing.Size(244, 63)
        Me.panel_sidebar.TabIndex = 59
        '
        'btn_back
        '
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_back.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.back_v1
        Me.btn_back.Location = New System.Drawing.Point(7, 7)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(28, 49)
        Me.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_back.TabIndex = 51
        Me.btn_back.TabStop = False
        Me.tt_back.SetToolTip(Me.btn_back, "Go back to the login menu")
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.schoollogo
        Me.PictureBox2.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'tt_back
        '
        Me.tt_back.ToolTipTitle = "Back"
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_type.FormattingEnabled = True
        Me.txt_type.Items.AddRange(New Object() {"Teacher", "Faculty Leader", "Cover Manager"})
        Me.txt_type.Location = New System.Drawing.Point(46, 342)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(157, 24)
        Me.txt_type.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(43, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Account Type:"
        '
        'frm_signup
        '
        Me.AcceptButton = Me.btn_signup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(244, 433)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.panel_sidebar)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_confirmpassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.panel_sidebar.ResumeLayout(False)
        CType(Me.btn_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_signup As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panel_sidebar As System.Windows.Forms.Panel
    Friend WithEvents btn_back As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tt_back As System.Windows.Forms.ToolTip
    Friend WithEvents txt_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
