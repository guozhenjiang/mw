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
            this.textBox_BinName = new System.Windows.Forms.TextBox();
            this.richTextBox_Bin = new System.Windows.Forms.RichTextBox();
            this.openFileDialog_SelBin = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_FileSel
            // 
            this.button_FileSel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_FileSel.Location = new System.Drawing.Point(811, 12);
            this.button_FileSel.Name = "button_FileSel";
            this.button_FileSel.Size = new System.Drawing.Size(82, 29);
            this.button_FileSel.TabIndex = 0;
            this.button_FileSel.Text = "选择文件";
            this.button_FileSel.UseVisualStyleBackColor = true;
            this.button_FileSel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_FileSel_MouseClick);
            // 
            // button_AddLen
            // 
            this.button_AddLen.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_AddLen.Location = new System.Drawing.Point(899, 12);
            this.button_AddLen.Name = "button_AddLen";
            this.button_AddLen.Size = new System.Drawing.Size(82, 29);
            this.button_AddLen.TabIndex = 1;
            this.button_AddLen.Text = "添加长度";
            this.button_AddLen.UseVisualStyleBackColor = true;
            // 
            // textBox_BinName
            // 
            this.textBox_BinName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_BinName.Location = new System.Drawing.Point(12, 12);
            this.textBox_BinName.Name = "textBox_BinName";
            this.textBox_BinName.Size = new System.Drawing.Size(793, 29);
            this.textBox_BinName.TabIndex = 2;
            // 
            // richTextBox_Bin
            // 
            this.richTextBox_Bin.Font = new System.Drawing.Font("Courier Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Bin.Location = new System.Drawing.Point(12, 47);
            this.richTextBox_Bin.Name = "richTextBox_Bin";
            this.richTextBox_Bin.Size = new System.Drawing.Size(969, 633);
            this.richTextBox_Bin.TabIndex = 3;
            this.richTextBox_Bin.Text = "00000000 01 02 03 04 05 06 07 08 09 10 11 12 13 14 15 16 ----------------";
            // 
            // openFileDialog_SelBin
            // 
            this.openFileDialog_SelBin.FileName = "*.bin";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 692);
            this.Controls.Add(this.richTextBox_Bin);
            this.Controls.Add(this.textBox_BinName);
            this.Controls.Add(this.button_AddLen);
            this.Controls.Add(this.button_FileSel);
            this.Name = "FormMain";
            this.Text = "MW_NCU121_Bin_Add_Len";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_FileSel;
        private System.Windows.Forms.Button button_AddLen;
        private System.Windows.Forms.TextBox textBox_BinName;
        private System.Windows.Forms.RichTextBox richTextBox_Bin;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SelBin;
    }
}

