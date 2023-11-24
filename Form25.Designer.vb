<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form25
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form25))
        Me.CardsTableAdapter1 = New GAMER.GAMERDataSet1TableAdapters.cardsTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TransidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranstypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranscostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranstruecostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranspaymenttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GAMERDataSet7 = New GAMER.GAMERDataSet7()
        Me.SellBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GAMERDataSet5 = New GAMER.GAMERDataSet5()
        Me.CardsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GAMERDataSet1 = New GAMER.GAMERDataSet1()
        Me.GAMERDataSet = New GAMER.GAMERDataSet()
        Me.CardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardsTableAdapter = New GAMER.GAMERDataSetTableAdapters.cardsTableAdapter()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SellTableAdapter = New GAMER.GAMERDataSet5TableAdapters.sellTableAdapter()
        Me.GAMERDataSet6 = New GAMER.GAMERDataSet6()
        Me.SellBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellTableAdapter1 = New GAMER.GAMERDataSet6TableAdapters.sellTableAdapter()
        Me.SellTableAdapter2 = New GAMER.GAMERDataSet7TableAdapters.sellTableAdapter()
        Me.GAMERDataSet8 = New GAMER.GAMERDataSet8()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAMERDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAMERDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAMERDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAMERDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GAMERDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAMERDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardsTableAdapter1
        '
        Me.CardsTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Location = New System.Drawing.Point(1100, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 655)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(27, 349)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1084, 393)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransidDataGridViewTextBoxColumn, Me.TransnameDataGridViewTextBoxColumn, Me.TranstypeDataGridViewTextBoxColumn, Me.quan, Me.TranscostDataGridViewTextBoxColumn, Me.TranstruecostDataGridViewTextBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.TranspaymenttypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SellBindingSource2
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
        'TransidDataGridViewTextBoxColumn
        '
        Me.TransidDataGridViewTextBoxColumn.DataPropertyName = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.HeaderText = "رقم المعاملة"
        Me.TransidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TransidDataGridViewTextBoxColumn.Name = "TransidDataGridViewTextBoxColumn"
        Me.TransidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransidDataGridViewTextBoxColumn.Width = 125
        '
        'TransnameDataGridViewTextBoxColumn
        '
        Me.TransnameDataGridViewTextBoxColumn.DataPropertyName = "trans_name"
        Me.TransnameDataGridViewTextBoxColumn.HeaderText = "اسم الكرت"
        Me.TransnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TransnameDataGridViewTextBoxColumn.Name = "TransnameDataGridViewTextBoxColumn"
        Me.TransnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransnameDataGridViewTextBoxColumn.Width = 125
        '
        'TranstypeDataGridViewTextBoxColumn
        '
        Me.TranstypeDataGridViewTextBoxColumn.DataPropertyName = "trans_type"
        Me.TranstypeDataGridViewTextBoxColumn.HeaderText = "نوع الكرت"
        Me.TranstypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TranstypeDataGridViewTextBoxColumn.Name = "TranstypeDataGridViewTextBoxColumn"
        Me.TranstypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TranstypeDataGridViewTextBoxColumn.Width = 125
        '
        'quan
        '
        Me.quan.DataPropertyName = "quan"
        Me.quan.HeaderText = "عدد "
        Me.quan.MinimumWidth = 6
        Me.quan.Name = "quan"
        Me.quan.ReadOnly = True
        Me.quan.Width = 125
        '
        'TranscostDataGridViewTextBoxColumn
        '
        Me.TranscostDataGridViewTextBoxColumn.DataPropertyName = "trans_cost"
        Me.TranscostDataGridViewTextBoxColumn.HeaderText = "سعر الكرت"
        Me.TranscostDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TranscostDataGridViewTextBoxColumn.Name = "TranscostDataGridViewTextBoxColumn"
        Me.TranscostDataGridViewTextBoxColumn.ReadOnly = True
        Me.TranscostDataGridViewTextBoxColumn.Width = 125
        '
        'TranstruecostDataGridViewTextBoxColumn
        '
        Me.TranstruecostDataGridViewTextBoxColumn.DataPropertyName = "trans_true_cost"
        Me.TranstruecostDataGridViewTextBoxColumn.HeaderText = "سعر بيع الكرت"
        Me.TranstruecostDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TranstruecostDataGridViewTextBoxColumn.Name = "TranstruecostDataGridViewTextBoxColumn"
        Me.TranstruecostDataGridViewTextBoxColumn.ReadOnly = True
        Me.TranstruecostDataGridViewTextBoxColumn.Width = 125
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date"
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "تاريخ المعاملة"
        Me.TransdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        Me.TransdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransdateDataGridViewTextBoxColumn.Width = 125
        '
        'TranspaymenttypeDataGridViewTextBoxColumn
        '
        Me.TranspaymenttypeDataGridViewTextBoxColumn.DataPropertyName = "trans_payment_type"
        Me.TranspaymenttypeDataGridViewTextBoxColumn.HeaderText = "طريقة الدفع"
        Me.TranspaymenttypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TranspaymenttypeDataGridViewTextBoxColumn.Name = "TranspaymenttypeDataGridViewTextBoxColumn"
        Me.TranspaymenttypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TranspaymenttypeDataGridViewTextBoxColumn.Width = 125
        '
        'SellBindingSource2
        '
        Me.SellBindingSource2.DataMember = "sell"
        Me.SellBindingSource2.DataSource = Me.GAMERDataSet7
        '
        'GAMERDataSet7
        '
        Me.GAMERDataSet7.DataSetName = "GAMERDataSet7"
        Me.GAMERDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SellBindingSource
        '
        Me.SellBindingSource.DataMember = "sell"
        Me.SellBindingSource.DataSource = Me.GAMERDataSet5
        '
        'GAMERDataSet5
        '
        Me.GAMERDataSet5.DataSetName = "GAMERDataSet5"
        Me.GAMERDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GAMERDataSet
        '
        Me.GAMERDataSet.DataSetName = "GAMERDataSet"
        Me.GAMERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CardsBindingSource
        '
        Me.CardsBindingSource.DataMember = "cards"
        Me.CardsBindingSource.DataSource = Me.GAMERDataSet
        '
        'CardsTableAdapter
        '
        Me.CardsTableAdapter.ClearBeforeFill = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(55, 29)
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
        Me.Label5.Location = New System.Drawing.Point(871, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "رقم المعاملة:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(55, 244)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(789, 32)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
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
        Me.GroupBox1.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1065, 327)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(881, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "عدد الكروت:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(55, 158)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox5.Size = New System.Drawing.Size(789, 32)
        Me.TextBox5.TabIndex = 3
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(877, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "طريقة الدفع:"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"كاش", "موبي كاش", "يسر", "ادفع لي"})
        Me.ComboBox2.Location = New System.Drawing.Point(55, 287)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox2.Size = New System.Drawing.Size(789, 32)
        Me.ComboBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(55, 115)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(789, 32)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(883, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "سعر الكرت:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(895, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "فئة الكرت:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(55, 201)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(789, 32)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "اسم الكرت:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"المدار الجديد", "ليبيانا", "ليبيا للاتصالات و التقنية", "هاتف ليبيا", "شركة قيقا للاتصالات", "الريادة لتقنية المعلومات", "سمارت نت", "كونكت", "شركة اورنج انترنت", "الحداثة نت-الواحة نت", "نسمة نت-فزان", "شركة لإندماج لأول", "تواصل نت", "صلة نت", "ابراج ليبيا", "فيرست نت", "النبض الرقمي", "سايبر نت", "الكفاءة نت", "دلكونت", "الأفق الرقمي", "اوزون الجديد", "سكاي تك", "سكاي نت", "الماسة نت", "المدى الرقمي", "اوكسجين", "سنا للاتصالات و التقنية زليتن", "سنا للاتصالات و التقنية الجفرة", "سنا للاتصالات و التقنية بني وليد", "سبارك نت", "هلا نت", "زاجل الغربية", "روابط", "زاجل ليبيا", "التجدد القبة", "التجدد العزيات", "لينك نت", " الجبل", "هاي كلاس نت", "ntc البرج للاتصالات ", "سمارت 300", "الاهرام للاتصالات", "فونينا", "اورنج المصرية 012", "للاتصالات oww  حكاوي", "وي المصرية015", "فودافون المصري 010", "اتصالات المصرية 011", "اورمج للأتصالات الدولية", "منصحة اشرح لي التعلمية", "مايكروستوري", "بوابة المعلم الاكترونية", "منصة ايضاح التعلمية", "منصة دورات التعليمية", "منهجي التعليمية", "العنكبوت الليبي", "WePOSمنظومة ننشئ", "السوق المفتوح", "كاشف الارقام", "توربو", "سبيدلي", "عروض خاصة", "ماستر كارد", "ببجي نيو ستايت", "ببجي ", "ابل كارد امريكا", "ابل كارد بريطانيا", "ابل كارد الإمارات", "ابل كارد السعودية", "ابل كارد كندا", "ابل كارد بلجيكا", "ابل كارد فرنسا", "ابل كارد إيرلندا", "ابل كارد إيطاليا", "ابل كارد هولندا", "ابل كارد برتغال", "ابل كارد إسبانيا", "ابل كارد اليابان", "ابل كارد تركيا", "قوقل بلاي امريكا", "قوقل بلاي كوريا الجنوبية", "قوقل بلاي بريطانيا", "قوقل بلاي اوروبا", "قوقل بلاي الامارات", "قوقل بلاي السعودية", "ستارز بالي سبورت(دوري الايطالي)", "ديسكورد", "USDT-بينانس", "تويتش", "ثريا", "ابيكس موبايل ليبيا", "بلايستيشن نتوورك امريكا", "بلايستيشن نتوورك بريطانيا", "بلايستيشن نتوورك الامارات", "بلايستيشن نتوورك السعودية", "بلايستيشن نتوورك فرنسا", "بلايستيشن نتوورك المانيا", "بلايستيشن نتوورك بلجيكا", "بلايستيشن نتوورك كندا", "بلايستيشن نتوورك كويت", "بلايستيشن نتوورك لبنان", "بلايستيشن نتوورك عمان", "بلايستيشن نتوورك بحرين", "يلا لودو", "لودو كلوب", "ستيم", "اكس بوكس امريكا", "اكس بوكس أوروبا", "اكس بوكس السعودية", "اكس بوكس الإمارات", "حاكونا", "ايمو", "نينتيندو", "فري فاير", "امازون امريكا", "امازون الإمارات", "امازون السعودية", "نيتفليكس امريكا", "نيتفليكس الإمارات", "نيتفليكس تركيا", "VIP شاهد", "أو إس إن", "IPTV جولد بلس", "وولمارت", "هولو بلس", "سي بي سي", "لايكي عمان", "لايكي المغرب", "تانقو لايف", "بيقولايف", "جواكر", "يال لايف", "سبوتيفاي", "ايباي", "وياك", "روبلوكس", "لوردس موبايل", "ماينكرافت", "ليق اوف ليجيند اوروبا", "ليق اوف ليجيند امريكا الشمالية", "فورتنايت", "بلايد & سول", "كارما كوين", "رون سكيب", "ستارز بلاي", "اي ايه قايمز اكسبوكس", "اي ايه قايمز اورجن", "اي ايه قايمز بلايستيشن", "قيم ستوب", "بليزارد", "فايبر اوت", "سكايب", "مكافي", "نون الامارات", "نون السعودية", "كرونشيرول", "سبيستون قو", "امفيو"})
        Me.ComboBox1.Location = New System.Drawing.Point(55, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(789, 32)
        Me.ComboBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(852, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "سعر بيع الكرت:"
        '
        'SellTableAdapter
        '
        Me.SellTableAdapter.ClearBeforeFill = True
        '
        'GAMERDataSet6
        '
        Me.GAMERDataSet6.DataSetName = "GAMERDataSet6"
        Me.GAMERDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SellBindingSource1
        '
        Me.SellBindingSource1.DataMember = "sell"
        Me.SellBindingSource1.DataSource = Me.GAMERDataSet6
        '
        'SellTableAdapter1
        '
        Me.SellTableAdapter1.ClearBeforeFill = True
        '
        'SellTableAdapter2
        '
        Me.SellTableAdapter2.ClearBeforeFill = True
        '
        'GAMERDataSet8
        '
        Me.GAMERDataSet8.DataSetName = "GAMERDataSet8"
        Me.GAMERDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1409, 756)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form25"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "صفحة المبيعات "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAMERDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAMERDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAMERDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAMERDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GAMERDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAMERDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CardsTableAdapter1 As GAMERDataSet1TableAdapters.cardsTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CardsBindingSource1 As BindingSource
    Friend WithEvents GAMERDataSet1 As GAMERDataSet1
    Friend WithEvents GAMERDataSet As GAMERDataSet
    Friend WithEvents CardsBindingSource As BindingSource
    Friend WithEvents CardsTableAdapter As GAMERDataSetTableAdapters.cardsTableAdapter
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GAMERDataSet5 As GAMERDataSet5
    Friend WithEvents SellBindingSource As BindingSource
    Friend WithEvents SellTableAdapter As GAMERDataSet5TableAdapters.sellTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GAMERDataSet6 As GAMERDataSet6
    Friend WithEvents SellBindingSource1 As BindingSource
    Friend WithEvents SellTableAdapter1 As GAMERDataSet6TableAdapters.sellTableAdapter
    Friend WithEvents GAMERDataSet7 As GAMERDataSet7
    Friend WithEvents SellBindingSource2 As BindingSource
    Friend WithEvents SellTableAdapter2 As GAMERDataSet7TableAdapters.sellTableAdapter
    Friend WithEvents GAMERDataSet8 As GAMERDataSet8
    Friend WithEvents TransidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranstypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents quan As DataGridViewTextBoxColumn
    Friend WithEvents TranscostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranstruecostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranspaymenttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
