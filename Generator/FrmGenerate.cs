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

        //此处私钥需要通过rsa.RSAKey()来进行生成，与Register项目中公钥是一对
        private readonly string privateKey = @"
<RSAKeyValue>
<Modulus>5vUf2tCILfv1T6oQK6kY36UGefK9yuueZkf6ZboLakIhY9shbTS7o653Z0k7iFrdP5kOcRxSm6XLSZ0+H8fzAeBrxLmwqwd1Jwb2V5TBj6ee3mqK3ZIQ1Ikv6akovynkitILvI2arftHJySU3Dul+U87DYaEeCFJ49SOdnBfmUU=</Modulus>
<Exponent>AQAB</Exponent>
<P>7iUPMOEdD7QT4EkwH2Ut+aXp1JwuArzozTO6TmPrBnR1SVfFNIJNBaKqHElFfONz28LZB5d1r9ngz9XV4QIxiw==</P>
<Q>+EYdB6TZ+1/ulzgJAGQTrCE1QqtC3EGvV9FDT2AwmoESNJjcSx9L5A9296rYX1smzFZPQT5+HJAPyLFi2qwabw==</Q>
<DP>sBDcI1I7zzFfBJJ3rq56iDk/IL57UfDi2VumIXDEAVi2ogvvM/wl/8WcqR8O7d+n99Ed7fvvuZyHFoHNB/c8Mw==</DP>
<DQ>v4048KDcHfpSFxIAv/B2zSOB+EIyf8WeB19JU4Cff1V+Ol6F+N/YqcjUvRlvf4LQWG9vDqOsoVT1GJ7j6ltGuQ==</DQ>
<InverseQ>wPvU4o8ZjkUs+taD+NtJn6IBUNBzjClL0uvh4Nc9kmcjNr4ujkHpGEsmbpV3pgRXZS5bhtDyMMzjUdGE0+C5lA==</InverseQ>
<D>y2VMrHPBul2OaJ4op4q/8RVwYq04ICDo2sLA7h2uN+INbddp1LcAGOJpHXkNCMSc3Il6gnqi9ZhJM4dbUrnQc0ZEiAoZBXFaS8xbJHt2wZw12LUHSA9cG/tLIZ3W/350n8XOKUFg/wEA8Npr9bwnWOBvpWdw7fGhWKCg7+LV0nE=</D>
</RSAKeyValue>
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
