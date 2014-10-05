Imports MySql.Data.MySqlClient
Imports System.Drawing.Text
Module db

    'DECLARATIONS
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public bs As BindingSource
    Dim rd As MySqlDataReader
    Dim connerror As Boolean = False

    'CONNECT TO DB
    Public Sub connect()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=dlp.ridgewayschool.com;userid=coversystem;password=dlop890;database=coversystem"
            'conn.ConnectionString = "server=localhost;userid=root;password=admin;database=coversystem"
            conn.Open()
        Catch ex As Exception
        End Try
    End Sub

    'CHECK SQL CONNECTION
    Public Function checkconn()
        connect()
        If conn.State = ConnectionState.Open Then
            frm_home.Text = "Ridgeway Cover Manager"
            frm_home.lbl_connectionstate.Text = "Connected"
            frm_home.lbl_connectionstate.ForeColor = Color.LimeGreen
            Return 1
        Else
            frm_home.Text = "Ridgeway Cover Manager - NOT CONNECTED TO SERVER"
            frm_home.lbl_connectionstate.Text = "Could not connect"
            frm_home.lbl_connectionstate.ForeColor = Color.OrangeRed
            Return 0
        End If
    End Function

    'NEW COMMAND
    Public Sub newcmd(ByVal cmdtext As String)
        cmd = New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = cmdtext
    End Sub
End Module
