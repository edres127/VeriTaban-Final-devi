namespace QasemKYS.UI
{
    partial class Personeliler
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.dataGridViewPersoneliler = new System.Windows.Forms.DataGridView();
            this.btnPersonelilerEkle = new System.Windows.Forms.ToolStripButton();
            this.btnPersonelilerduzenlı = new System.Windows.Forms.ToolStripButton();
            this.btnPersonelilersıl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPersonelilerBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.labelPersonelilerAra = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPersoneliler = new System.Windows.Forms.ToolStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneliler)).BeginInit();
            this.toolStripPersoneliler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 455);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btniptal);
            this.tabPage1.Controls.Add(this.btnTamam);
            this.tabPage1.Controls.Add(this.dataGridViewPersoneliler);
            this.tabPage1.Controls.Add(this.toolStripPersoneliler);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personeliler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.AllowDrop = true;
            this.btniptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(693, 362);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(108, 35);
            this.btniptal.TabIndex = 10;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTamam.Location = new System.Drawing.Point(577, 362);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(108, 35);
            this.btnTamam.TabIndex = 9;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // dataGridViewPersoneliler
            // 
            this.dataGridViewPersoneliler.AllowUserToAddRows = false;
            this.dataGridViewPersoneliler.AllowUserToDeleteRows = false;
            this.dataGridViewPersoneliler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPersoneliler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneliler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPersoneliler.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewPersoneliler.MultiSelect = false;
            this.dataGridViewPersoneliler.Name = "dataGridViewPersoneliler";
            this.dataGridViewPersoneliler.RowHeadersWidth = 62;
            this.dataGridViewPersoneliler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPersoneliler.RowTemplate.Height = 29;
            this.dataGridViewPersoneliler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersoneliler.Size = new System.Drawing.Size(795, 318);
            this.dataGridViewPersoneliler.TabIndex = 2;
            // 
            // btnPersonelilerEkle
            // 
            this.btnPersonelilerEkle.Image = global::QasemKYS.Properties.Resources.database_user_add;
            this.btnPersonelilerEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonelilerEkle.Name = "btnPersonelilerEkle";
            this.btnPersonelilerEkle.Size = new System.Drawing.Size(71, 29);
            this.btnPersonelilerEkle.Text = "Ekle";
            this.btnPersonelilerEkle.Click += new System.EventHandler(this.btnPersonelilerEkle_Click);
            // 
            // btnPersonelilerduzenlı
            // 
            this.btnPersonelilerduzenlı.Image = global::QasemKYS.Properties.Resources.database_user_edit;
            this.btnPersonelilerduzenlı.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonelilerduzenlı.Name = "btnPersonelilerduzenlı";
            this.btnPersonelilerduzenlı.Size = new System.Drawing.Size(103, 29);
            this.btnPersonelilerduzenlı.Text = "Düzenle";
            this.btnPersonelilerduzenlı.Click += new System.EventHandler(this.btnPersonelilerduzenlı_Click);
            // 
            // btnPersonelilersıl
            // 
            this.btnPersonelilersıl.Image = global::QasemKYS.Properties.Resources.database_user_remove;
            this.btnPersonelilersıl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonelilersıl.Name = "btnPersonelilersıl";
            this.btnPersonelilersıl.Size = new System.Drawing.Size(58, 29);
            this.btnPersonelilersıl.Text = "Sil";
            this.btnPersonelilersıl.Click += new System.EventHandler(this.btnPersonelilersıl_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnPersonelilerBul
            // 
            this.btnPersonelilerBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPersonelilerBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPersonelilerBul.Image = global::QasemKYS.Properties.Resources.database_user_search;
            this.btnPersonelilerBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonelilerBul.Name = "btnPersonelilerBul";
            this.btnPersonelilerBul.Size = new System.Drawing.Size(34, 29);
            this.btnPersonelilerBul.Text = "Bul";
            this.btnPersonelilerBul.Click += new System.EventHandler(this.btnPersonelilerBul_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 31);
            // 
            // labelPersonelilerAra
            // 
            this.labelPersonelilerAra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelPersonelilerAra.Name = "labelPersonelilerAra";
            this.labelPersonelilerAra.Size = new System.Drawing.Size(39, 29);
            this.labelPersonelilerAra.Text = "Ara";
            // 
            // toolStripPersoneliler
            // 
            this.toolStripPersoneliler.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripPersoneliler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPersonelilerEkle,
            this.btnPersonelilerduzenlı,
            this.btnPersonelilersıl,
            this.toolStripSeparator1,
            this.btnPersonelilerBul,
            this.toolStripTextBox1,
            this.labelPersonelilerAra});
            this.toolStripPersoneliler.Location = new System.Drawing.Point(3, 3);
            this.toolStripPersoneliler.Name = "toolStripPersoneliler";
            this.toolStripPersoneliler.Size = new System.Drawing.Size(827, 34);
            this.toolStripPersoneliler.TabIndex = 0;
            this.toolStripPersoneliler.Text = "toolStrip1";
            // 
            // Personeliler
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(841, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "Personeliler";
            this.Text = "Kutuphane Personelleri";
            this.Load += new System.EventHandler(this.Personeliler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneliler)).EndInit();
            this.toolStripPersoneliler.ResumeLayout(false);
            this.toolStripPersoneliler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.DataGridView dataGridViewPersoneliler;
        private System.Windows.Forms.ToolStrip toolStripPersoneliler;
        private System.Windows.Forms.ToolStripButton btnPersonelilerEkle;
        private System.Windows.Forms.ToolStripButton btnPersonelilerduzenlı;
        private System.Windows.Forms.ToolStripButton btnPersonelilersıl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPersonelilerBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel labelPersonelilerAra;
    }
}