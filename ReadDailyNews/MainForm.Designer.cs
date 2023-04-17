namespace ReadDailyNews
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tvPublishers = new System.Windows.Forms.TreeView();
			this.pnNews = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddFeed = new System.Windows.Forms.Button();
			this.btnRemoveFeed = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tvPublishers
			// 
			this.tvPublishers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tvPublishers.Location = new System.Drawing.Point(12, 33);
			this.tvPublishers.Name = "tvPublishers";
			this.tvPublishers.Size = new System.Drawing.Size(231, 433);
			this.tvPublishers.TabIndex = 3;
			this.tvPublishers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPublishers_AfterSelect);
			// 
			// pnNews
			// 
			this.pnNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnNews.AutoScroll = true;
			this.pnNews.BackgroundImage = global::ReadDailyNews.Properties.Resources.Picture2;
			this.pnNews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnNews.Location = new System.Drawing.Point(249, 33);
			this.pnNews.Name = "pnNews";
			this.pnNews.Size = new System.Drawing.Size(574, 433);
			this.pnNews.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn tòa soạn và chuyên mục";
			// 
			// btnAddFeed
			// 
			this.btnAddFeed.Location = new System.Drawing.Point(181, 4);
			this.btnAddFeed.Name = "btnAddFeed";
			this.btnAddFeed.Size = new System.Drawing.Size(28, 23);
			this.btnAddFeed.TabIndex = 1;
			this.btnAddFeed.Text = "+";
			this.btnAddFeed.UseVisualStyleBackColor = true;
			this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
			// 
			// btnRemoveFeed
			// 
			this.btnRemoveFeed.Location = new System.Drawing.Point(215, 4);
			this.btnRemoveFeed.Name = "btnRemoveFeed";
			this.btnRemoveFeed.Size = new System.Drawing.Size(28, 23);
			this.btnRemoveFeed.TabIndex = 2;
			this.btnRemoveFeed.Text = "-";
			this.btnRemoveFeed.UseVisualStyleBackColor = true;
			this.btnRemoveFeed.Click += new System.EventHandler(this.btnRemoveFeed_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 478);
			this.Controls.Add(this.btnRemoveFeed);
			this.Controls.Add(this.btnAddFeed);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pnNews);
			this.Controls.Add(this.tvPublishers);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView tvPublishers;
		private System.Windows.Forms.Panel pnNews;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddFeed;
		private System.Windows.Forms.Button btnRemoveFeed;
	}
}

