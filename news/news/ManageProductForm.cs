using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Top.Api.Domain;
using Top.Api.Request;
using Top.Api.Response;

namespace news
{

    public partial class ManageProductForm : Form
    {
        private long m_currentNumId;
        private MProduct m_currentProduct;
        private int m_pageIndex = 0;
        List<MProduct> products = null;

        List<int> addAblumId = new List<int>();
        List<int> deleteAblumId = new List<int>();
        List<int> addStyleId = new List<int>();
        List<int> deleteStyleId = new List<int>();
        List<int> addCategoryId = new List<int>();
        List<int> deleteCategoryId = new List<int>();
        int m_productGridViewType = 0;
        MProduct m_selectProduct;
        bool m_isEdit = false;
        public ManageProductForm()
        {
            InitializeComponent();
            fillProductList();
            refreshBtn();
        }

        void fillProductList()
        {
            productGridView.Rows.Add(40);
            requestProductList();
        }


        void requestProductByNumId()
        {
            if (numIdExTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("numId 不能为空");
                return;
            }
            HttpWebRequest myRequest =
             (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "SelectProduct?type=1&numId=" + numIdExTxt.Text.Trim());
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
            products = JsonConvert.DeserializeObject<List<MProduct>>(result);
            refreshProduct();
        }

        void requestProductByTitle()
        {
            if (titleSearchTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("numId 不能为空");
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
            products = JsonConvert.DeserializeObject<List<MProduct>>(result);
            refreshProduct();
        }
        void requestProductList()
        {
            HttpWebRequest myRequest =
             (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "SelectProduct?type=0&pageIndex=" + m_pageIndex + "&pageSize=" + Convert.ToInt32(pageSizeTxt.Text.Trim())+"&categoryId="+MShareDataManager.gInstance.mCategoryID);
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
            products = JsonConvert.DeserializeObject<List<MProduct>>(result);
            refreshProduct();
        }


        void refreshProduct()
        {
            if (products != null && products.Count > 0)
            {
                int rowIndex = 0;
                this.productGridView.Rows.Clear();
                this.productGridView.Rows.Add(products.Count);
                foreach (MProduct product in products)
                {
                    productGridView["numId", rowIndex].Value = product.mNumId;
                    productGridView["title", rowIndex].Value = Util.decode(product.mTitle);
                    productGridView["pcClickUrl", rowIndex].Value = product.mPcClickUrl;
                    productGridView["mobileClickUrl", rowIndex].Value = product.mMobileClickUrl;
                    productGridView["imageRate", rowIndex].Value = product.mImageRate;
                    productGridView["newPrice", rowIndex].Value = product.mNewPrice;
                    productGridView["oldPrice", rowIndex].Value = product.mOldPrice;
                    rowIndex++;
                }
            }
            else
            {
                this.productGridView.Rows.Clear();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_pageIndex == 0)
                return;
            m_pageIndex--;
            request();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m_pageIndex++;
            request();
        }

        private void lastPageBtn_Click(object sender, EventArgs e)
        {

        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pcClickUrlTxt.Text == string.Empty)
                    return;
                //if (!pcClickUrlTxt.Text.Trim().Contains("34009286"))
                //{
                //    MessageBox.Show("链接没带上咱们的淘宝客ID,34009286");
                //    return;
                //}
                string pcClickUrl = pcClickUrlTxt.Text;
                Uri uri = new Uri(pcClickUrl);
                string queryString = uri.Query;
                NameValueCollection collection = GetQueryString(queryString, Encoding.UTF8, false);
                m_currentNumId = Convert.ToInt64(collection.Get("id"));
                string mobileClickUrl = null;
                if (m_currentNumId == 0)
                    return;
                //if (pcClickUrl.StartsWith("http://item.taobao.com"))
                //{
                //    mobileClickUrl = pcClickUrl.Replace("http://item.taobao.com", "http://a.m.taobao.com");
                //    string findStr = "tem.htm?";
                //    int length = findStr.Length;
                //    int index = pcClickUrl.IndexOf(findStr);
                //    mobileClickUrl = mobileClickUrl.Replace(findStr, collection.Get("id") + ".htm?");
                //    mobileClickUrl = mobileClickUrl.Replace("id=" + collection.Get("id") + "&", "");
                //}
                //else if (pcClickUrl.StartsWith("http://detail.tmall.com"))
                //{
                //    mobileClickUrl = pcClickUrl.Replace("http://detail.tmall.com", "http://a.m.tmall.com");
                //    string findStr = "tem.htm?";
                //    int length = findStr.Length;
                //    int index = pcClickUrl.IndexOf(findStr);
                //    mobileClickUrl = mobileClickUrl.Replace(findStr, collection.Get("id") + ".htm?");
                //    mobileClickUrl = mobileClickUrl.Replace("id=" + collection.Get("id") + "&", "");
                //}
                //else
                //    return;
                //ItemGetRequest itemResquest = new ItemGetRequest();
                //itemResquest.NumIid = m_currentNumId;
                //itemResquest.Fields = "num_iid,title,pic_url,price";
                //ItemGetResponse itemResponse=MShareDataManager.gInstance.mClient.Execute<ItemGetResponse>(itemResquest);
                TaobaokeItemsDetailGetRequest req = new TaobaokeItemsDetailGetRequest();
                req.Fields = "click_url,num_iid,title,pic_url,price";
                req.NumIids = m_currentNumId.ToString();
                req.IsMobile = true;
                TaobaokeItemsDetailGetResponse itemResponse = MShareDataManager.gInstance.mClient.Execute<TaobaokeItemsDetailGetResponse>(req);
                string url = itemResponse.ReqUrl;
                if (itemResponse.TaobaokeItemDetails == null || itemResponse.TaobaokeItemDetails.Count == 0)
                {
                    MessageBox.Show("不是淘宝客商品");
                    return;
                }
                TaobaokeItemDetail item = itemResponse.TaobaokeItemDetails.FirstOrDefault();
                m_currentProduct = new MProduct();
                m_currentProduct.mNumId = m_currentNumId;
                m_currentProduct.mTitle = item.Item.Title;
                m_currentProduct.mImageUrl = item.Item.PicUrl;
                m_currentProduct.mOldPrice = Convert.ToSingle(item.Item.Price);
                mobileClickUrl = item.ClickUrl;
                this.oldPriceTxt.Text = this.newPriceTxt.Text = m_currentProduct.mOldPrice.ToString();
                this.numIdTxt.Text = m_currentNumId.ToString();
                this.titleTxt.Text = m_currentProduct.mTitle;
                m_currentProduct.mMobileClickUrl = this.mobileClickUrlTxt.Text = mobileClickUrl;
                this.pictureBox1.Image = downloadImg(m_currentProduct.mImageUrl + "_100x100.jpg");

                TaobaokeItemsDetailGetRequest req1 = new TaobaokeItemsDetailGetRequest();
                req.Fields = "click_url";
                req.NumIids = m_currentNumId.ToString();
                req.IsMobile = false;
                TaobaokeItemsDetailGetResponse itemResponse1 = MShareDataManager.gInstance.mClient.Execute<TaobaokeItemsDetailGetResponse>(req);
                string url1 = itemResponse1.ReqUrl;
                if (itemResponse1.TaobaokeItemDetails == null || itemResponse1.TaobaokeItemDetails.Count == 0)
                {
                    MessageBox.Show("不是淘宝客商品");
                    return;
                }
                TaobaokeItemDetail item1 = itemResponse1.TaobaokeItemDetails.FirstOrDefault();
                m_currentProduct.mPcClickUrl = pcClickUrl = pcClickUrlTxt.Text = item1.ClickUrl;

            }
            catch (Exception e1)
            {
                MessageBox.Show("错误：" + e1.Message.ToString());
            }
        }

        Image downloadImg(string imgUrl)
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
            this.pictureBox1.Width = intWidth;
            this.pictureBox1.Height = intHeight;
            this.imageRateTxt.Text = (((float)intWidth / (float)intHeight)).ToString("0.##");
            return pic;
        }
        public static NameValueCollection GetQueryString(string queryString, Encoding encoding, bool isEncoded)
        {
            queryString = queryString.Replace("?", "");
            NameValueCollection result = new NameValueCollection(StringComparer.OrdinalIgnoreCase);
            if (!string.IsNullOrEmpty(queryString))
            {
                int count = queryString.Length;
                for (int i = 0; i < count; i++)
                {
                    int startIndex = i;
                    int index = -1;
                    while (i < count)
                    {
                        char item = queryString[i];
                        if (item == '=')
                        {
                            if (index < 0)
                            {
                                index = i;
                            }
                        }
                        else if (item == '&')
                        {
                            break;
                        }
                        i++;
                    }
                    string key = null;
                    string value = null;
                    if (index >= 0)
                    {
                        key = queryString.Substring(startIndex, index - startIndex);
                        value = queryString.Substring(index + 1, (i - index) - 1);
                    }
                    else
                    {
                        key = queryString.Substring(startIndex, i - startIndex);
                    }
                    if (isEncoded)
                    {
                        result[MyUrlDeCode(key, encoding)] = MyUrlDeCode(value, encoding);
                    }
                    else
                    {
                        result[key] = value;
                    }
                    if ((i == (count - 1)) && (queryString[i] == '&'))
                    {
                        result[key] = string.Empty;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 解码URL.
        /// </summary>
        /// <param name="encoding">null为自动选择编码</param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MyUrlDeCode(string str, Encoding encoding)
        {
            if (encoding == null)
            {

                Encoding utf8 = Encoding.UTF8;
                //首先用utf-8进行解码                     
                string code = HttpUtility.UrlDecode(str.ToUpper(), utf8);
                //将已经解码的字符再次进行编码.
                string encode = HttpUtility.UrlEncode(code, utf8).ToUpper();
                if (str == encode)
                    encoding = Encoding.UTF8;
                else
                    encoding = Encoding.GetEncoding("gb2312");
            }
            return HttpUtility.UrlDecode(str, encoding);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!m_isEdit)
            {
                if (m_currentProduct == null)
                    return;
            }
            else
            {
                if (m_selectProduct == null)
                    return;
            }
            string url = MShareDataManager.gInstance.mServerUrl + "AddProduct";
            url += "?isEdit=" + m_isEdit;
            Encoding myEncoding = Encoding.GetEncoding("utf-8");
            HttpWebRequest myRequest =
            (HttpWebRequest)WebRequest.Create(url);

            string postData = "numId=" + numIdTxt.Text.Trim();
            postData += "&title=" + titleTxt.Text.Trim();
            postData += "&imageUrl=" + (m_isEdit ? m_selectProduct.mImageUrl : m_currentProduct.mImageUrl);
            postData += "&pcClickUrl=" + Util.encode(pcClickUrlTxt.Text.Trim());
            postData += "&mobileClickUrl=" + Util.encode(mobileClickUrlTxt.Text.Trim());
            postData += "&newPrice=" + newPriceTxt.Text.Trim();
            postData += "&oldPrice=" + oldPriceTxt.Text.Trim();
            postData += "&imageRate=" + imageRateTxt.Text.Trim();
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
                    // m_pageIndex = 0;
                    //addCategoryProduct(59);
                    //addBrandProduct(34);
                    //addAblumProduct(38);
                    request();
                    break;
                case 2:
                    MessageBox.Show("商品已经存在，无需添加");
                    break;
                case 3:
                    MessageBox.Show("未知错误");
                    break;
            }
            if (products != null && products.Count > 0)
                m_selectProduct = products[0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showAblumProductBtn_Click(object sender, EventArgs e)
        {
            m_productGridViewType = 1;
            m_pageIndex = 0;
         
        }

        private void showStyleProductBtn_Click(object sender, EventArgs e)
        {
            m_productGridViewType = 2;
            m_pageIndex = 0;
         
        }

        private void showCategoryProductBtn_Click(object sender, EventArgs e)
        {
            m_productGridViewType = 3;
            m_pageIndex = 0;
          
        }

        void request()
        {
            switch (m_productGridViewType)
            {
                case 0:
                    requestProductList();
                    break;
              
                case 4:
                    requestProductByNumId();
                    break;
                case 5:
                    requestProductByTitle();
                    break;
               
            }
        }

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            m_pageIndex = 0;
            request();
        }

        private void selectProductListBtn_Click(object sender, EventArgs e)
        {
            m_productGridViewType = 0;
            m_pageIndex = 0;
            request();
        }

     
        private void productGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (products == null)
                return;
            string columnName = productGridView.Columns[e.ColumnIndex].Name;
            MProduct product = products[e.RowIndex];
            m_selectProduct = product;
            if (product == null)
                return;
            if (columnName == "imageUrl")
            {
                this.pictureBox1.Image = downloadImg(product.mImageUrl + "_100x100.jpg");
            }
            else if (columnName == "detail")
            {


                this.pcClickUrlTxt.Text = product.mPcClickUrl;
                this.mobileClickUrlTxt.Text = product.mMobileClickUrl;
                this.numIdTxt.Text = product.mNumId.ToString();
                this.newPriceTxt.Text = product.mNewPrice.ToString();
                this.oldPriceTxt.Text = product.mOldPrice.ToString();
                this.pictureBox1.Image = downloadImg(product.mImageUrl + "_100x100.jpg");
                this.imageRateTxt.Text = product.mImageRate.ToString();
                this.titleTxt.Text = Util.decode(product.mTitle);

               
                m_isEdit = true;
                refreshBtn();
            }
            else if (columnName == "delete")
            {
                HttpWebRequest myRequest =
                       (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "DeleteProduct?numId=" + product.mNumId);
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
                    requestProductList();
                }
            }
            else if (columnName == "reset")
            {
                Uri uri = new Uri(m_selectProduct.mPcClickUrl);
                string queryString = uri.Query;
                NameValueCollection collection = GetQueryString(queryString, Encoding.UTF8, false);
                long numId = Convert.ToInt64(collection.Get("id"));
                string mobileClickUrl = null;
                if (numId == 0)
                    return;

                TaobaokeItemsDetailGetRequest req = new TaobaokeItemsDetailGetRequest();
                req.Fields = "click_url,num_iid,title,pic_url,price";
                req.NumIids = numId.ToString();
                req.IsMobile = true;
                TaobaokeItemsDetailGetResponse itemResponse = MShareDataManager.gInstance.mClient.Execute<TaobaokeItemsDetailGetResponse>(req);
                string url = itemResponse.ReqUrl;
                if (itemResponse.TaobaokeItemDetails == null || itemResponse.TaobaokeItemDetails.Count == 0)
                {
                    MessageBox.Show("不是淘宝客商品");
                    return;
                }
                TaobaokeItemDetail item = itemResponse.TaobaokeItemDetails.FirstOrDefault();
                MProduct tempProduct = new MProduct();
                tempProduct.mNumId = numId;
                tempProduct.mTitle = item.Item.Title;
                tempProduct.mImageUrl = item.Item.PicUrl;
                tempProduct.mOldPrice = Convert.ToSingle(item.Item.Price);
                mobileClickUrl = item.ClickUrl;
                this.oldPriceTxt.Text = tempProduct.mOldPrice.ToString();
                this.newPriceTxt.Text = m_selectProduct.mNewPrice.ToString();
                this.numIdTxt.Text = numId.ToString();
                this.titleTxt.Text = tempProduct.mTitle;
                tempProduct.mMobileClickUrl = this.mobileClickUrlTxt.Text = mobileClickUrl;
                this.pictureBox1.Image = downloadImg(tempProduct.mImageUrl + "_100x100.jpg");

                TaobaokeItemsDetailGetRequest req1 = new TaobaokeItemsDetailGetRequest();
                req.Fields = "click_url";
                req.NumIids = numId.ToString();
                req.IsMobile = false;
                TaobaokeItemsDetailGetResponse itemResponse1 = MShareDataManager.gInstance.mClient.Execute<TaobaokeItemsDetailGetResponse>(req);
                string url1 = itemResponse1.ReqUrl;
                if (itemResponse1.TaobaokeItemDetails == null || itemResponse1.TaobaokeItemDetails.Count == 0)
                {
                    MessageBox.Show("不是淘宝客商品");
                    return;
                }
                TaobaokeItemDetail item1 = itemResponse1.TaobaokeItemDetails.FirstOrDefault();
                tempProduct.mPcClickUrl = pcClickUrlTxt.Text = item1.ClickUrl;
                button1_Click(null, null);
            }
        }


        List<MCategory> getCategoryByNumId(long numId)
        {
            HttpWebRequest myRequest =
                   (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "SelectProductCategory?numId=" + numId);
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
            List<MCategory> categoryList = JsonConvert.DeserializeObject<List<MCategory>>(result);
            return categoryList;
        }

        void refreshBtn()
        {
            if (m_isEdit)
            {
                saveProductBtn.Text = "保存";
                exitEditBtn.Visible = true;
                transferBtn.Enabled = false;
            }
            else
            {
                saveProductBtn.Text = "添加入库";
                exitEditBtn.Visible = false;
                transferBtn.Enabled = true;
                this.titleTxt.Text = "";
                m_selectProduct = null;
                this.newPriceTxt.Text = "";
                this.oldPriceTxt.Text = "";
                this.imageRateTxt.Text = "";
                this.pcClickUrlTxt.Text = "";
                this.mobileClickUrlTxt.Text = "";
                this.numIdTxt.Text = "";
                pictureBox1.Image = null;
              
            }

        }


       
        private void pageSizeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchNumIdBtn_Click(object sender, EventArgs e)
        {
            m_productGridViewType = 4;
            request();
        }

        private void styleComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleSearchBtn_Click(object sender, EventArgs e)
        {
            m_productGridViewType = 5;
            request();
        }

        private void resetProductDataBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productGridView.Rows)
            {
                MProduct product = products[row.Index];
                m_selectProduct = product;
                Uri uri = new Uri(m_selectProduct.mPcClickUrl);
                string queryString = uri.Query;
                NameValueCollection collection = GetQueryString(queryString, Encoding.UTF8, false);
                long numId = Convert.ToInt64(collection.Get("id"));
                string mobileClickUrl = null;
                if (numId == 0)
                    continue;

                TaobaokeItemsDetailGetRequest req = new TaobaokeItemsDetailGetRequest();
                req.Fields = "click_url,num_iid,title,pic_url,price";
                req.NumIids = numId.ToString();
                req.IsMobile = true;
                TaobaokeItemsDetailGetResponse itemResponse = MShareDataManager.gInstance.mClient.Execute<TaobaokeItemsDetailGetResponse>(req);
                // string url2 = itemResponse.ReqUrl;
                if (itemResponse.TaobaokeItemDetails == null || itemResponse.TaobaokeItemDetails.Count == 0)
                {
                    continue;
                }
                TaobaokeItemDetail item = itemResponse.TaobaokeItemDetails.FirstOrDefault();
                MProduct tempProduct = new MProduct();
                tempProduct.mNumId = numId;
                tempProduct.mTitle = item.Item.Title;
                tempProduct.mImageUrl = item.Item.PicUrl;
                tempProduct.mOldPrice = Convert.ToSingle(item.Item.Price);
                mobileClickUrl = item.ClickUrl;
                this.oldPriceTxt.Text = tempProduct.mOldPrice.ToString();
                this.newPriceTxt.Text = m_selectProduct.mNewPrice.ToString();
                this.numIdTxt.Text = numId.ToString();
                this.titleTxt.Text = tempProduct.mTitle;
                tempProduct.mMobileClickUrl = this.mobileClickUrlTxt.Text = mobileClickUrl;
                this.pictureBox1.Image = downloadImg(tempProduct.mImageUrl + "_100x100.jpg");

                TaobaokeItemsDetailGetRequest req1 = new TaobaokeItemsDetailGetRequest();
                req.Fields = "click_url";
                req.NumIids = numId.ToString();
                req.IsMobile = false;
                TaobaokeItemsDetailGetResponse itemResponse1 = MShareDataManager.gInstance.mClient.Execute<TaobaokeItemsDetailGetResponse>(req);
                // string url1 = itemResponse1.ReqUrl;
                if (itemResponse1.TaobaokeItemDetails == null || itemResponse1.TaobaokeItemDetails.Count == 0)
                {
                    continue;
                }
                TaobaokeItemDetail item1 = itemResponse1.TaobaokeItemDetails.FirstOrDefault();
                tempProduct.mPcClickUrl = pcClickUrlTxt.Text = item1.ClickUrl;

                string url = MShareDataManager.gInstance.mServerUrl + "AddProduct";
                url += "?isEdit=true";
                Encoding myEncoding = Encoding.GetEncoding("utf-8");
                HttpWebRequest myRequest =
                (HttpWebRequest)WebRequest.Create(url);

                string postData = "numId=" + numIdTxt.Text.Trim();
                postData += "&title=" + titleTxt.Text.Trim();
                postData += "&imageUrl=" + m_selectProduct.mImageUrl;
                postData += "&pcClickUrl=" + Util.encode(pcClickUrlTxt.Text.Trim());
                postData += "&mobileClickUrl=" + Util.encode(mobileClickUrlTxt.Text.Trim());
                postData += "&newPrice=" + newPriceTxt.Text.Trim();
                postData += "&oldPrice=" + oldPriceTxt.Text.Trim();
                postData += "&imageRate=" + imageRateTxt.Text.Trim();
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
                newStream.Close();
                stream.Close();
            }
            request();
            MessageBox.Show("重置完成");
        }

        private void transferBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pcClickUrlTxt.Text == string.Empty)
                    return;
                //if (!pcClickUrlTxt.Text.Trim().Contains("34009286"))
                //{
                //    MessageBox.Show("链接没带上咱们的淘宝客ID,34009286");
                //    return;
                //}
                string pcClickUrl = pcClickUrlTxt.Text;
                Uri uri = new Uri(pcClickUrl);
                string queryString = uri.Query;
                NameValueCollection collection = GetQueryString(queryString, Encoding.UTF8, false);
                m_currentNumId = Convert.ToInt64(collection.Get("id"));
                string mobileClickUrl = null;
                if (m_currentNumId == 0)
                    return;
                //if (pcClickUrl.StartsWith("http://item.taobao.com"))
                //{
                //    mobileClickUrl = pcClickUrl.Replace("http://item.taobao.com", "http://a.m.taobao.com");
                //    string findStr = "tem.htm?";
                //    int length = findStr.Length;
                //    int index = pcClickUrl.IndexOf(findStr);
                //    mobileClickUrl = mobileClickUrl.Replace(findStr, collection.Get("id") + ".htm?");
                //    mobileClickUrl = mobileClickUrl.Replace("id=" + collection.Get("id") + "&", "");
                //}
                //else if (pcClickUrl.StartsWith("http://detail.tmall.com"))
                //{
                //    mobileClickUrl = pcClickUrl.Replace("http://detail.tmall.com", "http://a.m.tmall.com");
                //    string findStr = "tem.htm?";
                //    int length = findStr.Length;
                //    int index = pcClickUrl.IndexOf(findStr);
                //    mobileClickUrl = mobileClickUrl.Replace(findStr, collection.Get("id") + ".htm?");
                //    mobileClickUrl = mobileClickUrl.Replace("id=" + collection.Get("id") + "&", "");
                //}
                //else
                //    return;
                //ItemGetRequest itemResquest = new ItemGetRequest();
                //itemResquest.NumIid = m_currentNumId;
                //itemResquest.Fields = "num_iid,title,pic_url,price";
                //ItemGetResponse itemResponse=MShareDataManager.gInstance.mClient.Execute<ItemGetResponse>(itemResquest);
                TaobaokeItemsDetailGetRequest req = new TaobaokeItemsDetailGetRequest();
                req.Fields = "click_url,num_iid,title,pic_url,price";
                req.NumIids = m_currentNumId.ToString();
                req.IsMobile = true;
                TaobaokeItemsDetailGetResponse itemResponse = MShareDataManager.gInstance.mClient.Execute<TaobaokeItemsDetailGetResponse>(req);
                string url = itemResponse.ReqUrl;
                if (itemResponse.TaobaokeItemDetails == null || itemResponse.TaobaokeItemDetails.Count == 0)
                {
                    MessageBox.Show("不是淘宝客商品");
                    return;
                }
                TaobaokeItemDetail item = itemResponse.TaobaokeItemDetails.FirstOrDefault();
                m_currentProduct = new MProduct();
                m_currentProduct.mNumId = m_currentNumId;
                m_currentProduct.mTitle = item.Item.Title;
                m_currentProduct.mImageUrl = item.Item.PicUrl;
                m_currentProduct.mOldPrice = Convert.ToSingle(item.Item.Price);
                mobileClickUrl = item.ClickUrl;
                this.oldPriceTxt.Text = this.newPriceTxt.Text = m_currentProduct.mOldPrice.ToString();
                this.numIdTxt.Text = m_currentNumId.ToString();
                this.titleTxt.Text = m_currentProduct.mTitle;
                m_currentProduct.mMobileClickUrl = this.mobileClickUrlTxt.Text = mobileClickUrl;
                this.pictureBox1.Image = downloadImg(m_currentProduct.mImageUrl + "_100x100.jpg");

                TaobaokeItemsDetailGetRequest req1 = new TaobaokeItemsDetailGetRequest();
                req.Fields = "click_url";
                req.NumIids = m_currentNumId.ToString();
                req.IsMobile = false;
                TaobaokeItemsDetailGetResponse itemResponse1 = MShareDataManager.gInstance.mClient.Execute<TaobaokeItemsDetailGetResponse>(req);
                string url1 = itemResponse1.ReqUrl;
                if (itemResponse1.TaobaokeItemDetails == null || itemResponse1.TaobaokeItemDetails.Count == 0)
                {
                    MessageBox.Show("不是淘宝客商品");
                    return;
                }
                TaobaokeItemDetail item1 = itemResponse1.TaobaokeItemDetails.FirstOrDefault();
                m_currentProduct.mPcClickUrl = pcClickUrl = pcClickUrlTxt.Text = item1.ClickUrl;

            }
            catch (Exception e1)
            {
                MessageBox.Show("错误：" + e1.Message.ToString());
            }
        }

        private void saveProductBtn_Click(object sender, EventArgs e)
        {
            if (!m_isEdit)
            {
                if (m_currentProduct == null)
                    return;
            }
            else
            {
                if (m_selectProduct == null)
                    return;
            }
            string url = MShareDataManager.gInstance.mServerUrl + "AddProduct";
            url += "?isEdit=" + m_isEdit;
            Encoding myEncoding = Encoding.GetEncoding("utf-8");
            HttpWebRequest myRequest =
            (HttpWebRequest)WebRequest.Create(url);

            string postData = "numId=" + numIdTxt.Text.Trim();
            postData += "&title=" + titleTxt.Text.Trim();
            postData += "&imageUrl=" + (m_isEdit ? m_selectProduct.mImageUrl : m_currentProduct.mImageUrl);
            postData += "&pcClickUrl=" + Util.encode(pcClickUrlTxt.Text.Trim());
            postData += "&mobileClickUrl=" + Util.encode(mobileClickUrlTxt.Text.Trim());
            postData += "&newPrice=" + newPriceTxt.Text.Trim();
            postData += "&oldPrice=" + oldPriceTxt.Text.Trim();
            postData += "&imageRate=" + imageRateTxt.Text.Trim();
            postData += "&categoryId=" + MShareDataManager.gInstance.mCategoryID;
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
                    // m_pageIndex = 0;
                    //addCategoryProduct(59);
                    //addBrandProduct(34);
                    //addAblumProduct(38);
                    request();
                    break;
                case 2:
                    MessageBox.Show("商品已经存在，无需添加");
                    break;
                case 3:
                    MessageBox.Show("未知错误");
                    break;
            }
            if (products != null && products.Count > 0)
                m_selectProduct = products[0];
        }

        private void exitEditBtn_Click_1(object sender, EventArgs e)
        {
            m_isEdit = false;
            refreshBtn();
        }


    }
}
