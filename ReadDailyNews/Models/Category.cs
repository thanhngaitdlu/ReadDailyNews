using System.Collections.Generic;

namespace ReadDailyNews.Models
{
	public class Category
	{
		// Tên chuyên mục
		public string Name { get; set; }

		// Liên kết để lấy danh sách tin tức từ web
		public string RssLink { get; set; }

		// Tập hợp các bài báo được lấy từ web
		public List<Article> Articles { get; set; }

		public Category()
		{
			Articles = new List<Article>();
		}
	}
}