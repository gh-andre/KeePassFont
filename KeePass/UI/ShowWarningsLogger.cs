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
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

using KeePass.Forms;

using KeePassLib.Interfaces;

namespace KeePass.UI
{
	/// <summary>
	/// This logger displays the current status in a status bar.
	/// As soon as a warning or error is logged, a dialog is opened
	/// and all consecutive log lines are sent to both loggers
	/// (status bar and dialog).
	/// </summary>
	public sealed class ShowWarningsLogger : IStatusLogger
	{
		private readonly StatusBarLogger m_sblDefault;
		private StatusLoggerForm m_slf = null;
		private readonly Form m_fTaskbarWindow;

		private bool m_bActive = false;
		private bool m_bCancelled = false;
		private TbpFlag m_tbpfLast = TbpFlag.NoProgress;

		private readonly List<KeyValuePair<LogStatusType, string>> m_lCachedMessages =
			new List<KeyValuePair<LogStatusType, string>>();

		internal bool IsFormShown { get { return (m_slf != null); } }

		[Obsolete]
		public ShowWarningsLogger(StatusBarLogger sblDefault) :
			this(sblDefault, null)
		{
		}

		public ShowWarningsLogger(StatusBarLogger sblDefault, Form fTaskbarWindow)
		{
			m_sblDefault = sblDefault;
			m_fTaskbarWindow = fTaskbarWindow;
		}

#if DEBUG
		~ShowWarningsLogger()
		{
			Debug.Assert(!m_bActive);
			Debug.Assert(m_tbpfLast == TbpFlag.NoProgress);
		}
#endif

		private void SetStyle(TbpFlag f)
		{
			if(m_fTaskbarWindow == null) return;

			if(f != m_tbpfLast)
			{
				TaskbarList.SetProgressState(m_fTaskbarWindow, f);
				m_tbpfLast = f;
			}
		}

		public void StartLogging(string strOperation, bool bWriteOperationToLog)
		{
			Debug.Assert(!m_bActive);

			if(m_sblDefault != null)
				m_sblDefault.StartLogging(strOperation, bWriteOperationToLog);
			if(m_slf != null)
				m_slf.StartLogging(strOperation, bWriteOperationToLog);
			if(m_fTaskbarWindow != null)
			{
				TaskbarList.SetProgressValue(m_fTaskbarWindow, 0, 100);
				SetStyle(TbpFlag.Indeterminate);
			}

			m_bActive = true;
			
			if(bWriteOperationToLog)
				m_lCachedMessages.Add(new KeyValuePair<LogStatusType, string>(
					LogStatusType.Info, strOperation));
		}

		public void EndLogging()
		{
			Debug.Assert(m_bActive);

			if(m_sblDefault != null) m_sblDefault.EndLogging();
			if(m_slf != null) m_slf.EndLogging();
			SetStyle(TbpFlag.NoProgress);

			m_bActive = false;
		}

		public bool SetProgress(uint uPercent)
		{
			Debug.Assert(m_bActive);

			bool b = !m_bCancelled;
			if(m_sblDefault != null)
			{
				if(!m_sblDefault.SetProgress(uPercent)) b = false;
			}
			if(m_slf != null)
			{
				if(!m_slf.SetProgress(uPercent)) b = false;
			}
			if(m_fTaskbarWindow != null)
			{
				TaskbarList.SetProgressValue(m_fTaskbarWindow, uPercent, 100);
				SetStyle((uPercent != 0) ? TbpFlag.Normal : TbpFlag.Indeterminate);
			}

			return b;
		}

		public bool SetText(string strNewText, LogStatusType lsType)
		{
			Debug.Assert(m_bActive);

			if((m_slf == null) && ((lsType == LogStatusType.Warning) ||
				(lsType == LogStatusType.Error)))
			{
				m_slf = new StatusLoggerForm();
				m_slf.InitEx(false);

				m_slf.Show();
				m_slf.BringToFront();

				bool bLoggingStarted = false;
				foreach(KeyValuePair<LogStatusType, string> kvp in m_lCachedMessages)
				{
					if(!bLoggingStarted)
					{
						m_slf.StartLogging(kvp.Value, true);
						bLoggingStarted = true;
					}
					else m_slf.SetText(kvp.Value, kvp.Key);
				}
				Debug.Assert(bLoggingStarted);

				m_lCachedMessages.Clear();
			}

			bool b = !m_bCancelled;
			if(m_sblDefault != null)
			{
				if(!m_sblDefault.SetText(strNewText, lsType)) b = false;
			}
			if(m_slf != null)
			{
				if(!m_slf.SetText(strNewText, lsType)) b = false;
			}

			if(m_slf == null)
				m_lCachedMessages.Add(new KeyValuePair<LogStatusType, string>(
					lsType, strNewText));

			return b;
		}

		public bool ContinueWork()
		{
			Debug.Assert(m_bActive);

			bool b = !m_bCancelled;
			if(m_slf != null)
			{
				if(!m_slf.ContinueWork()) b = false;
			}
			if(m_sblDefault != null)
			{
				if(!m_sblDefault.ContinueWork()) b = false;
			}

			return b;
		}

		internal void SetCancelled(bool bCancelled)
		{
			m_bCancelled = bCancelled;
		}
	}
}
