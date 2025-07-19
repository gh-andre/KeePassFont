namespace KeePass.Forms
{
	partial class UrlOverridesForm
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
            this.m_lvOverrides = new KeePass.UI.CustomListViewEx();
            this.m_btnAdd = new System.Windows.Forms.Button();
            this.m_btnEdit = new System.Windows.Forms.Button();
            this.m_btnDelete = new System.Windows.Forms.Button();
            this.m_lblSep = new System.Windows.Forms.Label();
            this.m_cbOverrideAll = new System.Windows.Forms.CheckBox();
            this.m_tbOverrideAll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_btnOK
            // 
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_btnOK.Location = new System.Drawing.Point(960, 898);
            this.m_btnOK.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(224, 64);
            this.m_btnOK.TabIndex = 7;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_btnCancel.Location = new System.Drawing.Point(1204, 898);
            this.m_btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(224, 64);
            this.m_btnCancel.TabIndex = 8;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            // 
            // m_lvOverrides
            // 
            this.m_lvOverrides.CheckBoxes = true;
            this.m_lvOverrides.FullRowSelect = true;
            this.m_lvOverrides.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.m_lvOverrides.HideSelection = false;
            this.m_lvOverrides.Location = new System.Drawing.Point(36, 34);
            this.m_lvOverrides.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.m_lvOverrides.Name = "m_lvOverrides";
            this.m_lvOverrides.ShowItemToolTips = true;
            this.m_lvOverrides.Size = new System.Drawing.Size(1140, 702);
            this.m_lvOverrides.TabIndex = 0;
            this.m_lvOverrides.UseCompatibleStateImageBehavior = false;
            this.m_lvOverrides.View = System.Windows.Forms.View.Details;
            this.m_lvOverrides.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.OnOverridesItemChecked);
            this.m_lvOverrides.SelectedIndexChanged += new System.EventHandler(this.OnOverridesSelectedIndexChanged);
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.Location = new System.Drawing.Point(1204, 34);
            this.m_btnAdd.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.Size = new System.Drawing.Size(224, 64);
            this.m_btnAdd.TabIndex = 1;
            this.m_btnAdd.Text = "&Add...";
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.OnBtnAdd);
            // 
            // m_btnEdit
            // 
            this.m_btnEdit.Location = new System.Drawing.Point(1204, 114);
            this.m_btnEdit.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.m_btnEdit.Name = "m_btnEdit";
            this.m_btnEdit.Size = new System.Drawing.Size(224, 64);
            this.m_btnEdit.TabIndex = 2;
            this.m_btnEdit.Text = "&Edit...";
            this.m_btnEdit.UseVisualStyleBackColor = true;
            this.m_btnEdit.Click += new System.EventHandler(this.OnBtnEdit);
            // 
            // m_btnDelete
            // 
            this.m_btnDelete.Location = new System.Drawing.Point(1204, 194);
            this.m_btnDelete.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.m_btnDelete.Name = "m_btnDelete";
            this.m_btnDelete.Size = new System.Drawing.Size(224, 64);
            this.m_btnDelete.TabIndex = 3;
            this.m_btnDelete.Text = "&Delete";
            this.m_btnDelete.UseVisualStyleBackColor = true;
            this.m_btnDelete.Click += new System.EventHandler(this.OnBtnDelete);
            // 
            // m_lblSep
            // 
            this.m_lblSep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lblSep.Location = new System.Drawing.Point(0, 872);
            this.m_lblSep.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.m_lblSep.Name = "m_lblSep";
            this.m_lblSep.Size = new System.Drawing.Size(1468, 6);
            this.m_lblSep.TabIndex = 6;
            // 
            // m_cbOverrideAll
            // 
            this.m_cbOverrideAll.AutoSize = true;
            this.m_cbOverrideAll.Location = new System.Drawing.Point(36, 784);
            this.m_cbOverrideAll.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.m_cbOverrideAll.Name = "m_cbOverrideAll";
            this.m_cbOverrideAll.Size = new System.Drawing.Size(364, 40);
            this.m_cbOverrideAll.TabIndex = 4;
            this.m_cbOverrideAll.Text = "&Override all entry URLs:";
            this.m_cbOverrideAll.UseVisualStyleBackColor = true;
            this.m_cbOverrideAll.CheckedChanged += new System.EventHandler(this.OnOverrideAllCheckedChanged);
            // 
            // m_tbOverrideAll
            // 
            this.m_tbOverrideAll.Location = new System.Drawing.Point(468, 778);
            this.m_tbOverrideAll.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.m_tbOverrideAll.Name = "m_tbOverrideAll";
            this.m_tbOverrideAll.Size = new System.Drawing.Size(708, 41);
            this.m_tbOverrideAll.TabIndex = 5;
            // 
            // UrlOverridesForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(1464, 994);
            this.Controls.Add(this.m_tbOverrideAll);
            this.Controls.Add(this.m_cbOverrideAll);
            this.Controls.Add(this.m_lblSep);
            this.Controls.Add(this.m_btnDelete);
            this.Controls.Add(this.m_btnEdit);
            this.Controls.Add(this.m_btnAdd);
            this.Controls.Add(this.m_lvOverrides);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrlOverridesForm";
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
		private KeePass.UI.CustomListViewEx m_lvOverrides;
		private System.Windows.Forms.Button m_btnAdd;
		private System.Windows.Forms.Button m_btnEdit;
		private System.Windows.Forms.Button m_btnDelete;
		private System.Windows.Forms.Label m_lblSep;
		private System.Windows.Forms.CheckBox m_cbOverrideAll;
		private System.Windows.Forms.TextBox m_tbOverrideAll;
	}
}