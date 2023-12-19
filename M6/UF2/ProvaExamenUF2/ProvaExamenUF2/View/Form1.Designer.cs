namespace ProvaExamenUF2.View
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
            this.lbContactes = new System.Windows.Forms.ListBox();
            this.dgvEmails = new System.Windows.Forms.DataGridView();
            this.cbTelefons = new System.Windows.Forms.ComboBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbEmails = new System.Windows.Forms.TextBox();
            this.bAfegirEmail = new System.Windows.Forms.Button();
            this.bAfegirTelefon = new System.Windows.Forms.Button();
            this.bDeleteTelefon = new System.Windows.Forms.Button();
            this.bUpdateTelefon = new System.Windows.Forms.Button();
            this.bDeleteEmail = new System.Windows.Forms.Button();
            this.bUpdateEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContactes
            // 
            this.lbContactes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbContactes.FormattingEnabled = true;
            this.lbContactes.Location = new System.Drawing.Point(24, 12);
            this.lbContactes.Name = "lbContactes";
            this.lbContactes.Size = new System.Drawing.Size(138, 251);
            this.lbContactes.TabIndex = 0;
            // 
            // dgvEmails
            // 
            this.dgvEmails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmails.Location = new System.Drawing.Point(218, 12);
            this.dgvEmails.MultiSelect = false;
            this.dgvEmails.Name = "dgvEmails";
            this.dgvEmails.ReadOnly = true;
            this.dgvEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmails.Size = new System.Drawing.Size(240, 150);
            this.dgvEmails.TabIndex = 1;
            // 
            // cbTelefons
            // 
            this.cbTelefons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbTelefons.FormattingEnabled = true;
            this.cbTelefons.Location = new System.Drawing.Point(218, 185);
            this.cbTelefons.Name = "cbTelefons";
            this.cbTelefons.Size = new System.Drawing.Size(121, 21);
            this.cbTelefons.TabIndex = 2;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbTelefon.Location = new System.Drawing.Point(218, 212);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbTelefon.TabIndex = 3;
            // 
            // tbEmails
            // 
            this.tbEmails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbEmails.Location = new System.Drawing.Point(218, 243);
            this.tbEmails.Name = "tbEmails";
            this.tbEmails.Size = new System.Drawing.Size(100, 20);
            this.tbEmails.TabIndex = 4;
            // 
            // bAfegirEmail
            // 
            this.bAfegirEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAfegirEmail.Location = new System.Drawing.Point(504, 171);
            this.bAfegirEmail.Name = "bAfegirEmail";
            this.bAfegirEmail.Size = new System.Drawing.Size(75, 23);
            this.bAfegirEmail.TabIndex = 5;
            this.bAfegirEmail.Text = "Af.Em";
            this.bAfegirEmail.UseVisualStyleBackColor = true;
            this.bAfegirEmail.Click += new System.EventHandler(this.bAfegirEmail_Click);
            // 
            // bAfegirTelefon
            // 
            this.bAfegirTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAfegirTelefon.Location = new System.Drawing.Point(504, 42);
            this.bAfegirTelefon.Name = "bAfegirTelefon";
            this.bAfegirTelefon.Size = new System.Drawing.Size(75, 23);
            this.bAfegirTelefon.TabIndex = 6;
            this.bAfegirTelefon.TabStop = false;
            this.bAfegirTelefon.Text = "Af.Tel";
            this.bAfegirTelefon.UseVisualStyleBackColor = true;
            this.bAfegirTelefon.Click += new System.EventHandler(this.bAfegirTelefon_Click);
            // 
            // bDeleteTelefon
            // 
            this.bDeleteTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteTelefon.Location = new System.Drawing.Point(504, 100);
            this.bDeleteTelefon.Name = "bDeleteTelefon";
            this.bDeleteTelefon.Size = new System.Drawing.Size(75, 23);
            this.bDeleteTelefon.TabIndex = 7;
            this.bDeleteTelefon.Text = "Del.Tel";
            this.bDeleteTelefon.UseVisualStyleBackColor = true;
            this.bDeleteTelefon.Click += new System.EventHandler(this.bDeleteTelefon_Click);
            // 
            // bUpdateTelefon
            // 
            this.bUpdateTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpdateTelefon.Location = new System.Drawing.Point(504, 71);
            this.bUpdateTelefon.Name = "bUpdateTelefon";
            this.bUpdateTelefon.Size = new System.Drawing.Size(75, 23);
            this.bUpdateTelefon.TabIndex = 8;
            this.bUpdateTelefon.Text = "Upd.Tel";
            this.bUpdateTelefon.UseVisualStyleBackColor = true;
            this.bUpdateTelefon.Click += new System.EventHandler(this.bUpdateTelefon_Click);
            // 
            // bDeleteEmail
            // 
            this.bDeleteEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteEmail.Location = new System.Drawing.Point(504, 229);
            this.bDeleteEmail.Name = "bDeleteEmail";
            this.bDeleteEmail.Size = new System.Drawing.Size(75, 23);
            this.bDeleteEmail.TabIndex = 9;
            this.bDeleteEmail.Text = "Del.Em";
            this.bDeleteEmail.UseVisualStyleBackColor = true;
            this.bDeleteEmail.Click += new System.EventHandler(this.bDeleteEmail_Click);
            // 
            // bUpdateEmail
            // 
            this.bUpdateEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpdateEmail.Location = new System.Drawing.Point(504, 200);
            this.bUpdateEmail.Name = "bUpdateEmail";
            this.bUpdateEmail.Size = new System.Drawing.Size(75, 23);
            this.bUpdateEmail.TabIndex = 10;
            this.bUpdateEmail.Text = "Upd.Em";
            this.bUpdateEmail.UseVisualStyleBackColor = true;
            this.bUpdateEmail.Click += new System.EventHandler(this.bUpdateEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 300);
            this.Controls.Add(this.bUpdateEmail);
            this.Controls.Add(this.bDeleteEmail);
            this.Controls.Add(this.bUpdateTelefon);
            this.Controls.Add(this.bDeleteTelefon);
            this.Controls.Add(this.bAfegirTelefon);
            this.Controls.Add(this.bAfegirEmail);
            this.Controls.Add(this.tbEmails);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.cbTelefons);
            this.Controls.Add(this.dgvEmails);
            this.Controls.Add(this.lbContactes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbContactes;
        public System.Windows.Forms.DataGridView dgvEmails;
        public System.Windows.Forms.ComboBox cbTelefons;
        public System.Windows.Forms.TextBox tbTelefon;
        public System.Windows.Forms.TextBox tbEmails;
        public System.Windows.Forms.Button bAfegirEmail;
        public System.Windows.Forms.Button bAfegirTelefon;
        public System.Windows.Forms.Button bDeleteTelefon;
        public System.Windows.Forms.Button bUpdateTelefon;
        public System.Windows.Forms.Button bDeleteEmail;
        public System.Windows.Forms.Button bUpdateEmail;
    }
}

