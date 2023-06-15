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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryWindow));
			Pnl_Footer = new Panel();
			Lbl_Title = new Label();
			Img_Logo = new PictureBox();
			Lbl_Errors = new Label();
			Btn_ClearInput = new Button();
			Btn_ClearOutput = new Button();
			Lbl_Input = new Label();
			Lbl_Output = new Label();
			SplitContainer_Content = new SplitContainer();
			Pnl_InputWrapper = new Panel();
			TxtBx_Input = new TextBox();
			Pnl_InputHeader = new Panel();
			Btn_Paste = new Button();
			Btn_Open = new Button();
			Pnl_OutputWrapper = new Panel();
			TxtBx_Output = new TextBox();
			Pnl_OutputHeader = new Panel();
			Btn_Copy = new Button();
			Btn_Save = new Button();
			Pnl_Options = new Panel();
			Pnl_OptionsCommon = new Panel();
			ChkBx_Switch = new CheckBox();
			ChkBx_Copy = new CheckBox();
			Rdo_Decode = new RadioButton();
			Rdo_Encode = new RadioButton();
			Btn_Run = new Button();
			Pnl_AesWrapper = new Panel();
			SplitContainer_Aes = new SplitContainer();
			TxtBx_AesKey = new TextBox();
			Lbl_AesKey = new Label();
			TxtBx_AesIV = new TextBox();
			Lbl_AesIV = new Label();
			Pnl_AesFileHandling = new Panel();
			Btn_AesShowHide = new Button();
			Btn_AesSave = new Button();
			Btn_AesOpen = new Button();
			Lbl_AesOptions = new Label();
			DrpDn_Mode = new ComboBox();
			Pnl_OptionsHeader = new Panel();
			Lbl_Options = new Label();
			OpenFile_Input = new OpenFileDialog();
			SaveFile_Output = new SaveFileDialog();
			ToolTip_Help = new ToolTip(components);
			OpenFile_Aes = new OpenFileDialog();
			SaveFile_Aes = new SaveFileDialog();
			Pnl_Footer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Img_Logo).BeginInit();
			((System.ComponentModel.ISupportInitialize)SplitContainer_Content).BeginInit();
			SplitContainer_Content.Panel1.SuspendLayout();
			SplitContainer_Content.Panel2.SuspendLayout();
			SplitContainer_Content.SuspendLayout();
			Pnl_InputWrapper.SuspendLayout();
			Pnl_InputHeader.SuspendLayout();
			Pnl_OutputWrapper.SuspendLayout();
			Pnl_OutputHeader.SuspendLayout();
			Pnl_Options.SuspendLayout();
			Pnl_OptionsCommon.SuspendLayout();
			Pnl_AesWrapper.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer_Aes).BeginInit();
			SplitContainer_Aes.Panel1.SuspendLayout();
			SplitContainer_Aes.Panel2.SuspendLayout();
			SplitContainer_Aes.SuspendLayout();
			Pnl_AesFileHandling.SuspendLayout();
			Pnl_OptionsHeader.SuspendLayout();
			SuspendLayout();
			// 
			// Pnl_Footer
			// 
			Pnl_Footer.AllowDrop = true;
			Pnl_Footer.BackColor = Color.DarkSlateGray;
			Pnl_Footer.Controls.Add(Lbl_Title);
			Pnl_Footer.Controls.Add(Img_Logo);
			Pnl_Footer.Controls.Add(Lbl_Errors);
			Pnl_Footer.Dock = DockStyle.Bottom;
			Pnl_Footer.Location = new Point(0, 445);
			Pnl_Footer.Margin = new Padding(0);
			Pnl_Footer.Name = "Pnl_Footer";
			Pnl_Footer.Size = new Size(732, 45);
			Pnl_Footer.TabIndex = 2;
			// 
			// Lbl_Title
			// 
			Lbl_Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			Lbl_Title.Font = new Font("EB Garamond 12", 18F, FontStyle.Italic, GraphicsUnit.Point);
			Lbl_Title.ForeColor = Color.FromArgb(188, 237, 162);
			Lbl_Title.Location = new Point(610, 3);
			Lbl_Title.Margin = new Padding(3);
			Lbl_Title.Name = "Lbl_Title";
			Lbl_Title.Size = new Size(110, 39);
			Lbl_Title.TabIndex = 6;
			Lbl_Title.Text = "μEncode";
			Lbl_Title.TextAlign = ContentAlignment.MiddleRight;
			// 
			// Img_Logo
			// 
			Img_Logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			Img_Logo.Image = (Image)resources.GetObject("Img_Logo.Image");
			Img_Logo.Location = new Point(5, 5);
			Img_Logo.Name = "Img_Logo";
			Img_Logo.Size = new Size(32, 35);
			Img_Logo.SizeMode = PictureBoxSizeMode.Zoom;
			Img_Logo.TabIndex = 1;
			Img_Logo.TabStop = false;
			Img_Logo.Click += Img_Logo_Click;
			// 
			// Lbl_Errors
			// 
			Lbl_Errors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Lbl_Errors.AutoEllipsis = true;
			Lbl_Errors.Font = new Font("Segoe UI Variable Small", 8F, FontStyle.Regular, GraphicsUnit.Point);
			Lbl_Errors.ForeColor = Color.FromArgb(225, 249, 215);
			Lbl_Errors.Location = new Point(43, 5);
			Lbl_Errors.Name = "Lbl_Errors";
			Lbl_Errors.Size = new Size(570, 35);
			Lbl_Errors.TabIndex = 6;
			Lbl_Errors.DoubleClick += Lbl_Errors_DoubleClick;
			// 
			// Btn_ClearInput
			// 
			Btn_ClearInput.Anchor = AnchorStyles.Right;
			Btn_ClearInput.BackColor = Color.FromArgb(39, 49, 54);
			Btn_ClearInput.FlatStyle = FlatStyle.Flat;
			Btn_ClearInput.Font = new Font("Segoe UI Variable Small Semibol", 8F, FontStyle.Bold, GraphicsUnit.Point);
			Btn_ClearInput.ForeColor = Color.FromArgb(225, 249, 215);
			Btn_ClearInput.ImageAlign = ContentAlignment.TopCenter;
			Btn_ClearInput.Location = new Point(477, 5);
			Btn_ClearInput.Name = "Btn_ClearInput";
			Btn_ClearInput.Size = new Size(50, 24);
			Btn_ClearInput.TabIndex = 2;
			Btn_ClearInput.Text = "Clear";
			Btn_ClearInput.UseMnemonic = false;
			Btn_ClearInput.UseVisualStyleBackColor = false;
			Btn_ClearInput.Click += Btn_ClearInput_Click;
			// 
			// Btn_ClearOutput
			// 
			Btn_ClearOutput.Anchor = AnchorStyles.Right;
			Btn_ClearOutput.BackColor = Color.FromArgb(39, 49, 54);
			Btn_ClearOutput.FlatStyle = FlatStyle.Flat;
			Btn_ClearOutput.Font = new Font("Segoe UI Variable Small Semibol", 8F, FontStyle.Bold, GraphicsUnit.Point);
			Btn_ClearOutput.ForeColor = Color.FromArgb(225, 249, 215);
			Btn_ClearOutput.ImageAlign = ContentAlignment.TopCenter;
			Btn_ClearOutput.Location = new Point(477, 5);
			Btn_ClearOutput.Name = "Btn_ClearOutput";
			Btn_ClearOutput.Size = new Size(50, 24);
			Btn_ClearOutput.TabIndex = 2;
			Btn_ClearOutput.Text = "Clear";
			Btn_ClearOutput.UseVisualStyleBackColor = false;
			Btn_ClearOutput.Click += Btn_ClearOutput_Click;
			// 
			// Lbl_Input
			// 
			Lbl_Input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			Lbl_Input.BackColor = Color.DarkSlateGray;
			Lbl_Input.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Lbl_Input.ForeColor = Color.FromArgb(225, 249, 215);
			Lbl_Input.Location = new Point(6, 6);
			Lbl_Input.Name = "Lbl_Input";
			Lbl_Input.Size = new Size(75, 23);
			Lbl_Input.TabIndex = 1;
			Lbl_Input.Text = "Input";
			Lbl_Input.TextAlign = ContentAlignment.BottomLeft;
			// 
			// Lbl_Output
			// 
			Lbl_Output.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			Lbl_Output.BackColor = Color.DarkSlateGray;
			Lbl_Output.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Lbl_Output.ForeColor = Color.FromArgb(225, 249, 215);
			Lbl_Output.Location = new Point(6, 6);
			Lbl_Output.Name = "Lbl_Output";
			Lbl_Output.Size = new Size(75, 23);
			Lbl_Output.TabIndex = 2;
			Lbl_Output.Text = "Output";
			Lbl_Output.TextAlign = ContentAlignment.BottomLeft;
			// 
			// SplitContainer_Content
			// 
			SplitContainer_Content.Dock = DockStyle.Fill;
			SplitContainer_Content.Location = new Point(0, 0);
			SplitContainer_Content.Name = "SplitContainer_Content";
			SplitContainer_Content.Orientation = Orientation.Horizontal;
			// 
			// SplitContainer_Content.Panel1
			// 
			SplitContainer_Content.Panel1.Controls.Add(Pnl_InputWrapper);
			SplitContainer_Content.Panel1.Controls.Add(Pnl_InputHeader);
			SplitContainer_Content.Panel1.Margin = new Padding(0, 3, 0, 0);
			// 
			// SplitContainer_Content.Panel2
			// 
			SplitContainer_Content.Panel2.Controls.Add(Pnl_OutputWrapper);
			SplitContainer_Content.Panel2.Controls.Add(Pnl_OutputHeader);
			SplitContainer_Content.Panel2.Margin = new Padding(0, 3, 0, 0);
			SplitContainer_Content.Size = new Size(732, 445);
			SplitContainer_Content.SplitterDistance = 218;
			SplitContainer_Content.TabIndex = 0;
			// 
			// Pnl_InputWrapper
			// 
			Pnl_InputWrapper.BackColor = Color.FromArgb(209, 222, 211);
			Pnl_InputWrapper.Controls.Add(TxtBx_Input);
			Pnl_InputWrapper.Dock = DockStyle.Fill;
			Pnl_InputWrapper.Location = new Point(0, 34);
			Pnl_InputWrapper.Name = "Pnl_InputWrapper";
			Pnl_InputWrapper.Size = new Size(732, 184);
			Pnl_InputWrapper.TabIndex = 7;
			// 
			// TxtBx_Input
			// 
			TxtBx_Input.AcceptsReturn = true;
			TxtBx_Input.AcceptsTab = true;
			TxtBx_Input.AllowDrop = true;
			TxtBx_Input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			TxtBx_Input.Font = new Font("Space Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
			TxtBx_Input.ForeColor = Color.FromArgb(39, 49, 54);
			TxtBx_Input.Location = new Point(8, 8);
			TxtBx_Input.Margin = new Padding(3, 3, 3, 6);
			TxtBx_Input.Multiline = true;
			TxtBx_Input.Name = "TxtBx_Input";
			TxtBx_Input.Size = new Size(517, 169);
			TxtBx_Input.TabIndex = 0;
			TxtBx_Input.TextChanged += TxtBx_Input_TextChanged;
			TxtBx_Input.DragDrop += Input_DragDrop;
			TxtBx_Input.DragEnter += Input_DragEnter;
			TxtBx_Input.DragLeave += Input_DragLeave;
			// 
			// Pnl_InputHeader
			// 
			Pnl_InputHeader.BackColor = Color.DarkSlateGray;
			Pnl_InputHeader.Controls.Add(Btn_Paste);
			Pnl_InputHeader.Controls.Add(Btn_Open);
			Pnl_InputHeader.Controls.Add(Lbl_Input);
			Pnl_InputHeader.Controls.Add(Btn_ClearInput);
			Pnl_InputHeader.Dock = DockStyle.Top;
			Pnl_InputHeader.Location = new Point(0, 0);
			Pnl_InputHeader.Name = "Pnl_InputHeader";
			Pnl_InputHeader.Size = new Size(732, 34);
			Pnl_InputHeader.TabIndex = 1;
			// 
			// Btn_Paste
			// 
			Btn_Paste.Anchor = AnchorStyles.Right;
			Btn_Paste.BackColor = Color.FromArgb(39, 49, 54);
			Btn_Paste.FlatStyle = FlatStyle.Flat;
			Btn_Paste.Font = new Font("Segoe UI Variable Small Semibol", 8F, FontStyle.Bold, GraphicsUnit.Point);
			Btn_Paste.ForeColor = Color.FromArgb(225, 249, 215);
			Btn_Paste.ImageAlign = ContentAlignment.TopCenter;
			Btn_Paste.Location = new Point(315, 5);
			Btn_Paste.Name = "Btn_Paste";
			Btn_Paste.Size = new Size(50, 24);
			Btn_Paste.TabIndex = 0;
			Btn_Paste.Text = "Paste";
			Btn_Paste.UseMnemonic = false;
			Btn_Paste.UseVisualStyleBackColor = false;
			Btn_Paste.Click += Btn_Paste_Click;
			// 
			// Btn_Open
			// 
			Btn_Open.Anchor = AnchorStyles.Right;
			Btn_Open.BackColor = Color.FromArgb(39, 49, 54);
			Btn_Open.FlatStyle = FlatStyle.Flat;
			Btn_Open.Font = new Font("Segoe UI Variable Small Semibol", 8F, FontStyle.Bold, GraphicsUnit.Point);
			Btn_Open.ForeColor = Color.FromArgb(225, 249, 215);
			Btn_Open.ImageAlign = ContentAlignment.TopCenter;
			Btn_Open.Location = new Point(371, 5);
			Btn_Open.Name = "Btn_Open";
			Btn_Open.Size = new Size(100, 24);
			Btn_Open.TabIndex = 1;
			Btn_Open.Text = "Open File";
			Btn_Open.UseVisualStyleBackColor = false;
			Btn_Open.Click += Btn_Open_Click;
			// 
			// Pnl_OutputWrapper
			// 
			Pnl_OutputWrapper.BackColor = Color.FromArgb(209, 222, 211);
			Pnl_OutputWrapper.Controls.Add(TxtBx_Output);
			Pnl_OutputWrapper.Dock = DockStyle.Fill;
			Pnl_OutputWrapper.Location = new Point(0, 34);
			Pnl_OutputWrapper.Name = "Pnl_OutputWrapper";
			Pnl_OutputWrapper.Size = new Size(732, 189);
			Pnl_OutputWrapper.TabIndex = 1;
			// 
			// TxtBx_Output
			// 
			TxtBx_Output.AcceptsReturn = true;
			TxtBx_Output.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			TxtBx_Output.Font = new Font("Space Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
			TxtBx_Output.ForeColor = Color.FromArgb(39, 49, 54);
			TxtBx_Output.Location = new Point(8, 8);
			TxtBx_Output.Margin = new Padding(3, 3, 3, 6);
			TxtBx_Output.Multiline = true;
			TxtBx_Output.Name = "TxtBx_Output";
			TxtBx_Output.Size = new Size(517, 171);
			TxtBx_Output.TabIndex = 0;
			TxtBx_Output.TextChanged += TxtBx_Output_TextChanged;
			// 
			// Pnl_OutputHeader
			// 
			Pnl_OutputHeader.BackColor = Color.DarkSlateGray;
			Pnl_OutputHeader.Controls.Add(Btn_Copy);
			Pnl_OutputHeader.Controls.Add(Btn_Save);
			Pnl_OutputHeader.Controls.Add(Lbl_Output);
			Pnl_OutputHeader.Controls.Add(Btn_ClearOutput);
			Pnl_OutputHeader.Dock = DockStyle.Top;
			Pnl_OutputHeader.Location = new Point(0, 0);
			Pnl_OutputHeader.Name = "Pnl_OutputHeader";
			Pnl_OutputHeader.Size = new Size(732, 34);
			Pnl_OutputHeader.TabIndex = 0;
			// 
			// Btn_Copy
			// 
			Btn_Copy.Anchor = AnchorStyles.Right;
			Btn_Copy.BackColor = Color.FromArgb(39, 49, 54);
			Btn_Copy.FlatStyle = FlatStyle.Flat;
			Btn_Copy.Font = new Font("Segoe UI Variable Small Semibol", 8F, FontStyle.Bold, GraphicsUnit.Point);
			Btn_Copy.ForeColor = Color.FromArgb(225, 249, 215);
			Btn_Copy.ImageAlign = ContentAlignment.TopCenter;
			Btn_Copy.Location = new Point(315, 5);
			Btn_Copy.Name = "Btn_Copy";
			Btn_Copy.Size = new Size(50, 24);
			Btn_Copy.TabIndex = 0;
			Btn_Copy.Text = "Copy";
			Btn_Copy.UseMnemonic = false;
			Btn_Copy.UseVisualStyleBackColor = false;
			Btn_Copy.Click += Btn_Copy_Click;
			// 
			// Btn_Save
			// 
			Btn_Save.Anchor = AnchorStyles.Right;
			Btn_Save.BackColor = Color.FromArgb(39, 49, 54);
			Btn_Save.FlatStyle = FlatStyle.Flat;
			Btn_Save.Font = new Font("Segoe UI Variable Small Semibol", 8F, FontStyle.Bold, GraphicsUnit.Point);
			Btn_Save.ForeColor = Color.FromArgb(225, 249, 215);
			Btn_Save.ImageAlign = ContentAlignment.TopCenter;
			Btn_Save.Location = new Point(371, 5);
			Btn_Save.Name = "Btn_Save";
			Btn_Save.Size = new Size(100, 24);
			Btn_Save.TabIndex = 1;
			Btn_Save.Text = "Save to File";
			Btn_Save.UseVisualStyleBackColor = false;
			Btn_Save.Click += Btn_Save_Click;
			// 
			// Pnl_Options
			// 
			Pnl_Options.BackColor = SystemColors.Window;
			Pnl_Options.Controls.Add(Pnl_OptionsCommon);
			Pnl_Options.Controls.Add(Btn_Run);
			Pnl_Options.Controls.Add(Pnl_AesWrapper);
			Pnl_Options.Controls.Add(DrpDn_Mode);
			Pnl_Options.Controls.Add(Pnl_OptionsHeader);
			Pnl_Options.Dock = DockStyle.Right;
			Pnl_Options.Location = new Point(532, 0);
			Pnl_Options.Name = "Pnl_Options";
			Pnl_Options.Size = new Size(200, 445);
			Pnl_Options.TabIndex = 7;
			// 
			// Pnl_OptionsCommon
			// 
			Pnl_OptionsCommon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			Pnl_OptionsCommon.Controls.Add(ChkBx_Switch);
			Pnl_OptionsCommon.Controls.Add(ChkBx_Copy);
			Pnl_OptionsCommon.Controls.Add(Rdo_Decode);
			Pnl_OptionsCommon.Controls.Add(Rdo_Encode);
			Pnl_OptionsCommon.Location = new Point(6, 39);
			Pnl_OptionsCommon.Margin = new Padding(6);
			Pnl_OptionsCommon.Name = "Pnl_OptionsCommon";
			Pnl_OptionsCommon.Size = new Size(188, 82);
			Pnl_OptionsCommon.TabIndex = 0;
			// 
			// ChkBx_Switch
			// 
			ChkBx_Switch.AutoSize = true;
			ChkBx_Switch.Font = new Font("Segoe UI Variable Small", 8F, FontStyle.Regular, GraphicsUnit.Point);
			ChkBx_Switch.ForeColor = Color.FromArgb(39, 49, 54);
			ChkBx_Switch.Location = new Point(3, 61);
			ChkBx_Switch.Margin = new Padding(3, 0, 3, 0);
			ChkBx_Switch.Name = "ChkBx_Switch";
			ChkBx_Switch.Size = new Size(149, 19);
			ChkBx_Switch.TabIndex = 3;
			ChkBx_Switch.Text = "Switch mode when done";
			ChkBx_Switch.UseVisualStyleBackColor = true;
			// 
			// ChkBx_Copy
			// 
			ChkBx_Copy.AutoSize = true;
			ChkBx_Copy.Font = new Font("Segoe UI Variable Small", 8F, FontStyle.Regular, GraphicsUnit.Point);
			ChkBx_Copy.ForeColor = Color.FromArgb(39, 49, 54);
			ChkBx_Copy.Location = new Point(3, 42);
			ChkBx_Copy.Margin = new Padding(3, 0, 3, 0);
			ChkBx_Copy.Name = "ChkBx_Copy";
			ChkBx_Copy.Size = new Size(142, 19);
			ChkBx_Copy.TabIndex = 2;
			ChkBx_Copy.Text = "Copy result when done";
			ChkBx_Copy.UseVisualStyleBackColor = true;
			// 
			// Rdo_Decode
			// 
			Rdo_Decode.AutoSize = true;
			Rdo_Decode.Font = new Font("Segoe UI Variable Small", 8F, FontStyle.Regular, GraphicsUnit.Point);
			Rdo_Decode.ForeColor = Color.FromArgb(39, 49, 54);
			Rdo_Decode.Location = new Point(3, 21);
			Rdo_Decode.Margin = new Padding(3, 0, 3, 3);
			Rdo_Decode.Name = "Rdo_Decode";
			Rdo_Decode.Size = new Size(64, 19);
			Rdo_Decode.TabIndex = 1;
			Rdo_Decode.Text = "Decode";
			Rdo_Decode.UseVisualStyleBackColor = true;
			// 
			// Rdo_Encode
			// 
			Rdo_Encode.AutoSize = true;
			Rdo_Encode.Checked = true;
			Rdo_Encode.Font = new Font("Segoe UI Variable Small", 8F, FontStyle.Regular, GraphicsUnit.Point);
			Rdo_Encode.ForeColor = Color.FromArgb(39, 49, 54);
			Rdo_Encode.Location = new Point(3, 2);
			Rdo_Encode.Margin = new Padding(3, 0, 3, 0);
			Rdo_Encode.Name = "Rdo_Encode";
			Rdo_Encode.Size = new Size(62, 19);
			Rdo_Encode.TabIndex = 0;
			Rdo_Encode.TabStop = true;
			Rdo_Encode.Text = "Encode";
			Rdo_Encode.UseVisualStyleBackColor = true;
			// 
			// Btn_Run
			// 
			Btn_Run.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Btn_Run.BackColor = Color.FromArgb(225, 249, 215);
			Btn_Run.FlatAppearance.BorderColor = Color.DarkSlateGray;
			Btn_Run.FlatAppearance.BorderSize = 3;
			Btn_Run.FlatStyle = FlatStyle.Flat;
			Btn_Run.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Btn_Run.ForeColor = Color.FromArgb(39, 49, 54);
			Btn_Run.Location = new Point(6, 400);
			Btn_Run.Margin = new Padding(3, 3, 3, 6);
			Btn_Run.Name = "Btn_Run";
			Btn_Run.Size = new Size(188, 34);
			Btn_Run.TabIndex = 2;
			Btn_Run.Text = "Run";
			Btn_Run.UseVisualStyleBackColor = false;
			Btn_Run.Click += Btn_Run_Click;
			// 
			// Pnl_AesWrapper
			// 
			Pnl_AesWrapper.AllowDrop = true;
			Pnl_AesWrapper.Controls.Add(SplitContainer_Aes);
			Pnl_AesWrapper.Controls.Add(Pnl_AesFileHandling);
			Pnl_AesWrapper.Controls.Add(Lbl_AesOptions);
			Pnl_AesWrapper.Location = new Point(6, 167);
			Pnl_AesWrapper.Margin = new Padding(6);
			Pnl_AesWrapper.Name = "Pnl_AesWrapper";
			Pnl_AesWrapper.Size = new Size(188, 177);
			Pnl_AesWrapper.TabIndex = 3;
			Pnl_AesWrapper.Visible = false;
			Pnl_AesWrapper.DragDrop += Aes_DragDrop;
			Pnl_AesWrapper.DragEnter += Aes_DragEnter;
			Pnl_AesWrapper.DragLeave += Aes_DragLeave;
			// 
			// SplitContainer_Aes
			// 
			SplitContainer_Aes.Dock = DockStyle.Fill;
			SplitContainer_Aes.IsSplitterFixed = true;
			SplitContainer_Aes.Location = new Point(0, 51);
			SplitContainer_Aes.Name = "SplitContainer_Aes";
			SplitContainer_Aes.Orientation = Orientation.Horizontal;
			// 
			// SplitContainer_Aes.Panel1
			// 
			SplitContainer_Aes.Panel1.Controls.Add(TxtBx_AesKey);
			SplitContainer_Aes.Panel1.Controls.Add(Lbl_AesKey);
			// 
			// SplitContainer_Aes.Panel2
			// 
			SplitContainer_Aes.Panel2.Controls.Add(TxtBx_AesIV);
			SplitContainer_Aes.Panel2.Controls.Add(Lbl_AesIV);
			SplitContainer_Aes.Size = new Size(188, 126);
			SplitContainer_Aes.SplitterDistance = 60;
			SplitContainer_Aes.TabIndex = 1;
			// 
			// TxtBx_AesKey
			// 
			TxtBx_AesKey.Dock = DockStyle.Fill;
			TxtBx_AesKey.Font = new Font("NK57 Monospace Sc Bk", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
			TxtBx_AesKey.ForeColor = Color.FromArgb(39, 49, 54);
			TxtBx_AesKey.Location = new Point(0, 15);
			TxtBx_AesKey.Multiline = true;
			TxtBx_AesKey.Name = "TxtBx_AesKey";
			TxtBx_AesKey.Size = new Size(188, 45);
			TxtBx_AesKey.TabIndex = 0;
			// 
			// Lbl_AesKey
			// 
			Lbl_AesKey.Dock = DockStyle.Top;
			Lbl_AesKey.Font = new Font("Segoe UI Variable Small", 8F, FontStyle.Regular, GraphicsUnit.Point);
			Lbl_AesKey.ForeColor = Color.FromArgb(39, 49, 54);
			Lbl_AesKey.Location = new Point(0, 0);
			Lbl_AesKey.Name = "Lbl_AesKey";
			Lbl_AesKey.Size = new Size(188, 15);
			Lbl_AesKey.TabIndex = 2;
			Lbl_AesKey.Text = "Key";
			// 
			// TxtBx_AesIV
			// 
			TxtBx_AesIV.Dock = DockStyle.Fill;
			TxtBx_AesIV.Font = new Font("NK57 Monospace Sc Bk", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
			TxtBx_AesIV.ForeColor = Color.FromArgb(39, 49, 54);
			TxtBx_AesIV.Location = new Point(0, 15);
			TxtBx_AesIV.Multiline = true;
			TxtBx_AesIV.Name = "TxtBx_AesIV";
			TxtBx_AesIV.Size = new Size(188, 47);
			TxtBx_AesIV.TabIndex = 1;
			// 
			// Lbl_AesIV
			// 
			Lbl_AesIV.Dock = DockStyle.Top;
			Lbl_AesIV.Font = new Font("Segoe UI Variable Small", 8F, FontStyle.Regular, GraphicsUnit.Point);
			Lbl_AesIV.ForeColor = Color.FromArgb(39, 49, 54);
			Lbl_AesIV.Location = new Point(0, 0);
			Lbl_AesIV.Name = "Lbl_AesIV";
			Lbl_AesIV.Size = new Size(188, 15);
			Lbl_AesIV.TabIndex = 2;
			Lbl_AesIV.Text = "Initialization Vector";
			// 
			// Pnl_AesFileHandling
			// 
			Pnl_AesFileHandling.Controls.Add(Btn_AesShowHide);
			Pnl_AesFileHandling.Controls.Add(Btn_AesSave);
			Pnl_AesFileHandling.Controls.Add(Btn_AesOpen);
			Pnl_AesFileHandling.Dock = DockStyle.Top;
			Pnl_AesFileHandling.Location = new Point(0, 20);
			Pnl_AesFileHandling.Name = "Pnl_AesFileHandling";
			Pnl_AesFileHandling.Size = new Size(188, 31);
			Pnl_AesFileHandling.TabIndex = 2;
			// 
			// Btn_AesShowHide
			// 
			Btn_AesShowHide.Location = new Point(99, 3);
			Btn_AesShowHide.Name = "Btn_AesShowHide";
			Btn_AesShowHide.Size = new Size(86, 25);
			Btn_AesShowHide.TabIndex = 2;
			Btn_AesShowHide.Text = "Hide Text";
			Btn_AesShowHide.UseVisualStyleBackColor = true;
			Btn_AesShowHide.Click += Btn_AesShowHide_Click;
			// 
			// Btn_AesSave
			// 
			Btn_AesSave.Location = new Point(51, 3);
			Btn_AesSave.Margin = new Padding(3, 3, 0, 3);
			Btn_AesSave.Name = "Btn_AesSave";
			Btn_AesSave.Size = new Size(45, 25);
			Btn_AesSave.TabIndex = 1;
			Btn_AesSave.Text = "Save";
			Btn_AesSave.UseVisualStyleBackColor = true;
			Btn_AesSave.Click += Btn_AesSave_Click;
			// 
			// Btn_AesOpen
			// 
			Btn_AesOpen.Location = new Point(3, 3);
			Btn_AesOpen.Margin = new Padding(3, 3, 0, 3);
			Btn_AesOpen.Name = "Btn_AesOpen";
			Btn_AesOpen.Size = new Size(45, 25);
			Btn_AesOpen.TabIndex = 0;
			Btn_AesOpen.Text = "Open";
			Btn_AesOpen.UseVisualStyleBackColor = true;
			Btn_AesOpen.Click += Btn_AesOpen_Click;
			// 
			// Lbl_AesOptions
			// 
			Lbl_AesOptions.Dock = DockStyle.Top;
			Lbl_AesOptions.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
			Lbl_AesOptions.ForeColor = Color.FromArgb(39, 49, 54);
			Lbl_AesOptions.Location = new Point(0, 0);
			Lbl_AesOptions.Margin = new Padding(2, 0, 2, 0);
			Lbl_AesOptions.Name = "Lbl_AesOptions";
			Lbl_AesOptions.Size = new Size(188, 20);
			Lbl_AesOptions.TabIndex = 0;
			Lbl_AesOptions.Text = "AES Options";
			// 
			// DrpDn_Mode
			// 
			DrpDn_Mode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			DrpDn_Mode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			DrpDn_Mode.AutoCompleteSource = AutoCompleteSource.ListItems;
			DrpDn_Mode.DropDownStyle = ComboBoxStyle.DropDownList;
			DrpDn_Mode.Font = new Font("Segoe UI Variable Small", 8F, FontStyle.Regular, GraphicsUnit.Point);
			DrpDn_Mode.ForeColor = Color.FromArgb(39, 49, 54);
			DrpDn_Mode.FormattingEnabled = true;
			DrpDn_Mode.Items.AddRange(new object[] { "Morse Code", "Random Shift", "Repeated Random Shift", "AES Encryption" });
			DrpDn_Mode.Location = new Point(6, 134);
			DrpDn_Mode.Margin = new Padding(6);
			DrpDn_Mode.Name = "DrpDn_Mode";
			DrpDn_Mode.Size = new Size(189, 23);
			DrpDn_Mode.TabIndex = 1;
			DrpDn_Mode.SelectedIndexChanged += DrpDn_Mode_Changed;
			// 
			// Pnl_OptionsHeader
			// 
			Pnl_OptionsHeader.Controls.Add(Lbl_Options);
			Pnl_OptionsHeader.Dock = DockStyle.Top;
			Pnl_OptionsHeader.Location = new Point(0, 0);
			Pnl_OptionsHeader.Name = "Pnl_OptionsHeader";
			Pnl_OptionsHeader.Size = new Size(200, 34);
			Pnl_OptionsHeader.TabIndex = 0;
			// 
			// Lbl_Options
			// 
			Lbl_Options.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			Lbl_Options.BackColor = SystemColors.Window;
			Lbl_Options.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Lbl_Options.ForeColor = Color.FromArgb(39, 49, 54);
			Lbl_Options.Location = new Point(6, 6);
			Lbl_Options.Name = "Lbl_Options";
			Lbl_Options.Size = new Size(75, 23);
			Lbl_Options.TabIndex = 5;
			Lbl_Options.Text = "Options";
			Lbl_Options.TextAlign = ContentAlignment.BottomLeft;
			// 
			// OpenFile_Input
			// 
			OpenFile_Input.Title = "Open File";
			OpenFile_Input.FileOk += OpenFile_Input_FileOk;
			// 
			// SaveFile_Output
			// 
			SaveFile_Output.DefaultExt = "txt";
			SaveFile_Output.Title = "Save Output";
			SaveFile_Output.FileOk += SaveFile_Output_FileOk;
			// 
			// ToolTip_Help
			// 
			ToolTip_Help.AutomaticDelay = 200;
			// 
			// OpenFile_Aes
			// 
			OpenFile_Aes.FileName = "openFileDialog1";
			OpenFile_Aes.Title = "Open AES Encryption Information File";
			OpenFile_Aes.FileOk += OpenFile_Aes_FileOk;
			// 
			// SaveFile_Aes
			// 
			SaveFile_Aes.DefaultExt = "txt";
			SaveFile_Aes.Title = "Save AES Encryption Information";
			SaveFile_Aes.FileOk += SaveFile_Aes_FileOk;
			// 
			// PrimaryWindow
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(732, 490);
			Controls.Add(Pnl_Options);
			Controls.Add(SplitContainer_Content);
			Controls.Add(Pnl_Footer);
			HelpButton = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			Margin = new Padding(3, 2, 3, 2);
			MinimumSize = new Size(450, 398);
			Name = "PrimaryWindow";
			Text = "μEncode";
			ResizeEnd += PrimaryWindow_ResizeEnd;
			Pnl_Footer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)Img_Logo).EndInit();
			SplitContainer_Content.Panel1.ResumeLayout(false);
			SplitContainer_Content.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainer_Content).EndInit();
			SplitContainer_Content.ResumeLayout(false);
			Pnl_InputWrapper.ResumeLayout(false);
			Pnl_InputWrapper.PerformLayout();
			Pnl_InputHeader.ResumeLayout(false);
			Pnl_OutputWrapper.ResumeLayout(false);
			Pnl_OutputWrapper.PerformLayout();
			Pnl_OutputHeader.ResumeLayout(false);
			Pnl_Options.ResumeLayout(false);
			Pnl_OptionsCommon.ResumeLayout(false);
			Pnl_OptionsCommon.PerformLayout();
			Pnl_AesWrapper.ResumeLayout(false);
			SplitContainer_Aes.Panel1.ResumeLayout(false);
			SplitContainer_Aes.Panel1.PerformLayout();
			SplitContainer_Aes.Panel2.ResumeLayout(false);
			SplitContainer_Aes.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer_Aes).EndInit();
			SplitContainer_Aes.ResumeLayout(false);
			Pnl_AesFileHandling.ResumeLayout(false);
			Pnl_OptionsHeader.ResumeLayout(false);
			ResumeLayout(false);
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
		private CheckBox ChkBx_Switch;
		private Panel Pnl_OptionsCommon;
		private OpenFileDialog OpenFile_Input;
		private SaveFileDialog SaveFile_Output;
		private ToolTip ToolTip_Help;
		private Panel Pnl_AesFileHandling;
		private Button Btn_AesSave;
		private Button Btn_AesOpen;
		private Button Btn_AesShowHide;
		private OpenFileDialog OpenFile_Aes;
		private SaveFileDialog SaveFile_Aes;
	}
}