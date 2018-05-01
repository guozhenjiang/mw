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
        string BinName;
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
            //openFileDialog_SelBin.Filter = "*.bin";

            if(openFileDialog_SelBin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BinName = openFileDialog_SelBin.FileName;

                textBox_BinName.Text = BinName;
            }
        }
    }
}
