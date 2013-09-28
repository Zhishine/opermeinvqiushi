namespace news
{
    partial class MMainForm
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
            this.btnAddClientName = new System.Windows.Forms.Button();
            this.btnManageNews = new System.Windows.Forms.Button();
            this.btnManageImage = new System.Windows.Forms.Button();
            this.btnAppUIManager = new System.Windows.Forms.Button();
            this.btnManagerTaobaoke = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClientName
            // 
            this.btnAddClientName.Location = new System.Drawing.Point(60, 31);
            this.btnAddClientName.Name = "btnAddClientName";
            this.btnAddClientName.Size = new System.Drawing.Size(123, 28);
            this.btnAddClientName.TabIndex = 0;
            this.btnAddClientName.Text = "客户端频道管理";
            this.btnAddClientName.UseVisualStyleBackColor = true;
            this.btnAddClientName.Click += new System.EventHandler(this.btnAddClientName_Click);
            // 
            // btnManageNews
            // 
            this.btnManageNews.Location = new System.Drawing.Point(215, 31);
            this.btnManageNews.Name = "btnManageNews";
            this.btnManageNews.Size = new System.Drawing.Size(105, 28);
            this.btnManageNews.TabIndex = 1;
            this.btnManageNews.Text = "资讯管理";
            this.btnManageNews.UseVisualStyleBackColor = true;
            this.btnManageNews.Click += new System.EventHandler(this.btnManageNews_Click);
            // 
            // btnManageImage
            // 
            this.btnManageImage.Location = new System.Drawing.Point(349, 31);
            this.btnManageImage.Name = "btnManageImage";
            this.btnManageImage.Size = new System.Drawing.Size(138, 28);
            this.btnManageImage.TabIndex = 2;
            this.btnManageImage.Text = "图片管理";
            this.btnManageImage.UseVisualStyleBackColor = true;
            this.btnManageImage.Click += new System.EventHandler(this.btnManageImage_Click);
            // 
            // btnAppUIManager
            // 
            this.btnAppUIManager.Location = new System.Drawing.Point(60, 93);
            this.btnAppUIManager.Name = "btnAppUIManager";
            this.btnAppUIManager.Size = new System.Drawing.Size(123, 28);
            this.btnAppUIManager.TabIndex = 4;
            this.btnAppUIManager.Text = "APP端数据管理";
            this.btnAppUIManager.UseVisualStyleBackColor = true;
            this.btnAppUIManager.Click += new System.EventHandler(this.btnAppUIManager_Click);
            // 
            // btnManagerTaobaoke
            // 
            this.btnManagerTaobaoke.Location = new System.Drawing.Point(215, 93);
            this.btnManagerTaobaoke.Name = "btnManagerTaobaoke";
            this.btnManagerTaobaoke.Size = new System.Drawing.Size(123, 28);
            this.btnManagerTaobaoke.TabIndex = 5;
            this.btnManagerTaobaoke.Text = "淘宝客数据管理";
            this.btnManagerTaobaoke.UseVisualStyleBackColor = true;
            this.btnManagerTaobaoke.Click += new System.EventHandler(this.btnManagerTaobaoke_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(527, 31);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(138, 28);
            this.btnClearData.TabIndex = 6;
            this.btnClearData.Text = "清除垃圾数据";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // MMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 393);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnManagerTaobaoke);
            this.Controls.Add(this.btnAppUIManager);
            this.Controls.Add(this.btnManageImage);
            this.Controls.Add(this.btnManageNews);
            this.Controls.Add(this.btnAddClientName);
            this.Name = "MMainForm";
            this.Text = "资讯首页管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddClientName;
        private System.Windows.Forms.Button btnManageNews;
        private System.Windows.Forms.Button btnManageImage;
        private System.Windows.Forms.Button btnAppUIManager;
        private System.Windows.Forms.Button btnManagerTaobaoke;
        private System.Windows.Forms.Button btnClearData;
    }
}

