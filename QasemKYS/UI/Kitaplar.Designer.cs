namespace QasemKYS.UI
{
    partial class Kitaplar
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
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnKitaplarEkle = new System.Windows.Forms.ToolStripButton();
            this.btnKitaplarduzenle = new System.Windows.Forms.ToolStripButton();
            this.btnKitaplarsil = new System.Windows.Forms.ToolStripButton();
            this.btnKitaplarBul = new System.Windows.Forms.ToolStripButton();
            this.labelKitaplarAra = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AllowUserToAddRows = false;
            this.dataGridViewKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewKitaplar.MultiSelect = false;
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.RowHeadersWidth = 62;
            this.dataGridViewKitaplar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewKitaplar.RowTemplate.Height = 29;
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(786, 306);
            this.dataGridViewKitaplar.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKitaplarEkle,
            this.btnKitaplarduzenle,
            this.btnKitaplarsil,
            this.toolStripSeparator2,
            this.btnKitaplarBul,
            this.toolStripTextBox2,
            this.labelKitaplarAra});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(786, 38);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnKitaplarEkle
            // 
            this.btnKitaplarEkle.Image = global::QasemKYS.Properties.Resources.book_add;
            this.btnKitaplarEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKitaplarEkle.Name = "btnKitaplarEkle";
            this.btnKitaplarEkle.Size = new System.Drawing.Size(71, 33);
            this.btnKitaplarEkle.Text = "Ekle";
            this.btnKitaplarEkle.Click += new System.EventHandler(this.btnKitaplarEkle_Click);
            // 
            // btnKitaplarduzenle
            // 
            this.btnKitaplarduzenle.Image = global::QasemKYS.Properties.Resources.book_edit;
            this.btnKitaplarduzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKitaplarduzenle.Name = "btnKitaplarduzenle";
            this.btnKitaplarduzenle.Size = new System.Drawing.Size(103, 33);
            this.btnKitaplarduzenle.Text = "Düzenle";
            this.btnKitaplarduzenle.Click += new System.EventHandler(this.btnKitaplarduzenle_Click);
            // 
            // btnKitaplarsil
            // 
            this.btnKitaplarsil.Image = global::QasemKYS.Properties.Resources.book_remove;
            this.btnKitaplarsil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKitaplarsil.Name = "btnKitaplarsil";
            this.btnKitaplarsil.Size = new System.Drawing.Size(58, 33);
            this.btnKitaplarsil.Text = "Sil";
            this.btnKitaplarsil.Click += new System.EventHandler(this.btnKitaplarsil_Click);
            // 
            // btnKitaplarBul
            // 
            this.btnKitaplarBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKitaplarBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKitaplarBul.Image = global::QasemKYS.Properties.Resources.book_search;
            this.btnKitaplarBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKitaplarBul.Name = "btnKitaplarBul";
            this.btnKitaplarBul.Size = new System.Drawing.Size(34, 33);
            this.btnKitaplarBul.Text = "Bul";
            this.btnKitaplarBul.Click += new System.EventHandler(this.btnKitaplarBul_Click);
            // 
            // labelKitaplarAra
            // 
            this.labelKitaplarAra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelKitaplarAra.Name = "labelKitaplarAra";
            this.labelKitaplarAra.Size = new System.Drawing.Size(39, 33);
            this.labelKitaplarAra.Text = "Ara";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btniptal);
            this.tabPage2.Controls.Add(this.btnTamam);
            this.tabPage2.Controls.Add(this.dataGridViewKitaplar);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.AllowDrop = true;
            this.btniptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(676, 371);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(108, 35);
            this.btniptal.TabIndex = 12;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTamam.Location = new System.Drawing.Point(560, 371);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(108, 35);
            this.btnTamam.TabIndex = 11;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 468);
            this.tabControl1.TabIndex = 2;
            // 
            // Kitaplar
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton btnKitaplarBul;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnKitaplarsil;
        private System.Windows.Forms.ToolStripButton btnKitaplarduzenle;
        private System.Windows.Forms.ToolStripButton btnKitaplarEkle;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel labelKitaplarAra;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamam;
    }
}