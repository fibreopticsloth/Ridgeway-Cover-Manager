Imports MySql.Data.MySqlClient
Imports System.Drawing.Text
Module MySQL_Connection

    'DECLARATIONS
    Public conn As MySqlConnection

    'AT VARIOUS POINTS DURING DEVELOPMENT, DIFFERENT SERVERS HAVE BEEN USED - THEIR CONNECTION STRINGS CAN BE SWITCHED FROM HERE
    'Public ConnectionString As String = "server=georgedunk.co.uk;userid=rcm;password=dlop890;database=covermanager;pooling = false"
    Public ConnectionString As String = "server=localhost;userid=root;password=admin;database=coversystem;pooling = false"
    'Public ConnectionString As String = "server=dlp.ridgewayschool.com;userid=coversystem;password=dlop890;database=coversystem;pooling = false"

    Public cmd As MySqlCommand
    Public ds As DataSet
    Public bs As BindingSource
    Dim rd As MySqlDataReader
    Dim connerror As Boolean = False

    'CHECK CONNECTION
    Public Function CheckConnection()

        Using Connection As New MySqlConnection(ConnectionString)

            Try
                Connection.Open()
            Catch ex As Exception

            End Try

            If Connection.State = ConnectionState.Open Then
                frm_home.toolstrip_status.Text = "Connected"
                frm_home.toolstrip_status.ForeColor = Color.Green
                Return 1
            Else
                frm_home.toolstrip_status.Text = "Connection Error"
                frm_home.toolstrip_status.ForeColor = Color.Red
                Return 0
            End If

            Connection.Close()
            Connection.Dispose()

        End Using

    End Function

    'NEW COMMAND
    Public Sub NewCommand(ByVal CmdText As String)

        If CheckConnection() Then

            Using Connection As New MySqlConnection(ConnectionString)

                With Connection.CreateCommand

                    .Connection.Open()
                    .CommandText = CmdText
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()

                    Connection.Close()
                    Connection.Dispose()
                    .Dispose()

                    WriteToLog(CmdText)

                End With

            End Using

        End If

    End Sub

    'NEW UPDATE COMMAND
    Public Function NewDataCommand(ByVal CmdText As String)

        If CheckConnection() Then

            Using Connection As New MySqlConnection(ConnectionString)

                Connection.Open()
                Dim da As New MySqlDataAdapter(CmdText, Connection)
                Dim ds As New DataSet("Data")
                da.Fill(ds, "Data")
                Return ds

                ds.Reset()
                da.Dispose()
                Connection.Close()
                Connection.Dispose()

            End Using

        End If

    End Function

    'NEW DATA COMMAND
    Public Function CheckData(ByVal CmdText As String)

        If CheckConnection Then

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

        End If

    End Function

    'NEW QUERY
    Public Sub NewQuery(ByVal CmdText As String, ByVal Table As DataGridView)

        If CheckConnection Then

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

        End If

    End Sub

    'WRITE TO LOG
    Public Sub WriteToLog(statement)

        Dim path As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\RCM"
        Dim filename As String = path & "\log.txt"

        If System.IO.Directory.Exists(path) = False Then
            System.IO.Directory.CreateDirectory(path)
        End If

        If System.IO.File.Exists(filename) = False Then
            System.IO.File.Create(filename).Dispose()
        End If

        Dim objWriter As New System.IO.StreamWriter(filename, True)
        objWriter.WriteLine(DateTime.Now + " - " + My.Settings.CurrentUsername + " - " + statement)
        objWriter.WriteLine()
        objWriter.Close()

    End Sub
    
End Module
