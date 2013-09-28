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
    public partial class MNewsManagerForm : Form
    {
        public MNewsManagerForm()
        {
            InitializeComponent();
            fillNewsList();
          
            refreshBtn();
        }
        List<MCategory> categoryList = null;
        List<MNews> newsList = null;
        MNews m_selectNews = null;
        Boolean m_isEdit = false;
        private MNews m_currentNews;
        private int m_pageIndex = 0;
        int m_newsGridViewType = 0;
        Stream fs;
     
         void fillNewsList()
        {
            newsGridView.Rows.Add(40);
            requestNewsList();
        }
        
        void requestNewsList()
        {
         HttpWebRequest myRequest =
             (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "SelectNews?type=0&pageIndex="+m_pageIndex+"&pageSize="+Convert.ToInt32(pageSizeTxt.Text.Trim())+"&categoryId="+MShareDataManager.gInstance.mCategoryID);
            myRequest.Method = "GET";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = myRequest.GetResponse();
            int contentLength =Convert.ToInt32(response.Headers["content-length"]);
            Stream stream = response.GetResponseStream();
            //stream.Position = 0;
            StreamReader readStream = new StreamReader(stream);

            char[] readByte = new char[contentLength];
            readStream.ReadBlock(readByte, 0, (int)contentLength);
            String result = new String(readByte);
            response.Close();
            stream.Close();
            readStream.Close();
            newsList = JsonConvert.DeserializeObject<List<MNews>>(result);
            refreshNews();
        }

          void refreshNews()
        {
            if (newsList != null && newsList.Count > 0)
            {
                int rowIndex = 0;
                this.newsGridView.Rows.Clear();
                this.newsGridView.Rows.Add(newsList.Count);
                foreach (MNews news in newsList)
                {
                    newsGridView["id", rowIndex].Value = news.mID;
                    newsGridView["title", rowIndex].Value = Util.decode(news.mTitle);
                    newsGridView["url", rowIndex].Value = news.mRedirectUrl;
                    newsGridView["description", rowIndex].Value = Util.decode(news.mDescription);
                    newsGridView["ext1", rowIndex].Value = news.mExt1;
                    newsGridView["ext2", rowIndex].Value = news.mExt2;
                    newsGridView["ext3", rowIndex].Value = news.mExt3;
                    rowIndex++;
                }
            }
            else
            {
                this.newsGridView.Rows.Clear();
            }
          }

        private void btnAddNews_Click(object sender, EventArgs e)
        {
            if (m_isEdit)
            {
                if (m_selectNews == null)
                    return;
            }
     
            string url = MShareDataManager.gInstance.mServerUrl + "AddNews";
            url += "?isEdit=" + m_isEdit;
            Encoding myEncoding = Encoding.GetEncoding("utf-8");
            HttpWebRequest myRequest =
            (HttpWebRequest)WebRequest.Create(url);
            string postData = string.Empty;
            if(m_isEdit)
            postData += "&id=" + idTxt.Text.Trim();
            postData += "&title=" + titleTxt.Text.Trim();
            postData += "&description=" + Util.encode(descriptionTxt.Text.Trim());
            postData += "&redirectUrl=" + Util.encode(urlTxt.Text.Trim());
            postData += "&titleImageUrl=" + newsPicUrlTxt.Text.Trim();
            postData += "&isWebPage=" + isWebPageChe.Checked;
            postData += "&ext1=" + ext1Txt.Text.Trim();
            postData += "&ext2=" + ext2Txt.Text.Trim();
            postData += "&ext3=" + ext3Txt.Text.Trim();
            postData += "&categoryId=" +MShareDataManager.gInstance.mCategoryID;
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
                    this.descriptionTxt.Text = this.idTxt.Text = string.Empty;
                    this.newsPicUrlTxt.Text = this.titleTxt.Text = string.Empty;
                    this.ext1Txt.Text = this.ext2Txt.Text = this.ext3Txt.Text = string.Empty;
                    requestNewsList();
                    break;
                case 2:
                    MessageBox.Show("网页已经存在，无需添加");
                    break;
                case 3:
                    MessageBox.Show("未知错误");
                    break;
            }
            if (newsList != null && newsList.Count > 0)
                m_selectNews = newsList[0];
        }

        private void newsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = newsGridView.Columns[e.ColumnIndex].Name;
            MNews news = newsList[e.RowIndex];
            m_selectNews = news;
            if (m_selectNews == null)
                return;
      
           if (columnName == "detail")
            {
                this.descriptionTxt.Text = Util.decode(news.mDescription);
                this.idTxt.Text = news.mID.ToString();
                this.urlTxt.Text = news.mRedirectUrl;
                this.ext2Txt.Text = news.mExt2;
                this.ext3Txt.Text = news.mExt3;
                this.ext1Txt.Text = news.mExt1;
                this.newsPicUrlTxt.Text = news.mTitleImageUrl;
                this.titleTxt.Text = Util.decode(news.mTitle);
                Image img = downloadImg(news.mTitleImageUrl); ;
                int width = img.Width;
                int height = img.Height;
                double rate = (double)height / (double)width;
                this.newsImgPic.Width = 120;
                this.newsImgPic.SizeMode = PictureBoxSizeMode.Zoom;
                this.newsImgPic.Height = Convert.ToInt32(120 * rate);
                this.newsImgPic.Image = img;
                m_isEdit = true;
                refreshBtn();
            }
            else if (columnName == "delete")
            {
                HttpWebRequest myRequest =
                       (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "DeleteNews?id=" + news.mID);
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
                if (Convert.ToBoolean(result))
                {
                    requestNewsList();
                }
            }
        }
        Image downloadImg(string imgUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(imgUrl))
                    return null;
                WebClient client = new WebClient();
                Uri uri = new Uri(imgUrl);
                byte[] data = client.DownloadData(uri);
                MemoryStream stream = new MemoryStream(data);
                Image pic = Image.FromStream(stream);//strFilePath是该图片的绝对路径
                int intWidth = pic.Width;//长度像素值
                int intHeight = pic.Height;//高度像素值
                this.newsImgPic.Width = intWidth;
                this.newsImgPic.Height = intHeight;
                return pic;
            }
            catch
            {
                return null;
            }
        }
        void refreshBtn()
        {
            if (m_isEdit)
            {
                btnAddNews.Text = "保存";
                exitEditBtn.Visible = true;
            }
            else
            {
                btnAddNews.Text = "添加";
                exitEditBtn.Visible = false;
                this.titleTxt.Text = "";
                m_selectNews = null;
                this.descriptionTxt.Text = "";
                this.urlTxt.Text = "";
                this.ext1Txt.Text = "";
                this.ext2Txt.Text = "";
                this.ext3Txt.Text = "";
            }
        }

        private void exitEditBtn_Click(object sender, EventArgs e)
        {
            m_isEdit = false;
            refreshBtn();
        }

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            m_pageIndex = 0;
            request();
        }

        void request()
        {
            switch (m_newsGridViewType)
            {
                case 0:
                    requestNewsList();
                    break;
               
                case 2:
                    requestProductByTitle();
                    break;
            }
        }

       
      

        void requestProductByTitle()
        {
            if (titleSearchTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("新闻标题不能为空");
                return;
            }
            HttpWebRequest myRequest =
             (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "SelectProduct?type=2&key=" + Util.encode(this.titleSearchTxt.Text.Trim()));
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
            newsList = JsonConvert.DeserializeObject<List<MNews>>(result);
            refreshNews();
        }

        private void prevPageBtn_Click(object sender, EventArgs e)
        {
            if (m_pageIndex == 0)
                return;
            m_pageIndex--;
            request();
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            m_pageIndex++;
            request();
        }

        private void titleSearchBtn_Click(object sender, EventArgs e)
        {
            m_newsGridViewType = 2;
            request();
        }

        private void showCategoryNewsBtn_Click(object sender, EventArgs e)
        {
            m_newsGridViewType = 1;
            request();
        }

        private void choseImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                fs = openFileDialog.OpenFile();
                Image img = Image.FromStream(fs);
                int width = img.Width;
                int height = img.Height;
                double rate = (double)height / (double)width;
                this.newsImgPic.Width = 120;
                this.newsImgPic.SizeMode = PictureBoxSizeMode.Zoom;
                this.newsImgPic.Height = Convert.ToInt32(120 * rate);
                this.newsImgPic.Image = img;
            }
            catch
            {
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            HttpWebRequest myRequest =
        (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "UploadImage?type=ablum");

            myRequest.Method = "POST";
            myRequest.ContentType = "application/octet-stream";
            //myRequest.Connection = "Keep-Alive";
            //myRequest.Headers["Connection"] = "Keep-Alive";
            Stream newStream = myRequest.GetRequestStream();
            byte[] imgByte = new byte[fs.Length];
            fs.Position = 0;//他妈的，在这里花了n长时间，因为没有设置位置0，就从末端读起，都是000000000000000
            fs.Read(imgByte, 0, imgByte.Length);
            newStream.Write(imgByte, 0, imgByte.Length);
            newStream.Flush();
            // newStream.Close();
            WebResponse response = myRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(stream);
            char[] readByte = new char[response.ContentLength];
            readStream.Read(readByte, 0, (int)response.ContentLength);
            String result = new String(readByte);
            response.Close();
            readStream.Close();
            newStream.Close();
            if (!string.IsNullOrEmpty(result))
            {
                this.newsPicUrlTxt.Text = result;
            }
        }

        private void MNewsManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
