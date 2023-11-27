using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCB
{
    internal class IDK
    {
        public static void ED(Control control)
        {
            Guna.UI2.WinForms.Guna2DragControl dragControl = new Guna.UI2.WinForms.Guna2DragControl();
            dragControl.TargetControl = control;
        }
        public static void AddTextToPanel(Guna.UI2.WinForms.Guna2Panel panel, string text)
        {
            Guna.UI2.WinForms.Guna2HtmlLabel label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label.Text = $"[LOGS] {DateTime.Now.ToString("HH:mm:ss")} {text}";
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            if (panel.Controls.Count > 0)
            {
                Control previousControl = panel.Controls[panel.Controls.Count - 1];
                label.Location = new Point(previousControl.Left, previousControl.Bottom + 10);
            }
            int totalheight = panel
                .Controls
                .OfType<Control>()
                .Sum(control => control.Height + control.Margin.Vertical);
            label.Location = new Point(10, totalheight + 10);
            panel.Controls.Add(label);
            panel.VerticalScroll.Value = panel.VerticalScroll.Maximum;
            panel.PerformLayout();
        }
    }
}
