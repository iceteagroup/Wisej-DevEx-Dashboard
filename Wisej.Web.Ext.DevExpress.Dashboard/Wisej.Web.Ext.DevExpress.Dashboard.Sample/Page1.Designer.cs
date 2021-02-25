
namespace Wisej.Web.Ext.DevExpress.Dashboard.Sample
{
	partial class Page1
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
			this.dashboard1 = new Wisej.Web.Ext.DevExpress.Dashboard.Dashboard();
			this.SuspendLayout();
			// 
			// dashboard1
			// 
			this.dashboard1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dashboard1.Location = new System.Drawing.Point(155, 83);
			this.dashboard1.Name = "dashboard1";
			this.dashboard1.Size = new System.Drawing.Size(817, 459);
			this.dashboard1.TabIndex = 1;
			this.dashboard1.Text = "aspNetPanel1";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.dashboard1);
			this.Name = "Page1";
			this.Padding = new Wisej.Web.Padding(8);
			this.Size = new System.Drawing.Size(1127, 624);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.Page1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Dashboard dashboard1;
	}
}

