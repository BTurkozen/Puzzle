namespace Puzzle
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
            this.buttonLevel1 = new System.Windows.Forms.Button();
            this.buttonLevel2 = new System.Windows.Forms.Button();
            this.buttonLevel3 = new System.Windows.Forms.Button();
            this.buttonLevel4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonImageBrowse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxPuzzle = new System.Windows.Forms.GroupBox();
            this.groupBoxIpucu = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLevel1
            // 
            this.buttonLevel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLevel1.Location = new System.Drawing.Point(22, 36);
            this.buttonLevel1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLevel1.Name = "buttonLevel1";
            this.buttonLevel1.Size = new System.Drawing.Size(128, 31);
            this.buttonLevel1.TabIndex = 0;
            this.buttonLevel1.Text = "Level 1";
            this.buttonLevel1.UseVisualStyleBackColor = true;
            this.buttonLevel1.Click += new System.EventHandler(this.buttonLevel1_Click);
            // 
            // buttonLevel2
            // 
            this.buttonLevel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLevel2.Location = new System.Drawing.Point(22, 85);
            this.buttonLevel2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Size = new System.Drawing.Size(128, 31);
            this.buttonLevel2.TabIndex = 1;
            this.buttonLevel2.Text = "Level 2";
            this.buttonLevel2.UseVisualStyleBackColor = true;
            this.buttonLevel2.Click += new System.EventHandler(this.buttonLevel2_Click);
            // 
            // buttonLevel3
            // 
            this.buttonLevel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLevel3.Location = new System.Drawing.Point(169, 36);
            this.buttonLevel3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLevel3.Name = "buttonLevel3";
            this.buttonLevel3.Size = new System.Drawing.Size(128, 31);
            this.buttonLevel3.TabIndex = 2;
            this.buttonLevel3.Text = "Level 3";
            this.buttonLevel3.UseVisualStyleBackColor = true;
            this.buttonLevel3.Click += new System.EventHandler(this.buttonLevel3_Click);
            // 
            // buttonLevel4
            // 
            this.buttonLevel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLevel4.Location = new System.Drawing.Point(169, 85);
            this.buttonLevel4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLevel4.Name = "buttonLevel4";
            this.buttonLevel4.Size = new System.Drawing.Size(128, 31);
            this.buttonLevel4.TabIndex = 3;
            this.buttonLevel4.Text = "Level 4";
            this.buttonLevel4.UseVisualStyleBackColor = true;
            this.buttonLevel4.Click += new System.EventHandler(this.buttonLevel4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonLevel4);
            this.groupBox1.Controls.Add(this.buttonLevel3);
            this.groupBox1.Controls.Add(this.buttonLevel2);
            this.groupBox1.Controls.Add(this.buttonLevel1);
            this.groupBox1.Location = new System.Drawing.Point(826, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(315, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zorluk Seviyesi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Location = new System.Drawing.Point(826, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durum";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 20);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(298, 16);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Bir Resim Seçerek Oyuna Başlıyabilirsiniz";
            // 
            // buttonImageBrowse
            // 
            this.buttonImageBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonImageBrowse.Location = new System.Drawing.Point(805, 23);
            this.buttonImageBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImageBrowse.Name = "buttonImageBrowse";
            this.buttonImageBrowse.Size = new System.Drawing.Size(120, 28);
            this.buttonImageBrowse.TabIndex = 5;
            this.buttonImageBrowse.Text = "......";
            this.buttonImageBrowse.UseVisualStyleBackColor = true;
            this.buttonImageBrowse.Click += new System.EventHandler(this.buttonImageBrowse_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.buttonImageBrowse);
            this.groupBox3.Location = new System.Drawing.Point(111, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(948, 68);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resim Seç";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(734, 22);
            this.textBox1.TabIndex = 6;
            // 
            // groupBoxPuzzle
            // 
            this.groupBoxPuzzle.Location = new System.Drawing.Point(12, 127);
            this.groupBoxPuzzle.Name = "groupBoxPuzzle";
            this.groupBoxPuzzle.Size = new System.Drawing.Size(794, 395);
            this.groupBoxPuzzle.TabIndex = 10;
            this.groupBoxPuzzle.TabStop = false;
            this.groupBoxPuzzle.Text = "Puzzle";
            // 
            // groupBoxIpucu
            // 
            this.groupBoxIpucu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxIpucu.Location = new System.Drawing.Point(826, 322);
            this.groupBoxIpucu.Name = "groupBoxIpucu";
            this.groupBoxIpucu.Size = new System.Drawing.Size(315, 200);
            this.groupBoxIpucu.TabIndex = 11;
            this.groupBoxIpucu.TabStop = false;
            this.groupBoxIpucu.Text = "İpucu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 534);
            this.Controls.Add(this.groupBoxIpucu);
            this.Controls.Add(this.groupBoxPuzzle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PUZZLE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLevel1;
        private System.Windows.Forms.Button buttonLevel2;
        private System.Windows.Forms.Button buttonLevel3;
        private System.Windows.Forms.Button buttonLevel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonImageBrowse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxPuzzle;
        private System.Windows.Forms.GroupBox groupBoxIpucu;
    }
}

