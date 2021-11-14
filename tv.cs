using Mpv.NET.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mynewtv
{
    public partial class tv : Form
    {
        public MpvPlayer player;

        public tv()
        {
            InitializeComponent();
            player = new MpvPlayer(this.Handle)
            {
                Loop = true,
                Volume = 50
            };
            string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //MessageBox.Show(ApplicationData);
            player.LoadConfig(ApplicationData + @"\gzhmutv\mpv.conf");
        }

        private void tv_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Dispose();
        }

        //禁用关闭按钮
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
