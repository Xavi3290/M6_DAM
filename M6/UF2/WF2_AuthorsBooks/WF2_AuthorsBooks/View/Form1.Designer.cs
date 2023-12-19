namespace WF2_AuthorsBooks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAuthorsBooks = new System.Windows.Forms.TabControl();
            this.tpCombos = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDescrip = new System.Windows.Forms.TextBox();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.cbAuthors = new System.Windows.Forms.ComboBox();
            this.tpAuthors = new System.Windows.Forms.TabPage();
            this.ckbAuthorFilter = new System.Windows.Forms.CheckBox();
            this.tbAuthorFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btAuthorDelAll = new System.Windows.Forms.Button();
            this.btAuthorDel = new System.Windows.Forms.Button();
            this.btAuthorUpd = new System.Windows.Forms.Button();
            this.btAuthorIns = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAuthorBooks = new System.Windows.Forms.DataGridView();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.tpBooks = new System.Windows.Forms.TabPage();
            this.cbBookAuthor = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbBookPrice = new System.Windows.Forms.TextBox();
            this.tbBookDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ckbBookFilter = new System.Windows.Forms.CheckBox();
            this.tbBookFilter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btBookDel = new System.Windows.Forms.Button();
            this.btBookUpd = new System.Windows.Forms.Button();
            this.btBookIns = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.tcAuthorsBooks.SuspendLayout();
            this.tpCombos.SuspendLayout();
            this.tpAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.tpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAuthorsBooks
            // 
            this.tcAuthorsBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAuthorsBooks.Controls.Add(this.tpCombos);
            this.tcAuthorsBooks.Controls.Add(this.tpAuthors);
            this.tcAuthorsBooks.Controls.Add(this.tpBooks);
            this.tcAuthorsBooks.Location = new System.Drawing.Point(1, 2);
            this.tcAuthorsBooks.Name = "tcAuthorsBooks";
            this.tcAuthorsBooks.SelectedIndex = 0;
            this.tcAuthorsBooks.Size = new System.Drawing.Size(644, 308);
            this.tcAuthorsBooks.TabIndex = 1;
            // 
            // tpCombos
            // 
            this.tpCombos.Controls.Add(this.label4);
            this.tpCombos.Controls.Add(this.label3);
            this.tpCombos.Controls.Add(this.label2);
            this.tpCombos.Controls.Add(this.label1);
            this.tpCombos.Controls.Add(this.tbPrice);
            this.tpCombos.Controls.Add(this.tbDescrip);
            this.tpCombos.Controls.Add(this.cbBooks);
            this.tpCombos.Controls.Add(this.cbAuthors);
            this.tpCombos.Location = new System.Drawing.Point(4, 22);
            this.tpCombos.Name = "tpCombos";
            this.tpCombos.Padding = new System.Windows.Forms.Padding(3);
            this.tpCombos.Size = new System.Drawing.Size(525, 258);
            this.tpCombos.TabIndex = 0;
            this.tpCombos.Text = "Consulta";
            this.tpCombos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Preu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripció";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Llibres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autors";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(185, 129);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // tbDescrip
            // 
            this.tbDescrip.Location = new System.Drawing.Point(185, 88);
            this.tbDescrip.Name = "tbDescrip";
            this.tbDescrip.Size = new System.Drawing.Size(284, 20);
            this.tbDescrip.TabIndex = 4;
            // 
            // cbBooks
            // 
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(185, 33);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(151, 21);
            this.cbBooks.TabIndex = 3;
            // 
            // cbAuthors
            // 
            this.cbAuthors.FormattingEnabled = true;
            this.cbAuthors.Location = new System.Drawing.Point(19, 33);
            this.cbAuthors.Name = "cbAuthors";
            this.cbAuthors.Size = new System.Drawing.Size(151, 21);
            this.cbAuthors.TabIndex = 2;
            // 
            // tpAuthors
            // 
            this.tpAuthors.Controls.Add(this.ckbAuthorFilter);
            this.tpAuthors.Controls.Add(this.tbAuthorFilter);
            this.tpAuthors.Controls.Add(this.label8);
            this.tpAuthors.Controls.Add(this.textBox1);
            this.tpAuthors.Controls.Add(this.label7);
            this.tpAuthors.Controls.Add(this.btAuthorDelAll);
            this.tpAuthors.Controls.Add(this.btAuthorDel);
            this.tpAuthors.Controls.Add(this.btAuthorUpd);
            this.tpAuthors.Controls.Add(this.btAuthorIns);
            this.tpAuthors.Controls.Add(this.label6);
            this.tpAuthors.Controls.Add(this.label5);
            this.tpAuthors.Controls.Add(this.dgvAuthorBooks);
            this.tpAuthors.Controls.Add(this.tbAuthor);
            this.tpAuthors.Controls.Add(this.dgvAuthors);
            this.tpAuthors.Location = new System.Drawing.Point(4, 22);
            this.tpAuthors.Name = "tpAuthors";
            this.tpAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tpAuthors.Size = new System.Drawing.Size(525, 258);
            this.tpAuthors.TabIndex = 1;
            this.tpAuthors.Text = "Autors";
            this.tpAuthors.UseVisualStyleBackColor = true;
            // 
            // ckbAuthorFilter
            // 
            this.ckbAuthorFilter.AutoSize = true;
            this.ckbAuthorFilter.Location = new System.Drawing.Point(187, 18);
            this.ckbAuthorFilter.Name = "ckbAuthorFilter";
            this.ckbAuthorFilter.Size = new System.Drawing.Size(49, 17);
            this.ckbAuthorFilter.TabIndex = 12;
            this.ckbAuthorFilter.Text = "actiu";
            this.ckbAuthorFilter.UseVisualStyleBackColor = true;
            // 
            // tbAuthorFilter
            // 
            this.tbAuthorFilter.Location = new System.Drawing.Point(48, 16);
            this.tbAuthorFilter.Name = "tbAuthorFilter";
            this.tbAuthorFilter.Size = new System.Drawing.Size(133, 20);
            this.tbAuthorFilter.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Filtre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Filtre";
            // 
            // btAuthorDelAll
            // 
            this.btAuthorDelAll.Location = new System.Drawing.Point(187, 133);
            this.btAuthorDelAll.Name = "btAuthorDelAll";
            this.btAuthorDelAll.Size = new System.Drawing.Size(44, 29);
            this.btAuthorDelAll.TabIndex = 0;
            this.btAuthorDelAll.TabStop = false;
            this.btAuthorDelAll.Text = "DelAll";
            this.btAuthorDelAll.UseVisualStyleBackColor = true;
            // 
            // btAuthorDel
            // 
            this.btAuthorDel.Location = new System.Drawing.Point(187, 98);
            this.btAuthorDel.Name = "btAuthorDel";
            this.btAuthorDel.Size = new System.Drawing.Size(44, 29);
            this.btAuthorDel.TabIndex = 0;
            this.btAuthorDel.TabStop = false;
            this.btAuthorDel.Text = "DEL";
            this.btAuthorDel.UseVisualStyleBackColor = true;
            // 
            // btAuthorUpd
            // 
            this.btAuthorUpd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAuthorUpd.Location = new System.Drawing.Point(249, 203);
            this.btAuthorUpd.Name = "btAuthorUpd";
            this.btAuthorUpd.Size = new System.Drawing.Size(44, 29);
            this.btAuthorUpd.TabIndex = 15;
            this.btAuthorUpd.Text = "UPD";
            this.btAuthorUpd.UseVisualStyleBackColor = true;
            // 
            // btAuthorIns
            // 
            this.btAuthorIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAuthorIns.Location = new System.Drawing.Point(187, 203);
            this.btAuthorIns.Name = "btAuthorIns";
            this.btAuthorIns.Size = new System.Drawing.Size(44, 29);
            this.btAuthorIns.TabIndex = 14;
            this.btAuthorIns.Text = "INS";
            this.btAuthorIns.UseVisualStyleBackColor = true;
            this.btAuthorIns.Click += new System.EventHandler(this.btAuthorIns_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Llibres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Autors";
            // 
            // dgvAuthorBooks
            // 
            this.dgvAuthorBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuthorBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAuthorBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthorBooks.Location = new System.Drawing.Point(249, 65);
            this.dgvAuthorBooks.MultiSelect = false;
            this.dgvAuthorBooks.Name = "dgvAuthorBooks";
            this.dgvAuthorBooks.ReadOnly = true;
            this.dgvAuthorBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthorBooks.Size = new System.Drawing.Size(259, 130);
            this.dgvAuthorBooks.TabIndex = 0;
            this.dgvAuthorBooks.TabStop = false;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAuthor.Location = new System.Drawing.Point(16, 212);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(165, 20);
            this.tbAuthor.TabIndex = 13;
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Location = new System.Drawing.Point(16, 65);
            this.dgvAuthors.MultiSelect = false;
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.ReadOnly = true;
            this.dgvAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthors.Size = new System.Drawing.Size(165, 130);
            this.dgvAuthors.TabIndex = 0;
            this.dgvAuthors.TabStop = false;
            // 
            // tpBooks
            // 
            this.tpBooks.Controls.Add(this.cbBookAuthor);
            this.tpBooks.Controls.Add(this.label15);
            this.tpBooks.Controls.Add(this.label14);
            this.tpBooks.Controls.Add(this.label13);
            this.tpBooks.Controls.Add(this.tbBookPrice);
            this.tpBooks.Controls.Add(this.tbBookDescription);
            this.tpBooks.Controls.Add(this.label12);
            this.tpBooks.Controls.Add(this.ckbBookFilter);
            this.tpBooks.Controls.Add(this.tbBookFilter);
            this.tpBooks.Controls.Add(this.label9);
            this.tpBooks.Controls.Add(this.textBox3);
            this.tpBooks.Controls.Add(this.label10);
            this.tpBooks.Controls.Add(this.btBookDel);
            this.tpBooks.Controls.Add(this.btBookUpd);
            this.tpBooks.Controls.Add(this.btBookIns);
            this.tpBooks.Controls.Add(this.label11);
            this.tpBooks.Controls.Add(this.dgvBooks);
            this.tpBooks.Controls.Add(this.tbBookTitle);
            this.tpBooks.Location = new System.Drawing.Point(4, 22);
            this.tpBooks.Name = "tpBooks";
            this.tpBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tpBooks.Size = new System.Drawing.Size(636, 282);
            this.tpBooks.TabIndex = 2;
            this.tpBooks.Text = "Llibres";
            this.tpBooks.UseVisualStyleBackColor = true;
            this.tpBooks.Click += new System.EventHandler(this.tpBooks_Click);
            // 
            // cbBookAuthor
            // 
            this.cbBookAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBookAuthor.FormattingEnabled = true;
            this.cbBookAuthor.Location = new System.Drawing.Point(462, 65);
            this.cbBookAuthor.Name = "cbBookAuthor";
            this.cbBookAuthor.Size = new System.Drawing.Size(151, 21);
            this.cbBookAuthor.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Preu";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Autor";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Descripció";
            // 
            // tbBookPrice
            // 
            this.tbBookPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBookPrice.Location = new System.Drawing.Point(480, 248);
            this.tbBookPrice.Name = "tbBookPrice";
            this.tbBookPrice.Size = new System.Drawing.Size(68, 20);
            this.tbBookPrice.TabIndex = 25;
            // 
            // tbBookDescription
            // 
            this.tbBookDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBookDescription.Location = new System.Drawing.Point(153, 248);
            this.tbBookDescription.Name = "tbBookDescription";
            this.tbBookDescription.Size = new System.Drawing.Size(321, 20);
            this.tbBookDescription.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Títol";
            // 
            // ckbBookFilter
            // 
            this.ckbBookFilter.AutoSize = true;
            this.ckbBookFilter.Location = new System.Drawing.Point(179, 22);
            this.ckbBookFilter.Name = "ckbBookFilter";
            this.ckbBookFilter.Size = new System.Drawing.Size(49, 17);
            this.ckbBookFilter.TabIndex = 22;
            this.ckbBookFilter.Text = "actiu";
            this.ckbBookFilter.UseVisualStyleBackColor = true;
            // 
            // tbBookFilter
            // 
            this.tbBookFilter.Location = new System.Drawing.Point(51, 19);
            this.tbBookFilter.Name = "tbBookFilter";
            this.tbBookFilter.Size = new System.Drawing.Size(122, 20);
            this.tbBookFilter.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Filtre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(51, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Filtre";
            // 
            // btBookDel
            // 
            this.btBookDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBookDel.Location = new System.Drawing.Point(462, 166);
            this.btBookDel.Name = "btBookDel";
            this.btBookDel.Size = new System.Drawing.Size(44, 29);
            this.btBookDel.TabIndex = 0;
            this.btBookDel.TabStop = false;
            this.btBookDel.Text = "DEL";
            this.btBookDel.UseVisualStyleBackColor = true;
            // 
            // btBookUpd
            // 
            this.btBookUpd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBookUpd.Location = new System.Drawing.Point(569, 166);
            this.btBookUpd.Name = "btBookUpd";
            this.btBookUpd.Size = new System.Drawing.Size(44, 29);
            this.btBookUpd.TabIndex = 28;
            this.btBookUpd.Text = "UPD";
            this.btBookUpd.UseVisualStyleBackColor = true;
            this.btBookUpd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btBookIns
            // 
            this.btBookIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBookIns.Location = new System.Drawing.Point(569, 239);
            this.btBookIns.Name = "btBookIns";
            this.btBookIns.Size = new System.Drawing.Size(44, 29);
            this.btBookIns.TabIndex = 26;
            this.btBookIns.Text = "INS";
            this.btBookIns.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Llibres";
            // 
            // dgvBooks
            // 
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(19, 65);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(423, 154);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.TabStop = false;
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBookTitle.Location = new System.Drawing.Point(19, 248);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(128, 20);
            this.tbBookTitle.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 308);
            this.Controls.Add(this.tcAuthorsBooks);
            this.Name = "Form1";
            this.Text = "MVC - Authors/Books";
            this.tcAuthorsBooks.ResumeLayout(false);
            this.tpCombos.ResumeLayout(false);
            this.tpCombos.PerformLayout();
            this.tpAuthors.ResumeLayout(false);
            this.tpAuthors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.tpBooks.ResumeLayout(false);
            this.tpBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAuthorsBooks;
        public System.Windows.Forms.TextBox tbPrice;
        public System.Windows.Forms.TextBox tbDescrip;
        public System.Windows.Forms.ComboBox cbBooks;
        public System.Windows.Forms.ComboBox cbAuthors;
        public System.Windows.Forms.DataGridView dgvAuthors;
        public System.Windows.Forms.TextBox tbAuthor;
        public System.Windows.Forms.DataGridView dgvAuthorBooks;
        public System.Windows.Forms.TextBox tbAuthorFilter;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox tbBookFilter;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.DataGridView dgvBooks;
        public System.Windows.Forms.TextBox tbBookTitle;
        public System.Windows.Forms.TextBox tbBookPrice;
        public System.Windows.Forms.TextBox tbBookDescription;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btAuthorDelAll;
        public System.Windows.Forms.Button btAuthorDel;
        public System.Windows.Forms.Button btAuthorUpd;
        public System.Windows.Forms.Button btAuthorIns;
        public System.Windows.Forms.CheckBox ckbAuthorFilter;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.CheckBox ckbBookFilter;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btBookDel;
        public System.Windows.Forms.Button btBookUpd;
        public System.Windows.Forms.Button btBookIns;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cbBookAuthor;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TabPage tpCombos;
        public System.Windows.Forms.TabPage tpAuthors;
        public System.Windows.Forms.TabPage tpBooks;
    }
}

