﻿namespace KeePass.Forms
{
	partial class SearchForm
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
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_tbSearch = new System.Windows.Forms.TextBox();
			this.m_lblSearchFor = new System.Windows.Forms.Label();
			this.m_grpSearchIn = new System.Windows.Forms.GroupBox();
			this.m_cbGroupPath = new System.Windows.Forms.CheckBox();
			this.m_cbStringName = new System.Windows.Forms.CheckBox();
			this.m_cbTags = new System.Windows.Forms.CheckBox();
			this.m_cbGroupName = new System.Windows.Forms.CheckBox();
			this.m_cbUuid = new System.Windows.Forms.CheckBox();
			this.m_cbOtherFields = new System.Windows.Forms.CheckBox();
			this.m_cbNotes = new System.Windows.Forms.CheckBox();
			this.m_cbURL = new System.Windows.Forms.CheckBox();
			this.m_cbPassword = new System.Windows.Forms.CheckBox();
			this.m_cbUserName = new System.Windows.Forms.CheckBox();
			this.m_cbTitle = new System.Windows.Forms.CheckBox();
			this.m_grpOptions = new System.Windows.Forms.GroupBox();
			this.m_cbIgnoreGroupSettings = new System.Windows.Forms.CheckBox();
			this.m_cbDerefData = new System.Windows.Forms.CheckBox();
			this.m_cbExcludeExpired = new System.Windows.Forms.CheckBox();
			this.m_cbCaseSensitive = new System.Windows.Forms.CheckBox();
			this.m_cbRegEx = new System.Windows.Forms.CheckBox();
			this.m_lblHints = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			this.m_grpSearchIn.SuspendLayout();
			this.m_grpOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_bannerImage
			// 
			this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
			this.m_bannerImage.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.Size = new System.Drawing.Size(936, 148);
			this.m_bannerImage.TabIndex = 0;
			this.m_bannerImage.TabStop = false;
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(488, 962);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(200, 56);
			this.m_btnOK.TabIndex = 6;
			this.m_btnOK.Text = "&Find";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(704, 962);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(200, 56);
			this.m_btnCancel.TabIndex = 7;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
			// 
			// m_tbSearch
			// 
			this.m_tbSearch.Location = new System.Drawing.Point(198, 170);
			this.m_tbSearch.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_tbSearch.Name = "m_tbSearch";
			this.m_tbSearch.Size = new System.Drawing.Size(700, 37);
			this.m_tbSearch.TabIndex = 1;
			// 
			// m_lblSearchFor
			// 
			this.m_lblSearchFor.AutoSize = true;
			this.m_lblSearchFor.Location = new System.Drawing.Point(32, 178);
			this.m_lblSearchFor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblSearchFor.Name = "m_lblSearchFor";
			this.m_lblSearchFor.Size = new System.Drawing.Size(131, 30);
			this.m_lblSearchFor.TabIndex = 0;
			this.m_lblSearchFor.Text = "Find &what:";
			// 
			// m_grpSearchIn
			// 
			this.m_grpSearchIn.Controls.Add(this.m_cbGroupPath);
			this.m_grpSearchIn.Controls.Add(this.m_cbStringName);
			this.m_grpSearchIn.Controls.Add(this.m_cbTags);
			this.m_grpSearchIn.Controls.Add(this.m_cbGroupName);
			this.m_grpSearchIn.Controls.Add(this.m_cbUuid);
			this.m_grpSearchIn.Controls.Add(this.m_cbOtherFields);
			this.m_grpSearchIn.Controls.Add(this.m_cbNotes);
			this.m_grpSearchIn.Controls.Add(this.m_cbURL);
			this.m_grpSearchIn.Controls.Add(this.m_cbPassword);
			this.m_grpSearchIn.Controls.Add(this.m_cbUserName);
			this.m_grpSearchIn.Controls.Add(this.m_cbTitle);
			this.m_grpSearchIn.Location = new System.Drawing.Point(32, 370);
			this.m_grpSearchIn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_grpSearchIn.Name = "m_grpSearchIn";
			this.m_grpSearchIn.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_grpSearchIn.Size = new System.Drawing.Size(872, 276);
			this.m_grpSearchIn.TabIndex = 4;
			this.m_grpSearchIn.TabStop = false;
			this.m_grpSearchIn.Text = "Search in";
			// 
			// m_cbGroupPath
			// 
			this.m_cbGroupPath.AutoSize = true;
			this.m_cbGroupPath.Location = new System.Drawing.Point(24, 216);
			this.m_cbGroupPath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbGroupPath.Name = "m_cbGroupPath";
			this.m_cbGroupPath.Size = new System.Drawing.Size(172, 34);
			this.m_cbGroupPath.TabIndex = 9;
			this.m_cbGroupPath.Text = "Group pat&h";
			this.m_cbGroupPath.UseVisualStyleBackColor = true;
			this.m_cbGroupPath.CheckedChanged += new System.EventHandler(this.OnGroupPathCheckedChanged);
			// 
			// m_cbStringName
			// 
			this.m_cbStringName.AutoSize = true;
			this.m_cbStringName.Location = new System.Drawing.Point(24, 160);
			this.m_cbStringName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbStringName.Name = "m_cbStringName";
			this.m_cbStringName.Size = new System.Drawing.Size(183, 34);
			this.m_cbStringName.TabIndex = 6;
			this.m_cbStringName.Text = "&String name";
			this.m_cbStringName.UseVisualStyleBackColor = true;
			// 
			// m_cbTags
			// 
			this.m_cbTags.AutoSize = true;
			this.m_cbTags.Location = new System.Drawing.Point(302, 160);
			this.m_cbTags.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbTags.Name = "m_cbTags";
			this.m_cbTags.Size = new System.Drawing.Size(102, 34);
			this.m_cbTags.TabIndex = 7;
			this.m_cbTags.Text = "T&ags";
			this.m_cbTags.UseVisualStyleBackColor = true;
			// 
			// m_cbGroupName
			// 
			this.m_cbGroupName.AutoSize = true;
			this.m_cbGroupName.Location = new System.Drawing.Point(302, 216);
			this.m_cbGroupName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbGroupName.Name = "m_cbGroupName";
			this.m_cbGroupName.Size = new System.Drawing.Size(187, 34);
			this.m_cbGroupName.TabIndex = 10;
			this.m_cbGroupName.Text = "&Group name";
			this.m_cbGroupName.UseVisualStyleBackColor = true;
			// 
			// m_cbUuid
			// 
			this.m_cbUuid.AutoSize = true;
			this.m_cbUuid.Location = new System.Drawing.Point(578, 160);
			this.m_cbUuid.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbUuid.Name = "m_cbUuid";
			this.m_cbUuid.Size = new System.Drawing.Size(108, 34);
			this.m_cbUuid.TabIndex = 8;
			this.m_cbUuid.Text = "UU&ID";
			this.m_cbUuid.UseVisualStyleBackColor = true;
			// 
			// m_cbOtherFields
			// 
			this.m_cbOtherFields.AutoSize = true;
			this.m_cbOtherFields.Location = new System.Drawing.Point(578, 104);
			this.m_cbOtherFields.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbOtherFields.Name = "m_cbOtherFields";
			this.m_cbOtherFields.Size = new System.Drawing.Size(176, 34);
			this.m_cbOtherFields.TabIndex = 5;
			this.m_cbOtherFields.Text = "&Other fields";
			this.m_cbOtherFields.UseVisualStyleBackColor = true;
			// 
			// m_cbNotes
			// 
			this.m_cbNotes.AutoSize = true;
			this.m_cbNotes.Location = new System.Drawing.Point(302, 104);
			this.m_cbNotes.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbNotes.Name = "m_cbNotes";
			this.m_cbNotes.Size = new System.Drawing.Size(112, 34);
			this.m_cbNotes.TabIndex = 4;
			this.m_cbNotes.Text = "&Notes";
			this.m_cbNotes.UseVisualStyleBackColor = true;
			// 
			// m_cbURL
			// 
			this.m_cbURL.AutoSize = true;
			this.m_cbURL.Location = new System.Drawing.Point(24, 104);
			this.m_cbURL.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbURL.Name = "m_cbURL";
			this.m_cbURL.Size = new System.Drawing.Size(97, 34);
			this.m_cbURL.TabIndex = 3;
			this.m_cbURL.Text = "UR&L";
			this.m_cbURL.UseVisualStyleBackColor = true;
			// 
			// m_cbPassword
			// 
			this.m_cbPassword.AutoSize = true;
			this.m_cbPassword.Location = new System.Drawing.Point(578, 46);
			this.m_cbPassword.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbPassword.Name = "m_cbPassword";
			this.m_cbPassword.Size = new System.Drawing.Size(158, 34);
			this.m_cbPassword.TabIndex = 2;
			this.m_cbPassword.Text = "&Password";
			this.m_cbPassword.UseVisualStyleBackColor = true;
			// 
			// m_cbUserName
			// 
			this.m_cbUserName.AutoSize = true;
			this.m_cbUserName.Location = new System.Drawing.Point(302, 46);
			this.m_cbUserName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbUserName.Name = "m_cbUserName";
			this.m_cbUserName.Size = new System.Drawing.Size(171, 34);
			this.m_cbUserName.TabIndex = 1;
			this.m_cbUserName.Text = "&User name";
			this.m_cbUserName.UseVisualStyleBackColor = true;
			// 
			// m_cbTitle
			// 
			this.m_cbTitle.AutoSize = true;
			this.m_cbTitle.Location = new System.Drawing.Point(24, 46);
			this.m_cbTitle.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbTitle.Name = "m_cbTitle";
			this.m_cbTitle.Size = new System.Drawing.Size(94, 34);
			this.m_cbTitle.TabIndex = 0;
			this.m_cbTitle.Text = "&Title";
			this.m_cbTitle.UseVisualStyleBackColor = true;
			// 
			// m_grpOptions
			// 
			this.m_grpOptions.Controls.Add(this.m_cbIgnoreGroupSettings);
			this.m_grpOptions.Controls.Add(this.m_cbDerefData);
			this.m_grpOptions.Controls.Add(this.m_cbExcludeExpired);
			this.m_grpOptions.Controls.Add(this.m_cbCaseSensitive);
			this.m_grpOptions.Location = new System.Drawing.Point(32, 660);
			this.m_grpOptions.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_grpOptions.Name = "m_grpOptions";
			this.m_grpOptions.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_grpOptions.Size = new System.Drawing.Size(872, 276);
			this.m_grpOptions.TabIndex = 5;
			this.m_grpOptions.TabStop = false;
			this.m_grpOptions.Text = "Options";
			// 
			// m_cbIgnoreGroupSettings
			// 
			this.m_cbIgnoreGroupSettings.AutoSize = true;
			this.m_cbIgnoreGroupSettings.Location = new System.Drawing.Point(24, 160);
			this.m_cbIgnoreGroupSettings.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbIgnoreGroupSettings.Name = "m_cbIgnoreGroupSettings";
			this.m_cbIgnoreGroupSettings.Size = new System.Drawing.Size(408, 34);
			this.m_cbIgnoreGroupSettings.TabIndex = 2;
			this.m_cbIgnoreGroupSettings.Text = "Ignor&e search settings of groups";
			this.m_cbIgnoreGroupSettings.UseVisualStyleBackColor = true;
			// 
			// m_cbDerefData
			// 
			this.m_cbDerefData.AutoSize = true;
			this.m_cbDerefData.Location = new System.Drawing.Point(24, 216);
			this.m_cbDerefData.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbDerefData.Name = "m_cbDerefData";
			this.m_cbDerefData.Size = new System.Drawing.Size(320, 34);
			this.m_cbDerefData.TabIndex = 3;
			this.m_cbDerefData.Text = "Resol&ve field references";
			this.m_cbDerefData.UseVisualStyleBackColor = true;
			// 
			// m_cbExcludeExpired
			// 
			this.m_cbExcludeExpired.AutoSize = true;
			this.m_cbExcludeExpired.Location = new System.Drawing.Point(24, 104);
			this.m_cbExcludeExpired.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbExcludeExpired.Name = "m_cbExcludeExpired";
			this.m_cbExcludeExpired.Size = new System.Drawing.Size(309, 34);
			this.m_cbExcludeExpired.TabIndex = 1;
			this.m_cbExcludeExpired.Text = "E&xclude expired entries";
			this.m_cbExcludeExpired.UseVisualStyleBackColor = true;
			// 
			// m_cbCaseSensitive
			// 
			this.m_cbCaseSensitive.AutoSize = true;
			this.m_cbCaseSensitive.Location = new System.Drawing.Point(24, 46);
			this.m_cbCaseSensitive.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbCaseSensitive.Name = "m_cbCaseSensitive";
			this.m_cbCaseSensitive.Size = new System.Drawing.Size(214, 34);
			this.m_cbCaseSensitive.TabIndex = 0;
			this.m_cbCaseSensitive.Text = "&Case-sensitive";
			this.m_cbCaseSensitive.UseVisualStyleBackColor = true;
			// 
			// m_cbRegEx
			// 
			this.m_cbRegEx.AutoSize = true;
			this.m_cbRegEx.Location = new System.Drawing.Point(198, 234);
			this.m_cbRegEx.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbRegEx.Name = "m_cbRegEx";
			this.m_cbRegEx.Size = new System.Drawing.Size(265, 34);
			this.m_cbRegEx.TabIndex = 2;
			this.m_cbRegEx.Text = "&Regular expression";
			this.m_cbRegEx.UseVisualStyleBackColor = true;
			this.m_cbRegEx.CheckedChanged += new System.EventHandler(this.OnRegExCheckedChanged);
			// 
			// m_lblHints
			// 
			this.m_lblHints.Location = new System.Drawing.Point(190, 284);
			this.m_lblHints.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblHints.Name = "m_lblHints";
			this.m_lblHints.Size = new System.Drawing.Size(714, 72);
			this.m_lblHints.TabIndex = 3;
			this.m_lblHints.Text = "Separate multiple terms using spaces \' \'. To exclude a term, prepend a minus sign" +
    " \'-\' to it.";
			// 
			// SearchForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(936, 1048);
			this.Controls.Add(this.m_lblHints);
			this.Controls.Add(this.m_cbRegEx);
			this.Controls.Add(this.m_grpOptions);
			this.Controls.Add(this.m_grpSearchIn);
			this.Controls.Add(this.m_lblSearchFor);
			this.Controls.Add(this.m_tbSearch);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.Controls.Add(this.m_bannerImage);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Find";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.Load += new System.EventHandler(this.OnFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			this.m_grpSearchIn.ResumeLayout(false);
			this.m_grpSearchIn.PerformLayout();
			this.m_grpOptions.ResumeLayout(false);
			this.m_grpOptions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.TextBox m_tbSearch;
		private System.Windows.Forms.Label m_lblSearchFor;
		private System.Windows.Forms.GroupBox m_grpSearchIn;
		private System.Windows.Forms.CheckBox m_cbNotes;
		private System.Windows.Forms.CheckBox m_cbURL;
		private System.Windows.Forms.CheckBox m_cbPassword;
		private System.Windows.Forms.CheckBox m_cbUserName;
		private System.Windows.Forms.CheckBox m_cbTitle;
		private System.Windows.Forms.GroupBox m_grpOptions;
		private System.Windows.Forms.CheckBox m_cbCaseSensitive;
		private System.Windows.Forms.CheckBox m_cbOtherFields;
		private System.Windows.Forms.CheckBox m_cbRegEx;
		private System.Windows.Forms.CheckBox m_cbExcludeExpired;
		private System.Windows.Forms.CheckBox m_cbGroupName;
		private System.Windows.Forms.CheckBox m_cbUuid;
		private System.Windows.Forms.CheckBox m_cbTags;
		private System.Windows.Forms.CheckBox m_cbDerefData;
		private System.Windows.Forms.Label m_lblHints;
		private System.Windows.Forms.CheckBox m_cbStringName;
		private System.Windows.Forms.CheckBox m_cbGroupPath;
		private System.Windows.Forms.CheckBox m_cbIgnoreGroupSettings;
	}
}