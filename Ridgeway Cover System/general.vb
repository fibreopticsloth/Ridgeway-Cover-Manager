Imports System
Imports System.Drawing.Text
Imports System.Text
Imports System.Security.Cryptography
Module general

    'DECLARATIONS
    Public pfc As New PrivateFontCollection
    Public ff() As FontFamily

    'MD5 HASH
    Public Function hash(ByVal password As String) As String
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytes() As Byte = md5.ComputeHash(Encoding.ASCII.GetBytes(password))
        Dim s As String = ""
        For Each by As Byte In bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function

    'CUSTOM FONT
    Public Sub customfont()

        'My.Computer.FileSystem.MoveFile("OpenSans-Light.ttf", "C:\Windows\Fonts")

        ''Dim pfc As PrivateFontCollection = New PrivateFontCollection
        ''pfc.AddFontFile("OpenSans-Light.ttf")
        ''pfc.AddFontFile("OpenSans-Semibold.ttf")
        ''pfc.AddFontFile("Candara.ttf")

        ''For Each ctrl As Control In frm_home.Controls

        ''    If Not ctrl.Font.IsSystemFont Then

        ''        Dim fontfamily As String = ctrl.Font.OriginalFontName.ToString
        ''        Dim fontfamilyint As Integer = 1

        ''        Select Case fontfamily
        ''            Case "Open Sans Light"
        ''                fontfamilyint = 1
        ''            Case "Open Sans Semibold"
        ''                fontfamilyint = 2
        ''            Case "Candara"
        ''                fontfamilyint = 0
        ''        End Select



        ''        'Dim fontsize As Integer = ctrl.Font.Size

        ''        Dim font As New Font(pfc.Families(fontfamilyint), ctrl.Font.Size)

        ''        ctrl.Font = font
        ''        'MsgBox(ctrl.Font.ToString)
        ''    End If
        ''Next
    End Sub
End Module
