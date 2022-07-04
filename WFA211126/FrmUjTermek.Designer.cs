namespace WFA211126
{
    partial class FrmUjTermek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTermekEgysegAr = new System.Windows.Forms.TextBox();
            this.tbTermekNev = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUjTermek = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTermekEgysegAr);
            this.groupBox1.Controls.Add(this.tbTermekNev);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "új termék adatai:";
            // 
            // tbTermekEgysegAr
            // 
            this.tbTermekEgysegAr.Location = new System.Drawing.Point(120, 136);
            this.tbTermekEgysegAr.Name = "tbTermekEgysegAr";
            this.tbTermekEgysegAr.Size = new System.Drawing.Size(95, 26);
            this.tbTermekEgysegAr.TabIndex = 1;
            // 
            // tbTermekNev
            // 
            this.tbTermekNev.Location = new System.Drawing.Point(120, 97);
            this.tbTermekNev.Name = "tbTermekNev";
            this.tbTermekNev.Size = new System.Drawing.Size(95, 26);
            this.tbTermekNev.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(120, 46);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(57, 26);
            this.tbID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Egységár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnUjTermek
            // 
            this.btnUjTermek.Location = new System.Drawing.Point(13, 209);
            this.btnUjTermek.Name = "btnUjTermek";
            this.btnUjTermek.Size = new System.Drawing.Size(257, 53);
            this.btnUjTermek.TabIndex = 1;
            this.btnUjTermek.Text = "Új termék rögzítése";
            this.btnUjTermek.UseVisualStyleBackColor = true;
            this.btnUjTermek.Click += new System.EventHandler(this.BtnUjTermek_Click);
            // 
            // FrmUjTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 274);
            this.Controls.Add(this.btnUjTermek);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUjTermek";
            this.Text = "FrmUjTermek";
            this.Load += new System.EventHandler(this.FrmUjTermek_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTermekEgysegAr;
        private System.Windows.Forms.TextBox tbTermekNev;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUjTermek;
    }
}