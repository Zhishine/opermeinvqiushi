using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace news
{
    public partial class MAppUIManagerForm : Form
    {
        public MAppUIManagerForm()
        {
            InitializeComponent();
            requestAppList();
            fillCategoryBox();
            this.platformBox.SelectedIndex = 0;
            this.categoryBox.SelectedIndex = 0;
        }
     
        List<MAppData> appList = null;
        MAppData m_selectApp;
        bool m_isEdit = false;

        List<MCategory> categoryList;
        void fillCategoryBox()
        {
            System.GC.Collect();

            Thread.Sleep(100);
            this.categoryBox.Items.Clear();
            HttpWebRequest myRequest =
           (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "SelectCategory?tick=" + new Random().Next(1000));
            myRequest.Method = "GET";
            myRequest.KeepAlive = false;

            myRequest.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = myRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(stream);
            char[] readByte = new char[response.ContentLength];
            readStream.ReadBlock(readByte, 0, (int)response.ContentLength);
            String result = new String(readByte);
            response.Close();
            stream.Close();
            myRequest.Abort();
            categoryList = JsonConvert.DeserializeObject<List<MCategory>>(result);
            if (categoryList == null)
                return;

            if (categoryList != null && categoryList.Count > 0)
            {
                this.categoryBox.Items.Clear();
                foreach (MCategory category in categoryList)
                    this.categoryBox.Items.Add(Util.decode(category.mName));
            }

        }
        private void MAppUIManagerForm_Load(object sender, EventArgs e)
        {

        }

        void requestAppList()
        {
            HttpWebRequest myRequest =
                (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "GetAppData?type=0");
            myRequest.Method = "GET";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = myRequest.GetResponse();
            int contentLength = Convert.ToInt32(response.Headers["content-length"]);
            Stream stream = response.GetResponseStream();
            //stream.Position = 0;
            StreamReader readStream = new StreamReader(stream);

            char[] readByte = new char[contentLength];
            readStream.ReadBlock(readByte, 0, (int)contentLength);
            String result = new String(readByte);
            response.Close();
            stream.Close();
            readStream.Close();
            appList = JsonConvert.DeserializeObject<List<MAppData>>(result);
            refreshApp();
        }

        void refreshApp()
        {
            if (appList != null && appList.Count > 0)
            {
                int rowIndex = 0;
                this.appGridView.Rows.Clear();
                this.appGridView.Rows.Add(appList.Count);
                foreach (MAppData app in appList)
                {
                    appGridView["id", rowIndex].Value = app.mId;
                    appGridView["platform", rowIndex].Value = app.mPlatform;
                    appGridView["categoryName", rowIndex].Value =Util.decode(app.mCategoryName);
                    appGridView["leftUpIconUrl", rowIndex].Value =app.mLeftUpIconUrl;
                    appGridView["rightUpIconUrl", rowIndex].Value =app.mRightUpIconUrl;
                    appGridView["leftDownIconUrl", rowIndex].Value = app.mLeftDownIconUrl;
                    appGridView["rightDownIconUrl", rowIndex].Value =app.mRightDownIconUrl;
                    appGridView["leftUpRedirectUrl", rowIndex].Value = app.mLeftUpRedirectUrl;
                    appGridView["rightUpRedirectUrl", rowIndex].Value = app.mRightUpRedirectUrl;
                    appGridView["leftDownRedirectUrl", rowIndex].Value = app.mLeftDownRedirectUrl;
                    appGridView["rightDownRedirectUrl", rowIndex].Value = app.mRightDownRedirectUrl;
                    appGridView["bannerIsShow", rowIndex].Value = app.mBannerIsShow;
                    appGridView["taobaokeIsShow", rowIndex].Value =app.mTaobaokeIsShow;
                    appGridView["adIsShow", rowIndex].Value = app.mAdIsShow;
                    rowIndex++;
                }
            }
            else
            {
                this.appGridView.Rows.Clear();
            }
        }


        void refreshBtn()
        {
            if (m_isEdit)
            {
                btnAddAppData.Text = "保存";
                exitEditBtn.Visible = true;
            }
            else
            {
                btnAddAppData.Text = "添加";
                exitEditBtn.Visible = false;
               
            }
        }

        private void exitEditBtn_Click(object sender, EventArgs e)
        {
            m_isEdit = false;
            refreshBtn();
        }

        private void btnAddAppData_Click(object sender, EventArgs e)
        {
            if (m_isEdit)
            {
                if (m_selectApp == null)
                    return;
            }

            string url = MShareDataManager.gInstance.mServerUrl + "AddAppData";
            url += "?isEdit=" + m_isEdit;
            Encoding myEncoding = Encoding.GetEncoding("utf-8");
            HttpWebRequest myRequest =
            (HttpWebRequest)WebRequest.Create(url);
            string postData = string.Empty;  
            if (m_isEdit)
                postData += "&id=" + idTxt.Text.Trim();
            postData += "&platform=" + platformBox.SelectedItem;
            postData += "&categoryName=" +Util.encode(categoryBox.SelectedItem.ToString());
            postData += "&leftUpIconUrl=" +leftUpIconUrlTxt.Text.Trim();
            postData += "&rightUpIconUrl=" + rightUpIconUrlTxt.Text.Trim();
            postData += "&leftDownIconUrl=" + leftDownIconUrlTxt.Text.Trim();
            postData += "&rightDownIconUrl=" + rightDownIconUrlTxt.Text.Trim();
            postData += "&leftUpRedirectUrl=" + leftUpRedirectUrlTxt.Text.Trim();
            postData += "&rightUpRedirectUrl=" + rightUpRedirectUrlTxt.Text.Trim();
            postData += "&leftDownRedirectUrl=" + leftDownRedirectUrlTxt.Text.Trim();
            postData += "&rightDownRedirectUrl=" + rightDownRedirectUrlTxt.Text.Trim();
            postData += "&bannerIsShow=" + bannerIsShowChe.Checked;
            postData += "&taobaokeIsShow=" +taobaokeIsShowChe.Checked;
            postData += "&adIsShow=" +adIsShowChe.Checked;
            byte[] data = myEncoding.GetBytes(postData);

            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = data.Length;
            Stream newStream = myRequest.GetRequestStream();

            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();
            WebResponse response = myRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(stream);
            char[] readByte = new char[response.ContentLength];
            readStream.Read(readByte, 0, (int)response.ContentLength);
            String result = new String(readByte);
            newStream.Close();
            stream.Close();
            switch (Convert.ToInt32(result))
            {
                case 1:
                    requestAppList();
                    break;
                case 2:
                    MessageBox.Show("App已经存在，无需添加");
                    break;
                case 3:
                    MessageBox.Show("未知错误");
                    break;
            }
            if (appList != null && appList.Count > 0)
                m_selectApp = appList[0];
        }

        private void appGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = appGridView.Columns[e.ColumnIndex].Name;
            MAppData app = appList[e.RowIndex];
            m_selectApp = app;
            if (m_selectApp == null)
                return;

            if (columnName == "detail")
            {
                this.idTxt.Text = app.mId.ToString();
                this.platformBox.Text = app.mPlatform;
                this.categoryBox.Text =Util.decode(app.mCategoryName);
                this.leftUpIconUrlTxt.Text = app.mLeftUpIconUrl;
                this.rightUpIconUrlTxt.Text = app.mRightUpIconUrl;
                this.leftDownIconUrlTxt.Text = app.mLeftDownIconUrl;
                this.rightDownIconUrlTxt.Text = app.mRightDownIconUrl;
                this.leftUpRedirectUrlTxt.Text = app.mLeftUpRedirectUrl;
                this.rightUpRedirectUrlTxt.Text = app.mRightUpRedirectUrl;
                this.leftDownRedirectUrlTxt.Text = app.mLeftDownRedirectUrl;
                this.rightDownRedirectUrlTxt.Text = app.mRightDownRedirectUrl;
                this.bannerIsShowChe.Checked = app.mBannerIsShow;
                this.taobaokeIsShowChe.Checked = app.mTaobaokeIsShow;
                this.adIsShowChe.Checked = app.mAdIsShow;
                m_isEdit = true;
                refreshBtn();
            }
            else if (columnName == "delete")
            {
                HttpWebRequest myRequest =
                       (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "DeleteAppData?id=" + app.mId);
                myRequest.Method = "GET";
                myRequest.ContentType = "application/x-www-form-urlencoded";
                WebResponse response = myRequest.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(stream);
                char[] readByte = new char[response.ContentLength];
                readStream.Read(readByte, 0, (int)response.ContentLength);
                String result = new String(readByte);
                response.Close();
                stream.Close();
           
                    requestAppList();
                
            }
        }
    }
}
