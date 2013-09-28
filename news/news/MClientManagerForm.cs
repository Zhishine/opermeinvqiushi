using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
namespace news
{
    public partial class MClientManagerForm : Form
    {
        public MClientManagerForm()
        {
            InitializeComponent();
            fillCategoryBox();
        }
        List<MCategory> categoryList;
        void fillCategoryBox()
        {
            System.GC.Collect();

            Thread.Sleep(100);
            this.categoryListBox.Items.Clear();
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
                this.categoryListBox.Items.Clear();
                foreach (MCategory category in categoryList)
                    this.categoryListBox.Items.Add(Util.decode(category.mName));
            }
          
        }
        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            string nameEncoderString = Util.encode(this.categoryTxt.Text.Trim());
            HttpWebRequest myRequest =
         (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "AddCategory?name=" + nameEncoderString);
            myRequest.Method = "GET";
            myRequest.ContentType = "text/html;charset=gb2312";
            WebResponse response = myRequest.GetResponse();
            fillCategoryBox();
        }

        private void delCategoryBtn_Click(object sender, EventArgs e)
        {
           
            if (this.categoryListBox.SelectedIndex == -1)
            {
                MessageBox.Show("还没选中频道");
                return;
            }
            MCategory category = categoryList[this.categoryListBox.SelectedIndex];
            if (category == null)
                return;
            HttpWebRequest myRequest =
       (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "DeleteCategory?id=" + category.mID);
            myRequest.Method = "GET";
            WebResponse response = myRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(stream);
            char[] readByte = new char[response.ContentLength];
            readStream.Read(readByte, 0, (int)response.ContentLength);
            String result = new String(readByte);
            response.Close();
            readStream.Close();
            if (Convert.ToBoolean(result))
            {
                fillCategoryBox();
            }
        }

        private void updatecategoryNameBtn_Click(object sender, EventArgs e)
        {
            MCategory category = null;
            if (categoryListBox.SelectedIndex != -1)
            {

                category = categoryList[categoryListBox.SelectedIndex];
                string nameEncoderString = Util.encode(this.categoryNameTxt.Text.Trim());
                HttpWebRequest myRequest =
             (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "UpdateData?type=category&id=" + category.mID + "&name=" + nameEncoderString);
                myRequest.Method = "GET";
                myRequest.ContentType = "text/html;charset=gb2312";
                WebResponse response = myRequest.GetResponse();
                fillCategoryBox();
            }
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedIndex < 0)
                return;
            MCategory category = categoryList[categoryListBox.SelectedIndex];
            if (category != null)
            {
                this.categoryIdTxt.Text = category.mID.ToString();
                this.categoryNameTxt.Text = Util.decode(category.mName.ToString());
            }
        }
    }
}
