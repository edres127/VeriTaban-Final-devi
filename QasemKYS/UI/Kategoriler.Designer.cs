namespace QasemKYS.UI
{
    partial class Kategoriler
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
            this.dataGridViewKategoriler = new System.Windows.Forms.DataGridView();
            this.toolStripUyu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.labelKategorilerAra = new System.Windows.Forms.ToolStripLabel();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnKategorilerEkle = new System.Windows.Forms.ToolStripButton();
            this.btnKategorilerduzenlı = new System.Windows.Forms.ToolStripButton();
            this.btnKategorilersıl = new System.Windows.Forms.ToolStripButton();
            this.btnKategorilerBul = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategoriler)).BeginInit();
            this.toolStripUyu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 389);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewKategoriler);
            this.tabPage1.Controls.Add(this.toolStripUyu);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kategoriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKategoriler
            // 
            this.dataGridViewKategoriler.AllowUserToAddRows = false;
            this.dataGridViewKategoriler.AllowUserToDeleteRows = false;
            this.dataGridViewKategoriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategoriler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewKategoriler.Location = new System.Drawing.Point(3, 40);
            this.dataGridViewKategoriler.MultiSelect = false;
            this.dataGridViewKategoriler.Name = "dataGridViewKategoriler";
            this.dataGridViewKategoriler.RowHeadersWidth = 62;
            this.dataGridViewKategoriler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewKategoriler.RowTemplate.Height = 29;
            this.dataGridViewKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKategoriler.Size = new System.Drawing.Size(872, 375);
            this.dataGridViewKategoriler.TabIndex = 1;
            // 
            // toolStripUyu
            // 
            this.toolStripUyu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripUyu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKategorilerEkle,
            this.btnKategorilerduzenlı,
            this.btnKategorilersıl,
            this.toolStripSeparator1,
            this.btnKategorilerBul,
            this.toolStripTextBox1,
            this.labelKategorilerAra});
            this.toolStripUyu.Location = new System.Drawing.Point(3, 3);
            this.toolStripUyu.Name = "toolStripUyu";
            this.toolStripUyu.Size = new System.Drawing.Size(863, 34);
            this.toolStripUyu.TabIndex = 0;
            this.toolStripUyu.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
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
            // labelKategorilerAra
            // 
            this.labelKategorilerAra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelKategorilerAra.Name = "labelKategorilerAra";
            this.labelKategorilerAra.Size = new System.Drawing.Size(39, 29);
            this.labelKategorilerAra.Text = "Ara";
            // 
            // btniptal
            // 
            this.btniptal.AllowDrop = true;
            this.btniptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(753, 406);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(108, 47);
            this.btniptal.TabIndex = 11;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTamam.Location = new System.Drawing.Point(637, 406);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(108, 47);
            this.btnTamam.TabIndex = 10;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnKategorilerEkle
            // 
            this.btnKategorilerEkle.Image = global::QasemKYS.Properties.Resources.database_user_add;
            this.btnKategorilerEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKategorilerEkle.Name = "btnKategorilerEkle";
            this.btnKategorilerEkle.Size = new System.Drawing.Size(71, 29);
            this.btnKategorilerEkle.Text = "Ekle";
            this.btnKategorilerEkle.Click += new System.EventHandler(this.btnKategorilerEkle_Click);
            // 
            // btnKategorilerduzenlı
            // 
            this.btnKategorilerduzenlı.Image = global::QasemKYS.Properties.Resources.database_user_edit;
            this.btnKategorilerduzenlı.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKategorilerduzenlı.Name = "btnKategorilerduzenlı";
            this.btnKategorilerduzenlı.Size = new System.Drawing.Size(103, 29);
            this.btnKategorilerduzenlı.Text = "Düzenle";
            this.btnKategorilerduzenlı.Click += new System.EventHandler(this.btnKategorilerduzenlı_Click);
            // 
            // btnKategorilersıl
            // 
            this.btnKategorilersıl.Image = global::QasemKYS.Properties.Resources.database_user_remove;
            this.btnKategorilersıl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKategorilersıl.Name = "btnKategorilersıl";
            this.btnKategorilersıl.Size = new System.Drawing.Size(58, 29);
            this.btnKategorilersıl.Text = "Sil";
            this.btnKategorilersıl.Click += new System.EventHandler(this.btnKategorilersıl_Click);
            // 
            // btnKategorilerBul
            // 
            this.btnKategorilerBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKategorilerBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKategorilerBul.Image = global::QasemKYS.Properties.Resources.database_user_search;
            this.btnKategorilerBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKategorilerBul.Name = "btnKategorilerBul";
            this.btnKategorilerBul.Size = new System.Drawing.Size(34, 29);
            this.btnKategorilerBul.Text = "Bul";
            this.btnKategorilerBul.Click += new System.EventHandler(this.btnKategorilerBul_Click);
            // 
            // Kategoriler
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(877, 466);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnTamam);
            this.Name = "Kategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategoriler)).EndInit();
            this.toolStripUyu.ResumeLayout(false);
            this.toolStripUyu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewKategoriler;
        private System.Windows.Forms.ToolStrip toolStripUyu;
        private System.Windows.Forms.ToolStripButton btnKategorilerEkle;
        private System.Windows.Forms.ToolStripButton btnKategorilerduzenlı;
        private System.Windows.Forms.ToolStripButton btnKategorilersıl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnKategorilerBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel labelKategorilerAra;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamam;
    }
}