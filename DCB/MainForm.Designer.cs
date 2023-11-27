namespace DCB
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menupanel = new Guna.UI2.WinForms.Guna2Panel();
            this.stubbuilderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.webhooktoolsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.aboutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.dumpinfobtn = new Guna.UI2.WinForms.Guna2Button();
            this.menudrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.form1drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.webhook1 = new DCB.webhook();
            this.dump1 = new DCB.dump();
            this.menupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.menupanel.Controls.Add(this.stubbuilderbtn);
            this.menupanel.Controls.Add(this.webhooktoolsbtn);
            this.menupanel.Controls.Add(this.aboutbtn);
            this.menupanel.Controls.Add(this.guna2Separator1);
            this.menupanel.Controls.Add(this.label1);
            this.menupanel.Controls.Add(this.dumpinfobtn);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(200, 536);
            this.menupanel.TabIndex = 0;
            // 
            // stubbuilderbtn
            // 
            this.stubbuilderbtn.Animated = true;
            this.stubbuilderbtn.BorderRadius = 16;
            this.stubbuilderbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stubbuilderbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stubbuilderbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stubbuilderbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stubbuilderbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.stubbuilderbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stubbuilderbtn.ForeColor = System.Drawing.Color.White;
            this.stubbuilderbtn.Image = ((System.Drawing.Image)(resources.GetObject("stubbuilderbtn.Image")));
            this.stubbuilderbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stubbuilderbtn.ImageSize = new System.Drawing.Size(24, 24);
            this.stubbuilderbtn.Location = new System.Drawing.Point(12, 227);
            this.stubbuilderbtn.Name = "stubbuilderbtn";
            this.stubbuilderbtn.Size = new System.Drawing.Size(173, 45);
            this.stubbuilderbtn.TabIndex = 5;
            this.stubbuilderbtn.Text = "Stub builder";
            this.stubbuilderbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stubbuilderbtn.Click += new System.EventHandler(this.stubbuilderbtn_Click);
            // 
            // webhooktoolsbtn
            // 
            this.webhooktoolsbtn.Animated = true;
            this.webhooktoolsbtn.BorderRadius = 16;
            this.webhooktoolsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.webhooktoolsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.webhooktoolsbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.webhooktoolsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.webhooktoolsbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.webhooktoolsbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.webhooktoolsbtn.ForeColor = System.Drawing.Color.White;
            this.webhooktoolsbtn.Image = ((System.Drawing.Image)(resources.GetObject("webhooktoolsbtn.Image")));
            this.webhooktoolsbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.webhooktoolsbtn.ImageSize = new System.Drawing.Size(24, 24);
            this.webhooktoolsbtn.Location = new System.Drawing.Point(12, 163);
            this.webhooktoolsbtn.Name = "webhooktoolsbtn";
            this.webhooktoolsbtn.Size = new System.Drawing.Size(173, 45);
            this.webhooktoolsbtn.TabIndex = 4;
            this.webhooktoolsbtn.Text = "webhook controller";
            this.webhooktoolsbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.webhooktoolsbtn.Click += new System.EventHandler(this.webhooktoolsbtn_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Animated = true;
            this.aboutbtn.BorderRadius = 16;
            this.aboutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.aboutbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aboutbtn.ForeColor = System.Drawing.Color.White;
            this.aboutbtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutbtn.Image")));
            this.aboutbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aboutbtn.ImageSize = new System.Drawing.Size(24, 24);
            this.aboutbtn.Location = new System.Drawing.Point(12, 462);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(173, 45);
            this.aboutbtn.TabIndex = 3;
            this.aboutbtn.Text = "about";
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(12, 434);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(174, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "DCB";
            // 
            // dumpinfobtn
            // 
            this.dumpinfobtn.Animated = true;
            this.dumpinfobtn.BorderRadius = 16;
            this.dumpinfobtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dumpinfobtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dumpinfobtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dumpinfobtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dumpinfobtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.dumpinfobtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dumpinfobtn.ForeColor = System.Drawing.Color.White;
            this.dumpinfobtn.Image = ((System.Drawing.Image)(resources.GetObject("dumpinfobtn.Image")));
            this.dumpinfobtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dumpinfobtn.ImageSize = new System.Drawing.Size(24, 24);
            this.dumpinfobtn.Location = new System.Drawing.Point(12, 98);
            this.dumpinfobtn.Name = "dumpinfobtn";
            this.dumpinfobtn.Size = new System.Drawing.Size(173, 45);
            this.dumpinfobtn.TabIndex = 0;
            this.dumpinfobtn.Text = "Dump token info";
            this.dumpinfobtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dumpinfobtn.Click += new System.EventHandler(this.dumpinfobtn_Click);
            // 
            // menudrag
            // 
            this.menudrag.DockForm = true;
            this.menudrag.DockIndicatorTransparencyValue = 0.6D;
            this.menudrag.TargetControl = this.menupanel;
            this.menudrag.UseTransparentDrag = true;
            // 
            // form1drag
            // 
            this.form1drag.DockForm = true;
            this.form1drag.DockIndicatorTransparencyValue = 0.6D;
            this.form1drag.TargetControl = this;
            this.form1drag.UseTransparentDrag = true;
            // 
            // webhook1
            // 
            this.webhook1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webhook1.Location = new System.Drawing.Point(200, 0);
            this.webhook1.Name = "webhook1";
            this.webhook1.Size = new System.Drawing.Size(672, 536);
            this.webhook1.TabIndex = 2;
            // 
            // dump1
            // 
            this.dump1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dump1.Location = new System.Drawing.Point(200, 0);
            this.dump1.Name = "dump1";
            this.dump1.Size = new System.Drawing.Size(672, 536);
            this.dump1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(872, 536);
            this.Controls.Add(this.webhook1);
            this.Controls.Add(this.dump1);
            this.Controls.Add(this.menupanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel menupanel;
        private Guna.UI2.WinForms.Guna2Button dumpinfobtn;
        private Guna.UI2.WinForms.Guna2Button aboutbtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private dump home1;
        private Guna.UI2.WinForms.Guna2DragControl menudrag;
        private dump dump1;
        private Guna.UI2.WinForms.Guna2Button webhooktoolsbtn;
        private webhook webhook1;
        private Guna.UI2.WinForms.Guna2DragControl form1drag;
        private Guna.UI2.WinForms.Guna2Button stubbuilderbtn;
    }
}

