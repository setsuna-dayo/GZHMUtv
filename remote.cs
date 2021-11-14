using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mynewtv
{
    public partial class remote : Form
    {
        int list_select = 0;

        //1
        Dictionary<string, string> locallivetv = new Dictionary<string, string>
            {
                {"广东卫视", @"http://203.118.192.21:90/live/guangdong_1500.m3u8"},
                {"广东珠江", @"http://203.118.192.21:90/live/gdzhujiang_1500.m3u8"},
                {"广东公共", @"http://203.118.192.21:90/live/gdpublic_1500.m3u8" },
                {"广东新闻", @"http://203.118.192.21:90/live/gdnews_1500.m3u8"},
                {"广东体育HD", @"http://203.118.192.21:90/live/gdsportsHD_3000.m3u8"},
                {"广东经济科教HD", @"http://203.118.192.21:90/live/GDjingjikejiaoHD_3000.m3u8"},
                {"广东南方卫视", @"http://203.118.192.21:90/live/gdnanfang_1500.m3u8"},
                {"广东影视", @"http://203.118.192.21:90/live/gdyingshi_1500.m3u8"},
                {"广东少儿", @"http://203.118.192.21:90/live/gdshaoer_1500.m3u8"}
            };

        //2
        Dictionary<string, string> cctvlivetv = new Dictionary<string, string>
            {
                {"CCTV1 HD", @"http://203.118.192.22:90/live/CCTV1HD_3000.m3u8"},
                {"CCTV2 HD", @"http://203.118.192.22:90/live/CCTV2HD_3000.m3u8"},
                {"CCTV3", @"http://203.118.192.22:90/live/CCTV3_1500.m3u8" },
                {"CCTV4国际", @"http://203.118.192.22:90/live/CCTV4_1500.m3u8"},
                {"CCTV5", @"http://203.118.192.21:90/live/CCTV5_1500.m3u8"},
                {"CCTV6 HD", @"http://203.118.192.21:90/live/CCTV6HD_3000.m3u8"},
                {"CCTV7 HD", @"http://203.118.192.22:90/live/CCTV7HD_3000.m3u8"},
                {"CCTV8", @"http://203.118.192.21:90/live/CCTV8HD_1500.m3u8"},
                {"CCTV9", @"http://203.118.192.21:90/live/CCTV9HD_3000.m3u8"},
                {"CCTV10 HD", @"http://203.118.192.21:90/live/CCTV10HD_3000.m3u8"},
                {"CCTV11 HD", @"http://203.118.192.22:90/live/CCTV11_1500.m3u8"},
                {"CCTV12 HD", @"http://203.118.192.22:90/live/CCTV12HD_3000.m3u8"},
                {"CCTV13", @"http://203.118.192.21:90/live/CCTV13_1500.m3u8"}
            };

        //3
        Dictionary<string, string> otherslive = new Dictionary<string, string>
            {
                {"香港翡翠", @"http://203.118.192.22:90/live/xgfeicui_1500.m3u8"},
                {"香港明珠", @"http://203.118.192.22:90/live/xgmingzhu_1500.m3u8"},
                {"世界地理", @"http://203.118.192.22:90/live/shijiedili_1500.m3u8" },
                {"风云音乐", @"http://203.118.192.22:90/live/fengyunyinyue_1500.m3u8"},
                {"魅力足球", @"http://203.118.192.22:90/live/meiliyinyue_1500.m3u8"},
                {"环球奇观", @"http://203.118.192.22:90/live/huanqiuqiguan_1500.m3u8"},
                {"全纪实", @"http://203.118.192.22:90/live/quanjishi_1500.m3u8"},
                {"凤凰中文台", @"http://203.118.192.21:90/live/fhzw_1500.m3u8"},
                {"湖南卫视 HD", @"http://203.118.192.21:90/live/hunanHD_3000.m3u8"},
                {"浙江卫视 HD", @"http://203.118.192.22:90/live/zhejiangHD_3000.m3u8"},
                {"安徽卫视 HD", @"http://203.118.192.21:90/live/anhuiHD_3000.m3u8"},
                {"江苏卫视 HD", @"http://203.118.192.21:90/live/jiangsuHD_3000.m3u8"},
                {"天津卫视 HD", @"http://203.118.192.21:90/live/tianjinHD_3000.m3u8"},
                {"山东卫视 HD", @"http://203.118.192.22:90/live/shandongHD_3000.m3u8"},
                {"四川卫视 HD", @"http://203.118.192.22:90/live/sichuanHD_3000.m3u8"},
                {"江西卫视 HD", @"http://203.118.192.22:90/live/jiangxiHD_3000.m3u8"},
                {"东方卫视 HD", @"http://203.118.192.21:90/live/dongfangHD_3000.m3u8"},
                {"北京卫视 HD", @"http://203.118.192.21:90/live/beijingHD_3000.m3u8"},
                {"深圳卫视 HD", @"http://203.118.192.22:90/live/shenzhenHD_3000.m3u8"},
                {"黑龙江卫视 HD", @"http://203.118.192.22:90/live/heilongjiangHD_1500.m3u8"}
            };

        //4
        Dictionary<string, string> movie = new Dictionary<string, string>
            {
                {"复仇者联盟", @"http://203.118.192.24:8011/vod/fczlm/fczlm.m3u8"},
                {"复仇者联盟2", @"http://203.118.192.24:8011/vod/fczlm2/fczlm2.m3u8"},
                {"复仇者联盟3", @"http://203.118.192.24:8011/vod/fczlm3/fczlm3.m3u8" },
                {"神奇女侠", @"http://203.118.192.24:8011/vod/35/35.m3u8"},
                {"少年派的奇幻漂流", @"http://203.118.192.24:8011/vod/33/33.m3u8"},
                {"奇异博士", @"http://203.118.192.24:8011/vod/30/30.m3u8"}
            };

        public remote()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var channel in locallivetv.Keys)
            {
                checkedListBox1.Items.Add(channel);
            }
            list_select = 1;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        this.checkedListBox1.SetItemCheckState(i,
                        System.Windows.Forms.CheckState.Unchecked);
                    }
                }
            }
            
        }

        string pass = "";
        tv tv = new tv();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string check in checkedListBox1.CheckedItems)
            {
                pass = check;
            }
            switch (list_select)
            {
                case 0:
                    MessageBox.Show("请先加载列表并勾选一个频道！");
                    break;
                case 1:
                    try
                    {
                        pass = locallivetv[pass];
                    }
                    catch
                    {
                        MessageBox.Show("请先加载列表并勾选一个频道！");
                    }
                    break;
                case 2:
                    try
                    {
                        pass = cctvlivetv[pass];
                    }
                    catch
                    {
                        MessageBox.Show("请先加载列表并勾选一个频道！");
                    }
                    break;
                case 3:
                    try
                    {
                        pass = otherslive[pass];
                    }
                    catch
                    {
                        MessageBox.Show("请先加载列表并勾选一个频道！");
                    }
                    break;
                case 4:
                    try
                    {
                        pass = movie[pass];
                    }
                    catch
                    {
                        MessageBox.Show("请先加载列表并勾选一个频道！");
                    }
                    break;
            }
            try
            {
                tv.Show();
                tv.player.Load(pass);
                tv.player.Resume();
            }
            catch
            {
                tv.Show();
                tv.player.Load(@"http://devimages.apple.com/iphone/samples/bipbop/bipbopall.m3u8");
                tv.player.Resume();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var channel in cctvlivetv.Keys)
            {
                checkedListBox1.Items.Add(channel);
            }
            list_select = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var channel in otherslive.Keys)
            {
                checkedListBox1.Items.Add(channel);
            }
            list_select = 3;
        }

        private void remote_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var channel in movie.Keys)
            {
                checkedListBox1.Items.Add(channel);
            }
            list_select = 4;            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tv.player.IsPlaying)
            {
                tv.player.Pause();
                button7.Text = "继续";
            }
            else
            {
                tv.player.Resume();
                button7.Text = "暂停";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.TopMost == false)
            {
                this.TopMost = true;
                label3.Text = "取消遥控器置顶";
            }
            else
            {
                this.TopMost = false;
                label3.Text = "设置遥控器置顶";
            }
        }

        private void remote_Load(object sender, EventArgs e)
        {
            
        }

        private void remote_Shown(object sender, EventArgs e)
        {
            
        }

        /**
        private void flick()
        {
            Thread.Sleep(500);
            button8.BackColor = Color.Transparent;
            Thread.Sleep(300);
            button8.BackColor = Color.Aqua;
            Thread.Sleep(300);
            button8.BackColor = Color.Transparent;
            Thread.Sleep(300);
            button8.BackColor = Color.Aqua;
            Thread.Sleep(300);
            button8.BackColor = Color.Transparent;
            Thread.Sleep(300);
            button8.BackColor = Color.Aqua;
            Thread.Sleep(300);
            button8.BackColor = Color.Transparent;
        }
        **/
    }
}
