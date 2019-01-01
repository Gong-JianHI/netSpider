/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/12/29 星期六
 * Time: 22:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;


namespace netSpider
{
	/// <summary>
	/// Description of nsGet.
	/// </summary>
	static class nsGet
	{
		private static netSpiderBase nsb = new netSpiderBase();
		private static bool useCookie=false;
		public static void getStream(nsManager nsm, string url)
		{
			if(useCookie){
				HttpWebResponse hwp = nsb.getRequestResponse(url, nsm.Keepalive, nsm.Timeout, nsm.Method, nsm.Accept, nsm.UserAgent);
			    nsm.streamh = hwp.GetResponseStream();
			}else{
				HttpWebResponse hwp = nsb.getRequestResponse(url, nsm.Keepalive, nsm.Timeout, nsm.Method, nsm.Accept, nsm.UserAgent);
			    nsm.streamh = hwp.GetResponseStream();
			}
			return;
		}
		public static HttpWebResponse getResponse(nsManager nsm, string url)
		{
			if(useCookie){
				HttpWebResponse hwp = nsb.getRequestResponse(url, nsm.Keepalive, nsm.Timeout, nsm.Method, nsm.Accept, nsm.UserAgent);
			    return hwp;
			}else{
				HttpWebResponse hwp = nsb.getRequestResponse(url, nsm.Keepalive, nsm.Timeout, nsm.Method, nsm.Accept, nsm.UserAgent);
			    return hwp;
			}
			
		}
		public static void setCookie(nsManager nsm){
			
		}
	}
	class nsPost
	{
		public nsPost()
		{
			
		}
		private void PostWebRequest(nsManager nsm, string postUrl, string paramData, Encoding dataEncode)
		{
			string ret = string.Empty;
			byte[] byteArray = dataEncode.GetBytes(paramData); //转化
			HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(postUrl));
			webReq.Method = "POST";
			webReq.ContentType = "application/x-www-form-urlencoded";
			webReq.KeepAlive = nsm.Keepalive;
			webReq.Timeout = nsm.Timeout;
			webReq.Accept = nsm.Accept;
			webReq.UserAgent = nsm.UserAgent;

			webReq.ContentLength = byteArray.Length;
			Stream newStream = webReq.GetRequestStream();
			newStream.Write(byteArray, 0, byteArray.Length);//写入参数
			newStream.Close();
			HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
			nsm.streamh = response.GetResponseStream();
			return;
		}
	}
}
