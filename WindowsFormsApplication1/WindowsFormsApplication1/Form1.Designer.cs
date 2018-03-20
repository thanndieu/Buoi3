namespace WindowsFormsApplication1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnt_Keo = new System.Windows.Forms.Button();
            this.bnt_bua = new System.Windows.Forms.Button();
            this.bnt_bao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa Chọn:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bnt_Keo
            // 
            this.bnt_Keo.Location = new System.Drawing.Point(54, 63);
            this.bnt_Keo.Name = "bnt_Keo";
            this.bnt_Keo.Size = new System.Drawing.Size(106, 83);
            this.bnt_Keo.TabIndex = 2;
            this.bnt_Keo.Text = "Kéo";
            this.bnt_Keo.UseVisualStyleBackColor = true;
            this.bnt_Keo.Click += new System.EventHandler(this.bnt_Keo_Click);
            // 
            // bnt_bua
            // 
            this.bnt_bua.Location = new System.Drawing.Point(195, 63);
            this.bnt_bua.Name = "bnt_bua";
            this.bnt_bua.Size = new System.Drawing.Size(106, 83);
            this.bnt_bua.TabIndex = 3;
            this.bnt_bua.Text = "Búa";
            this.bnt_bua.UseVisualStyleBackColor = true;
            this.bnt_bua.Click += new System.EventHandler(this.bnt_bua_Click);
            // 
            // bnt_bao
            // 
            this.bnt_bao.Location = new System.Drawing.Point(325, 63);
            this.bnt_bao.Name = "bnt_bao";
            this.bnt_bao.Size = new System.Drawing.Size(106, 83);
            this.bnt_bao.TabIndex = 4;
            this.bnt_bao.Text = "Bao";
            this.bnt_bao.UseVisualStyleBackColor = true;
            this.bnt_bao.Click += new System.EventHandler(this.bnt_bao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kết Quả:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 246);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnt_bao);
            this.Controls.Add(this.bnt_bua);
            this.Controls.Add(this.bnt_Keo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bnt_Keo;
        private System.Windows.Forms.Button bnt_bua;
        private System.Windows.Forms.Button bnt_bao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

