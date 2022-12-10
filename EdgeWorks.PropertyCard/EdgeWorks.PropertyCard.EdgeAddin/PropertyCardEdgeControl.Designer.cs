namespace EdgeWorks.PropertyCard.EdgeAddin
{
    partial class PropertyCardEdgeControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CardElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // CardElementHost
            // 
            this.CardElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardElementHost.Location = new System.Drawing.Point(0, 0);
            this.CardElementHost.Name = "CardElementHost";
            this.CardElementHost.Size = new System.Drawing.Size(150, 150);
            this.CardElementHost.TabIndex = 0;
            this.CardElementHost.Text = "elementHost1";
            this.CardElementHost.Child = null;
            // 
            // PropertyCardEdgeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardElementHost);
            this.Name = "PropertyCardEdgeControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost CardElementHost;
    }
}
