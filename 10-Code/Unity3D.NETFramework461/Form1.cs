using System;
using System.Windows.Forms;

namespace Unity3D.NETFramework461
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string src = Application.StartupPath+@"/Unity3dFiles/trans.unity3d";

            var unity = UnityHelper.CreateUnity(this,src);

            Form form = new Form();
            form.Controls.Add(unity);
            form.Show();
        }
    }
}
