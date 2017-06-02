using System;
using System.Windows.Forms;

using System.Media;

using System.Runtime.InteropServices; 

namespace MediaPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///
        ///值得注意的一点：每种方法最好都将媒体文件的属性设置----
        ///声音文件右键属性 生成操作（嵌入的资源）复制到输出的目录（始终复制）
        ///



        //播放系统事件声音
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Question.Play();
        }

        //  2   使用System.Media.SoundPlayer播放wav波形文件
        //using System.Media;
        //需要注意的是必须 声音文件右键属性 生成操作（嵌入的资源）复制到输出的目录（始终复制）
        private void button6_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer soundPlayer = new SoundPlayer();
            //soundPlayer.SoundLocation = @"source/dota_kill.wav";
            //soundPlayer.PlayLooping();
            //上下两种写法都可以
            SoundPlayer soundPlayer = new SoundPlayer(@"source/dota_kill.wav");
            soundPlayer.PlayLooping();
        }

        //   3   使用MCI Command String多媒体设备程序接口播放mp3，avi等  亲测不支持wav
        //using System.Runtime.InteropServices; 
        //这个方法可以识别一般的文件，比较强大！！
       // public static uint SND_ASYNC = 0x0001; 
       // public static uint SND_FILENAME = 0x00020000;
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand, string lpstrReturnString, uint uReturnLength, uint hWndCallback);
        private void button7_Click(object sender, EventArgs e)
        {
            //mciSendString(@"close temp_alias", null, 0, 0);
            mciSendString(@"open  source/dota_kill.mp3 alias temp_alias", null, 0, 0); 
            mciSendString("play temp_alias repeat", null, 0, 0); //去掉repeat可以单次播放不循环
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"notepad.exe","source/MCISendString详细参数.txt");
        }

        //第4种方法  可以播放视频
        /// 4.使用axWindowsMediaPlayer的COM组件来播放 
        //a.加载COM组件:ToolBox->Choose Items->COM Components->Windows Media Player如下图：
        //b.把Windows Media Player控件拖放到Winform窗体中，把axWindowsMediaPlayer1中URL属性设置为MP3或是AVI的文件路径，F5运行。
        /// 属性页可以设置是否加载窗体就播放
    }
}
