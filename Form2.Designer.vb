<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CardIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.card_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardtruecostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardinsertiondateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GAMERDataSet1 = New GAMER.GAMERDataSet1()
        Me.CardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GAMERDataSet = New GAMER.GAMERDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CardsTableAdapter = New GAMER.GAMERDataSetTableAdapters.cardsTableAdapter()
        Me.CardsTableAdapter1 = New GAMER.GAMERDataSet1TableAdapters.cardsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAMERDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAMERDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(52, 160)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(789, 32)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(906, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "سعر الكرت:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(905, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "اسم الكرت:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(52, 214)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(789, 32)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(918, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "فئة الكرت:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"المدار الجديد", "ليبيانا", "ليبيا للاتصالات و التقنية", "هاتف ليبيا", "شركة قيقا للاتصالات", "الريادة لتقنية المعلومات", "سمارت نت", "كونكت", "شركة اورنج انترنت", "الحداثة نت-الواحة نت", "نسمة نت-فزان", "شركة لإندماج لأول", "تواصل نت", "صلة نت", "ابراج ليبيا", "فيرست نت", "النبض الرقمي", "سايبر نت", "الكفاءة نت", "دلكونت", "الأفق الرقمي", "اوزون الجديد", "سكاي تك", "سكاي نت", "الماسة نت", "المدى الرقمي", "اوكسجين", "سنا للاتصالات و التقنية زليتن", "سنا للاتصالات و التقنية الجفرة", "سنا للاتصالات و التقنية بني وليد", "سبارك نت", "هلا نت", "زاجل الغربية", "روابط", "زاجل ليبيا", "التجدد القبة", "التجدد العزيات", "لينك نت", " الجبل", "هاي كلاس نت", "ntc البرج للاتصالات ", "سمارت 300", "الاهرام للاتصالات", "فونينا", "اورنج المصرية 012", "للاتصالات oww  حكاوي", "وي المصرية015", "فودافون المصري 010", "اتصالات المصرية 011", "اورمج للأتصالات الدولية", "منصحة اشرح لي التعلمية", "مايكروستوري", "بوابة المعلم الاكترونية", "منصة ايضاح التعلمية", "منصة دورات التعليمية", "منهجي التعليمية", "العنكبوت الليبي", "WePOSمنظومة ننشئ", "السوق المفتوح", "كاشف الارقام", "توربو", "سبيدلي", "عروض خاصة", "ماستر كارد", "ببجي نيو ستايت", "ببجي ", "ابل كارد امريكا", "ابل كارد بريطانيا", "ابل كارد الإمارات", "ابل كارد السعودية", "ابل كارد كندا", "ابل كارد بلجيكا", "ابل كارد فرنسا", "ابل كارد إيرلندا", "ابل كارد إيطاليا", "ابل كارد هولندا", "ابل كارد برتغال", "ابل كارد إسبانيا", "ابل كارد اليابان", "ابل كارد تركيا", "قوقل بلاي امريكا", "قوقل بلاي كوريا الجنوبية", "قوقل بلاي بريطانيا", "قوقل بلاي اوروبا", "قوقل بلاي الامارات", "قوقل بلاي السعودية", "ستارز بالي سبورت(دوري الايطالي)", "ديسكورد", "USDT-بينانس", "تويتش", "ثريا", "ابيكس موبايل ليبيا", "بلايستيشن نتوورك امريكا", "بلايستيشن نتوورك بريطانيا", "بلايستيشن نتوورك الامارات", "بلايستيشن نتوورك السعودية", "بلايستيشن نتوورك فرنسا", "بلايستيشن نتوورك المانيا", "بلايستيشن نتوورك بلجيكا", "بلايستيشن نتوورك كندا", "بلايستيشن نتوورك كويت", "بلايستيشن نتوورك لبنان", "بلايستيشن نتوورك عمان", "بلايستيشن نتوورك بحرين", "يلا لودو", "لودو كلوب", "ستيم", "اكس بوكس امريكا", "اكس بوكس أوروبا", "اكس بوكس السعودية", "اكس بوكس الإمارات", "حاكونا", "ايمو", "نينتيندو", "فري فاير", "امازون امريكا", "امازون الإمارات", "امازون السعودية", "نيتفليكس امريكا", "نيتفليكس الإمارات", "نيتفليكس تركيا", "VIP شاهد", "أو إس إن", "IPTV جولد بلس", "وولمارت", "هولو بلس", "سي بي سي", "لايكي عمان", "لايكي المغرب", "تانقو لايف", "بيقولايف", "جواكر", "يال لايف", "سبوتيفاي", "ايباي", "وياك", "روبلوكس", "لوردس موبايل", "ماينكرافت", "ليق اوف ليجيند اوروبا", "ليق اوف ليجيند امريكا الشمالية", "فورتنايت", "بلايد & سول", "كارما كوين", "رون سكيب", "ستارز بلاي", "اي ايه قايمز اكسبوكس", "اي ايه قايمز اورجن", "اي ايه قايمز بلايستيشن", "قيم ستوب", "بليزارد", "فايبر اوت", "سكايب", "مكافي", "نون الامارات", "نون السعودية", "كرونشيرول", "سبيستون قو", "امفيو", "ريزر-قولد"})
        Me.ComboBox1.Location = New System.Drawing.Point(52, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(789, 32)
        Me.ComboBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(875, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "سعر بيع الكرت:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1065, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(52, 52)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(789, 32)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(915, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "رقم الكرت:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(52, 268)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(789, 32)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardIDDataGridViewTextBoxColumn, Me.card_type, Me.CardnameDataGridViewTextBoxColumn, Me.CardcostDataGridViewTextBoxColumn, Me.CardtruecostDataGridViewTextBoxColumn, Me.CardinsertiondateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CardsBindingSource1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(18, 35)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1048, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'CardIDDataGridViewTextBoxColumn
        '
        Me.CardIDDataGridViewTextBoxColumn.DataPropertyName = "card_ID"
        Me.CardIDDataGridViewTextBoxColumn.HeaderText = "رقم الكرت"
        Me.CardIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CardIDDataGridViewTextBoxColumn.Name = "CardIDDataGridViewTextBoxColumn"
        Me.CardIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CardIDDataGridViewTextBoxColumn.Width = 125
        '
        'card_type
        '
        Me.card_type.DataPropertyName = "card_type"
        Me.card_type.HeaderText = "نوع الكرت"
        Me.card_type.MinimumWidth = 6
        Me.card_type.Name = "card_type"
        Me.card_type.ReadOnly = True
        Me.card_type.Width = 125
        '
        'CardnameDataGridViewTextBoxColumn
        '
        Me.CardnameDataGridViewTextBoxColumn.DataPropertyName = "card_name"
        Me.CardnameDataGridViewTextBoxColumn.HeaderText = "اسم الكرت"
        Me.CardnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CardnameDataGridViewTextBoxColumn.Name = "CardnameDataGridViewTextBoxColumn"
        Me.CardnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CardnameDataGridViewTextBoxColumn.Width = 125
        '
        'CardcostDataGridViewTextBoxColumn
        '
        Me.CardcostDataGridViewTextBoxColumn.DataPropertyName = "card_cost"
        Me.CardcostDataGridViewTextBoxColumn.HeaderText = "سعر الكرت"
        Me.CardcostDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CardcostDataGridViewTextBoxColumn.Name = "CardcostDataGridViewTextBoxColumn"
        Me.CardcostDataGridViewTextBoxColumn.ReadOnly = True
        Me.CardcostDataGridViewTextBoxColumn.Width = 125
        '
        'CardtruecostDataGridViewTextBoxColumn
        '
        Me.CardtruecostDataGridViewTextBoxColumn.DataPropertyName = "card_true_cost"
        Me.CardtruecostDataGridViewTextBoxColumn.HeaderText = "سعر بيع الكرت"
        Me.CardtruecostDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CardtruecostDataGridViewTextBoxColumn.Name = "CardtruecostDataGridViewTextBoxColumn"
        Me.CardtruecostDataGridViewTextBoxColumn.ReadOnly = True
        Me.CardtruecostDataGridViewTextBoxColumn.Width = 125
        '
        'CardinsertiondateDataGridViewTextBoxColumn
        '
        Me.CardinsertiondateDataGridViewTextBoxColumn.DataPropertyName = "card_insertion_date"
        Me.CardinsertiondateDataGridViewTextBoxColumn.HeaderText = "تاريخ ادخال الكرت"
        Me.CardinsertiondateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CardinsertiondateDataGridViewTextBoxColumn.Name = "CardinsertiondateDataGridViewTextBoxColumn"
        Me.CardinsertiondateDataGridViewTextBoxColumn.ReadOnly = True
        Me.CardinsertiondateDataGridViewTextBoxColumn.Width = 125
        '
        'CardsBindingSource1
        '
        Me.CardsBindingSource1.DataMember = "cards"
        Me.CardsBindingSource1.DataSource = Me.GAMERDataSet1
        '
        'GAMERDataSet1
        '
        Me.GAMERDataSet1.DataSetName = "GAMERDataSet1"
        Me.GAMERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CardsBindingSource
        '
        Me.CardsBindingSource.DataMember = "cards"
        Me.CardsBindingSource.DataSource = Me.GAMERDataSet
        '
        'GAMERDataSet
        '
        Me.GAMERDataSet.DataSetName = "GAMERDataSet"
        Me.GAMERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(22, 352)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1084, 388)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(48, 214)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 77)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "ادخال"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(48, 331)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 77)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "تعديل"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(47, 448)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 77)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "حذف"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Location = New System.Drawing.Point(1095, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 655)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CardsTableAdapter
        '
        Me.CardsTableAdapter.ClearBeforeFill = True
        '
        'CardsTableAdapter1
        '
        Me.CardsTableAdapter1.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1409, 756)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "صفحة الكروت"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAMERDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAMERDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GAMERDataSet As GAMERDataSet
    Friend WithEvents CardsBindingSource As BindingSource
    Friend WithEvents CardsTableAdapter As GAMERDataSetTableAdapters.cardsTableAdapter
    Friend WithEvents GAMERDataSet1 As GAMERDataSet1
    Friend WithEvents CardsBindingSource1 As BindingSource
    Friend WithEvents CardsTableAdapter1 As GAMERDataSet1TableAdapters.cardsTableAdapter
    Friend WithEvents CardIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents card_type As DataGridViewTextBoxColumn
    Friend WithEvents CardnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardcostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardtruecostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardinsertiondateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
