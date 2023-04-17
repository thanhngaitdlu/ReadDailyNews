using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using ReadDailyNews.Models;

namespace ReadDailyNews.IO
{
	// Lớp đọc dữ liệu từ file text. Nội dung file phải có định dạng như sau:

	// @Tuổi trẻ
	// #Kinh tế^https://tuoitre.vn/rss/kinh-doanh.rss
	// #Thế giới^https://tuoitre.vn/rss/the-gioi.rss
	//
	// @Vn Express
	// #Thời sự^https://vnexpress.net/rss/thoi-su.rss
	// #Pháp luật^https://vnexpress.net/rss/phap-luat.rss
	public class TextNewsRepository:INewsRepository
	{
		private const string FilePath = "data\\news.txt";
		public List<Publisher> Read()
		{
			var publishers = new List<Publisher>();
			Publisher office = null;
			string line;

			try
			{
				using (var stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
				{
					using (var reader = new StreamReader(stream))
					{
						while (!reader.EndOfStream)
						{
							line = reader.ReadLine();
							if (line == null)
								break;
							if (line.StartsWith("@"))
							{
								office = ParsePublisher(line);
								publishers.Add(office);
							}
							else if (line.StartsWith("#") && office != null)
							{
								var category = ParseCategory(line);
								office.Categories.Add(category);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				
			}
			return publishers;
		}

		public void Save(List<Publisher> publishers)
		{
			using (var stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
			{
				using (var writer = new StreamWriter(stream))
				{
					foreach (var publisher in publishers)
					{
						writer.WriteLine("@{0}",publisher.Name);

						foreach (var category in publisher.Categories)
						{
							writer.WriteLine("#{0}^{1}", category.Name, category.RssLink);
						}
					}
				}
			}
		}
		
		private Publisher ParsePublisher(string info)
		{
			return new Publisher() {Name = info.Substring(1).Trim()};
		}

		private Category ParseCategory(string info)
		{
			var parts = info.Substring(1).Split('^');
			return new Category()
			{
				Name = parts[0].Trim(),
				RssLink = parts[1].Trim()
			};
		}
	}
}