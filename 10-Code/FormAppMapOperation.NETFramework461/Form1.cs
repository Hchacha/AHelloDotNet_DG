using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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

namespace FormAppMapOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bing混合地图
            gMapControl1.MapProvider = GMapProviders.BingHybridMap;

            //离线模式
            string mapPath = Application.StartupPath + "\\bingmap.gmdb";
            gMapControl1.CacheLocation = mapPath;
            gMapControl1.Manager.Mode = AccessMode.CacheOnly;
            //GMap.NET.GMaps.Instance.ImportFromGMDB(mapPath);

            //地图中心位置
            //gMap.SetPositionByKeywords("beijing, china"); 
            //    gMapControl1.Position = new PointLatLng(39.185422, 112.252810);  //中心点的纬度，经度     

            //    //不显示中心十字点
            //    gMapControl1.ShowCenter = false;
            //    //左键拖拽地图
            //    gMapControl1.DragButton = MouseButtons.Left;
            //    gMapControl1.MinZoom = 2;   //最小缩放
            //    gMapControl1.MaxZoom = 18;  //最大缩放
            //    gMapControl1.Zoom = 6;      //当前缩放

            gMapControl1_Load(sender, e);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            new Thread(() => GMap.NET.GMaps.Instance.ImportFromGMDB(AppDomain.CurrentDomain.BaseDirectory + "\\bingmap.gmdb")).Start();
            gMapControl1.Manager.Mode = GMap.NET.AccessMode.ServerOnly;
        }
    }
}
