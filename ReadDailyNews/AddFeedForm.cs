using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadDailyNews.Models;

namespace ReadDailyNews
{
	public partial class AddFeedForm : Form
	{
		private readonly NewsFeedManager _newsManager;

		public bool HasChanged { get; set; }
		public AddFeedForm(NewsFeedManager newsManager)
		{
			InitializeComponent();
			_newsManager = newsManager;
		}

		private void AddFeedForm_Load(object sender, EventArgs e)
		{
			var publishers = _newsManager.GetNewFeed();
			foreach (var publisher in publishers)
			{
				cbbPublishers.Items.Add(publisher.Name);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var publisherName = cbbPublishers.Text;
			var categoryName = txtCategoryName.Text;
			var link = txtRssLink.Text;

			if (string.IsNullOrWhiteSpace(publisherName)
			    || string.IsNullOrWhiteSpace(categoryName)
			    || string.IsNullOrWhiteSpace(link))
			{
				MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Lỗi");
				return;
			}

			HasChanged = true;

			var success = _newsManager.AddCategory(publisherName, categoryName, link, false);
			if (success)
			{
				ClearForm();
				return;
			}
			if (MessageBox.Show("Chuyên mục này đã tồn tại, bạn có muốn cập nhật RSS link không?",
				    "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				_newsManager.AddCategory(publisherName, categoryName, link, true);
			}
			ClearForm();
		}

		private void ClearForm()
		{
			cbbPublishers.Text = "";
			txtCategoryName.Text = "";
			txtRssLink.Text = "";
		}
	}
}
