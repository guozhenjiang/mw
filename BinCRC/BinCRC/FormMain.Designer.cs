namespace BinCRC
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog_SelBin = new System.Windows.Forms.OpenFileDialog();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.bt_file_sel = new System.Windows.Forms.Button();
            this.groupBox_CRC32 = new System.Windows.Forms.GroupBox();
            this.tb_crc32_val = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_crc32_poly = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_crc32_init_val = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_run_crc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_file_len = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_crc08_init_val = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_crc08_poly = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_crc08_val = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_crc16_init_val = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_crc16_poly = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_crc16_val = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_CRC32.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_SelBin
            // 
            this.openFileDialog_SelBin.FileName = "openFileDialog1";
            // 
            // tb_file
            // 
            this.tb_file.Location = new System.Drawing.Point(83, 12);
            this.tb_file.Name = "tb_file";
            this.tb_file.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_file.Size = new System.Drawing.Size(705, 21);
            this.tb_file.TabIndex = 0;
            // 
            // bt_file_sel
            // 
            this.bt_file_sel.Location = new System.Drawing.Point(12, 12);
            this.bt_file_sel.Name = "bt_file_sel";
            this.bt_file_sel.Size = new System.Drawing.Size(65, 23);
            this.bt_file_sel.TabIndex = 1;
            this.bt_file_sel.Text = "选择文件";
            this.bt_file_sel.UseVisualStyleBackColor = true;
            this.bt_file_sel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_file_sel_MouseClick);
            // 
            // groupBox_CRC32
            // 
            this.groupBox_CRC32.Controls.Add(this.tb_crc32_val);
            this.groupBox_CRC32.Controls.Add(this.label3);
            this.groupBox_CRC32.Controls.Add(this.tb_crc32_poly);
            this.groupBox_CRC32.Controls.Add(this.label2);
            this.groupBox_CRC32.Controls.Add(this.tb_crc32_init_val);
            this.groupBox_CRC32.Controls.Add(this.label1);
            this.groupBox_CRC32.Location = new System.Drawing.Point(224, 41);
            this.groupBox_CRC32.Name = "groupBox_CRC32";
            this.groupBox_CRC32.Size = new System.Drawing.Size(184, 98);
            this.groupBox_CRC32.TabIndex = 2;
            this.groupBox_CRC32.TabStop = false;
            this.groupBox_CRC32.Text = "CRC_32";
            // 
            // tb_crc32_val
            // 
            this.tb_crc32_val.Location = new System.Drawing.Point(53, 68);
            this.tb_crc32_val.Name = "tb_crc32_val";
            this.tb_crc32_val.Size = new System.Drawing.Size(125, 21);
            this.tb_crc32_val.TabIndex = 1;
            this.tb_crc32_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "结  果";
            // 
            // tb_crc32_poly
            // 
            this.tb_crc32_poly.Location = new System.Drawing.Point(53, 41);
            this.tb_crc32_poly.Name = "tb_crc32_poly";
            this.tb_crc32_poly.Size = new System.Drawing.Size(125, 21);
            this.tb_crc32_poly.TabIndex = 1;
            this.tb_crc32_poly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "多项式";
            // 
            // tb_crc32_init_val
            // 
            this.tb_crc32_init_val.Location = new System.Drawing.Point(53, 14);
            this.tb_crc32_init_val.Name = "tb_crc32_init_val";
            this.tb_crc32_init_val.Size = new System.Drawing.Size(125, 21);
            this.tb_crc32_init_val.TabIndex = 1;
            this.tb_crc32_init_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "初始值";
            // 
            // bt_run_crc
            // 
            this.bt_run_crc.Location = new System.Drawing.Point(12, 145);
            this.bt_run_crc.Name = "bt_run_crc";
            this.bt_run_crc.Size = new System.Drawing.Size(65, 23);
            this.bt_run_crc.TabIndex = 1;
            this.bt_run_crc.Text = "进行校验";
            this.bt_run_crc.UseVisualStyleBackColor = true;
            this.bt_run_crc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_run_crc_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_file_len);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 98);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件信息";
            // 
            // tb_file_len
            // 
            this.tb_file_len.Location = new System.Drawing.Point(41, 14);
            this.tb_file_len.Name = "tb_file_len";
            this.tb_file_len.Size = new System.Drawing.Size(102, 21);
            this.tb_file_len.TabIndex = 1;
            this.tb_file_len.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "长度";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Location = new System.Drawing.Point(585, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "guo_zhen_jiang@163.com 2018-05-03";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "初始值";
            // 
            // tb_crc08_init_val
            // 
            this.tb_crc08_init_val.Location = new System.Drawing.Point(53, 14);
            this.tb_crc08_init_val.Name = "tb_crc08_init_val";
            this.tb_crc08_init_val.Size = new System.Drawing.Size(125, 21);
            this.tb_crc08_init_val.TabIndex = 1;
            this.tb_crc08_init_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "多项式";
            // 
            // tb_crc08_poly
            // 
            this.tb_crc08_poly.Location = new System.Drawing.Point(53, 41);
            this.tb_crc08_poly.Name = "tb_crc08_poly";
            this.tb_crc08_poly.Size = new System.Drawing.Size(125, 21);
            this.tb_crc08_poly.TabIndex = 1;
            this.tb_crc08_poly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "结  果";
            // 
            // tb_crc08_val
            // 
            this.tb_crc08_val.Location = new System.Drawing.Point(53, 68);
            this.tb_crc08_val.Name = "tb_crc08_val";
            this.tb_crc08_val.Size = new System.Drawing.Size(125, 21);
            this.tb_crc08_val.TabIndex = 1;
            this.tb_crc08_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_crc08_val);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_crc08_poly);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_crc08_init_val);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(604, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRC_08";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "初始值";
            // 
            // tb_crc16_init_val
            // 
            this.tb_crc16_init_val.Location = new System.Drawing.Point(53, 14);
            this.tb_crc16_init_val.Name = "tb_crc16_init_val";
            this.tb_crc16_init_val.Size = new System.Drawing.Size(125, 21);
            this.tb_crc16_init_val.TabIndex = 1;
            this.tb_crc16_init_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "多项式";
            // 
            // tb_crc16_poly
            // 
            this.tb_crc16_poly.Location = new System.Drawing.Point(53, 41);
            this.tb_crc16_poly.Name = "tb_crc16_poly";
            this.tb_crc16_poly.Size = new System.Drawing.Size(125, 21);
            this.tb_crc16_poly.TabIndex = 1;
            this.tb_crc16_poly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "结  果";
            // 
            // tb_crc16_val
            // 
            this.tb_crc16_val.Location = new System.Drawing.Point(53, 68);
            this.tb_crc16_val.Name = "tb_crc16_val";
            this.tb_crc16_val.Size = new System.Drawing.Size(125, 21);
            this.tb_crc16_val.TabIndex = 1;
            this.tb_crc16_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_crc16_val);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_crc16_poly);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_crc16_init_val);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(414, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRC_16";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Byte";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 175);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 182);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "常用多项式及初始值：\nCRC32\t\t初始值\t\t\t多项式\n\t\tFFFFFFFF\t\t\t84C11DB7";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_CRC32);
            this.Controls.Add(this.bt_run_crc);
            this.Controls.Add(this.bt_file_sel);
            this.Controls.Add(this.tb_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.Text = "BinCRC";
            this.groupBox_CRC32.ResumeLayout(false);
            this.groupBox_CRC32.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_SelBin;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.Button bt_file_sel;
        private System.Windows.Forms.GroupBox groupBox_CRC32;
        private System.Windows.Forms.TextBox tb_crc32_val;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_crc32_poly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_crc32_init_val;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_run_crc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_file_len;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_crc08_init_val;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_crc08_poly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_crc08_val;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_crc16_init_val;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_crc16_poly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_crc16_val;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

