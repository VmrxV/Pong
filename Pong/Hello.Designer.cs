namespace Pong
{
	partial class Hello
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
			this.helloMy1 = new Pong.HelloMy();
			this.SuspendLayout();
			// 
			// helloMy1
			// 
			this.helloMy1.Location = new System.Drawing.Point(12, 2);
			this.helloMy1.Name = "helloMy1";
			this.helloMy1.Size = new System.Drawing.Size(507, 259);
			this.helloMy1.TabIndex = 0;
			this.helloMy1.Load += new System.EventHandler(this.helloMy1_Load);
			// 
			// Hello
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(509, 274);
			this.Controls.Add(this.helloMy1);
			this.Name = "Hello";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hello";
			this.ResumeLayout(false);

		}

		#endregion

		private HelloMy helloMy1;
	}
}