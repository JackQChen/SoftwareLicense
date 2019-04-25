using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Register
{
    public partial class FrmRegister : Form
    {
        private Validate reg = new Validate();
        internal RegInfo regInfo;
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmActive_Load(object sender, System.EventArgs e)
        {
            txtMachineCode.Text = reg.MachineCode;
            this.openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetDataObject(txtMachineCode.Text);
        }

        private void btnActive_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var strReg = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
                if (reg.CheckReg(strReg, true, out regInfo))
                {
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "key.lic", strReg, Encoding.Default);
                    MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnHelp_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("请联系系统管理员获取软件授权文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
