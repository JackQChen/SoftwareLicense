namespace Register
{
    partial class FrmRegister
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMachineCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Location = new System.Drawing.Point(67, 51);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.ReadOnly = true;
            this.txtMachineCode.Size = new System.Drawing.Size(257, 23);
            this.txtMachineCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "机器码";
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopy.Location = new System.Drawing.Point(195, 22);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(129, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "复制到剪切板(&C)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnActive
            // 
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActive.Location = new System.Drawing.Point(12, 104);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(97, 28);
            this.btnActive.TabIndex = 3;
            this.btnActive.Text = "注 册(&A)";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Location = new System.Drawing.Point(119, 104);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(97, 28);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "帮 助(&H)";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(226, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取 消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "授权文件(*.lic)|*.lic";
            this.openFileDialog1.Title = "请选择注册文件";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMachineCode);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件注册";
            this.Load += new System.EventHandler(this.FrmActive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMachineCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

