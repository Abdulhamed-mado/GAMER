Imports System.Data.SqlClient


Public Class Form25
    Private i As Integer

    Sub FillDG()

        'TODO: This line of code loads data into the 'GAMERDataSet7.sell' table. You can move, or remove it, as needed.
        Me.SellTableAdapter2.Fill(Me.GAMERDataSet7.sell)



    End Sub
    Sub comfill(x As String)



        If cn1.State = ConnectionState.Open Then cn1.Close()

        TextBox3.Text = x
        Dim com As New SqlCommand("SELECT * FROM cards where card_type =  '" + x + "' ", cn1)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)

        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "card_name"
        ComboBox1.ValueMember = "card_name"
        TextBox5.Text = ""

    End Sub
    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comfill(sx)

        FillDG()

        findWalletBalance()

        If ComboBox1.Text = "" Then
            TextBox2.Text = ""
            TextBox1.Text = ""
            TextBox5.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox5.Text = "" Then
            TextBox5.Text = "1"
        End If

        If ComboBox2.Text = "" Then
            ComboBox2.Text = "كاش"
        End If
        Dim x As Double
        Dim xa As Double
        Dim xax As Double
        Dim s As String = ComboBox1.Text
        Dim sa As String = ComboBox2.Text
        Dim sss As Double = Convert.ToDouble(TextBox2.Text)
        If wallet >= sss Then

            sss = sss * -1

            Try

                Dim conn As New SqlCommand("select max(trans_id) from wallet ", cn1)
                If cn1.State = ConnectionState.Open Then cn1.Close()

                cn1.Open()
                Dim myreder As SqlDataReader = conn.ExecuteReader()
                myreder.Read()


                i = myreder.Item(0).ToString
                i = i + 1

                cn1.Close()

            Catch ex As Exception

            End Try
            x = TextBox1.Text
            xa = TextBox2.Text
            xax = TextBox5.Text
            x *= xax
            xa *= xax
            TextBox1.Text = x
            TextBox2.Text = xa

            Dim com As New SqlCommand("insert into wallet(trans_amount) values(" & sss & ")", cn1)

            Dim comm As New SqlCommand("insert into sell (trans_name , trans_cost ,trans_true_cost , trans_type , trans_payment_type,wallet_id,quan) values( '" + s + "', '" & TextBox2.Text & "'  ,  '" & TextBox1.Text & "' ,  '" & TextBox3.Text & "','" & sa & "' ," & i & ",  '" & TextBox5.Text & "' )", cn1)


            Try
                If cn1.State = ConnectionState.Open Then cn1.Close()

                cn1.Open()
                com.ExecuteNonQuery()
                comm.ExecuteNonQuery()
                cn1.Close()




                MsgBox("تم ادخال البيانات")
            Catch ex As Exception
                MsgBox("الرجاء التأكد من البيانات", MsgBoxStyle.Exclamation, "خطأ")
                cn1.Close()

            End Try

        Else
            MsgBox("لا يوجد رصيد كافي")
        End If
        TextBox5.Text = ""

        FillDG()
        findWalletBalance()
        card_cost()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s As String = ComboBox1.Text
        Dim sa As String = ComboBox2.Text
        Dim sss As Integer = TextBox1.Text
        If wallet >= sss Then

            If TextBox5.Text = "" Then
                TextBox5.Text = "1"
            End If



            sss = sss * -1
            multi()

            Dim upp As String = "UPDATE wallet set "
            upp = upp + "trans_amount ='" & sss & "'"

            upp = upp + "WHERE trans_id = '" & i & "' "



            Dim up As String = "UPDATE sell set "
            up = up + "trans_name='" & s & "'"
            up = up + ",trans_type='" + TextBox3.Text + "'"
            up = up + ",trans_cost='" + TextBox2.Text + "'"
            up = up + ",trans_true_cost ='" + TextBox1.Text + "'"
            up = up + ",trans_payment_type ='" & sa & "'"
            up = up + ",quan ='" & TextBox5.Text & "'"

            up = up + "WHERE trans_id = '" + TextBox4.Text + "' "
            Dim com As New SqlCommand(up, cn1)
            Dim comn As New SqlCommand(upp, cn1)


            Try
                If cn1.State = ConnectionState.Open Then cn1.Close()

                cn1.Open()
                com.ExecuteNonQuery()
                comn.ExecuteNonQuery()
                cn1.Close()

                TextBox5.Text = ""

                MsgBox("تم تعديل البيانات")
            Catch ex As Exception
                MsgBox("الرجاء التأكد من ادخال البيانات", MsgBoxStyle.Exclamation, "خطأ")
                cn1.Close()
            End Try

        End If
        FillDG()
        findWalletBalance()
        card_cost()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x As Integer
        Dim result As DialogResult = MsgBox("هل تريد حذف المعاملة", MsgBoxStyle.YesNo, "تأكيد")
        If result = DialogResult.Yes Then
            Dim comx As New SqlCommand("SELECT * FROM sell WHERE trans_id ='" + TextBox4.Text + "' ", cn1)
            If cn1.State = ConnectionState.Open Then cn1.Close()
            Try
                cn1.Open()
                Dim myreder As SqlDataReader = comx.ExecuteReader()
                myreder.Read()

                x = myreder("wallet_id")
            Catch ex As Exception

            End Try







            Dim com As New SqlCommand("delete FROM sell WHERE  trans_id='" + TextBox4.Text + "' ", cn1)
            Dim comn As New SqlCommand("delete FROM wallet WHERE  trans_id='" & x & "' ", cn1)

            Try
                If cn1.State = ConnectionState.Open Then cn1.Close()


                cn1.Open()

                com.ExecuteNonQuery()
                comn.ExecuteNonQuery()
                cn1.Close()

                TextBox5.Text = ""

                TextBox4.Text = ""

                MsgBox("تم حذف البيانات")
            Catch ex As Exception
                MsgBox("الرجاء التأكد رقم الكرت", MsgBoxStyle.Exclamation, "خطأ")
                cn1.Close()

            End Try

        End If
        FillDG()




        findWalletBalance()



    End Sub
    Sub card_cost()
        Try


            Dim s As String = ComboBox1.Text




            '        Dim str As String = "Server=DESKTOP-BRR1N2I;Database=karate;Trusted_Connection=True;
            '"


            '        Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand("SELECT * FROM cards WHERE  card_name ='" + s + "' ", cn1)
            If cn1.State = ConnectionState.Open Then cn1.Close()

            cn1.Open()
            Dim myreder As SqlDataReader = com.ExecuteReader()
            myreder.Read()


            TextBox1.Text = myreder("card_true_cost")
            TextBox2.Text = myreder("card_cost")


            cn1.Close()

        Catch ex As Exception


        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        card_cost()

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Try

            Dim s As String
            Dim sa As String
            s = DataGridView1.SelectedCells.Item(0).Value.ToString




            '        Dim str As String = "Server=DESKTOP-BRR1N2I;Database=karate;Trusted_Connection=True;
            '"


            '        Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand("SELECT * FROM sell WHERE trans_id ='" + s + "' ", cn1)
            If cn1.State = ConnectionState.Open Then cn1.Close()

            cn1.Open()
            Dim myreder As SqlDataReader = com.ExecuteReader()
            myreder.Read()
            ComboBox2.Text = myreder("trans_payment_type")
            i = myreder("wallet_id")

            TextBox3.Text = myreder("trans_type")
            TextBox4.Text = myreder("trans_id")
            sa = myreder("trans_type")
            TextBox1.Text = myreder("trans_true_cost")
            TextBox2.Text = myreder("trans_cost")

            comfill(sa)


            cn1.Close()

        Catch ex As Exception
            MsgBox("الرجاء التأكد من نقر المزدوج على خانة رقم القرار", MsgBoxStyle.Exclamation, "خطأ")

        End Try
    End Sub

    Sub multi()

        Dim s As Double
        Dim sa As Double
        Dim sas As Double
        If TextBox5.Text = "" Then

            card_cost()


        Else
            card_cost()
            s = TextBox1.Text
            sa = TextBox2.Text
            sas = TextBox5.Text
            s *= sas
            sa *= sas
            TextBox1.Text = s
            TextBox2.Text = sa
        End If
    End Sub


    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class