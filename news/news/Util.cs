using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace news
{
    public class Util
    {
        static Encoding myEncoding = Encoding.GetEncoding("utf-8");
        public static string decode(string decodeString)
        {
            return HttpUtility.UrlDecode(decodeString, myEncoding);
        }

        public static string encode(string encodeString)
        {
            return HttpUtility.UrlEncode(encodeString, myEncoding);
        }
    }
}
