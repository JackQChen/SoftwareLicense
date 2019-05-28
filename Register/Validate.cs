using System;
using System.IO;
using System.Management;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Register
{
    public sealed class Validate
    {

        private RSACryption rsa = new RSACryption();
        private JavaScriptSerializer convert = new JavaScriptSerializer();

        //此处公钥需要通过rsa.RSAKey()来进行生成，与Generator项目中私钥是一对
        private readonly string publicKey = @"
<RSAKeyValue>
<Modulus>5vUf2tCILfv1T6oQK6kY36UGefK9yuueZkf6ZboLakIhY9shbTS7o653Z0k7iFrdP5kOcRxSm6XLSZ0+H8fzAeBrxLmwqwd1Jwb2V5TBj6ee3mqK3ZIQ1Ikv6akovynkitILvI2arftHJySU3Dul+U87DYaEeCFJ49SOdnBfmUU=</Modulus>
<Exponent>AQAB</Exponent>
</RSAKeyValue>
";

        public Validate()
        {
            var strID = string.Format("{0},{1},{2}", GetCpuID(), GetBoardID(), GetDiskID());
            MachineCode = MD5Crytion.Encrypt(strID).ToUpper();
        }

        #region 获取机器相关信息

        private string GetCpuID()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                string strID = null;
                foreach (ManagementObject mo in moc)
                {
                    strID = mo.Properties["ProcessorId"].Value.ToString();
                    break;
                }
                return strID;
            }
            catch
            {
                return "unknow";
            }
        }

        private string GetBoardID()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_BaseBoard");
                ManagementObjectCollection moc = mc.GetInstances();
                string strID = null;
                foreach (ManagementObject mo in moc)
                {
                    strID = mo.Properties["SerialNumber"].Value.ToString();
                    break;
                }
                return strID;
            }
            catch
            {
                return "unknow";
            }
        }

        private string GetDiskID()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_PhysicalMedia");
                ManagementObjectCollection moc = mc.GetInstances();
                string strID = null;
                foreach (ManagementObject mo in moc)
                {
                    strID = mo.Properties["SerialNumber"].Value.ToString();
                    break;
                }
                return strID;
            }
            catch
            {
                return "unknow";
            }
        }

        internal string MachineCode { get; }

        #endregion

        #region 验证信息

        /// <summary>
        /// 验证是否为当前机器
        /// </summary>
        /// <param name="machineCode"></param>
        /// <returns></returns>
        private bool IsCurrentMachine(string machineCode)
        {
            return machineCode == this.MachineCode ? true : false;
        }

        /// <summary>
        /// 是否在有效期内
        /// </summary>
        private bool IsValidity(string validity)
        {
            return DateTime.Now < Convert.ToDateTime(validity);
        }

        internal bool CheckReg(string regString, bool showMsg)
        {
            RegInfo reg = null;
            return CheckReg(regString, showMsg, out reg);
        }

        internal bool CheckReg(string regString, bool showMsg, out RegInfo regInfo)
        {
            RegInfo reg = null;
            try
            {
                var infoString = Encoding.Default.GetString(Convert.FromBase64String(regString));
                reg = convert.Deserialize<RegInfo>(infoString);
                regInfo = reg;
                if (rsa.SignatureDeformatter(publicKey, rsa.GetHash(convert.Serialize(reg.RegBase)), reg.Signature))
                {
                    if (!IsCurrentMachine(reg.RegBase.MachineCode))
                    {
                        if (showMsg)
                            MessageBox.Show("非当前机器授权信息，请核对！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else if (!IsValidity(reg.RegBase.ExpiryDate))
                    {
                        if (showMsg)
                            MessageBox.Show("授权时间已过期，请重新注册！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                        return true;
                }
                else
                {
                    if (showMsg)
                        MessageBox.Show("授权信息验证失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                if (showMsg)
                    MessageBox.Show("授权信息不正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            regInfo = reg;
            return false;
        }

        static Validate validate = new Validate();

        public static bool Check()
        {
            return Check(true);
        }

        public static bool Check(bool showRegister)
        {
            RegInfo reg = null;
            return Check(showRegister, out reg);
        }

        public static bool Check(bool showRegister, out RegInfo reg)
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory + "key.lic", strReg = "";
            if (File.Exists(strPath))
                strReg = File.ReadAllText(strPath, Encoding.Default);
            if (validate.CheckReg(strReg, showRegister, out reg))
            {
                return true;
            }
            else
            {
                if (showRegister)
                {
                    using (var frm = new FrmRegister())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            reg = frm.regInfo;
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        #endregion

    }
}
