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
                this.Text = "校验成功";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Register.Validate.Check(false))
                this.Text = "校验成功";
            else
                this.Text = "校验失败";
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000 * 60);
                    if (!Register.Validate.Check(false))
                        System.Windows.Forms.Application.Exit();
                }
            }) { IsBackground = true }.Start();
        }
    }
}
