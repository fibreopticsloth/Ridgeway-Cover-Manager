<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_covermanagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_covermanagement))
        Me.dg_covers = New System.Windows.Forms.DataGridView()
        Me.dg_rooms = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_booked = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_booked2 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_custom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_customcount = New System.Windows.Forms.Button()
        Me.lbl_next1 = New System.Windows.Forms.Label()
        Me.lbl_next2 = New System.Windows.Forms.Label()
        Me.lbl_next3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_tomorrow = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_today = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tt_back = New System.Windows.Forms.ToolTip(Me.components)
        Me.tt_update = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_update = New System.Windows.Forms.PictureBox()
        Me.panel_sidebar = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dg_external = New System.Windows.Forms.DataGridView()
        Me.btn_booked3 = New System.Windows.Forms.Button()
        CType(Me.dg_covers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_rooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_sidebar.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dg_external, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_covers
        '
        Me.dg_covers.AllowUserToAddRows = False
        Me.dg_covers.AllowUserToDeleteRows = False
        Me.dg_covers.AllowUserToResizeColumns = False
        Me.dg_covers.AllowUserToResizeRows = False
        Me.dg_covers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_covers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_covers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_covers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_covers.Location = New System.Drawing.Point(3, 3)
        Me.dg_covers.Name = "dg_covers"
        Me.dg_covers.ReadOnly = True
        Me.dg_covers.RowHeadersVisible = False
        Me.dg_covers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_covers.Size = New System.Drawing.Size(370, 347)
        Me.dg_covers.TabIndex = 0
        '
        'dg_rooms
        '
        Me.dg_rooms.AllowUserToAddRows = False
        Me.dg_rooms.AllowUserToDeleteRows = False
        Me.dg_rooms.AllowUserToResizeColumns = False
        Me.dg_rooms.AllowUserToResizeRows = False
        Me.dg_rooms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_rooms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_rooms.Location = New System.Drawing.Point(3, 3)
        Me.dg_rooms.Name = "dg_rooms"
        Me.dg_rooms.ReadOnly = True
        Me.dg_rooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_rooms.RowHeadersVisible = False
        Me.dg_rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_rooms.Size = New System.Drawing.Size(370, 347)
        Me.dg_rooms.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 34)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 438)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dg_covers)
        Me.TabPage1.Controls.Add(Me.btn_booked)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 412)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cover Requests"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_booked
        '
        Me.btn_booked.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_booked.AutoSize = True
        Me.btn_booked.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_booked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_booked.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_booked.FlatAppearance.BorderSize = 0
        Me.btn_booked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_booked.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_booked.ForeColor = System.Drawing.Color.White
        Me.btn_booked.Location = New System.Drawing.Point(252, 365)
        Me.btn_booked.Name = "btn_booked"
        Me.btn_booked.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked.TabIndex = 4
        Me.btn_booked.Text = "Mark as Booked"
        Me.btn_booked.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_booked2)
        Me.TabPage2.Controls.Add(Me.dg_rooms)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 412)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Room Changes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_booked2
        '
        Me.btn_booked2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_booked2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_booked2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_booked2.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_booked2.FlatAppearance.BorderSize = 0
        Me.btn_booked2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_booked2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.btn_booked2.ForeColor = System.Drawing.Color.White
        Me.btn_booked2.Location = New System.Drawing.Point(252, 365)
        Me.btn_booked2.Name = "btn_booked2"
        Me.btn_booked2.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked2.TabIndex = 5
        Me.btn_booked2.Text = "Mark as Booked"
        Me.btn_booked2.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.txt_custom)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.btn_customcount)
        Me.TabPage3.Controls.Add(Me.lbl_next1)
        Me.TabPage3.Controls.Add(Me.lbl_next2)
        Me.TabPage3.Controls.Add(Me.lbl_next3)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.lbl_tomorrow)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.lbl_today)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(376, 412)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stats"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(159, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(207, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "THIS AREA IS STILL IN DEVELOPMENT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_custom
        '
        Me.txt_custom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custom.Location = New System.Drawing.Point(141, 117)
        Me.txt_custom.Name = "txt_custom"
        Me.txt_custom.Size = New System.Drawing.Size(34, 23)
        Me.txt_custom.TabIndex = 72
        Me.txt_custom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Upcoming Cover Count:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_customcount
        '
        Me.btn_customcount.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_customcount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customcount.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_customcount.FlatAppearance.BorderSize = 0
        Me.btn_customcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customcount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customcount.ForeColor = System.Drawing.Color.White
        Me.btn_customcount.Location = New System.Drawing.Point(110, 89)
        Me.btn_customcount.Name = "btn_customcount"
        Me.btn_customcount.Size = New System.Drawing.Size(98, 22)
        Me.btn_customcount.TabIndex = 69
        Me.btn_customcount.Text = "Get Count"
        Me.btn_customcount.UseVisualStyleBackColor = False
        '
        'lbl_next1
        '
        Me.lbl_next1.AutoSize = True
        Me.lbl_next1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_next1.Location = New System.Drawing.Point(32, 74)
        Me.lbl_next1.Name = "lbl_next1"
        Me.lbl_next1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_next1.Size = New System.Drawing.Size(35, 15)
        Me.lbl_next1.TabIndex = 68
        Me.lbl_next1.Text = "next1"
        Me.lbl_next1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_next2
        '
        Me.lbl_next2.AutoSize = True
        Me.lbl_next2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_next2.Location = New System.Drawing.Point(34, 89)
        Me.lbl_next2.Name = "lbl_next2"
        Me.lbl_next2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_next2.Size = New System.Drawing.Size(35, 15)
        Me.lbl_next2.TabIndex = 67
        Me.lbl_next2.Text = "next2"
        Me.lbl_next2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_next3
        '
        Me.lbl_next3.AutoSize = True
        Me.lbl_next3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_next3.Location = New System.Drawing.Point(34, 104)
        Me.lbl_next3.Name = "lbl_next3"
        Me.lbl_next3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_next3.Size = New System.Drawing.Size(35, 15)
        Me.lbl_next3.TabIndex = 66
        Me.lbl_next3.Text = "next3"
        Me.lbl_next3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Custom Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_tomorrow
        '
        Me.lbl_tomorrow.AutoSize = True
        Me.lbl_tomorrow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tomorrow.Location = New System.Drawing.Point(11, 59)
        Me.lbl_tomorrow.Name = "lbl_tomorrow"
        Me.lbl_tomorrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_tomorrow.Size = New System.Drawing.Size(60, 15)
        Me.lbl_tomorrow.TabIndex = 64
        Me.lbl_tomorrow.Text = "tomorrow"
        Me.lbl_tomorrow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(110, 60)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 23)
        Me.DateTimePicker1.TabIndex = 63
        '
        'lbl_today
        '
        Me.lbl_today.AutoSize = True
        Me.lbl_today.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_today.Location = New System.Drawing.Point(32, 44)
        Me.lbl_today.Name = "lbl_today"
        Me.lbl_today.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_today.Size = New System.Drawing.Size(37, 15)
        Me.lbl_today.TabIndex = 62
        Me.lbl_today.Text = "today"
        Me.lbl_today.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tt_back
        '
        Me.tt_back.ToolTipTitle = "Back"
        '
        'tt_update
        '
        Me.tt_update.ToolTipTitle = "Update"
        '
        'btn_update
        '
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.sync
        Me.btn_update.Location = New System.Drawing.Point(3, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(29, 21)
        Me.btn_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_update.TabIndex = 53
        Me.btn_update.TabStop = False
        Me.tt_update.SetToolTip(Me.btn_update, "Update the records in this form")
        '
        'panel_sidebar
        '
        Me.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.panel_sidebar.Controls.Add(Me.btn_update)
        Me.panel_sidebar.Controls.Add(Me.Label3)
        Me.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_sidebar.Location = New System.Drawing.Point(0, 0)
        Me.panel_sidebar.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_sidebar.Name = "panel_sidebar"
        Me.panel_sidebar.Padding = New System.Windows.Forms.Padding(7)
        Me.panel_sidebar.Size = New System.Drawing.Size(384, 31)
        Me.panel_sidebar.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 26)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Cover Management Area"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btn_booked3)
        Me.TabPage4.Controls.Add(Me.dg_external)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(376, 412)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "External"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dg_external
        '
        Me.dg_external.AllowUserToAddRows = False
        Me.dg_external.AllowUserToDeleteRows = False
        Me.dg_external.AllowUserToResizeColumns = False
        Me.dg_external.AllowUserToResizeRows = False
        Me.dg_external.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_external.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_external.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_external.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_external.Location = New System.Drawing.Point(3, 3)
        Me.dg_external.Name = "dg_external"
        Me.dg_external.ReadOnly = True
        Me.dg_external.RowHeadersVisible = False
        Me.dg_external.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_external.Size = New System.Drawing.Size(370, 347)
        Me.dg_external.TabIndex = 1
        '
        'btn_booked3
        '
        Me.btn_booked3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_booked3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_booked3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_booked3.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_booked3.FlatAppearance.BorderSize = 0
        Me.btn_booked3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_booked3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.btn_booked3.ForeColor = System.Drawing.Color.White
        Me.btn_booked3.Location = New System.Drawing.Point(252, 365)
        Me.btn_booked3.Name = "btn_booked3"
        Me.btn_booked3.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked3.TabIndex = 6
        Me.btn_booked3.Text = "Mark as Booked"
        Me.btn_booked3.UseVisualStyleBackColor = False
        '
        'frm_covermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(384, 472)
        Me.Controls.Add(Me.panel_sidebar)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(290, 225)
        Me.Name = "frm_covermanagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Area"
        CType(Me.dg_covers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_rooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_sidebar.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dg_external, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_covers As System.Windows.Forms.DataGridView
    Friend WithEvents dg_rooms As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_booked As System.Windows.Forms.Button
    Friend WithEvents tt_back As System.Windows.Forms.ToolTip
    Friend WithEvents tt_update As System.Windows.Forms.ToolTip
    Friend WithEvents panel_sidebar As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_today As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_tomorrow As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_next1 As System.Windows.Forms.Label
    Friend WithEvents lbl_next2 As System.Windows.Forms.Label
    Friend WithEvents lbl_next3 As System.Windows.Forms.Label
    Friend WithEvents btn_booked2 As System.Windows.Forms.Button
    Friend WithEvents btn_customcount As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_custom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dg_external As System.Windows.Forms.DataGridView
    Friend WithEvents btn_booked3 As System.Windows.Forms.Button
End Class
