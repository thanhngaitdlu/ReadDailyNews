namespace ReadDailyNews.Components
{
	partial class NewsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblDetail = new System.Windows.Forms.LinkLabel();
			this.lblDescription = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Blue;
			this.lblTitle.Location = new System.Drawing.Point(10, 5);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(32, 13);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Title";
			// 
			// lblDate
			// 
			this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(7, 110);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(35, 13);
			this.lblDate.TabIndex = 1;
			this.lblDate.Text = "label2";
			// 
			// lblDetail
			// 
			this.lblDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDetail.AutoSize = true;
			this.lblDetail.Location = new System.Drawing.Point(427, 110);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(62, 13);
			this.lblDetail.TabIndex = 2;
			this.lblDetail.TabStop = true;
			this.lblDetail.Text = "Xem chi tiết";
			// 
			// lblDescription
			// 
			this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDescription.AutoEllipsis = true;
			this.lblDescription.Location = new System.Drawing.Point(10, 29);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(486, 68);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "label3";
			// 
			// NewsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblDetail);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblTitle);
			this.Name = "NewsControl";
			this.Size = new System.Drawing.Size(499, 134);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.LinkLabel lblDetail;
		private System.Windows.Forms.Label lblDescription;
	}
}
