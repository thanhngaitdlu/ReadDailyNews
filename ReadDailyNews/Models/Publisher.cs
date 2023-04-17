using System.Collections.Generic;

namespace ReadDailyNews.Models
{
	public class Publisher
	{
		// Tên tòa soạn
		public string Name { get; set; }

		// Danh sách các chuyên mục
		public List<Category> Categories { get; set; }

		public Publisher()
		{
			Categories = new List<Category>();
		}

		public bool AddCategory(string name, string link, bool updateIfExisted)
		{
			var category = Categories.Find(x => x.Name == name);

			if (category == null)
			{
				category = new Category()
				{
					Name = name,
					RssLink = link
				};

				Categories.Add(category);
				return true;
			}
			if (updateIfExisted)
			{
				category.RssLink = link;
				return true;
			}
			return false;
		}

		public void RemoveCategory(string name)
		{
			Categories.RemoveAll(x => x.Name == name);
		}
	}
}