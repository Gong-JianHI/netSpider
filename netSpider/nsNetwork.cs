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
	class nsGet
	{
		private static netSpiderBase nsb=new netSpiderBase();
		public nsGet()
		{
		}
		public static void getStream(nsManager nsm,string url){
			HttpWebResponse hwp=nsb.getRequestResponse(url,nsm.Keepalive,nsm.Timeout,nsm.Method,nsm.Accept,nsm.UserAgent);
			nsm.streamh=hwp.GetResponseStream();
			return;
		}
		public static HttpWebResponse getResponse(nsManager nsm,string url){
			HttpWebResponse hwp=nsb.getRequestResponse(url,nsm.Keepalive,nsm.Timeout,nsm.Method,nsm.Accept,nsm.UserAgent);
			return hwp;
		}
	}
	
}
