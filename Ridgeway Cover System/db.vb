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
            'conn.ConnectionString = "server=dlp.ridgewayschool.com;userid=coversystem;password=dlop890;database=coversystem"
            conn.ConnectionString = "server=localhost;userid=root;password=admin;database=coversystem"
            conn.Open()
        Catch ex As Exception
        End Try
    End Sub

    'CHECK SQL CONNECTION
    Public Function checkconn()
        connect()
        If conn.State = ConnectionState.Open Then
            Return 1
        Else : Return 0
        End If
    End Function

    'NEW COMMAND
    Public Sub newcmd(ByVal cmdtext As String)
        cmd = New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = cmdtext
    End Sub

    'GET DATA
    Public Sub newqry(ByVal cmdtext As String, ByVal table As DataGridView)
        Dim da As New MySqlDataAdapter(cmdtext, conn)
        Dim ds As New DataSet
        da.Fill(ds, "Data")
        table.DataSource = ds
        table.DataMember = "Data"
        ds.Dispose()
        da.Dispose()
    End Sub

    'GET ALL SOFTWARE DATA
    Public Sub getalldata()
        'MY REQUESTS - LESSONS
        Try
            newqry("select ID, StartDate, StartPeriod, EndDate, EndPeriod, Approved, Booked from lessons where teacher='" & My.Settings.currentuser & "'", frm_home.dg_mycovers)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
        'MY REQUESTS - ROOMS
        Try
            newqry("select ID, StartDate, StartPeriod, EndDate, EndPeriod, Booked from roomchange where teacher='" & My.Settings.currentuser & "'", frm_home.dg_myroomchanges)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
        'FACULTY AREA
        Try
            newqry("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Reason from lessons where facultyhead='" & My.Settings.currentuser & "' and approved = 'Pending'", frm_home.dg_viewrequests)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
        'COVER MANAGEMENT - LESSONS
        Try
            newqry("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Approved, Booked, Push from lessons where approved = 'approved' and booked = 'pending'", frm_covermanagement.dg_covers)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
        'COVER MANAGEMENT - ROOMS
        Try
            newqry("select ID, Teacher, StartDate, StartPeriod, EndDate, EndPeriod, Booked, Push from roomchange where booked = 'pending'", frm_covermanagement.dg_rooms)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
        'ADMIN - USERS
        Try
            newqry("select ID, username, type from users", frm_admin.dg_users)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database" + vbNewLine + "Please ensure you are connected to the internet")
        End Try
        frm_home.hidecolumns()
    End Sub
End Module
