namespace DCB
{
    partial class dump
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dump));
            this.label1 = new System.Windows.Forms.Label();
            this.tokeninput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Connectbtn = new Guna.UI2.WinForms.Guna2Button();
            this.loggingpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discord Control Box";
            // 
            // tokeninput
            // 
            this.tokeninput.BackColor = System.Drawing.Color.Transparent;
            this.tokeninput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.tokeninput.BorderRadius = 16;
            this.tokeninput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tokeninput.DefaultText = "";
            this.tokeninput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tokeninput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tokeninput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tokeninput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tokeninput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.tokeninput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.tokeninput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tokeninput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.tokeninput.Location = new System.Drawing.Point(24, 109);
            this.tokeninput.Name = "tokeninput";
            this.tokeninput.PasswordChar = '\0';
            this.tokeninput.PlaceholderText = "";
            this.tokeninput.SelectedText = "";
            this.tokeninput.Size = new System.Drawing.Size(615, 36);
            this.tokeninput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter discord token to dump info";
            // 
            // Connectbtn
            // 
            this.Connectbtn.Animated = true;
            this.Connectbtn.BorderRadius = 16;
            this.Connectbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Connectbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Connectbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Connectbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Connectbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.Connectbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Connectbtn.ForeColor = System.Drawing.Color.White;
            this.Connectbtn.Image = ((System.Drawing.Image)(resources.GetObject("Connectbtn.Image")));
            this.Connectbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Connectbtn.ImageSize = new System.Drawing.Size(24, 24);
            this.Connectbtn.Location = new System.Drawing.Point(248, 164);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(173, 45);
            this.Connectbtn.TabIndex = 5;
            this.Connectbtn.Text = "Dump info";
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // loggingpanel
            // 
            this.loggingpanel.AutoScroll = true;
            this.loggingpanel.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.loggingpanel.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.loggingpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.loggingpanel.Location = new System.Drawing.Point(24, 228);
            this.loggingpanel.Name = "loggingpanel";
            this.loggingpanel.Size = new System.Drawing.Size(621, 295);
            this.loggingpanel.TabIndex = 6;
            // 
            // closebtn
            // 
            this.closebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.closebtn.Location = new System.Drawing.Point(621, 3);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closebtn.Size = new System.Drawing.Size(41, 40);
            this.closebtn.TabIndex = 35;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // dump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.loggingpanel);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tokeninput);
            this.Controls.Add(this.label1);
            this.Name = "dump";
            this.Size = new System.Drawing.Size(665, 536);
            this.Load += new System.EventHandler(this.dump_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tokeninput;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Connectbtn;
        private Guna.UI2.WinForms.Guna2Panel loggingpanel;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
    }
}
