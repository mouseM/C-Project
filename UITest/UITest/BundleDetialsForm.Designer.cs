namespace UITest
{
    partial class BundleDetialsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.uninstallRadioButton = new System.Windows.Forms.RadioButton();
            this.installRadioButton = new System.Windows.Forms.RadioButton();
            this.stopRadioButton = new System.Windows.Forms.RadioButton();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "状态：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.uninstallRadioButton);
            this.groupBox.Controls.Add(this.installRadioButton);
            this.groupBox.Controls.Add(this.stopRadioButton);
            this.groupBox.Controls.Add(this.activeRadioButton);
            this.groupBox.Location = new System.Drawing.Point(40, 65);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 100);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // uninstallRadioButton
            // 
            this.uninstallRadioButton.AutoSize = true;
            this.uninstallRadioButton.Location = new System.Drawing.Point(6, 83);
            this.uninstallRadioButton.Name = "uninstallRadioButton";
            this.uninstallRadioButton.Size = new System.Drawing.Size(47, 16);
            this.uninstallRadioButton.TabIndex = 3;
            this.uninstallRadioButton.TabStop = true;
            this.uninstallRadioButton.Text = "卸载";
            this.uninstallRadioButton.UseVisualStyleBackColor = true;
            // 
            // installRadioButton
            // 
            this.installRadioButton.AutoSize = true;
            this.installRadioButton.Location = new System.Drawing.Point(6, 65);
            this.installRadioButton.Name = "installRadioButton";
            this.installRadioButton.Size = new System.Drawing.Size(47, 16);
            this.installRadioButton.TabIndex = 2;
            this.installRadioButton.TabStop = true;
            this.installRadioButton.Text = "安装";
            this.installRadioButton.UseVisualStyleBackColor = true;
            // 
            // stopRadioButton
            // 
            this.stopRadioButton.AutoSize = true;
            this.stopRadioButton.Location = new System.Drawing.Point(6, 42);
            this.stopRadioButton.Name = "stopRadioButton";
            this.stopRadioButton.Size = new System.Drawing.Size(47, 16);
            this.stopRadioButton.TabIndex = 1;
            this.stopRadioButton.TabStop = true;
            this.stopRadioButton.Text = "停止";
            this.stopRadioButton.UseVisualStyleBackColor = true;
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Location = new System.Drawing.Point(6, 20);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(47, 16);
            this.activeRadioButton.TabIndex = 0;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "激活";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(97, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // BundleDetialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BundleDetialsForm";
            this.Text = "BundleDetialsForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton activeRadioButton;
        private System.Windows.Forms.RadioButton uninstallRadioButton;
        private System.Windows.Forms.RadioButton installRadioButton;
        private System.Windows.Forms.RadioButton stopRadioButton;
        private System.Windows.Forms.Label label3;
    }
}