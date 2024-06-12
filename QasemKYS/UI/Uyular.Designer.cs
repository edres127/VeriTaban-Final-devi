namespace QasemKYS.UI
{
    partial class Uyular
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
            this.labelUyuAra = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewUyular = new System.Windows.Forms.DataGridView();
            this.toolStripUyu = new System.Windows.Forms.ToolStrip();
            this.btnUyuEkle = new System.Windows.Forms.ToolStripButton();
            this.btnUyuduzenlı = new System.Windows.Forms.ToolStripButton();
            this.btnUyusıl = new System.Windows.Forms.ToolStripButton();
            this.btnUyuBul = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyular)).BeginInit();
            this.toolStripUyu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUyuAra
            // 
            this.labelUyuAra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelUyuAra.Name = "labelUyuAra";
            this.labelUyuAra.Size = new System.Drawing.Size(39, 29);
            this.labelUyuAra.Text = "Ara";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 31);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // dataGridViewUyular
            // 
            this.dataGridViewUyular.AllowUserToAddRows = false;
            this.dataGridViewUyular.AllowUserToDeleteRows = false;
            this.dataGridViewUyular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUyular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUyular.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewUyular.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewUyular.MultiSelect = false;
            this.dataGridViewUyular.Name = "dataGridViewUyular";
            this.dataGridViewUyular.RowHeadersWidth = 62;
            this.dataGridViewUyular.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUyular.RowTemplate.Height = 29;
            this.dataGridViewUyular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUyular.Size = new System.Drawing.Size(1097, 378);
            this.dataGridViewUyular.TabIndex = 1;
            // 
            // toolStripUyu
            // 
            this.toolStripUyu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripUyu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUyuEkle,
            this.btnUyuduzenlı,
            this.btnUyusıl,
            this.toolStripSeparator1,
            this.btnUyuBul,
            this.toolStripTextBox1,
            this.labelUyuAra});
            this.toolStripUyu.Location = new System.Drawing.Point(3, 3);
            this.toolStripUyu.Name = "toolStripUyu";
            this.toolStripUyu.Size = new System.Drawing.Size(1088, 38);
            this.toolStripUyu.TabIndex = 0;
            this.toolStripUyu.Text = "toolStrip1";
            // 
            // btnUyuEkle
            // 
            this.btnUyuEkle.Image = global::QasemKYS.Properties.Resources.database_user_add;
            this.btnUyuEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUyuEkle.Name = "btnUyuEkle";
            this.btnUyuEkle.Size = new System.Drawing.Size(71, 29);
            this.btnUyuEkle.Text = "Ekle";
            this.btnUyuEkle.Click += new System.EventHandler(this.btnUyuEkle_Click);
            // 
            // btnUyuduzenlı
            // 
            this.btnUyuduzenlı.Image = global::QasemKYS.Properties.Resources.database_user_edit;
            this.btnUyuduzenlı.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUyuduzenlı.Name = "btnUyuduzenlı";
            this.btnUyuduzenlı.Size = new System.Drawing.Size(103, 29);
            this.btnUyuduzenlı.Text = "Düzenle";
            this.btnUyuduzenlı.Click += new System.EventHandler(this.btnUyuduzenlı_Click);
            // 
            // btnUyusıl
            // 
            this.btnUyusıl.Image = global::QasemKYS.Properties.Resources.database_user_remove;
            this.btnUyusıl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUyusıl.Name = "btnUyusıl";
            this.btnUyusıl.Size = new System.Drawing.Size(58, 29);
            this.btnUyusıl.Text = "Sil";
            this.btnUyusıl.Click += new System.EventHandler(this.btnUyusıl_Click);
            // 
            // btnUyuBul
            // 
            this.btnUyuBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUyuBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUyuBul.Image = global::QasemKYS.Properties.Resources.database_user_search;
            this.btnUyuBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUyuBul.Name = "btnUyuBul";
            this.btnUyuBul.Size = new System.Drawing.Size(34, 29);
            this.btnUyuBul.Text = "Bul";
            this.btnUyuBul.Click += new System.EventHandler(this.btnUyuBul_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewUyular);
            this.tabPage1.Controls.Add(this.toolStripUyu);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uyu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1102, 389);
            this.tabControl1.TabIndex = 2;
            // 
            // btniptal
            // 
            this.btniptal.AllowDrop = true;
            this.btniptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(987, 431);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(108, 47);
            this.btniptal.TabIndex = 8;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTamam.Location = new System.Drawing.Point(871, 431);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(108, 47);
            this.btnTamam.TabIndex = 7;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // Uyular
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(1102, 504);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.tabControl1);
            this.Name = "Uyular";
            this.Text = "Uyular";
            this.Load += new System.EventHandler(this.Uyular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyular)).EndInit();
            this.toolStripUyu.ResumeLayout(false);
            this.toolStripUyu.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripLabel labelUyuAra;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton btnUyuBul;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUyusıl;
        private System.Windows.Forms.ToolStripButton btnUyuduzenlı;
        private System.Windows.Forms.ToolStripButton btnUyuEkle;
        private System.Windows.Forms.DataGridView dataGridViewUyular;
        private System.Windows.Forms.ToolStrip toolStripUyu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamam;
    }
}