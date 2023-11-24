Imports System.Data.SqlClient


Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As Integer
        Dim m As Integer
        Dim y As Integer
        d = Today.Day
        m = Today.Month
        y = Today.Year
        Dim s As String = m & "-" & d & "-" & y
        Dim c As Double = TextBox2.Text
        Dim tc As Double = TextBox1.Text
        Dim sa As String
        Dim aa As String = ComboBox1.Text
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("الرجاء التأكد من البيانات")

        Else
            If tc < c Then

                MsgBox("الرجاء التأكد من البيانات")
            Else

                sa = TextBox3.Text

                '        Dim str As String = "Server=DESKTOP-BRR1N2I;Database=karate;Trusted_Connection=True;
                '"




                '        Dim myconn As New SqlConnection(str)
                Dim com As New SqlCommand("insert into cards (card_name , card_cost ,card_true_cost , card_insertion_date , card_type) values( '" + sa + "', '" + TextBox2.Text + "'  ,  '" + TextBox1.Text + "' ,  '" + s + "','" + aa + "' )", cn1)


                Try
                    If cn1.State = ConnectionState.Open Then cn1.Close()

                    cn1.Open()
                    com.ExecuteNonQuery()

                    cn1.Close()

                    TextBox3.Text = ""
                    TextBox2.Text = ""

                    TextBox1.Text = ""


                    MsgBox("تم ادخال البيانات")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    MsgBox("الرجاء التأكد من البيانات", MsgBoxStyle.Exclamation, "خطأ")
                    cn1.Close()

                End Try
            End If


        End If


        FillDG()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim d As Integer
        Dim m As Integer
        Dim y As Integer
        d = Today.Day
        m = Today.Month
        y = Today.Year
        Dim s As String = m & "-" & d & "-" & y

        '        Dim str As String = "Server=DESKTOP-BRR1N2I;Database=karate;Trusted_Connection=True;
        '"

        Dim c As Double = TextBox2.Text
        Dim tc As Double = TextBox1.Text
        Dim sa As String
        Dim aa As String = ComboBox1.Text
        If tc < c Then

            MsgBox("الرجاء التأكد من البيانات")
        Else

            sa = TextBox3.Text
            Dim up As String = "UPDATE cards set "
            up = up + "card_name='" + sa + "'"
            up = up + ",card_cost='" + TextBox2.Text + "'"
            up = up + ",card_true_cost='" + TextBox1.Text + "'"
            up = up + ",card_insertion_date ='" + s + "'"
            up = up + ",card_type ='" + aa + "'"

            up = up + "WHERE card_ID = '" + TextBox4.Text + "' "
            Dim com As New SqlCommand(up, cn1)


            Try
                If cn1.State = ConnectionState.Open Then cn1.Close()

                cn1.Open()
                com.ExecuteNonQuery()

                cn1.Close()

                TextBox3.Text = ""
                TextBox2.Text = ""

                TextBox1.Text = ""
                MsgBox("تم تعديل البيانات")
            Catch ex As Exception
                MsgBox("الرجاء التأكد من ادخال البيانات", MsgBoxStyle.Exclamation, "خطأ")
                cn1.Close()

            End Try
        End If
        FillDG()
    End Sub

    Sub FillDG()
        'TODO: This line of code loads data into the 'GAMERDataSet1.cards' table. You can move, or remove it, as needed.
        Me.CardsTableAdapter1.Fill(Me.GAMERDataSet1.cards)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        FillDG()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Try

            Dim s As String
            s = DataGridView1.SelectedCells.Item(0).Value.ToString




            '        Dim str As String = "Server=DESKTOP-BRR1N2I;Database=karate;Trusted_Connection=True;
            '"


            '        Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand("SELECT * FROM cards WHERE  card_ID='" + s + "' ", cn1)
            If cn1.State = ConnectionState.Open Then cn1.Close()

            cn1.Open()
            Dim myreder As SqlDataReader = com.ExecuteReader()
            myreder.Read()

            TextBox3.Text = myreder("card_name")
            TextBox4.Text = myreder("card_ID")

            TextBox1.Text = myreder("card_true_cost")
            TextBox2.Text = myreder("card_cost")
            ComboBox1.Text = myreder("card_type")


            cn1.Close()

        Catch ex As Exception
            MsgBox("الرجاء التأكد من نقر المزدوج على خانة رقم القرار", MsgBoxStyle.Exclamation, "خطأ")

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As DialogResult = MsgBox("هل تريد حذف الكرت", MsgBoxStyle.YesNo, "تأكيد")
        If result = DialogResult.Yes Then




            Dim com As New SqlCommand("delete FROM cards WHERE  card_ID='" + TextBox4.Text + "' ", cn1)
            Try
                If cn1.State = ConnectionState.Open Then cn1.Close()


                cn1.Open()

                com.ExecuteNonQuery()

                cn1.Close()

                TextBox3.Text = ""
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox4.Text = ""

                MsgBox("تم حذف البيانات")
            Catch ex As Exception
                MsgBox("الرجاء التأكد رقم الكرت", MsgBoxStyle.Exclamation, "خطأ")
                cn1.Close()

            End Try

        End If
        FillDG()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Then
            e.Handled = True
        End If
    End Sub
End Class