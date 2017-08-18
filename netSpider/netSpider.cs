using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace netSpider
{
    public class netSpider
    {
       
        public Stream  getScode(string URL, bool keepAlive, int timeOut, string method, string accept, string userAgent)
        {
            HttpWebRequest mywr = (HttpWebRequest)WebRequest.Create(URL);
            mywr.KeepAlive = keepAlive;
            mywr.Timeout = timeOut;
            mywr.Method = method;
            mywr.Accept = accept;
            mywr.UserAgent = userAgent;
            HttpWebResponse myrp = (HttpWebResponse)mywr.GetResponse();
            if (myrp.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }
            return myrp.GetResponseStream();
        }
        public Stream GetBaiduPicPage_S(string key)
        {
            string Url="http://image.baidu.com/search/index?tn=baiduimage&ct=201326592&lm=-1&cl=2&ie=gbk&word="+System.Web.HttpUtility.UrlDecode(key)+"&fr=ala&ala=2&alatpl=sp&pos=0";


          return  getScode(Url, true, 30 * 1000, "GET", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36");
        }
    }
}
