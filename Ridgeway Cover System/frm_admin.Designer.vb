<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin))
        Me.panel_sidebar = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg_users = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_changepw = New System.Windows.Forms.Button()
        Me.txt_pw1 = New System.Windows.Forms.TextBox()
        Me.txt_pw2 = New System.Windows.Forms.TextBox()
        Me.txt_newtype = New System.Windows.Forms.ComboBox()
        Me.txt_newusername = New System.Windows.Forms.TextBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_deleteuser = New System.Windows.Forms.Button()
        Me.dg_admins = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_password1 = New System.Windows.Forms.TextBox()
        Me.txt_password2 = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.panel_sidebar.SuspendLayout()
        CType(Me.dg_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.dg_admins.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_sidebar
        '
        Me.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.panel_sidebar.Controls.Add(Me.Label3)
        Me.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_sidebar.Location = New System.Drawing.Point(0, 0)
        Me.panel_sidebar.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_sidebar.Name = "panel_sidebar"
        Me.panel_sidebar.Padding = New System.Windows.Forms.Padding(7)
        Me.panel_sidebar.Size = New System.Drawing.Size(511, 50)
        Me.panel_sidebar.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(209, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 21)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Admin Area"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dg_users
        '
        Me.dg_users.AllowUserToAddRows = False
        Me.dg_users.AllowUserToDeleteRows = False
        Me.dg_users.AllowUserToResizeColumns = False
        Me.dg_users.AllowUserToResizeRows = False
        Me.dg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id})
        Me.dg_users.Location = New System.Drawing.Point(0, 3)
        Me.dg_users.Name = "dg_users"
        Me.dg_users.ReadOnly = True
        Me.dg_users.RowHeadersVisible = False
        Me.dg_users.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_users.Size = New System.Drawing.Size(181, 276)
        Me.dg_users.TabIndex = 64
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'btn_changepw
        '
        Me.btn_changepw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_changepw.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_changepw.FlatAppearance.BorderSize = 0
        Me.btn_changepw.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_changepw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_changepw.ForeColor = System.Drawing.Color.White
        Me.btn_changepw.Location = New System.Drawing.Point(6, 87)
        Me.btn_changepw.Name = "btn_changepw"
        Me.btn_changepw.Size = New System.Drawing.Size(138, 23)
        Me.btn_changepw.TabIndex = 6
        Me.btn_changepw.Text = "Change Password"
        Me.btn_changepw.UseVisualStyleBackColor = False
        '
        'txt_pw1
        '
        Me.txt_pw1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pw1.Location = New System.Drawing.Point(6, 19)
        Me.txt_pw1.Name = "txt_pw1"
        Me.txt_pw1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pw1.Size = New System.Drawing.Size(138, 20)
        Me.txt_pw1.TabIndex = 4
        '
        'txt_pw2
        '
        Me.txt_pw2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pw2.Location = New System.Drawing.Point(6, 61)
        Me.txt_pw2.Name = "txt_pw2"
        Me.txt_pw2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pw2.Size = New System.Drawing.Size(138, 20)
        Me.txt_pw2.TabIndex = 5
        '
        'txt_newtype
        '
        Me.txt_newtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newtype.FormattingEnabled = True
        Me.txt_newtype.Items.AddRange(New Object() {"teacher", "faculty", "covermanager", "admin"})
        Me.txt_newtype.Location = New System.Drawing.Point(6, 77)
        Me.txt_newtype.Name = "txt_newtype"
        Me.txt_newtype.Size = New System.Drawing.Size(138, 21)
        Me.txt_newtype.TabIndex = 2
        '
        'txt_newusername
        '
        Me.txt_newusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newusername.Location = New System.Drawing.Point(6, 38)
        Me.txt_newusername.Name = "txt_newusername"
        Me.txt_newusername.Size = New System.Drawing.Size(138, 20)
        Me.txt_newusername.TabIndex = 1
        Me.txt_newusername.Tag = ""
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(6, 19)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(294, 20)
        Me.txt_search.TabIndex = 0
        '
        'btn_update
        '
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(9, 104)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(135, 23)
        Me.btn_update.TabIndex = 3
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_newusername)
        Me.GroupBox1.Controls.Add(Me.txt_newtype)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Location = New System.Drawing.Point(187, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 135)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Username"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_search)
        Me.GroupBox2.Location = New System.Drawing.Point(187, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 49)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_pw1)
        Me.GroupBox3.Controls.Add(Me.txt_pw2)
        Me.GroupBox3.Controls.Add(Me.btn_changepw)
        Me.GroupBox3.Location = New System.Drawing.Point(343, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 118)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "New Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Confirm Password"
        '
        'btn_deleteuser
        '
        Me.btn_deleteuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deleteuser.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_deleteuser.FlatAppearance.BorderSize = 0
        Me.btn_deleteuser.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_deleteuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteuser.ForeColor = System.Drawing.Color.White
        Me.btn_deleteuser.Location = New System.Drawing.Point(187, 226)
        Me.btn_deleteuser.Name = "btn_deleteuser"
        Me.btn_deleteuser.Size = New System.Drawing.Size(306, 37)
        Me.btn_deleteuser.TabIndex = 7
        Me.btn_deleteuser.Text = "Delete User"
        Me.btn_deleteuser.UseVisualStyleBackColor = False
        '
        'dg_admins
        '
        Me.dg_admins.Controls.Add(Me.TabPage3)
        Me.dg_admins.Controls.Add(Me.TabPage1)
        Me.dg_admins.Location = New System.Drawing.Point(0, 53)
        Me.dg_admins.Multiline = True
        Me.dg_admins.Name = "dg_admins"
        Me.dg_admins.SelectedIndex = 0
        Me.dg_admins.Size = New System.Drawing.Size(511, 305)
        Me.dg_admins.TabIndex = 81
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.btn_deleteuser)
        Me.TabPage3.Controls.Add(Me.dg_users)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(503, 279)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Manage Users"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.btn_submit)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(503, 279)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Add User/Admin"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_username)
        Me.GroupBox4.Controls.Add(Me.txt_type)
        Me.GroupBox4.Location = New System.Drawing.Point(95, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 110)
        Me.GroupBox4.TabIndex = 82
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "User Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Username"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(6, 38)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(138, 20)
        Me.txt_username.TabIndex = 0
        Me.txt_username.Tag = ""
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.FormattingEnabled = True
        Me.txt_type.Items.AddRange(New Object() {"teacher", "faculty", "covermanager", "admin"})
        Me.txt_type.Location = New System.Drawing.Point(6, 77)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(138, 21)
        Me.txt_type.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txt_password1)
        Me.GroupBox5.Controls.Add(Me.txt_password2)
        Me.GroupBox5.Location = New System.Drawing.Point(251, 63)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(150, 110)
        Me.GroupBox5.TabIndex = 83
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Confirm Password"
        '
        'txt_password1
        '
        Me.txt_password1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password1.Location = New System.Drawing.Point(6, 19)
        Me.txt_password1.Name = "txt_password1"
        Me.txt_password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password1.Size = New System.Drawing.Size(138, 20)
        Me.txt_password1.TabIndex = 2
        '
        'txt_password2
        '
        Me.txt_password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password2.Location = New System.Drawing.Point(6, 61)
        Me.txt_password2.Name = "txt_password2"
        Me.txt_password2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password2.Size = New System.Drawing.Size(138, 20)
        Me.txt_password2.TabIndex = 3
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_submit.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_submit.FlatAppearance.BorderSize = 0
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_submit.ForeColor = System.Drawing.Color.Black
        Me.btn_submit.Location = New System.Drawing.Point(175, 184)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(150, 30)
        Me.btn_submit.TabIndex = 4
        Me.btn_submit.Text = "Add User"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'frm_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(511, 358)
        Me.Controls.Add(Me.panel_sidebar)
        Me.Controls.Add(Me.dg_admins)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Area"
        Me.panel_sidebar.ResumeLayout(False)
        Me.panel_sidebar.PerformLayout()
        CType(Me.dg_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.dg_admins.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_sidebar As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dg_users As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_changepw As System.Windows.Forms.Button
    Friend WithEvents txt_pw1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pw2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_newtype As System.Windows.Forms.ComboBox
    Friend WithEvents txt_newusername As System.Windows.Forms.TextBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_deleteuser As System.Windows.Forms.Button
    Friend WithEvents dg_admins As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_type As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_password1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_password2 As System.Windows.Forms.TextBox
End Class
