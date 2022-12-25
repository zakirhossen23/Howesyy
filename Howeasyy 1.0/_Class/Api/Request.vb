Imports System.Net
Imports System.Net.HttpWebResponse
Imports Mysqlx.XDevAPI.Common
Imports Newtonsoft.Json
Public Class Request
    Public Shared GetUrl As String = "https://api.howeasyy.com/Get?sql="
    Public Shared PostUrl As String = "https://api.howeasyy.com/Post?sql="
    Public Shared SerializerSettings As JsonSerializerSettings = New JsonSerializerSettings()

    Public Shared Async Function GetJSONAsync(Of T)(ByVal query As Object, ByVal output As T) As Threading.Tasks.Task(Of Object)

        ' Optional: Specify request options
        Dim options = New Utils.WebRequest.Options With {
            .UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0",
            .Headers = New System.Net.WebHeaderCollection From {
                {"key", "value"}
            }
        }

        Dim response = Await Utils.WebRequest.GetAsync(GetUrl + query)
        Dim decoded = Linq.JArray.Parse(response.Body)
        Dim obj As Array = decoded.ToArray()
        Dim allRecords As New List(Of Dictionary(Of String, Object))
        For Each one As Linq.JToken In obj
            Dim allfields As Dictionary(Of String, Object) = one.ToObject(Of Dictionary(Of String, Object))
            allRecords.Add(allfields)
        Next

        SerializerSettings.Formatting = Formatting.None
        Dim jsonFormat = JsonConvert.SerializeObject(allRecords)
        Dim output2 = JsonConvert.DeserializeAnonymousType(jsonFormat, output, SerializerSettings)

        Return output2
    End Function
    Public Shared Async Function PostAsync(ByVal query As String) As Threading.Tasks.Task

        ' Optional: Specify request options
        Dim options = New Utils.WebRequest.Options With {
            .UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0",
            .Headers = New System.Net.WebHeaderCollection From {
                {"key", "value"}
            }
        }

        Dim response = Await Utils.WebRequest.GetAsync(PostUrl + query)
    End Function

    Public Shared Function InsertQueryMaker(ByVal tablename As String, ByVal allFields As Dictionary(Of String, Object)) As String

        Dim allKeys As New List(Of String)
        Dim allValues As New List(Of Object)
        For i = 0 To allFields.Keys.Count() - 1
            allKeys.Add($"`{allFields.Keys(i)}`")
        Next
        For i = 0 To allFields.Values.Count() - 1
            Dim value As Object = allFields.Values(i)
            If (allFields.Values(i).GetType() = GetType(String)) Then
                value = $"'{allFields.Values(i)}'"
            End If

            allValues.Add(value)
        Next

        Dim keysSQL = String.Join(",", allKeys.ToArray())
        Dim ValuesSQL = String.Join(",", allValues.ToArray())

        Dim sqlQuery As String = $"INSERT INTO `{tablename}` ({keysSQL}) VALUES ({ValuesSQL})"


        Return sqlQuery

    End Function

    Public Shared Function UpdateQueryMaker(ByVal tablename As String, ByVal allFields As Dictionary(Of String, Object), ByVal whereby As String, ByVal wherevalue As Object) As String

        Dim allKeys As New List(Of String)
        Dim allValues As New List(Of Object)
        For i = 0 To allFields.Values.Count() - 1
            Dim value As Object = allFields.Values(i)
            If (allFields.Values(i).GetType() = GetType(String)) Then
                value = $"'{allFields.Values(i)}'"
            End If

            allValues.Add(value)
        Next
        For i = 0 To allFields.Keys.Count() - 1
            allKeys.Add($"`{allFields.Keys(i)}`={allValues(i)}")
        Next

        Dim keysSQL = String.Join(", ", allKeys.ToArray())


        Dim sqlQuery As String = $"Update `{tablename}` set {keysSQL} where `{whereby}` = {wherevalue}"

        Return sqlQuery

    End Function

End Class
