namespace Bombwars.net
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.count = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.exampleAircraft = new System.Windows.Forms.PictureBox();
            this.exampleBomb = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleBomb)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.count,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "YOU CRASHED ";
            // 
            // count
            // 
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(15, 17);
            this.count.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel3.Text = "ENEMY AIRCRAFTS !";
            // 
            // exampleAircraft
            // 
            this.exampleAircraft.Image = ((System.Drawing.Image)(resources.GetObject("exampleAircraft.Image")));
            this.exampleAircraft.Location = new System.Drawing.Point(0, 0);
            this.exampleAircraft.Name = "exampleAircraft";
            this.exampleAircraft.Size = new System.Drawing.Size(157, 85);
            this.exampleAircraft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exampleAircraft.TabIndex = 1;
            this.exampleAircraft.TabStop = false;
            // 
            // exampleBomb
            // 
            this.exampleBomb.Image = ((System.Drawing.Image)(resources.GetObject("exampleBomb.Image")));
            this.exampleBomb.Location = new System.Drawing.Point(0, 0);
            this.exampleBomb.Name = "exampleBomb";
            this.exampleBomb.Size = new System.Drawing.Size(83, 85);
            this.exampleBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exampleBomb.TabIndex = 2;
            this.exampleBomb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 487);
            this.Controls.Add(this.exampleBomb);
            this.Controls.Add(this.exampleAircraft);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BombWars Origin";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleBomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel count;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.PictureBox exampleAircraft;
        private System.Windows.Forms.PictureBox exampleBomb;
    }
}

