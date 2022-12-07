Module Code_Encryption
    Private ReadOnly cryptoServiceProvider As Security.Cryptography.RNGCryptoServiceProvider

    Public Function HashString(str As String) As String
        Return EncryptString(str)
    End Function

    Public Function GenerateSalt() As String
        Using cryptoServiceProvider As New System.Security.Cryptography.RNGCryptoServiceProvider
            Dim sb As New System.Text.StringBuilder()
            Dim data As Byte() = New Byte(4) {}
            For i = 0 To 6
                cryptoServiceProvider.GetBytes(data)
                Dim value As String = BitConverter.ToString(data, 0)
                sb.Append(value)
            Next
            Return EncryptString(sb.ToString())
        End Using
    End Function

    Private Function EncryptString(str As String) As String
        Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)
        Dim hashed = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes)
        Return Convert.ToBase64String(hashed)
    End Function
End Module
