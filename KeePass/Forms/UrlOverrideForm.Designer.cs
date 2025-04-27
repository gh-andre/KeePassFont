namespace KeePass.Forms
{
	partial class UrlOverrideForm
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
			if(disposing && (components != null))
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
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_lblScheme = new System.Windows.Forms.Label();
            this.m_tbScheme = new System.Windows.Forms.TextBox();
            this.m_lblUrlOverride = new System.Windows.Forms.Label();
            this.m_tbOverride = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_btnOK
            // 
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(360, 207);
            this.m_btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(168, 48);
            this.m_btnOK.TabIndex = 4;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(543, 207);
            this.m_btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(168, 48);
            this.m_btnCancel.TabIndex = 5;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            // 
            // m_lblScheme
            // 
            this.m_lblScheme.AutoSize = true;
            this.m_lblScheme.Location = new System.Drawing.Point(21, 32);
            this.m_lblScheme.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblScheme.Name = "m_lblScheme";
            this.m_lblScheme.Size = new System.Drawing.Size(108, 29);
            this.m_lblScheme.TabIndex = 0;
            this.m_lblScheme.Text = "&Scheme:";
            // 
            // m_tbScheme
            // 
            this.m_tbScheme.Location = new System.Drawing.Point(144, 26);
            this.m_tbScheme.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tbScheme.Name = "m_tbScheme";
            this.m_tbScheme.Size = new System.Drawing.Size(562, 33);
            this.m_tbScheme.TabIndex = 1;
            // 
            // m_lblUrlOverride
            // 
            this.m_lblUrlOverride.AutoSize = true;
            this.m_lblUrlOverride.Location = new System.Drawing.Point(21, 93);
            this.m_lblUrlOverride.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblUrlOverride.Name = "m_lblUrlOverride";
            this.m_lblUrlOverride.Size = new System.Drawing.Size(161, 29);
            this.m_lblUrlOverride.TabIndex = 2;
            this.m_lblUrlOverride.Text = "&URL override:";
            // 
            // m_tbOverride
            // 
            this.m_tbOverride.Location = new System.Drawing.Point(27, 130);
            this.m_tbOverride.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_tbOverride.Name = "m_tbOverride";
            this.m_tbOverride.Size = new System.Drawing.Size(679, 33);
            this.m_tbOverride.TabIndex = 3;
            // 
            // UrlOverrideForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(738, 280);
            this.Controls.Add(this.m_tbOverride);
            this.Controls.Add(this.m_lblUrlOverride);
            this.Controls.Add(this.m_tbScheme);
            this.Controls.Add(this.m_lblScheme);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrlOverrideForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "<>";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Label m_lblScheme;
		private System.Windows.Forms.TextBox m_tbScheme;
		private System.Windows.Forms.Label m_lblUrlOverride;
		private System.Windows.Forms.TextBox m_tbOverride;
	}
}