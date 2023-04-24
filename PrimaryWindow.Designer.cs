namespace MuEncode
{
	partial class PrimaryWindow
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
			this.Panel_Input = new System.Windows.Forms.Panel();
			this.Panel_Output = new System.Windows.Forms.Panel();
			this.Panel_Footer = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Panel_Input
			// 
			this.Panel_Input.AllowDrop = true;
			this.Panel_Input.Location = new System.Drawing.Point(10, 10);
			this.Panel_Input.Margin = new System.Windows.Forms.Padding(1);
			this.Panel_Input.Name = "Panel_Input";
			this.Panel_Input.Size = new System.Drawing.Size(500, 160);
			this.Panel_Input.TabIndex = 0;
			// 
			// Panel_Output
			// 
			this.Panel_Output.AllowDrop = true;
			this.Panel_Output.Location = new System.Drawing.Point(10, 172);
			this.Panel_Output.Margin = new System.Windows.Forms.Padding(1);
			this.Panel_Output.Name = "Panel_Output";
			this.Panel_Output.Size = new System.Drawing.Size(500, 160);
			this.Panel_Output.TabIndex = 1;
			this.Panel_Output.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// Panel_Footer
			// 
			this.Panel_Footer.AllowDrop = true;
			this.Panel_Footer.Location = new System.Drawing.Point(10, 334);
			this.Panel_Footer.Margin = new System.Windows.Forms.Padding(1);
			this.Panel_Footer.Name = "Panel_Footer";
			this.Panel_Footer.Size = new System.Drawing.Size(500, 50);
			this.Panel_Footer.TabIndex = 2;
			// 
			// PrimaryWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(519, 394);
			this.Controls.Add(this.Panel_Footer);
			this.Controls.Add(this.Panel_Output);
			this.Controls.Add(this.Panel_Input);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "PrimaryWindow";
			this.Text = "μEncode";
			this.ResumeLayout(false);

		}

		#endregion

		private Panel Panel_Input;
		private Panel Panel_Output;
		private Panel Panel_Footer;
	}
}