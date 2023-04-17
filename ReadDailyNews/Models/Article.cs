using System;

namespace ReadDailyNews.Models
{
	public class Article
	{
		// Tiêu đề bài báo
		public string Title { get; set; }

		// Nội dung giới thiệu ngắn
		public string Description { get; set; }

		// Ngày xuất bản
		public DateTime PublishedDate { get; set; }

		// Liên kết tới bài báo chi tiết
		public string Link { get; set; }

	}
}