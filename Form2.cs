using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_click_atlas_2
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var parameter = new ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://github.com/gui013memo" };
            Process.Start(parameter);

            //O site que resolveu meu problema: https://docs.microsoft.com/en-us/answers/questions/406989/winformapplication-systemcomponentmodelwin32except.html
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lb2_Dev_Click(object sender, EventArgs e)
        {

        }
    }
}
