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
        Me.dg_roomchanges = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_booked = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_booked_2 = New System.Windows.Forms.Button()
        Me.btn_booked2 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btn_booked_3 = New System.Windows.Forms.Button()
        Me.btn_booked3 = New System.Windows.Forms.Button()
        Me.dg_external = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tt_back = New System.Windows.Forms.ToolTip(Me.components)
        Me.tt_update = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_update = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dg_covers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_roomchanges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dg_external, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.dg_covers.Size = New System.Drawing.Size(526, 277)
        Me.dg_covers.TabIndex = 0
        '
        'dg_roomchanges
        '
        Me.dg_roomchanges.AllowUserToAddRows = False
        Me.dg_roomchanges.AllowUserToDeleteRows = False
        Me.dg_roomchanges.AllowUserToResizeColumns = False
        Me.dg_roomchanges.AllowUserToResizeRows = False
        Me.dg_roomchanges.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_roomchanges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_roomchanges.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_roomchanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_roomchanges.Location = New System.Drawing.Point(3, 3)
        Me.dg_roomchanges.Name = "dg_roomchanges"
        Me.dg_roomchanges.ReadOnly = True
        Me.dg_roomchanges.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_roomchanges.RowHeadersVisible = False
        Me.dg_roomchanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_roomchanges.Size = New System.Drawing.Size(526, 277)
        Me.dg_roomchanges.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(10, 58)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(540, 368)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dg_covers)
        Me.TabPage1.Controls.Add(Me.btn_booked)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(532, 342)
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
        Me.btn_booked.Location = New System.Drawing.Point(408, 295)
        Me.btn_booked.Name = "btn_booked"
        Me.btn_booked.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked.TabIndex = 4
        Me.btn_booked.Text = "Mark as Booked"
        Me.btn_booked.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_booked_2)
        Me.TabPage2.Controls.Add(Me.btn_booked2)
        Me.TabPage2.Controls.Add(Me.dg_roomchanges)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(532, 342)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Room Changes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_booked_2
        '
        Me.btn_booked_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_booked_2.AutoSize = True
        Me.btn_booked_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_booked_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_booked_2.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_booked_2.FlatAppearance.BorderSize = 0
        Me.btn_booked_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_booked_2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_booked_2.ForeColor = System.Drawing.Color.White
        Me.btn_booked_2.Location = New System.Drawing.Point(408, 295)
        Me.btn_booked_2.Name = "btn_booked_2"
        Me.btn_booked_2.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked_2.TabIndex = 6
        Me.btn_booked_2.Text = "Mark as Booked"
        Me.btn_booked_2.UseVisualStyleBackColor = False
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
        Me.btn_booked2.Location = New System.Drawing.Point(252, 873)
        Me.btn_booked2.Name = "btn_booked2"
        Me.btn_booked2.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked2.TabIndex = 5
        Me.btn_booked2.Text = "Mark as Booked"
        Me.btn_booked2.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btn_booked_3)
        Me.TabPage4.Controls.Add(Me.btn_booked3)
        Me.TabPage4.Controls.Add(Me.dg_external)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(532, 342)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "External"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btn_booked_3
        '
        Me.btn_booked_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_booked_3.AutoSize = True
        Me.btn_booked_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_booked_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_booked_3.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText
        Me.btn_booked_3.FlatAppearance.BorderSize = 0
        Me.btn_booked_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_booked_3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_booked_3.ForeColor = System.Drawing.Color.White
        Me.btn_booked_3.Location = New System.Drawing.Point(408, 295)
        Me.btn_booked_3.Name = "btn_booked_3"
        Me.btn_booked_3.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked_3.TabIndex = 7
        Me.btn_booked_3.Text = "Mark as Booked"
        Me.btn_booked_3.UseVisualStyleBackColor = False
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
        Me.btn_booked3.Location = New System.Drawing.Point(252, 873)
        Me.btn_booked3.Name = "btn_booked3"
        Me.btn_booked3.Size = New System.Drawing.Size(120, 35)
        Me.btn_booked3.TabIndex = 6
        Me.btn_booked3.Text = "Mark as Booked"
        Me.btn_booked3.UseVisualStyleBackColor = False
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
        Me.dg_external.Size = New System.Drawing.Size(526, 277)
        Me.dg_external.TabIndex = 1
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
        Me.btn_update.Location = New System.Drawing.Point(12, 9)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(29, 21)
        Me.btn_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_update.TabIndex = 53
        Me.btn_update.TabStop = False
        Me.tt_update.SetToolTip(Me.btn_update, "Update the records in this form")
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(209, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Cover Management Area"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 7)
        Me.Panel1.TabIndex = 84
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_update)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel2.Size = New System.Drawing.Size(559, 40)
        Me.Panel2.TabIndex = 83
        '
        'frm_covermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(559, 436)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(290, 225)
        Me.Name = "frm_covermanagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Area"
        CType(Me.dg_covers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_roomchanges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dg_external, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_covers As System.Windows.Forms.DataGridView
    Friend WithEvents dg_roomchanges As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_booked As System.Windows.Forms.Button
    Friend WithEvents tt_back As System.Windows.Forms.ToolTip
    Friend WithEvents tt_update As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.PictureBox
    Friend WithEvents btn_booked2 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dg_external As System.Windows.Forms.DataGridView
    Friend WithEvents btn_booked3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_booked_2 As System.Windows.Forms.Button
    Friend WithEvents btn_booked_3 As System.Windows.Forms.Button
End Class
