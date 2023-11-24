Imports System.Data.SqlClient

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        findWalletBalance()
    End Sub




    Sub findWalletBalance()
        Dim com As New SqlCommand("select sum(trans_amount) from wallet ", cn1)

        Try
            If cn1.State = ConnectionState.Open Then cn1.Close()

            cn1.Open()
            Dim myreder As SqlDataReader = com.ExecuteReader()
            myreder.Read()

            TextBox1.Text = myreder.Item(0).ToString
            If TextBox1.Text <> "" Then
                wallet = Convert.ToDouble(myreder.Item(0).ToString)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try




        cn1.Close()
    End Sub








    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MsgBox("هل تريد ملئ المحفظة", MsgBoxStyle.YesNo, "تأكيد")
        If result = DialogResult.Yes Then
            Dim s As String = InputBox("كم نريد تعبئة المحفضة", "تعبئة",,,)


            Dim com As New SqlCommand("insert into wallet(trans_amount) values(" + s + ")", cn1)

            Try
                If cn1.State = ConnectionState.Open Then cn1.Close()

                cn1.Open()
                com.ExecuteNonQuery()
                cn1.Close()

                MsgBox("تمت التعبئة بنجاح")
            Catch ex As Exception



            End Try
            findWalletBalance()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.ShowDialog()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form24.ShowDialog()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.ShowDialog()
    End Sub
End Class


