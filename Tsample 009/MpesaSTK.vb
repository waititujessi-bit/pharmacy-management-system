Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class MpesaSTK
    Private Const ConsumerKey As String = "lbw2LmGD4YBKotAsRJY4LG3GXLW0rlmdflUatTmgXgz2dL2EHI"
    Private Const ConsumerSecret As String = "RRKHC7DsiJbmrTTmdckc9BUJcNOOAnR4MRuUGskmdAPN8BbzPZi3aj07WmvwUuor7"
    Private Const BusinessShortCode As String = "174379"
    Private Const PassKey As String = "bfb279f9aa9bdbcf158e97dd71a467cd2e0c893059b10f78e6b72ada1ed2c919"
    Private Const CallBackURL As String = "https://example.com"

    Public Shared Function GetAccessToken() As String
        ' FORCE TLS 1.2 using number code
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

        Dim credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(ConsumerKey & ":" & ConsumerSecret))
        Dim request = WebRequest.Create("https://sandbox.safaricom.co.ke/oauth/v1/generate?grant_type=client_credentials")
        request.Headers.Add("Authorization", "Basic " & credentials)
        Dim response = request.GetResponse()
        Dim reader = New StreamReader(response.GetResponseStream())
        Dim json = reader.ReadToEnd()
        Return Regex.Match(json, """access_token"":""(.*?)""").Groups(1).Value
    End Function

    Public Shared Function SendSTKPush(phone As String, amount As String, accountRef As String) As String
        ' FORCE TLS 1.2 using number code
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

        Dim token = GetAccessToken()
        Dim timestamp = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim password = Convert.ToBase64String(Encoding.UTF8.GetBytes(BusinessShortCode & PassKey & timestamp))

        If phone.StartsWith("0") Then phone = "254" & phone.Substring(1)

        Dim jsonPayload = "{" & _
            """BusinessShortCode"":""" & BusinessShortCode & """," & _
            """Password"":""" & password & """," & _
            """Timestamp"":""" & timestamp & """," & _
            """TransactionType"":""CustomerPayBillOnline""," & _
            """Amount"":""" & amount & """," & _
            """PartyA"":""" & phone & """," & _
            """PartyB"":""" & BusinessShortCode & """," & _
            """PhoneNumber"":""" & phone & """," & _
            """CallBackURL"":""" & CallBackURL & """," & _
            """AccountReference"":""" & accountRef & """," & _
            """TransactionDesc"":""POS Payment""}"

        Dim request = WebRequest.Create("https://sandbox.safaricom.co.ke/mpesa/stkpush/v1/processrequest")
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("Authorization", "Bearer " & token)

        Dim writer = New StreamWriter(request.GetRequestStream())
        writer.Write(jsonPayload)
        writer.Close()

        Dim response = request.GetResponse()
        Dim reader = New StreamReader(response.GetResponseStream())
        Return reader.ReadToEnd()
    End Function
End Class