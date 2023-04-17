using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadDailyNews.IO;
using ReadDailyNews.Models;
using ReadDailyNews.RSSFeed;

namespace ReadDailyNews
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
				   | SecurityProtocolType.Tls11
				   | SecurityProtocolType.Tls12
				   | SecurityProtocolType.Ssl3;

			var textRepository = new TextNewsRepository();
			var parser = new NewsParser();
			var reader = new RssReader(parser);
			var newsManager = new NewsFeedManager(textRepository, reader);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(newsManager));
		}
	}
}
