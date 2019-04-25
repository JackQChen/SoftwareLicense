namespace Generator
{
    partial class FrmGenerate
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerate));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMachineCode = new CustomSkin.Windows.Forms.TextBox();
            this.txtOrgCode = new CustomSkin.Windows.Forms.TextBox();
            this.btnGenerateFile = new CustomSkin.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrganization = new CustomSkin.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 29);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2012, 5, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "到期时间";
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachineCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMachineCode.Location = new System.Drawing.Point(164, 177);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.Size = new System.Drawing.Size(255, 29);
            this.txtMachineCode.TabIndex = 3;
            this.txtMachineCode.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMachineCode.WatermarkText = null;
            // 
            // txtOrgCode
            // 
            this.txtOrgCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrgCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrgCode.Location = new System.Drawing.Point(164, 107);
            this.txtOrgCode.Name = "txtOrgCode";
            this.txtOrgCode.Size = new System.Drawing.Size(255, 29);
            this.txtOrgCode.TabIndex = 1;
            this.txtOrgCode.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtOrgCode.WatermarkText = null;
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateFile.FocusBorder = true;
            this.btnGenerateFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerateFile.Location = new System.Drawing.Point(167, 221);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(146, 45);
            this.btnGenerateFile.TabIndex = 4;
            this.btnGenerateFile.Text = "生成授权文件(&G)";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "key.lic";
            this.saveFileDialog1.Filter = "授权文件|*.lic";
            this.saveFileDialog1.Title = "请选择文件保存位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(70, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "机构编码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(89, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "机器码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(70, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "机构名称";
            // 
            // txtOrganization
            // 
            this.txtOrganization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrganization.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrganization.Location = new System.Drawing.Point(164, 142);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.Size = new System.Drawing.Size(255, 29);
            this.txtOrganization.TabIndex = 2;
            this.txtOrganization.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtOrganization.WatermarkText = null;
            // 
            // FrmGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrganization);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateFile);
            this.Controls.Add(this.txtOrgCode);
            this.Controls.Add(this.txtMachineCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGenerate";
            this.SkinButtonVisible = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "授权生成器";
            this.TitleStyle = true;
            this.Load += new System.EventHandler(this.FrmGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private CustomSkin.Windows.Forms.TextBox txtMachineCode;
        private CustomSkin.Windows.Forms.TextBox txtOrgCode;
        private CustomSkin.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomSkin.Windows.Forms.TextBox txtOrganization;
    }
}