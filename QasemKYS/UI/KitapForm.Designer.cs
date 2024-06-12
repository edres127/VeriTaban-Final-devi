namespace QasemKYS.UI
{
    partial class KitapForm
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
            this.components = new System.ComponentModel.Container();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textYazarID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textKategoriID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnYazarSeç = new System.Windows.Forms.Button();
            this.btnKategoriSeç = new System.Windows.Forms.Button();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btniptal
            // 
            this.btniptal.AllowDrop = true;
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(617, 318);
            this.btniptal.Margin = new System.Windows.Forms.Padding(4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(120, 41);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTamam.Location = new System.Drawing.Point(453, 318);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(116, 42);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "DateTime";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(143, 35);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(208, 27);
            this.textID.TabIndex = 0;
            this.textID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // textYazarID
            // 
            this.textYazarID.Location = new System.Drawing.Point(143, 100);
            this.textYazarID.Margin = new System.Windows.Forms.Padding(4);
            this.textYazarID.Name = "textYazarID";
            this.textYazarID.ReadOnly = true;
            this.textYazarID.Size = new System.Drawing.Size(208, 27);
            this.textYazarID.TabIndex = 2;
            this.textYazarID.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "YazarID";
            // 
            // textKategoriID
            // 
            this.textKategoriID.Location = new System.Drawing.Point(143, 135);
            this.textKategoriID.Margin = new System.Windows.Forms.Padding(4);
            this.textKategoriID.Name = "textKategoriID";
            this.textKategoriID.ReadOnly = true;
            this.textKategoriID.Size = new System.Drawing.Size(208, 27);
            this.textKategoriID.TabIndex = 3;
            this.textKategoriID.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "KategoriID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(143, 209);
            this.numAdet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(208, 27);
            this.numAdet.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnYazarSeç
            // 
            this.btnYazarSeç.Location = new System.Drawing.Point(380, 103);
            this.btnYazarSeç.Name = "btnYazarSeç";
            this.btnYazarSeç.Size = new System.Drawing.Size(112, 30);
            this.btnYazarSeç.TabIndex = 17;
            this.btnYazarSeç.Text = "Yazar Seç";
            this.btnYazarSeç.UseVisualStyleBackColor = true;
            this.btnYazarSeç.Click += new System.EventHandler(this.btnYazarSeç_Click);
            // 
            // btnKategoriSeç
            // 
            this.btnKategoriSeç.Location = new System.Drawing.Point(380, 139);
            this.btnKategoriSeç.Name = "btnKategoriSeç";
            this.btnKategoriSeç.Size = new System.Drawing.Size(112, 30);
            this.btnKategoriSeç.TabIndex = 18;
            this.btnKategoriSeç.Text = "Kategori Seç";
            this.btnKategoriSeç.UseVisualStyleBackColor = true;
            this.btnKategoriSeç.Click += new System.EventHandler(this.btnKategoriSeç_Click);
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(143, 65);
            this.textAd.Margin = new System.Windows.Forms.Padding(4);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(208, 27);
            this.textAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "AD";
            // 
            // KitapForm
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.btnKategoriSeç);
            this.Controls.Add(this.btnYazarSeç);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textKategoriID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textYazarID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KitapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KitapForm";
            this.Load += new System.EventHandler(this.KitapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textYazarID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textKategoriID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnKategoriSeç;
        private System.Windows.Forms.Button btnYazarSeç;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label6;
    }
}