Imports MySql.Data.MySqlClient
Imports System.Drawing.Text
Module MySQL_Connection

    'DECLARATIONS
    Public conn As MySqlConnection
    Public ConnectionString As String = "server=localhost;userid=root;password=admin;database=coversystem;pooling = false"
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public bs As BindingSource
    Dim rd As MySqlDataReader
    Dim connerror As Boolean = False

    'CHECK CONNECTION
    Public Function CheckConnection()

        Using Connection As New MySqlConnection(ConnectionString)

            Connection.Open()
            If Connection.State = ConnectionState.Open Then
                frm_home.Text = "Ridgeway Cover Manager"
                frm_home.lbl_connectionstate.Text = "Connected"
                frm_home.lbl_connectionstate.ForeColor = Color.Green
                Return 1
            Else
                frm_home.Text = "Ridgeway Cover Manager - NOT CONNECTED TO SERVER"
                frm_home.lbl_connectionstate.Text = "Could not connect"
                frm_home.lbl_connectionstate.ForeColor = Color.Red
                Return 0
            End If

            Connection.Close()
            Connection.Dispose()

        End Using

    End Function

    'NEW COMMAND
    Public Sub NewCommand(ByVal CmdText As String)

        Using Connection As New MySqlConnection(ConnectionString)

            With Connection.CreateCommand

                .Connection.Open()
                .CommandText = CmdText
                .CommandType = CommandType.Text
                .ExecuteNonQuery()

                Connection.Close()
                Connection.Dispose()
                .Dispose()

            End With

        End Using

    End Sub

    'NEW UPDATE COMMAND
    Public Function NewDataCommand(ByVal CmdText As String)

        Using Connection As New MySqlConnection(ConnectionString)

            With Connection.CreateCommand

                .Connection.Open()
                .CommandText = CmdText
                .CommandType = CommandType.Text

                Dim rd As MySqlDataReader
                rd = .ExecuteReader

                Return rd

                Connection.Close()
                Connection.Dispose()
                .Dispose()
                rd.Dispose()

            End With

        End Using

    End Function

    'NEW DATA COMMAND
    Public Function CheckData(ByVal CmdText As String)

        Using Connection As New MySqlConnection(ConnectionString)

            With Connection.CreateCommand

                .Connection.Open()
                .CommandText = CmdText
                .CommandType = CommandType.Text

                Dim rd As MySqlDataReader
                rd = .ExecuteReader

                While rd.Read
                    If rd.HasRows Then
                        Return 1
                    Else
                        Return 0
                    End If
                End While

                Connection.Close()
                Connection.Dispose()
                .Dispose()
                rd.Dispose()

            End With

        End Using

    End Function

    'NEW QUERY
    Public Sub NewQuery(ByVal CmdText As String, ByVal Table As DataGridView)

        Using Connection As New MySqlConnection(ConnectionString)

            Using da As New MySqlDataAdapter(CmdText, Connection)
                Dim ds As New DataSet
                da.Fill(ds, "Data")
                Table.DataSource = ds
                Table.DataMember = "Data"
                da.Dispose()
                ds.Dispose()
            End Using

        End Using

    End Sub

    'CONNECT TO DB
    'Public Sub connect()
    '    Try
    '        conn = New MySqlConnection
    '        'conn.ConnectionString = "server=dlp.ridgewayschool.com;userid=coversystem;password=dlop890;database=coversystem"
    '        conn.ConnectionString = "server=localhost;userid=root;password=admin;database=coversystem"
    '        conn.Open()
    '    Catch ex As Exception
    '        Dim path As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    '        Dim FILE_NAME As String = path & "\SET\errorlog.txt"
    '        If System.IO.File.Exists(FILE_NAME) = True Then
    '            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
    '            objWriter.WriteLine(DateTime.Now.ToString + " | " + ErrorToString())
    '            objWriter.Close()
    '        Else
    '            My.Computer.FileSystem.CreateDirectory(path & "\SET")
    '            Dim objWriter As IO.StreamWriter
    '            objWriter = IO.File.CreateText(FILE_NAME)
    '            objWriter.WriteLine(DateTime.Now.ToString + " | " + ErrorToString())
    '            objWriter.Close()
    '        End If
    '    End Try
    'End Sub
    
End Module
