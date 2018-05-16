namespace mw_nuc121_bin_add_len
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
            this.button_FileSel = new System.Windows.Forms.Button();
            this.button_AddLen = new System.Windows.Forms.Button();
            this.textBox_BinRaw_PathNameExt = new System.Windows.Forms.TextBox();
            this.openFileDialog_SelBin = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox_Dbg = new System.Windows.Forms.RichTextBox();
            this.richTextBox_BinNew = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox_BinRaw = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox_RolSame = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_BinNewCRC = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_FileSel
            // 
            this.button_FileSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_FileSel.BackColor = System.Drawing.Color.Gainsboro;
            this.button_FileSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FileSel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_FileSel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_FileSel.Location = new System.Drawing.Point(936, 12);
            this.button_FileSel.Name = "button_FileSel";
            this.button_FileSel.Size = new System.Drawing.Size(82, 25);
            this.button_FileSel.TabIndex = 0;
            this.button_FileSel.Text = "选择文件";
            this.button_FileSel.UseVisualStyleBackColor = false;
            this.button_FileSel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_FileSel_MouseClick);
            // 
            // button_AddLen
            // 
            this.button_AddLen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddLen.BackColor = System.Drawing.Color.Gainsboro;
            this.button_AddLen.Enabled = false;
            this.button_AddLen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddLen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_AddLen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_AddLen.Location = new System.Drawing.Point(1024, 12);
            this.button_AddLen.Name = "button_AddLen";
            this.button_AddLen.Size = new System.Drawing.Size(82, 25);
            this.button_AddLen.TabIndex = 1;
            this.button_AddLen.Text = "添加长度";
            this.button_AddLen.UseVisualStyleBackColor = false;
            this.button_AddLen.Click += new System.EventHandler(this.button_AddLen_Click);
            // 
            // textBox_BinRaw_PathNameExt
            // 
            this.textBox_BinRaw_PathNameExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_BinRaw_PathNameExt.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_BinRaw_PathNameExt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_BinRaw_PathNameExt.Location = new System.Drawing.Point(12, 12);
            this.textBox_BinRaw_PathNameExt.Name = "textBox_BinRaw_PathNameExt";
            this.textBox_BinRaw_PathNameExt.Size = new System.Drawing.Size(918, 25);
            this.textBox_BinRaw_PathNameExt.TabIndex = 2;
            // 
            // openFileDialog_SelBin
            // 
            this.openFileDialog_SelBin.FileName = "*.bin";
            // 
            // richTextBox_Dbg
            // 
            this.richTextBox_Dbg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Dbg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox_Dbg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Dbg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Dbg.ForeColor = System.Drawing.Color.Gold;
            this.richTextBox_Dbg.Location = new System.Drawing.Point(12, 594);
            this.richTextBox_Dbg.Name = "richTextBox_Dbg";
            this.richTextBox_Dbg.Size = new System.Drawing.Size(1094, 134);
            this.richTextBox_Dbg.TabIndex = 4;
            this.richTextBox_Dbg.Text = "";
            this.richTextBox_Dbg.WordWrap = false;
            // 
            // richTextBox_BinNew
            // 
            this.richTextBox_BinNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_BinNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox_BinNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_BinNew.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_BinNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox_BinNew.Location = new System.Drawing.Point(549, 25);
            this.richTextBox_BinNew.Name = "richTextBox_BinNew";
            this.richTextBox_BinNew.Size = new System.Drawing.Size(542, 488);
            this.richTextBox_BinNew.TabIndex = 3;
            this.richTextBox_BinNew.Text = "";
            this.richTextBox_BinNew.WordWrap = false;
            this.richTextBox_BinNew.VScroll += new System.EventHandler(this.richTextBox_BinNew_VScroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00333F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_BinNew, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_BinRaw, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1094, 516);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // richTextBox_BinRaw
            // 
            this.richTextBox_BinRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_BinRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox_BinRaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_BinRaw.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_BinRaw.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox_BinRaw.Location = new System.Drawing.Point(3, 25);
            this.richTextBox_BinRaw.Name = "richTextBox_BinRaw";
            this.richTextBox_BinRaw.Size = new System.Drawing.Size(540, 488);
            this.richTextBox_BinRaw.TabIndex = 3;
            this.richTextBox_BinRaw.Text = "";
            this.richTextBox_BinRaw.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(540, 19);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Address : 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(549, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(542, 19);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Address : 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            // 
            // checkBox_RolSame
            // 
            this.checkBox_RolSame.AutoSize = true;
            this.checkBox_RolSame.Checked = true;
            this.checkBox_RolSame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RolSame.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_RolSame.ForeColor = System.Drawing.Color.White;
            this.checkBox_RolSame.Location = new System.Drawing.Point(15, 43);
            this.checkBox_RolSame.Name = "checkBox_RolSame";
            this.checkBox_RolSame.Size = new System.Drawing.Size(80, 23);
            this.checkBox_RolSame.TabIndex = 6;
            this.checkBox_RolSame.Text = "同步滚动";
            this.checkBox_RolSame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_RolSame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "新文件CRC32(初始值 0xFFFFFFFF 多项式 0x104C11DB7)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_BinNewCRC
            // 
            this.textBox_BinNewCRC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_BinNewCRC.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_BinNewCRC.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_BinNewCRC.Location = new System.Drawing.Point(1024, 41);
            this.textBox_BinNewCRC.Name = "textBox_BinNewCRC";
            this.textBox_BinNewCRC.Size = new System.Drawing.Size(83, 25);
            this.textBox_BinNewCRC.TabIndex = 2;
            this.textBox_BinNewCRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1118, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_RolSame);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox_Dbg);
            this.Controls.Add(this.textBox_BinNewCRC);
            this.Controls.Add(this.textBox_BinRaw_PathNameExt);
            this.Controls.Add(this.button_AddLen);
            this.Controls.Add(this.button_FileSel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MW_NCU121_Bin_Add_Len by GuoZhenjiang 2018-5-16";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_FileSel;
        private System.Windows.Forms.Button button_AddLen;
        private System.Windows.Forms.TextBox textBox_BinRaw_PathNameExt;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SelBin;
        private System.Windows.Forms.RichTextBox richTextBox_Dbg;
        private System.Windows.Forms.RichTextBox richTextBox_BinNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox_BinRaw;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox_RolSame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BinNewCRC;
    }
}

