Imports System.Data.OleDb
Imports System.Text.RegularExpressions
'Imports System.Data.OledbClient


Module Module1
    Public Fdate As Date
    Public Tdate As Date

    Public blnadd As Boolean
    Public blnupdate As Boolean

    Public CompDB As String

    'Public con As New OledbConnection("Provider=MICROSOFT.ACE.Oledb.12.0; Data Source=|DataDirectory|/database.accdb")
    Public rs As New OleDbDataAdapter

    'Public Function cnSettings() As String
    '    'Return "Data Source=akora\OledbEXPRESS;AttachDbFilename=|DataDirectory|\intel.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
    '    'Return "Data Source=.\SQLEXPRESS;Database=SHARPBOOKDB;Integrated Security=True;"
    '    'Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\MainDB.mdb;Persist Security Info=True"
    '    Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Philips\Database\MainDB.mdb;Persist Security Info=True"
    'End Function

    Function Oledbinjection(ByVal strValue, ByVal intLevel) As String

        '*** Written by user CWA, CoolWebAwards.com Forums. 2 February 2010
        '*** http://forum.coolwebawards.com/threads/11-Preventing-Oledb-injection-attacks-using-VB-NET

        ' intLevel represent how thorough the value will be checked for dangerous code
        ' intLevel (1) - Do just the basic. This level will already counter most of the Oledb injection attacks
        ' intLevel (2) - &nbsp; (non breaking space) will be added to most words used in Oledb queries to prevent unauthorized access to the database. Safe to be printed back into HTML code. Don't use for usernames or passwords

        If Not IsDBNull(strValue) Then
            If intLevel > 0 Then
                strValue = Replace(strValue, "'", "''") ' Most important one! This line alone can prevent most injection attacks
                strValue = Replace(strValue, "--", "")
                strValue = Replace(strValue, "[", "[[]")
                strValue = Replace(strValue, "%", "[%]")
            End If

            If intLevel > 1 Then
                Dim myArray As Array
                myArray = Split("xp_ ;update ;insert ;select ;drop ;alter ;create ;rename ;delete ;replace ", ";")
                Dim i, i2, intLenghtLeft As Integer
                For i = LBound(myArray) To UBound(myArray)
                    Dim rx As New Regex(myArray(i), RegexOptions.Compiled Or RegexOptions.IgnoreCase)
                    Dim matches As MatchCollection = rx.Matches(strValue)
                    i2 = 0
                    For Each match As Match In matches
                        Dim groups As GroupCollection = match.Groups
                        intLenghtLeft = groups.Item(0).Index + Len(myArray(i)) + i2
                        strValue = Left(strValue, intLenghtLeft - 1) & "&nbsp;" & Right(strValue, Len(strValue) - intLenghtLeft)
                        i2 += 5
                    Next
                Next
            End If

            'strValue = replace(strValue, ";", ";&nbsp;")
            'strValue = replace(strValue, "_", "[_]")

            Return strValue
        Else
            Return strValue
        End If

    End Function

    'Public Function getDataTable(ByVal SQL As String) As DataTable

    '    'checkConnection()
    '    Dim con As New OleDbConnection(cnSettings)
    '    Dim cmd As New OleDbCommand(SQL, con)
    '    Dim table As New DataTable
    '    Dim da As New OleDbDataAdapter(cmd)
    '    da.Fill(table)
    '    Return table

    'End Function

    'Public Function getDataReader(ByVal SQL As String) As OleDbDataReader
    '    'Dim dr As New OleDbDataReader
    '    'checkConnection()
    '    Dim con As New OleDbConnection(cnSettings)
    '    con.Open()
    '    Dim cmd As New OleDbCommand(SQL, con)
    '    Dim dr As OleDbDataReader
    '    dr = cmd.ExecuteReader
    '    Return dr
    '    con.Close()
    'End Function
End Module
