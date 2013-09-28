namespace news
{
    partial class MImageManagerForm
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
            this.imagePicUrlTxt = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.imgPic = new System.Windows.Forms.PictureBox();
            this.choseImgBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.exitEditBtn = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ext3Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ext2Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ext1Txt = new System.Windows.Forms.TextBox();
            this.pageSizeTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.homePageBtn = new System.Windows.Forms.Button();
            this.imageGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.titleSearchTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.titleSearchBtn = new System.Windows.Forms.Button();
            this.isNativePageChe = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.redirectUrlTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isNativePage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.redirectUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePicUrlTxt
            // 
            this.imagePicUrlTxt.Location = new System.Drawing.Point(365, 128);
            this.imagePicUrlTxt.Name = "imagePicUrlTxt";
            this.imagePicUrlTxt.Size = new System.Drawing.Size(526, 21);
            this.imagePicUrlTxt.TabIndex = 139;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(16, 64);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(63, 23);
            this.btnUpload.TabIndex = 138;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // imgPic
            // 
            this.imgPic.Location = new System.Drawing.Point(85, 35);
            this.imgPic.Name = "imgPic";
            this.imgPic.Size = new System.Drawing.Size(257, 114);
            this.imgPic.TabIndex = 137;
            this.imgPic.TabStop = false;
            // 
            // choseImgBtn
            // 
            this.choseImgBtn.Location = new System.Drawing.Point(16, 35);
            this.choseImgBtn.Name = "choseImgBtn";
            this.choseImgBtn.Size = new System.Drawing.Size(63, 23);
            this.choseImgBtn.TabIndex = 136;
            this.choseImgBtn.Text = "选择图片";
            this.choseImgBtn.UseVisualStyleBackColor = true;
            this.choseImgBtn.Click += new System.EventHandler(this.choseImgBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 135;
            this.label9.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(39, 5);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(81, 21);
            this.idTxt.TabIndex = 134;
            // 
            // exitEditBtn
            // 
            this.exitEditBtn.Location = new System.Drawing.Point(985, 126);
            this.exitEditBtn.Name = "exitEditBtn";
            this.exitEditBtn.Size = new System.Drawing.Size(74, 23);
            this.exitEditBtn.TabIndex = 133;
            this.exitEditBtn.Text = "取消编辑";
            this.exitEditBtn.UseVisualStyleBackColor = true;
            this.exitEditBtn.Click += new System.EventHandler(this.exitEditBtn_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(902, 126);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(67, 23);
            this.btnAddImage.TabIndex = 132;
            this.btnAddImage.Text = "添加";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 126;
            this.label5.Text = "扩展参数3";
            // 
            // ext3Txt
            // 
            this.ext3Txt.Location = new System.Drawing.Point(539, 6);
            this.ext3Txt.Name = "ext3Txt";
            this.ext3Txt.Size = new System.Drawing.Size(115, 21);
            this.ext3Txt.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 124;
            this.label4.Text = "扩展参数2";
            // 
            // ext2Txt
            // 
            this.ext2Txt.Location = new System.Drawing.Point(365, 5);
            this.ext2Txt.Name = "ext2Txt";
            this.ext2Txt.Size = new System.Drawing.Size(103, 21);
            this.ext2Txt.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 122;
            this.label3.Text = "扩展参数1";
            // 
            // ext1Txt
            // 
            this.ext1Txt.Location = new System.Drawing.Point(191, 4);
            this.ext1Txt.Name = "ext1Txt";
            this.ext1Txt.Size = new System.Drawing.Size(111, 21);
            this.ext1Txt.TabIndex = 121;
            // 
            // pageSizeTxt
            // 
            this.pageSizeTxt.Location = new System.Drawing.Point(422, 587);
            this.pageSizeTxt.Name = "pageSizeTxt";
            this.pageSizeTxt.Size = new System.Drawing.Size(55, 21);
            this.pageSizeTxt.TabIndex = 111;
            this.pageSizeTxt.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 110;
            this.label8.Text = "每页数量";
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.Location = new System.Drawing.Point(272, 583);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(75, 23);
            this.lastPageBtn.TabIndex = 109;
            this.lastPageBtn.Text = "末页";
            this.lastPageBtn.UseVisualStyleBackColor = true;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Location = new System.Drawing.Point(191, 583);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(75, 23);
            this.nextPageBtn.TabIndex = 108;
            this.nextPageBtn.Text = "下一页";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Location = new System.Drawing.Point(110, 582);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(75, 23);
            this.prevPageBtn.TabIndex = 107;
            this.prevPageBtn.Text = "上一页";
            this.prevPageBtn.UseVisualStyleBackColor = true;
            this.prevPageBtn.Click += new System.EventHandler(this.prevPageBtn_Click);
            // 
            // homePageBtn
            // 
            this.homePageBtn.Location = new System.Drawing.Point(29, 581);
            this.homePageBtn.Name = "homePageBtn";
            this.homePageBtn.Size = new System.Drawing.Size(75, 23);
            this.homePageBtn.TabIndex = 106;
            this.homePageBtn.Text = "首页";
            this.homePageBtn.UseVisualStyleBackColor = true;
            this.homePageBtn.Click += new System.EventHandler(this.homePageBtn_Click);
            // 
            // imageGridView
            // 
            this.imageGridView.AllowUserToAddRows = false;
            this.imageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.description,
            this.url,
            this.isNativePage,
            this.redirectUrl,
            this.width,
            this.height,
            this.ext1,
            this.ext2,
            this.ext3,
            this.detail,
            this.delete});
            this.imageGridView.Location = new System.Drawing.Point(19, 163);
            this.imageGridView.Name = "imageGridView";
            this.imageGridView.RowTemplate.Height = 23;
            this.imageGridView.Size = new System.Drawing.Size(1226, 412);
            this.imageGridView.TabIndex = 105;
            this.imageGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newsGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 141;
            this.label1.Text = "描述";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(696, 38);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(195, 77);
            this.descriptionTxt.TabIndex = 140;
            // 
            // titleSearchTxt
            // 
            this.titleSearchTxt.Location = new System.Drawing.Point(509, 587);
            this.titleSearchTxt.Name = "titleSearchTxt";
            this.titleSearchTxt.Size = new System.Drawing.Size(118, 21);
            this.titleSearchTxt.TabIndex = 143;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 142;
            this.label12.Text = "描述";
            // 
            // titleSearchBtn
            // 
            this.titleSearchBtn.Location = new System.Drawing.Point(633, 585);
            this.titleSearchBtn.Name = "titleSearchBtn";
            this.titleSearchBtn.Size = new System.Drawing.Size(57, 23);
            this.titleSearchBtn.TabIndex = 144;
            this.titleSearchBtn.Text = "搜索";
            this.titleSearchBtn.UseVisualStyleBackColor = true;
            this.titleSearchBtn.Click += new System.EventHandler(this.titleSearchBtn_Click);
            // 
            // isNativePageChe
            // 
            this.isNativePageChe.AutoSize = true;
            this.isNativePageChe.Checked = true;
            this.isNativePageChe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isNativePageChe.Location = new System.Drawing.Point(663, 10);
            this.isNativePageChe.Name = "isNativePageChe";
            this.isNativePageChe.Size = new System.Drawing.Size(96, 16);
            this.isNativePageChe.TabIndex = 146;
            this.isNativePageChe.Text = "是否本地页面";
            this.isNativePageChe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 147;
            this.label2.Text = "跳转网址";
            // 
            // redirectUrlTxt
            // 
            this.redirectUrlTxt.Location = new System.Drawing.Point(422, 35);
            this.redirectUrlTxt.Multiline = true;
            this.redirectUrlTxt.Name = "redirectUrlTxt";
            this.redirectUrlTxt.Size = new System.Drawing.Size(232, 79);
            this.redirectUrlTxt.TabIndex = 148;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(833, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 152;
            this.label10.Text = "高";
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(856, 6);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(35, 21);
            this.heightTxt.TabIndex = 151;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(776, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 150;
            this.label11.Text = "宽";
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(799, 6);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(28, 21);
            this.widthTxt.TabIndex = 149;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // description
            // 
            this.description.HeaderText = "描述";
            this.description.Name = "description";
            this.description.Width = 150;
            // 
            // url
            // 
            this.url.FillWeight = 150F;
            this.url.HeaderText = "网址";
            this.url.Name = "url";
            // 
            // isNativePage
            // 
            this.isNativePage.HeaderText = "是否本地页面";
            this.isNativePage.Name = "isNativePage";
            // 
            // redirectUrl
            // 
            this.redirectUrl.HeaderText = "跳转地址";
            this.redirectUrl.Name = "redirectUrl";
            // 
            // width
            // 
            this.width.HeaderText = "宽度";
            this.width.Name = "width";
            // 
            // height
            // 
            this.height.HeaderText = "高度";
            this.height.Name = "height";
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
            // MImageManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 616);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.redirectUrlTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isNativePageChe);
            this.Controls.Add(this.titleSearchBtn);
            this.Controls.Add(this.titleSearchTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.imagePicUrlTxt);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.imgPic);
            this.Controls.Add(this.choseImgBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.exitEditBtn);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ext3Txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ext2Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ext1Txt);
            this.Controls.Add(this.pageSizeTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastPageBtn);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.prevPageBtn);
            this.Controls.Add(this.homePageBtn);
            this.Controls.Add(this.imageGridView);
            this.Name = "MImageManagerForm";
            this.Text = "图片管理";
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imagePicUrlTxt;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox imgPic;
        private System.Windows.Forms.Button choseImgBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button exitEditBtn;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ext3Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ext2Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ext1Txt;
        private System.Windows.Forms.TextBox pageSizeTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button lastPageBtn;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Button prevPageBtn;
        private System.Windows.Forms.Button homePageBtn;
        private System.Windows.Forms.DataGridView imageGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox titleSearchTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button titleSearchBtn;
        private System.Windows.Forms.CheckBox isNativePageChe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox redirectUrlTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNativePage;
        private System.Windows.Forms.DataGridViewTextBoxColumn redirectUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext3;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}