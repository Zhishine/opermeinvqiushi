namespace news
{
    partial class MNewsManagerForm
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
            this.newsGridView = new System.Windows.Forms.DataGridView();
            this.homePageBtn = new System.Windows.Forms.Button();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.titleSearchBtn = new System.Windows.Forms.Button();
            this.titleSearchTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pageSizeTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.titleLab = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ext1Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ext2Txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ext3Txt = new System.Windows.Forms.TextBox();
            this.btnAddNews = new System.Windows.Forms.Button();
            this.exitEditBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.newsPicUrlTxt = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.newsImgPic = new System.Windows.Forms.PictureBox();
            this.choseImgBtn = new System.Windows.Forms.Button();
            this.isWebPageChe = new System.Windows.Forms.CheckBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.newsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // newsGridView
            // 
            this.newsGridView.AllowUserToAddRows = false;
            this.newsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.description,
            this.url,
            this.ext1,
            this.ext2,
            this.ext3,
            this.detail,
            this.delete});
            this.newsGridView.Location = new System.Drawing.Point(12, 138);
            this.newsGridView.Name = "newsGridView";
            this.newsGridView.RowTemplate.Height = 23;
            this.newsGridView.Size = new System.Drawing.Size(1048, 444);
            this.newsGridView.TabIndex = 25;
            this.newsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newsGridView_CellContentClick);
            // 
            // homePageBtn
            // 
            this.homePageBtn.Location = new System.Drawing.Point(12, 588);
            this.homePageBtn.Name = "homePageBtn";
            this.homePageBtn.Size = new System.Drawing.Size(75, 23);
            this.homePageBtn.TabIndex = 26;
            this.homePageBtn.Text = "首页";
            this.homePageBtn.UseVisualStyleBackColor = true;
            this.homePageBtn.Click += new System.EventHandler(this.homePageBtn_Click);
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Location = new System.Drawing.Point(93, 589);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(75, 23);
            this.prevPageBtn.TabIndex = 27;
            this.prevPageBtn.Text = "上一页";
            this.prevPageBtn.UseVisualStyleBackColor = true;
            this.prevPageBtn.Click += new System.EventHandler(this.prevPageBtn_Click);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Location = new System.Drawing.Point(174, 590);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(75, 23);
            this.nextPageBtn.TabIndex = 28;
            this.nextPageBtn.Text = "下一页";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.Location = new System.Drawing.Point(258, 590);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(75, 23);
            this.lastPageBtn.TabIndex = 29;
            this.lastPageBtn.Text = "末页";
            this.lastPageBtn.UseVisualStyleBackColor = true;
            // 
            // titleSearchBtn
            // 
            this.titleSearchBtn.Location = new System.Drawing.Point(625, 592);
            this.titleSearchBtn.Name = "titleSearchBtn";
            this.titleSearchBtn.Size = new System.Drawing.Size(57, 23);
            this.titleSearchBtn.TabIndex = 79;
            this.titleSearchBtn.Text = "搜索";
            this.titleSearchBtn.UseVisualStyleBackColor = true;
            this.titleSearchBtn.Click += new System.EventHandler(this.titleSearchBtn_Click);
            // 
            // titleSearchTxt
            // 
            this.titleSearchTxt.Location = new System.Drawing.Point(525, 592);
            this.titleSearchTxt.Name = "titleSearchTxt";
            this.titleSearchTxt.Size = new System.Drawing.Size(94, 21);
            this.titleSearchTxt.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 77;
            this.label12.Text = "新闻标题";
            // 
            // pageSizeTxt
            // 
            this.pageSizeTxt.Location = new System.Drawing.Point(405, 594);
            this.pageSizeTxt.Name = "pageSizeTxt";
            this.pageSizeTxt.Size = new System.Drawing.Size(55, 21);
            this.pageSizeTxt.TabIndex = 73;
            this.pageSizeTxt.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 72;
            this.label8.Text = "每页数量";
            // 
            // titleLab
            // 
            this.titleLab.AutoSize = true;
            this.titleLab.Location = new System.Drawing.Point(15, 15);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(29, 12);
            this.titleLab.TabIndex = 81;
            this.titleLab.Text = "标题";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(50, 12);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(128, 21);
            this.titleTxt.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 83;
            this.label1.Text = "描述";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(50, 69);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(202, 52);
            this.descriptionTxt.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 85;
            this.label2.Text = "网址";
            // 
            // urlTxt
            // 
            this.urlTxt.Location = new System.Drawing.Point(50, 39);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(128, 21);
            this.urlTxt.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 87;
            this.label3.Text = "扩展参数1";
            // 
            // ext1Txt
            // 
            this.ext1Txt.Location = new System.Drawing.Point(258, 12);
            this.ext1Txt.Name = "ext1Txt";
            this.ext1Txt.Size = new System.Drawing.Size(128, 21);
            this.ext1Txt.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 89;
            this.label4.Text = "扩展参数2";
            // 
            // ext2Txt
            // 
            this.ext2Txt.Location = new System.Drawing.Point(471, 12);
            this.ext2Txt.Name = "ext2Txt";
            this.ext2Txt.Size = new System.Drawing.Size(128, 21);
            this.ext2Txt.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 91;
            this.label5.Text = "扩展参数3";
            // 
            // ext3Txt
            // 
            this.ext3Txt.Location = new System.Drawing.Point(680, 12);
            this.ext3Txt.Name = "ext3Txt";
            this.ext3Txt.Size = new System.Drawing.Size(128, 21);
            this.ext3Txt.TabIndex = 90;
            // 
            // btnAddNews
            // 
            this.btnAddNews.Location = new System.Drawing.Point(258, 72);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(67, 23);
            this.btnAddNews.TabIndex = 97;
            this.btnAddNews.Text = "添加";
            this.btnAddNews.UseVisualStyleBackColor = true;
            this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
            // 
            // exitEditBtn
            // 
            this.exitEditBtn.Location = new System.Drawing.Point(331, 72);
            this.exitEditBtn.Name = "exitEditBtn";
            this.exitEditBtn.Size = new System.Drawing.Size(74, 23);
            this.exitEditBtn.TabIndex = 98;
            this.exitEditBtn.Text = "取消编辑";
            this.exitEditBtn.UseVisualStyleBackColor = true;
            this.exitEditBtn.Click += new System.EventHandler(this.exitEditBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(815, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 100;
            this.label9.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(837, 12);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(108, 21);
            this.idTxt.TabIndex = 99;
            // 
            // newsPicUrlTxt
            // 
            this.newsPicUrlTxt.Location = new System.Drawing.Point(723, 40);
            this.newsPicUrlTxt.Multiline = true;
            this.newsPicUrlTxt.Name = "newsPicUrlTxt";
            this.newsPicUrlTxt.Size = new System.Drawing.Size(242, 21);
            this.newsPicUrlTxt.TabIndex = 104;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(409, 71);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(63, 23);
            this.btnUpload.TabIndex = 103;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // newsImgPic
            // 
            this.newsImgPic.Location = new System.Drawing.Point(478, 42);
            this.newsImgPic.Name = "newsImgPic";
            this.newsImgPic.Size = new System.Drawing.Size(239, 90);
            this.newsImgPic.TabIndex = 102;
            this.newsImgPic.TabStop = false;
            // 
            // choseImgBtn
            // 
            this.choseImgBtn.Location = new System.Drawing.Point(409, 42);
            this.choseImgBtn.Name = "choseImgBtn";
            this.choseImgBtn.Size = new System.Drawing.Size(63, 23);
            this.choseImgBtn.TabIndex = 101;
            this.choseImgBtn.Text = "选择图片";
            this.choseImgBtn.UseVisualStyleBackColor = true;
            this.choseImgBtn.Click += new System.EventHandler(this.choseImgBtn_Click);
            // 
            // isWebPageChe
            // 
            this.isWebPageChe.AutoSize = true;
            this.isWebPageChe.Checked = true;
            this.isWebPageChe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isWebPageChe.Location = new System.Drawing.Point(195, 42);
            this.isWebPageChe.Name = "isWebPageChe";
            this.isWebPageChe.Size = new System.Drawing.Size(72, 16);
            this.isWebPageChe.TabIndex = 147;
            this.isWebPageChe.Text = "是否网页";
            this.isWebPageChe.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // title
            // 
            this.title.FillWeight = 150F;
            this.title.HeaderText = "标题";
            this.title.Name = "title";
            // 
            // description
            // 
            this.description.HeaderText = "描述";
            this.description.Name = "description";
            // 
            // url
            // 
            this.url.FillWeight = 150F;
            this.url.HeaderText = "网址";
            this.url.Name = "url";
            // 
            // ext1
            // 
            this.ext1.HeaderText = "扩展参数1";
            this.ext1.Name = "ext1";
            // 
            // ext2
            // 
            this.ext2.HeaderText = "扩展参数2";
            this.ext2.Name = "ext2";
            // 
            // ext3
            // 
            this.ext3.HeaderText = "扩展参数3";
            this.ext3.Name = "ext3";
            // 
            // detail
            // 
            this.detail.HeaderText = "详情";
            this.detail.Name = "detail";
            this.detail.Text = "详情";
            this.detail.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.Text = "删除";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // MNewsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 623);
            this.Controls.Add(this.isWebPageChe);
            this.Controls.Add(this.newsPicUrlTxt);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.newsImgPic);
            this.Controls.Add(this.choseImgBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.exitEditBtn);
            this.Controls.Add(this.btnAddNews);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ext3Txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ext2Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ext1Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.titleLab);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.titleSearchBtn);
            this.Controls.Add(this.titleSearchTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pageSizeTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastPageBtn);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.prevPageBtn);
            this.Controls.Add(this.homePageBtn);
            this.Controls.Add(this.newsGridView);
            this.Name = "MNewsManagerForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MNewsManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImgPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView newsGridView;
        private System.Windows.Forms.Button homePageBtn;
        private System.Windows.Forms.Button prevPageBtn;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Button lastPageBtn;
        private System.Windows.Forms.Button titleSearchBtn;
        private System.Windows.Forms.TextBox titleSearchTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pageSizeTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label titleLab;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ext1Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ext2Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ext3Txt;
        private System.Windows.Forms.Button btnAddNews;
        private System.Windows.Forms.Button exitEditBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox newsPicUrlTxt;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox newsImgPic;
        private System.Windows.Forms.Button choseImgBtn;
        private System.Windows.Forms.CheckBox isWebPageChe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext3;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}