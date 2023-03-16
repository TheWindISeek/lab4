namespace lab4
{
    partial class TimeForm
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
            this.hourInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minuteInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondInput = new System.Windows.Forms.RichTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hourInput
            // 
            this.hourInput.Enabled = false;
            this.hourInput.Location = new System.Drawing.Point(12, 85);
            this.hourInput.Name = "hourInput";
            this.hourInput.Size = new System.Drawing.Size(52, 42);
            this.hourInput.TabIndex = 0;
            this.hourInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // minuteInput
            // 
            this.minuteInput.Enabled = false;
            this.minuteInput.Location = new System.Drawing.Point(143, 85);
            this.minuteInput.Name = "minuteInput";
            this.minuteInput.Size = new System.Drawing.Size(70, 42);
            this.minuteInput.TabIndex = 2;
            this.minuteInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // secondInput
            // 
            this.secondInput.Enabled = false;
            this.secondInput.Location = new System.Drawing.Point(292, 85);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(70, 42);
            this.secondInput.TabIndex = 4;
            this.secondInput.Text = "";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(391, 85);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(71, 46);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // TimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 183);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minuteInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourInput);
            this.Name = "TimeForm";
            this.Text = "TimeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox hourInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox minuteInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox secondInput;
        private System.Windows.Forms.Button addBtn;
    }
}