using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DCB
{
    public partial class dump : UserControl
    {
        public dump()
        {
            InitializeComponent();
            IDK.AddTextToPanel(this.loggingpanel, "Program started");
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            string token = tokeninput.Text;
            API.SetToken = token;
            API apiInstance = new API();
            bool valid = apiInstance.checktoken();
            if (valid)
            {
                IDK.AddTextToPanel(this.loggingpanel, "dumped the token info");
                apiInstance.TokenInfo();
            }
            else
            {
                IDK.AddTextToPanel(this.loggingpanel, "Failed to connect, Maybe its invaild?");
            }
        }

        private void dump_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
