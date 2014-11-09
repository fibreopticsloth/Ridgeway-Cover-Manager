<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_home))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_roomchange = New System.Windows.Forms.Button()
        Me.btn_facultyarea = New System.Windows.Forms.Button()
        Me.btn_myrequests = New System.Windows.Forms.Button()
        Me.btn_requestcover = New System.Windows.Forms.Button()
        Me.btn_accountdetails = New System.Windows.Forms.Button()
        Me.nfimenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotificationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btn_notifications = New System.Windows.Forms.Button()
        Me.data_timer = New System.Windows.Forms.Timer(Me.components)
        Me.tt_notify = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_sync = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.requestcover_txt_startperiod = New System.Windows.Forms.ComboBox()
        Me.lbl_startperiodcover = New System.Windows.Forms.Label()
        Me.requestcover_chk_thislessononly = New System.Windows.Forms.CheckBox()
        Me.requestcover_btn_submit = New System.Windows.Forms.Button()
        Me.lbl_startdatecover = New System.Windows.Forms.Label()
        Me.requestcover_txt_endperiod = New System.Windows.Forms.ComboBox()
        Me.requestcover_dp_enddate = New System.Windows.Forms.DateTimePicker()
        Me.requestcover_dp_startdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.requestcover_txt_facultyhead = New System.Windows.Forms.ComboBox()
        Me.requestcover_txt_reason = New System.Windows.Forms.TextBox()
        Me.panel_requestcover = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.myrequests_tc_myrequests = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dg_mycovers = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dg_myroomchanges = New System.Windows.Forms.DataGridView()
        Me.panel_myrequests = New System.Windows.Forms.Panel()
        Me.myrequests_btn_cancel = New System.Windows.Forms.Button()
        Me.dg_viewrequests = New System.Windows.Forms.DataGridView()
        Me.facultyarea_txt_startperiod = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chk_thislessononly = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.facultyarea_dp_startdate = New System.Windows.Forms.DateTimePicker()
        Me.facultyarea_txt_endperiod = New System.Windows.Forms.ComboBox()
        Me.facultyarea_dp_enddate = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.facultyarea_txt_reason = New System.Windows.Forms.TextBox()
        Me.facultyarea_btn_approve = New System.Windows.Forms.Button()
        Me.facultyarea_btn_reject = New System.Windows.Forms.Button()
        Me.panel_facultyarea = New System.Windows.Forms.Panel()
        Me.roomchange_txt_startperiod = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.roomchange_chk_thislessononly = New System.Windows.Forms.CheckBox()
        Me.roomchange_btn_submit = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.roomchange_txt_endperiod = New System.Windows.Forms.ComboBox()
        Me.roomchange_dp_enddate = New System.Windows.Forms.DateTimePicker()
        Me.roomchange_dp_startdate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.roomchange_txt_reason = New System.Windows.Forms.TextBox()
        Me.roomchange_txt_room = New System.Windows.Forms.TextBox()
        Me.panel_roomchange = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panel_notifications_clearnotifications = New System.Windows.Forms.Button()
        Me.lbl_notify = New System.Windows.Forms.TextBox()
        Me.panel_notifications = New System.Windows.Forms.Panel()
        Me.lbl_currentuser = New System.Windows.Forms.Label()
        Me.txt_logout = New System.Windows.Forms.LinkLabel()
        Me.panel_start = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lbl_main = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoverManagementAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SubmitBugReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_pendingbooking = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstrip_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panel_accountdetails = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btn_submittype = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.ComboBox()
        Me.btn_submitpassword = New System.Windows.Forms.Button()
        Me.txt_newpassword2 = New System.Windows.Forms.TextBox()
        Me.txt_newpassword1 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_oldpassword = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.nfimenu.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_sync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_requestcover.SuspendLayout()
        Me.myrequests_tc_myrequests.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg_mycovers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dg_myroomchanges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_myrequests.SuspendLayout()
        CType(Me.dg_viewrequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_facultyarea.SuspendLayout()
        Me.panel_roomchange.SuspendLayout()
        Me.panel_notifications.SuspendLayout()
        Me.panel_start.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.panel_accountdetails.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_roomchange
        '
        Me.btn_roomchange.BackColor = System.Drawing.Color.White
        Me.btn_roomchange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_roomchange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btn_roomchange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_roomchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_roomchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_roomchange.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_roomchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_roomchange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_roomchange.Location = New System.Drawing.Point(1, 93)
        Me.btn_roomchange.Name = "btn_roomchange"
        Me.btn_roomchange.Size = New System.Drawing.Size(133, 35)
        Me.btn_roomchange.TabIndex = 4
        Me.btn_roomchange.TabStop = False
        Me.btn_roomchange.Text = "Room Change"
        Me.btn_roomchange.UseVisualStyleBackColor = False
        '
        'btn_facultyarea
        '
        Me.btn_facultyarea.BackColor = System.Drawing.Color.White
        Me.btn_facultyarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_facultyarea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btn_facultyarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_facultyarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_facultyarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facultyarea.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facultyarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_facultyarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facultyarea.Location = New System.Drawing.Point(1, 187)
        Me.btn_facultyarea.Name = "btn_facultyarea"
        Me.btn_facultyarea.Size = New System.Drawing.Size(133, 35)
        Me.btn_facultyarea.TabIndex = 10
        Me.btn_facultyarea.TabStop = False
        Me.btn_facultyarea.Text = "Faculty Area"
        Me.btn_facultyarea.UseVisualStyleBackColor = False
        '
        'btn_myrequests
        '
        Me.btn_myrequests.BackColor = System.Drawing.Color.White
        Me.btn_myrequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_myrequests.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btn_myrequests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_myrequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_myrequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_myrequests.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_myrequests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_myrequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_myrequests.Location = New System.Drawing.Point(1, 153)
        Me.btn_myrequests.Name = "btn_myrequests"
        Me.btn_myrequests.Size = New System.Drawing.Size(133, 35)
        Me.btn_myrequests.TabIndex = 9
        Me.btn_myrequests.TabStop = False
        Me.btn_myrequests.Text = "My Requests"
        Me.btn_myrequests.UseVisualStyleBackColor = False
        '
        'btn_requestcover
        '
        Me.btn_requestcover.BackColor = System.Drawing.Color.White
        Me.btn_requestcover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_requestcover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btn_requestcover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_requestcover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_requestcover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_requestcover.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_requestcover.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_requestcover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_requestcover.Location = New System.Drawing.Point(1, 59)
        Me.btn_requestcover.Name = "btn_requestcover"
        Me.btn_requestcover.Size = New System.Drawing.Size(133, 35)
        Me.btn_requestcover.TabIndex = 12
        Me.btn_requestcover.TabStop = False
        Me.btn_requestcover.Text = "Cover Request"
        Me.btn_requestcover.UseVisualStyleBackColor = False
        '
        'btn_accountdetails
        '
        Me.btn_accountdetails.BackColor = System.Drawing.Color.White
        Me.btn_accountdetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_accountdetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btn_accountdetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_accountdetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_accountdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_accountdetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_accountdetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_accountdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_accountdetails.Location = New System.Drawing.Point(1, 281)
        Me.btn_accountdetails.Name = "btn_accountdetails"
        Me.btn_accountdetails.Size = New System.Drawing.Size(133, 35)
        Me.btn_accountdetails.TabIndex = 14
        Me.btn_accountdetails.TabStop = False
        Me.btn_accountdetails.Text = "Account Details"
        Me.btn_accountdetails.UseVisualStyleBackColor = False
        '
        'nfimenu
        '
        Me.nfimenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotificationsToolStripMenuItem, Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.nfimenu.Name = "nfimenu"
        Me.nfimenu.Size = New System.Drawing.Size(158, 70)
        '
        'NotificationsToolStripMenuItem
        '
        Me.NotificationsToolStripMenuItem.Name = "NotificationsToolStripMenuItem"
        Me.NotificationsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NotificationsToolStripMenuItem.Text = "0 notification(s)"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'nfi
        '
        Me.nfi.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.nfi.BalloonTipTitle = "Ridgeway Cover Manager"
        Me.nfi.ContextMenuStrip = Me.nfimenu
        Me.nfi.Icon = CType(resources.GetObject("nfi.Icon"), System.Drawing.Icon)
        Me.nfi.Text = "Ridgeway Cover Manager"
        '
        'btn_notifications
        '
        Me.btn_notifications.BackColor = System.Drawing.Color.White
        Me.btn_notifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_notifications.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btn_notifications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_notifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_notifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_notifications.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_notifications.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_notifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_notifications.Location = New System.Drawing.Point(1, 221)
        Me.btn_notifications.Name = "btn_notifications"
        Me.btn_notifications.Size = New System.Drawing.Size(133, 35)
        Me.btn_notifications.TabIndex = 65
        Me.btn_notifications.TabStop = False
        Me.btn_notifications.Text = "Notifications"
        Me.btn_notifications.UseVisualStyleBackColor = False
        '
        'data_timer
        '
        Me.data_timer.Interval = 60000
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.home
        Me.PictureBox4.Location = New System.Drawing.Point(57, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 21)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 77
        Me.PictureBox4.TabStop = False
        Me.tt_notify.SetToolTip(Me.PictureBox4, "Home")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.logout
        Me.PictureBox3.Location = New System.Drawing.Point(1, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 76
        Me.PictureBox3.TabStop = False
        Me.tt_notify.SetToolTip(Me.PictureBox3, "Logout")
        '
        'btn_sync
        '
        Me.btn_sync.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_sync.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sync.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.sync
        Me.btn_sync.Location = New System.Drawing.Point(29, 6)
        Me.btn_sync.Name = "btn_sync"
        Me.btn_sync.Size = New System.Drawing.Size(29, 21)
        Me.btn_sync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_sync.TabIndex = 62
        Me.btn_sync.TabStop = False
        Me.tt_notify.SetToolTip(Me.btn_sync, "Synchronize")
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(1, 34)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 25)
        Me.Button5.TabIndex = 67
        Me.Button5.TabStop = False
        Me.Button5.Text = "NEW"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(1, 128)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(133, 25)
        Me.Button6.TabIndex = 68
        Me.Button6.TabStop = False
        Me.Button6.Text = "MANAGE REQUESTS"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(1, 256)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(133, 25)
        Me.Button7.TabIndex = 69
        Me.Button7.TabStop = False
        Me.Button7.Text = "OPTIONS"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'requestcover_txt_startperiod
        '
        Me.requestcover_txt_startperiod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_txt_startperiod.FormattingEnabled = True
        Me.requestcover_txt_startperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.requestcover_txt_startperiod.Location = New System.Drawing.Point(195, 99)
        Me.requestcover_txt_startperiod.Name = "requestcover_txt_startperiod"
        Me.requestcover_txt_startperiod.Size = New System.Drawing.Size(78, 23)
        Me.requestcover_txt_startperiod.TabIndex = 6
        '
        'lbl_startperiodcover
        '
        Me.lbl_startperiodcover.AutoSize = True
        Me.lbl_startperiodcover.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_startperiodcover.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lbl_startperiodcover.Location = New System.Drawing.Point(145, 104)
        Me.lbl_startperiodcover.Name = "lbl_startperiodcover"
        Me.lbl_startperiodcover.Size = New System.Drawing.Size(44, 15)
        Me.lbl_startperiodcover.TabIndex = 11
        Me.lbl_startperiodcover.Text = "Period:"
        Me.lbl_startperiodcover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'requestcover_chk_thislessononly
        '
        Me.requestcover_chk_thislessononly.AutoSize = True
        Me.requestcover_chk_thislessononly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.requestcover_chk_thislessononly.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_chk_thislessononly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.requestcover_chk_thislessononly.Location = New System.Drawing.Point(108, 45)
        Me.requestcover_chk_thislessononly.Name = "requestcover_chk_thislessononly"
        Me.requestcover_chk_thislessononly.Size = New System.Drawing.Size(100, 19)
        Me.requestcover_chk_thislessononly.TabIndex = 30
        Me.requestcover_chk_thislessononly.Text = "Single Lesson:"
        Me.requestcover_chk_thislessononly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.requestcover_chk_thislessononly.UseVisualStyleBackColor = True
        '
        'requestcover_btn_submit
        '
        Me.requestcover_btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.requestcover_btn_submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.requestcover_btn_submit.FlatAppearance.BorderSize = 0
        Me.requestcover_btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.requestcover_btn_submit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_btn_submit.ForeColor = System.Drawing.Color.White
        Me.requestcover_btn_submit.Location = New System.Drawing.Point(195, 340)
        Me.requestcover_btn_submit.Name = "requestcover_btn_submit"
        Me.requestcover_btn_submit.Size = New System.Drawing.Size(159, 25)
        Me.requestcover_btn_submit.TabIndex = 54
        Me.requestcover_btn_submit.Text = "Submit"
        Me.requestcover_btn_submit.UseVisualStyleBackColor = False
        '
        'lbl_startdatecover
        '
        Me.lbl_startdatecover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_startdatecover.AutoSize = True
        Me.lbl_startdatecover.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_startdatecover.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lbl_startdatecover.Location = New System.Drawing.Point(128, 76)
        Me.lbl_startdatecover.Name = "lbl_startdatecover"
        Me.lbl_startdatecover.Size = New System.Drawing.Size(61, 15)
        Me.lbl_startdatecover.TabIndex = 9
        Me.lbl_startdatecover.Text = "Start Date:"
        Me.lbl_startdatecover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'requestcover_txt_endperiod
        '
        Me.requestcover_txt_endperiod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_txt_endperiod.FormattingEnabled = True
        Me.requestcover_txt_endperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.requestcover_txt_endperiod.Location = New System.Drawing.Point(195, 157)
        Me.requestcover_txt_endperiod.Name = "requestcover_txt_endperiod"
        Me.requestcover_txt_endperiod.Size = New System.Drawing.Size(78, 23)
        Me.requestcover_txt_endperiod.TabIndex = 15
        '
        'requestcover_dp_enddate
        '
        Me.requestcover_dp_enddate.CustomFormat = "dd'-'MM'-'yy"
        Me.requestcover_dp_enddate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_dp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.requestcover_dp_enddate.Location = New System.Drawing.Point(195, 128)
        Me.requestcover_dp_enddate.Name = "requestcover_dp_enddate"
        Me.requestcover_dp_enddate.Size = New System.Drawing.Size(78, 23)
        Me.requestcover_dp_enddate.TabIndex = 13
        Me.requestcover_dp_enddate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'requestcover_dp_startdate
        '
        Me.requestcover_dp_startdate.CustomFormat = "dd'-'MM'-'yy"
        Me.requestcover_dp_startdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_dp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.requestcover_dp_startdate.Location = New System.Drawing.Point(195, 70)
        Me.requestcover_dp_startdate.Name = "requestcover_dp_startdate"
        Me.requestcover_dp_startdate.Size = New System.Drawing.Size(78, 23)
        Me.requestcover_dp_startdate.TabIndex = 5
        Me.requestcover_dp_startdate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(145, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Period:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(132, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "End Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(103, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 15)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Faculty Leader:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(141, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Reason:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'requestcover_txt_facultyhead
        '
        Me.requestcover_txt_facultyhead.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_txt_facultyhead.FormattingEnabled = True
        Me.requestcover_txt_facultyhead.Location = New System.Drawing.Point(195, 186)
        Me.requestcover_txt_facultyhead.Name = "requestcover_txt_facultyhead"
        Me.requestcover_txt_facultyhead.Size = New System.Drawing.Size(159, 23)
        Me.requestcover_txt_facultyhead.TabIndex = 26
        '
        'requestcover_txt_reason
        '
        Me.requestcover_txt_reason.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_txt_reason.Location = New System.Drawing.Point(195, 218)
        Me.requestcover_txt_reason.Margin = New System.Windows.Forms.Padding(6)
        Me.requestcover_txt_reason.Multiline = True
        Me.requestcover_txt_reason.Name = "requestcover_txt_reason"
        Me.requestcover_txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.requestcover_txt_reason.Size = New System.Drawing.Size(159, 106)
        Me.requestcover_txt_reason.TabIndex = 6
        '
        'panel_requestcover
        '
        Me.panel_requestcover.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_requestcover.Controls.Add(Me.Label6)
        Me.panel_requestcover.Controls.Add(Me.requestcover_txt_reason)
        Me.panel_requestcover.Controls.Add(Me.requestcover_txt_facultyhead)
        Me.panel_requestcover.Controls.Add(Me.Label11)
        Me.panel_requestcover.Controls.Add(Me.Label10)
        Me.panel_requestcover.Controls.Add(Me.Label4)
        Me.panel_requestcover.Controls.Add(Me.Label7)
        Me.panel_requestcover.Controls.Add(Me.requestcover_dp_startdate)
        Me.panel_requestcover.Controls.Add(Me.requestcover_dp_enddate)
        Me.panel_requestcover.Controls.Add(Me.requestcover_txt_endperiod)
        Me.panel_requestcover.Controls.Add(Me.lbl_startdatecover)
        Me.panel_requestcover.Controls.Add(Me.requestcover_btn_submit)
        Me.panel_requestcover.Controls.Add(Me.requestcover_chk_thislessononly)
        Me.panel_requestcover.Controls.Add(Me.lbl_startperiodcover)
        Me.panel_requestcover.Controls.Add(Me.requestcover_txt_startperiod)
        Me.panel_requestcover.Location = New System.Drawing.Point(138, 38)
        Me.panel_requestcover.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_requestcover.Name = "panel_requestcover"
        Me.panel_requestcover.Size = New System.Drawing.Size(500, 383)
        Me.panel_requestcover.TabIndex = 11
        Me.panel_requestcover.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(192, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 17)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "New Cover Request"
        '
        'myrequests_tc_myrequests
        '
        Me.myrequests_tc_myrequests.Controls.Add(Me.TabPage1)
        Me.myrequests_tc_myrequests.Controls.Add(Me.TabPage2)
        Me.myrequests_tc_myrequests.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myrequests_tc_myrequests.HotTrack = True
        Me.myrequests_tc_myrequests.Location = New System.Drawing.Point(6, 6)
        Me.myrequests_tc_myrequests.Multiline = True
        Me.myrequests_tc_myrequests.Name = "myrequests_tc_myrequests"
        Me.myrequests_tc_myrequests.SelectedIndex = 0
        Me.myrequests_tc_myrequests.Size = New System.Drawing.Size(486, 330)
        Me.myrequests_tc_myrequests.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dg_mycovers)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(478, 304)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cover Requests"
        '
        'dg_mycovers
        '
        Me.dg_mycovers.AllowUserToAddRows = False
        Me.dg_mycovers.AllowUserToDeleteRows = False
        Me.dg_mycovers.AllowUserToResizeColumns = False
        Me.dg_mycovers.AllowUserToResizeRows = False
        Me.dg_mycovers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_mycovers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_mycovers.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_mycovers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_mycovers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mycovers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_mycovers.Location = New System.Drawing.Point(3, 3)
        Me.dg_mycovers.Name = "dg_mycovers"
        Me.dg_mycovers.ReadOnly = True
        Me.dg_mycovers.RowHeadersVisible = False
        Me.dg_mycovers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_mycovers.Size = New System.Drawing.Size(472, 298)
        Me.dg_mycovers.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.dg_myroomchanges)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(478, 304)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Room Change Requests"
        '
        'dg_myroomchanges
        '
        Me.dg_myroomchanges.AllowUserToAddRows = False
        Me.dg_myroomchanges.AllowUserToDeleteRows = False
        Me.dg_myroomchanges.AllowUserToResizeColumns = False
        Me.dg_myroomchanges.AllowUserToResizeRows = False
        Me.dg_myroomchanges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_myroomchanges.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_myroomchanges.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_myroomchanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_myroomchanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_myroomchanges.Location = New System.Drawing.Point(3, 3)
        Me.dg_myroomchanges.Name = "dg_myroomchanges"
        Me.dg_myroomchanges.ReadOnly = True
        Me.dg_myroomchanges.RowHeadersVisible = False
        Me.dg_myroomchanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_myroomchanges.Size = New System.Drawing.Size(472, 298)
        Me.dg_myroomchanges.TabIndex = 1
        '
        'panel_myrequests
        '
        Me.panel_myrequests.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_myrequests.Controls.Add(Me.myrequests_btn_cancel)
        Me.panel_myrequests.Controls.Add(Me.myrequests_tc_myrequests)
        Me.panel_myrequests.Location = New System.Drawing.Point(138, 38)
        Me.panel_myrequests.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_myrequests.Name = "panel_myrequests"
        Me.panel_myrequests.Size = New System.Drawing.Size(500, 383)
        Me.panel_myrequests.TabIndex = 60
        Me.panel_myrequests.Visible = False
        '
        'myrequests_btn_cancel
        '
        Me.myrequests_btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.myrequests_btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.myrequests_btn_cancel.FlatAppearance.BorderSize = 0
        Me.myrequests_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.myrequests_btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myrequests_btn_cancel.ForeColor = System.Drawing.Color.White
        Me.myrequests_btn_cancel.Location = New System.Drawing.Point(171, 346)
        Me.myrequests_btn_cancel.Name = "myrequests_btn_cancel"
        Me.myrequests_btn_cancel.Size = New System.Drawing.Size(159, 25)
        Me.myrequests_btn_cancel.TabIndex = 65
        Me.myrequests_btn_cancel.Text = "Cancel selected request(s)"
        Me.myrequests_btn_cancel.UseVisualStyleBackColor = False
        '
        'dg_viewrequests
        '
        Me.dg_viewrequests.AllowUserToAddRows = False
        Me.dg_viewrequests.AllowUserToDeleteRows = False
        Me.dg_viewrequests.AllowUserToResizeColumns = False
        Me.dg_viewrequests.AllowUserToResizeRows = False
        Me.dg_viewrequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_viewrequests.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_viewrequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_viewrequests.Location = New System.Drawing.Point(18, 17)
        Me.dg_viewrequests.MultiSelect = False
        Me.dg_viewrequests.Name = "dg_viewrequests"
        Me.dg_viewrequests.ReadOnly = True
        Me.dg_viewrequests.RowHeadersVisible = False
        Me.dg_viewrequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_viewrequests.Size = New System.Drawing.Size(180, 349)
        Me.dg_viewrequests.TabIndex = 41
        '
        'facultyarea_txt_startperiod
        '
        Me.facultyarea_txt_startperiod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.facultyarea_txt_startperiod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_txt_startperiod.FormattingEnabled = True
        Me.facultyarea_txt_startperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.facultyarea_txt_startperiod.Location = New System.Drawing.Point(303, 63)
        Me.facultyarea_txt_startperiod.Name = "facultyarea_txt_startperiod"
        Me.facultyarea_txt_startperiod.Size = New System.Drawing.Size(34, 23)
        Me.facultyarea_txt_startperiod.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(250, 67)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 15)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Period:"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(236, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 15)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Start Date:"
        '
        'chk_thislessononly
        '
        Me.chk_thislessononly.AutoSize = True
        Me.chk_thislessononly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_thislessononly.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_thislessononly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.chk_thislessononly.Location = New System.Drawing.Point(217, 92)
        Me.chk_thislessononly.Name = "chk_thislessononly"
        Me.chk_thislessononly.Size = New System.Drawing.Size(100, 19)
        Me.chk_thislessononly.TabIndex = 30
        Me.chk_thislessononly.Text = "Single Lesson:"
        Me.chk_thislessononly.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(253, 151)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 15)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Period:"
        '
        'facultyarea_dp_startdate
        '
        Me.facultyarea_dp_startdate.CustomFormat = "dd'-'MM'-'yy"
        Me.facultyarea_dp_startdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_dp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.facultyarea_dp_startdate.Location = New System.Drawing.Point(303, 34)
        Me.facultyarea_dp_startdate.Name = "facultyarea_dp_startdate"
        Me.facultyarea_dp_startdate.Size = New System.Drawing.Size(81, 23)
        Me.facultyarea_dp_startdate.TabIndex = 5
        Me.facultyarea_dp_startdate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'facultyarea_txt_endperiod
        '
        Me.facultyarea_txt_endperiod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.facultyarea_txt_endperiod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_txt_endperiod.FormattingEnabled = True
        Me.facultyarea_txt_endperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.facultyarea_txt_endperiod.Location = New System.Drawing.Point(303, 146)
        Me.facultyarea_txt_endperiod.Name = "facultyarea_txt_endperiod"
        Me.facultyarea_txt_endperiod.Size = New System.Drawing.Size(31, 23)
        Me.facultyarea_txt_endperiod.TabIndex = 15
        '
        'facultyarea_dp_enddate
        '
        Me.facultyarea_dp_enddate.CustomFormat = "dd'-'MM'-'yy"
        Me.facultyarea_dp_enddate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_dp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.facultyarea_dp_enddate.Location = New System.Drawing.Point(303, 117)
        Me.facultyarea_dp_enddate.Name = "facultyarea_dp_enddate"
        Me.facultyarea_dp_enddate.Size = New System.Drawing.Size(81, 23)
        Me.facultyarea_dp_enddate.TabIndex = 13
        Me.facultyarea_dp_enddate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(240, 123)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 15)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "End Date:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(249, 176)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 15)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Reason:"
        '
        'facultyarea_txt_reason
        '
        Me.facultyarea_txt_reason.BackColor = System.Drawing.Color.White
        Me.facultyarea_txt_reason.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_txt_reason.Location = New System.Drawing.Point(303, 176)
        Me.facultyarea_txt_reason.Margin = New System.Windows.Forms.Padding(6)
        Me.facultyarea_txt_reason.Multiline = True
        Me.facultyarea_txt_reason.Name = "facultyarea_txt_reason"
        Me.facultyarea_txt_reason.ReadOnly = True
        Me.facultyarea_txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.facultyarea_txt_reason.Size = New System.Drawing.Size(159, 106)
        Me.facultyarea_txt_reason.TabIndex = 6
        '
        'facultyarea_btn_approve
        '
        Me.facultyarea_btn_approve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.facultyarea_btn_approve.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.facultyarea_btn_approve.FlatAppearance.BorderSize = 0
        Me.facultyarea_btn_approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyarea_btn_approve.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_btn_approve.ForeColor = System.Drawing.Color.White
        Me.facultyarea_btn_approve.Location = New System.Drawing.Point(303, 294)
        Me.facultyarea_btn_approve.Name = "facultyarea_btn_approve"
        Me.facultyarea_btn_approve.Size = New System.Drawing.Size(159, 25)
        Me.facultyarea_btn_approve.TabIndex = 59
        Me.facultyarea_btn_approve.Text = "Approve"
        Me.facultyarea_btn_approve.UseVisualStyleBackColor = False
        '
        'facultyarea_btn_reject
        '
        Me.facultyarea_btn_reject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.facultyarea_btn_reject.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.facultyarea_btn_reject.FlatAppearance.BorderSize = 0
        Me.facultyarea_btn_reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyarea_btn_reject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_btn_reject.ForeColor = System.Drawing.Color.White
        Me.facultyarea_btn_reject.Location = New System.Drawing.Point(303, 325)
        Me.facultyarea_btn_reject.Name = "facultyarea_btn_reject"
        Me.facultyarea_btn_reject.Size = New System.Drawing.Size(159, 25)
        Me.facultyarea_btn_reject.TabIndex = 60
        Me.facultyarea_btn_reject.Text = "Reject"
        Me.facultyarea_btn_reject.UseVisualStyleBackColor = False
        '
        'panel_facultyarea
        '
        Me.panel_facultyarea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_btn_reject)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_btn_approve)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_txt_reason)
        Me.panel_facultyarea.Controls.Add(Me.Label27)
        Me.panel_facultyarea.Controls.Add(Me.Label21)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_dp_enddate)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_txt_endperiod)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_dp_startdate)
        Me.panel_facultyarea.Controls.Add(Me.Label22)
        Me.panel_facultyarea.Controls.Add(Me.chk_thislessononly)
        Me.panel_facultyarea.Controls.Add(Me.Label23)
        Me.panel_facultyarea.Controls.Add(Me.Label24)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_txt_startperiod)
        Me.panel_facultyarea.Controls.Add(Me.dg_viewrequests)
        Me.panel_facultyarea.Location = New System.Drawing.Point(138, 38)
        Me.panel_facultyarea.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_facultyarea.Name = "panel_facultyarea"
        Me.panel_facultyarea.Size = New System.Drawing.Size(500, 383)
        Me.panel_facultyarea.TabIndex = 60
        '
        'roomchange_txt_startperiod
        '
        Me.roomchange_txt_startperiod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_txt_startperiod.FormattingEnabled = True
        Me.roomchange_txt_startperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.roomchange_txt_startperiod.Location = New System.Drawing.Point(195, 99)
        Me.roomchange_txt_startperiod.Name = "roomchange_txt_startperiod"
        Me.roomchange_txt_startperiod.Size = New System.Drawing.Size(78, 23)
        Me.roomchange_txt_startperiod.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(145, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 15)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Period:"
        '
        'roomchange_chk_thislessononly
        '
        Me.roomchange_chk_thislessononly.AutoSize = True
        Me.roomchange_chk_thislessononly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.roomchange_chk_thislessononly.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_chk_thislessononly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.roomchange_chk_thislessononly.Location = New System.Drawing.Point(108, 45)
        Me.roomchange_chk_thislessononly.Name = "roomchange_chk_thislessononly"
        Me.roomchange_chk_thislessononly.Size = New System.Drawing.Size(100, 19)
        Me.roomchange_chk_thislessononly.TabIndex = 30
        Me.roomchange_chk_thislessononly.Text = "Single Lesson:"
        Me.roomchange_chk_thislessononly.UseVisualStyleBackColor = True
        '
        'roomchange_btn_submit
        '
        Me.roomchange_btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.roomchange_btn_submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.roomchange_btn_submit.FlatAppearance.BorderSize = 0
        Me.roomchange_btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roomchange_btn_submit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_btn_submit.ForeColor = System.Drawing.Color.White
        Me.roomchange_btn_submit.Location = New System.Drawing.Point(195, 340)
        Me.roomchange_btn_submit.Name = "roomchange_btn_submit"
        Me.roomchange_btn_submit.Size = New System.Drawing.Size(159, 25)
        Me.roomchange_btn_submit.TabIndex = 54
        Me.roomchange_btn_submit.Text = "Submit"
        Me.roomchange_btn_submit.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(128, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 15)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Start Date:"
        '
        'roomchange_txt_endperiod
        '
        Me.roomchange_txt_endperiod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_txt_endperiod.FormattingEnabled = True
        Me.roomchange_txt_endperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.roomchange_txt_endperiod.Location = New System.Drawing.Point(195, 157)
        Me.roomchange_txt_endperiod.Name = "roomchange_txt_endperiod"
        Me.roomchange_txt_endperiod.Size = New System.Drawing.Size(78, 23)
        Me.roomchange_txt_endperiod.TabIndex = 15
        '
        'roomchange_dp_enddate
        '
        Me.roomchange_dp_enddate.CustomFormat = "dd'-'MM'-'yy"
        Me.roomchange_dp_enddate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_dp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.roomchange_dp_enddate.Location = New System.Drawing.Point(195, 128)
        Me.roomchange_dp_enddate.Name = "roomchange_dp_enddate"
        Me.roomchange_dp_enddate.Size = New System.Drawing.Size(78, 23)
        Me.roomchange_dp_enddate.TabIndex = 13
        Me.roomchange_dp_enddate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'roomchange_dp_startdate
        '
        Me.roomchange_dp_startdate.CustomFormat = "dd'-'MM'-'yy"
        Me.roomchange_dp_startdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_dp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.roomchange_dp_startdate.Location = New System.Drawing.Point(195, 70)
        Me.roomchange_dp_startdate.Name = "roomchange_dp_startdate"
        Me.roomchange_dp_startdate.Size = New System.Drawing.Size(78, 23)
        Me.roomchange_dp_startdate.TabIndex = 5
        Me.roomchange_dp_startdate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(145, 164)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 15)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Period:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(132, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 15)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "End Date:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(148, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Room:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(141, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Reason:"
        '
        'roomchange_txt_reason
        '
        Me.roomchange_txt_reason.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_txt_reason.Location = New System.Drawing.Point(195, 218)
        Me.roomchange_txt_reason.Margin = New System.Windows.Forms.Padding(6)
        Me.roomchange_txt_reason.Multiline = True
        Me.roomchange_txt_reason.Name = "roomchange_txt_reason"
        Me.roomchange_txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.roomchange_txt_reason.Size = New System.Drawing.Size(159, 106)
        Me.roomchange_txt_reason.TabIndex = 6
        '
        'roomchange_txt_room
        '
        Me.roomchange_txt_room.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_txt_room.Location = New System.Drawing.Point(195, 186)
        Me.roomchange_txt_room.Name = "roomchange_txt_room"
        Me.roomchange_txt_room.Size = New System.Drawing.Size(78, 23)
        Me.roomchange_txt_room.TabIndex = 59
        '
        'panel_roomchange
        '
        Me.panel_roomchange.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_roomchange.Controls.Add(Me.Label8)
        Me.panel_roomchange.Controls.Add(Me.roomchange_txt_room)
        Me.panel_roomchange.Controls.Add(Me.roomchange_txt_reason)
        Me.panel_roomchange.Controls.Add(Me.Label12)
        Me.panel_roomchange.Controls.Add(Me.Label13)
        Me.panel_roomchange.Controls.Add(Me.Label15)
        Me.panel_roomchange.Controls.Add(Me.Label17)
        Me.panel_roomchange.Controls.Add(Me.roomchange_dp_startdate)
        Me.panel_roomchange.Controls.Add(Me.roomchange_dp_enddate)
        Me.panel_roomchange.Controls.Add(Me.roomchange_txt_endperiod)
        Me.panel_roomchange.Controls.Add(Me.Label18)
        Me.panel_roomchange.Controls.Add(Me.roomchange_btn_submit)
        Me.panel_roomchange.Controls.Add(Me.roomchange_chk_thislessononly)
        Me.panel_roomchange.Controls.Add(Me.Label19)
        Me.panel_roomchange.Controls.Add(Me.roomchange_txt_startperiod)
        Me.panel_roomchange.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.panel_roomchange.Location = New System.Drawing.Point(138, 38)
        Me.panel_roomchange.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_roomchange.Name = "panel_roomchange"
        Me.panel_roomchange.Size = New System.Drawing.Size(500, 383)
        Me.panel_roomchange.TabIndex = 59
        Me.panel_roomchange.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(192, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 17)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "New Room Change"
        '
        'panel_notifications_clearnotifications
        '
        Me.panel_notifications_clearnotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel_notifications_clearnotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.panel_notifications_clearnotifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel_notifications_clearnotifications.FlatAppearance.BorderSize = 0
        Me.panel_notifications_clearnotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.panel_notifications_clearnotifications.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_notifications_clearnotifications.ForeColor = System.Drawing.Color.White
        Me.panel_notifications_clearnotifications.Location = New System.Drawing.Point(171, 334)
        Me.panel_notifications_clearnotifications.Name = "panel_notifications_clearnotifications"
        Me.panel_notifications_clearnotifications.Size = New System.Drawing.Size(159, 25)
        Me.panel_notifications_clearnotifications.TabIndex = 55
        Me.panel_notifications_clearnotifications.Text = "Clear Notifications"
        Me.panel_notifications_clearnotifications.UseVisualStyleBackColor = False
        '
        'lbl_notify
        '
        Me.lbl_notify.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_notify.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_notify.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lbl_notify.Location = New System.Drawing.Point(13, 14)
        Me.lbl_notify.Multiline = True
        Me.lbl_notify.Name = "lbl_notify"
        Me.lbl_notify.ReadOnly = True
        Me.lbl_notify.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lbl_notify.Size = New System.Drawing.Size(472, 297)
        Me.lbl_notify.TabIndex = 56
        Me.lbl_notify.Text = "No notifications to show!"
        '
        'panel_notifications
        '
        Me.panel_notifications.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_notifications.Controls.Add(Me.lbl_notify)
        Me.panel_notifications.Controls.Add(Me.panel_notifications_clearnotifications)
        Me.panel_notifications.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_notifications.ForeColor = System.Drawing.Color.White
        Me.panel_notifications.Location = New System.Drawing.Point(138, 38)
        Me.panel_notifications.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_notifications.Name = "panel_notifications"
        Me.panel_notifications.Size = New System.Drawing.Size(500, 383)
        Me.panel_notifications.TabIndex = 60
        Me.panel_notifications.Visible = False
        '
        'lbl_currentuser
        '
        Me.lbl_currentuser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lbl_currentuser.Location = New System.Drawing.Point(25, 165)
        Me.lbl_currentuser.Name = "lbl_currentuser"
        Me.lbl_currentuser.Size = New System.Drawing.Size(450, 37)
        Me.lbl_currentuser.TabIndex = 1
        Me.lbl_currentuser.Text = "Not Logged In"
        Me.lbl_currentuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_logout
        '
        Me.txt_logout.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_logout.AutoSize = True
        Me.txt_logout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txt_logout.LinkColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txt_logout.Location = New System.Drawing.Point(220, 196)
        Me.txt_logout.Name = "txt_logout"
        Me.txt_logout.Size = New System.Drawing.Size(61, 17)
        Me.txt_logout.TabIndex = 3
        Me.txt_logout.TabStop = True
        Me.txt_logout.Text = "Not you?"
        Me.txt_logout.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        '
        'panel_start
        '
        Me.panel_start.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_start.Controls.Add(Me.txt_logout)
        Me.panel_start.Controls.Add(Me.lbl_currentuser)
        Me.panel_start.Location = New System.Drawing.Point(138, 38)
        Me.panel_start.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_start.Name = "panel_start"
        Me.panel_start.Size = New System.Drawing.Size(500, 383)
        Me.panel_start.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "© TRS 2014"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(1, 1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(640, 31)
        Me.Button8.TabIndex = 70
        Me.Button8.TabStop = False
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'lbl_main
        '
        Me.lbl_main.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lbl_main.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_main.ForeColor = System.Drawing.Color.White
        Me.lbl_main.Location = New System.Drawing.Point(138, 7)
        Me.lbl_main.Name = "lbl_main"
        Me.lbl_main.Size = New System.Drawing.Size(500, 19)
        Me.lbl_main.TabIndex = 71
        Me.lbl_main.Text = "Ridgeway Cover Manager"
        Me.lbl_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(1, 315)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(133, 114)
        Me.Button9.TabIndex = 72
        Me.Button9.TabStop = False
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 2)
        Me.Panel1.TabIndex = 64
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton1, Me.Help, Me.lbl_pendingbooking, Me.ToolStripStatusLabel1, Me.toolstrip_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(1, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(640, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 73
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(38, 20)
        Me.ToolStripDropDownButton2.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUserToolStripMenuItem, Me.CoverManagementAreaToolStripMenuItem})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(56, 20)
        Me.ToolStripDropDownButton1.Text = "Admin"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ManageUserToolStripMenuItem.Text = "Manage Users"
        '
        'CoverManagementAreaToolStripMenuItem
        '
        Me.CoverManagementAreaToolStripMenuItem.Name = "CoverManagementAreaToolStripMenuItem"
        Me.CoverManagementAreaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CoverManagementAreaToolStripMenuItem.Text = "Cover Management Area"
        '
        'Help
        '
        Me.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmitBugReportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.Help.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Image = CType(resources.GetObject("Help.Image"), System.Drawing.Image)
        Me.Help.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(45, 20)
        Me.Help.Text = "Help"
        '
        'SubmitBugReportToolStripMenuItem
        '
        Me.SubmitBugReportToolStripMenuItem.Name = "SubmitBugReportToolStripMenuItem"
        Me.SubmitBugReportToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SubmitBugReportToolStripMenuItem.Text = "Submit Bug Report"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lbl_pendingbooking
        '
        Me.lbl_pendingbooking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lbl_pendingbooking.Name = "lbl_pendingbooking"
        Me.lbl_pendingbooking.Size = New System.Drawing.Size(149, 17)
        Me.lbl_pendingbooking.Text = " -- 0 request(s) in queue -- "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(272, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'toolstrip_status
        '
        Me.toolstrip_status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstrip_status.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolstrip_status.ForeColor = System.Drawing.Color.Green
        Me.toolstrip_status.Name = "toolstrip_status"
        Me.toolstrip_status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.toolstrip_status.Size = New System.Drawing.Size(65, 17)
        Me.toolstrip_status.Text = "Connected"
        '
        'panel_accountdetails
        '
        Me.panel_accountdetails.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_accountdetails.Controls.Add(Me.Label29)
        Me.panel_accountdetails.Controls.Add(Me.btn_submittype)
        Me.panel_accountdetails.Controls.Add(Me.Label28)
        Me.panel_accountdetails.Controls.Add(Me.txt_type)
        Me.panel_accountdetails.Controls.Add(Me.btn_submitpassword)
        Me.panel_accountdetails.Controls.Add(Me.txt_newpassword2)
        Me.panel_accountdetails.Controls.Add(Me.txt_newpassword1)
        Me.panel_accountdetails.Controls.Add(Me.Label20)
        Me.panel_accountdetails.Controls.Add(Me.Label5)
        Me.panel_accountdetails.Controls.Add(Me.Label1)
        Me.panel_accountdetails.Controls.Add(Me.Label3)
        Me.panel_accountdetails.Controls.Add(Me.txt_oldpassword)
        Me.panel_accountdetails.Location = New System.Drawing.Point(138, 38)
        Me.panel_accountdetails.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_accountdetails.Name = "panel_accountdetails"
        Me.panel_accountdetails.Size = New System.Drawing.Size(500, 383)
        Me.panel_accountdetails.TabIndex = 78
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(117, 272)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(63, 15)
        Me.Label29.TabIndex = 69
        Me.Label29.Text = "New Type:"
        '
        'btn_submittype
        '
        Me.btn_submittype.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_submittype.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_submittype.FlatAppearance.BorderSize = 0
        Me.btn_submittype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submittype.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submittype.ForeColor = System.Drawing.Color.White
        Me.btn_submittype.Location = New System.Drawing.Point(183, 306)
        Me.btn_submittype.Name = "btn_submittype"
        Me.btn_submittype.Size = New System.Drawing.Size(175, 25)
        Me.btn_submittype.TabIndex = 68
        Me.btn_submittype.Text = "Submit"
        Me.btn_submittype.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(188, 239)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(164, 17)
        Me.Label28.TabIndex = 67
        Me.Label28.Text = "Change your Account Type"
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.FormattingEnabled = True
        Me.txt_type.Items.AddRange(New Object() {"Teacher", "Faculty Leader", "Cover Manager"})
        Me.txt_type.Location = New System.Drawing.Point(183, 268)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(175, 23)
        Me.txt_type.TabIndex = 66
        '
        'btn_submitpassword
        '
        Me.btn_submitpassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_submitpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_submitpassword.FlatAppearance.BorderSize = 0
        Me.btn_submitpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submitpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submitpassword.ForeColor = System.Drawing.Color.White
        Me.btn_submitpassword.Location = New System.Drawing.Point(183, 172)
        Me.btn_submitpassword.Name = "btn_submitpassword"
        Me.btn_submitpassword.Size = New System.Drawing.Size(175, 25)
        Me.btn_submitpassword.TabIndex = 60
        Me.btn_submitpassword.Text = "Submit"
        Me.btn_submitpassword.UseVisualStyleBackColor = False
        '
        'txt_newpassword2
        '
        Me.txt_newpassword2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newpassword2.Location = New System.Drawing.Point(183, 136)
        Me.txt_newpassword2.Name = "txt_newpassword2"
        Me.txt_newpassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_newpassword2.Size = New System.Drawing.Size(175, 23)
        Me.txt_newpassword2.TabIndex = 65
        '
        'txt_newpassword1
        '
        Me.txt_newpassword1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newpassword1.Location = New System.Drawing.Point(183, 107)
        Me.txt_newpassword1.Name = "txt_newpassword1"
        Me.txt_newpassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_newpassword1.Size = New System.Drawing.Size(175, 23)
        Me.txt_newpassword1.TabIndex = 64
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(92, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 15)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "New Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(125, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Confirm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(96, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Old Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(200, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Change your Password"
        '
        'txt_oldpassword
        '
        Me.txt_oldpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_oldpassword.Location = New System.Drawing.Point(183, 78)
        Me.txt_oldpassword.Name = "txt_oldpassword"
        Me.txt_oldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_oldpassword.Size = New System.Drawing.Size(175, 23)
        Me.txt_oldpassword.TabIndex = 60
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.minimize
        Me.PictureBox2.Location = New System.Drawing.Point(594, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(617, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.White
        Me.pic_logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(5, 337)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(124, 44)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 0
        Me.pic_logo.TabStop = False
        '
        'frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(642, 451)
        Me.Controls.Add(Me.panel_start)
        Me.Controls.Add(Me.panel_notifications)
        Me.Controls.Add(Me.panel_myrequests)
        Me.Controls.Add(Me.panel_facultyarea)
        Me.Controls.Add(Me.panel_roomchange)
        Me.Controls.Add(Me.panel_requestcover)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.lbl_main)
        Me.Controls.Add(Me.btn_sync)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_requestcover)
        Me.Controls.Add(Me.btn_roomchange)
        Me.Controls.Add(Me.btn_facultyarea)
        Me.Controls.Add(Me.btn_accountdetails)
        Me.Controls.Add(Me.btn_notifications)
        Me.Controls.Add(Me.btn_myrequests)
        Me.Controls.Add(Me.panel_accountdetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_home"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ridgeway Cover Manager"
        Me.nfimenu.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_sync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_requestcover.ResumeLayout(False)
        Me.panel_requestcover.PerformLayout()
        Me.myrequests_tc_myrequests.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dg_mycovers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dg_myroomchanges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_myrequests.ResumeLayout(False)
        CType(Me.dg_viewrequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_facultyarea.ResumeLayout(False)
        Me.panel_facultyarea.PerformLayout()
        Me.panel_roomchange.ResumeLayout(False)
        Me.panel_roomchange.PerformLayout()
        Me.panel_notifications.ResumeLayout(False)
        Me.panel_notifications.PerformLayout()
        Me.panel_start.ResumeLayout(False)
        Me.panel_start.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.panel_accountdetails.ResumeLayout(False)
        Me.panel_accountdetails.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_roomchange As System.Windows.Forms.Button
    Friend WithEvents btn_facultyarea As System.Windows.Forms.Button
    Friend WithEvents btn_myrequests As System.Windows.Forms.Button
    Friend WithEvents btn_requestcover As System.Windows.Forms.Button
    Friend WithEvents pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_accountdetails As System.Windows.Forms.Button
    Friend WithEvents btn_sync As System.Windows.Forms.PictureBox
    Friend WithEvents nfimenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nfi As System.Windows.Forms.NotifyIcon
    Friend WithEvents btn_notifications As System.Windows.Forms.Button
    Friend WithEvents data_timer As System.Windows.Forms.Timer
    Friend WithEvents tt_notify As System.Windows.Forms.ToolTip
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents requestcover_txt_startperiod As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_startperiodcover As System.Windows.Forms.Label
    Friend WithEvents requestcover_chk_thislessononly As System.Windows.Forms.CheckBox
    Friend WithEvents requestcover_btn_submit As System.Windows.Forms.Button
    Friend WithEvents lbl_startdatecover As System.Windows.Forms.Label
    Friend WithEvents requestcover_txt_endperiod As System.Windows.Forms.ComboBox
    Friend WithEvents requestcover_dp_enddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents requestcover_dp_startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents requestcover_txt_facultyhead As System.Windows.Forms.ComboBox
    Friend WithEvents requestcover_txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents panel_requestcover As System.Windows.Forms.Panel
    Friend WithEvents myrequests_tc_myrequests As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dg_mycovers As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dg_myroomchanges As System.Windows.Forms.DataGridView
    Friend WithEvents panel_myrequests As System.Windows.Forms.Panel
    Friend WithEvents dg_viewrequests As System.Windows.Forms.DataGridView
    Friend WithEvents facultyarea_txt_startperiod As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chk_thislessononly As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents facultyarea_dp_startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents facultyarea_txt_endperiod As System.Windows.Forms.ComboBox
    Friend WithEvents facultyarea_dp_enddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents facultyarea_txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents facultyarea_btn_approve As System.Windows.Forms.Button
    Friend WithEvents facultyarea_btn_reject As System.Windows.Forms.Button
    Friend WithEvents panel_facultyarea As System.Windows.Forms.Panel
    Friend WithEvents roomchange_txt_startperiod As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents roomchange_chk_thislessononly As System.Windows.Forms.CheckBox
    Friend WithEvents roomchange_btn_submit As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents roomchange_txt_endperiod As System.Windows.Forms.ComboBox
    Friend WithEvents roomchange_dp_enddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents roomchange_dp_startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents roomchange_txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents roomchange_txt_room As System.Windows.Forms.TextBox
    Friend WithEvents panel_roomchange As System.Windows.Forms.Panel
    Friend WithEvents panel_notifications_clearnotifications As System.Windows.Forms.Button
    Friend WithEvents lbl_notify As System.Windows.Forms.TextBox
    Friend WithEvents panel_notifications As System.Windows.Forms.Panel
    Friend WithEvents lbl_currentuser As System.Windows.Forms.Label
    Friend WithEvents txt_logout As System.Windows.Forms.LinkLabel
    Friend WithEvents panel_start As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents lbl_main As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ManageUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoverManagementAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents myrequests_btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Help As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SubmitBugReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents toolstrip_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents panel_accountdetails As System.Windows.Forms.Panel
    Friend WithEvents btn_submitpassword As System.Windows.Forms.Button
    Friend WithEvents txt_newpassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_newpassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_oldpassword As System.Windows.Forms.TextBox
    Friend WithEvents txt_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btn_submittype As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_pendingbooking As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NotificationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
