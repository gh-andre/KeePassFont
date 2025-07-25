/*
  KeePass Password Safe - The Open-Source Password Manager
  Copyright (C) 2003-2025 Dominik Reichl <dominik.reichl@t-online.de>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using KeePass.App;
using KeePass.Resources;
using KeePass.UI;

using KeePassLib;
using KeePassLib.Interfaces;
using KeePassLib.Utility;

namespace KeePass.Forms
{
	public partial class StatusLoggerForm : Form, IStatusLogger
	{
		private bool m_bIsModal = false;
		private bool m_bCancelled = false;
		private bool m_bCloseMode = false;
		private uint m_uLastPercent = 0;

		private uint m_cWarnings = 0;
		private uint m_cErrors = 0;

		private ImageList m_ilIcons = null;

		public void InitEx(bool bIsModal)
		{
			m_bIsModal = bIsModal;
		}

		public void StartLogging(string strOperation, bool bWriteOperationToLog)
		{
			if(!string.IsNullOrEmpty(strOperation))
			{
				this.Text = strOperation + " - " + PwDefs.ShortProductName;
				
				if(bWriteOperationToLog)
					SetText(strOperation, LogStatusType.Info);
			}

			m_pbProgress.Value = 0;
			m_uLastPercent = 0;
		}

		public void EndLogging()
		{
			this.Text = PwDefs.ShortProductName;
			m_btnCancel.Text = KPRes.Close;
			m_bCloseMode = true;

			SetText(string.Empty, LogStatusType.AdditionalInfo);

			string strFinish = KPRes.Ready + " " +
				KPRes.Errors + ": " + m_cErrors.ToString() + ". " +
				KPRes.Warnings + ": " + m_cWarnings.ToString() + ".";
			SetText(strFinish, LogStatusType.Info);

			m_pbProgress.Value = 100;
			m_uLastPercent = 100;

			Application.DoEvents();
		}

		public bool SetProgress(uint uPercent)
		{
			if(uPercent != m_uLastPercent)
			{
				m_pbProgress.Value = (int)uPercent;
				m_uLastPercent = uPercent;

				Application.DoEvents();
			}

			return !m_bCancelled;
		}

		public bool SetText(string strNewText, LogStatusType lsType)
		{
			if(strNewText != null)
			{
				ListViewItem lvi = new ListViewItem(StrUtil.MultiToSingleLine(
					strNewText), (int)lsType);
				lvi.Tag = strNewText;

				m_lvMessages.Items.Add(lvi);
				m_lvMessages.EnsureVisible(m_lvMessages.Items.Count - 1);

				if(lsType == LogStatusType.Warning) ++m_cWarnings;
				else if(lsType == LogStatusType.Error) ++m_cErrors;
			}
			else { Debug.Assert(false); }

			ProcessResize();
			Application.DoEvents();
			return !m_bCancelled;
		}

		public bool ContinueWork()
		{
			Application.DoEvents();

			return !m_bCancelled;
		}

		public StatusLoggerForm()
		{
			InitializeComponent();
			GlobalWindowManager.InitializeForm(this);
		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			GlobalWindowManager.AddWindow(this);

			this.Icon = AppIcons.Default;
			this.Text = PwDefs.ShortProductName;
			
			m_pbProgress.Minimum = 0;
			m_pbProgress.Maximum = 100;

			List<Image> lImages = new List<Image>
			{
				Properties.Resources.B16x16_MessageBox_Info,
				Properties.Resources.B16x16_MessageBox_Warning,
				Properties.Resources.B16x16_MessageBox_Critical,
				Properties.Resources.B16x16_Transparent
			};
			m_ilIcons = UIUtil.BuildImageListUnscaled(lImages,
				DpiUtil.ScaleIntX(16), DpiUtil.ScaleIntY(16));
			m_lvMessages.SmallImageList = m_ilIcons;

			m_lvMessages.Columns.Add(KPRes.Status);

			ProcessResize();
		}

		private void ProcessResize()
		{
			UIUtil.ResizeColumns(m_lvMessages, true);
		}

		private void OnBtnCancel(object sender, EventArgs e)
		{
			if(m_bCloseMode)
			{
				if(m_bIsModal) this.DialogResult = DialogResult.Cancel;
				else Close();
			}
			else
			{
				m_bCancelled = true;
				this.DialogResult = DialogResult.None;
			}
		}

		private void OnMessagesSelectedIndexChanged(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection slvic = m_lvMessages.SelectedItems;
			if(slvic.Count == 0)
			{
				m_tbDetails.Text = string.Empty;
				return;
			}

			string str = (slvic[0].Tag as string);
			if(str == null) { Debug.Assert(false); str = string.Empty; }
			UIUtil.SetMultilineText(m_tbDetails, str);
		}

		private void OnFormClosed(object sender, FormClosedEventArgs e)
		{
			if(m_ilIcons != null)
			{
				m_lvMessages.SmallImageList = null;
				m_ilIcons.Dispose();
				m_ilIcons = null;
			}
			else { Debug.Assert(false); }

			GlobalWindowManager.RemoveWindow(this);
		}
	}
}
