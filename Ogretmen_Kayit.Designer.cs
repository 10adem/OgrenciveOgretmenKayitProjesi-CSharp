
namespace OkulSistemi
{
    partial class Ogretmen_Kayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrtNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.cbBrans = new System.Windows.Forms.ComboBox();
            this.btnKayıtEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yaş :";
            // 
            // txtOgrtNo
            // 
            this.txtOgrtNo.Location = new System.Drawing.Point(226, 88);
            this.txtOgrtNo.MaxLength = 9;
            this.txtOgrtNo.Name = "txtOgrtNo";
            this.txtOgrtNo.Size = new System.Drawing.Size(228, 29);
            this.txtOgrtNo.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(226, 127);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(228, 29);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(226, 168);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(228, 29);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(226, 246);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(228, 29);
            this.txtYas.TabIndex = 9;
            // 
            // cbBrans
            // 
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Items.AddRange(new object[] {
            "Algoritma",
            "Veri Tabanı",
            "Tarih",
            "Sosyoloji",
            "Psikoloji",
            "Veri Madenciliği",
            "Mobil Programlama"});
            this.cbBrans.Location = new System.Drawing.Point(226, 206);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(228, 29);
            this.cbBrans.TabIndex = 10;
            // 
            // btnKayıtEt
            // 
            this.btnKayıtEt.Location = new System.Drawing.Point(292, 281);
            this.btnKayıtEt.Name = "btnKayıtEt";
            this.btnKayıtEt.Size = new System.Drawing.Size(102, 35);
            this.btnKayıtEt.TabIndex = 11;
            this.btnKayıtEt.Text = "Kaydet";
            this.btnKayıtEt.UseVisualStyleBackColor = true;
            this.btnKayıtEt.Click += new System.EventHandler(this.btnKayıtEt_Click);
            // 
            // Ogretmen_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(540, 368);
            this.Controls.Add(this.btnKayıtEt);
            this.Controls.Add(this.cbBrans);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtOgrtNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ogretmen_Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oğretmen Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ogretmen_Kayit_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrtNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.ComboBox cbBrans;
        private System.Windows.Forms.Button btnKayıtEt;
    }
}