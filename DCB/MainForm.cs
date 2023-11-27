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
    public partial class MainForm : Form
    {
        private dump dumpControl;
        private webhook webhookControl;
        private stubbuilder stubControl;
        private about aboutControl;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dumpControl = new dump();
            webhookControl = new webhook();
            stubControl = new stubbuilder();
            aboutControl = new about();
            Controls.Add(dumpControl);
            Controls.Add(webhookControl);
            Controls.Add(stubControl);
            Controls.Add(aboutControl);
            dumpControl.Dock = DockStyle.Right;
            webhookControl.Dock = DockStyle.Right;
            stubControl.Dock = DockStyle.Right;
            aboutControl.Dock = DockStyle.Right;
            IDK.ED(dumpControl);
            IDK.ED(webhookControl);
            IDK.ED(stubControl);
            IDK.ED(aboutControl);
            dumpControl.Show();
            webhookControl.Hide();
            stubControl.Hide();
            aboutControl.Hide();

        }
        private void dumpinfobtn_Click(object sender, EventArgs e)
        {
            dumpControl.Show();
            webhookControl.Hide();
            stubControl.Hide();
            aboutControl.Hide();
        }
        private void webhooktoolsbtn_Click(object sender, EventArgs e)
        {
            webhookControl.Show();
            dumpControl.Hide();
            stubControl.Hide();
            aboutControl.Hide();
        }

        private void stubbuilderbtn_Click(object sender, EventArgs e)
        {
            stubControl.Show();
            dumpControl.Hide();
            webhookControl.Hide();
            aboutControl.Hide();
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            stubControl.Hide();
            dumpControl.Hide();
            webhookControl.Hide();
            aboutControl.Show();
        }
    }
}
