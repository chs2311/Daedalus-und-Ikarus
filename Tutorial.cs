using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Engine
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            Text = "Daedalus und Ikarus [Tutorial] Version 0.2 Benutzername: " + System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/spaceman");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/coin");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/bird");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.freepik.com/free-photo/blue-sky-sea-landscape_2353028.htm#query=sea%20sky&position=31&from_view=keyword&track=ais_user&uuid=64506a84-ebf8-4ad1-acd3-e68b0938888e");
        }

        private void ExitGAme(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
