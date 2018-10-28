Imports System.Data.SqlClient
Imports System.Data
Module connection
    Public cnnstr As New SqlConnection
    Public issuecommand As New SqlCommand
    Public usertype, uname, eid, dept As String
    Public eimage As Image
    Public picsel As String
    Public eda, ehra, epf
    Public rpt, rpt1, rpt2, rpt3, rpt4, rpt5, rpt6, rpt7, rpt8
    Public Sub connect()
        cnnstr.ConnectionString = "data source= PUNITH\SQLEXPRESS;Initial catalog=rajfishmeal; Integrated security=true"
        cnnstr.Open()
        issuecommand.Connection = cnnstr
    End Sub
End Module
