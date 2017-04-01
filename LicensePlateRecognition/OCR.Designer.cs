namespace akıllıgecissistemleri
{
    partial class OCR
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
            this.txtNumbePlate1 = new System.Windows.Forms.TextBox();
            this.ptBNumberPlate1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptBNumberPlate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumbePlate1
            // 
            this.txtNumbePlate1.BackColor = System.Drawing.Color.Black;
            this.txtNumbePlate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNumbePlate1.ForeColor = System.Drawing.Color.Lime;
            this.txtNumbePlate1.Location = new System.Drawing.Point(607, 205);
            this.txtNumbePlate1.Name = "txtNumbePlate1";
            this.txtNumbePlate1.Size = new System.Drawing.Size(252, 44);
            this.txtNumbePlate1.TabIndex = 56;
            this.txtNumbePlate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumbePlate1.TextChanged += new System.EventHandler(this.txtNumbePlate1_TextChanged);
            // 
            // ptBNumberPlate1
            // 
            this.ptBNumberPlate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ptBNumberPlate1.Location = new System.Drawing.Point(607, 85);
            this.ptBNumberPlate1.Name = "ptBNumberPlate1";
            this.ptBNumberPlate1.Size = new System.Drawing.Size(252, 99);
            this.ptBNumberPlate1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBNumberPlate1.TabIndex = 55;
            this.ptBNumberPlate1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(607, 266);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 37);
            this.btnLoad.TabIndex = 57;
            this.btnLoad.Text = "Recognition";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 360);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 34);
            this.button1.TabIndex = 68;
            this.button1.Text = "Dosya Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Dosyasec);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 69;
            this.button2.Text = "Plaka Tespit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(229, 391);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(112, 24);
            this.progressBar1.TabIndex = 70;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 438);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 71;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(607, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 45);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(607, 338);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 69);
            this.listBox1.TabIndex = 73;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(758, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 37);
            this.button3.TabIndex = 74;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(895, 470);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtNumbePlate1);
            this.Controls.Add(this.ptBNumberPlate1);
            this.Name = "OCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            this.Load += new System.EventHandler(this.OCR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptBNumberPlate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumbePlate1;
        private System.Windows.Forms.PictureBox ptBNumberPlate1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;

    }
}