<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_notify
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
        Me.timerfadein = New System.Windows.Forms.Timer(Me.components)
        Me.timertimeout = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_notification = New System.Windows.Forms.TextBox()
        Me.panel_sidebar = New System.Windows.Forms.Panel()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerfadein
        '
        Me.timerfadein.Enabled = True
        Me.timerfadein.Interval = 10
        '
        'timertimeout
        '
        Me.timertimeout.Enabled = True
        Me.timertimeout.Interval = 7500
        '
        'lbl_notification
        '
        Me.lbl_notification.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_notification.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_notification.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notification.Location = New System.Drawing.Point(11, 45)
        Me.lbl_notification.Multiline = True
        Me.lbl_notification.Name = "lbl_notification"
        Me.lbl_notification.ReadOnly = True
        Me.lbl_notification.Size = New System.Drawing.Size(302, 40)
        Me.lbl_notification.TabIndex = 2
        Me.lbl_notification.TabStop = False
        Me.lbl_notification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panel_sidebar
        '
        Me.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.panel_sidebar.Controls.Add(Me.lbl_name)
        Me.panel_sidebar.Controls.Add(Me.PictureBox1)
        Me.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_sidebar.Location = New System.Drawing.Point(0, 0)
        Me.panel_sidebar.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_sidebar.Name = "panel_sidebar"
        Me.panel_sidebar.Size = New System.Drawing.Size(323, 35)
        Me.panel_sidebar.TabIndex = 45
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(124, 8)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(123, 19)
        Me.lbl_name.TabIndex = 54
        Me.lbl_name.Text = "New Notification"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ridgeway_Cover_System.My.Resources.Resources.schoollogo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_notify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(323, 92)
        Me.Controls.Add(Me.panel_sidebar)
        Me.Controls.Add(Me.lbl_notification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_notify"
        Me.ShowInTaskbar = False
        Me.Text = "frm_notify"
        Me.TopMost = True
        Me.panel_sidebar.ResumeLayout(False)
        Me.panel_sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerfadein As System.Windows.Forms.Timer
    Friend WithEvents timertimeout As System.Windows.Forms.Timer
    Friend WithEvents lbl_notification As System.Windows.Forms.TextBox
    Friend WithEvents panel_sidebar As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
End Class
