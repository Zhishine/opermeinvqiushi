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
    public partial class MImageManagerForm : Form
    {
        public MImageManagerForm()
        {
            InitializeComponent();
            requestImageList();
        }
        List<MCategory> categoryList = null;
        List<MImage> imageList = null;
        MImage m_selectImage = null;
        Boolean m_isEdit = false;
        private MImage m_currentImage;
        private int m_pageIndex = 0;
        int m_imageGridViewType = 0;
        Stream fs;
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
                this.imgPic.Width = 120;
                this.imgPic.SizeMode = PictureBoxSizeMode.Zoom;
                this.imgPic.Height = Convert.ToInt32(120 * rate);
                this.imgPic.Image = img;
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
                this.imagePicUrlTxt.Text = result;
            }
        }

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            m_pageIndex = 0;
            request();
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

        void request()
        {
            switch (m_imageGridViewType)
            {
                case 0:
                    requestImageList();
                    break;
             
                case 2:
                    requestImageByDescription();
                    break;
            }
        }

      

        void requestImageByDescription()
        {
            if (titleSearchTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("描述不能为空");
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
            imageList = JsonConvert.DeserializeObject<List<MImage>>(result);
            refreshImage();
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
                this.imgPic.Width = intWidth;
                this.imgPic.Height = intHeight;
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
                btnAddImage.Text = "保存";
                exitEditBtn.Visible = true;
            }
            else
            {
                btnAddImage.Text = "添加";
                exitEditBtn.Visible = false;
                m_selectImage = null;
                this.descriptionTxt.Text = "";
                this.imagePicUrlTxt.Text = "";
                this.ext1Txt.Text = "";
                this.ext2Txt.Text = "";
                this.ext3Txt.Text = "";
            }
        }

        void requestImageList()
        {
            HttpWebRequest myRequest =
                (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "SelectImage?type=0&pageIndex=" + m_pageIndex + "&pageSize=" + Convert.ToInt32(pageSizeTxt.Text.Trim())+"&categoryId="+MShareDataManager.gInstance.mCategoryID);
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
            imageList = JsonConvert.DeserializeObject<List<MImage>>(result);
            refreshImage();
        }

        void refreshImage()
        {
            if (imageList != null && imageList.Count > 0)
            {
                int rowIndex = 0;
                this.imageGridView.Rows.Clear();
                this.imageGridView.Rows.Add(imageList.Count);
                foreach (MImage image in imageList)
                {
                    imageGridView["id", rowIndex].Value = image.mID;
                    imageGridView["url", rowIndex].Value = image.mImageUrl;
                    imageGridView["isNativePage", rowIndex].Value = image.mIsNativePage;
                    imageGridView["redirectUrl", rowIndex].Value = image.mRedirectUrl;
                    imageGridView["description", rowIndex].Value = image.mDescription;
                    imageGridView["width", rowIndex].Value = image.mWidth;
                    imageGridView["height", rowIndex].Value = image.mHeight;
                    imageGridView["ext1", rowIndex].Value = image.mExt1;
                    imageGridView["ext2", rowIndex].Value = image.mExt2;
                    imageGridView["ext3", rowIndex].Value = image.mExt3;
                    rowIndex++;
                }
            }
            else
            {
                this.imageGridView.Rows.Clear();
            }
        }

        private void newsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = imageGridView.Columns[e.ColumnIndex].Name;
            MImage image = imageList[e.RowIndex];
            m_selectImage = image;
            if (m_selectImage == null)
                return;

            if (columnName == "detail")
            {
                this.idTxt.Text = image.mID.ToString();
                this.descriptionTxt.Text = image.mDescription;
                this.imagePicUrlTxt.Text = image.mImageUrl;
                this.ext2Txt.Text = image.mExt2;
                this.ext3Txt.Text = image.mExt3;
                this.ext1Txt.Text = image.mExt1;
                this.widthTxt.Text = image.mWidth.ToString();
                this.heightTxt.Text = image.mHeight.ToString();
                this.isNativePageChe.Checked = image.mIsNativePage;
                this.redirectUrlTxt.Text = image.mRedirectUrl;
                Image img = downloadImg(image.mImageUrl);
                if (img != null)
                {
                    int width = img.Width;
                    int height = img.Height;
                    double rate = (double)height / (double)width;
                    this.imgPic.Width = 120;
                    this.imgPic.SizeMode = PictureBoxSizeMode.Zoom;
                    this.imgPic.Height = Convert.ToInt32(120 * rate);
                    this.imgPic.Image = img;
                }
                m_isEdit = true;
                refreshBtn();
            }
            else if (columnName == "delete")
            {
                HttpWebRequest myRequest =
                       (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "DeleteImage?id=" + image.mID);
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
                    requestImageList();
                }
            }
        }

        private void titleSearchBtn_Click(object sender, EventArgs e)
        {
            m_imageGridViewType = 2;
            request();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (m_isEdit)
            {
                if (m_selectImage == null)
                    return;
            }
       
            string url = MShareDataManager.gInstance.mServerUrl + "AddImage";
            url += "?isEdit=" + m_isEdit;
            Encoding myEncoding = Encoding.GetEncoding("utf-8");
            HttpWebRequest myRequest =
            (HttpWebRequest)WebRequest.Create(url);
            string postData = string.Empty;
            if (m_isEdit)
                postData += "&id=" + idTxt.Text.Trim();
            postData += "&description=" + Util.encode(descriptionTxt.Text.Trim());
            postData += "&imageUrl=" + imagePicUrlTxt.Text.Trim();
            postData += "&isNativePage=" + isNativePageChe.Checked;
            postData += "&redirectUrl=" + redirectUrlTxt.Text.Trim();
            postData += "&ext1=" + ext1Txt.Text.Trim();
            postData += "&ext2=" + ext2Txt.Text.Trim();
            postData += "&ext3=" + ext3Txt.Text.Trim();
            postData += "&width=" + widthTxt.Text.Trim();
            postData += "&height=" + heightTxt.Text.Trim();
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
                    requestImageList();
                    break;
                case 2:
                    MessageBox.Show("图片已经存在，无需添加");
                    break;
                case 3:
                    MessageBox.Show("未知错误");
                    break;
            }
            if (imageList != null && imageList.Count > 0)
                m_selectImage =imageList[0];
        }

        private void showCategoryNewsBtn_Click(object sender, EventArgs e)
        {
            m_imageGridViewType = 1;
            request();
        }

        private void exitEditBtn_Click(object sender, EventArgs e)
        {
            m_isEdit = false;
            refreshBtn();
        }

 
    }
}
