using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadDailyNews.Models;

namespace ReadDailyNews.Components
{
	public partial class NewsControl : UserControl
	{
		public NewsControl()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			
			e.Graphics.DrawRectangle(Pens.Black, 0, 1, Width-1, Height -2);
		}

		public void SetArticle(Article news)
		{
			lblTitle.Text = news.Title;
			lblDescription.Text = news.Description;
			lblDate.Text = news.PublishedDate.ToString("dd/MM/yyyy HH:mm");
			lblDetail.LinkClicked += (sender, args) =>
			{
				Process.Start(news.Link);
			};
		}
	}

}
