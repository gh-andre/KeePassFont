﻿/*
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
using System.Net;
using System.Xml.Serialization;

using KeePassLib.Delegates;
using KeePassLib.Interfaces;
using KeePassLib.Serialization;

namespace KeePassLib
{
	/// <summary>
	/// Contains KeePassLib-global definitions and enums.
	/// </summary>
	public static class PwDefs
	{
		/// <summary>
		/// The product name.
		/// </summary>
		public static readonly string ProductName = "KeePass Password Safe";

		/// <summary>
		/// A short, simple string representing the product name. The string
		/// should contain no spaces, directory separator characters, etc.
		/// </summary>
		public static readonly string ShortProductName = "KeePass";

		internal const string UnixName = "keepass2";
		internal const string ResClass = "KeePass2"; // With initial capital

		/// <summary>
		/// Version, encoded as 32-bit unsigned integer.
		/// 2.00 = 0x02000000, 2.01 = 0x02000100, ..., 2.18 = 0x02010800.
		/// As of 2.19, the version is encoded component-wise per byte,
		/// e.g. 2.19 = 0x02130000.
		/// It is highly recommended to use <c>FileVersion64</c> instead.
		/// </summary>
		public static readonly uint Version32 = 0x023B0000;

		/// <summary>
		/// Version, encoded as 64-bit unsigned integer
		/// (component-wise, 16 bits per component).
		/// </summary>
		public static readonly ulong FileVersion64 = 0x0002003B00000000UL;

		/// <summary>
		/// Version, encoded as string.
		/// </summary>
		public static readonly string VersionString = "2.59";

		public static readonly string Copyright = @"Copyright © 2003-2025 Dominik Reichl";

		/// <summary>
		/// Product website URL. Terminated by a forward slash.
		/// </summary>
		public static readonly string HomepageUrl = "https://keepass.info/";

		/// <summary>
		/// URL to the online translations page.
		/// </summary>
		public static readonly string TranslationsUrl = "https://keepass.info/translations.html";

		/// <summary>
		/// URL to the online plugins page.
		/// </summary>
		public static readonly string PluginsUrl = "https://keepass.info/plugins.html";

		/// <summary>
		/// Product donations URL.
		/// </summary>
		public static readonly string DonationsUrl = "https://keepass.info/donate.html";

		/// <summary>
		/// URL to the root path of the online KeePass help. Terminated by
		/// a forward slash.
		/// </summary>
		public static readonly string HelpUrl = "https://keepass.info/help/";

		/// <summary>
		/// URL to a TXT file (eventually compressed) that contains information
		/// about the latest KeePass version available on the website.
		/// </summary>
		public static readonly string VersionUrl = "https://www.dominik-reichl.de/update/version2x.txt.gz";

		/// <summary>
		/// A <c>DateTime</c> object that represents the time when the assembly
		/// was loaded.
		/// </summary>
		public static readonly DateTime DtDefaultNow = DateTime.UtcNow;

		/// <summary>
		/// Default number of master key encryption/transformation rounds
		/// (making dictionary attacks harder).
		/// </summary>
		public static readonly ulong DefaultKeyEncryptionRounds = 600000;

		/// <summary>
		/// Default identifier string for the title field.
		/// Should not contain spaces, tabs or other whitespace.
		/// </summary>
		public const string TitleField = "Title";
		// Const instead of static readonly for backward compatibility with plugins

		/// <summary>
		/// Default identifier string for the user name field.
		/// Should not contain spaces, tabs or other whitespace.
		/// </summary>
		public const string UserNameField = "UserName";
		// Const instead of static readonly for backward compatibility with plugins

		/// <summary>
		/// Default identifier string for the password field.
		/// Should not contain spaces, tabs or other whitespace.
		/// </summary>
		public const string PasswordField = "Password";
		// Const instead of static readonly for backward compatibility with plugins

		/// <summary>
		/// Default identifier string for the URL field.
		/// Should not contain spaces, tabs or other whitespace.
		/// </summary>
		public const string UrlField = "URL";
		// Const instead of static readonly for backward compatibility with plugins

		/// <summary>
		/// Default identifier string for the notes field.
		/// Should not contain spaces, tabs or other whitespace.
		/// </summary>
		public const string NotesField = "Notes";
		// Const instead of static readonly for backward compatibility with plugins

		/// <summary>
		/// Default identifier string for the field which will contain TAN indices.
		/// </summary>
		public static readonly string TanIndexField = UserNameField;

		/// <summary>
		/// Default title of an entry that is really a TAN entry.
		/// </summary>
		public static readonly string TanTitle = @"<TAN>";

		/// <summary>
		/// Prefix of a custom auto-type string field.
		/// </summary>
		public static readonly string AutoTypeStringPrefix = "S:";

		/// <summary>
		/// Default string representing a hidden password.
		/// </summary>
		public static readonly string HiddenPassword = "********";

		/// <summary>
		/// Default auto-type keystroke sequence. If no custom sequence is
		/// specified, this sequence is used.
		/// </summary>
		public static readonly string DefaultAutoTypeSequence = @"{USERNAME}{TAB}{PASSWORD}{ENTER}";

		/// <summary>
		/// Default auto-type keystroke sequence for TAN entries. If no custom
		/// sequence is specified, this sequence is used.
		/// </summary>
		public static readonly string DefaultAutoTypeSequenceTan = @"{PASSWORD}";

		/// <summary>
		/// Maximum time (in milliseconds) after which the user interface
		/// should be updated.
		/// </summary>
		internal const int UIUpdateDelay = 50;

		internal const uint QualityBitsWeak = 79;

		internal const string FavoriteTag = "Favorite";

		internal static bool DebugMode { get; set; } // Command line option '-debug'

		/// <summary>
		/// Check whether a name is a standard field name.
		/// </summary>
		public static bool IsStandardField(string strFieldName)
		{
			if(strFieldName == null) { Debug.Assert(false); return false; }

			return ((strFieldName == TitleField) ||
				(strFieldName == UserNameField) ||
				(strFieldName == PasswordField) ||
				(strFieldName == UrlField) ||
				(strFieldName == NotesField));
		}

		public static List<string> GetStandardFields()
		{
			return new List<string>
			{
				TitleField, UserNameField, PasswordField, UrlField, NotesField
			};
		}

		internal static bool IsMultiLineField(string strFieldName)
		{
			if(strFieldName == null) { Debug.Assert(false); return false; }

			return ((strFieldName == NotesField) || !IsStandardField(strFieldName));
		}

		/// <summary>
		/// Check whether an entry is a TAN entry.
		/// </summary>
		public static bool IsTanEntry(PwEntry pe)
		{
			if(pe == null) { Debug.Assert(false); return false; }

			return (pe.Strings.ReadSafe(TitleField) == TanTitle);
		}

		internal static string GetTranslationDisplayVersion(string strFileVersion)
		{
			if(strFileVersion == null) { Debug.Assert(false); return string.Empty; }

			if(strFileVersion == "2.39") return "2.39.1 / 2.39";
			if(strFileVersion == "2.42") return "2.42.1 / 2.42";
			if(strFileVersion == "2.48") return "2.48.1 / 2.48";
			if(strFileVersion == "2.51") return "2.51.1 / 2.51";
			// if(strFileVersion == "2.57") return "2.57.1 / 2.57";

			return strFileVersion;
		}

		internal static PwIcon GroupIconToEntryIcon(PwIcon i)
		{
			PwIcon r = i; // Inherit by default

			switch(i)
			{
				case PwIcon.Folder:
				case PwIcon.FolderOpen:
				case PwIcon.FolderPackage:
					Debug.Assert((new PwEntry(false, false)).IconId == PwIcon.Key);
					r = PwIcon.Key;
					break;

				case PwIcon.EMailBox:
					r = PwIcon.EMail;
					break;

				default: break;
			}

			return r;
		}
	}

	/// <summary>
	/// Search parameters for group and entry searches.
	/// </summary>
	public sealed class SearchParameters
	{
		private string m_strName = string.Empty;
		[DefaultValue("")]
		public string Name
		{
			get { return m_strName; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_strName = value;
			}
		}

		private string m_strText = string.Empty;
		[DefaultValue("")]
		public string SearchString
		{
			get { return m_strText; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_strText = value;
			}
		}

		private PwSearchMode m_sm = PwSearchMode.Simple;
		public PwSearchMode SearchMode
		{
			get { return m_sm; }
			set { m_sm = value; }
		}

		[DefaultValue(false)]
		[Obsolete]
		[XmlIgnore]
		public bool RegularExpression
		{
			get { return (m_sm == PwSearchMode.Regular); }
			set { m_sm = (value ? PwSearchMode.Regular : PwSearchMode.Simple); }
		}

		private bool m_bSearchInTitles = true;
		[DefaultValue(true)]
		public bool SearchInTitles
		{
			get { return m_bSearchInTitles; }
			set { m_bSearchInTitles = value; }
		}

		private bool m_bSearchInUserNames = true;
		[DefaultValue(true)]
		public bool SearchInUserNames
		{
			get { return m_bSearchInUserNames; }
			set { m_bSearchInUserNames = value; }
		}

		private bool m_bSearchInPasswords = false;
		[DefaultValue(false)]
		public bool SearchInPasswords
		{
			get { return m_bSearchInPasswords; }
			set { m_bSearchInPasswords = value; }
		}

		private bool m_bSearchInUrls = true;
		[DefaultValue(true)]
		public bool SearchInUrls
		{
			get { return m_bSearchInUrls; }
			set { m_bSearchInUrls = value; }
		}

		private bool m_bSearchInNotes = true;
		[DefaultValue(true)]
		public bool SearchInNotes
		{
			get { return m_bSearchInNotes; }
			set { m_bSearchInNotes = value; }
		}

		private bool m_bSearchInOther = true;
		[DefaultValue(true)]
		public bool SearchInOther
		{
			get { return m_bSearchInOther; }
			set { m_bSearchInOther = value; }
		}

		private bool m_bSearchInStringNames = false;
		[DefaultValue(false)]
		public bool SearchInStringNames
		{
			get { return m_bSearchInStringNames; }
			set { m_bSearchInStringNames = value; }
		}

		private bool m_bSearchInTags = true;
		[DefaultValue(true)]
		public bool SearchInTags
		{
			get { return m_bSearchInTags; }
			set { m_bSearchInTags = value; }
		}

		private bool m_bSearchInUuids = false;
		[DefaultValue(false)]
		public bool SearchInUuids
		{
			get { return m_bSearchInUuids; }
			set { m_bSearchInUuids = value; }
		}

		private bool m_bSearchInGroupPaths = false;
		[DefaultValue(false)]
		public bool SearchInGroupPaths
		{
			get { return m_bSearchInGroupPaths; }
			set { m_bSearchInGroupPaths = value; }
		}

		private bool m_bSearchInGroupNames = false;
		[DefaultValue(false)]
		public bool SearchInGroupNames
		{
			get { return m_bSearchInGroupNames; }
			set { m_bSearchInGroupNames = value; }
		}

		private bool m_bSearchInHistory = false;
		[DefaultValue(false)]
		public bool SearchInHistory
		{
			get { return m_bSearchInHistory; }
			set { m_bSearchInHistory = value; }
		}

#if KeePassUAP
		private StringComparison m_scType = StringComparison.OrdinalIgnoreCase;
#else
		private StringComparison m_scType = StringComparison.InvariantCultureIgnoreCase;
#endif
		/// <summary>
		/// String comparison type. Specifies the condition when the specified
		/// text matches a group/entry string.
		/// </summary>
		public StringComparison ComparisonMode
		{
			get { return m_scType; }
			set { m_scType = value; }
		}

		private bool m_bExcludeExpired = false;
		[DefaultValue(false)]
		public bool ExcludeExpired
		{
			get { return m_bExcludeExpired; }
			set { m_bExcludeExpired = value; }
		}

		private bool m_bRespectEntrySearchingDisabled = true;
		[DefaultValue(true)]
		public bool RespectEntrySearchingDisabled
		{
			get { return m_bRespectEntrySearchingDisabled; }
			set { m_bRespectEntrySearchingDisabled = value; }
		}

		private StrPwEntryDelegate m_fnDataTrf = null;
		[XmlIgnore]
		public StrPwEntryDelegate DataTransformationFn
		{
			get { return m_fnDataTrf; }
			set { m_fnDataTrf = value; }
		}

		private string m_strDataTrf = string.Empty;
		/// <summary>
		/// Only for serialization.
		/// </summary>
		[DefaultValue("")]
		public string DataTransformation
		{
			get { return m_strDataTrf; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_strDataTrf = value;
			}
		}

		[XmlIgnore]
		public static SearchParameters None
		{
			get
			{
				SearchParameters sp = new SearchParameters();

				Debug.Assert(sp.m_strName.Length == 0);
				Debug.Assert(sp.m_strText.Length == 0);
				Debug.Assert(sp.m_sm == PwSearchMode.Simple);
				sp.m_bSearchInTitles = false;
				sp.m_bSearchInUserNames = false;
				Debug.Assert(!sp.m_bSearchInPasswords);
				sp.m_bSearchInUrls = false;
				sp.m_bSearchInNotes = false;
				sp.m_bSearchInOther = false;
				Debug.Assert(!sp.m_bSearchInStringNames);
				sp.m_bSearchInTags = false;
				Debug.Assert(!sp.m_bSearchInUuids);
				Debug.Assert(!sp.m_bSearchInGroupPaths);
				Debug.Assert(!sp.m_bSearchInGroupNames);
				Debug.Assert(!sp.m_bSearchInHistory);
				// Debug.Assert(sp.m_scType == StringComparison.InvariantCultureIgnoreCase);
				Debug.Assert(!sp.m_bExcludeExpired);
				Debug.Assert(sp.m_bRespectEntrySearchingDisabled);

				return sp;
			}
		}

		/// <summary>
		/// Construct a new search parameters object.
		/// </summary>
		public SearchParameters()
		{
		}

		public SearchParameters Clone()
		{
			return (SearchParameters)this.MemberwiseClone();
		}
	}

	/// <summary>
	/// Memory protection configuration structure (for default fields).
	/// </summary>
	public sealed class MemoryProtectionConfig : IDeepCloneable<MemoryProtectionConfig>
	{
		public bool ProtectTitle = false;
		public bool ProtectUserName = false;
		public bool ProtectPassword = true;
		public bool ProtectUrl = false;
		public bool ProtectNotes = false;

		// public bool AutoEnableVisualHiding = false;

		public MemoryProtectionConfig CloneDeep()
		{
			return (MemoryProtectionConfig)this.MemberwiseClone();
		}

		public bool GetProtection(string strField)
		{
			if(strField == PwDefs.TitleField) return this.ProtectTitle;
			if(strField == PwDefs.UserNameField) return this.ProtectUserName;
			if(strField == PwDefs.PasswordField) return this.ProtectPassword;
			if(strField == PwDefs.UrlField) return this.ProtectUrl;
			if(strField == PwDefs.NotesField) return this.ProtectNotes;

			return false;
		}
	}

	public sealed class ObjectTouchedEventArgs : EventArgs
	{
		private readonly object m_o;
		public object Object { get { return m_o; } }

		private readonly bool m_bModified;
		public bool Modified { get { return m_bModified; } }

		private readonly bool m_bParentsTouched;
		public bool ParentsTouched { get { return m_bParentsTouched; } }

		public ObjectTouchedEventArgs(object o, bool bModified,
			bool bParentsTouched)
		{
			m_o = o;
			m_bModified = bModified;
			m_bParentsTouched = bParentsTouched;
		}
	}

	public sealed class IOAccessEventArgs : EventArgs
	{
		private readonly IOConnectionInfo m_ioc;
		public IOConnectionInfo IOConnectionInfo { get { return m_ioc; } }

		private readonly IOConnectionInfo m_ioc2;
		public IOConnectionInfo IOConnectionInfo2 { get { return m_ioc2; } }

		private readonly IOAccessType m_t;
		public IOAccessType Type { get { return m_t; } }

		public IOAccessEventArgs(IOConnectionInfo ioc, IOConnectionInfo ioc2,
			IOAccessType t)
		{
			m_ioc = ioc;
			m_ioc2 = ioc2;
			m_t = t;
		}
	}

	public sealed class IOWebRequestEventArgs : EventArgs
	{
		private readonly WebRequest m_wr;
		public WebRequest Request { get { return m_wr; } }

		private readonly IOConnectionInfo m_ioc;
		public IOConnectionInfo IOConnectionInfo { get { return m_ioc; } }

		public IOWebRequestEventArgs(WebRequest r, IOConnectionInfo ioc)
		{
			m_wr = r;
			m_ioc = ioc;
		}
	}
}
