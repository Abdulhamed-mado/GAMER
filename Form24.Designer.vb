<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form24
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.Location = New System.Drawing.Point(166, 81)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 45)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "دخول"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"كروت الاتصلات المحلية", "كروت الانترنت المحلية", "كروت لااتصال الدولية", "كروت المنصات التعلمية", "كرون المحلية", "عروض خاصة", "ماستر كارد", "ببجي نيو ستايت", "ببجي ", "ابل كارد-ايتونز", "قوقل بلاي ", "ستارز بالي سبورت-دوري الايطالي", "ديسكورد", "USDT-بينانس", "تويتش", "ثريا", "ابيكس موبايل ليبيا", "بلايستيشن ", "لودو", "ستيم", "اكس بوكس", "حاكونا", "ايمو", "نينتيندو", "فري فاير", "امازون", "نيتفليكس", "VIP شاهد", "أو إس إن", "IPTV جولد بلس", "وولمارت", "هولو بلس", "سي بي سي", "لايكي", "تانقو لايف", "بيقو لايف", "جواكر", "يال لايف", "سبوتيفاي", "ايباي", "وياك", "روبلوكس", "لوردس موبايل", "ماينكرافت", "ليق اوف ليجيند", "فورتنايت", "بلايد & سول", "كارما كوين", "رون سكيب", "ستارز بلاي", "اي ايه قايمز", "قيم ستوب", "بليزارد", "فايبر اوت", "سكايب", "مكافي", "نون ", "كرونشيرول", "سبيستون قو", "امفيو", "ريزر-قولد"})
        Me.ComboBox1.Location = New System.Drawing.Point(24, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox1.Size = New System.Drawing.Size(393, 32)
        Me.ComboBox1.TabIndex = 0
        '
        'Form24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 162)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form24"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "صفحة المبيعات-كروت "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
