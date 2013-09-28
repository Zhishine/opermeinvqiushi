namespace news
{
    partial class MClientManagerForm
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
            this.updatecategoryNameBtn = new System.Windows.Forms.Button();
            this.categoryNameTxt = new System.Windows.Forms.TextBox();
            this.categoryIdTxt = new System.Windows.Forms.TextBox();
            this.delCategoryBtn = new System.Windows.Forms.Button();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updatecategoryNameBtn
            // 
            this.updatecategoryNameBtn.Location = new System.Drawing.Point(207, 172);
            this.updatecategoryNameBtn.Name = "updatecategoryNameBtn";
            this.updatecategoryNameBtn.Size = new System.Drawing.Size(42, 23);
            this.updatecategoryNameBtn.TabIndex = 57;
            this.updatecategoryNameBtn.Text = "更新";
            this.updatecategoryNameBtn.UseVisualStyleBackColor = true;
            this.updatecategoryNameBtn.Click += new System.EventHandler(this.updatecategoryNameBtn_Click);
            // 
            // categoryNameTxt
            // 
            this.categoryNameTxt.Location = new System.Drawing.Point(207, 130);
            this.categoryNameTxt.Name = "categoryNameTxt";
            this.categoryNameTxt.Size = new System.Drawing.Size(52, 21);
            this.categoryNameTxt.TabIndex = 56;
            // 
            // categoryIdTxt
            // 
            this.categoryIdTxt.Location = new System.Drawing.Point(207, 88);
            this.categoryIdTxt.Name = "categoryIdTxt";
            this.categoryIdTxt.Size = new System.Drawing.Size(52, 21);
            this.categoryIdTxt.TabIndex = 55;
            // 
            // delCategoryBtn
            // 
            this.delCategoryBtn.Location = new System.Drawing.Point(159, 59);
            this.delCategoryBtn.Name = "delCategoryBtn";
            this.delCategoryBtn.Size = new System.Drawing.Size(42, 23);
            this.delCategoryBtn.TabIndex = 54;
            this.delCategoryBtn.Text = "删除";
            this.delCategoryBtn.UseVisualStyleBackColor = true;
            this.delCategoryBtn.Click += new System.EventHandler(this.delCategoryBtn_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Location = new System.Drawing.Point(159, 33);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(42, 23);
            this.addCategoryBtn.TabIndex = 53;
            this.addCategoryBtn.Text = "添加";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(92, 33);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(61, 21);
            this.categoryTxt.TabIndex = 52;
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 12;
            this.categoryListBox.Location = new System.Drawing.Point(47, 88);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(154, 292);
            this.categoryListBox.TabIndex = 51;
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.categoryListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "频道";
            // 
            // clientManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 400);
            this.Controls.Add(this.updatecategoryNameBtn);
            this.Controls.Add(this.categoryNameTxt);
            this.Controls.Add(this.categoryIdTxt);
            this.Controls.Add(this.delCategoryBtn);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.label1);
            this.Name = "clientManagerForm";
            this.Text = "客户端频道管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatecategoryNameBtn;
        private System.Windows.Forms.TextBox categoryNameTxt;
        private System.Windows.Forms.TextBox categoryIdTxt;
        private System.Windows.Forms.Button delCategoryBtn;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Label label1;
    }
}