
namespace OkulSistemi
{
    partial class Giris_Sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Sayfasi));
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.btnOgretmenGiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOgrenciGiris.Location = new System.Drawing.Point(708, 37);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(214, 74);
            this.btnOgrenciGiris.TabIndex = 0;
            this.btnOgrenciGiris.Text = "Öğrenci Girişi";
            this.btnOgrenciGiris.UseVisualStyleBackColor = false;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // btnOgretmenGiris
            // 
            this.btnOgretmenGiris.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOgretmenGiris.Location = new System.Drawing.Point(929, 37);
            this.btnOgretmenGiris.Name = "btnOgretmenGiris";
            this.btnOgretmenGiris.Size = new System.Drawing.Size(214, 74);
            this.btnOgretmenGiris.TabIndex = 1;
            this.btnOgretmenGiris.Text = "Öğretmen Girişi";
            this.btnOgretmenGiris.UseVisualStyleBackColor = false;
            this.btnOgretmenGiris.Click += new System.EventHandler(this.btnOgretmenGiris_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(708, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Öğrenci Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(929, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "Öğretmen Kayıt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 646);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOgretmenGiris);
            this.Controls.Add(this.btnOgrenciGiris);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris_Sayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_Sayfasi_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciGiris;
        private System.Windows.Forms.Button btnOgretmenGiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

