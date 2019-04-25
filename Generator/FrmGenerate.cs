using System;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using CustomSkin.Windows.Forms;
using Register;

namespace Generator
{
    public partial class FrmGenerate : FormBase
    {
        private RSACryption rsa = new RSACryption();
        private JavaScriptSerializer convert = new JavaScriptSerializer();
        private readonly string privateKey = @"
此处私钥需要通过rsa.RSAKey()来进行生成，与Register项目中公钥是一对
";

        public FrmGenerate()
        {
            InitializeComponent();
        }

        private void FrmGenerate_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                RegInfo regInfo = new RegInfo();
                RegBaseInfo baseInfo = new RegBaseInfo();
                baseInfo.MachineCode = this.txtMachineCode.Text;
                baseInfo.OrganizationCode = this.txtOrgCode.Text;
                baseInfo.OrganizationName = this.txtOrganization.Text;
                baseInfo.ExpiryDate = this.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                regInfo.RegBase = baseInfo;
                regInfo.Signature = rsa.SignatureFormatter(privateKey, rsa.GetHash(convert.Serialize(baseInfo)));
                File.WriteAllText(saveFileDialog1.FileName,
                    Convert.ToBase64String(Encoding.Default.GetBytes(convert.Serialize(regInfo))),
                    Encoding.Default);
                CustomSkin.Windows.Forms.MessageBox.Show("生成成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
