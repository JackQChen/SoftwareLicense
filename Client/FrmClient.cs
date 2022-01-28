using System;
using System.Windows.Forms;
using Register;
using System.Threading;

namespace Client
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Register.Validate.Check())
                MessageBox.Show("验证成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Register.Validate.Check(false))
                MessageBox.Show("验证成功");
            else
                MessageBox.Show("验证失败");
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            //后台保持校验
            //new Thread(() =>
            //{
            //    while (true)
            //    {
            //        Thread.Sleep(1000 * 60);
            //        if (!Register.Validate.Check(false))
            //            System.Windows.Forms.Application.Exit();
            //    }
            //}) { IsBackground = true }.Start();
        }
    }
}
