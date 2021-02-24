
namespace Wisej.Web.Ext.DevExpress.Dashboard.Sample.AspNetPanel
{
	partial class Window1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.aspNetPanel1 = new Wisej.Web.AspNetPanel();
			this.SuspendLayout();
			// 
			// aspNetPanel1
			// 
			this.aspNetPanel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.aspNetPanel1.Location = new System.Drawing.Point(20, 16);
			this.aspNetPanel1.Name = "aspNetPanel1";
			this.aspNetPanel1.PageSource = "AspNetPanel\\MyPage.aspx";
			this.aspNetPanel1.Size = new System.Drawing.Size(449, 424);
			this.aspNetPanel1.TabIndex = 0;
			this.aspNetPanel1.Text = "aspNetPanel1";
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 456);
			this.Controls.Add(this.aspNetPanel1);
			this.Name = "Window1";
			this.Text = "AspNetPanel";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.AspNetPanel aspNetPanel1;
	}
}