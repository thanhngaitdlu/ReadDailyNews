using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadDailyNews.Components;
using ReadDailyNews.Models;

namespace ReadDailyNews
{
	public partial class MainForm : Form
	{
		private readonly NewsFeedManager _newsManager;
		public MainForm(NewsFeedManager newsManager)
		{
			InitializeComponent();
			_newsManager = newsManager;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var publisher = _newsManager.GetNewFeed();
			ShowFeedOnTreeView(publisher);
		}

		private void ShowFeedOnTreeView(List<Publisher> publishers)
		{
			tvPublishers.Nodes.Clear();
			pnNews.Controls.Clear();

			foreach (var publisher in publishers)
			{
				var publisherNode = tvPublishers.Nodes.Add(publisher.Name);

				foreach (var category in publisher.Categories)
				{
					publisherNode.Nodes.Add(category.Name);
				}
			}
			tvPublishers.ExpandAll();
		}

		private void btnAddFeed_Click(object sender, EventArgs e)
		{
			var dialog = new AddFeedForm(_newsManager);
			dialog.ShowDialog(this);

			if (dialog.HasChanged)
			{
				_newsManager.SaveChange();
				ShowFeedOnTreeView(_newsManager.GetNewFeed());
			}
		}

		private void btnRemoveFeed_Click(object sender, EventArgs e)
		{
			if (tvPublishers.SelectedNode == null) return;

			if (tvPublishers.SelectedNode.Level == 0)
			{
				_newsManager.RemovePublisher(tvPublishers.SelectedNode.Text);
			}
			else
			{
				var publisherNode = tvPublishers.SelectedNode.Parent;
				_newsManager.RemoveCategory(publisherNode.Text, tvPublishers.SelectedNode.Text);
			}
			tvPublishers.SelectedNode.Remove();
		}

		private void tvPublishers_AfterSelect(object sender, TreeViewEventArgs e)
		{
			pnNews.Controls.Clear();

			if (e.Node.Level == 1)
			{
				var articles = _newsManager.GetNews(e.Node.Parent.Text, e.Node.Text);

				foreach (var article in articles)
				{
					var item = new NewsControl();
					item.Size = new Size(500,100);
					item.Dock = DockStyle.Top;
					item.SetArticle(article);

					pnNews.Controls.Add(item);
				}
			}
		}
	}
}
