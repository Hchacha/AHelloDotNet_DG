using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unity3D
{
    public class UnityHelper
    {
        public static AxUnityWebPlayerAXLib.AxUnityWebPlayer CreateUnity(Form form,string src)
        {
            var unity = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(unity)).BeginInit();
            form.Controls.Add(unity);
            ((System.ComponentModel.ISupportInitialize)(unity)).EndInit();
            unity.src = src;
            AxHost.State state = unity.OcxState;
            unity.Dispose();
            unity = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(unity)).BeginInit();
            form.SuspendLayout();
            unity.Dock = DockStyle.Fill;
            unity.Name = "Unity";
            unity.OcxState = state;
            unity.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(unity)).EndInit();
            form.ResumeLayout(false);
            return unity;
        }
    }
}
