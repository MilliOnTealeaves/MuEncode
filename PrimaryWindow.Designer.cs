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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryWindow));
			this.Pnl_Footer = new System.Windows.Forms.Panel();
			this.Lbl_Title = new System.Windows.Forms.Label();
			this.Img_Logo = new System.Windows.Forms.PictureBox();
			this.Lbl_Errors = new System.Windows.Forms.Label();
			this.Btn_ClearInput = new System.Windows.Forms.Button();
			this.Btn_ClearOutput = new System.Windows.Forms.Button();
			this.Lbl_Input = new System.Windows.Forms.Label();
			this.Lbl_Output = new System.Windows.Forms.Label();
			this.SplitContainer_Content = new System.Windows.Forms.SplitContainer();
			this.Pnl_InputWrapper = new System.Windows.Forms.Panel();
			this.TxtBx_Input = new System.Windows.Forms.TextBox();
			this.Pnl_InputHeader = new System.Windows.Forms.Panel();
			this.Btn_Paste = new System.Windows.Forms.Button();
			this.Btn_Open = new System.Windows.Forms.Button();
			this.Pnl_OutputWrapper = new System.Windows.Forms.Panel();
			this.TxtBx_Output = new System.Windows.Forms.TextBox();
			this.Pnl_OutputHeader = new System.Windows.Forms.Panel();
			this.Btn_Copy = new System.Windows.Forms.Button();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Pnl_Options = new System.Windows.Forms.Panel();
			this.ChkBx_Copy = new System.Windows.Forms.CheckBox();
			this.Pnl_AesWrapper = new System.Windows.Forms.Panel();
			this.SplitContainer_Aes = new System.Windows.Forms.SplitContainer();
			this.TxtBx_AesKey = new System.Windows.Forms.TextBox();
			this.Lbl_AesKey = new System.Windows.Forms.Label();
			this.TxtBx_AesIV = new System.Windows.Forms.TextBox();
			this.Lbl_AesIV = new System.Windows.Forms.Label();
			this.Lbl_AesOptions = new System.Windows.Forms.Label();
			this.Btn_Run = new System.Windows.Forms.Button();
			this.DrpDn_Mode = new System.Windows.Forms.ComboBox();
			this.Rdo_Decode = new System.Windows.Forms.RadioButton();
			this.Rdo_Encode = new System.Windows.Forms.RadioButton();
			this.Pnl_OptionsHeader = new System.Windows.Forms.Panel();
			this.Lbl_Options = new System.Windows.Forms.Label();
			this.Pnl_Footer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Img_Logo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Content)).BeginInit();
			this.SplitContainer_Content.Panel1.SuspendLayout();
			this.SplitContainer_Content.Panel2.SuspendLayout();
			this.SplitContainer_Content.SuspendLayout();
			this.Pnl_InputWrapper.SuspendLayout();
			this.Pnl_InputHeader.SuspendLayout();
			this.Pnl_OutputWrapper.SuspendLayout();
			this.Pnl_OutputHeader.SuspendLayout();
			this.Pnl_Options.SuspendLayout();
			this.Pnl_AesWrapper.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Aes)).BeginInit();
			this.SplitContainer_Aes.Panel1.SuspendLayout();
			this.SplitContainer_Aes.Panel2.SuspendLayout();
			this.SplitContainer_Aes.SuspendLayout();
			this.Pnl_OptionsHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// Pnl_Footer
			// 
			this.Pnl_Footer.AllowDrop = true;
			this.Pnl_Footer.BackColor = System.Drawing.Color.DarkSlateGray;
			this.Pnl_Footer.Controls.Add(this.Lbl_Title);
			this.Pnl_Footer.Controls.Add(this.Img_Logo);
			this.Pnl_Footer.Controls.Add(this.Lbl_Errors);
			this.Pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Pnl_Footer.Location = new System.Drawing.Point(0, 556);
			this.Pnl_Footer.Margin = new System.Windows.Forms.Padding(0);
			this.Pnl_Footer.Name = "Pnl_Footer";
			this.Pnl_Footer.Size = new System.Drawing.Size(915, 56);
			this.Pnl_Footer.TabIndex = 2;
			// 
			// Lbl_Title
			// 
			this.Lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_Title.Font = new System.Drawing.Font("EB Garamond 12", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.Lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(237)))), ((int)(((byte)(162)))));
			this.Lbl_Title.Location = new System.Drawing.Point(762, 4);
			this.Lbl_Title.Margin = new System.Windows.Forms.Padding(4);
			this.Lbl_Title.Name = "Lbl_Title";
			this.Lbl_Title.Size = new System.Drawing.Size(138, 49);
			this.Lbl_Title.TabIndex = 6;
			this.Lbl_Title.Text = "μEncode";
			this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Img_Logo
			// 
			this.Img_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Img_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Img_Logo.Image")));
			this.Img_Logo.Location = new System.Drawing.Point(6, 6);
			this.Img_Logo.Margin = new System.Windows.Forms.Padding(4);
			this.Img_Logo.Name = "Img_Logo";
			this.Img_Logo.Size = new System.Drawing.Size(40, 44);
			this.Img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Img_Logo.TabIndex = 1;
			this.Img_Logo.TabStop = false;
			// 
			// Lbl_Errors
			// 
			this.Lbl_Errors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_Errors.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lbl_Errors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Lbl_Errors.Location = new System.Drawing.Point(54, 6);
			this.Lbl_Errors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lbl_Errors.Name = "Lbl_Errors";
			this.Lbl_Errors.Size = new System.Drawing.Size(713, 44);
			this.Lbl_Errors.TabIndex = 6;
			this.Lbl_Errors.DoubleClick += new System.EventHandler(this.Lbl_Errors_DoubleClick);
			// 
			// Btn_ClearInput
			// 
			this.Btn_ClearInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Btn_ClearInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Btn_ClearInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_ClearInput.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Btn_ClearInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Btn_ClearInput.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_ClearInput.Location = new System.Drawing.Point(596, 6);
			this.Btn_ClearInput.Margin = new System.Windows.Forms.Padding(4);
			this.Btn_ClearInput.Name = "Btn_ClearInput";
			this.Btn_ClearInput.Size = new System.Drawing.Size(62, 30);
			this.Btn_ClearInput.TabIndex = 2;
			this.Btn_ClearInput.Text = "Clear";
			this.Btn_ClearInput.UseMnemonic = false;
			this.Btn_ClearInput.UseVisualStyleBackColor = false;
			this.Btn_ClearInput.Click += new System.EventHandler(this.Btn_ClearInput_Click);
			// 
			// Btn_ClearOutput
			// 
			this.Btn_ClearOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Btn_ClearOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Btn_ClearOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_ClearOutput.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Btn_ClearOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Btn_ClearOutput.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_ClearOutput.Location = new System.Drawing.Point(596, 6);
			this.Btn_ClearOutput.Margin = new System.Windows.Forms.Padding(4);
			this.Btn_ClearOutput.Name = "Btn_ClearOutput";
			this.Btn_ClearOutput.Size = new System.Drawing.Size(62, 30);
			this.Btn_ClearOutput.TabIndex = 1;
			this.Btn_ClearOutput.Text = "Clear";
			this.Btn_ClearOutput.UseVisualStyleBackColor = false;
			this.Btn_ClearOutput.Click += new System.EventHandler(this.Btn_ClearOutput_Click);
			// 
			// Lbl_Input
			// 
			this.Lbl_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_Input.BackColor = System.Drawing.Color.DarkSlateGray;
			this.Lbl_Input.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Lbl_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Lbl_Input.Location = new System.Drawing.Point(8, 8);
			this.Lbl_Input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lbl_Input.Name = "Lbl_Input";
			this.Lbl_Input.Size = new System.Drawing.Size(94, 29);
			this.Lbl_Input.TabIndex = 1;
			this.Lbl_Input.Text = "Input";
			this.Lbl_Input.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Lbl_Output
			// 
			this.Lbl_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_Output.BackColor = System.Drawing.Color.DarkSlateGray;
			this.Lbl_Output.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Lbl_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Lbl_Output.Location = new System.Drawing.Point(8, 8);
			this.Lbl_Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lbl_Output.Name = "Lbl_Output";
			this.Lbl_Output.Size = new System.Drawing.Size(94, 29);
			this.Lbl_Output.TabIndex = 2;
			this.Lbl_Output.Text = "Output";
			this.Lbl_Output.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// SplitContainer_Content
			// 
			this.SplitContainer_Content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer_Content.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer_Content.Margin = new System.Windows.Forms.Padding(4);
			this.SplitContainer_Content.Name = "SplitContainer_Content";
			this.SplitContainer_Content.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SplitContainer_Content.Panel1
			// 
			this.SplitContainer_Content.Panel1.Controls.Add(this.Pnl_InputWrapper);
			this.SplitContainer_Content.Panel1.Controls.Add(this.Pnl_InputHeader);
			this.SplitContainer_Content.Panel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
			// 
			// SplitContainer_Content.Panel2
			// 
			this.SplitContainer_Content.Panel2.Controls.Add(this.Pnl_OutputWrapper);
			this.SplitContainer_Content.Panel2.Controls.Add(this.Pnl_OutputHeader);
			this.SplitContainer_Content.Panel2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.SplitContainer_Content.Size = new System.Drawing.Size(915, 556);
			this.SplitContainer_Content.SplitterDistance = 273;
			this.SplitContainer_Content.SplitterWidth = 5;
			this.SplitContainer_Content.TabIndex = 0;
			// 
			// Pnl_InputWrapper
			// 
			this.Pnl_InputWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
			this.Pnl_InputWrapper.Controls.Add(this.TxtBx_Input);
			this.Pnl_InputWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Pnl_InputWrapper.Location = new System.Drawing.Point(0, 42);
			this.Pnl_InputWrapper.Margin = new System.Windows.Forms.Padding(4);
			this.Pnl_InputWrapper.Name = "Pnl_InputWrapper";
			this.Pnl_InputWrapper.Size = new System.Drawing.Size(915, 231);
			this.Pnl_InputWrapper.TabIndex = 7;
			// 
			// TxtBx_Input
			// 
			this.TxtBx_Input.AcceptsReturn = true;
			this.TxtBx_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBx_Input.Font = new System.Drawing.Font("Space Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtBx_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.TxtBx_Input.Location = new System.Drawing.Point(10, 10);
			this.TxtBx_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
			this.TxtBx_Input.Multiline = true;
			this.TxtBx_Input.Name = "TxtBx_Input";
			this.TxtBx_Input.Size = new System.Drawing.Size(645, 212);
			this.TxtBx_Input.TabIndex = 0;
			// 
			// Pnl_InputHeader
			// 
			this.Pnl_InputHeader.BackColor = System.Drawing.Color.DarkSlateGray;
			this.Pnl_InputHeader.Controls.Add(this.Btn_Paste);
			this.Pnl_InputHeader.Controls.Add(this.Btn_Open);
			this.Pnl_InputHeader.Controls.Add(this.Lbl_Input);
			this.Pnl_InputHeader.Controls.Add(this.Btn_ClearInput);
			this.Pnl_InputHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pnl_InputHeader.Location = new System.Drawing.Point(0, 0);
			this.Pnl_InputHeader.Margin = new System.Windows.Forms.Padding(4);
			this.Pnl_InputHeader.Name = "Pnl_InputHeader";
			this.Pnl_InputHeader.Size = new System.Drawing.Size(915, 42);
			this.Pnl_InputHeader.TabIndex = 1;
			// 
			// Btn_Paste
			// 
			this.Btn_Paste.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Btn_Paste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Btn_Paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Paste.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Btn_Paste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Btn_Paste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Paste.Location = new System.Drawing.Point(394, 6);
			this.Btn_Paste.Margin = new System.Windows.Forms.Padding(4);
			this.Btn_Paste.Name = "Btn_Paste";
			this.Btn_Paste.Size = new System.Drawing.Size(62, 30);
			this.Btn_Paste.TabIndex = 3;
			this.Btn_Paste.Text = "Paste";
			this.Btn_Paste.UseMnemonic = false;
			this.Btn_Paste.UseVisualStyleBackColor = false;
			// 
			// Btn_Open
			// 
			this.Btn_Open.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Btn_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Open.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Btn_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Btn_Open.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Open.Location = new System.Drawing.Point(464, 6);
			this.Btn_Open.Margin = new System.Windows.Forms.Padding(4);
			this.Btn_Open.Name = "Btn_Open";
			this.Btn_Open.Size = new System.Drawing.Size(125, 30);
			this.Btn_Open.TabIndex = 1;
			this.Btn_Open.Text = "Open File";
			this.Btn_Open.UseVisualStyleBackColor = false;
			// 
			// Pnl_OutputWrapper
			// 
			this.Pnl_OutputWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
			this.Pnl_OutputWrapper.Controls.Add(this.TxtBx_Output);
			this.Pnl_OutputWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Pnl_OutputWrapper.Location = new System.Drawing.Point(0, 42);
			this.Pnl_OutputWrapper.Margin = new System.Windows.Forms.Padding(4);
			this.Pnl_OutputWrapper.Name = "Pnl_OutputWrapper";
			this.Pnl_OutputWrapper.Size = new System.Drawing.Size(915, 236);
			this.Pnl_OutputWrapper.TabIndex = 8;
			// 
			// TxtBx_Output
			// 
			this.TxtBx_Output.AcceptsReturn = true;
			this.TxtBx_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBx_Output.Font = new System.Drawing.Font("Space Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtBx_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.TxtBx_Output.Location = new System.Drawing.Point(10, 10);
			this.TxtBx_Output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
			this.TxtBx_Output.Multiline = true;
			this.TxtBx_Output.Name = "TxtBx_Output";
			this.TxtBx_Output.Size = new System.Drawing.Size(645, 213);
			this.TxtBx_Output.TabIndex = 0;
			// 
			// Pnl_OutputHeader
			// 
			this.Pnl_OutputHeader.BackColor = System.Drawing.Color.DarkSlateGray;
			this.Pnl_OutputHeader.Controls.Add(this.Btn_Copy);
			this.Pnl_OutputHeader.Controls.Add(this.Btn_Save);
			this.Pnl_OutputHeader.Controls.Add(this.Lbl_Output);
			this.Pnl_OutputHeader.Controls.Add(this.Btn_ClearOutput);
			this.Pnl_OutputHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pnl_OutputHeader.Location = new System.Drawing.Point(0, 0);
			this.Pnl_OutputHeader.Margin = new System.Windows.Forms.Padding(4);
			this.Pnl_OutputHeader.Name = "Pnl_OutputHeader";
			this.Pnl_OutputHeader.Size = new System.Drawing.Size(915, 42);
			this.Pnl_OutputHeader.TabIndex = 1;
			// 
			// Btn_Copy
			// 
			this.Btn_Copy.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Btn_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Btn_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Copy.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Btn_Copy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Btn_Copy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Copy.Location = new System.Drawing.Point(394, 6);
			this.Btn_Copy.Margin = new System.Windows.Forms.Padding(4);
			this.Btn_Copy.Name = "Btn_Copy";
			this.Btn_Copy.Size = new System.Drawing.Size(62, 30);
			this.Btn_Copy.TabIndex = 4;
			this.Btn_Copy.Text = "Copy";
			this.Btn_Copy.UseMnemonic = false;
			this.Btn_Copy.UseVisualStyleBackColor = false;
			// 
			// Btn_Save
			// 
			this.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Save.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Save.Location = new System.Drawing.Point(464, 6);
			this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(125, 30);
			this.Btn_Save.TabIndex = 0;
			this.Btn_Save.Text = "Save to File";
			this.Btn_Save.UseVisualStyleBackColor = false;
			// 
			// Pnl_Options
			// 
			this.Pnl_Options.BackColor = System.Drawing.SystemColors.Window;
			this.Pnl_Options.Controls.Add(this.ChkBx_Copy);
			this.Pnl_Options.Controls.Add(this.Pnl_AesWrapper);
			this.Pnl_Options.Controls.Add(this.Btn_Run);
			this.Pnl_Options.Controls.Add(this.DrpDn_Mode);
			this.Pnl_Options.Controls.Add(this.Rdo_Decode);
			this.Pnl_Options.Controls.Add(this.Rdo_Encode);
			this.Pnl_Options.Controls.Add(this.Pnl_OptionsHeader);
			this.Pnl_Options.Dock = System.Windows.Forms.DockStyle.Right;
			this.Pnl_Options.Location = new System.Drawing.Point(665, 0);
			this.Pnl_Options.Margin = new System.Windows.Forms.Padding(4);
			this.Pnl_Options.Name = "Pnl_Options";
			this.Pnl_Options.Size = new System.Drawing.Size(250, 556);
			this.Pnl_Options.TabIndex = 7;
			// 
			// ChkBx_Copy
			// 
			this.ChkBx_Copy.AutoSize = true;
			this.ChkBx_Copy.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ChkBx_Copy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.ChkBx_Copy.Location = new System.Drawing.Point(11, 119);
			this.ChkBx_Copy.Name = "ChkBx_Copy";
			this.ChkBx_Copy.Size = new System.Drawing.Size(227, 23);
			this.ChkBx_Copy.TabIndex = 8;
			this.ChkBx_Copy.Text = "Copy to clipboard when done";
			this.ChkBx_Copy.UseVisualStyleBackColor = true;
			// 
			// Pnl_AesWrapper
			// 
			this.Pnl_AesWrapper.Controls.Add(this.SplitContainer_Aes);
			this.Pnl_AesWrapper.Controls.Add(this.Lbl_AesOptions);
			this.Pnl_AesWrapper.Location = new System.Drawing.Point(8, 184);
			this.Pnl_AesWrapper.Name = "Pnl_AesWrapper";
			this.Pnl_AesWrapper.Size = new System.Drawing.Size(234, 200);
			this.Pnl_AesWrapper.TabIndex = 7;
			this.Pnl_AesWrapper.Visible = false;
			// 
			// SplitContainer_Aes
			// 
			this.SplitContainer_Aes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer_Aes.IsSplitterFixed = true;
			this.SplitContainer_Aes.Location = new System.Drawing.Point(0, 25);
			this.SplitContainer_Aes.Margin = new System.Windows.Forms.Padding(4);
			this.SplitContainer_Aes.Name = "SplitContainer_Aes";
			this.SplitContainer_Aes.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SplitContainer_Aes.Panel1
			// 
			this.SplitContainer_Aes.Panel1.Controls.Add(this.TxtBx_AesKey);
			this.SplitContainer_Aes.Panel1.Controls.Add(this.Lbl_AesKey);
			// 
			// SplitContainer_Aes.Panel2
			// 
			this.SplitContainer_Aes.Panel2.Controls.Add(this.TxtBx_AesIV);
			this.SplitContainer_Aes.Panel2.Controls.Add(this.Lbl_AesIV);
			this.SplitContainer_Aes.Size = new System.Drawing.Size(234, 175);
			this.SplitContainer_Aes.SplitterDistance = 86;
			this.SplitContainer_Aes.SplitterWidth = 5;
			this.SplitContainer_Aes.TabIndex = 1;
			// 
			// TxtBx_AesKey
			// 
			this.TxtBx_AesKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBx_AesKey.Font = new System.Drawing.Font("NK57 Monospace Sc Bk", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtBx_AesKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.TxtBx_AesKey.Location = new System.Drawing.Point(0, 19);
			this.TxtBx_AesKey.Margin = new System.Windows.Forms.Padding(4);
			this.TxtBx_AesKey.Multiline = true;
			this.TxtBx_AesKey.Name = "TxtBx_AesKey";
			this.TxtBx_AesKey.Size = new System.Drawing.Size(234, 67);
			this.TxtBx_AesKey.TabIndex = 3;
			// 
			// Lbl_AesKey
			// 
			this.Lbl_AesKey.Dock = System.Windows.Forms.DockStyle.Top;
			this.Lbl_AesKey.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lbl_AesKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Lbl_AesKey.Location = new System.Drawing.Point(0, 0);
			this.Lbl_AesKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lbl_AesKey.Name = "Lbl_AesKey";
			this.Lbl_AesKey.Size = new System.Drawing.Size(234, 19);
			this.Lbl_AesKey.TabIndex = 2;
			this.Lbl_AesKey.Text = "Key";
			// 
			// TxtBx_AesIV
			// 
			this.TxtBx_AesIV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBx_AesIV.Font = new System.Drawing.Font("NK57 Monospace Sc Bk", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtBx_AesIV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.TxtBx_AesIV.Location = new System.Drawing.Point(0, 19);
			this.TxtBx_AesIV.Margin = new System.Windows.Forms.Padding(4);
			this.TxtBx_AesIV.Multiline = true;
			this.TxtBx_AesIV.Name = "TxtBx_AesIV";
			this.TxtBx_AesIV.Size = new System.Drawing.Size(234, 65);
			this.TxtBx_AesIV.TabIndex = 3;
			// 
			// Lbl_AesIV
			// 
			this.Lbl_AesIV.Dock = System.Windows.Forms.DockStyle.Top;
			this.Lbl_AesIV.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lbl_AesIV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Lbl_AesIV.Location = new System.Drawing.Point(0, 0);
			this.Lbl_AesIV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lbl_AesIV.Name = "Lbl_AesIV";
			this.Lbl_AesIV.Size = new System.Drawing.Size(234, 19);
			this.Lbl_AesIV.TabIndex = 2;
			this.Lbl_AesIV.Text = "Initialization Vector";
			// 
			// Lbl_AesOptions
			// 
			this.Lbl_AesOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.Lbl_AesOptions.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lbl_AesOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Lbl_AesOptions.Location = new System.Drawing.Point(0, 0);
			this.Lbl_AesOptions.Name = "Lbl_AesOptions";
			this.Lbl_AesOptions.Size = new System.Drawing.Size(234, 25);
			this.Lbl_AesOptions.TabIndex = 0;
			this.Lbl_AesOptions.Text = "AES Options";
			this.Lbl_AesOptions.Click += new System.EventHandler(this.Lbl_AesOptions_Click);
			// 
			// Btn_Run
			// 
			this.Btn_Run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(249)))), ((int)(((byte)(215)))));
			this.Btn_Run.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.Btn_Run.FlatAppearance.BorderSize = 3;
			this.Btn_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Run.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Btn_Run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Btn_Run.Location = new System.Drawing.Point(8, 501);
			this.Btn_Run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
			this.Btn_Run.Name = "Btn_Run";
			this.Btn_Run.Size = new System.Drawing.Size(235, 44);
			this.Btn_Run.TabIndex = 5;
			this.Btn_Run.Text = "Run";
			this.Btn_Run.UseVisualStyleBackColor = false;
			this.Btn_Run.Click += new System.EventHandler(this.Btn_Run_Click);
			// 
			// DrpDn_Mode
			// 
			this.DrpDn_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DrpDn_Mode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.DrpDn_Mode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.DrpDn_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DrpDn_Mode.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DrpDn_Mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.DrpDn_Mode.FormattingEnabled = true;
			this.DrpDn_Mode.Items.AddRange(new object[] {
            "Morse Code",
            "Random Shift",
            "Repeated Random Shift",
            "AES Encryption"});
			this.DrpDn_Mode.Location = new System.Drawing.Point(8, 145);
			this.DrpDn_Mode.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
			this.DrpDn_Mode.Name = "DrpDn_Mode";
			this.DrpDn_Mode.Size = new System.Drawing.Size(234, 25);
			this.DrpDn_Mode.TabIndex = 3;
			this.DrpDn_Mode.SelectedIndexChanged += new System.EventHandler(this.DrpDn_Mode_Changed);
			// 
			// Rdo_Decode
			// 
			this.Rdo_Decode.AutoSize = true;
			this.Rdo_Decode.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Rdo_Decode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Rdo_Decode.Location = new System.Drawing.Point(11, 85);
			this.Rdo_Decode.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
			this.Rdo_Decode.Name = "Rdo_Decode";
			this.Rdo_Decode.Size = new System.Drawing.Size(81, 23);
			this.Rdo_Decode.TabIndex = 2;
			this.Rdo_Decode.Text = "Decode";
			this.Rdo_Decode.UseVisualStyleBackColor = true;
			// 
			// Rdo_Encode
			// 
			this.Rdo_Encode.AutoSize = true;
			this.Rdo_Encode.Checked = true;
			this.Rdo_Encode.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Rdo_Encode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Rdo_Encode.Location = new System.Drawing.Point(11, 58);
			this.Rdo_Encode.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
			this.Rdo_Encode.Name = "Rdo_Encode";
			this.Rdo_Encode.Size = new System.Drawing.Size(78, 23);
			this.Rdo_Encode.TabIndex = 1;
			this.Rdo_Encode.TabStop = true;
			this.Rdo_Encode.Text = "Encode";
			this.Rdo_Encode.UseVisualStyleBackColor = true;
			// 
			// Pnl_OptionsHeader
			// 
			this.Pnl_OptionsHeader.Controls.Add(this.Lbl_Options);
			this.Pnl_OptionsHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pnl_OptionsHeader.Location = new System.Drawing.Point(0, 0);
			this.Pnl_OptionsHeader.Margin = new System.Windows.Forms.Padding(4);
			this.Pnl_OptionsHeader.Name = "Pnl_OptionsHeader";
			this.Pnl_OptionsHeader.Size = new System.Drawing.Size(250, 42);
			this.Pnl_OptionsHeader.TabIndex = 0;
			// 
			// Lbl_Options
			// 
			this.Lbl_Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_Options.BackColor = System.Drawing.SystemColors.Window;
			this.Lbl_Options.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lbl_Options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.Lbl_Options.Location = new System.Drawing.Point(8, 8);
			this.Lbl_Options.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lbl_Options.Name = "Lbl_Options";
			this.Lbl_Options.Size = new System.Drawing.Size(94, 29);
			this.Lbl_Options.TabIndex = 5;
			this.Lbl_Options.Text = "Options";
			this.Lbl_Options.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// PrimaryWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(915, 612);
			this.Controls.Add(this.Pnl_Options);
			this.Controls.Add(this.SplitContainer_Content);
			this.Controls.Add(this.Pnl_Footer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.MinimumSize = new System.Drawing.Size(558, 488);
			this.Name = "PrimaryWindow";
			this.Text = "μEncode";
			this.ResizeEnd += new System.EventHandler(this.PrimaryWindow_ResizeEnd);
			this.Pnl_Footer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Img_Logo)).EndInit();
			this.SplitContainer_Content.Panel1.ResumeLayout(false);
			this.SplitContainer_Content.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Content)).EndInit();
			this.SplitContainer_Content.ResumeLayout(false);
			this.Pnl_InputWrapper.ResumeLayout(false);
			this.Pnl_InputWrapper.PerformLayout();
			this.Pnl_InputHeader.ResumeLayout(false);
			this.Pnl_OutputWrapper.ResumeLayout(false);
			this.Pnl_OutputWrapper.PerformLayout();
			this.Pnl_OutputHeader.ResumeLayout(false);
			this.Pnl_Options.ResumeLayout(false);
			this.Pnl_Options.PerformLayout();
			this.Pnl_AesWrapper.ResumeLayout(false);
			this.SplitContainer_Aes.Panel1.ResumeLayout(false);
			this.SplitContainer_Aes.Panel1.PerformLayout();
			this.SplitContainer_Aes.Panel2.ResumeLayout(false);
			this.SplitContainer_Aes.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Aes)).EndInit();
			this.SplitContainer_Aes.ResumeLayout(false);
			this.Pnl_OptionsHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel Pnl_Footer;
		private Label Lbl_Input;
		private Label Lbl_Output;
		private Button Btn_ClearInput;
		private Button Btn_ClearOutput;
		private SplitContainer SplitContainer_Content;
		private Panel Pnl_InputHeader;
		private Panel Pnl_OutputHeader;
		private Button Btn_Open;
		private Panel Pnl_Options;
		private Button Btn_Save;
		private RadioButton Rdo_Decode;
		private RadioButton Rdo_Encode;
		private Panel Pnl_OptionsHeader;
		private Label Lbl_Options;
		private Button Btn_Run;
		private ComboBox DrpDn_Mode;
		private Panel Pnl_InputWrapper;
		private TextBox TxtBx_Input;
		private Panel Pnl_OutputWrapper;
		private TextBox TxtBx_Output;
		private PictureBox Img_Logo;
		private Label Lbl_Title;
		private Label Lbl_Errors;
		private Button Btn_Paste;
		private Button Btn_Copy;
		private Panel Pnl_AesWrapper;
		private SplitContainer SplitContainer_Aes;
		private TextBox TxtBx_AesKey;
		private Label Lbl_AesKey;
		private TextBox TxtBx_AesIV;
		private Label Lbl_AesIV;
		private Label Lbl_AesOptions;
		private CheckBox ChkBx_Copy;
	}
}