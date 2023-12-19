namespace RocaXavierExamenUF2.View
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
            this.dgvEquOCicl = new System.Windows.Forms.DataGridView();
            this.rbCiclistes = new System.Windows.Forms.RadioButton();
            this.rbEquips = new System.Windows.Forms.RadioButton();
            this.dgvEtapesGuanyades = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCiclistesEquip = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.laCountCiclistes = new System.Windows.Forms.Label();
            this.laCountEtapesGuanyades = new System.Windows.Forms.Label();
            this.laCiclistesEquip = new System.Windows.Forms.Label();
            this.dgvPortsGuanyats = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.laPortsGuanyats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquOCicl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapesGuanyades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclistesEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortsGuanyats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquOCicl
            // 
            this.dgvEquOCicl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquOCicl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquOCicl.Location = new System.Drawing.Point(36, 81);
            this.dgvEquOCicl.MultiSelect = false;
            this.dgvEquOCicl.Name = "dgvEquOCicl";
            this.dgvEquOCicl.ReadOnly = true;
            this.dgvEquOCicl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquOCicl.Size = new System.Drawing.Size(240, 150);
            this.dgvEquOCicl.TabIndex = 2;
            // 
            // rbCiclistes
            // 
            this.rbCiclistes.AutoSize = true;
            this.rbCiclistes.Location = new System.Drawing.Point(36, 33);
            this.rbCiclistes.Name = "rbCiclistes";
            this.rbCiclistes.Size = new System.Drawing.Size(63, 17);
            this.rbCiclistes.TabIndex = 5;
            this.rbCiclistes.TabStop = true;
            this.rbCiclistes.Text = "Ciclistes";
            this.rbCiclistes.UseVisualStyleBackColor = true;
            this.rbCiclistes.CheckedChanged += new System.EventHandler(this.rbCiclistes_CheckedChanged);
            // 
            // rbEquips
            // 
            this.rbEquips.AutoSize = true;
            this.rbEquips.Location = new System.Drawing.Point(105, 33);
            this.rbEquips.Name = "rbEquips";
            this.rbEquips.Size = new System.Drawing.Size(57, 17);
            this.rbEquips.TabIndex = 6;
            this.rbEquips.TabStop = true;
            this.rbEquips.Text = "Equips";
            this.rbEquips.UseVisualStyleBackColor = true;
            // 
            // dgvEtapesGuanyades
            // 
            this.dgvEtapesGuanyades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEtapesGuanyades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapesGuanyades.Location = new System.Drawing.Point(302, 81);
            this.dgvEtapesGuanyades.MultiSelect = false;
            this.dgvEtapesGuanyades.Name = "dgvEtapesGuanyades";
            this.dgvEtapesGuanyades.ReadOnly = true;
            this.dgvEtapesGuanyades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapesGuanyades.Size = new System.Drawing.Size(462, 150);
            this.dgvEtapesGuanyades.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Etapes Guanyades";
            // 
            // dgvCiclistesEquip
            // 
            this.dgvCiclistesEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCiclistesEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiclistesEquip.Location = new System.Drawing.Point(36, 264);
            this.dgvCiclistesEquip.MultiSelect = false;
            this.dgvCiclistesEquip.Name = "dgvCiclistesEquip";
            this.dgvCiclistesEquip.ReadOnly = true;
            this.dgvCiclistesEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiclistesEquip.Size = new System.Drawing.Size(240, 150);
            this.dgvCiclistesEquip.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ciclistes de l\'equip";
            // 
            // laCountCiclistes
            // 
            this.laCountCiclistes.AutoSize = true;
            this.laCountCiclistes.Location = new System.Drawing.Point(195, 35);
            this.laCountCiclistes.Name = "laCountCiclistes";
            this.laCountCiclistes.Size = new System.Drawing.Size(81, 13);
            this.laCountCiclistes.TabIndex = 11;
            this.laCountCiclistes.Text = "laCountCiclistes";
            // 
            // laCountEtapesGuanyades
            // 
            this.laCountEtapesGuanyades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laCountEtapesGuanyades.AutoSize = true;
            this.laCountEtapesGuanyades.Location = new System.Drawing.Point(473, 65);
            this.laCountEtapesGuanyades.Name = "laCountEtapesGuanyades";
            this.laCountEtapesGuanyades.Size = new System.Drawing.Size(35, 13);
            this.laCountEtapesGuanyades.TabIndex = 12;
            this.laCountEtapesGuanyades.Text = "label5";
            // 
            // laCiclistesEquip
            // 
            this.laCiclistesEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.laCiclistesEquip.AutoSize = true;
            this.laCiclistesEquip.Location = new System.Drawing.Point(229, 248);
            this.laCiclistesEquip.Name = "laCiclistesEquip";
            this.laCiclistesEquip.Size = new System.Drawing.Size(35, 13);
            this.laCiclistesEquip.TabIndex = 13;
            this.laCiclistesEquip.Text = "label6";
            // 
            // dgvPortsGuanyats
            // 
            this.dgvPortsGuanyats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPortsGuanyats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPortsGuanyats.Location = new System.Drawing.Point(302, 264);
            this.dgvPortsGuanyats.MultiSelect = false;
            this.dgvPortsGuanyats.Name = "dgvPortsGuanyats";
            this.dgvPortsGuanyats.ReadOnly = true;
            this.dgvPortsGuanyats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPortsGuanyats.Size = new System.Drawing.Size(462, 150);
            this.dgvPortsGuanyats.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ports Guanyats";
            // 
            // laPortsGuanyats
            // 
            this.laPortsGuanyats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laPortsGuanyats.AutoSize = true;
            this.laPortsGuanyats.Location = new System.Drawing.Point(473, 248);
            this.laPortsGuanyats.Name = "laPortsGuanyats";
            this.laPortsGuanyats.Size = new System.Drawing.Size(35, 13);
            this.laPortsGuanyats.TabIndex = 16;
            this.laPortsGuanyats.Text = "label8";
            this.laPortsGuanyats.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.laPortsGuanyats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPortsGuanyats);
            this.Controls.Add(this.laCiclistesEquip);
            this.Controls.Add(this.laCountEtapesGuanyades);
            this.Controls.Add(this.laCountCiclistes);
            this.Controls.Add(this.dgvCiclistesEquip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEtapesGuanyades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbEquips);
            this.Controls.Add(this.rbCiclistes);
            this.Controls.Add(this.dgvEquOCicl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquOCicl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapesGuanyades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclistesEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortsGuanyats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvEquOCicl;
        public System.Windows.Forms.RadioButton rbCiclistes;
        public System.Windows.Forms.RadioButton rbEquips;
        public System.Windows.Forms.DataGridView dgvEtapesGuanyades;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvCiclistesEquip;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label laCountCiclistes;
        public System.Windows.Forms.Label laCountEtapesGuanyades;
        public System.Windows.Forms.Label laCiclistesEquip;
        public System.Windows.Forms.DataGridView dgvPortsGuanyats;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label laPortsGuanyats;
    }
}

