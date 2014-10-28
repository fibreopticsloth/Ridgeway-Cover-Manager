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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_booked = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tt_back = New System.Windows.Forms.ToolTip(Me.components)
        Me.tt_update = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_update = New System.Windows.Forms.PictureBox()
        Me.panel_sidebar = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dg_covers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_rooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_covers
        '
        Me.dg_covers.AllowUserToAddRows = False
        Me.dg_covers.AllowUserToDeleteRows = False
        Me.dg_covers.AllowUserToResizeColumns = False
        Me.dg_covers.AllowUserToResizeRows = False
        Me.dg_covers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_covers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_covers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_covers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_covers.Location = New System.Drawing.Point(3, 3)
        Me.dg_covers.Name = "dg_covers"
        Me.dg_covers.ReadOnly = True
        Me.dg_covers.RowHeadersVisible = False
        Me.dg_covers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_covers.Size = New System.Drawing.Size(370, 335)
        Me.dg_covers.TabIndex = 0
        '
        'dg_rooms
        '
        Me.dg_rooms.AllowUserToAddRows = False
        Me.dg_rooms.AllowUserToDeleteRows = False
        Me.dg_rooms.AllowUserToResizeColumns = False
        Me.dg_rooms.AllowUserToResizeRows = False
        Me.dg_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_rooms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_rooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_rooms.Location = New System.Drawing.Point(3, 3)
        Me.dg_rooms.Name = "dg_rooms"
        Me.dg_rooms.ReadOnly = True
        Me.dg_rooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_rooms.RowHeadersVisible = False
        Me.dg_rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_rooms.Size = New System.Drawing.Size(370, 335)
        Me.dg_rooms.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 367)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dg_covers)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 341)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cover Requests"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dg_rooms)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 341)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Room Changes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_booked
        '
        Me.btn_booked.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_booked.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_booked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_booked.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_booked.FlatAppearance.BorderSize = 0
        Me.btn_booked.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_booked.ForeColor = System.Drawing.Color.Black
        Me.btn_booked.Location = New System.Drawing.Point(132, 427)
        Me.btn_booked.Name = "btn_booked"
        Me.btn_booked.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked.TabIndex = 4
        Me.btn_booked.Text = "Mark as Booked"
        Me.btn_booked.UseVisualStyleBackColor = False
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
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Image = Global.Ridgeway_Cover_Manager.My.Resources.Resources.update
        Me.btn_update.Location = New System.Drawing.Point(345, 7)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(35, 35)
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
        Me.panel_sidebar.Size = New System.Drawing.Size(384, 50)
        Me.panel_sidebar.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 26)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Cover Management Area"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_covermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(384, 472)
        Me.Controls.Add(Me.panel_sidebar)
        Me.Controls.Add(Me.btn_booked)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(290, 225)
        Me.Name = "frm_covermanagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Area"
        CType(Me.dg_covers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_rooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_sidebar.ResumeLayout(False)
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
End Class
