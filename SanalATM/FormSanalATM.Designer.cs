namespace SanalATM
{
    partial class FormSanalATM
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
            this.cikisBtn = new System.Windows.Forms.Button();
            this.paraCek = new System.Windows.Forms.Button();
            this.bakiyeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paraYatır = new System.Windows.Forms.Button();
            this.tutarTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cikisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisBtn.Location = new System.Drawing.Point(480, 320);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(120, 50);
            this.cikisBtn.TabIndex = 0;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Text = "ÇIKIŞ";
            this.cikisBtn.UseVisualStyleBackColor = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // paraCek
            // 
            this.paraCek.BackColor = System.Drawing.Color.LightCoral;
            this.paraCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paraCek.Location = new System.Drawing.Point(267, 290);
            this.paraCek.Margin = new System.Windows.Forms.Padding(0);
            this.paraCek.Name = "paraCek";
            this.paraCek.Size = new System.Drawing.Size(200, 80);
            this.paraCek.TabIndex = 0;
            this.paraCek.TabStop = false;
            this.paraCek.Text = "PARA ÇEK";
            this.paraCek.UseVisualStyleBackColor = false;
            this.paraCek.Click += new System.EventHandler(this.paraCek_Click);
            // 
            // bakiyeLbl
            // 
            this.bakiyeLbl.AutoSize = true;
            this.bakiyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeLbl.Location = new System.Drawing.Point(230, 50);
            this.bakiyeLbl.Name = "bakiyeLbl";
            this.bakiyeLbl.Size = new System.Drawing.Size(0, 46);
            this.bakiyeLbl.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "BAKİYE:";
            // 
            // paraYatır
            // 
            this.paraYatır.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paraYatır.BackColor = System.Drawing.Color.LightCoral;
            this.paraYatır.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paraYatır.Location = new System.Drawing.Point(58, 290);
            this.paraYatır.Margin = new System.Windows.Forms.Padding(0);
            this.paraYatır.Name = "paraYatır";
            this.paraYatır.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paraYatır.Size = new System.Drawing.Size(200, 80);
            this.paraYatır.TabIndex = 0;
            this.paraYatır.TabStop = false;
            this.paraYatır.Text = "PARA YATIR";
            this.paraYatır.UseVisualStyleBackColor = false;
            this.paraYatır.Click += new System.EventHandler(this.paraYatır_Click);
            // 
            // tutarTextBox
            // 
            this.tutarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutarTextBox.Location = new System.Drawing.Point(303, 149);
            this.tutarTextBox.Name = "tutarTextBox";
            this.tutarTextBox.Size = new System.Drawing.Size(174, 45);
            this.tutarTextBox.TabIndex = 11;
            this.tutarTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tutar Giriniz:";
            // 
            // FormSanalATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tutarTextBox);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.paraCek);
            this.Controls.Add(this.bakiyeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paraYatır);
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(650, 450);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "FormSanalATM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanal ATM";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Button paraCek;
        private System.Windows.Forms.Label bakiyeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button paraYatır;
        private System.Windows.Forms.TextBox tutarTextBox;
        private System.Windows.Forms.Label label2;
    }
}