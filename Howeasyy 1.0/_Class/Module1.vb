Imports System.Data.Sql
Imports System.Data.OleDb
Module connection
    Public cur As Form
    Public dt As DataTable
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public sqL As String
    Public connStr As String = System.Environment.CurrentDirectory.ToString & "\sonarbangla.mdb"
    Dim con As OleDbConnection
    Public Function cnSettings() As String
        Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\sonarbangla.mdb;Persist Security Info=True"
    End Function
    Public Sub ConnDB()
        Try
            conn = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & connStr & "")
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Connection Failed")
        End Try
    End Sub
    'Public Sub checkConnection()

    '    If con Is Nothing OrElse con.State = ConnectionState.Closed Then
    '        createConnection()
    '    End If

    'End Sub

    Public Function getDataReader(ByVal SQL As String) As OleDbDataReader

        'checkConnection()
        Dim con As New OleDbConnection(cnSettings)
        con.Open()
        Dim cmd As New OleDbCommand(SQL, con)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Return dr
        con.Close()
    End Function

    Public Function getDataTable(ByVal SQL As String) As DataTable

        'checkConnection()
        Dim con As New OleDbConnection(cnSettings)
        con.Open()
        Dim cmd As New OleDbCommand(SQL, con)
        Dim table As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(table)
        Return table
        con.Close()
    End Function

    Public Sub executeQuery(ByVal SQL As String)
        'checkConnection()
        Dim con As New OleDbConnection(cnSettings)
        con.Open()
        Dim cmd As New OleDbCommand(SQL, con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Module


