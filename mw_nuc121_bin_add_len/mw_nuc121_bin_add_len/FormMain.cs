using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mw_nuc121_bin_add_len
{
    public partial class FormMain : Form
    {
        // 要处理的文件的信息
        string BinRaw_PathNameExt;      // 原文件 路径、名称、扩展名
        string BinRaw_Path;             // 原文件 路径
        string BinRaw_Name;             // 原文件 名称(不含后缀)
        string BinRaw_Ext;              // 原文件 后缀
        long   BinRaw_Len;              // 原文件 大小(内容字节数)
        string BinRaw_Len_10;           // 原文件 大小(字符串 十进制)
        string BinRaw_Len_16;           // 原文件 大小(字符串 十六进制)
        
        string BinNew_PathNameExt;      // 新文件 路径、名称、扩展名
        string BinNew_Path;             // 新文件 路径
        string BinNew_Name;             // 新文件 名称(不含后缀)
        string BinNew_Ext;              // 新文件 后缀
        long   BinNew_Len;              // 新文件 大小(内容字节数)

        string TimeStamp;               // 当前时间
        string StrAddLen;

        byte[] BinLen = new byte[4];

        UInt32 i;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Show_Bin_To_RitchTextBox(string File_PathNameExt, RichTextBox richTextBox)
        {
            // 获取文件内容
            FileStream fileStream = new FileStream(File_PathNameExt, FileMode.Open);
            long fileLen = fileStream.Length;
            byte[] fileData = new byte[fileLen];
            byte[] fileData_16 = new byte[16];      // 每次最多读取16字节进行处理

            fileStream.Read(fileData, 0, (int)fileLen);
            fileStream.Close();

            // 显示文件内容
            richTextBox.Text = "";
            string Str_NewByte;

            for (i = 0; i < fileLen; i++)
            {
                if (0 == i % 16)
                {
                    if (i > 0)
                        richTextBox.AppendText("\r\n");
                    richTextBox.AppendText(i.ToString("X8") + ":");
                }

                Str_NewByte = " ";

                if (fileData[i] < 0x10)
                    Str_NewByte += "0";

                Str_NewByte += Convert.ToString(fileData[i], 16).ToUpper();

                richTextBox.AppendText(Str_NewByte);
            }
        }

        private void Update_BinNew_CRC32(string File_PathNameExt)
        {
            UInt32 CRC32_InitVal = 0xFFFFFFFF;
            long CRC32_Poly = 0x104C11DB7;
            long CRC32_Val;

            // 进行校验计算
            FileStream file_stream = new FileStream(File_PathNameExt, FileMode.Open);
            System.IO.BinaryReader file_read = new System.IO.BinaryReader(file_stream);

            long i, j, k;
            UInt32[] byte_cache = new UInt32[4];

            CRC32_Val = CRC32_InitVal;

            for (i = 0; i < file_stream.Length; i += 4)
            {
                // 字节顺序从高到低
                byte_cache[3] = file_read.ReadByte();
                byte_cache[2] = file_read.ReadByte();
                byte_cache[1] = file_read.ReadByte();
                byte_cache[0] = file_read.ReadByte();

                for (k = 0; k < 4; k++)
                {
                    CRC32_Val ^= byte_cache[k] << 24;

                    for (j = 0; j < 8; j++)
                    {
                        if (0x80000000 == (CRC32_Val & 0x80000000))
                            CRC32_Val = (CRC32_Val << 1) ^ CRC32_Poly;
                        else
                            CRC32_Val <<= 1;
                    }
                }
            }

            file_stream.Close();

            textBox_BinNewCRC.Text = Convert.ToString(CRC32_Val, 16).ToUpper();
        }

        private void Force_Same_Scroll(CheckBox checkBox, RichTextBox richTextBox_Act, RichTextBox richTextBox_Follow)
        {
            if (checkBox.Checked)
            {
                // 获取当前窗口行号//获得当前坐标信息
                Point p = richTextBox_Act.Location;
                int crntFirstIndex = richTextBox_Act.GetCharIndexFromPosition(p);
                int crntFirstLine = richTextBox_Act.GetLineFromCharIndex(crntFirstIndex);

                // 设置另外一个窗口滚动
                try
                {
                    richTextBox_Follow.SelectionStart = richTextBox_Follow.GetFirstCharIndexFromLine(crntFirstLine - 1);
                    richTextBox_Follow.SelectionLength = 0;
                    richTextBox_Follow.ScrollToCaret();
                }
                catch
                {

                }
            }
        }

        private void button_FileSel_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog_SelBin.Multiselect = false;
            openFileDialog_SelBin.Title = "请选择 .bin 文件";

            if(openFileDialog_SelBin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // 获取原文件信息
                BinRaw_PathNameExt = openFileDialog_SelBin.FileName;

                FileInfo BinRaw_Info = new FileInfo(BinRaw_PathNameExt);    // 获取文件信息

                BinRaw_Path = System.IO.Path.GetDirectoryName(BinRaw_PathNameExt);
                BinRaw_Name = System.IO.Path.GetFileNameWithoutExtension(BinRaw_PathNameExt);
                BinRaw_Ext  = System.IO.Path.GetExtension(BinRaw_PathNameExt);
                BinRaw_Len  = BinRaw_Info.Length;
                BinRaw_Len_10 = BinRaw_Len.ToString();
                BinRaw_Len_16 = "0x" + Convert.ToString(BinRaw_Len, 16).ToUpper();

                textBox_BinRaw_PathNameExt.Text = BinRaw_PathNameExt;
                richTextBox_Dbg.AppendText("\r\n");
                richTextBox_Dbg.AppendText("BinRaw_PathNameExt:" + BinRaw_PathNameExt + "\r\n");
                richTextBox_Dbg.AppendText("BinRaw_Path:" + BinRaw_Path + "\r\n");
                richTextBox_Dbg.AppendText("BinRaw_Name:" + BinRaw_Name + "\r\n");
                richTextBox_Dbg.AppendText("BinRaw_Ext:" + BinRaw_Ext + "\r\n");
                richTextBox_Dbg.AppendText("BinRaw_Len:"+ BinRaw_Len_10 + " " + BinRaw_Len_16 + "\r\n");
                richTextBox_Dbg.ScrollToCaret();

                Show_Bin_To_RitchTextBox(BinRaw_PathNameExt, richTextBox_BinRaw);

                button_AddLen.Enabled = true;
            }
        }

        private void button_AddLen_Click(object sender, EventArgs e)
        {

            // 生成新的文件信息
            BinNew_Path = BinRaw_Path;
            BinNew_Name = BinRaw_Name;
            BinNew_Ext = BinRaw_Ext;
            BinNew_Len = BinRaw_Len + 4;

            TimeStamp = DateTime.Now.ToString();
            TimeStamp = TimeStamp.Replace("/", "_");
            TimeStamp = TimeStamp.Replace(":", "");
            TimeStamp = TimeStamp.Replace(" ", "_");

            richTextBox_Dbg.AppendText("\r\n");
            BinNew_PathNameExt = BinNew_Path + "\\" + BinNew_Name + "-" + TimeStamp + "-AddLen-" + BinRaw_Len_10 + "-" + BinRaw_Len_16 + BinNew_Ext;
            richTextBox_Dbg.AppendText("BinNew_PathNameExt:" + BinNew_PathNameExt + "\r\n");
            richTextBox_Dbg.ScrollToCaret();

            BinLen[0] = (byte)((BinRaw_Len & 0x000000FF) >> 0);
            BinLen[1] = (byte)((BinRaw_Len & 0x0000FF00) >> 8);
            BinLen[2] = (byte)((BinRaw_Len & 0x00FF0000) >> 16);
            BinLen[3] = (byte)((BinRaw_Len & 0xFF000000) >> 24);

            StrAddLen = "";

            for (int i = 0; i < 4; i++)
            {
                if (BinLen[i] < 0x10)
                    StrAddLen += "0";

                StrAddLen += Convert.ToString(BinLen[i], 16).ToUpper();
                StrAddLen += " ";
            }
            richTextBox_Dbg.AppendText("Add Len:" + StrAddLen + "\r\n");
            // 获取原文件内容
            byte[] BinRaw_Data = new byte[BinRaw_Len];
            FileStream FileStream_BinRaw = new FileStream(BinRaw_PathNameExt, FileMode.Open);

            FileStream_BinRaw.Read(BinRaw_Data, 0, (int)BinRaw_Len);
            FileStream_BinRaw.Close();

            // 新文件
            FileStream FileStream_BinNew = new FileStream(BinNew_PathNameExt, FileMode.Create);

            FileStream_BinNew.Write(BinLen, 0, 4);
            FileStream_BinNew.Write(BinRaw_Data, 0, (int)BinRaw_Len);

            FileStream_BinNew.Flush();
            FileStream_BinNew.Close();

            Show_Bin_To_RitchTextBox(BinNew_PathNameExt, richTextBox_BinNew);

            Update_BinNew_CRC32(BinNew_PathNameExt);
        }

        private void richTextBox_BinRaw_VScroll(object sender, EventArgs e)
        {
            Force_Same_Scroll(checkBox_RolSame, richTextBox_BinRaw, richTextBox_BinNew);
        }

        private void richTextBox_BinNew_VScroll(object sender, EventArgs e)
        {
            Force_Same_Scroll(checkBox_RolSame, richTextBox_BinNew, richTextBox_BinRaw);
        }
    }
}
