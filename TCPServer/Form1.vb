Imports System.Net
Imports System.Net.Sockets
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Form1
    Dim connection As New Connection
    Dim connectToServer As New ConnectToServer

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        If serverHostTextBox.Text = vbNullString Then
            MsgBox("Host cannot be empty")
        ElseIf serverPortTextBox.Text = vbNullString Or portTextBox.Text.Length > 5 Then
            MsgBox("Port format error")
        Else
            connection.connectServer(serverHostTextBox.Text, serverPortTextBox.Text)
        End If
    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        connection.stopServer()
    End Sub
    Private Sub sendButton_Click_1(sender As Object, e As EventArgs) Handles sendButton.Click

        If hostTextBox.Text = vbNullString Then
            MsgBox("Host cannot be empty")
        ElseIf portTextBox.Text = vbNullString Or portTextBox.Text.Length > 5 Then
            MsgBox("Port format error")
        ElseIf msgTextBox.Text = vbNullString Then
            MsgBox("Message cannot be empty")
        Else
            resTextBox.Text = connectToServer.Connect(hostTextBox.Text, portTextBox.Text, msgTextBox.Text)
        End If
    End Sub
    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        connection.stopServer()
    End Sub

    Private Sub number(sender As Object, e As KeyPressEventArgs) Handles portTextBox.KeyPress, serverPortTextBox.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub hostTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hostTextBox.KeyPress, serverHostTextBox.KeyPress
        Dim rgx As New Regex("[0-9/.]")
        If e.KeyChar <> ChrW(Keys.Back) Then
            If rgx.IsMatch(e.KeyChar) = False Then
                MsgBox("IP format error.")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub msgTextBox_TextChanged(sender As Object, e As EventArgs) Handles msgTextBox.TextChanged
        resTextBox.Text = " "
    End Sub
End Class

Public Class Connection
    Private server As TcpListener = Nothing
    Private serverThread As Thread = Nothing
    Private tcpOpen As Boolean = False

    Public Sub connectServer(host As [String], port As [String])
        Dim localAddr As IPAddress = IPAddress.Parse(host)
        Dim localPort As Int32 = Convert.ToInt32(port)

        server = New TcpListener(localAddr, port)
        serverThread = New Thread(AddressOf connect)
        serverThread.IsBackground = True
        serverThread.Start()
    End Sub

    Public Sub connect()
        Try
            ' Start listening for client requests.
            server.Start()
            Console.WriteLine("Connection successful")
            tcpOpen = True

            ' Buffer for reading data
            Dim bytes(1024) As Byte
            Dim data As String = Nothing

            ' Enter the listening loop.
            While True
                Console.Write("Waiting for a connection... ")

                ' Perform a blocking call to accept requests.
                ' You could also use server.AcceptSocket() here.
                Dim client As TcpClient = server.AcceptTcpClient()
                Console.WriteLine("Connected!")

                data = Nothing

                ' Get a stream object for reading and writing
                Dim stream As NetworkStream = client.GetStream()

                Dim i As Int32

                ' Loop to receive all the data sent by the client.
                i = stream.Read(bytes, 0, bytes.Length)
                While (i <> 0)
                    ' Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.Unicode.GetString(bytes, 0, i)
                    Console.WriteLine("Received: {0}", data)

                    ' Process the data sent by the client.
                    Dim msg As Byte() = System.Text.Encoding.Unicode.GetBytes("Server response: " + data)

                    ' Send back a response.
                    stream.Write(msg, 0, msg.Length)
                    MsgBox("Server get message: " + data)

                    i = stream.Read(bytes, 0, bytes.Length)

                End While

                ' Shutdown and end connection
                client.Close()
            End While
        Catch e As SocketException
            Console.WriteLine("SocketException: {0}", e)
            MsgBox(e.Message)
        Finally
            server.Stop()
        End Try
    End Sub

    Public Sub stopServer()
        If tcpOpen Then
            server.Stop()
            serverThread = Nothing
            'MsgBox("cannel")
        End If
    End Sub
End Class

Public Class ConnectToServer
    Public Function Connect(host As [String], port As [String], message As [String])
        Dim response As String = Nothing

        Try
            Dim client As New TcpClient(host, port)
            Dim data As [Byte]() = System.Text.Encoding.Unicode.GetBytes(message)
            Dim stream As NetworkStream = client.GetStream()

            ' Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length)

            Console.WriteLine("Sent: {0}", message)

            data = New [Byte](256) {}

            Dim responseData As [String] = [String].Empty

            ' Read the first batch of the TcpServer response bytes.
            Dim bytes As Int32 = stream.Read(data, 0, data.Length)
            responseData = System.Text.Encoding.Unicode.GetString(data, 0, bytes)
            Console.WriteLine("Received: {0}", responseData)
            response = responseData.ToString

            ' Close everything.
            stream.Close()
            client.Close()
        Catch e As ArgumentNullException
            Console.WriteLine("ArgumentNullException: {0}", e)
            MsgBox(e.Message)
        Catch e As SocketException
            Console.WriteLine("SocketException: {0}", e)
            MsgBox(e.Message)
        End Try

        Console.WriteLine(ControlChars.Cr + " Press Enter to continue...")
        Console.Read()

        Return response
    End Function
End Class
