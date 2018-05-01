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
        string BinRaw_PathNameAll;      // 路径及名称
        string BinRaw_PathOnly;

        string BinRaw_NameWithoutExt;   // 名称
        long BinRaw_Len;                // 大小

        string BinNew_PathNameExt;      // 保存文件的路径、名称、及扩展名

        byte[] BinLen = new byte[4];
        byte[] BinRaw = new byte[] { };

        BinaryWriter Bin_W;
        BinaryReader Bin_R;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button_FileSel_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog_SelBin.Multiselect = false;
            openFileDialog_SelBin.Title = "请选择 .bin 文件";

            if(openFileDialog_SelBin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BinRaw_PathNameAll = openFileDialog_SelBin.FileName;       // 获取路径及文件名
                textBox_BinName.Text = BinRaw_PathNameAll;                 // 提示路径及文件名
                FileInfo BinRaw_Info = new FileInfo(BinRaw_PathNameAll);   // 获取文件信息

                BinRaw_NameWithoutExt = System.IO.Path.GetFileNameWithoutExtension(BinRaw_PathNameAll);    // 获取不带路径和后缀的文件名
                BinRaw_Len = BinRaw_Info.Length;
                BinRaw_PathOnly = System.IO.Path.GetDirectoryName(BinRaw_PathNameAll);

                BinNew_PathNameExt = BinRaw_PathOnly + "\\" + BinRaw_NameWithoutExt + "_AddLen.bin";

                richTextBox_Bin.AppendText("\r\n文件名称:" + BinRaw_NameWithoutExt + "\r\n");   // 显示文件名
                richTextBox_Bin.AppendText("文件长度:" + BinRaw_Len + "\r\n");                  // 显示文件大小
                richTextBox_Bin.AppendText("原路径:" + BinRaw_PathOnly + "\r\n");             // 显示文件路径
                richTextBox_Bin.AppendText("新文件:" + BinNew_PathNameExt + "\r\n");           // 新文件信息

                BinLen[0] = (byte)((BinRaw_Len & 0x000000FF) >> 0);
                BinLen[1] = (byte)((BinRaw_Len & 0x0000FF00) >> 8);
                BinLen[2] = (byte)((BinRaw_Len & 0x00FF0000) >> 16);
                BinLen[3] = (byte)((BinRaw_Len & 0xFF000000) >> 24);

                //BinLen[0] = 0x12;
                //BinLen[1] = 0x34;
                //BinLen[2] = 0x56;
                //BinLen[3] = 0x78;

                richTextBox_Bin.AppendText("Add Len:");
                string str_bin_len_x = "";
                for (int i=0; i<4; i++)
                {
                    str_bin_len_x = Convert.ToString(BinLen[i], 16);
                    str_bin_len_x = str_bin_len_x.ToUpper();
                    richTextBox_Bin.AppendText(str_bin_len_x);
                }
                richTextBox_Bin.AppendText("\r\n");

                richTextBox_Bin.Text = "";


                byte[] RawBinData = new byte[BinRaw_Len];
                string str_byte_x;

                System.IO.FileStream fs = new System.IO.FileStream(BinRaw_PathNameAll, System.IO.FileMode.Open);

                System.IO.BinaryReader read = new System.IO.BinaryReader(fs);

                for (UInt32 i = 0; i < fs.Length; i++)
                {
                    if ((i > 0) && (0 == i % 16))
                        richTextBox_Bin.AppendText("\r\n");

                    str_byte_x = "";
                    RawBinData[i] = read.ReadByte();

                    if (RawBinData[i] < 0x10)
                        str_byte_x += "0";

                    str_byte_x += Convert.ToString(RawBinData[i], 16);
                    str_byte_x = str_byte_x.ToUpper() + " ";

                    richTextBox_Bin.AppendText(str_byte_x);
                }

                fs.Close();

                button_AddLen.Enabled = true;
            }
        }

        private void button_AddLen_Click(object sender, EventArgs e)
        {
            FileStream fs_raw = new FileStream(BinRaw_PathNameAll, FileMode.Open);
            System.IO.BinaryReader read_raw = new System.IO.BinaryReader(fs_raw);

            FileStream fs = new FileStream(BinNew_PathNameExt, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            System.IO.BinaryReader read = new System.IO.BinaryReader(fs);

            Int32 i;

            // 写入长度信息
            for (i = 0; i < 4; i++)
                sw.Write(BinLen[i]);

            // 写入原来的文件
            for (i = 0; i < fs_raw.Length; i++)
                sw.Write(read_raw.ReadByte());

            fs.Flush();
            fs.Close();

            fs_raw.Close();

            // 清空显示
            richTextBox_Bin.Text = "";

            FileStream fs2 = new FileStream(BinNew_PathNameExt, FileMode.Open);
            System.IO.BinaryReader read2 = new System.IO.BinaryReader(fs2);

            string str_byte_x;
            byte[] NewBinData = new byte[fs2.Length];

            for (i = 0; i < fs2.Length; i++)
            {
                if ((i > 0) && (0 == i % 16))
                    richTextBox_Bin.AppendText("\r\n");

                str_byte_x = "";
                NewBinData[i] = read2.ReadByte();

                if (NewBinData[i] < 0x10)
                    str_byte_x += "0";

                str_byte_x += Convert.ToString(NewBinData[i], 16);
                str_byte_x = str_byte_x.ToUpper() + " ";

                richTextBox_Bin.AppendText(str_byte_x);
            }

            fs.Close();
        }
    }
}
