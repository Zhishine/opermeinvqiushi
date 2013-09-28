using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;

namespace news
{
    public class MShareDataManager
    {
        public static readonly MShareDataManager gInstance = new MShareDataManager();
     
        public string mServerUrl = "http://192.168.1.115:8080/news/";
        public int mCategoryID = 1;
       // public string mServerUrl = "";
        private MShareDataManager()
        {

        }
        public ITopClient mClient
        {
            get
            {
                return new DefaultTopClient("http://gw.api.taobao.com/router/rest", "21583624", "56f377136a426911a9ad6b26cdd5ac79"); ;
            }
        }
       
    }
}
