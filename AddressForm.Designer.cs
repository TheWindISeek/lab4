namespace lab4
{
    partial class AddressForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.RichTextBox();
            this.phoneInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.RichTextBox();
            this.infoOutput = new System.Windows.Forms.RichTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(129, 48);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(159, 36);
            this.nameInput.TabIndex = 1;
            this.nameInput.Text = "";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(129, 124);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(159, 36);
            this.phoneInput.TabIndex = 2;
            this.phoneInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "电话:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(129, 194);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(159, 36);
            this.emailInput.TabIndex = 5;
            this.emailInput.Text = "";
            // 
            // infoOutput
            // 
            this.infoOutput.Enabled = false;
            this.infoOutput.Location = new System.Drawing.Point(55, 261);
            this.infoOutput.Name = "infoOutput";
            this.infoOutput.Size = new System.Drawing.Size(362, 116);
            this.infoOutput.TabIndex = 6;
            this.infoOutput.Text = "";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(316, 114);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 58);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 389);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.infoOutput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "AddressForm";
            this.Text = "实训1";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox nameInput;
        private System.Windows.Forms.RichTextBox phoneInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox emailInput;
        private System.Windows.Forms.RichTextBox infoOutput;
        private System.Windows.Forms.Button addBtn;
    }
}

