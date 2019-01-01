/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/12/29 星期六
 * Time: 22:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace netSpider
{
	/// <summary>
	/// Description of nsManager.
	/// </summary>
	class nsManager
	{
		public nsManager()
		{
			
		}
		private string userAgent;
		private string accept;
		private string method;
		private int timeout;
		private bool keepalive;
		public Stream streamh;
		string cookie;

		public string Cookie {
			get {
				return cookie;
			}
			set{
				cookie=value;
			}
		}

		public bool Keepalive {
			get {
				return keepalive;
			}
			set{
				keepalive=value;
			}
		}

		public string UserAgent {
			get {
				return userAgent;
			}
			set{
				accept=value;
			}
		}
		public string Accept {
			get {
				return accept;
			}
			set{
				userAgent=value;
			}
		}

		public string Method {
			get {
				return method;
			}
			set{
				method=value;
			}
		}
		
		public int Timeout {
			get {
				return timeout;
			}
			set{
				timeout =value;
			}
		}
		public string getString(){
			string temp;
			StreamReader s=new StreamReader (streamh);
			temp=s.ReadToEnd();
			return temp;
		}
	}
	class nsmHelp{
		public nsmHelp() {
			
		}
		
	}
}
