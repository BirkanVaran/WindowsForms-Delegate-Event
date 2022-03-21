
namespace WindowFormDelegateVeEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.btnIslem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSonucPozitif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(100, 38);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 22);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(100, 66);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 22);
            this.txtSayi2.TabIndex = 3;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(51, 106);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(149, 38);
            this.btnSonuc.TabIndex = 4;
            this.btnSonuc.Text = "SONUÇ";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(51, 150);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(149, 38);
            this.btnIslem.TabIndex = 5;
            this.btnIslem.Text = "TOPLA VE ÇARP";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "SAYI KONTROL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSonucPozitif
            // 
            this.btnSonucPozitif.Location = new System.Drawing.Point(51, 282);
            this.btnSonucPozitif.Name = "btnSonucPozitif";
            this.btnSonucPozitif.Size = new System.Drawing.Size(149, 38);
            this.btnSonucPozitif.TabIndex = 8;
            this.btnSonucPozitif.Text = "Sonuç pozitif  mi?";
            this.btnSonucPozitif.UseVisualStyleBackColor = true;
            this.btnSonucPozitif.Click += new System.EventHandler(this.btnSonucPozitif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 335);
            this.Controls.Add(this.btnSonucPozitif);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSonucPozitif;
    }
}

