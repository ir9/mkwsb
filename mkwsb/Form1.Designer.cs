namespace mkwsb
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonClipboardRedirectionE = new System.Windows.Forms.RadioButton();
			this.radioButtonClipboardRedirectionD = new System.Windows.Forms.RadioButton();
			this.radioButtonClipboardRedirectionN = new System.Windows.Forms.RadioButton();
			this.radioButtonPrinterRedirectionE = new System.Windows.Forms.RadioButton();
			this.radioButtonPrinterRedirectionD = new System.Windows.Forms.RadioButton();
			this.radioButtonPrinterRedirectionN = new System.Windows.Forms.RadioButton();
			this.radioButtonProtectedClientE = new System.Windows.Forms.RadioButton();
			this.radioButtonProtectedClientD = new System.Windows.Forms.RadioButton();
			this.radioButtonProtectedClientN = new System.Windows.Forms.RadioButton();
			this.radioButtonVideoInputE = new System.Windows.Forms.RadioButton();
			this.radioButtonVideoInputD = new System.Windows.Forms.RadioButton();
			this.radioButtonVideoInputN = new System.Windows.Forms.RadioButton();
			this.radioButtonAudioInputE = new System.Windows.Forms.RadioButton();
			this.radioButtonAudioInputD = new System.Windows.Forms.RadioButton();
			this.radioButtonAudioInputN = new System.Windows.Forms.RadioButton();
			this.labelClipboardRedirection = new System.Windows.Forms.Label();
			this.labelvGPU = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelNetworking = new System.Windows.Forms.Label();
			this.labelAudioInput = new System.Windows.Forms.Label();
			this.labelVideoInput = new System.Windows.Forms.Label();
			this.labelProtectedClient = new System.Windows.Forms.Label();
			this.labelPrinterRedirection = new System.Windows.Forms.Label();
			this.radioButtonvGPUE = new System.Windows.Forms.RadioButton();
			this.radioButtonvGPUD = new System.Windows.Forms.RadioButton();
			this.radioButtonvGPUN = new System.Windows.Forms.RadioButton();
			this.radioButtonNetworkingN = new System.Windows.Forms.RadioButton();
			this.radioButtonNetworkingD = new System.Windows.Forms.RadioButton();
			this.radioButtonNetworkingE = new System.Windows.Forms.RadioButton();
			this.buttonSave = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gridViewDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.readonlyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.mappingTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new mkwsb.DataSet1();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxLogonCommand = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonLogonCommand = new System.Windows.Forms.Button();
			this.openFileDialogLogonCommand = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogWSB = new System.Windows.Forms.SaveFileDialog();
			this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guest = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.buttonAddHostPath = new System.Windows.Forms.Button();
			this.buttonAddBlankRecord = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDownMemoryInMB = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mappingTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemoryInMB)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.radioButtonClipboardRedirectionE, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonClipboardRedirectionD, 2, 7);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonClipboardRedirectionN, 3, 7);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonPrinterRedirectionE, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonPrinterRedirectionD, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonPrinterRedirectionN, 3, 6);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonProtectedClientE, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonProtectedClientD, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonProtectedClientN, 3, 5);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonVideoInputE, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonVideoInputD, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonVideoInputN, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonAudioInputE, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonAudioInputD, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonAudioInputN, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelClipboardRedirection, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelvGPU, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelNetworking, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelAudioInput, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelVideoInput, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelProtectedClient, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelPrinterRedirection, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonvGPUE, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonvGPUD, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonvGPUN, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonNetworkingN, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonNetworkingD, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonNetworkingE, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 217);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// radioButtonClipboardRedirectionE
			// 
			this.radioButtonClipboardRedirectionE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonClipboardRedirectionE.AutoCheck = false;
			this.radioButtonClipboardRedirectionE.AutoSize = true;
			this.radioButtonClipboardRedirectionE.Location = new System.Drawing.Point(147, 196);
			this.radioButtonClipboardRedirectionE.Name = "radioButtonClipboardRedirectionE";
			this.radioButtonClipboardRedirectionE.Size = new System.Drawing.Size(14, 13);
			this.radioButtonClipboardRedirectionE.TabIndex = 18;
			this.radioButtonClipboardRedirectionE.TabStop = true;
			this.radioButtonClipboardRedirectionE.UseVisualStyleBackColor = true;
			this.radioButtonClipboardRedirectionE.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonClipboardRedirectionD
			// 
			this.radioButtonClipboardRedirectionD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonClipboardRedirectionD.AutoCheck = false;
			this.radioButtonClipboardRedirectionD.AutoSize = true;
			this.radioButtonClipboardRedirectionD.Location = new System.Drawing.Point(218, 196);
			this.radioButtonClipboardRedirectionD.Name = "radioButtonClipboardRedirectionD";
			this.radioButtonClipboardRedirectionD.Size = new System.Drawing.Size(14, 13);
			this.radioButtonClipboardRedirectionD.TabIndex = 19;
			this.radioButtonClipboardRedirectionD.TabStop = true;
			this.radioButtonClipboardRedirectionD.UseVisualStyleBackColor = true;
			this.radioButtonClipboardRedirectionD.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonClipboardRedirectionN
			// 
			this.radioButtonClipboardRedirectionN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonClipboardRedirectionN.AutoCheck = false;
			this.radioButtonClipboardRedirectionN.AutoSize = true;
			this.radioButtonClipboardRedirectionN.Location = new System.Drawing.Point(289, 196);
			this.radioButtonClipboardRedirectionN.Name = "radioButtonClipboardRedirectionN";
			this.radioButtonClipboardRedirectionN.Size = new System.Drawing.Size(14, 13);
			this.radioButtonClipboardRedirectionN.TabIndex = 20;
			this.radioButtonClipboardRedirectionN.TabStop = true;
			this.radioButtonClipboardRedirectionN.UseVisualStyleBackColor = true;
			this.radioButtonClipboardRedirectionN.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonPrinterRedirectionE
			// 
			this.radioButtonPrinterRedirectionE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonPrinterRedirectionE.AutoCheck = false;
			this.radioButtonPrinterRedirectionE.AutoSize = true;
			this.radioButtonPrinterRedirectionE.Location = new System.Drawing.Point(147, 169);
			this.radioButtonPrinterRedirectionE.Name = "radioButtonPrinterRedirectionE";
			this.radioButtonPrinterRedirectionE.Size = new System.Drawing.Size(14, 13);
			this.radioButtonPrinterRedirectionE.TabIndex = 15;
			this.radioButtonPrinterRedirectionE.TabStop = true;
			this.radioButtonPrinterRedirectionE.UseVisualStyleBackColor = true;
			this.radioButtonPrinterRedirectionE.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonPrinterRedirectionD
			// 
			this.radioButtonPrinterRedirectionD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonPrinterRedirectionD.AutoCheck = false;
			this.radioButtonPrinterRedirectionD.AutoSize = true;
			this.radioButtonPrinterRedirectionD.Location = new System.Drawing.Point(218, 169);
			this.radioButtonPrinterRedirectionD.Name = "radioButtonPrinterRedirectionD";
			this.radioButtonPrinterRedirectionD.Size = new System.Drawing.Size(14, 13);
			this.radioButtonPrinterRedirectionD.TabIndex = 16;
			this.radioButtonPrinterRedirectionD.TabStop = true;
			this.radioButtonPrinterRedirectionD.UseVisualStyleBackColor = true;
			this.radioButtonPrinterRedirectionD.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonPrinterRedirectionN
			// 
			this.radioButtonPrinterRedirectionN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonPrinterRedirectionN.AutoCheck = false;
			this.radioButtonPrinterRedirectionN.AutoSize = true;
			this.radioButtonPrinterRedirectionN.Location = new System.Drawing.Point(289, 169);
			this.radioButtonPrinterRedirectionN.Name = "radioButtonPrinterRedirectionN";
			this.radioButtonPrinterRedirectionN.Size = new System.Drawing.Size(14, 13);
			this.radioButtonPrinterRedirectionN.TabIndex = 17;
			this.radioButtonPrinterRedirectionN.TabStop = true;
			this.radioButtonPrinterRedirectionN.UseVisualStyleBackColor = true;
			this.radioButtonPrinterRedirectionN.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonProtectedClientE
			// 
			this.radioButtonProtectedClientE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonProtectedClientE.AutoCheck = false;
			this.radioButtonProtectedClientE.AutoSize = true;
			this.radioButtonProtectedClientE.Location = new System.Drawing.Point(147, 142);
			this.radioButtonProtectedClientE.Name = "radioButtonProtectedClientE";
			this.radioButtonProtectedClientE.Size = new System.Drawing.Size(14, 13);
			this.radioButtonProtectedClientE.TabIndex = 12;
			this.radioButtonProtectedClientE.TabStop = true;
			this.radioButtonProtectedClientE.UseVisualStyleBackColor = true;
			this.radioButtonProtectedClientE.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonProtectedClientD
			// 
			this.radioButtonProtectedClientD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonProtectedClientD.AutoCheck = false;
			this.radioButtonProtectedClientD.AutoSize = true;
			this.radioButtonProtectedClientD.Location = new System.Drawing.Point(218, 142);
			this.radioButtonProtectedClientD.Name = "radioButtonProtectedClientD";
			this.radioButtonProtectedClientD.Size = new System.Drawing.Size(14, 13);
			this.radioButtonProtectedClientD.TabIndex = 13;
			this.radioButtonProtectedClientD.TabStop = true;
			this.radioButtonProtectedClientD.UseVisualStyleBackColor = true;
			this.radioButtonProtectedClientD.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonProtectedClientN
			// 
			this.radioButtonProtectedClientN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonProtectedClientN.AutoCheck = false;
			this.radioButtonProtectedClientN.AutoSize = true;
			this.radioButtonProtectedClientN.Location = new System.Drawing.Point(289, 142);
			this.radioButtonProtectedClientN.Name = "radioButtonProtectedClientN";
			this.radioButtonProtectedClientN.Size = new System.Drawing.Size(14, 13);
			this.radioButtonProtectedClientN.TabIndex = 14;
			this.radioButtonProtectedClientN.TabStop = true;
			this.radioButtonProtectedClientN.UseVisualStyleBackColor = true;
			this.radioButtonProtectedClientN.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonVideoInputE
			// 
			this.radioButtonVideoInputE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonVideoInputE.AutoCheck = false;
			this.radioButtonVideoInputE.AutoSize = true;
			this.radioButtonVideoInputE.Location = new System.Drawing.Point(147, 115);
			this.radioButtonVideoInputE.Name = "radioButtonVideoInputE";
			this.radioButtonVideoInputE.Size = new System.Drawing.Size(14, 13);
			this.radioButtonVideoInputE.TabIndex = 9;
			this.radioButtonVideoInputE.TabStop = true;
			this.radioButtonVideoInputE.UseVisualStyleBackColor = true;
			this.radioButtonVideoInputE.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonVideoInputD
			// 
			this.radioButtonVideoInputD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonVideoInputD.AutoCheck = false;
			this.radioButtonVideoInputD.AutoSize = true;
			this.radioButtonVideoInputD.Location = new System.Drawing.Point(218, 115);
			this.radioButtonVideoInputD.Name = "radioButtonVideoInputD";
			this.radioButtonVideoInputD.Size = new System.Drawing.Size(14, 13);
			this.radioButtonVideoInputD.TabIndex = 10;
			this.radioButtonVideoInputD.TabStop = true;
			this.radioButtonVideoInputD.UseVisualStyleBackColor = true;
			this.radioButtonVideoInputD.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonVideoInputN
			// 
			this.radioButtonVideoInputN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonVideoInputN.AutoCheck = false;
			this.radioButtonVideoInputN.AutoSize = true;
			this.radioButtonVideoInputN.Location = new System.Drawing.Point(289, 115);
			this.radioButtonVideoInputN.Name = "radioButtonVideoInputN";
			this.radioButtonVideoInputN.Size = new System.Drawing.Size(14, 13);
			this.radioButtonVideoInputN.TabIndex = 11;
			this.radioButtonVideoInputN.TabStop = true;
			this.radioButtonVideoInputN.UseVisualStyleBackColor = true;
			this.radioButtonVideoInputN.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonAudioInputE
			// 
			this.radioButtonAudioInputE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonAudioInputE.AutoCheck = false;
			this.radioButtonAudioInputE.AutoSize = true;
			this.radioButtonAudioInputE.Location = new System.Drawing.Point(147, 88);
			this.radioButtonAudioInputE.Name = "radioButtonAudioInputE";
			this.radioButtonAudioInputE.Size = new System.Drawing.Size(14, 13);
			this.radioButtonAudioInputE.TabIndex = 6;
			this.radioButtonAudioInputE.TabStop = true;
			this.radioButtonAudioInputE.UseVisualStyleBackColor = true;
			this.radioButtonAudioInputE.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonAudioInputD
			// 
			this.radioButtonAudioInputD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonAudioInputD.AutoCheck = false;
			this.radioButtonAudioInputD.AutoSize = true;
			this.radioButtonAudioInputD.Location = new System.Drawing.Point(218, 88);
			this.radioButtonAudioInputD.Name = "radioButtonAudioInputD";
			this.radioButtonAudioInputD.Size = new System.Drawing.Size(14, 13);
			this.radioButtonAudioInputD.TabIndex = 7;
			this.radioButtonAudioInputD.TabStop = true;
			this.radioButtonAudioInputD.UseVisualStyleBackColor = true;
			this.radioButtonAudioInputD.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonAudioInputN
			// 
			this.radioButtonAudioInputN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonAudioInputN.AutoCheck = false;
			this.radioButtonAudioInputN.AutoSize = true;
			this.radioButtonAudioInputN.Location = new System.Drawing.Point(289, 88);
			this.radioButtonAudioInputN.Name = "radioButtonAudioInputN";
			this.radioButtonAudioInputN.Size = new System.Drawing.Size(14, 13);
			this.radioButtonAudioInputN.TabIndex = 8;
			this.radioButtonAudioInputN.TabStop = true;
			this.radioButtonAudioInputN.UseVisualStyleBackColor = true;
			this.radioButtonAudioInputN.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// labelClipboardRedirection
			// 
			this.labelClipboardRedirection.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelClipboardRedirection.AutoSize = true;
			this.labelClipboardRedirection.Location = new System.Drawing.Point(4, 197);
			this.labelClipboardRedirection.Name = "labelClipboardRedirection";
			this.labelClipboardRedirection.Size = new System.Drawing.Size(111, 12);
			this.labelClipboardRedirection.TabIndex = 9;
			this.labelClipboardRedirection.Text = "ClipboardRedirection";
			// 
			// labelvGPU
			// 
			this.labelvGPU.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelvGPU.AutoSize = true;
			this.labelvGPU.Location = new System.Drawing.Point(81, 35);
			this.labelvGPU.Name = "labelvGPU";
			this.labelvGPU.Size = new System.Drawing.Size(34, 12);
			this.labelvGPU.TabIndex = 0;
			this.labelvGPU.Text = "vGPU";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(131, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enabled";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(203, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "Disable";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(275, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "Default";
			// 
			// labelNetworking
			// 
			this.labelNetworking.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelNetworking.AutoSize = true;
			this.labelNetworking.Location = new System.Drawing.Point(53, 62);
			this.labelNetworking.Name = "labelNetworking";
			this.labelNetworking.Size = new System.Drawing.Size(62, 12);
			this.labelNetworking.TabIndex = 6;
			this.labelNetworking.Text = "Networking";
			// 
			// labelAudioInput
			// 
			this.labelAudioInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelAudioInput.AutoSize = true;
			this.labelAudioInput.Location = new System.Drawing.Point(56, 89);
			this.labelAudioInput.Name = "labelAudioInput";
			this.labelAudioInput.Size = new System.Drawing.Size(59, 12);
			this.labelAudioInput.TabIndex = 5;
			this.labelAudioInput.Text = "AudioInput";
			// 
			// labelVideoInput
			// 
			this.labelVideoInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelVideoInput.AutoSize = true;
			this.labelVideoInput.Location = new System.Drawing.Point(56, 116);
			this.labelVideoInput.Name = "labelVideoInput";
			this.labelVideoInput.Size = new System.Drawing.Size(59, 12);
			this.labelVideoInput.TabIndex = 4;
			this.labelVideoInput.Text = "VideoInput";
			// 
			// labelProtectedClient
			// 
			this.labelProtectedClient.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelProtectedClient.AutoSize = true;
			this.labelProtectedClient.Location = new System.Drawing.Point(31, 143);
			this.labelProtectedClient.Name = "labelProtectedClient";
			this.labelProtectedClient.Size = new System.Drawing.Size(84, 12);
			this.labelProtectedClient.TabIndex = 7;
			this.labelProtectedClient.Text = "ProtectedClient";
			// 
			// labelPrinterRedirection
			// 
			this.labelPrinterRedirection.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelPrinterRedirection.AutoSize = true;
			this.labelPrinterRedirection.Location = new System.Drawing.Point(18, 170);
			this.labelPrinterRedirection.Name = "labelPrinterRedirection";
			this.labelPrinterRedirection.Size = new System.Drawing.Size(97, 12);
			this.labelPrinterRedirection.TabIndex = 8;
			this.labelPrinterRedirection.Text = "PrinterRedirection";
			// 
			// radioButtonvGPUE
			// 
			this.radioButtonvGPUE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonvGPUE.AutoCheck = false;
			this.radioButtonvGPUE.AutoSize = true;
			this.radioButtonvGPUE.Location = new System.Drawing.Point(147, 34);
			this.radioButtonvGPUE.Name = "radioButtonvGPUE";
			this.radioButtonvGPUE.Size = new System.Drawing.Size(14, 13);
			this.radioButtonvGPUE.TabIndex = 0;
			this.radioButtonvGPUE.TabStop = true;
			this.radioButtonvGPUE.UseVisualStyleBackColor = true;
			this.radioButtonvGPUE.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonvGPUD
			// 
			this.radioButtonvGPUD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonvGPUD.AutoCheck = false;
			this.radioButtonvGPUD.AutoSize = true;
			this.radioButtonvGPUD.Location = new System.Drawing.Point(218, 34);
			this.radioButtonvGPUD.Name = "radioButtonvGPUD";
			this.radioButtonvGPUD.Size = new System.Drawing.Size(14, 13);
			this.radioButtonvGPUD.TabIndex = 1;
			this.radioButtonvGPUD.TabStop = true;
			this.radioButtonvGPUD.UseVisualStyleBackColor = true;
			this.radioButtonvGPUD.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonvGPUN
			// 
			this.radioButtonvGPUN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonvGPUN.AutoCheck = false;
			this.radioButtonvGPUN.AutoSize = true;
			this.radioButtonvGPUN.Location = new System.Drawing.Point(289, 34);
			this.radioButtonvGPUN.Name = "radioButtonvGPUN";
			this.radioButtonvGPUN.Size = new System.Drawing.Size(14, 13);
			this.radioButtonvGPUN.TabIndex = 2;
			this.radioButtonvGPUN.TabStop = true;
			this.radioButtonvGPUN.UseVisualStyleBackColor = true;
			this.radioButtonvGPUN.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonNetworkingN
			// 
			this.radioButtonNetworkingN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonNetworkingN.AutoCheck = false;
			this.radioButtonNetworkingN.AutoSize = true;
			this.radioButtonNetworkingN.Location = new System.Drawing.Point(289, 61);
			this.radioButtonNetworkingN.Name = "radioButtonNetworkingN";
			this.radioButtonNetworkingN.Size = new System.Drawing.Size(14, 13);
			this.radioButtonNetworkingN.TabIndex = 5;
			this.radioButtonNetworkingN.TabStop = true;
			this.radioButtonNetworkingN.UseVisualStyleBackColor = true;
			this.radioButtonNetworkingN.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonNetworkingD
			// 
			this.radioButtonNetworkingD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonNetworkingD.AutoCheck = false;
			this.radioButtonNetworkingD.AutoSize = true;
			this.radioButtonNetworkingD.Location = new System.Drawing.Point(218, 61);
			this.radioButtonNetworkingD.Name = "radioButtonNetworkingD";
			this.radioButtonNetworkingD.Size = new System.Drawing.Size(14, 13);
			this.radioButtonNetworkingD.TabIndex = 4;
			this.radioButtonNetworkingD.TabStop = true;
			this.radioButtonNetworkingD.UseVisualStyleBackColor = true;
			this.radioButtonNetworkingD.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonNetworkingE
			// 
			this.radioButtonNetworkingE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonNetworkingE.AutoCheck = false;
			this.radioButtonNetworkingE.AutoSize = true;
			this.radioButtonNetworkingE.Location = new System.Drawing.Point(147, 61);
			this.radioButtonNetworkingE.Name = "radioButtonNetworkingE";
			this.radioButtonNetworkingE.Size = new System.Drawing.Size(14, 13);
			this.radioButtonNetworkingE.TabIndex = 3;
			this.radioButtonNetworkingE.TabStop = true;
			this.radioButtonNetworkingE.UseVisualStyleBackColor = true;
			this.radioButtonNetworkingE.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Location = new System.Drawing.Point(351, 12);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(142, 54);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridViewDelete,
            this.hostDataGridViewTextBoxColumn,
            this.guestDataGridViewTextBoxColumn,
            this.readonlyDataGridViewCheckBoxColumn});
			this.dataGridView1.DataSource = this.mappingTableBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 322);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(481, 174);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
			this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
			this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
			this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
			// 
			// gridViewDelete
			// 
			this.gridViewDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.gridViewDelete.HeaderText = "Del";
			this.gridViewDelete.Name = "gridViewDelete";
			this.gridViewDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.gridViewDelete.Width = 28;
			// 
			// hostDataGridViewTextBoxColumn
			// 
			this.hostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
			this.hostDataGridViewTextBoxColumn.HeaderText = "host";
			this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
			// 
			// guestDataGridViewTextBoxColumn
			// 
			this.guestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.guestDataGridViewTextBoxColumn.DataPropertyName = "guest";
			this.guestDataGridViewTextBoxColumn.HeaderText = "guest";
			this.guestDataGridViewTextBoxColumn.Name = "guestDataGridViewTextBoxColumn";
			// 
			// readonlyDataGridViewCheckBoxColumn
			// 
			this.readonlyDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.readonlyDataGridViewCheckBoxColumn.DataPropertyName = "readonly";
			this.readonlyDataGridViewCheckBoxColumn.HeaderText = "R/O";
			this.readonlyDataGridViewCheckBoxColumn.Name = "readonlyDataGridViewCheckBoxColumn";
			this.readonlyDataGridViewCheckBoxColumn.Width = 33;
			// 
			// mappingTableBindingSource
			// 
			this.mappingTableBindingSource.DataMember = "MappingTable";
			this.mappingTableBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "LogonCommand";
			// 
			// textBoxLogonCommand
			// 
			this.textBoxLogonCommand.Location = new System.Drawing.Point(12, 258);
			this.textBoxLogonCommand.Name = "textBoxLogonCommand";
			this.textBoxLogonCommand.Size = new System.Drawing.Size(445, 19);
			this.textBoxLogonCommand.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 304);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 12);
			this.label5.TabIndex = 6;
			this.label5.Text = "MappedFolders";
			// 
			// buttonLogonCommand
			// 
			this.buttonLogonCommand.Location = new System.Drawing.Point(463, 258);
			this.buttonLogonCommand.Name = "buttonLogonCommand";
			this.buttonLogonCommand.Size = new System.Drawing.Size(30, 19);
			this.buttonLogonCommand.TabIndex = 1;
			this.buttonLogonCommand.Text = "...";
			this.buttonLogonCommand.UseVisualStyleBackColor = true;
			this.buttonLogonCommand.Click += new System.EventHandler(this.buttonLogonCommand_Click);
			// 
			// openFileDialogLogonCommand
			// 
			this.openFileDialogLogonCommand.DefaultExt = "*";
			// 
			// saveFileDialogWSB
			// 
			this.saveFileDialogWSB.DefaultExt = "wsb";
			this.saveFileDialogWSB.Filter = "Windows Sandbox configuration file|*.wsb";
			// 
			// host
			// 
			this.host.DataPropertyName = "host";
			this.host.HeaderText = "host";
			this.host.Name = "host";
			// 
			// guest
			// 
			this.guest.DataPropertyName = "guest";
			this.guest.HeaderText = "guest";
			this.guest.Name = "guest";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.SelectedPath = "c:\\";
			// 
			// buttonAddHostPath
			// 
			this.buttonAddHostPath.Location = new System.Drawing.Point(98, 293);
			this.buttonAddHostPath.Name = "buttonAddHostPath";
			this.buttonAddHostPath.Size = new System.Drawing.Size(160, 23);
			this.buttonAddHostPath.TabIndex = 7;
			this.buttonAddHostPath.Text = "Add host path";
			this.buttonAddHostPath.UseVisualStyleBackColor = true;
			this.buttonAddHostPath.Click += new System.EventHandler(this.buttonAddHostPath_Click);
			// 
			// buttonAddBlankRecord
			// 
			this.buttonAddBlankRecord.Location = new System.Drawing.Point(264, 293);
			this.buttonAddBlankRecord.Name = "buttonAddBlankRecord";
			this.buttonAddBlankRecord.Size = new System.Drawing.Size(113, 23);
			this.buttonAddBlankRecord.TabIndex = 8;
			this.buttonAddBlankRecord.Text = "Add blank record";
			this.buttonAddBlankRecord.UseVisualStyleBackColor = true;
			this.buttonAddBlankRecord.Click += new System.EventHandler(this.buttonAddBlankRecord_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(422, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "MemoryInMB";
			// 
			// numericUpDownMemoryInMB
			// 
			this.numericUpDownMemoryInMB.Location = new System.Drawing.Point(353, 210);
			this.numericUpDownMemoryInMB.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDownMemoryInMB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericUpDownMemoryInMB.Name = "numericUpDownMemoryInMB";
			this.numericUpDownMemoryInMB.Size = new System.Drawing.Size(140, 19);
			this.numericUpDownMemoryInMB.TabIndex = 10;
			this.numericUpDownMemoryInMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDownMemoryInMB.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 508);
			this.Controls.Add(this.numericUpDownMemoryInMB);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonAddBlankRecord);
			this.Controls.Add(this.buttonAddHostPath);
			this.Controls.Add(this.buttonLogonCommand);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxLogonCommand);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mappingTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemoryInMB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelvGPU;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelClipboardRedirection;
		private System.Windows.Forms.Label labelNetworking;
		private System.Windows.Forms.Label labelAudioInput;
		private System.Windows.Forms.Label labelVideoInput;
		private System.Windows.Forms.Label labelProtectedClient;
		private System.Windows.Forms.Label labelPrinterRedirection;
		private System.Windows.Forms.RadioButton radioButtonvGPUE;
		private System.Windows.Forms.RadioButton radioButtonvGPUD;
		private System.Windows.Forms.RadioButton radioButtonvGPUN;
		private System.Windows.Forms.RadioButton radioButtonClipboardRedirectionE;
		private System.Windows.Forms.RadioButton radioButtonClipboardRedirectionD;
		private System.Windows.Forms.RadioButton radioButtonClipboardRedirectionN;
		private System.Windows.Forms.RadioButton radioButtonPrinterRedirectionE;
		private System.Windows.Forms.RadioButton radioButtonPrinterRedirectionD;
		private System.Windows.Forms.RadioButton radioButtonPrinterRedirectionN;
		private System.Windows.Forms.RadioButton radioButtonProtectedClientE;
		private System.Windows.Forms.RadioButton radioButtonProtectedClientD;
		private System.Windows.Forms.RadioButton radioButtonProtectedClientN;
		private System.Windows.Forms.RadioButton radioButtonVideoInputE;
		private System.Windows.Forms.RadioButton radioButtonVideoInputD;
		private System.Windows.Forms.RadioButton radioButtonVideoInputN;
		private System.Windows.Forms.RadioButton radioButtonAudioInputE;
		private System.Windows.Forms.RadioButton radioButtonAudioInputD;
		private System.Windows.Forms.RadioButton radioButtonAudioInputN;
		private System.Windows.Forms.RadioButton radioButtonNetworkingN;
		private System.Windows.Forms.RadioButton radioButtonNetworkingD;
		private System.Windows.Forms.RadioButton radioButtonNetworkingE;
		private System.Windows.Forms.DataGridView dataGridView1;
		private DataSet1 dataSet1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxLogonCommand;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonLogonCommand;
		private System.Windows.Forms.OpenFileDialog openFileDialogLogonCommand;
		private System.Windows.Forms.SaveFileDialog saveFileDialogWSB;
		private System.Windows.Forms.BindingSource mappingTableBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn host;
		private System.Windows.Forms.DataGridViewTextBoxColumn guest;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button buttonAddHostPath;
		private System.Windows.Forms.Button buttonAddBlankRecord;
		private System.Windows.Forms.DataGridViewButtonColumn gridViewDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn guestDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn readonlyDataGridViewCheckBoxColumn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDownMemoryInMB;
	}
}

