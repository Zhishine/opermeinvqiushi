namespace news
{
    partial class MAppUIManagerForm
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
            this.exitEditBtn = new System.Windows.Forms.Button();
            this.btnAddAppData = new System.Windows.Forms.Button();
            this.platformBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftUpIconUrlTxt = new System.Windows.Forms.TextBox();
            this.rightUpIconUrlTxt = new System.Windows.Forms.TextBox();
            this.rightImgUrlTxt = new System.Windows.Forms.Label();
            this.btnShowImg1 = new System.Windows.Forms.Button();
            this.btnShowImg2 = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Label();
            this.leftUpRedirectUrlTxt = new System.Windows.Forms.TextBox();
            this.rightUpRedirectUrlTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.appGridView = new System.Windows.Forms.DataGridView();
            this.rightDownRedirectUrlTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leftDownRedirectUrlTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rightDownIconUrlTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.leftDownIconUrlTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bannerIsShowChe = new System.Windows.Forms.CheckBox();
            this.taobaokeIsShowChe = new System.Windows.Forms.CheckBox();
            this.adIsShowChe = new System.Windows.Forms.CheckBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftUpIconUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightUpIconUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftDownIconUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightDownIconUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftUpRedirectUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightUpRedirectUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftDownRedirectUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightDownRedirectUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bannerIsShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taobaokeIsShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adIsShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.appGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitEditBtn
            // 
            this.exitEditBtn.Location = new System.Drawing.Point(966, 110);
            this.exitEditBtn.Name = "exitEditBtn";
            this.exitEditBtn.Size = new System.Drawing.Size(64, 23);
            this.exitEditBtn.TabIndex = 135;
            this.exitEditBtn.Text = "取消编辑";
            this.exitEditBtn.UseVisualStyleBackColor = true;
            this.exitEditBtn.Click += new System.EventHandler(this.exitEditBtn_Click);
            // 
            // btnAddAppData
            // 
            this.btnAddAppData.Location = new System.Drawing.Point(903, 110);
            this.btnAddAppData.Name = "btnAddAppData";
            this.btnAddAppData.Size = new System.Drawing.Size(48, 23);
            this.btnAddAppData.TabIndex = 134;
            this.btnAddAppData.Text = "添加";
            this.btnAddAppData.UseVisualStyleBackColor = true;
            this.btnAddAppData.Click += new System.EventHandler(this.btnAddAppData_Click);
            // 
            // platformBox
            // 
            this.platformBox.FormattingEnabled = true;
            this.platformBox.Items.AddRange(new object[] {
            "Android",
            "IPhone"});
            this.platformBox.Location = new System.Drawing.Point(1043, 3);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(94, 20);
            this.platformBox.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1008, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 137;
            this.label1.Text = "平台";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 138;
            this.label2.Text = "左边ICON URL";
            // 
            // leftUpIconUrlTxt
            // 
            this.leftUpIconUrlTxt.Location = new System.Drawing.Point(112, 5);
            this.leftUpIconUrlTxt.Name = "leftUpIconUrlTxt";
            this.leftUpIconUrlTxt.Size = new System.Drawing.Size(242, 21);
            this.leftUpIconUrlTxt.TabIndex = 139;
            // 
            // rightUpIconUrlTxt
            // 
            this.rightUpIconUrlTxt.Location = new System.Drawing.Point(115, 43);
            this.rightUpIconUrlTxt.Name = "rightUpIconUrlTxt";
            this.rightUpIconUrlTxt.Size = new System.Drawing.Size(239, 21);
            this.rightUpIconUrlTxt.TabIndex = 141;
            // 
            // rightImgUrlTxt
            // 
            this.rightImgUrlTxt.AutoSize = true;
            this.rightImgUrlTxt.Location = new System.Drawing.Point(32, 46);
            this.rightImgUrlTxt.Name = "rightImgUrlTxt";
            this.rightImgUrlTxt.Size = new System.Drawing.Size(77, 12);
            this.rightImgUrlTxt.TabIndex = 140;
            this.rightImgUrlTxt.Text = "右边ICON URL";
            // 
            // btnShowImg1
            // 
            this.btnShowImg1.Location = new System.Drawing.Point(360, 3);
            this.btnShowImg1.Name = "btnShowImg1";
            this.btnShowImg1.Size = new System.Drawing.Size(41, 23);
            this.btnShowImg1.TabIndex = 142;
            this.btnShowImg1.Text = "查看";
            this.btnShowImg1.UseVisualStyleBackColor = true;
            // 
            // btnShowImg2
            // 
            this.btnShowImg2.Location = new System.Drawing.Point(360, 43);
            this.btnShowImg2.Name = "btnShowImg2";
            this.btnShowImg2.Size = new System.Drawing.Size(41, 23);
            this.btnShowImg2.TabIndex = 143;
            this.btnShowImg2.Text = "查看";
            this.btnShowImg2.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Location = new System.Drawing.Point(416, 9);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(53, 12);
            this.left.TabIndex = 144;
            this.left.Text = "跳转网址";
            // 
            // leftUpRedirectUrlTxt
            // 
            this.leftUpRedirectUrlTxt.Location = new System.Drawing.Point(475, 6);
            this.leftUpRedirectUrlTxt.Name = "leftUpRedirectUrlTxt";
            this.leftUpRedirectUrlTxt.Size = new System.Drawing.Size(397, 21);
            this.leftUpRedirectUrlTxt.TabIndex = 145;
            // 
            // rightUpRedirectUrlTxt
            // 
            this.rightUpRedirectUrlTxt.Location = new System.Drawing.Point(475, 43);
            this.rightUpRedirectUrlTxt.Name = "rightUpRedirectUrlTxt";
            this.rightUpRedirectUrlTxt.Size = new System.Drawing.Size(397, 21);
            this.rightUpRedirectUrlTxt.TabIndex = 147;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 146;
            this.label3.Text = "跳转网址";
            // 
            // appGridView
            // 
            this.appGridView.AllowUserToAddRows = false;
            this.appGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.categoryName,
            this.platform,
            this.leftUpIconUrl,
            this.rightUpIconUrl,
            this.leftDownIconUrl,
            this.rightDownIconUrl,
            this.leftUpRedirectUrl,
            this.rightUpRedirectUrl,
            this.leftDownRedirectUrl,
            this.rightDownRedirectUrl,
            this.bannerIsShow,
            this.taobaokeIsShow,
            this.adIsShow,
            this.detail,
            this.update,
            this.delete});
            this.appGridView.Location = new System.Drawing.Point(12, 153);
            this.appGridView.Name = "appGridView";
            this.appGridView.RowTemplate.Height = 23;
            this.appGridView.Size = new System.Drawing.Size(1284, 400);
            this.appGridView.TabIndex = 148;
            this.appGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appGridView_CellContentClick);
            // 
            // rightDownRedirectUrlTxt
            // 
            this.rightDownRedirectUrlTxt.Location = new System.Drawing.Point(475, 112);
            this.rightDownRedirectUrlTxt.Name = "rightDownRedirectUrlTxt";
            this.rightDownRedirectUrlTxt.Size = new System.Drawing.Size(397, 21);
            this.rightDownRedirectUrlTxt.TabIndex = 158;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 157;
            this.label4.Text = "跳转网址";
            // 
            // leftDownRedirectUrlTxt
            // 
            this.leftDownRedirectUrlTxt.Location = new System.Drawing.Point(475, 75);
            this.leftDownRedirectUrlTxt.Name = "leftDownRedirectUrlTxt";
            this.leftDownRedirectUrlTxt.Size = new System.Drawing.Size(397, 21);
            this.leftDownRedirectUrlTxt.TabIndex = 156;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 155;
            this.label5.Text = "跳转网址";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 154;
            this.button1.Text = "查看";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 153;
            this.button2.Text = "查看";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rightDownIconUrlTxt
            // 
            this.rightDownIconUrlTxt.Location = new System.Drawing.Point(115, 112);
            this.rightDownIconUrlTxt.Name = "rightDownIconUrlTxt";
            this.rightDownIconUrlTxt.Size = new System.Drawing.Size(239, 21);
            this.rightDownIconUrlTxt.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 151;
            this.label6.Text = "右下边ICON URL";
            // 
            // leftDownIconUrlTxt
            // 
            this.leftDownIconUrlTxt.Location = new System.Drawing.Point(112, 74);
            this.leftDownIconUrlTxt.Name = "leftDownIconUrlTxt";
            this.leftDownIconUrlTxt.Size = new System.Drawing.Size(242, 21);
            this.leftDownIconUrlTxt.TabIndex = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 149;
            this.label8.Text = "左下边ICON URL";
            // 
            // bannerIsShowChe
            // 
            this.bannerIsShowChe.AutoSize = true;
            this.bannerIsShowChe.Checked = true;
            this.bannerIsShowChe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bannerIsShowChe.Location = new System.Drawing.Point(898, 8);
            this.bannerIsShowChe.Name = "bannerIsShowChe";
            this.bannerIsShowChe.Size = new System.Drawing.Size(108, 16);
            this.bannerIsShowChe.TabIndex = 159;
            this.bannerIsShowChe.Text = "banner是否显示";
            this.bannerIsShowChe.UseVisualStyleBackColor = true;
            // 
            // taobaokeIsShowChe
            // 
            this.taobaokeIsShowChe.AutoSize = true;
            this.taobaokeIsShowChe.Checked = true;
            this.taobaokeIsShowChe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.taobaokeIsShowChe.Location = new System.Drawing.Point(898, 45);
            this.taobaokeIsShowChe.Name = "taobaokeIsShowChe";
            this.taobaokeIsShowChe.Size = new System.Drawing.Size(96, 16);
            this.taobaokeIsShowChe.TabIndex = 160;
            this.taobaokeIsShowChe.Text = "商品是否显示";
            this.taobaokeIsShowChe.UseVisualStyleBackColor = true;
            // 
            // adIsShowChe
            // 
            this.adIsShowChe.AutoSize = true;
            this.adIsShowChe.Checked = true;
            this.adIsShowChe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.adIsShowChe.Location = new System.Drawing.Point(898, 80);
            this.adIsShowChe.Name = "adIsShowChe";
            this.adIsShowChe.Size = new System.Drawing.Size(96, 16);
            this.adIsShowChe.TabIndex = 161;
            this.adIsShowChe.Text = "广告是否显示";
            this.adIsShowChe.UseVisualStyleBackColor = true;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(1055, 78);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(82, 21);
            this.idTxt.TabIndex = 163;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1025, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 162;
            this.label7.Text = "id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1008, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 165;
            this.label9.Text = "频道";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Android",
            "IPhone"});
            this.categoryBox.Location = new System.Drawing.Point(1043, 38);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(94, 20);
            this.categoryBox.TabIndex = 164;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // categoryName
            // 
            this.categoryName.FillWeight = 150F;
            this.categoryName.HeaderText = "频道";
            this.categoryName.Name = "categoryName";
            this.categoryName.Width = 50;
            // 
            // platform
            // 
            this.platform.HeaderText = "平台";
            this.platform.Name = "platform";
            this.platform.Width = 50;
            // 
            // leftUpIconUrl
            // 
            this.leftUpIconUrl.HeaderText = "左上边ICON URL";
            this.leftUpIconUrl.Name = "leftUpIconUrl";
            // 
            // rightUpIconUrl
            // 
            this.rightUpIconUrl.FillWeight = 150F;
            this.rightUpIconUrl.HeaderText = "右上边ICON URL";
            this.rightUpIconUrl.Name = "rightUpIconUrl";
            this.rightUpIconUrl.Width = 120;
            // 
            // leftDownIconUrl
            // 
            this.leftDownIconUrl.HeaderText = "左下边ICON URL";
            this.leftDownIconUrl.Name = "leftDownIconUrl";
            // 
            // rightDownIconUrl
            // 
            this.rightDownIconUrl.HeaderText = "右下边ICON URL";
            this.rightDownIconUrl.Name = "rightDownIconUrl";
            // 
            // leftUpRedirectUrl
            // 
            this.leftUpRedirectUrl.HeaderText = "左上边RedirectUrl";
            this.leftUpRedirectUrl.Name = "leftUpRedirectUrl";
            // 
            // rightUpRedirectUrl
            // 
            this.rightUpRedirectUrl.HeaderText = "右上边RedirectUrl";
            this.rightUpRedirectUrl.Name = "rightUpRedirectUrl";
            // 
            // leftDownRedirectUrl
            // 
            this.leftDownRedirectUrl.HeaderText = "左下边RedirectUrl";
            this.leftDownRedirectUrl.Name = "leftDownRedirectUrl";
            // 
            // rightDownRedirectUrl
            // 
            this.rightDownRedirectUrl.HeaderText = "右下边RedirectUrl";
            this.rightDownRedirectUrl.Name = "rightDownRedirectUrl";
            // 
            // bannerIsShow
            // 
            this.bannerIsShow.HeaderText = "Banner显示";
            this.bannerIsShow.Name = "bannerIsShow";
            this.bannerIsShow.Width = 70;
            // 
            // taobaokeIsShow
            // 
            this.taobaokeIsShow.HeaderText = "商品显示";
            this.taobaokeIsShow.Name = "taobaokeIsShow";
            this.taobaokeIsShow.Width = 70;
            // 
            // adIsShow
            // 
            this.adIsShow.HeaderText = "广告显示";
            this.adIsShow.Name = "adIsShow";
            this.adIsShow.Width = 70;
            // 
            // detail
            // 
            this.detail.HeaderText = "详情";
            this.detail.Name = "detail";
            this.detail.Text = "详情";
            this.detail.UseColumnTextForButtonValue = true;
            this.detail.Width = 30;
            // 
            // update
            // 
            this.update.HeaderText = "更新";
            this.update.Name = "update";
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.Text = "更新";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 30;
            // 
            // delete
            // 
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.Text = "删除";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 30;
            // 
            // MAppUIManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 641);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adIsShowChe);
            this.Controls.Add(this.taobaokeIsShowChe);
            this.Controls.Add(this.bannerIsShowChe);
            this.Controls.Add(this.rightDownRedirectUrlTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftDownRedirectUrlTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rightDownIconUrlTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.leftDownIconUrlTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.appGridView);
            this.Controls.Add(this.rightUpRedirectUrlTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leftUpRedirectUrlTxt);
            this.Controls.Add(this.left);
            this.Controls.Add(this.btnShowImg2);
            this.Controls.Add(this.btnShowImg1);
            this.Controls.Add(this.rightUpIconUrlTxt);
            this.Controls.Add(this.rightImgUrlTxt);
            this.Controls.Add(this.leftUpIconUrlTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platformBox);
            this.Controls.Add(this.exitEditBtn);
            this.Controls.Add(this.btnAddAppData);
            this.Name = "MAppUIManagerForm";
            this.Text = "APP数据端管理";
            this.Load += new System.EventHandler(this.MAppUIManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitEditBtn;
        private System.Windows.Forms.Button btnAddAppData;
        private System.Windows.Forms.ComboBox platformBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox leftUpIconUrlTxt;
        private System.Windows.Forms.TextBox rightUpIconUrlTxt;
        private System.Windows.Forms.Label rightImgUrlTxt;
        private System.Windows.Forms.Button btnShowImg1;
        private System.Windows.Forms.Button btnShowImg2;
        private System.Windows.Forms.Label left;
        private System.Windows.Forms.TextBox leftUpRedirectUrlTxt;
        private System.Windows.Forms.TextBox rightUpRedirectUrlTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView appGridView;
        private System.Windows.Forms.TextBox rightDownRedirectUrlTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leftDownRedirectUrlTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rightDownIconUrlTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox leftDownIconUrlTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox bannerIsShowChe;
        private System.Windows.Forms.CheckBox taobaokeIsShowChe;
        private System.Windows.Forms.CheckBox adIsShowChe;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftUpIconUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightUpIconUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftDownIconUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightDownIconUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftUpRedirectUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightUpRedirectUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftDownRedirectUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightDownRedirectUrl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bannerIsShow;
        private System.Windows.Forms.DataGridViewCheckBoxColumn taobaokeIsShow;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adIsShow;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}