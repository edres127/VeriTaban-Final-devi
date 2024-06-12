namespace QasemKYS.UI
{
    partial class Yazarlar
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
            this.dataGridViewYazarlar = new System.Windows.Forms.DataGridView();
            this.toolStripYazarlar = new System.Windows.Forms.ToolStrip();
            this.btnYazarEkle = new System.Windows.Forms.ToolStripButton();
            this.btnYazarduzenlı = new System.Windows.Forms.ToolStripButton();
            this.btnYazarsıl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYazarBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.labelYazarAra = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYazarlar)).BeginInit();
            this.toolStripYazarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 510);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btniptal);
            this.tabPage1.Controls.Add(this.btnTamam);
            this.tabPage1.Controls.Add(this.dataGridViewYazarlar);
            this.tabPage1.Controls.Add(this.toolStripYazarlar);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yazarlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.AllowDrop = true;
            this.btniptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(801, 417);
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
            this.btnTamam.Location = new System.Drawing.Point(685, 417);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(108, 35);
            this.btnTamam.TabIndex = 9;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // dataGridViewYazarlar
            // 
            this.dataGridViewYazarlar.AllowUserToAddRows = false;
            this.dataGridViewYazarlar.AllowUserToDeleteRows = false;
            this.dataGridViewYazarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYazarlar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewYazarlar.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewYazarlar.MultiSelect = false;
            this.dataGridViewYazarlar.Name = "dataGridViewYazarlar";
            this.dataGridViewYazarlar.RowHeadersWidth = 62;
            this.dataGridViewYazarlar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewYazarlar.RowTemplate.Height = 29;
            this.dataGridViewYazarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYazarlar.Size = new System.Drawing.Size(903, 373);
            this.dataGridViewYazarlar.TabIndex = 2;
            // 
            // toolStripYazarlar
            // 
            this.toolStripYazarlar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripYazarlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYazarEkle,
            this.btnYazarduzenlı,
            this.btnYazarsıl,
            this.toolStripSeparator1,
            this.btnYazarBul,
            this.toolStripTextBox1,
            this.labelYazarAra});
            this.toolStripYazarlar.Location = new System.Drawing.Point(3, 3);
            this.toolStripYazarlar.Name = "toolStripYazarlar";
            this.toolStripYazarlar.Size = new System.Drawing.Size(935, 38);
            this.toolStripYazarlar.TabIndex = 0;
            this.toolStripYazarlar.Text = "toolStrip1";
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Image = global::QasemKYS.Properties.Resources.database_user_add;
            this.btnYazarEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(71, 33);
            this.btnYazarEkle.Text = "Ekle";
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // btnYazarduzenlı
            // 
            this.btnYazarduzenlı.Image = global::QasemKYS.Properties.Resources.database_user_edit;
            this.btnYazarduzenlı.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYazarduzenlı.Name = "btnYazarduzenlı";
            this.btnYazarduzenlı.Size = new System.Drawing.Size(103, 33);
            this.btnYazarduzenlı.Text = "Düzenle";
            this.btnYazarduzenlı.Click += new System.EventHandler(this.btnYazarduzenlı_Click);
            // 
            // btnYazarsıl
            // 
            this.btnYazarsıl.Image = global::QasemKYS.Properties.Resources.database_user_remove;
            this.btnYazarsıl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYazarsıl.Name = "btnYazarsıl";
            this.btnYazarsıl.Size = new System.Drawing.Size(58, 33);
            this.btnYazarsıl.Text = "Sil";
            this.btnYazarsıl.Click += new System.EventHandler(this.btnYazarsıl_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnYazarBul
            // 
            this.btnYazarBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnYazarBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYazarBul.Image = global::QasemKYS.Properties.Resources.database_user_search;
            this.btnYazarBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYazarBul.Name = "btnYazarBul";
            this.btnYazarBul.Size = new System.Drawing.Size(34, 33);
            this.btnYazarBul.Text = "Bul";
            this.btnYazarBul.Click += new System.EventHandler(this.btnYazarBul_Click);
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
            // labelYazarAra
            // 
            this.labelYazarAra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelYazarAra.Name = "labelYazarAra";
            this.labelYazarAra.Size = new System.Drawing.Size(39, 33);
            this.labelYazarAra.Text = "Ara";
            // 
            // Yazarlar
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(949, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "Yazarlar";
            this.Text = "Yazarlar";
            this.Load += new System.EventHandler(this.Yazarlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYazarlar)).EndInit();
            this.toolStripYazarlar.ResumeLayout(false);
            this.toolStripYazarlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStripYazarlar;
        private System.Windows.Forms.ToolStripButton btnYazarEkle;
        private System.Windows.Forms.ToolStripButton btnYazarduzenlı;
        private System.Windows.Forms.ToolStripButton btnYazarsıl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnYazarBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel labelYazarAra;
        private System.Windows.Forms.DataGridView dataGridViewYazarlar;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamam;
    }
}