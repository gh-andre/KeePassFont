namespace KeePass.Forms
{
	partial class OptionsForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_tabMain = new System.Windows.Forms.TabControl();
            this.m_tabSecurity = new System.Windows.Forms.TabPage();
            this.m_linkSecOptAdm = new System.Windows.Forms.LinkLabel();
            this.m_linkSecOptEx = new System.Windows.Forms.LinkLabel();
            this.m_lblSecOpt = new System.Windows.Forms.Label();
            this.m_numLockAfterGlobalTime = new System.Windows.Forms.NumericUpDown();
            this.m_cbLockAfterGlobalTime = new System.Windows.Forms.CheckBox();
            this.m_lvSecurityOptions = new KeePass.UI.CustomListViewEx();
            this.m_numClipClearTime = new System.Windows.Forms.NumericUpDown();
            this.m_cbClipClearTime = new System.Windows.Forms.CheckBox();
            this.m_numDefaultExpireDays = new System.Windows.Forms.NumericUpDown();
            this.m_cbDefaultExpireDays = new System.Windows.Forms.CheckBox();
            this.m_cbLockAfterTime = new System.Windows.Forms.CheckBox();
            this.m_numLockAfterTime = new System.Windows.Forms.NumericUpDown();
            this.m_tabPolicy = new System.Windows.Forms.TabPage();
            this.m_lvPolicy = new KeePass.UI.CustomListViewEx();
            this.m_linkPolicyInfo = new System.Windows.Forms.LinkLabel();
            this.m_lblPolicyMore = new System.Windows.Forms.Label();
            this.m_lblPolicyRestart = new System.Windows.Forms.Label();
            this.m_lblPolicyIntro = new System.Windows.Forms.Label();
            this.m_tabGui1 = new System.Windows.Forms.TabPage();
            this.m_lvGuiOptions = new KeePass.UI.CustomListViewEx();
            this.m_tabGui2 = new System.Windows.Forms.TabPage();
            this.m_grpIntAdv = new System.Windows.Forms.GroupBox();
            this.m_lblEscAction = new System.Windows.Forms.Label();
            this.m_lblMruCount = new System.Windows.Forms.Label();
            this.m_numMruCount = new System.Windows.Forms.NumericUpDown();
            this.m_cmbEscAction = new System.Windows.Forms.ComboBox();
            this.m_grpFonts = new System.Windows.Forms.GroupBox();
            this.m_linkMainFont = new System.Windows.Forms.LinkLabel();
            this.m_cbListFont = new System.Windows.Forms.CheckBox();
            this.m_btnListFont = new System.Windows.Forms.Button();
            this.m_btnPasswordFont = new System.Windows.Forms.Button();
            this.m_cbPasswordFont = new System.Windows.Forms.CheckBox();
            this.m_grpStyles = new System.Windows.Forms.GroupBox();
            this.m_cmbAltColor = new System.Windows.Forms.ComboBox();
            this.m_lblAltColor = new System.Windows.Forms.Label();
            this.m_linkTheme = new System.Windows.Forms.LinkLabel();
            this.m_cmbMenuStyle = new System.Windows.Forms.ComboBox();
            this.m_btnAltColor = new KeePass.UI.ColorButtonEx();
            this.m_cmbBannerStyle = new System.Windows.Forms.ComboBox();
            this.m_lblBannerStyle = new System.Windows.Forms.Label();
            this.m_lblMenuStyle = new System.Windows.Forms.Label();
            this.m_tabIntegration = new System.Windows.Forms.TabPage();
            this.m_btnHelpSource = new System.Windows.Forms.Button();
            this.m_btnSchemeOverrides = new System.Windows.Forms.Button();
            this.m_cbAutoRun = new System.Windows.Forms.CheckBox();
            this.m_grpFileExt = new System.Windows.Forms.GroupBox();
            this.m_btnFileExtRemove = new System.Windows.Forms.Button();
            this.m_btnFileExtCreate = new System.Windows.Forms.Button();
            this.m_lblFileExtHint = new System.Windows.Forms.Label();
            this.m_grpHotKeys = new System.Windows.Forms.GroupBox();
            this.m_lblAutoTypePassword = new System.Windows.Forms.Label();
            this.m_hkAutoTypePassword = new KeePass.UI.HotKeyControlEx();
            this.m_linkHotKeyHelp = new System.Windows.Forms.LinkLabel();
            this.m_lblAutoTypeSelected = new System.Windows.Forms.Label();
            this.m_hkAutoTypeSelected = new KeePass.UI.HotKeyControlEx();
            this.m_hkShowWindow = new KeePass.UI.HotKeyControlEx();
            this.m_lblAutoType = new System.Windows.Forms.Label();
            this.m_lblShowWindow = new System.Windows.Forms.Label();
            this.m_hkAutoType = new KeePass.UI.HotKeyControlEx();
            this.m_tabAdvanced = new System.Windows.Forms.TabPage();
            this.m_btnProxy = new System.Windows.Forms.Button();
            this.m_lvAdvanced = new KeePass.UI.CustomListViewEx();
            this.m_ttRect = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.m_tabMain.SuspendLayout();
            this.m_tabSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numLockAfterGlobalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numClipClearTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numDefaultExpireDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numLockAfterTime)).BeginInit();
            this.m_tabPolicy.SuspendLayout();
            this.m_tabGui1.SuspendLayout();
            this.m_tabGui2.SuspendLayout();
            this.m_grpIntAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numMruCount)).BeginInit();
            this.m_grpFonts.SuspendLayout();
            this.m_grpStyles.SuspendLayout();
            this.m_tabIntegration.SuspendLayout();
            this.m_grpFileExt.SuspendLayout();
            this.m_grpHotKeys.SuspendLayout();
            this.m_tabAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_bannerImage
            // 
            this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
            this.m_bannerImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_bannerImage.Name = "m_bannerImage";
            this.m_bannerImage.Size = new System.Drawing.Size(1318, 124);
            this.m_bannerImage.TabIndex = 0;
            this.m_bannerImage.TabStop = false;
            // 
            // m_btnOK
            // 
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(940, 906);
            this.m_btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(168, 48);
            this.m_btnOK.TabIndex = 0;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(1122, 906);
            this.m_btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(168, 48);
            this.m_btnCancel.TabIndex = 1;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
            // 
            // m_tabMain
            // 
            this.m_tabMain.Controls.Add(this.m_tabSecurity);
            this.m_tabMain.Controls.Add(this.m_tabPolicy);
            this.m_tabMain.Controls.Add(this.m_tabGui1);
            this.m_tabMain.Controls.Add(this.m_tabGui2);
            this.m_tabMain.Controls.Add(this.m_tabIntegration);
            this.m_tabMain.Controls.Add(this.m_tabAdvanced);
            this.m_tabMain.Location = new System.Drawing.Point(27, 136);
            this.m_tabMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabMain.Name = "m_tabMain";
            this.m_tabMain.SelectedIndex = 0;
            this.m_tabMain.Size = new System.Drawing.Size(1264, 756);
            this.m_tabMain.TabIndex = 2;
            // 
            // m_tabSecurity
            // 
            this.m_tabSecurity.Controls.Add(this.m_linkSecOptAdm);
            this.m_tabSecurity.Controls.Add(this.m_linkSecOptEx);
            this.m_tabSecurity.Controls.Add(this.m_lblSecOpt);
            this.m_tabSecurity.Controls.Add(this.m_numLockAfterGlobalTime);
            this.m_tabSecurity.Controls.Add(this.m_cbLockAfterGlobalTime);
            this.m_tabSecurity.Controls.Add(this.m_lvSecurityOptions);
            this.m_tabSecurity.Controls.Add(this.m_numClipClearTime);
            this.m_tabSecurity.Controls.Add(this.m_cbClipClearTime);
            this.m_tabSecurity.Controls.Add(this.m_numDefaultExpireDays);
            this.m_tabSecurity.Controls.Add(this.m_cbDefaultExpireDays);
            this.m_tabSecurity.Controls.Add(this.m_cbLockAfterTime);
            this.m_tabSecurity.Controls.Add(this.m_numLockAfterTime);
            this.m_tabSecurity.Location = new System.Drawing.Point(4, 38);
            this.m_tabSecurity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabSecurity.Name = "m_tabSecurity";
            this.m_tabSecurity.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabSecurity.Size = new System.Drawing.Size(1256, 714);
            this.m_tabSecurity.TabIndex = 0;
            this.m_tabSecurity.Text = "Security";
            this.m_tabSecurity.UseVisualStyleBackColor = true;
            // 
            // m_linkSecOptAdm
            // 
            this.m_linkSecOptAdm.AutoSize = true;
            this.m_linkSecOptAdm.Location = new System.Drawing.Point(414, 657);
            this.m_linkSecOptAdm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_linkSecOptAdm.Name = "m_linkSecOptAdm";
            this.m_linkSecOptAdm.Size = new System.Drawing.Size(207, 29);
            this.m_linkSecOptAdm.TabIndex = 11;
            this.m_linkSecOptAdm.TabStop = true;
            this.m_linkSecOptAdm.Text = "For administrators";
            this.m_linkSecOptAdm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSecOptAdmLinkClicked);
            // 
            // m_linkSecOptEx
            // 
            this.m_linkSecOptEx.AutoSize = true;
            this.m_linkSecOptEx.Location = new System.Drawing.Point(267, 657);
            this.m_linkSecOptEx.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_linkSecOptEx.Name = "m_linkSecOptEx";
            this.m_linkSecOptEx.Size = new System.Drawing.Size(135, 29);
            this.m_linkSecOptEx.TabIndex = 10;
            this.m_linkSecOptEx.TabStop = true;
            this.m_linkSecOptEx.Text = "For experts";
            this.m_linkSecOptEx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSecOptExLinkClicked);
            // 
            // m_lblSecOpt
            // 
            this.m_lblSecOpt.AutoSize = true;
            this.m_lblSecOpt.Location = new System.Drawing.Point(6, 657);
            this.m_lblSecOpt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblSecOpt.Name = "m_lblSecOpt";
            this.m_lblSecOpt.Size = new System.Drawing.Size(248, 29);
            this.m_lblSecOpt.TabIndex = 9;
            this.m_lblSecOpt.Text = "More security options:";
            // 
            // m_numLockAfterGlobalTime
            // 
            this.m_numLockAfterGlobalTime.Location = new System.Drawing.Point(735, 76);
            this.m_numLockAfterGlobalTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_numLockAfterGlobalTime.Maximum = new decimal(new int[] {
            1209600,
            0,
            0,
            0});
            this.m_numLockAfterGlobalTime.Name = "m_numLockAfterGlobalTime";
            this.m_numLockAfterGlobalTime.Size = new System.Drawing.Size(148, 33);
            this.m_numLockAfterGlobalTime.TabIndex = 3;
            // 
            // m_cbLockAfterGlobalTime
            // 
            this.m_cbLockAfterGlobalTime.AutoSize = true;
            this.m_cbLockAfterGlobalTime.Location = new System.Drawing.Point(14, 80);
            this.m_cbLockAfterGlobalTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbLockAfterGlobalTime.Name = "m_cbLockAfterGlobalTime";
            this.m_cbLockAfterGlobalTime.Size = new System.Drawing.Size(67, 33);
            this.m_cbLockAfterGlobalTime.TabIndex = 2;
            this.m_cbLockAfterGlobalTime.Text = "<>";
            this.m_cbLockAfterGlobalTime.UseVisualStyleBackColor = true;
            this.m_cbLockAfterGlobalTime.CheckedChanged += new System.EventHandler(this.OnLockAfterGlobalTimeCheckedChanged);
            // 
            // m_lvSecurityOptions
            // 
            this.m_lvSecurityOptions.CheckBoxes = true;
            this.m_lvSecurityOptions.FullRowSelect = true;
            this.m_lvSecurityOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.m_lvSecurityOptions.HideSelection = false;
            this.m_lvSecurityOptions.Location = new System.Drawing.Point(14, 238);
            this.m_lvSecurityOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_lvSecurityOptions.Name = "m_lvSecurityOptions";
            this.m_lvSecurityOptions.ShowItemToolTips = true;
            this.m_lvSecurityOptions.Size = new System.Drawing.Size(1210, 398);
            this.m_lvSecurityOptions.TabIndex = 8;
            this.m_lvSecurityOptions.UseCompatibleStateImageBehavior = false;
            this.m_lvSecurityOptions.View = System.Windows.Forms.View.Details;
            // 
            // m_numClipClearTime
            // 
            this.m_numClipClearTime.Location = new System.Drawing.Point(735, 130);
            this.m_numClipClearTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_numClipClearTime.Maximum = new decimal(new int[] {
            1209600,
            0,
            0,
            0});
            this.m_numClipClearTime.Name = "m_numClipClearTime";
            this.m_numClipClearTime.Size = new System.Drawing.Size(148, 33);
            this.m_numClipClearTime.TabIndex = 5;
            // 
            // m_cbClipClearTime
            // 
            this.m_cbClipClearTime.AutoSize = true;
            this.m_cbClipClearTime.Location = new System.Drawing.Point(14, 134);
            this.m_cbClipClearTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbClipClearTime.Name = "m_cbClipClearTime";
            this.m_cbClipClearTime.Size = new System.Drawing.Size(67, 33);
            this.m_cbClipClearTime.TabIndex = 4;
            this.m_cbClipClearTime.Text = "<>";
            this.m_cbClipClearTime.UseVisualStyleBackColor = true;
            this.m_cbClipClearTime.CheckedChanged += new System.EventHandler(this.OnClipboardClearTimeCheckedChanged);
            // 
            // m_numDefaultExpireDays
            // 
            this.m_numDefaultExpireDays.Location = new System.Drawing.Point(735, 184);
            this.m_numDefaultExpireDays.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_numDefaultExpireDays.Maximum = new decimal(new int[] {
            2920,
            0,
            0,
            0});
            this.m_numDefaultExpireDays.Name = "m_numDefaultExpireDays";
            this.m_numDefaultExpireDays.Size = new System.Drawing.Size(148, 33);
            this.m_numDefaultExpireDays.TabIndex = 7;
            // 
            // m_cbDefaultExpireDays
            // 
            this.m_cbDefaultExpireDays.AutoSize = true;
            this.m_cbDefaultExpireDays.Location = new System.Drawing.Point(14, 188);
            this.m_cbDefaultExpireDays.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbDefaultExpireDays.Name = "m_cbDefaultExpireDays";
            this.m_cbDefaultExpireDays.Size = new System.Drawing.Size(67, 33);
            this.m_cbDefaultExpireDays.TabIndex = 6;
            this.m_cbDefaultExpireDays.Text = "<>";
            this.m_cbDefaultExpireDays.UseVisualStyleBackColor = true;
            this.m_cbDefaultExpireDays.CheckedChanged += new System.EventHandler(this.OnDefaultExpireDaysCheckedChanged);
            // 
            // m_cbLockAfterTime
            // 
            this.m_cbLockAfterTime.AutoSize = true;
            this.m_cbLockAfterTime.Location = new System.Drawing.Point(14, 26);
            this.m_cbLockAfterTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbLockAfterTime.Name = "m_cbLockAfterTime";
            this.m_cbLockAfterTime.Size = new System.Drawing.Size(67, 33);
            this.m_cbLockAfterTime.TabIndex = 0;
            this.m_cbLockAfterTime.Text = "<>";
            this.m_cbLockAfterTime.UseVisualStyleBackColor = true;
            this.m_cbLockAfterTime.CheckedChanged += new System.EventHandler(this.OnLockAfterTimeCheckedChanged);
            // 
            // m_numLockAfterTime
            // 
            this.m_numLockAfterTime.Location = new System.Drawing.Point(735, 22);
            this.m_numLockAfterTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_numLockAfterTime.Maximum = new decimal(new int[] {
            1209600,
            0,
            0,
            0});
            this.m_numLockAfterTime.Name = "m_numLockAfterTime";
            this.m_numLockAfterTime.Size = new System.Drawing.Size(148, 33);
            this.m_numLockAfterTime.TabIndex = 1;
            // 
            // m_tabPolicy
            // 
            this.m_tabPolicy.Controls.Add(this.m_lvPolicy);
            this.m_tabPolicy.Controls.Add(this.m_linkPolicyInfo);
            this.m_tabPolicy.Controls.Add(this.m_lblPolicyMore);
            this.m_tabPolicy.Controls.Add(this.m_lblPolicyRestart);
            this.m_tabPolicy.Controls.Add(this.m_lblPolicyIntro);
            this.m_tabPolicy.Location = new System.Drawing.Point(4, 38);
            this.m_tabPolicy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabPolicy.Name = "m_tabPolicy";
            this.m_tabPolicy.Size = new System.Drawing.Size(1256, 714);
            this.m_tabPolicy.TabIndex = 3;
            this.m_tabPolicy.Text = "<>";
            this.m_tabPolicy.UseVisualStyleBackColor = true;
            // 
            // m_lvPolicy
            // 
            this.m_lvPolicy.CheckBoxes = true;
            this.m_lvPolicy.FullRowSelect = true;
            this.m_lvPolicy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.m_lvPolicy.HideSelection = false;
            this.m_lvPolicy.Location = new System.Drawing.Point(14, 96);
            this.m_lvPolicy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_lvPolicy.Name = "m_lvPolicy";
            this.m_lvPolicy.ShowItemToolTips = true;
            this.m_lvPolicy.Size = new System.Drawing.Size(1210, 542);
            this.m_lvPolicy.TabIndex = 3;
            this.m_lvPolicy.UseCompatibleStateImageBehavior = false;
            this.m_lvPolicy.View = System.Windows.Forms.View.Details;
            // 
            // m_linkPolicyInfo
            // 
            this.m_linkPolicyInfo.AutoSize = true;
            this.m_linkPolicyInfo.Location = new System.Drawing.Point(219, 54);
            this.m_linkPolicyInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_linkPolicyInfo.Name = "m_linkPolicyInfo";
            this.m_linkPolicyInfo.Size = new System.Drawing.Size(260, 29);
            this.m_linkPolicyInfo.TabIndex = 2;
            this.m_linkPolicyInfo.TabStop = true;
            this.m_linkPolicyInfo.Text = "Application Policy Help";
            this.m_linkPolicyInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPolicyInfoLinkClicked);
            // 
            // m_lblPolicyMore
            // 
            this.m_lblPolicyMore.AutoSize = true;
            this.m_lblPolicyMore.Location = new System.Drawing.Point(6, 54);
            this.m_lblPolicyMore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblPolicyMore.Name = "m_lblPolicyMore";
            this.m_lblPolicyMore.Size = new System.Drawing.Size(200, 29);
            this.m_lblPolicyMore.TabIndex = 1;
            this.m_lblPolicyMore.Text = "More information:";
            // 
            // m_lblPolicyRestart
            // 
            this.m_lblPolicyRestart.AutoSize = true;
            this.m_lblPolicyRestart.Location = new System.Drawing.Point(6, 657);
            this.m_lblPolicyRestart.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblPolicyRestart.Name = "m_lblPolicyRestart";
            this.m_lblPolicyRestart.Size = new System.Drawing.Size(550, 29);
            this.m_lblPolicyRestart.TabIndex = 4;
            this.m_lblPolicyRestart.Text = "* Changing the policy requires restarting KeePass.";
            // 
            // m_lblPolicyIntro
            // 
            this.m_lblPolicyIntro.Location = new System.Drawing.Point(6, 18);
            this.m_lblPolicyIntro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblPolicyIntro.Name = "m_lblPolicyIntro";
            this.m_lblPolicyIntro.Size = new System.Drawing.Size(1233, 28);
            this.m_lblPolicyIntro.TabIndex = 0;
            this.m_lblPolicyIntro.Text = "The application policy defines which security-critical operations are allowed and" +
    " which are not.";
            // 
            // m_tabGui1
            // 
            this.m_tabGui1.Controls.Add(this.m_lvGuiOptions);
            this.m_tabGui1.Location = new System.Drawing.Point(4, 38);
            this.m_tabGui1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabGui1.Name = "m_tabGui1";
            this.m_tabGui1.Size = new System.Drawing.Size(1256, 714);
            this.m_tabGui1.TabIndex = 2;
            this.m_tabGui1.Text = "Interface (1)";
            this.m_tabGui1.UseVisualStyleBackColor = true;
            // 
            // m_lvGuiOptions
            // 
            this.m_lvGuiOptions.CheckBoxes = true;
            this.m_lvGuiOptions.FullRowSelect = true;
            this.m_lvGuiOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.m_lvGuiOptions.HideSelection = false;
            this.m_lvGuiOptions.Location = new System.Drawing.Point(14, 26);
            this.m_lvGuiOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_lvGuiOptions.Name = "m_lvGuiOptions";
            this.m_lvGuiOptions.ShowItemToolTips = true;
            this.m_lvGuiOptions.Size = new System.Drawing.Size(1210, 654);
            this.m_lvGuiOptions.TabIndex = 0;
            this.m_lvGuiOptions.UseCompatibleStateImageBehavior = false;
            this.m_lvGuiOptions.View = System.Windows.Forms.View.Details;
            // 
            // m_tabGui2
            // 
            this.m_tabGui2.Controls.Add(this.m_grpIntAdv);
            this.m_tabGui2.Controls.Add(this.m_grpFonts);
            this.m_tabGui2.Controls.Add(this.m_grpStyles);
            this.m_tabGui2.Location = new System.Drawing.Point(4, 38);
            this.m_tabGui2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabGui2.Name = "m_tabGui2";
            this.m_tabGui2.Size = new System.Drawing.Size(1256, 714);
            this.m_tabGui2.TabIndex = 5;
            this.m_tabGui2.Text = "Interface (2)";
            this.m_tabGui2.UseVisualStyleBackColor = true;
            // 
            // m_grpIntAdv
            // 
            this.m_grpIntAdv.Controls.Add(this.m_lblEscAction);
            this.m_grpIntAdv.Controls.Add(this.m_lblMruCount);
            this.m_grpIntAdv.Controls.Add(this.m_numMruCount);
            this.m_grpIntAdv.Controls.Add(this.m_cmbEscAction);
            this.m_grpIntAdv.Location = new System.Drawing.Point(14, 333);
            this.m_grpIntAdv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpIntAdv.Name = "m_grpIntAdv";
            this.m_grpIntAdv.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpIntAdv.Size = new System.Drawing.Size(742, 162);
            this.m_grpIntAdv.TabIndex = 2;
            this.m_grpIntAdv.TabStop = false;
            this.m_grpIntAdv.Text = "Advanced";
            // 
            // m_lblEscAction
            // 
            this.m_lblEscAction.AutoSize = true;
            this.m_lblEscAction.Location = new System.Drawing.Point(14, 44);
            this.m_lblEscAction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblEscAction.Name = "m_lblEscAction";
            this.m_lblEscAction.Size = new System.Drawing.Size(334, 29);
            this.m_lblEscAction.TabIndex = 0;
            this.m_lblEscAction.Text = "&Esc keypress in main window:";
            // 
            // m_lblMruCount
            // 
            this.m_lblMruCount.AutoSize = true;
            this.m_lblMruCount.Location = new System.Drawing.Point(14, 98);
            this.m_lblMruCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblMruCount.Name = "m_lblMruCount";
            this.m_lblMruCount.Size = new System.Drawing.Size(339, 29);
            this.m_lblMruCount.TabIndex = 2;
            this.m_lblMruCount.Text = "&Remember recently used files:";
            // 
            // m_numMruCount
            // 
            this.m_numMruCount.Location = new System.Drawing.Point(360, 93);
            this.m_numMruCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_numMruCount.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.m_numMruCount.Name = "m_numMruCount";
            this.m_numMruCount.Size = new System.Drawing.Size(120, 33);
            this.m_numMruCount.TabIndex = 3;
            this.m_numMruCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_cmbEscAction
            // 
            this.m_cmbEscAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbEscAction.FormattingEnabled = true;
            this.m_cmbEscAction.Location = new System.Drawing.Point(360, 38);
            this.m_cmbEscAction.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cmbEscAction.Name = "m_cmbEscAction";
            this.m_cmbEscAction.Size = new System.Drawing.Size(355, 37);
            this.m_cmbEscAction.TabIndex = 1;
            // 
            // m_grpFonts
            // 
            this.m_grpFonts.Controls.Add(this.m_linkMainFont);
            this.m_grpFonts.Controls.Add(this.m_cbListFont);
            this.m_grpFonts.Controls.Add(this.m_btnListFont);
            this.m_grpFonts.Controls.Add(this.m_btnPasswordFont);
            this.m_grpFonts.Controls.Add(this.m_cbPasswordFont);
            this.m_grpFonts.Location = new System.Drawing.Point(770, 26);
            this.m_grpFonts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpFonts.Name = "m_grpFonts";
            this.m_grpFonts.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpFonts.Size = new System.Drawing.Size(459, 296);
            this.m_grpFonts.TabIndex = 1;
            this.m_grpFonts.TabStop = false;
            this.m_grpFonts.Text = "Fonts";
            // 
            // m_linkMainFont
            // 
            this.m_linkMainFont.AutoSize = true;
            this.m_linkMainFont.Location = new System.Drawing.Point(14, 243);
            this.m_linkMainFont.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_linkMainFont.Name = "m_linkMainFont";
            this.m_linkMainFont.Size = new System.Drawing.Size(175, 29);
            this.m_linkMainFont.TabIndex = 4;
            this.m_linkMainFont.TabStop = true;
            this.m_linkMainFont.Text = "Main font (size)";
            this.m_linkMainFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnGuiFontLinkClicked);
            // 
            // m_cbListFont
            // 
            this.m_cbListFont.AutoSize = true;
            this.m_cbListFont.Location = new System.Drawing.Point(21, 42);
            this.m_cbListFont.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbListFont.Name = "m_cbListFont";
            this.m_cbListFont.Size = new System.Drawing.Size(208, 33);
            this.m_cbListFont.TabIndex = 0;
            this.m_cbListFont.Text = "Custom &list font:";
            this.m_cbListFont.UseVisualStyleBackColor = true;
            // 
            // m_btnListFont
            // 
            this.m_btnListFont.Location = new System.Drawing.Point(63, 81);
            this.m_btnListFont.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnListFont.Name = "m_btnListFont";
            this.m_btnListFont.Size = new System.Drawing.Size(375, 48);
            this.m_btnListFont.TabIndex = 1;
            this.m_btnListFont.Text = "<>";
            this.m_btnListFont.UseVisualStyleBackColor = true;
            // 
            // m_btnPasswordFont
            // 
            this.m_btnPasswordFont.Location = new System.Drawing.Point(63, 180);
            this.m_btnPasswordFont.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnPasswordFont.Name = "m_btnPasswordFont";
            this.m_btnPasswordFont.Size = new System.Drawing.Size(375, 48);
            this.m_btnPasswordFont.TabIndex = 3;
            this.m_btnPasswordFont.Text = "<>";
            this.m_btnPasswordFont.UseVisualStyleBackColor = true;
            // 
            // m_cbPasswordFont
            // 
            this.m_cbPasswordFont.AutoSize = true;
            this.m_cbPasswordFont.Location = new System.Drawing.Point(21, 141);
            this.m_cbPasswordFont.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbPasswordFont.Name = "m_cbPasswordFont";
            this.m_cbPasswordFont.Size = new System.Drawing.Size(283, 33);
            this.m_cbPasswordFont.TabIndex = 2;
            this.m_cbPasswordFont.Text = "Custom &password font:";
            this.m_cbPasswordFont.UseVisualStyleBackColor = true;
            // 
            // m_grpStyles
            // 
            this.m_grpStyles.Controls.Add(this.m_cmbAltColor);
            this.m_grpStyles.Controls.Add(this.m_lblAltColor);
            this.m_grpStyles.Controls.Add(this.m_linkTheme);
            this.m_grpStyles.Controls.Add(this.m_cmbMenuStyle);
            this.m_grpStyles.Controls.Add(this.m_btnAltColor);
            this.m_grpStyles.Controls.Add(this.m_cmbBannerStyle);
            this.m_grpStyles.Controls.Add(this.m_lblBannerStyle);
            this.m_grpStyles.Controls.Add(this.m_lblMenuStyle);
            this.m_grpStyles.Location = new System.Drawing.Point(14, 26);
            this.m_grpStyles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpStyles.Name = "m_grpStyles";
            this.m_grpStyles.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpStyles.Size = new System.Drawing.Size(742, 296);
            this.m_grpStyles.TabIndex = 0;
            this.m_grpStyles.TabStop = false;
            this.m_grpStyles.Text = "Styles && colors";
            // 
            // m_cmbAltColor
            // 
            this.m_cmbAltColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbAltColor.FormattingEnabled = true;
            this.m_cmbAltColor.Location = new System.Drawing.Point(360, 150);
            this.m_cmbAltColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cmbAltColor.Name = "m_cmbAltColor";
            this.m_cmbAltColor.Size = new System.Drawing.Size(260, 37);
            this.m_cmbAltColor.TabIndex = 5;
            this.m_cmbAltColor.SelectedIndexChanged += new System.EventHandler(this.OnAltColorSelectedIndexChanged);
            // 
            // m_lblAltColor
            // 
            this.m_lblAltColor.AutoSize = true;
            this.m_lblAltColor.Location = new System.Drawing.Point(14, 156);
            this.m_lblAltColor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblAltColor.Name = "m_lblAltColor";
            this.m_lblAltColor.Size = new System.Drawing.Size(297, 29);
            this.m_lblAltColor.TabIndex = 4;
            this.m_lblAltColor.Text = "&Alt. item background color:";
            // 
            // m_linkTheme
            // 
            this.m_linkTheme.AutoSize = true;
            this.m_linkTheme.Location = new System.Drawing.Point(14, 212);
            this.m_linkTheme.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_linkTheme.Name = "m_linkTheme";
            this.m_linkTheme.Size = new System.Drawing.Size(136, 29);
            this.m_linkTheme.TabIndex = 7;
            this.m_linkTheme.TabStop = true;
            this.m_linkTheme.Text = "Dark theme";
            this.m_linkTheme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnGuiDarkLinkClicked);
            // 
            // m_cmbMenuStyle
            // 
            this.m_cmbMenuStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbMenuStyle.FormattingEnabled = true;
            this.m_cmbMenuStyle.Location = new System.Drawing.Point(360, 38);
            this.m_cmbMenuStyle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cmbMenuStyle.Name = "m_cmbMenuStyle";
            this.m_cmbMenuStyle.Size = new System.Drawing.Size(355, 37);
            this.m_cmbMenuStyle.TabIndex = 1;
            // 
            // m_btnAltColor
            // 
            this.m_btnAltColor.Location = new System.Drawing.Point(639, 147);
            this.m_btnAltColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnAltColor.Name = "m_btnAltColor";
            this.m_btnAltColor.Size = new System.Drawing.Size(84, 48);
            this.m_btnAltColor.TabIndex = 6;
            this.m_btnAltColor.UseVisualStyleBackColor = true;
            // 
            // m_cmbBannerStyle
            // 
            this.m_cmbBannerStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbBannerStyle.FormattingEnabled = true;
            this.m_cmbBannerStyle.Location = new System.Drawing.Point(360, 93);
            this.m_cmbBannerStyle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cmbBannerStyle.Name = "m_cmbBannerStyle";
            this.m_cmbBannerStyle.Size = new System.Drawing.Size(355, 37);
            this.m_cmbBannerStyle.TabIndex = 3;
            this.m_cmbBannerStyle.SelectedIndexChanged += new System.EventHandler(this.OnBannerStyleSelectedChanged);
            // 
            // m_lblBannerStyle
            // 
            this.m_lblBannerStyle.AutoSize = true;
            this.m_lblBannerStyle.Location = new System.Drawing.Point(14, 99);
            this.m_lblBannerStyle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblBannerStyle.Name = "m_lblBannerStyle";
            this.m_lblBannerStyle.Size = new System.Drawing.Size(225, 29);
            this.m_lblBannerStyle.TabIndex = 2;
            this.m_lblBannerStyle.Text = "&Dialog banner style:";
            // 
            // m_lblMenuStyle
            // 
            this.m_lblMenuStyle.AutoSize = true;
            this.m_lblMenuStyle.Location = new System.Drawing.Point(14, 44);
            this.m_lblMenuStyle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblMenuStyle.Name = "m_lblMenuStyle";
            this.m_lblMenuStyle.Size = new System.Drawing.Size(261, 29);
            this.m_lblMenuStyle.TabIndex = 0;
            this.m_lblMenuStyle.Text = "&Menu and toolbar style:";
            // 
            // m_tabIntegration
            // 
            this.m_tabIntegration.Controls.Add(this.m_btnHelpSource);
            this.m_tabIntegration.Controls.Add(this.m_btnSchemeOverrides);
            this.m_tabIntegration.Controls.Add(this.m_cbAutoRun);
            this.m_tabIntegration.Controls.Add(this.m_grpFileExt);
            this.m_tabIntegration.Controls.Add(this.m_grpHotKeys);
            this.m_tabIntegration.Location = new System.Drawing.Point(4, 38);
            this.m_tabIntegration.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabIntegration.Name = "m_tabIntegration";
            this.m_tabIntegration.Size = new System.Drawing.Size(1256, 714);
            this.m_tabIntegration.TabIndex = 4;
            this.m_tabIntegration.Text = "Integration";
            this.m_tabIntegration.UseVisualStyleBackColor = true;
            // 
            // m_btnHelpSource
            // 
            this.m_btnHelpSource.Location = new System.Drawing.Point(978, 638);
            this.m_btnHelpSource.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnHelpSource.Name = "m_btnHelpSource";
            this.m_btnHelpSource.Size = new System.Drawing.Size(252, 48);
            this.m_btnHelpSource.TabIndex = 4;
            this.m_btnHelpSource.Text = "&Help Source...";
            this.m_btnHelpSource.UseVisualStyleBackColor = true;
            this.m_btnHelpSource.Click += new System.EventHandler(this.OnBtnHelpSource);
            // 
            // m_btnSchemeOverrides
            // 
            this.m_btnSchemeOverrides.Location = new System.Drawing.Point(714, 638);
            this.m_btnSchemeOverrides.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnSchemeOverrides.Name = "m_btnSchemeOverrides";
            this.m_btnSchemeOverrides.Size = new System.Drawing.Size(252, 48);
            this.m_btnSchemeOverrides.TabIndex = 3;
            this.m_btnSchemeOverrides.Text = "URL &Overrides...";
            this.m_btnSchemeOverrides.UseVisualStyleBackColor = true;
            this.m_btnSchemeOverrides.Click += new System.EventHandler(this.OnBtnUrlOverrides);
            // 
            // m_cbAutoRun
            // 
            this.m_cbAutoRun.AutoSize = true;
            this.m_cbAutoRun.Location = new System.Drawing.Point(14, 513);
            this.m_cbAutoRun.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbAutoRun.Name = "m_cbAutoRun";
            this.m_cbAutoRun.Size = new System.Drawing.Size(542, 33);
            this.m_cbAutoRun.TabIndex = 2;
            this.m_cbAutoRun.Text = "R&un KeePass at Windows startup (current user)";
            this.m_cbAutoRun.UseVisualStyleBackColor = true;
            this.m_cbAutoRun.CheckedChanged += new System.EventHandler(this.OnCheckedChangedAutoRun);
            // 
            // m_grpFileExt
            // 
            this.m_grpFileExt.Controls.Add(this.m_btnFileExtRemove);
            this.m_grpFileExt.Controls.Add(this.m_btnFileExtCreate);
            this.m_grpFileExt.Controls.Add(this.m_lblFileExtHint);
            this.m_grpFileExt.Location = new System.Drawing.Point(14, 309);
            this.m_grpFileExt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpFileExt.Name = "m_grpFileExt";
            this.m_grpFileExt.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpFileExt.Size = new System.Drawing.Size(1215, 177);
            this.m_grpFileExt.TabIndex = 1;
            this.m_grpFileExt.TabStop = false;
            this.m_grpFileExt.Text = "KDBX file association";
            // 
            // m_btnFileExtRemove
            // 
            this.m_btnFileExtRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_btnFileExtRemove.Location = new System.Drawing.Point(328, 108);
            this.m_btnFileExtRemove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnFileExtRemove.Name = "m_btnFileExtRemove";
            this.m_btnFileExtRemove.Size = new System.Drawing.Size(303, 48);
            this.m_btnFileExtRemove.TabIndex = 2;
            this.m_btnFileExtRemove.Text = "&Remove Association";
            this.m_btnFileExtRemove.UseVisualStyleBackColor = true;
            this.m_btnFileExtRemove.Click += new System.EventHandler(this.OnBtnFileExtRemove);
            // 
            // m_btnFileExtCreate
            // 
            this.m_btnFileExtCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_btnFileExtCreate.Location = new System.Drawing.Point(21, 108);
            this.m_btnFileExtCreate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnFileExtCreate.Name = "m_btnFileExtCreate";
            this.m_btnFileExtCreate.Size = new System.Drawing.Size(294, 48);
            this.m_btnFileExtCreate.TabIndex = 1;
            this.m_btnFileExtCreate.Text = "&Create Association";
            this.m_btnFileExtCreate.UseVisualStyleBackColor = true;
            this.m_btnFileExtCreate.Click += new System.EventHandler(this.OnBtnFileExtCreate);
            // 
            // m_lblFileExtHint
            // 
            this.m_lblFileExtHint.Location = new System.Drawing.Point(14, 44);
            this.m_lblFileExtHint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblFileExtHint.Name = "m_lblFileExtHint";
            this.m_lblFileExtHint.Size = new System.Drawing.Size(1182, 58);
            this.m_lblFileExtHint.TabIndex = 0;
            this.m_lblFileExtHint.Text = "KDBX files can be associated with KeePass. When you double-click a KDBX file in W" +
    "indows Explorer, they will automatically be opened by KeePass.";
            // 
            // m_grpHotKeys
            // 
            this.m_grpHotKeys.Controls.Add(this.m_lblAutoTypePassword);
            this.m_grpHotKeys.Controls.Add(this.m_hkAutoTypePassword);
            this.m_grpHotKeys.Controls.Add(this.m_linkHotKeyHelp);
            this.m_grpHotKeys.Controls.Add(this.m_lblAutoTypeSelected);
            this.m_grpHotKeys.Controls.Add(this.m_hkAutoTypeSelected);
            this.m_grpHotKeys.Controls.Add(this.m_hkShowWindow);
            this.m_grpHotKeys.Controls.Add(this.m_lblAutoType);
            this.m_grpHotKeys.Controls.Add(this.m_lblShowWindow);
            this.m_grpHotKeys.Controls.Add(this.m_hkAutoType);
            this.m_grpHotKeys.Location = new System.Drawing.Point(14, 26);
            this.m_grpHotKeys.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpHotKeys.Name = "m_grpHotKeys";
            this.m_grpHotKeys.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpHotKeys.Size = new System.Drawing.Size(1215, 268);
            this.m_grpHotKeys.TabIndex = 0;
            this.m_grpHotKeys.TabStop = false;
            this.m_grpHotKeys.Text = "System-wide hot keys";
            // 
            // m_lblAutoTypePassword
            // 
            this.m_lblAutoTypePassword.AutoSize = true;
            this.m_lblAutoTypePassword.Location = new System.Drawing.Point(14, 98);
            this.m_lblAutoTypePassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblAutoTypePassword.Name = "m_lblAutoTypePassword";
            this.m_lblAutoTypePassword.Size = new System.Drawing.Size(370, 29);
            this.m_lblAutoTypePassword.TabIndex = 3;
            this.m_lblAutoTypePassword.Text = "Global auto-type - password only:";
            // 
            // m_hkAutoTypePassword
            // 
            this.m_hkAutoTypePassword.Location = new System.Drawing.Point(393, 92);
            this.m_hkAutoTypePassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_hkAutoTypePassword.Name = "m_hkAutoTypePassword";
            this.m_hkAutoTypePassword.Size = new System.Drawing.Size(400, 33);
            this.m_hkAutoTypePassword.TabIndex = 4;
            // 
            // m_linkHotKeyHelp
            // 
            this.m_linkHotKeyHelp.AutoSize = true;
            this.m_linkHotKeyHelp.Location = new System.Drawing.Point(860, 44);
            this.m_linkHotKeyHelp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_linkHotKeyHelp.Name = "m_linkHotKeyHelp";
            this.m_linkHotKeyHelp.Size = new System.Drawing.Size(339, 29);
            this.m_linkHotKeyHelp.TabIndex = 2;
            this.m_linkHotKeyHelp.TabStop = true;
            this.m_linkHotKeyHelp.Text = "Creating system-wide hot keys";
            this.m_linkHotKeyHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnHotKeyHelpLinkClicked);
            // 
            // m_lblAutoTypeSelected
            // 
            this.m_lblAutoTypeSelected.AutoSize = true;
            this.m_lblAutoTypeSelected.Location = new System.Drawing.Point(14, 152);
            this.m_lblAutoTypeSelected.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblAutoTypeSelected.Name = "m_lblAutoTypeSelected";
            this.m_lblAutoTypeSelected.Size = new System.Drawing.Size(276, 29);
            this.m_lblAutoTypeSelected.TabIndex = 5;
            this.m_lblAutoTypeSelected.Text = "Auto-type selected entry:";
            // 
            // m_hkAutoTypeSelected
            // 
            this.m_hkAutoTypeSelected.Location = new System.Drawing.Point(393, 146);
            this.m_hkAutoTypeSelected.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_hkAutoTypeSelected.Name = "m_hkAutoTypeSelected";
            this.m_hkAutoTypeSelected.Size = new System.Drawing.Size(400, 33);
            this.m_hkAutoTypeSelected.TabIndex = 6;
            // 
            // m_hkShowWindow
            // 
            this.m_hkShowWindow.Location = new System.Drawing.Point(393, 200);
            this.m_hkShowWindow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_hkShowWindow.Name = "m_hkShowWindow";
            this.m_hkShowWindow.Size = new System.Drawing.Size(400, 33);
            this.m_hkShowWindow.TabIndex = 8;
            // 
            // m_lblAutoType
            // 
            this.m_lblAutoType.AutoSize = true;
            this.m_lblAutoType.Location = new System.Drawing.Point(14, 44);
            this.m_lblAutoType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblAutoType.Name = "m_lblAutoType";
            this.m_lblAutoType.Size = new System.Drawing.Size(195, 29);
            this.m_lblAutoType.TabIndex = 0;
            this.m_lblAutoType.Text = "Global auto-type:";
            // 
            // m_lblShowWindow
            // 
            this.m_lblShowWindow.AutoSize = true;
            this.m_lblShowWindow.Location = new System.Drawing.Point(14, 206);
            this.m_lblShowWindow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblShowWindow.Name = "m_lblShowWindow";
            this.m_lblShowWindow.Size = new System.Drawing.Size(272, 29);
            this.m_lblShowWindow.TabIndex = 7;
            this.m_lblShowWindow.Text = "Show KeePass window:";
            // 
            // m_hkAutoType
            // 
            this.m_hkAutoType.Location = new System.Drawing.Point(393, 38);
            this.m_hkAutoType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_hkAutoType.Name = "m_hkAutoType";
            this.m_hkAutoType.Size = new System.Drawing.Size(400, 33);
            this.m_hkAutoType.TabIndex = 1;
            // 
            // m_tabAdvanced
            // 
            this.m_tabAdvanced.Controls.Add(this.m_btnProxy);
            this.m_tabAdvanced.Controls.Add(this.m_lvAdvanced);
            this.m_tabAdvanced.Location = new System.Drawing.Point(4, 38);
            this.m_tabAdvanced.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabAdvanced.Name = "m_tabAdvanced";
            this.m_tabAdvanced.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tabAdvanced.Size = new System.Drawing.Size(1256, 714);
            this.m_tabAdvanced.TabIndex = 1;
            this.m_tabAdvanced.Text = "Advanced";
            this.m_tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // m_btnProxy
            // 
            this.m_btnProxy.Location = new System.Drawing.Point(1062, 638);
            this.m_btnProxy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnProxy.Name = "m_btnProxy";
            this.m_btnProxy.Size = new System.Drawing.Size(168, 48);
            this.m_btnProxy.TabIndex = 1;
            this.m_btnProxy.Text = "&Proxy...";
            this.m_btnProxy.UseVisualStyleBackColor = true;
            this.m_btnProxy.Click += new System.EventHandler(this.OnBtnProxy);
            // 
            // m_lvAdvanced
            // 
            this.m_lvAdvanced.CheckBoxes = true;
            this.m_lvAdvanced.FullRowSelect = true;
            this.m_lvAdvanced.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.m_lvAdvanced.HideSelection = false;
            this.m_lvAdvanced.Location = new System.Drawing.Point(14, 26);
            this.m_lvAdvanced.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_lvAdvanced.Name = "m_lvAdvanced";
            this.m_lvAdvanced.ShowItemToolTips = true;
            this.m_lvAdvanced.Size = new System.Drawing.Size(1210, 596);
            this.m_lvAdvanced.TabIndex = 0;
            this.m_lvAdvanced.UseCompatibleStateImageBehavior = false;
            this.m_lvAdvanced.View = System.Windows.Forms.View.Details;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(1318, 978);
            this.Controls.Add(this.m_tabMain);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOK);
            this.Controls.Add(this.m_bannerImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.m_tabMain.ResumeLayout(false);
            this.m_tabSecurity.ResumeLayout(false);
            this.m_tabSecurity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numLockAfterGlobalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numClipClearTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numDefaultExpireDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numLockAfterTime)).EndInit();
            this.m_tabPolicy.ResumeLayout(false);
            this.m_tabPolicy.PerformLayout();
            this.m_tabGui1.ResumeLayout(false);
            this.m_tabGui2.ResumeLayout(false);
            this.m_grpIntAdv.ResumeLayout(false);
            this.m_grpIntAdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numMruCount)).EndInit();
            this.m_grpFonts.ResumeLayout(false);
            this.m_grpFonts.PerformLayout();
            this.m_grpStyles.ResumeLayout(false);
            this.m_grpStyles.PerformLayout();
            this.m_tabIntegration.ResumeLayout(false);
            this.m_tabIntegration.PerformLayout();
            this.m_grpFileExt.ResumeLayout(false);
            this.m_grpHotKeys.ResumeLayout(false);
            this.m_grpHotKeys.PerformLayout();
            this.m_tabAdvanced.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.TabControl m_tabMain;
		private System.Windows.Forms.TabPage m_tabSecurity;
		private System.Windows.Forms.TabPage m_tabAdvanced;
		private System.Windows.Forms.TabPage m_tabGui1;
		private System.Windows.Forms.CheckBox m_cbLockAfterTime;
		private System.Windows.Forms.NumericUpDown m_numLockAfterTime;
		private System.Windows.Forms.TabPage m_tabPolicy;
		private System.Windows.Forms.LinkLabel m_linkPolicyInfo;
		private System.Windows.Forms.Label m_lblPolicyMore;
		private System.Windows.Forms.Label m_lblPolicyRestart;
		private System.Windows.Forms.Label m_lblPolicyIntro;
		private KeePass.UI.CustomListViewEx m_lvPolicy;
		private KeePass.UI.CustomListViewEx m_lvGuiOptions;
		private System.Windows.Forms.TabPage m_tabIntegration;
		private KeePass.UI.HotKeyControlEx m_hkAutoType;
		private System.Windows.Forms.Label m_lblAutoType;
		private System.Windows.Forms.GroupBox m_grpHotKeys;
		private KeePass.UI.HotKeyControlEx m_hkShowWindow;
		private System.Windows.Forms.Label m_lblShowWindow;
		private System.Windows.Forms.CheckBox m_cbDefaultExpireDays;
		private System.Windows.Forms.NumericUpDown m_numDefaultExpireDays;
		private System.Windows.Forms.NumericUpDown m_numClipClearTime;
		private System.Windows.Forms.CheckBox m_cbClipClearTime;
		private System.Windows.Forms.Button m_btnFileExtRemove;
		private System.Windows.Forms.GroupBox m_grpFileExt;
		private System.Windows.Forms.Button m_btnFileExtCreate;
		private System.Windows.Forms.Label m_lblFileExtHint;
		private System.Windows.Forms.CheckBox m_cbAutoRun;
		private KeePass.UI.CustomListViewEx m_lvAdvanced;
		private KeePass.UI.CustomListViewEx m_lvSecurityOptions;
		private System.Windows.Forms.Button m_btnSchemeOverrides;
		private System.Windows.Forms.Label m_lblAutoTypeSelected;
		private KeePass.UI.HotKeyControlEx m_hkAutoTypeSelected;
		private System.Windows.Forms.LinkLabel m_linkHotKeyHelp;
		private System.Windows.Forms.CheckBox m_cbLockAfterGlobalTime;
		private System.Windows.Forms.NumericUpDown m_numLockAfterGlobalTime;
		private System.Windows.Forms.Button m_btnProxy;
		private System.Windows.Forms.ToolTip m_ttRect;
		private System.Windows.Forms.Label m_lblAutoTypePassword;
		private KeePass.UI.HotKeyControlEx m_hkAutoTypePassword;
		private System.Windows.Forms.Button m_btnHelpSource;
		private System.Windows.Forms.Label m_lblSecOpt;
		private System.Windows.Forms.LinkLabel m_linkSecOptAdm;
		private System.Windows.Forms.LinkLabel m_linkSecOptEx;
		private System.Windows.Forms.TabPage m_tabGui2;
		private System.Windows.Forms.ComboBox m_cmbMenuStyle;
		private System.Windows.Forms.Label m_lblMenuStyle;
		private System.Windows.Forms.Label m_lblBannerStyle;
		private System.Windows.Forms.ComboBox m_cmbBannerStyle;
		private System.Windows.Forms.ComboBox m_cmbEscAction;
		private System.Windows.Forms.Label m_lblEscAction;
		private System.Windows.Forms.NumericUpDown m_numMruCount;
		private System.Windows.Forms.Label m_lblMruCount;
		private System.Windows.Forms.CheckBox m_cbListFont;
		private System.Windows.Forms.Button m_btnPasswordFont;
		private System.Windows.Forms.CheckBox m_cbPasswordFont;
		private System.Windows.Forms.Button m_btnListFont;
		private KeePass.UI.ColorButtonEx m_btnAltColor;
		private System.Windows.Forms.GroupBox m_grpFonts;
		private System.Windows.Forms.GroupBox m_grpStyles;
		private System.Windows.Forms.GroupBox m_grpIntAdv;
		private System.Windows.Forms.LinkLabel m_linkTheme;
		private System.Windows.Forms.LinkLabel m_linkMainFont;
		private System.Windows.Forms.ComboBox m_cmbAltColor;
		private System.Windows.Forms.Label m_lblAltColor;
	}
}