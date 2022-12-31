﻿namespace KeePass.Forms
{
	partial class EditStringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStringForm));
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.m_lblStringValueDesc = new System.Windows.Forms.Label();
            this.m_lblStringIdDesc = new System.Windows.Forms.Label();
            this.m_lblIDIntro = new System.Windows.Forms.Label();
            this.m_rtbValue = new KeePass.UI.CustomRichTextBoxEx();
            this.m_lblSeparator = new System.Windows.Forms.Label();
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_btnHelp = new System.Windows.Forms.Button();
            this.m_cbProtect = new System.Windows.Forms.CheckBox();
            this.m_lblValidationInfo = new System.Windows.Forms.Label();
            this.m_cmbName = new System.Windows.Forms.ComboBox();
            this.m_btnGenPw = new System.Windows.Forms.Button();
            this.m_ttRect = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // m_bannerImage
            // 
            this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
            this.m_bannerImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_bannerImage.Name = "m_bannerImage";
            this.m_bannerImage.Size = new System.Drawing.Size(818, 111);
            this.m_bannerImage.TabIndex = 0;
            this.m_bannerImage.TabStop = false;
            // 
            // m_lblStringValueDesc
            // 
            this.m_lblStringValueDesc.AutoSize = true;
            this.m_lblStringValueDesc.Location = new System.Drawing.Point(24, 288);
            this.m_lblStringValueDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblStringValueDesc.Name = "m_lblStringValueDesc";
            this.m_lblStringValueDesc.Size = new System.Drawing.Size(69, 25);
            this.m_lblStringValueDesc.TabIndex = 4;
            this.m_lblStringValueDesc.Text = "&Value:";
            // 
            // m_lblStringIdDesc
            // 
            this.m_lblStringIdDesc.AutoSize = true;
            this.m_lblStringIdDesc.Location = new System.Drawing.Point(24, 214);
            this.m_lblStringIdDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblStringIdDesc.Name = "m_lblStringIdDesc";
            this.m_lblStringIdDesc.Size = new System.Drawing.Size(70, 25);
            this.m_lblStringIdDesc.TabIndex = 1;
            this.m_lblStringIdDesc.Text = "&Name:";
            // 
            // m_lblIDIntro
            // 
            this.m_lblIDIntro.Location = new System.Drawing.Point(24, 123);
            this.m_lblIDIntro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblIDIntro.Name = "m_lblIDIntro";
            this.m_lblIDIntro.Size = new System.Drawing.Size(770, 74);
            this.m_lblIDIntro.TabIndex = 0;
            this.m_lblIDIntro.Text = resources.GetString("m_lblIDIntro.Text");
            // 
            // m_rtbValue
            // 
            this.m_rtbValue.Location = new System.Drawing.Point(112, 285);
            this.m_rtbValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_rtbValue.Name = "m_rtbValue";
            this.m_rtbValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.m_rtbValue.Size = new System.Drawing.Size(678, 140);
            this.m_rtbValue.TabIndex = 5;
            this.m_rtbValue.Text = "";
            // 
            // m_lblSeparator
            // 
            this.m_lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lblSeparator.Location = new System.Drawing.Point(0, 501);
            this.m_lblSeparator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblSeparator.Name = "m_lblSeparator";
            this.m_lblSeparator.Size = new System.Drawing.Size(818, 3);
            this.m_lblSeparator.TabIndex = 8;
            // 
            // m_btnOK
            // 
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(482, 520);
            this.m_btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(150, 42);
            this.m_btnOK.TabIndex = 10;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(644, 520);
            this.m_btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(150, 42);
            this.m_btnCancel.TabIndex = 11;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
            // 
            // m_btnHelp
            // 
            this.m_btnHelp.Location = new System.Drawing.Point(24, 520);
            this.m_btnHelp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnHelp.Name = "m_btnHelp";
            this.m_btnHelp.Size = new System.Drawing.Size(150, 42);
            this.m_btnHelp.TabIndex = 9;
            this.m_btnHelp.Text = "&Help";
            this.m_btnHelp.UseVisualStyleBackColor = true;
            this.m_btnHelp.Click += new System.EventHandler(this.OnBtnHelp);
            // 
            // m_cbProtect
            // 
            this.m_cbProtect.AutoSize = true;
            this.m_cbProtect.Location = new System.Drawing.Point(112, 447);
            this.m_cbProtect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbProtect.Name = "m_cbProtect";
            this.m_cbProtect.Size = new System.Drawing.Size(320, 29);
            this.m_cbProtect.TabIndex = 6;
            this.m_cbProtect.Text = "&Protect value in process memory";
            this.m_cbProtect.UseVisualStyleBackColor = true;
            // 
            // m_lblValidationInfo
            // 
            this.m_lblValidationInfo.ForeColor = System.Drawing.Color.Crimson;
            this.m_lblValidationInfo.Location = new System.Drawing.Point(106, 254);
            this.m_lblValidationInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblValidationInfo.Name = "m_lblValidationInfo";
            this.m_lblValidationInfo.Size = new System.Drawing.Size(688, 26);
            this.m_lblValidationInfo.TabIndex = 3;
            this.m_lblValidationInfo.Text = "<>";
            // 
            // m_cmbName
            // 
            this.m_cmbName.FormattingEnabled = true;
            this.m_cmbName.Location = new System.Drawing.Point(112, 208);
            this.m_cmbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cmbName.Name = "m_cmbName";
            this.m_cmbName.Size = new System.Drawing.Size(678, 33);
            this.m_cmbName.TabIndex = 2;
            this.m_cmbName.TextChanged += new System.EventHandler(this.OnNameTextChanged);
            // 
            // m_btnGenPw
            // 
            this.m_btnGenPw.Location = new System.Drawing.Point(730, 440);
            this.m_btnGenPw.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnGenPw.Name = "m_btnGenPw";
            this.m_btnGenPw.Size = new System.Drawing.Size(64, 42);
            this.m_btnGenPw.TabIndex = 7;
            this.m_btnGenPw.UseVisualStyleBackColor = true;
            // 
            // EditStringForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(818, 585);
            this.Controls.Add(this.m_btnGenPw);
            this.Controls.Add(this.m_cmbName);
            this.Controls.Add(this.m_lblValidationInfo);
            this.Controls.Add(this.m_cbProtect);
            this.Controls.Add(this.m_btnHelp);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOK);
            this.Controls.Add(this.m_lblSeparator);
            this.Controls.Add(this.m_rtbValue);
            this.Controls.Add(this.m_lblIDIntro);
            this.Controls.Add(this.m_lblStringIdDesc);
            this.Controls.Add(this.m_lblStringValueDesc);
            this.Controls.Add(this.m_bannerImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStringForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Entry String";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Label m_lblStringValueDesc;
		private System.Windows.Forms.Label m_lblStringIdDesc;
		private System.Windows.Forms.Label m_lblIDIntro;
		private KeePass.UI.CustomRichTextBoxEx m_rtbValue;
		private System.Windows.Forms.Label m_lblSeparator;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Button m_btnHelp;
		private System.Windows.Forms.CheckBox m_cbProtect;
		private System.Windows.Forms.Label m_lblValidationInfo;
		private System.Windows.Forms.ComboBox m_cmbName;
		private System.Windows.Forms.Button m_btnGenPw;
		private System.Windows.Forms.ToolTip m_ttRect;
	}
}