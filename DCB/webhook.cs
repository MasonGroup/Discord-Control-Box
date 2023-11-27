using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCB
{
    public partial class webhook : UserControl
    {
        public webhook()
        {
            InitializeComponent();
            statuswebhook.Text = "standby";
        }

        private void extractwebhookbtn_Click(object sender, EventArgs e)
        {
            string webhoook = webhookinput.Text;
            API.SetWebhook = webhoook;
            API apiInstance = new API();
            bool valid = apiInstance.checkwebhook();
            if (valid)
            {
                
                dynamic webhookinfo = Newtonsoft.Json.JsonConvert.DeserializeObject(apiInstance.extract_webhook_info());
                string applicationId = webhookinfo.application_id;
                string avatar = webhookinfo.avatar;
                string channelId = webhookinfo.channel_id;
                string guildId = webhookinfo.guild_id;
                string webhookId = webhookinfo.id;
                string name = webhookinfo.name;
                int type = webhookinfo.type;
                string userId = webhookinfo.user.id;
                string username = webhookinfo.user.username;
                string userAvatar = webhookinfo.user.avatar;
                string discriminator = webhookinfo.user.discriminator;
                infotextbox.Text = $"Application ID: {applicationId}\r\n" +
                       $"Avatar: {avatar}\r\n" +
                       $"Channel ID: {channelId}\r\n" +
                       $"Guild ID: {guildId}\r\n" +
                       $"Webhook ID: {webhookId}\r\n" +
                       $"Name: {name}\r\n" +
                       $"Type: {type}\r\n" +
                       $"User ID: {userId}\r\n" +
                       $"creator: {username}\r\n" +
                       $"User Avatar: {userAvatar}\r\n" +
                       $"Discriminator: {discriminator}";
            }
            else
            {
                MessageBox.Show("webhook is not vaild");
            }
        }

        private void checkvaildbtn_Click(object sender, EventArgs e)
        {
            string webhoook = webhookinput.Text;
            API.SetWebhook = webhoook;
            API apiInstance = new API();
            bool valid = apiInstance.checkwebhook();
            if (valid)
            {
                MessageBox.Show("webhook is vaild");
            }
            else
            {
                MessageBox.Show("webhook is not vaild");
            }
        }

        private void webhook_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string webhoook = webhookinput.Text;
            API.SetWebhook = webhoook;
            API apiInstance = new API();
            bool valid = apiInstance.checkwebhook();
            if (valid)
            {
                if (apiInstance.deletewebhook())
                {
                    MessageBox.Show("webhook has been deleted");
                }
            }
            else
            {
                MessageBox.Show("webhook is not vaild");
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string webhoook = webhookinput.Text;
            API.SetWebhook = webhoook;
            API apiInstance = new API();
            bool valid = apiInstance.checkwebhook();
            if (!valid)
            {
                MessageBox.Show("webhook is not vaild");
            }
            int nom;
            string content = webhookmsg.Text;
            string username = webhookusernane.Text;
            string Avatarurl = avatarurl.Text;
            if (!int.TryParse(amountmessages.Text, out nom))
            {
                statuswebhook.Text = "Invalid number of messages";
                return;
            }
            if (string.IsNullOrWhiteSpace(content))
            {
                statuswebhook.Text = "Send empty message? very nice";
                return;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                statuswebhook.Text = "Set username";
                return;
            }
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < nom; i++)
                {
                    bool success = false;

                    for (int attempt = 0; attempt < 3 && !success; attempt++)
                    {
                        Invoke(new Action(() =>
                        {
                            success = apiInstance.sendmessage(content, Avatarurl, username);
                            if (success)
                            {
                                statuswebhook.Text = $"Message {i + 1}/{nom} sent successfully!";
                            }
                            else
                            {
                                statuswebhook.Text = $"Error sending message {i + 1}/{nom}. Retrying...";
                            }
                        }));
                    }
                }

                Invoke(new Action(() =>
                {
                    statuswebhook.Text = "All messages sent!";
                }));
            });

            thread.Start();
        }



        private void closebtn_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
