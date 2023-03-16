namespace lab4
{
    partial class AccountForm
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
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.getBtn = new System.Windows.Forms.Button();
            this.storeBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.getInput = new System.Windows.Forms.RichTextBox();
            this.storeInput = new System.Windows.Forms.RichTextBox();
            this.infoOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(24, 28);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(115, 41);
            this.createAccountBtn.TabIndex = 0;
            this.createAccountBtn.Text = "创建账户";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(24, 101);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(59, 41);
            this.getBtn.TabIndex = 1;
            this.getBtn.Text = "取款";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // storeBtn
            // 
            this.storeBtn.Location = new System.Drawing.Point(24, 168);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(59, 41);
            this.storeBtn.TabIndex = 2;
            this.storeBtn.Text = "存款";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(24, 250);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(115, 41);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "查询余额";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // getInput
            // 
            this.getInput.Location = new System.Drawing.Point(89, 101);
            this.getInput.Name = "getInput";
            this.getInput.Size = new System.Drawing.Size(76, 41);
            this.getInput.TabIndex = 4;
            this.getInput.Text = "";
            // 
            // storeInput
            // 
            this.storeInput.Location = new System.Drawing.Point(89, 168);
            this.storeInput.Name = "storeInput";
            this.storeInput.Size = new System.Drawing.Size(76, 41);
            this.storeInput.TabIndex = 5;
            this.storeInput.Text = "";
            // 
            // infoOutput
            // 
            this.infoOutput.Enabled = false;
            this.infoOutput.Location = new System.Drawing.Point(206, 28);
            this.infoOutput.Name = "infoOutput";
            this.infoOutput.Size = new System.Drawing.Size(240, 263);
            this.infoOutput.TabIndex = 6;
            this.infoOutput.Text = "";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 360);
            this.Controls.Add(this.infoOutput);
            this.Controls.Add(this.storeInput);
            this.Controls.Add(this.getInput);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.storeBtn);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.createAccountBtn);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RichTextBox getInput;
        private System.Windows.Forms.RichTextBox storeInput;
        private System.Windows.Forms.RichTextBox infoOutput;
    }
}