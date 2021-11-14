using Mpv.NET.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mynewtv
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }

        private void tv_main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form remote1 = new remote();
            remote1.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("cyanskyofyou@outlook.com");
            MessageBox.Show("电子邮件地址已复制到剪贴板！");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
