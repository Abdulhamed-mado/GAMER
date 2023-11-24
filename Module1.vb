Imports System.Data.SqlClient

Module Module1

    'Dim s1 As String = "Server=" & My.Computer.Name & ";Initial Catalog=Karate;Integrated Security=True"
    Dim s1 As String = "Server=DESKTOP-EDI2GIR;Database=GAMER;Trusted_Connection=True;"
    Public cn1 As New SqlConnection(s1)
    Public sx As String
    Public wallet As Double = 0

    Public Sub findWalletBalance()
        Dim com As New SqlCommand("select sum(trans_amount) from wallet ", cn1)

        Try
            If cn1.State = ConnectionState.Open Then cn1.Close()

            cn1.Open()
            Dim myreder As SqlDataReader = com.ExecuteReader()
            myreder.Read()

            Form1.TextBox1.Text = myreder.Item(0).ToString
            If Form1.TextBox1.Text <> "" Then
                wallet = Convert.ToDouble(myreder.Item(0).ToString)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try




        cn1.Close()
    End Sub

End Module
