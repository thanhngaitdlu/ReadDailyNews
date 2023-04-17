using System.Collections.Generic;
using ReadDailyNews.IO;
using ReadDailyNews.RSSFeed;

namespace ReadDailyNews.Models
{
	public class NewsFeedManager
	{
		private readonly INewsRepository _newsRepository;
		private readonly RssReader _reader;
		private List<Publisher> _publishers;

		public NewsFeedManager(INewsRepository newsRepository, RssReader reader)
		{
			_newsRepository = newsRepository;
			_reader = reader;
		}

		public List<Publisher> GetNewFeed()
		{
			if (_publishers == null)
			{
				_publishers = _newsRepository.Read();
			}
			return _publishers;
		}

		public void SaveChange()
		{
			_newsRepository.Save(_publishers);
		}

		public void RemovePublisher(string publisherName)
		{
			_publishers.RemoveAll(p => p.Name == publisherName);
			SaveChange();
		}

		public void RemoveCategory(string publisherName, string categoryName)
		{
			var publisher = _publishers.Find(p => p.Name == publisherName);
			if(publisher == null) return;
			
			publisher.RemoveCategory(categoryName);
		}

		public bool AddCategory(string publisherName, string categoryName, string rssLink, bool updateIfExisted)
		{
			var publisher = _publishers.Find(p => p.Name == publisherName);

			if (publisher == null)
			{
				publisher = new Publisher()
				{
					Name = publisherName
				};
				_publishers.Add(publisher);
			}

			return publisher.AddCategory(categoryName, rssLink, updateIfExisted);

		}

		public List<Article> GetNews(string publisherName, string categoryName)
		{
			var publisher = _publishers.Find(p => p.Name == publisherName);
			if (publisher == null) return new List<Article>();

			var category = publisher.Categories.Find(x => x.Name == categoryName);
			if(category == null) return new List<Article>();

			if (category.Articles.Count == 0)
			{
				category.Articles = _reader.GetNews(category.RssLink);
			}
			return category.Articles;
		}
	}
}