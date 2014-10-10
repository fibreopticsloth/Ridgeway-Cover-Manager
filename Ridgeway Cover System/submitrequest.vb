Imports MySql.Data.MySqlClient
Module submitrequest

    'DECLARATIONS
    Dim rd As MySqlDataReader
    Dim type As String
    Dim teacher As String
    Dim facultyhead As String
    Dim startdate As String
    Dim startperiod As String
    Dim enddate As String
    Dim endperiod As String
    Dim reason As String

    'RUN THROUGH THIS MODULE, PREPARING DATA FOR SUBMISSION, THEN SUBMIT IT
    Public Function submit(type_ As String, teacher_ As String, facultyhead_ As String, startdate_ As DateTimePicker, startperiod_ As String, enddate_ As DateTimePicker, endperiod_ As String, reason_ As String)
        getdata(type_, teacher_, facultyhead_, startdate_, startperiod_, enddate_, endperiod_, reason_)
        appendtime()
        If allfilled() = 1 And startbeforeend() = 1 And checkoverlap() = 1 Then
            sqlinsert()
            Return 1
        Else : Return 0
        End If
    End Function

    'GET THE DATA FROM THE REQUEST FORMS
    Public Sub getdata(type_ As String, teacher_ As String, facultyhead_ As String, startdate_ As DateTimePicker, startperiod_ As String, enddate_ As DateTimePicker, endperiod_ As String, reason_ As String)
        type = type_
        teacher = teacher_
        facultyhead = facultyhead_
        startdate_.CustomFormat = "yy'-'MM'-'dd"
        startdate = startdate_.Text
        startdate_.CustomFormat = "dd'-'MM'-'yy"
        startperiod = CInt(startperiod_)
        enddate_.CustomFormat = "yy'-'MM'-'dd"
        enddate = enddate_.Text
        enddate_.CustomFormat = "dd'-'MM'-'yy"
        If endperiod_ = "" Then
            endperiod = startperiod
            enddate = startdate
        Else
            endperiod = CInt(endperiod_)
        End If
        reason = reason_
    End Sub

    'CONVERT A PERIOD NUMBER TO A TIME
    Public Function periodtimes(lessonnum As Integer, type As String)
        If type = "start" Then
            Select Case lessonnum
                Case 1
                    Return "08:50:01"
                Case 2
                    Return "09:50:01"
                Case 3
                    Return "11:10:01"
                Case 4
                    Return "12:10:01"
                Case 5
                    Return "14:15:01"
                Case 6
                    Return "15:15:01"
                Case Else
                    Return "00:00:00"
            End Select
        ElseIf type = "end" Then
            Select Case lessonnum
                Case 1
                    Return "09:50:00"
                Case 2
                    Return "10:50:00"
                Case 3
                    Return "12:10:00"
                Case 4
                    Return "13:10:00"
                Case 5
                    Return "15:15:00"
                Case 6
                    Return "16:15:00"
                Case Else
                    Return "00:00:00"
            End Select
        Else
            Return "00:00:00"
        End If
    End Function

    'APPEND THE PERIOD TIME TO THE DATE TO GET A DATETIME VALUE
    Public Sub appendtime()
        startdate = startdate + " " + periodtimes(startperiod, "start")
        enddate = enddate + " " + periodtimes(endperiod, "end")
    End Sub

    'ENSURE ALL FIELDS WERE FILLED
    Public Function allfilled()
        Select Case endperiod
            Case startperiod
                If facultyhead = "" Or startdate = "" Or startperiod = "" Or reason = "" Then
                    MsgBox("You must fill all fields.")
                    Return 0
                Else : Return 1
                End If
            Case Else
                If facultyhead = "" Or startdate = "" Or startperiod = "" Or enddate = "" Or endperiod = "" Or reason = "" Then
                    MsgBox("You must fill all fields.")
                    Return 0
                Else : Return 1
                End If
        End Select

    End Function

    'ENSURE THE START DATE IS BEFORE THE END DATE
    Public Function startbeforeend()
        Dim start_ As DateTime = startdate
        Dim end_ As DateTime = enddate
        If start_ <= end_ Then
            Return 1
        Else
            MsgBox("The start date must be before the end date.")
            Return 0
        End If
    End Function

    'CHECK THERE IS NO OVERLAP WITH EXISTING REQUESTS
    Public Function checkoverlap()
        If type = "lesson" Then
            If CheckData("select * from lessons where startdate <= '" & enddate & "' and '" & startdate & "' <= enddate and teacher = '" & My.Settings.currentuser & "'") Then
                MsgBox("This overlaps an existing request.")
                Return 0
            Else
                Return 1
            End If
        ElseIf type = "room" Then
            If CheckData("select * from roomchange where startdate <= '" & enddate & "' and '" & startdate & "' <= enddate and teacher = '" & My.Settings.currentuser & "'") Then
                MsgBox("This overlaps an existing request.")
                Return 0
            Else
                Return 1
            End If
        Else
            Return 0
        End If
    End Function

    'INSERT THE DATA TO THE DATABASE
    Public Sub sqlinsert()
        If type = "lesson" Then
            NewCommand("INSERT into LESSONS(teacher, facultyhead, startdate, enddate, startperiod, endperiod, reason) VALUES('" & teacher & "', '" & facultyhead & "', '" & startdate & "', '" & enddate & "', '" & startperiod & "', '" & endperiod & "', '" & reason & "')")
        ElseIf type = "room" Then
            NewCommand("INSERT into ROOMCHANGE(teacher, startdate, enddate, startperiod, endperiod, reason) VALUES('" & teacher & "', '" & startdate & "', '" & enddate & "', '" & startperiod & "', '" & endperiod & "', '" & reason & "')")
        Else
        End If
    End Sub
End Module
