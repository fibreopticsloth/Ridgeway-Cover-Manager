Imports System
Imports System.Drawing.Text
Imports System.Text
Imports System.Security.Cryptography
Module general

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
End Module
