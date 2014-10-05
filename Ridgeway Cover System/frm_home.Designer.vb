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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_roomchange = New System.Windows.Forms.Button()
        Me.btn_facultyarea = New System.Windows.Forms.Button()
        Me.btn_myrequests = New System.Windows.Forms.Button()
        Me.panel_requestcover = New System.Windows.Forms.Panel()
        Me.requestcover_txt_reason = New System.Windows.Forms.TextBox()
        Me.requestcover_txt_facultyhead = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.requestcover_dp_startdate = New System.Windows.Forms.DateTimePicker()
        Me.requestcover_dp_enddate = New System.Windows.Forms.DateTimePicker()
        Me.requestcover_txt_endperiod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.requestcover_chk_thislessononly = New System.Windows.Forms.CheckBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.requestcover_txt_startperiod = New System.Windows.Forms.ComboBox()
        Me.btn_requestcover = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_userinterface = New System.Windows.Forms.Button()
        Me.btn_accountdetails = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel_start = New System.Windows.Forms.Panel()
        Me.lbl_connectionstate = New System.Windows.Forms.Label()
        Me.txt_logout = New System.Windows.Forms.LinkLabel()
        Me.lbl_currentuser = New System.Windows.Forms.Label()
        Me.lbl_welcome = New System.Windows.Forms.Label()
        Me.panel_roomchange = New System.Windows.Forms.Panel()
        Me.roomchange_txt_room = New System.Windows.Forms.TextBox()
        Me.roomchange_txt_reason = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.roomchange_dp_startdate = New System.Windows.Forms.DateTimePicker()
        Me.roomchange_dp_enddate = New System.Windows.Forms.DateTimePicker()
        Me.roomchange_txt_endperiod = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.roomchange_btn_submit = New System.Windows.Forms.Button()
        Me.roomchange_chk_thislessononly = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.roomchange_txt_startperiod = New System.Windows.Forms.ComboBox()
        Me.panel_myrequests = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.myrequests_btn_cancel = New System.Windows.Forms.PictureBox()
        Me.myrequests_tc_myrequests = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dg_mycovers = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dg_myroomchanges = New System.Windows.Forms.DataGridView()
        Me.btn_sync = New System.Windows.Forms.PictureBox()
        Me.panel_facultyarea = New System.Windows.Forms.Panel()
        Me.facultyarea_btn_reject = New System.Windows.Forms.Button()
        Me.facultyarea_btn_approve = New System.Windows.Forms.Button()
        Me.facultyarea_txt_reason = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.facultyarea_dp_enddate = New System.Windows.Forms.DateTimePicker()
        Me.facultyarea_txt_endperiod = New System.Windows.Forms.ComboBox()
        Me.facultyarea_dp_startdate = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.chk_thislessononly = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.facultyarea_txt_startperiod = New System.Windows.Forms.ComboBox()
        Me.dg_viewrequests = New System.Windows.Forms.DataGridView()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchAdminCentreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchCoverManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpDocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitABugReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nfimenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lbl_facultyarea = New System.Windows.Forms.Label()
        Me.lbl_myrequests = New System.Windows.Forms.Label()
        Me.lbl_requestcover = New System.Windows.Forms.Label()
        Me.lbl_roomchange = New System.Windows.Forms.Label()
        Me.lbl_start = New System.Windows.Forms.Label()
        Me.btn_notifications = New System.Windows.Forms.Button()
        Me.panel_notifications = New System.Windows.Forms.Panel()
        Me.lbl_notify = New System.Windows.Forms.TextBox()
        Me.panel_notifications_clearnotifications = New System.Windows.Forms.Button()
        Me.lbl_notifications = New System.Windows.Forms.Label()
        Me.data_timer = New System.Windows.Forms.Timer(Me.components)
        Me.panel_requestcover.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_start.SuspendLayout()
        Me.panel_roomchange.SuspendLayout()
        Me.panel_myrequests.SuspendLayout()
        CType(Me.myrequests_btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.myrequests_tc_myrequests.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg_mycovers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dg_myroomchanges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_sync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_facultyarea.SuspendLayout()
        CType(Me.dg_viewrequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.nfimenu.SuspendLayout()
        Me.panel_notifications.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NEW"
        '
        'btn_roomchange
        '
        Me.btn_roomchange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_roomchange.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_roomchange.FlatAppearance.BorderSize = 0
        Me.btn_roomchange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_roomchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_roomchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_roomchange.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_roomchange.ForeColor = System.Drawing.Color.White
        Me.btn_roomchange.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.roomchange
        Me.btn_roomchange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_roomchange.Location = New System.Drawing.Point(6, 157)
        Me.btn_roomchange.Name = "btn_roomchange"
        Me.btn_roomchange.Size = New System.Drawing.Size(125, 35)
        Me.btn_roomchange.TabIndex = 4
        Me.btn_roomchange.TabStop = False
        Me.btn_roomchange.Text = "       Room Change"
        Me.btn_roomchange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_roomchange.UseVisualStyleBackColor = True
        '
        'btn_facultyarea
        '
        Me.btn_facultyarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_facultyarea.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_facultyarea.FlatAppearance.BorderSize = 0
        Me.btn_facultyarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_facultyarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_facultyarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facultyarea.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facultyarea.ForeColor = System.Drawing.Color.White
        Me.btn_facultyarea.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.facultyarea
        Me.btn_facultyarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facultyarea.Location = New System.Drawing.Point(6, 290)
        Me.btn_facultyarea.Name = "btn_facultyarea"
        Me.btn_facultyarea.Size = New System.Drawing.Size(125, 35)
        Me.btn_facultyarea.TabIndex = 10
        Me.btn_facultyarea.TabStop = False
        Me.btn_facultyarea.Text = "       Faculty Area"
        Me.btn_facultyarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facultyarea.UseVisualStyleBackColor = True
        '
        'btn_myrequests
        '
        Me.btn_myrequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_myrequests.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_myrequests.FlatAppearance.BorderSize = 0
        Me.btn_myrequests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_myrequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_myrequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_myrequests.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_myrequests.ForeColor = System.Drawing.Color.White
        Me.btn_myrequests.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.myrequests
        Me.btn_myrequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_myrequests.Location = New System.Drawing.Point(6, 256)
        Me.btn_myrequests.Name = "btn_myrequests"
        Me.btn_myrequests.Size = New System.Drawing.Size(125, 35)
        Me.btn_myrequests.TabIndex = 9
        Me.btn_myrequests.TabStop = False
        Me.btn_myrequests.Text = "       My Requests"
        Me.btn_myrequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_myrequests.UseVisualStyleBackColor = True
        '
        'panel_requestcover
        '
        Me.panel_requestcover.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panel_requestcover.Controls.Add(Me.requestcover_txt_reason)
        Me.panel_requestcover.Controls.Add(Me.requestcover_txt_facultyhead)
        Me.panel_requestcover.Controls.Add(Me.Label11)
        Me.panel_requestcover.Controls.Add(Me.Label10)
        Me.panel_requestcover.Controls.Add(Me.Label9)
        Me.panel_requestcover.Controls.Add(Me.Label4)
        Me.panel_requestcover.Controls.Add(Me.Label8)
        Me.panel_requestcover.Controls.Add(Me.Label7)
        Me.panel_requestcover.Controls.Add(Me.requestcover_dp_startdate)
        Me.panel_requestcover.Controls.Add(Me.requestcover_dp_enddate)
        Me.panel_requestcover.Controls.Add(Me.requestcover_txt_endperiod)
        Me.panel_requestcover.Controls.Add(Me.Label6)
        Me.panel_requestcover.Controls.Add(Me.btn_submit)
        Me.panel_requestcover.Controls.Add(Me.requestcover_chk_thislessononly)
        Me.panel_requestcover.Controls.Add(Me.Label40)
        Me.panel_requestcover.Controls.Add(Me.requestcover_txt_startperiod)
        Me.panel_requestcover.Location = New System.Drawing.Point(131, 65)
        Me.panel_requestcover.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_requestcover.Name = "panel_requestcover"
        Me.panel_requestcover.Size = New System.Drawing.Size(499, 382)
        Me.panel_requestcover.TabIndex = 11
        Me.panel_requestcover.Visible = False
        '
        'requestcover_txt_reason
        '
        Me.requestcover_txt_reason.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_txt_reason.Location = New System.Drawing.Point(249, 149)
        Me.requestcover_txt_reason.Margin = New System.Windows.Forms.Padding(6)
        Me.requestcover_txt_reason.Multiline = True
        Me.requestcover_txt_reason.Name = "requestcover_txt_reason"
        Me.requestcover_txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.requestcover_txt_reason.Size = New System.Drawing.Size(175, 106)
        Me.requestcover_txt_reason.TabIndex = 6
        '
        'requestcover_txt_facultyhead
        '
        Me.requestcover_txt_facultyhead.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_txt_facultyhead.FormattingEnabled = True
        Me.requestcover_txt_facultyhead.Location = New System.Drawing.Point(249, 91)
        Me.requestcover_txt_facultyhead.Name = "requestcover_txt_facultyhead"
        Me.requestcover_txt_facultyhead.Size = New System.Drawing.Size(175, 23)
        Me.requestcover_txt_facultyhead.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(311, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Reason"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(291, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 17)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Faculty Leader"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(127, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(124, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Start Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(68, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Period:"
        '
        'requestcover_dp_startdate
        '
        Me.requestcover_dp_startdate.CustomFormat = "dd'-'MM'-'yy"
        Me.requestcover_dp_startdate.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_dp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.requestcover_dp_startdate.Location = New System.Drawing.Point(115, 91)
        Me.requestcover_dp_startdate.Name = "requestcover_dp_startdate"
        Me.requestcover_dp_startdate.Size = New System.Drawing.Size(80, 22)
        Me.requestcover_dp_startdate.TabIndex = 5
        Me.requestcover_dp_startdate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'requestcover_dp_enddate
        '
        Me.requestcover_dp_enddate.CustomFormat = "dd'-'MM'-'yy"
        Me.requestcover_dp_enddate.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_dp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.requestcover_dp_enddate.Location = New System.Drawing.Point(115, 205)
        Me.requestcover_dp_enddate.Name = "requestcover_dp_enddate"
        Me.requestcover_dp_enddate.Size = New System.Drawing.Size(80, 22)
        Me.requestcover_dp_enddate.TabIndex = 13
        Me.requestcover_dp_enddate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'requestcover_txt_endperiod
        '
        Me.requestcover_txt_endperiod.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_txt_endperiod.FormattingEnabled = True
        Me.requestcover_txt_endperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.requestcover_txt_endperiod.Location = New System.Drawing.Point(115, 233)
        Me.requestcover_txt_endperiod.Name = "requestcover_txt_endperiod"
        Me.requestcover_txt_endperiod.Size = New System.Drawing.Size(34, 23)
        Me.requestcover_txt_endperiod.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(75, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date:"
        '
        'btn_submit
        '
        Me.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_submit.FlatAppearance.BorderSize = 0
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.Color.White
        Me.btn_submit.Location = New System.Drawing.Point(155, 296)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(200, 35)
        Me.btn_submit.TabIndex = 54
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'requestcover_chk_thislessononly
        '
        Me.requestcover_chk_thislessononly.AutoSize = True
        Me.requestcover_chk_thislessononly.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_chk_thislessononly.ForeColor = System.Drawing.Color.White
        Me.requestcover_chk_thislessononly.Location = New System.Drawing.Point(115, 148)
        Me.requestcover_chk_thislessononly.Name = "requestcover_chk_thislessononly"
        Me.requestcover_chk_thislessononly.Size = New System.Drawing.Size(100, 19)
        Me.requestcover_chk_thislessononly.TabIndex = 30
        Me.requestcover_chk_thislessononly.Text = "This lesson only"
        Me.requestcover_chk_thislessononly.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(68, 122)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(41, 15)
        Me.Label40.TabIndex = 11
        Me.Label40.Text = "Period:"
        '
        'requestcover_txt_startperiod
        '
        Me.requestcover_txt_startperiod.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestcover_txt_startperiod.FormattingEnabled = True
        Me.requestcover_txt_startperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.requestcover_txt_startperiod.Location = New System.Drawing.Point(115, 119)
        Me.requestcover_txt_startperiod.Name = "requestcover_txt_startperiod"
        Me.requestcover_txt_startperiod.Size = New System.Drawing.Size(34, 23)
        Me.requestcover_txt_startperiod.TabIndex = 6
        '
        'btn_requestcover
        '
        Me.btn_requestcover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_requestcover.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_requestcover.FlatAppearance.BorderSize = 0
        Me.btn_requestcover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_requestcover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_requestcover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_requestcover.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_requestcover.ForeColor = System.Drawing.Color.White
        Me.btn_requestcover.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.coverrequest
        Me.btn_requestcover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_requestcover.Location = New System.Drawing.Point(6, 123)
        Me.btn_requestcover.Name = "btn_requestcover"
        Me.btn_requestcover.Size = New System.Drawing.Size(125, 35)
        Me.btn_requestcover.TabIndex = 12
        Me.btn_requestcover.TabStop = False
        Me.btn_requestcover.Text = "       Cover Request"
        Me.btn_requestcover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_requestcover.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "MANAGE REQUESTS"
        '
        'pic_logo
        '
        Me.pic_logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_logo.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.schoollogo
        Me.pic_logo.Location = New System.Drawing.Point(27, 39)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(76, 52)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 0
        Me.pic_logo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "OPTIONS"
        '
        'btn_userinterface
        '
        Me.btn_userinterface.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_userinterface.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_userinterface.FlatAppearance.BorderSize = 0
        Me.btn_userinterface.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_userinterface.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_userinterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_userinterface.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_userinterface.ForeColor = System.Drawing.Color.White
        Me.btn_userinterface.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.userinterface
        Me.btn_userinterface.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_userinterface.Location = New System.Drawing.Point(6, 391)
        Me.btn_userinterface.Name = "btn_userinterface"
        Me.btn_userinterface.Size = New System.Drawing.Size(125, 35)
        Me.btn_userinterface.TabIndex = 15
        Me.btn_userinterface.TabStop = False
        Me.btn_userinterface.Text = "       User Interface"
        Me.btn_userinterface.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_userinterface.UseVisualStyleBackColor = True
        '
        'btn_accountdetails
        '
        Me.btn_accountdetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_accountdetails.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_accountdetails.FlatAppearance.BorderSize = 0
        Me.btn_accountdetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_accountdetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_accountdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_accountdetails.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_accountdetails.ForeColor = System.Drawing.Color.White
        Me.btn_accountdetails.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.userdetails
        Me.btn_accountdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_accountdetails.Location = New System.Drawing.Point(6, 357)
        Me.btn_accountdetails.Name = "btn_accountdetails"
        Me.btn_accountdetails.Size = New System.Drawing.Size(125, 35)
        Me.btn_accountdetails.TabIndex = 14
        Me.btn_accountdetails.TabStop = False
        Me.btn_accountdetails.Text = "       Account Details"
        Me.btn_accountdetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_accountdetails.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 432)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "© TRS 2014"
        '
        'panel_start
        '
        Me.panel_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panel_start.Controls.Add(Me.txt_logout)
        Me.panel_start.Controls.Add(Me.lbl_currentuser)
        Me.panel_start.Controls.Add(Me.lbl_welcome)
        Me.panel_start.Controls.Add(Me.lbl_connectionstate)
        Me.panel_start.Location = New System.Drawing.Point(131, 65)
        Me.panel_start.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_start.Name = "panel_start"
        Me.panel_start.Size = New System.Drawing.Size(499, 382)
        Me.panel_start.TabIndex = 59
        '
        'lbl_connectionstate
        '
        Me.lbl_connectionstate.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connectionstate.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_connectionstate.Location = New System.Drawing.Point(0, 343)
        Me.lbl_connectionstate.Name = "lbl_connectionstate"
        Me.lbl_connectionstate.Size = New System.Drawing.Size(499, 37)
        Me.lbl_connectionstate.TabIndex = 4
        Me.lbl_connectionstate.Text = "Connected"
        Me.lbl_connectionstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_logout
        '
        Me.txt_logout.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_logout.AutoSize = True
        Me.txt_logout.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_logout.LinkColor = System.Drawing.Color.White
        Me.txt_logout.Location = New System.Drawing.Point(213, 201)
        Me.txt_logout.Name = "txt_logout"
        Me.txt_logout.Size = New System.Drawing.Size(72, 19)
        Me.txt_logout.TabIndex = 3
        Me.txt_logout.TabStop = True
        Me.txt_logout.Text = "Not you?"
        '
        'lbl_currentuser
        '
        Me.lbl_currentuser.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentuser.ForeColor = System.Drawing.Color.White
        Me.lbl_currentuser.Location = New System.Drawing.Point(0, 169)
        Me.lbl_currentuser.Name = "lbl_currentuser"
        Me.lbl_currentuser.Size = New System.Drawing.Size(499, 37)
        Me.lbl_currentuser.TabIndex = 1
        Me.lbl_currentuser.Text = "Logged in as "
        Me.lbl_currentuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_welcome.ForeColor = System.Drawing.Color.White
        Me.lbl_welcome.Location = New System.Drawing.Point(202, 150)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(95, 24)
        Me.lbl_welcome.TabIndex = 0
        Me.lbl_welcome.Text = "Welcome"
        Me.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_roomchange
        '
        Me.panel_roomchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panel_roomchange.Controls.Add(Me.roomchange_txt_room)
        Me.panel_roomchange.Controls.Add(Me.roomchange_txt_reason)
        Me.panel_roomchange.Controls.Add(Me.Label12)
        Me.panel_roomchange.Controls.Add(Me.Label13)
        Me.panel_roomchange.Controls.Add(Me.Label14)
        Me.panel_roomchange.Controls.Add(Me.Label15)
        Me.panel_roomchange.Controls.Add(Me.Label16)
        Me.panel_roomchange.Controls.Add(Me.Label17)
        Me.panel_roomchange.Controls.Add(Me.roomchange_dp_startdate)
        Me.panel_roomchange.Controls.Add(Me.roomchange_dp_enddate)
        Me.panel_roomchange.Controls.Add(Me.roomchange_txt_endperiod)
        Me.panel_roomchange.Controls.Add(Me.Label18)
        Me.panel_roomchange.Controls.Add(Me.roomchange_btn_submit)
        Me.panel_roomchange.Controls.Add(Me.roomchange_chk_thislessononly)
        Me.panel_roomchange.Controls.Add(Me.Label19)
        Me.panel_roomchange.Controls.Add(Me.roomchange_txt_startperiod)
        Me.panel_roomchange.Location = New System.Drawing.Point(131, 65)
        Me.panel_roomchange.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_roomchange.Name = "panel_roomchange"
        Me.panel_roomchange.Size = New System.Drawing.Size(499, 382)
        Me.panel_roomchange.TabIndex = 59
        Me.panel_roomchange.Visible = False
        '
        'roomchange_txt_room
        '
        Me.roomchange_txt_room.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.roomchange_txt_room.Location = New System.Drawing.Point(283, 91)
        Me.roomchange_txt_room.Name = "roomchange_txt_room"
        Me.roomchange_txt_room.Size = New System.Drawing.Size(100, 23)
        Me.roomchange_txt_room.TabIndex = 59
        '
        'roomchange_txt_reason
        '
        Me.roomchange_txt_reason.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_txt_reason.Location = New System.Drawing.Point(249, 149)
        Me.roomchange_txt_reason.Margin = New System.Windows.Forms.Padding(6)
        Me.roomchange_txt_reason.Multiline = True
        Me.roomchange_txt_reason.Name = "roomchange_txt_reason"
        Me.roomchange_txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.roomchange_txt_reason.Size = New System.Drawing.Size(175, 106)
        Me.roomchange_txt_reason.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(311, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Reason"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(313, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 17)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Room"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(127, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 17)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "End Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(75, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 15)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Date:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(124, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 17)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Start Date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(68, 235)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 15)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Period:"
        '
        'roomchange_dp_startdate
        '
        Me.roomchange_dp_startdate.CustomFormat = "dd'-'MM'-'yy"
        Me.roomchange_dp_startdate.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_dp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.roomchange_dp_startdate.Location = New System.Drawing.Point(115, 91)
        Me.roomchange_dp_startdate.Name = "roomchange_dp_startdate"
        Me.roomchange_dp_startdate.Size = New System.Drawing.Size(80, 22)
        Me.roomchange_dp_startdate.TabIndex = 5
        Me.roomchange_dp_startdate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'roomchange_dp_enddate
        '
        Me.roomchange_dp_enddate.CustomFormat = "dd'-'MM'-'yy"
        Me.roomchange_dp_enddate.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_dp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.roomchange_dp_enddate.Location = New System.Drawing.Point(115, 205)
        Me.roomchange_dp_enddate.Name = "roomchange_dp_enddate"
        Me.roomchange_dp_enddate.Size = New System.Drawing.Size(80, 22)
        Me.roomchange_dp_enddate.TabIndex = 13
        Me.roomchange_dp_enddate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'roomchange_txt_endperiod
        '
        Me.roomchange_txt_endperiod.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_txt_endperiod.FormattingEnabled = True
        Me.roomchange_txt_endperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.roomchange_txt_endperiod.Location = New System.Drawing.Point(115, 232)
        Me.roomchange_txt_endperiod.Name = "roomchange_txt_endperiod"
        Me.roomchange_txt_endperiod.Size = New System.Drawing.Size(34, 23)
        Me.roomchange_txt_endperiod.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(75, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 15)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Date:"
        '
        'roomchange_btn_submit
        '
        Me.roomchange_btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.roomchange_btn_submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.roomchange_btn_submit.FlatAppearance.BorderSize = 0
        Me.roomchange_btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roomchange_btn_submit.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_btn_submit.ForeColor = System.Drawing.Color.White
        Me.roomchange_btn_submit.Location = New System.Drawing.Point(155, 296)
        Me.roomchange_btn_submit.Name = "roomchange_btn_submit"
        Me.roomchange_btn_submit.Size = New System.Drawing.Size(200, 35)
        Me.roomchange_btn_submit.TabIndex = 54
        Me.roomchange_btn_submit.Text = "Submit"
        Me.roomchange_btn_submit.UseVisualStyleBackColor = False
        '
        'roomchange_chk_thislessononly
        '
        Me.roomchange_chk_thislessononly.AutoSize = True
        Me.roomchange_chk_thislessononly.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_chk_thislessononly.ForeColor = System.Drawing.Color.White
        Me.roomchange_chk_thislessononly.Location = New System.Drawing.Point(115, 148)
        Me.roomchange_chk_thislessononly.Name = "roomchange_chk_thislessononly"
        Me.roomchange_chk_thislessononly.Size = New System.Drawing.Size(100, 19)
        Me.roomchange_chk_thislessononly.TabIndex = 30
        Me.roomchange_chk_thislessononly.Text = "This lesson only"
        Me.roomchange_chk_thislessononly.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(68, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 15)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Period:"
        '
        'roomchange_txt_startperiod
        '
        Me.roomchange_txt_startperiod.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomchange_txt_startperiod.FormattingEnabled = True
        Me.roomchange_txt_startperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.roomchange_txt_startperiod.Location = New System.Drawing.Point(115, 119)
        Me.roomchange_txt_startperiod.Name = "roomchange_txt_startperiod"
        Me.roomchange_txt_startperiod.Size = New System.Drawing.Size(34, 23)
        Me.roomchange_txt_startperiod.TabIndex = 6
        '
        'panel_myrequests
        '
        Me.panel_myrequests.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panel_myrequests.Controls.Add(Me.Label20)
        Me.panel_myrequests.Controls.Add(Me.myrequests_btn_cancel)
        Me.panel_myrequests.Controls.Add(Me.myrequests_tc_myrequests)
        Me.panel_myrequests.Location = New System.Drawing.Point(131, 65)
        Me.panel_myrequests.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_myrequests.Name = "panel_myrequests"
        Me.panel_myrequests.Size = New System.Drawing.Size(499, 382)
        Me.panel_myrequests.TabIndex = 60
        Me.panel_myrequests.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Open Sans Light", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(297, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(160, 18)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Cancel selected request(s)"
        '
        'myrequests_btn_cancel
        '
        Me.myrequests_btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.myrequests_btn_cancel.Image = CType(resources.GetObject("myrequests_btn_cancel.Image"), System.Drawing.Image)
        Me.myrequests_btn_cancel.Location = New System.Drawing.Point(458, 14)
        Me.myrequests_btn_cancel.Name = "myrequests_btn_cancel"
        Me.myrequests_btn_cancel.Size = New System.Drawing.Size(30, 30)
        Me.myrequests_btn_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.myrequests_btn_cancel.TabIndex = 63
        Me.myrequests_btn_cancel.TabStop = False
        '
        'myrequests_tc_myrequests
        '
        Me.myrequests_tc_myrequests.Controls.Add(Me.TabPage1)
        Me.myrequests_tc_myrequests.Controls.Add(Me.TabPage2)
        Me.myrequests_tc_myrequests.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myrequests_tc_myrequests.HotTrack = True
        Me.myrequests_tc_myrequests.Location = New System.Drawing.Point(6, 33)
        Me.myrequests_tc_myrequests.Multiline = True
        Me.myrequests_tc_myrequests.Name = "myrequests_tc_myrequests"
        Me.myrequests_tc_myrequests.SelectedIndex = 0
        Me.myrequests_tc_myrequests.Size = New System.Drawing.Size(486, 342)
        Me.myrequests_tc_myrequests.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dg_mycovers)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(478, 314)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Open Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_mycovers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_mycovers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mycovers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_mycovers.Location = New System.Drawing.Point(3, 3)
        Me.dg_mycovers.Name = "dg_mycovers"
        Me.dg_mycovers.ReadOnly = True
        Me.dg_mycovers.RowHeadersVisible = False
        Me.dg_mycovers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_mycovers.Size = New System.Drawing.Size(472, 308)
        Me.dg_mycovers.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.dg_myroomchanges)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(478, 314)
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
        Me.dg_myroomchanges.Size = New System.Drawing.Size(472, 308)
        Me.dg_myroomchanges.TabIndex = 1
        '
        'btn_sync
        '
        Me.btn_sync.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sync.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.sync
        Me.btn_sync.Location = New System.Drawing.Point(587, 34)
        Me.btn_sync.Name = "btn_sync"
        Me.btn_sync.Size = New System.Drawing.Size(43, 21)
        Me.btn_sync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_sync.TabIndex = 62
        Me.btn_sync.TabStop = False
        '
        'panel_facultyarea
        '
        Me.panel_facultyarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_btn_reject)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_btn_approve)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_txt_reason)
        Me.panel_facultyarea.Controls.Add(Me.Label27)
        Me.panel_facultyarea.Controls.Add(Me.Label26)
        Me.panel_facultyarea.Controls.Add(Me.Label21)
        Me.panel_facultyarea.Controls.Add(Me.Label25)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_dp_enddate)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_txt_endperiod)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_dp_startdate)
        Me.panel_facultyarea.Controls.Add(Me.Label22)
        Me.panel_facultyarea.Controls.Add(Me.chk_thislessononly)
        Me.panel_facultyarea.Controls.Add(Me.Label23)
        Me.panel_facultyarea.Controls.Add(Me.Label24)
        Me.panel_facultyarea.Controls.Add(Me.facultyarea_txt_startperiod)
        Me.panel_facultyarea.Controls.Add(Me.dg_viewrequests)
        Me.panel_facultyarea.Location = New System.Drawing.Point(131, 65)
        Me.panel_facultyarea.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_facultyarea.Name = "panel_facultyarea"
        Me.panel_facultyarea.Size = New System.Drawing.Size(499, 382)
        Me.panel_facultyarea.TabIndex = 60
        '
        'facultyarea_btn_reject
        '
        Me.facultyarea_btn_reject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.facultyarea_btn_reject.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.facultyarea_btn_reject.FlatAppearance.BorderSize = 0
        Me.facultyarea_btn_reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyarea_btn_reject.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_btn_reject.ForeColor = System.Drawing.Color.White
        Me.facultyarea_btn_reject.Location = New System.Drawing.Point(265, 317)
        Me.facultyarea_btn_reject.Name = "facultyarea_btn_reject"
        Me.facultyarea_btn_reject.Size = New System.Drawing.Size(200, 35)
        Me.facultyarea_btn_reject.TabIndex = 60
        Me.facultyarea_btn_reject.Text = "Reject"
        Me.facultyarea_btn_reject.UseVisualStyleBackColor = False
        '
        'facultyarea_btn_approve
        '
        Me.facultyarea_btn_approve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.facultyarea_btn_approve.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.facultyarea_btn_approve.FlatAppearance.BorderSize = 0
        Me.facultyarea_btn_approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyarea_btn_approve.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_btn_approve.ForeColor = System.Drawing.Color.White
        Me.facultyarea_btn_approve.Location = New System.Drawing.Point(59, 317)
        Me.facultyarea_btn_approve.Name = "facultyarea_btn_approve"
        Me.facultyarea_btn_approve.Size = New System.Drawing.Size(200, 35)
        Me.facultyarea_btn_approve.TabIndex = 59
        Me.facultyarea_btn_approve.Text = "Approve"
        Me.facultyarea_btn_approve.UseVisualStyleBackColor = False
        '
        'facultyarea_txt_reason
        '
        Me.facultyarea_txt_reason.BackColor = System.Drawing.Color.White
        Me.facultyarea_txt_reason.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_txt_reason.Location = New System.Drawing.Point(362, 84)
        Me.facultyarea_txt_reason.Margin = New System.Windows.Forms.Padding(6)
        Me.facultyarea_txt_reason.Multiline = True
        Me.facultyarea_txt_reason.Name = "facultyarea_txt_reason"
        Me.facultyarea_txt_reason.ReadOnly = True
        Me.facultyarea_txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.facultyarea_txt_reason.Size = New System.Drawing.Size(125, 163)
        Me.facultyarea_txt_reason.TabIndex = 6
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(399, 62)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 17)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Reason"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(263, 173)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 17)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "End Date"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Open Sans Light", 8.25!)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(211, 201)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 15)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Date:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(260, 62)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 17)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "Start Date"
        '
        'facultyarea_dp_enddate
        '
        Me.facultyarea_dp_enddate.CustomFormat = "dd'-'MM'-'yy"
        Me.facultyarea_dp_enddate.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_dp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.facultyarea_dp_enddate.Location = New System.Drawing.Point(251, 195)
        Me.facultyarea_dp_enddate.Name = "facultyarea_dp_enddate"
        Me.facultyarea_dp_enddate.Size = New System.Drawing.Size(81, 23)
        Me.facultyarea_dp_enddate.TabIndex = 13
        Me.facultyarea_dp_enddate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'facultyarea_txt_endperiod
        '
        Me.facultyarea_txt_endperiod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.facultyarea_txt_endperiod.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_txt_endperiod.FormattingEnabled = True
        Me.facultyarea_txt_endperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.facultyarea_txt_endperiod.Location = New System.Drawing.Point(251, 224)
        Me.facultyarea_txt_endperiod.Name = "facultyarea_txt_endperiod"
        Me.facultyarea_txt_endperiod.Size = New System.Drawing.Size(31, 23)
        Me.facultyarea_txt_endperiod.TabIndex = 15
        '
        'facultyarea_dp_startdate
        '
        Me.facultyarea_dp_startdate.CustomFormat = "dd'-'MM'-'yy"
        Me.facultyarea_dp_startdate.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_dp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.facultyarea_dp_startdate.Location = New System.Drawing.Point(251, 84)
        Me.facultyarea_dp_startdate.Name = "facultyarea_dp_startdate"
        Me.facultyarea_dp_startdate.Size = New System.Drawing.Size(81, 23)
        Me.facultyarea_dp_startdate.TabIndex = 5
        Me.facultyarea_dp_startdate.Value = New Date(2014, 6, 14, 0, 0, 0, 0)
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Open Sans Light", 8.25!)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(205, 227)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 15)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Period:"
        '
        'chk_thislessononly
        '
        Me.chk_thislessononly.AutoSize = True
        Me.chk_thislessononly.Font = New System.Drawing.Font("Open Sans Light", 8.25!)
        Me.chk_thislessononly.ForeColor = System.Drawing.Color.White
        Me.chk_thislessononly.Location = New System.Drawing.Point(249, 142)
        Me.chk_thislessononly.Name = "chk_thislessononly"
        Me.chk_thislessononly.Size = New System.Drawing.Size(100, 19)
        Me.chk_thislessononly.TabIndex = 30
        Me.chk_thislessononly.Text = "This lesson only"
        Me.chk_thislessononly.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Open Sans Light", 8.25!)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(211, 90)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 15)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Date:"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Open Sans Light", 8.25!)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(205, 116)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 15)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Period:"
        '
        'facultyarea_txt_startperiod
        '
        Me.facultyarea_txt_startperiod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.facultyarea_txt_startperiod.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyarea_txt_startperiod.FormattingEnabled = True
        Me.facultyarea_txt_startperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.facultyarea_txt_startperiod.Location = New System.Drawing.Point(251, 113)
        Me.facultyarea_txt_startperiod.Name = "facultyarea_txt_startperiod"
        Me.facultyarea_txt_startperiod.Size = New System.Drawing.Size(34, 23)
        Me.facultyarea_txt_startperiod.TabIndex = 6
        '
        'dg_viewrequests
        '
        Me.dg_viewrequests.AllowUserToAddRows = False
        Me.dg_viewrequests.AllowUserToDeleteRows = False
        Me.dg_viewrequests.AllowUserToResizeColumns = False
        Me.dg_viewrequests.AllowUserToResizeRows = False
        Me.dg_viewrequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_viewrequests.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_viewrequests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_viewrequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_viewrequests.Location = New System.Drawing.Point(12, 34)
        Me.dg_viewrequests.MultiSelect = False
        Me.dg_viewrequests.Name = "dg_viewrequests"
        Me.dg_viewrequests.ReadOnly = True
        Me.dg_viewrequests.RowHeadersVisible = False
        Me.dg_viewrequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_viewrequests.Size = New System.Drawing.Size(180, 251)
        Me.dg_viewrequests.TabIndex = 41
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip.TabIndex = 64
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.QuitToolStripMenuItem.Text = "Exit"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchAdminCentreToolStripMenuItem, Me.LaunchCoverManagementToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LaunchAdminCentreToolStripMenuItem
        '
        Me.LaunchAdminCentreToolStripMenuItem.Name = "LaunchAdminCentreToolStripMenuItem"
        Me.LaunchAdminCentreToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaunchAdminCentreToolStripMenuItem.Text = "Launch Admin Centre"
        '
        'LaunchCoverManagementToolStripMenuItem
        '
        Me.LaunchCoverManagementToolStripMenuItem.Name = "LaunchCoverManagementToolStripMenuItem"
        Me.LaunchCoverManagementToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaunchCoverManagementToolStripMenuItem.Text = "Launch Cover Management"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpDocumentationToolStripMenuItem, Me.SubmitABugReportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpDocumentationToolStripMenuItem
        '
        Me.HelpDocumentationToolStripMenuItem.Name = "HelpDocumentationToolStripMenuItem"
        Me.HelpDocumentationToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.HelpDocumentationToolStripMenuItem.Text = "Help Documentation"
        '
        'SubmitABugReportToolStripMenuItem
        '
        Me.SubmitABugReportToolStripMenuItem.Name = "SubmitABugReportToolStripMenuItem"
        Me.SubmitABugReportToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SubmitABugReportToolStripMenuItem.Text = "Submit a Bug Report"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'nfimenu
        '
        Me.nfimenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.nfimenu.Name = "nfimenu"
        Me.nfimenu.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'nfi
        '
        Me.nfi.ContextMenuStrip = Me.nfimenu
        Me.nfi.Icon = CType(resources.GetObject("nfi.Icon"), System.Drawing.Icon)
        Me.nfi.Text = "Ridgeway Cover Scheduler"
        '
        'lbl_facultyarea
        '
        Me.lbl_facultyarea.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_facultyarea.ForeColor = System.Drawing.Color.White
        Me.lbl_facultyarea.Location = New System.Drawing.Point(131, 34)
        Me.lbl_facultyarea.Name = "lbl_facultyarea"
        Me.lbl_facultyarea.Size = New System.Drawing.Size(499, 23)
        Me.lbl_facultyarea.TabIndex = 63
        Me.lbl_facultyarea.Text = "Faculty Area"
        Me.lbl_facultyarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_myrequests
        '
        Me.lbl_myrequests.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_myrequests.ForeColor = System.Drawing.Color.White
        Me.lbl_myrequests.Location = New System.Drawing.Point(131, 34)
        Me.lbl_myrequests.Name = "lbl_myrequests"
        Me.lbl_myrequests.Size = New System.Drawing.Size(499, 23)
        Me.lbl_myrequests.TabIndex = 61
        Me.lbl_myrequests.Text = "My Requests"
        Me.lbl_myrequests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_requestcover
        '
        Me.lbl_requestcover.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_requestcover.ForeColor = System.Drawing.Color.White
        Me.lbl_requestcover.Location = New System.Drawing.Point(131, 34)
        Me.lbl_requestcover.Name = "lbl_requestcover"
        Me.lbl_requestcover.Size = New System.Drawing.Size(499, 23)
        Me.lbl_requestcover.TabIndex = 59
        Me.lbl_requestcover.Text = "New Cover Request"
        Me.lbl_requestcover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_roomchange
        '
        Me.lbl_roomchange.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomchange.ForeColor = System.Drawing.Color.White
        Me.lbl_roomchange.Location = New System.Drawing.Point(131, 34)
        Me.lbl_roomchange.Name = "lbl_roomchange"
        Me.lbl_roomchange.Size = New System.Drawing.Size(499, 23)
        Me.lbl_roomchange.TabIndex = 60
        Me.lbl_roomchange.Text = "New Room Change"
        Me.lbl_roomchange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_start
        '
        Me.lbl_start.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_start.ForeColor = System.Drawing.Color.White
        Me.lbl_start.Location = New System.Drawing.Point(131, 34)
        Me.lbl_start.Name = "lbl_start"
        Me.lbl_start.Size = New System.Drawing.Size(499, 23)
        Me.lbl_start.TabIndex = 60
        Me.lbl_start.Text = "Ridgeway Cover Manager"
        Me.lbl_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_notifications
        '
        Me.btn_notifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_notifications.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_notifications.FlatAppearance.BorderSize = 0
        Me.btn_notifications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_notifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_notifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_notifications.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_notifications.ForeColor = System.Drawing.Color.White
        Me.btn_notifications.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.notifications
        Me.btn_notifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_notifications.Location = New System.Drawing.Point(6, 222)
        Me.btn_notifications.Name = "btn_notifications"
        Me.btn_notifications.Size = New System.Drawing.Size(125, 35)
        Me.btn_notifications.TabIndex = 65
        Me.btn_notifications.TabStop = False
        Me.btn_notifications.Text = "       Notifications"
        Me.btn_notifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_notifications.UseVisualStyleBackColor = True
        '
        'panel_notifications
        '
        Me.panel_notifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panel_notifications.Controls.Add(Me.lbl_notify)
        Me.panel_notifications.Controls.Add(Me.panel_notifications_clearnotifications)
        Me.panel_notifications.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_notifications.ForeColor = System.Drawing.Color.White
        Me.panel_notifications.Location = New System.Drawing.Point(131, 65)
        Me.panel_notifications.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_notifications.Name = "panel_notifications"
        Me.panel_notifications.Size = New System.Drawing.Size(499, 382)
        Me.panel_notifications.TabIndex = 60
        Me.panel_notifications.Visible = False
        '
        'lbl_notify
        '
        Me.lbl_notify.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lbl_notify.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_notify.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notify.ForeColor = System.Drawing.Color.White
        Me.lbl_notify.Location = New System.Drawing.Point(13, 14)
        Me.lbl_notify.Multiline = True
        Me.lbl_notify.Name = "lbl_notify"
        Me.lbl_notify.ReadOnly = True
        Me.lbl_notify.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lbl_notify.Size = New System.Drawing.Size(472, 297)
        Me.lbl_notify.TabIndex = 56
        Me.lbl_notify.Text = "No notifications to show!"
        '
        'panel_notifications_clearnotifications
        '
        Me.panel_notifications_clearnotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel_notifications_clearnotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.panel_notifications_clearnotifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel_notifications_clearnotifications.FlatAppearance.BorderSize = 0
        Me.panel_notifications_clearnotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.panel_notifications_clearnotifications.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_notifications_clearnotifications.ForeColor = System.Drawing.Color.White
        Me.panel_notifications_clearnotifications.Location = New System.Drawing.Point(149, 332)
        Me.panel_notifications_clearnotifications.Name = "panel_notifications_clearnotifications"
        Me.panel_notifications_clearnotifications.Size = New System.Drawing.Size(200, 35)
        Me.panel_notifications_clearnotifications.TabIndex = 55
        Me.panel_notifications_clearnotifications.Text = "Clear Notifications"
        Me.panel_notifications_clearnotifications.UseVisualStyleBackColor = False
        '
        'lbl_notifications
        '
        Me.lbl_notifications.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notifications.ForeColor = System.Drawing.Color.White
        Me.lbl_notifications.Location = New System.Drawing.Point(127, 34)
        Me.lbl_notifications.Name = "lbl_notifications"
        Me.lbl_notifications.Size = New System.Drawing.Size(499, 23)
        Me.lbl_notifications.TabIndex = 66
        Me.lbl_notifications.Text = "Notifications"
        Me.lbl_notifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'data_timer
        '
        Me.data_timer.Enabled = True
        Me.data_timer.Interval = 5000
        '
        'frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 451)
        Me.Controls.Add(Me.lbl_start)
        Me.Controls.Add(Me.panel_start)
        Me.Controls.Add(Me.panel_notifications)
        Me.Controls.Add(Me.panel_roomchange)
        Me.Controls.Add(Me.btn_notifications)
        Me.Controls.Add(Me.btn_sync)
        Me.Controls.Add(Me.lbl_requestcover)
        Me.Controls.Add(Me.lbl_roomchange)
        Me.Controls.Add(Me.lbl_myrequests)
        Me.Controls.Add(Me.panel_facultyarea)
        Me.Controls.Add(Me.lbl_facultyarea)
        Me.Controls.Add(Me.panel_myrequests)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_requestcover)
        Me.Controls.Add(Me.btn_roomchange)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_facultyarea)
        Me.Controls.Add(Me.btn_myrequests)
        Me.Controls.Add(Me.btn_userinterface)
        Me.Controls.Add(Me.btn_accountdetails)
        Me.Controls.Add(Me.panel_requestcover)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.lbl_notifications)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_home"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ridgeway Cover Manager"
        Me.panel_requestcover.ResumeLayout(False)
        Me.panel_requestcover.PerformLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_start.ResumeLayout(False)
        Me.panel_start.PerformLayout()
        Me.panel_roomchange.ResumeLayout(False)
        Me.panel_roomchange.PerformLayout()
        Me.panel_myrequests.ResumeLayout(False)
        Me.panel_myrequests.PerformLayout()
        CType(Me.myrequests_btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.myrequests_tc_myrequests.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dg_mycovers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dg_myroomchanges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_sync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_facultyarea.ResumeLayout(False)
        Me.panel_facultyarea.PerformLayout()
        CType(Me.dg_viewrequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.nfimenu.ResumeLayout(False)
        Me.panel_notifications.ResumeLayout(False)
        Me.panel_notifications.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_roomchange As System.Windows.Forms.Button
    Friend WithEvents btn_facultyarea As System.Windows.Forms.Button
    Friend WithEvents btn_myrequests As System.Windows.Forms.Button
    Friend WithEvents panel_requestcover As System.Windows.Forms.Panel
    Friend WithEvents btn_requestcover As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_userinterface As System.Windows.Forms.Button
    Friend WithEvents btn_accountdetails As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents requestcover_txt_facultyhead As System.Windows.Forms.ComboBox
    Friend WithEvents requestcover_txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents requestcover_dp_enddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents requestcover_txt_endperiod As System.Windows.Forms.ComboBox
    Friend WithEvents requestcover_dp_startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents requestcover_chk_thislessononly As System.Windows.Forms.CheckBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents requestcover_txt_startperiod As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents panel_start As System.Windows.Forms.Panel
    Friend WithEvents panel_roomchange As System.Windows.Forms.Panel
    Friend WithEvents roomchange_txt_room As System.Windows.Forms.TextBox
    Friend WithEvents roomchange_txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents roomchange_dp_startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents roomchange_dp_enddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents roomchange_txt_endperiod As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents roomchange_btn_submit As System.Windows.Forms.Button
    Friend WithEvents roomchange_chk_thislessononly As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents roomchange_txt_startperiod As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_welcome As System.Windows.Forms.Label
    Friend WithEvents lbl_currentuser As System.Windows.Forms.Label
    Friend WithEvents txt_logout As System.Windows.Forms.LinkLabel
    Friend WithEvents panel_myrequests As System.Windows.Forms.Panel
    Friend WithEvents myrequests_tc_myrequests As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dg_mycovers As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dg_myroomchanges As System.Windows.Forms.DataGridView
    Friend WithEvents btn_sync As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents myrequests_btn_cancel As System.Windows.Forms.PictureBox
    Friend WithEvents panel_facultyarea As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents facultyarea_dp_enddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents facultyarea_txt_endperiod As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents facultyarea_txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents facultyarea_dp_startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_thislessononly As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents facultyarea_txt_startperiod As System.Windows.Forms.ComboBox
    Friend WithEvents dg_viewrequests As System.Windows.Forms.DataGridView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents facultyarea_btn_reject As System.Windows.Forms.Button
    Friend WithEvents facultyarea_btn_approve As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nfimenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nfi As System.Windows.Forms.NotifyIcon
    Friend WithEvents lbl_facultyarea As System.Windows.Forms.Label
    Friend WithEvents lbl_myrequests As System.Windows.Forms.Label
    Friend WithEvents lbl_requestcover As System.Windows.Forms.Label
    Friend WithEvents lbl_roomchange As System.Windows.Forms.Label
    Friend WithEvents lbl_start As System.Windows.Forms.Label
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaunchAdminCentreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaunchCoverManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpDocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubmitABugReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_notifications As System.Windows.Forms.Button
    Friend WithEvents panel_notifications As System.Windows.Forms.Panel
    Friend WithEvents lbl_notifications As System.Windows.Forms.Label
    Friend WithEvents lbl_connectionstate As System.Windows.Forms.Label
    Friend WithEvents panel_notifications_clearnotifications As System.Windows.Forms.Button
    Friend WithEvents lbl_notify As System.Windows.Forms.TextBox
    Friend WithEvents data_timer As System.Windows.Forms.Timer
End Class
