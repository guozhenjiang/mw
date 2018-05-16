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

namespace BinCRC
{
    public partial class FormMain : Form
    {
        string Str_FilePathNameExt;
        long FileLen = 0;

        // CRC32
        string Str_CRC32_InitVal;
        string Str_CRC32_Poly;
        string Str_CRC32_Val;

        UInt32 CRC32_InitVal;
        long CRC32_Poly;
        long CRC32_Val;
        
        // CRC16
        string Str_CRC16_InitVal;
        string Str_CRC16_Poly;
        string Str_CRC16_Val;

        UInt32 CRC16_InitVal;
        UInt32 CRC16_Poly;
        UInt32 CRC16_Val;

        // CRC08
        string Str_CRC08_InitVal;
        string Str_CRC08_Poly;
        string Str_CRC08_Val;

        UInt32 CRC08_InitVal;
        UInt32 CRC08_Poly;
        UInt32 CRC08_Val;

        public FormMain()
        {
            InitializeComponent();
            tb_crc32_init_val.Text = "FFFFFFFF";
            tb_crc32_poly.Text = "104C11DB7";
        }

        private void bt_file_sel_MouseClick(object sender, MouseEventArgs e)
        {
            // 如果成功打开文件
            if(System.Windows.Forms.DialogResult.OK == openFileDialog_SelBin.ShowDialog())
            {
                Str_FilePathNameExt = openFileDialog_SelBin.FileName;   // 记录打开文件的 路径、文件名、后缀
                FileInfo BinInfo = new FileInfo(Str_FilePathNameExt);   // 进一步获取文件信息

                FileLen = BinInfo.Length;                               // 获取文件长度 字节数

                // 清空校验结果
                Str_CRC32_Val = "";
                Str_CRC16_Val = "";
                Str_CRC08_Val = "";
                tb_crc32_val.Text = Str_CRC32_Val;
                tb_crc16_val.Text = Str_CRC16_Val;
                tb_crc08_val.Text = Str_CRC08_Val;

                // 更新提示信息
                tb_file.Text = Str_FilePathNameExt;     // 显示文件路径、名称、扩展名
                tb_file_len.Text = FileLen.ToString();  // 显示文件大小
            }
        }

        private void bt_run_crc_MouseClick(object sender, MouseEventArgs e)
        {
            // 进行校验时，必须已知初始值和多项式
            if (("" != tb_crc32_init_val.Text) && ("" != tb_crc32_poly.Text))
            {
                //CRC32_InitVal = Convert.ToUInt32(tb_crc32_init_val.Text);
                //CRC32_Poly = Convert.ToUInt32(tb_crc32_poly);
                CRC32_InitVal = UInt32.Parse(tb_crc32_init_val.Text, System.Globalization.NumberStyles.HexNumber);
                CRC32_Poly = long.Parse(tb_crc32_poly.Text, System.Globalization.NumberStyles.HexNumber);

                // 进行校验计算
                FileStream file_stream = new FileStream(Str_FilePathNameExt, FileMode.Open);
                System.IO.BinaryReader file_read = new System.IO.BinaryReader(file_stream);

                long i, j, k;
                UInt32[] byte_cache = new UInt32[4];

                CRC32_Val = CRC32_InitVal;
                
                for(i=0; i< FileLen; i+=4)
                {
                    // 字节顺序从高到低
                    byte_cache[3] = file_read.ReadByte();
                    byte_cache[2] = file_read.ReadByte();
                    byte_cache[1] = file_read.ReadByte();
                    byte_cache[0] = file_read.ReadByte();

                    for(k=0; k<4; k++)
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

                tb_crc32_val.Text = Convert.ToString(CRC32_Val, 16).ToUpper();
            }
        }
    }
}

