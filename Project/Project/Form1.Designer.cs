namespace Project
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缓存插件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志插件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库插件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消息插件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激活ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激活ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.状态信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.激活ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.状态信息ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.激活ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pluginToolStripMenuItem
            // 
            this.pluginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.缓存插件ToolStripMenuItem,
            this.日志插件ToolStripMenuItem,
            this.数据库插件ToolStripMenuItem,
            this.消息插件ToolStripMenuItem});
            this.pluginToolStripMenuItem.Name = "pluginToolStripMenuItem";
            this.pluginToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.pluginToolStripMenuItem.Text = "插件列表";
            // 
            // 缓存插件ToolStripMenuItem
            // 
            this.缓存插件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态ToolStripMenuItem,
            this.激活ToolStripMenuItem,
            this.停止ToolStripMenuItem});
            this.缓存插件ToolStripMenuItem.Name = "缓存插件ToolStripMenuItem";
            this.缓存插件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.缓存插件ToolStripMenuItem.Text = "缓存插件";
            // 
            // 日志插件ToolStripMenuItem
            // 
            this.日志插件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态信息ToolStripMenuItem,
            this.激活ToolStripMenuItem1,
            this.停止ToolStripMenuItem1});
            this.日志插件ToolStripMenuItem.Name = "日志插件ToolStripMenuItem";
            this.日志插件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.日志插件ToolStripMenuItem.Text = "日志插件";
            // 
            // 数据库插件ToolStripMenuItem
            // 
            this.数据库插件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态信息ToolStripMenuItem1,
            this.激活ToolStripMenuItem2,
            this.停止ToolStripMenuItem2});
            this.数据库插件ToolStripMenuItem.Name = "数据库插件ToolStripMenuItem";
            this.数据库插件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.数据库插件ToolStripMenuItem.Text = "数据库插件";
            // 
            // 消息插件ToolStripMenuItem
            // 
            this.消息插件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态信息ToolStripMenuItem2,
            this.激活ToolStripMenuItem3,
            this.停止ToolStripMenuItem3});
            this.消息插件ToolStripMenuItem.Name = "消息插件ToolStripMenuItem";
            this.消息插件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.消息插件ToolStripMenuItem.Text = "消息插件";
            // 
            // 状态ToolStripMenuItem
            // 
            this.状态ToolStripMenuItem.Name = "状态ToolStripMenuItem";
            this.状态ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.状态ToolStripMenuItem.Text = "状态信息";
            // 
            // 激活ToolStripMenuItem
            // 
            this.激活ToolStripMenuItem.Name = "激活ToolStripMenuItem";
            this.激活ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.激活ToolStripMenuItem.Text = "激活";
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.停止ToolStripMenuItem.Text = "停止";
            // 
            // 状态信息ToolStripMenuItem
            // 
            this.状态信息ToolStripMenuItem.Name = "状态信息ToolStripMenuItem";
            this.状态信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.状态信息ToolStripMenuItem.Text = "状态信息";
            // 
            // 激活ToolStripMenuItem1
            // 
            this.激活ToolStripMenuItem1.Name = "激活ToolStripMenuItem1";
            this.激活ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.激活ToolStripMenuItem1.Text = "激活";
            // 
            // 停止ToolStripMenuItem1
            // 
            this.停止ToolStripMenuItem1.Name = "停止ToolStripMenuItem1";
            this.停止ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.停止ToolStripMenuItem1.Text = "停止";
            // 
            // 状态信息ToolStripMenuItem1
            // 
            this.状态信息ToolStripMenuItem1.Name = "状态信息ToolStripMenuItem1";
            this.状态信息ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.状态信息ToolStripMenuItem1.Text = "状态信息";
            // 
            // 激活ToolStripMenuItem2
            // 
            this.激活ToolStripMenuItem2.Name = "激活ToolStripMenuItem2";
            this.激活ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.激活ToolStripMenuItem2.Text = "激活";
            // 
            // 停止ToolStripMenuItem2
            // 
            this.停止ToolStripMenuItem2.Name = "停止ToolStripMenuItem2";
            this.停止ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.停止ToolStripMenuItem2.Text = "停止";
            // 
            // 状态信息ToolStripMenuItem2
            // 
            this.状态信息ToolStripMenuItem2.Name = "状态信息ToolStripMenuItem2";
            this.状态信息ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.状态信息ToolStripMenuItem2.Text = "状态信息";
            // 
            // 激活ToolStripMenuItem3
            // 
            this.激活ToolStripMenuItem3.Name = "激活ToolStripMenuItem3";
            this.激活ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.激活ToolStripMenuItem3.Text = "激活";
            // 
            // 停止ToolStripMenuItem3
            // 
            this.停止ToolStripMenuItem3.Name = "停止ToolStripMenuItem3";
            this.停止ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.停止ToolStripMenuItem3.Text = "停止";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缓存插件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 激活ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日志插件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 激活ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 数据库插件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 激活ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 消息插件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态信息ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 激活ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem3;
    }
}

