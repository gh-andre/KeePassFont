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
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using KeePass.UI;
using KeePass.Util;
using KeePass.Util.XmlSerialization;

using KeePassLib;
using KeePassLib.Delegates;
using KeePassLib.Native;
using KeePassLib.Serialization;
using KeePassLib.Utility;

namespace KeePass.App.Configuration
{
	[XmlType(AppConfigEx.StrXmlTypeName)]
	public sealed partial class AppConfigEx
	{
		internal const string StrXmlTypeName = "Configuration";

		private string m_strSearchString = null;

		public AppConfigEx()
		{
		}

#if DEBUG
		~AppConfigEx()
		{
			Debug.Assert(m_strSearchString == null);
		}
#endif

		private AceMeta m_meta = null;
		public AceMeta Meta
		{
			get
			{
				if(m_meta == null) m_meta = new AceMeta();
				return m_meta;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_meta = value;
			}
		}

		private AceApplication m_aceApp = null;
		public AceApplication Application
		{
			get
			{
				if(m_aceApp == null) m_aceApp = new AceApplication();
				return m_aceApp;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_aceApp = value;
			}
		}

		private AceLogging m_aceLogging = null;
		public AceLogging Logging
		{
			get
			{
				if(m_aceLogging == null) m_aceLogging = new AceLogging();
				return m_aceLogging;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_aceLogging = value;
			}
		}

		private AceMainWindow m_uiMainWindow = null;
		public AceMainWindow MainWindow
		{
			get
			{
				if(m_uiMainWindow == null) m_uiMainWindow = new AceMainWindow();
				return m_uiMainWindow;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_uiMainWindow = value;
			}
		}

		private AceUI m_aceUI = null;
		public AceUI UI
		{
			get
			{
				if(m_aceUI == null) m_aceUI = new AceUI();
				return m_aceUI;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_aceUI = value;
			}
		}

		private AceSecurity m_sec = null;
		public AceSecurity Security
		{
			get
			{
				if(m_sec == null) m_sec = new AceSecurity();
				return m_sec;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_sec = value;
			}
		}

		private AceNative m_native = null;
		public AceNative Native
		{
			get
			{
				if(m_native == null) m_native = new AceNative();
				return m_native;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_native = value;
			}
		}

		private AcePasswordGenerator m_pwGen = null;
		public AcePasswordGenerator PasswordGenerator
		{
			get
			{
				if(m_pwGen == null) m_pwGen = new AcePasswordGenerator();
				return m_pwGen;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_pwGen = value;
			}
		}

		private AceSearch m_aceSearch = null;
		public AceSearch Search
		{
			get
			{
				if(m_aceSearch == null) m_aceSearch = new AceSearch();
				return m_aceSearch;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_aceSearch = value;
			}
		}

		private AceDefaults m_def = null;
		public AceDefaults Defaults
		{
			get
			{
				if(m_def == null) m_def = new AceDefaults();
				return m_def;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_def = value;
			}
		}

		private AceIntegration m_int = null;
		public AceIntegration Integration
		{
			get
			{
				if(m_int == null) m_int = new AceIntegration();
				return m_int;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_int = value;
			}
		}

		private AceCustomConfig m_cc = null;
		[XmlIgnore]
		public AceCustomConfig CustomConfig
		{
			get
			{
				if(m_cc == null) m_cc = new AceCustomConfig();
				return m_cc;
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_cc = value;
			}
		}

		[XmlArray("Custom")]
		[XmlArrayItem("Item")]
		public AceKvp[] CustomSerialized
		{
			get
			{
				return this.CustomConfig.Serialize();
			}
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				this.CustomConfig.Deserialize(value);
			}
		}

		/// <summary>
		/// Prepare for saving the configuration to disk. None of the
		/// modifications in this method need to be rolled back
		/// (for rollback, use <c>OnSavePre</c> / <c>OnSavePost</c>).
		/// </summary>
		private void PrepareSave()
		{
			// Member variables might be null
			AceMeta aceMeta = this.Meta;
			AceApplication aceApp = this.Application;
			AceSearch aceSearch = this.Search;
			AceDefaults aceDef = this.Defaults;

			aceMeta.Version = StrUtil.VersionToString(PwDefs.FileVersion64);
			aceMeta.OmitItemsWithDefaultValues = true;
			aceMeta.DpiFactorX = DpiUtil.FactorX; // For new (not loaded) cfgs.
			aceMeta.DpiFactorY = DpiUtil.FactorY;

			aceApp.LastUsedFile.ClearCredentials(true);

			foreach(IOConnectionInfo iocMru in aceApp.MostRecentlyUsed.Items)
				iocMru.ClearCredentials(true);

			if(!aceDef.RememberKeySources) aceDef.KeySources.Clear();

			// aceApp.TriggerSystem = Program.TriggerSystem;

			SearchUtil.PrepareForSerialize(aceSearch.LastUsedProfile);
			foreach(SearchParameters sp in aceSearch.UserProfiles)
				SearchUtil.PrepareForSerialize(sp);

			const int m = 64; // Maximum number of compatibility items
			List<string> l = aceApp.PluginCompatibility;
			if(l.Count > m) l.RemoveRange(m, l.Count - m); // See reg.
		}

		internal void OnLoad()
		{
			ulong uVersion = this.Meta.GetVersion();
			AceApplication aceApp = this.Application;
			AceDefaults aceDef = this.Defaults;
			AceIntegration aceInt = this.Integration;
			AceMainWindow aceMW = this.MainWindow;
			AceSearch aceSearch = this.Search;
			AceSecurity aceSec = this.Security;

			// aceInt.UrlSchemeOverrides.SetDefaultsIfEmpty();

			ObfuscateCred(false);
			ChangePathsRelAbs(true);

			// Remove invalid columns
			List<AceColumn> lColumns = aceMW.EntryListColumns;
			for(int i = lColumns.Count - 1; i >= 0; --i)
			{
				int t = (int)lColumns[i].Type;
				if((t < 0) || (t >= (int)AceColumnType.Count))
					lColumns.RemoveAt(i);
			}

			SearchUtil.FinishDeserialize(aceSearch.LastUsedProfile);
			foreach(SearchParameters sp in aceSearch.UserProfiles)
				SearchUtil.FinishDeserialize(sp);

			DpiScale();

			// AceFont af = this.UI.PasswordFont;
			// Debug.Assert(af.GraphicsUnit == GraphicsUnit.Point);
			// float fSize = ((af.GraphicsUnit == GraphicsUnit.Point) ? af.Size :
			//	af.ToFont().SizeInPoints);
			// if(fSize > AceUI.PasswordFontSizeMaximum)
			// {
			//	Debug.Assert(false);
			//	af.Size = AceUI.PasswordFontSizeMaximum;
			//	af.GraphicsUnit = GraphicsUnit.Point;
			// }

			if(aceMW.EscMinimizesToTray) // For backward compatibility
			{
				aceMW.EscMinimizesToTray = false; // Default value
				aceMW.EscAction = AceEscAction.MinimizeToTray;
			}

			// As of KeePass 2.54, all built-in URL scheme overrides are disabled
			// by default; silently disable defaults of older versions
			Debug.Assert((new AceUrlSchemeOverrides()).BuiltInOverridesEnabled == 0UL);
			if(uVersion < 0x0002003600000000UL) // < 2.54
			{
				ulong u = aceInt.UrlSchemeOverrides.BuiltInOverridesEnabled;
				if((u == 0x1UL) || (u == 0x1000000UL))
					aceInt.UrlSchemeOverrides.BuiltInOverridesEnabled = 0;
			}

			// When the regular configuration file contains an MRU item with a
			// relative path and the enforced configuration file contains a
			// corresponding one with an absolute path, the path conversion may
			// result in duplicate MRU items;
			// cf. GetNodeKey and MruList.AddItem (CaseIgnoreCmp)
			aceApp.MostRecentlyUsed.Items = new List<IOConnectionInfo>(
				MemUtil.Distinct<IOConnectionInfo, string>(aceApp.MostRecentlyUsed.Items,
				(ioc => ioc.GetDisplayName().ToUpperInvariant()), true));
			// Cf. GetNodeKey and AceDefaults.GetKeyAssocIndex (CaseIgnoreCmp)
			aceDef.KeySources = new List<AceKeyAssoc>(
				MemUtil.Distinct<AceKeyAssoc, string>(aceDef.KeySources,
				(a => a.DatabasePath.ToUpperInvariant()), true));

			if(NativeLib.IsUnix())
			{
				aceSec.PreventScreenCapture = false;
				aceSec.MasterKeyOnSecureDesktop = false;

				aceInt.HotKeyGlobalAutoType = (long)Keys.None;
				aceInt.HotKeyGlobalAutoTypePassword = (long)Keys.None;
				aceInt.HotKeySelectedAutoType = (long)Keys.None;
				aceInt.HotKeyShowWindow = (long)Keys.None;
				aceInt.HotKeyEntryMenu = (long)Keys.None;
			}

			if(MonoWorkarounds.IsRequired(1378))
			{
				AceWorkspaceLocking aceWL = aceSec.WorkspaceLocking;
				aceWL.LockOnSessionSwitch = false;
				aceWL.LockOnSuspend = false;
				aceWL.LockOnRemoteControlChange = false;
			}

			if(MonoWorkarounds.IsRequired(1418))
			{
				aceMW.MinimizeAfterOpeningDatabase = false;
				aceApp.Start.MinimizedAndLocked = false;
			}

			if(MonoWorkarounds.IsRequired(1976))
			{
				aceMW.FocusQuickFindOnRestore = false;
				aceMW.FocusQuickFindOnUntray = false;
			}
		}

		internal void OnSavePre()
		{
			PrepareSave();

			ChangePathsRelAbs(false);
			ObfuscateCred(true);
			RemoveSensitiveInfo(true);
		}

		internal void OnSavePost()
		{
			RemoveSensitiveInfo(false);
			ObfuscateCred(false);
			ChangePathsRelAbs(true);
		}

		private void ChangePathsRelAbs(bool bMakeAbsolute)
		{
			AceApplication aceApp = this.Application;
			AceDefaults aceDef = this.Defaults;

			ChangePathRelAbs(aceApp.LastUsedFile, bMakeAbsolute);

			foreach(IOConnectionInfo iocMru in aceApp.MostRecentlyUsed.Items)
				ChangePathRelAbs(iocMru, bMakeAbsolute);

			List<string> lWDKeys = aceApp.GetWorkingDirectoryContexts();
			foreach(string strWDKey in lWDKeys)
				aceApp.SetWorkingDirectory(strWDKey, ChangePathRelAbsStr(
					aceApp.GetWorkingDirectory(strWDKey), bMakeAbsolute));

			foreach(AceKeyAssoc kfp in aceDef.KeySources)
			{
				kfp.DatabasePath = ChangePathRelAbsStr(kfp.DatabasePath, bMakeAbsolute);
				kfp.KeyFilePath = ChangePathRelAbsStr(kfp.KeyFilePath, bMakeAbsolute);
			}
		}

		private static void ChangePathRelAbs(IOConnectionInfo ioc, bool bMakeAbsolute)
		{
			if(ioc == null) { Debug.Assert(false); return; }

			if(!ioc.IsLocalFile()) return;

			// Update path separators for current system
			ioc.Path = UrlUtil.ConvertSeparators(ioc.Path);

			string strBase = WinUtil.GetExecutable();
			bool bIsAbs = UrlUtil.IsAbsolutePath(ioc.Path);

			if(bMakeAbsolute && !bIsAbs)
				ioc.Path = UrlUtil.MakeAbsolutePath(strBase, ioc.Path);
			else if(!bMakeAbsolute && bIsAbs)
				ioc.Path = UrlUtil.MakeRelativePath(strBase, ioc.Path);
		}

		private static string ChangePathRelAbsStr(string strPath, bool bMakeAbsolute)
		{
			if(strPath == null) { Debug.Assert(false); return string.Empty; }
			if(strPath.Length == 0) return strPath;

			IOConnectionInfo ioc = IOConnectionInfo.FromPath(strPath);
			ChangePathRelAbs(ioc, bMakeAbsolute);
			return ioc.Path;
		}

		private void ObfuscateCred(bool bObf)
		{
			AceApplication aceApp = this.Application;
			AceIntegration aceInt = this.Integration;

			aceApp.LastUsedFile.Obfuscate(bObf);

			foreach(IOConnectionInfo iocMru in aceApp.MostRecentlyUsed.Items)
			{
				if(iocMru == null) { Debug.Assert(false); }
				else iocMru.Obfuscate(bObf);
			}

			if(bObf) aceInt.ProxyUserName = StrUtil.Obfuscate(aceInt.ProxyUserName);
			else aceInt.ProxyUserName = StrUtil.Deobfuscate(aceInt.ProxyUserName);

			if(bObf) aceInt.ProxyPassword = StrUtil.Obfuscate(aceInt.ProxyPassword);
			else aceInt.ProxyPassword = StrUtil.Deobfuscate(aceInt.ProxyPassword);
		}

		private void RemoveSensitiveInfo(bool bRemove)
		{
			SearchParameters sp = this.Search.LastUsedProfile;

			if(bRemove)
			{
				Debug.Assert(m_strSearchString == null);
				m_strSearchString = sp.SearchString;
				sp.SearchString = string.Empty;
			}
			else
			{
				if(m_strSearchString != null)
				{
					sp.SearchString = m_strSearchString;
					m_strSearchString = null;
				}
				else { Debug.Assert(false); }
			}
		}

		private void DpiScale()
		{
			AceMeta aceMeta = this.Meta;
			double dCfgX = aceMeta.DpiFactorX, dCfgY = aceMeta.DpiFactorY;
			double dScrX = DpiUtil.FactorX, dScrY = DpiUtil.FactorY;

			if((dScrX == dCfgX) && (dScrY == dCfgY)) return;

			// When this method returns, all positions and sizes are in pixels
			// for the current screen DPI
			aceMeta.DpiFactorX = dScrX;
			aceMeta.DpiFactorY = dScrY;

			// Backward compatibility; configuration files created by KeePass
			// 2.37 and earlier do not contain DpiFactor* values, they default
			// to 0.0 and all positions and sizes are in pixels for the current
			// screen DPI; so, do not perform any DPI scaling in this case
			if((dCfgX == 0.0) || (dCfgY == 0.0)) return;

			double sX = dScrX / dCfgX, sY = dScrY / dCfgY;
			GFunc<int, int> fX = delegate(int x)
			{
				return (int)Math.Round((double)x * sX);
			};
			GFunc<int, int> fY = delegate(int y)
			{
				return (int)Math.Round((double)y * sY);
			};
			GFunc<string, string> fWsr = delegate(string strRect)
			{
				return UIUtil.ScaleWindowScreenRect(strRect, sX, sY);
			};
			GFunc<string, string> fVX = delegate(string strArray)
			{
				if(string.IsNullOrEmpty(strArray)) return strArray;

				try
				{
					int[] v = StrUtil.DeserializeIntArray(strArray);
					if(v == null) { Debug.Assert(false); return strArray; }

					for(int i = 0; i < v.Length; ++i)
						v[i] = (int)Math.Round((double)v[i] * sX);

					return StrUtil.SerializeIntArray(v);
				}
				catch(Exception) { Debug.Assert(false); }

				return strArray;
			};
			Action<AceFont> fFont = delegate(AceFont f)
			{
				if(f == null) { Debug.Assert(false); return; }

				if(f.GraphicsUnit == GraphicsUnit.Pixel)
					f.Size = (float)(f.Size * sY);
			};

			AceMainWindow mw = this.MainWindow;
			AceUI ui = this.UI;

			if(mw.X != AppDefs.InvalidWindowValue) mw.X = fX(mw.X);
			if(mw.Y != AppDefs.InvalidWindowValue) mw.Y = fY(mw.Y);
			if(mw.Width != AppDefs.InvalidWindowValue) mw.Width = fX(mw.Width);
			if(mw.Height != AppDefs.InvalidWindowValue) mw.Height = fY(mw.Height);

			foreach(AceColumn c in mw.EntryListColumns)
			{
				if(c.Width >= 0) c.Width = fX(c.Width);
			}

			ui.DataViewerRect = fWsr(ui.DataViewerRect);
			ui.DataEditorRect = fWsr(ui.DataEditorRect);
			ui.CharPickerRect = fWsr(ui.CharPickerRect);
			ui.AutoTypeCtxRect = fWsr(ui.AutoTypeCtxRect);
			ui.AutoTypeCtxColumnWidths = fVX(ui.AutoTypeCtxColumnWidths);

			fFont(ui.StandardFont);
			fFont(ui.PasswordFont);
			fFont(ui.DataEditorFont);
		}

		public void Apply(AceApplyFlags f)
		{
			AceApplication aceApp = this.Application;
			AceIntegration aceInt = this.Integration;
			AceNative aceNtv = this.Native;
			AceSecurity aceSec = this.Security;

			if((f & AceApplyFlags.Proxy) != AceApplyFlags.None)
				IOConnection.SetProxy(aceInt.ProxyType, aceInt.ProxyAddress,
					aceInt.ProxyPort, aceInt.ProxyAuthType, aceInt.ProxyUserName,
					aceInt.ProxyPassword);

			if((f & AceApplyFlags.Ssl) != AceApplyFlags.None)
				IOConnection.SslCertsAcceptInvalid = aceSec.SslCertsAcceptInvalid;

			if((f & AceApplyFlags.FileTransactions) != AceApplyFlags.None)
				FileTransactionEx.ExtraSafe = aceApp.FileTxExtra;

			if((f & AceApplyFlags.Native) != AceApplyFlags.None)
				NativeLib.AllowNative = aceNtv.NativeKeyTransformations;
		}

		private static readonly Dictionary<object, string> g_dictXmlPathCache =
			new Dictionary<object, string>();
		public static bool IsOptionEnforced(object oContainer, PropertyInfo pi)
		{
			if(oContainer == null) { Debug.Assert(false); return false; }
			if(pi == null) { Debug.Assert(false); return false; }

			XmlDocument xdEnforced = AppConfigSerializer.EnforcedConfigXml;
			if(xdEnforced == null) return false;

			string strObjPath;
			if(!g_dictXmlPathCache.TryGetValue(oContainer, out strObjPath))
			{
				strObjPath = XmlUtil.GetObjectXmlPath(Program.Config, oContainer);
				if(string.IsNullOrEmpty(strObjPath)) { Debug.Assert(false); return false; }

				g_dictXmlPathCache[oContainer] = strObjPath;
			}

			string strProp = XmlSerializerEx.GetXmlName(pi);
			if(string.IsNullOrEmpty(strProp)) { Debug.Assert(false); return false; }

			string strPre = strObjPath;
			if(!strPre.EndsWith("/")) strPre += "/";
			string strXPath = strPre + strProp;

			XmlNode xn = xdEnforced.SelectSingleNode(strXPath);
			if(xn == null) return false;

			XmContext ctx = new XmContext(null, AppConfigEx.GetNodeOptions,
				AppConfigEx.GetNodeKey);
			return XmlUtil.IsAlwaysEnforced(xn, strXPath, ctx);
		}

		public static bool IsOptionEnforced(object oContainer, string strPropertyName)
		{
			if(oContainer == null) { Debug.Assert(false); return false; }
			if(string.IsNullOrEmpty(strPropertyName)) { Debug.Assert(false); return false; }

			// To improve performance (avoid type queries), check here, too
			XmlDocument xdEnforced = AppConfigSerializer.EnforcedConfigXml;
			if(xdEnforced == null) return false;

			PropertyInfo pi = oContainer.GetType().GetProperty(strPropertyName);
			return IsOptionEnforced(oContainer, pi);
		}

		public static void ClearXmlPathCache()
		{
			g_dictXmlPathCache.Clear();
		}

		internal static void GetNodeOptions(XmNodeOptions o, string strXPath)
		{
			if(o == null) { Debug.Assert(false); return; }
			if(string.IsNullOrEmpty(strXPath)) { Debug.Assert(false); return; }
			Debug.Assert(strXPath.IndexOf('[') < 0);

			switch(strXPath)
			{
				// Sync. with documentation

				case "/Configuration/Application/PluginCompatibility":
				case "/Configuration/Meta/DpiFactorX":
				case "/Configuration/Meta/DpiFactorY":
				case "/Configuration/Meta/PreferUserConfiguration":
				case "/Configuration/Meta/Version":
					o.NodeMode = XmNodeMode.None;
					break;

				case "/Configuration/Application/TriggerSystem":
				case "/Configuration/Application/TriggerSystem/Triggers/Trigger":
				case "/Configuration/Defaults/KeySources/Association":
				case "/Configuration/Integration/UrlSchemeOverrides":
				case "/Configuration/PasswordGenerator/AutoGeneratedPasswordsProfile":
				// case "/Configuration/PasswordGenerator/LastUsedProfile":
				case "/Configuration/PasswordGenerator/UserProfiles":
				case "/Configuration/PasswordGenerator/UserProfiles/Profile":
				case "/Configuration/Search/LastUsedProfile":
				case "/Configuration/Search/UserProfiles/Profile":
					o.ContentMode = XmContentMode.Replace;
					break;

				// Nodes that do not have child elements:
				// case "/Configuration/Application/WorkingDirectories/Item":
				// case "/Configuration/Integration/AutoTypeAbortOnWindows/Window":

				// Nodes where the mode 'Merge' may be more useful:
				// case "/Configuration/Application/MostRecentlyUsed/Items/ConnectionInfo":
				//     (allow users to save credentials)
				// case "/Configuration/Custom/Item":
				//     (empty Value explicitly only)
				// case "/Configuration/Defaults/SearchParameters":
				//     (admin might only want to turn off case-sensitivity)
				// case "/Configuration/Integration/UrlSchemeOverrides/CustomOverrides/Override":
				//     (allow users to enable/disable the item)
				// case "/Configuration/MainWindow/EntryListColumnCollection/Column":
				//     (allow users to change the width)

				default: break;
			}
		}

		internal static string GetNodeKey(XmlNode xn, string strXPath)
		{
			if(xn == null) { Debug.Assert(false); return null; }
			if(string.IsNullOrEmpty(strXPath)) { Debug.Assert(false); return null; }

			Debug.Assert(xn is XmlElement);
			Debug.Assert((strXPath == xn.Name) || strXPath.EndsWith("/" + xn.Name));
			Debug.Assert(strXPath.IndexOf('[') < 0);

			string strA = null, strB = null;
			switch(strXPath)
			{
				// Sync. with documentation

				case "/Configuration/Application/PluginCompatibility/Item":
				case "/Configuration/Application/WorkingDirectories/Item":
				case "/Configuration/Integration/AutoTypeAbortOnWindows/Window":
					strA = XmlUtil.SafeInnerXml(xn);
					break;

				case "/Configuration/Application/MostRecentlyUsed/Items/ConnectionInfo":
					strA = XmlUtil.SafeInnerXml(xn, "Path"); // Cf. OnLoad
					strB = XmlUtil.SafeInnerXml(xn, "UserName"); // Cf. MRU display name
					break;

				case "/Configuration/Application/TriggerSystem/Triggers/Trigger":
					strA = XmlUtil.SafeInnerXml(xn, "Guid");
					break;

				case "/Configuration/Custom/Item":
					strA = XmlUtil.SafeInnerXml(xn, "Key");
					break;

				case "/Configuration/Defaults/KeySources/Association":
					strA = XmlUtil.SafeInnerXml(xn, "DatabasePath"); // Cf. OnLoad
					break;

				case "/Configuration/Integration/UrlSchemeOverrides/CustomOverrides/Override":
					strA = XmlUtil.SafeInnerXml(xn, "Scheme");
					strB = XmlUtil.SafeInnerXml(xn, "UrlOverride");
					break;

				case "/Configuration/MainWindow/EntryListColumnCollection/Column":
					strA = XmlUtil.SafeInnerXml(xn, "Type");
					strB = XmlUtil.SafeInnerXml(xn, "CustomName");
					break;

				case "/Configuration/PasswordGenerator/UserProfiles/Profile":
				case "/Configuration/Search/UserProfiles/Profile":
					strA = XmlUtil.SafeInnerXml(xn, "Name");
					break;

				default: break;
			}

			Debug.Assert((strA == null) || (strA.IndexOf('<') < 0));
			Debug.Assert((strB == null) || (strB.IndexOf('<') < 0));
			Debug.Assert((strB == null) || (strA != null)); // B => A
			Debug.Assert((strA == null) || (strA.Length != 0));

			if(strB != null) return ((strA ?? string.Empty) + " <> " + strB);
			return strA;
		}

		internal static T GetPropertyValue<T>(object oContainer,
			string strPropertyName, T tDefault, out PropertyInfo piForSet)
		{
			piForSet = null;
			if(oContainer == null) { Debug.Assert(false); return tDefault; }
			if(string.IsNullOrEmpty(strPropertyName)) { Debug.Assert(false); return tDefault; }

			piForSet = oContainer.GetType().GetProperty(strPropertyName);
			if(piForSet == null) { Debug.Assert(false); return tDefault; }
			if(piForSet.PropertyType != typeof(T))
			{
				Debug.Assert(false);
				piForSet = null;
				return tDefault;
			}

			T t = (T)piForSet.GetValue(oContainer, null);
			if(IsOptionEnforced(oContainer, piForSet)) piForSet = null;
			return t;
		}

		internal static string GetEmptyXml()
		{
			return ("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
				"<" + StrXmlTypeName + " xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" " +
				"xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" />");
		}

		internal static XmlDocument CreateEmptyXmlDocument()
		{
			return XmlUtilEx.LoadXmlDocumentFromString(GetEmptyXml());
		}
	}

	[Flags]
	public enum AceApplyFlags
	{
		None = 0,
		Proxy = 0x1,
		Ssl = 0x2,
		FileTransactions = 0x4,
		Native = 0x8,

		All = 0x7FFF
	}

	public sealed class AceMeta
	{
		public AceMeta()
		{
		}

		private string m_strVersion = string.Empty;
		[DefaultValue("")]
		public string Version
		{
			get { return m_strVersion; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_strVersion = value;
			}
		}

		private bool m_bPrefLocalCfg = false;
		public bool PreferUserConfiguration
		{
			get { return m_bPrefLocalCfg; }
			set { m_bPrefLocalCfg = value; }
		}

		// private bool m_bIsEnforced = false;
		// [XmlIgnore]
		// public bool IsEnforcedConfiguration
		// {
		//	get { return m_bIsEnforced; }
		//	set { m_bIsEnforced = value; }
		// }

		private bool m_bOmitDefaultValues = true;
		// Informational property only (like an XML comment);
		// currently doesn't have any effect (the XmlSerializer
		// always omits default values, independent of this
		// property)
		public bool OmitItemsWithDefaultValues
		{
			get { return m_bOmitDefaultValues; }
			set { m_bOmitDefaultValues = value; }
		}

		private double m_dDpiFactorX = 0.0; // See AppConfigEx.DpiScale()
		[DefaultValue(0.0)]
		public double DpiFactorX
		{
			get { return m_dDpiFactorX; }
			set { m_dDpiFactorX = value; }
		}

		private double m_dDpiFactorY = 0.0; // See AppConfigEx.DpiScale()
		[DefaultValue(0.0)]
		public double DpiFactorY
		{
			get { return m_dDpiFactorY; }
			set { m_dDpiFactorY = value; }
		}

		internal ulong GetVersion()
		{
			if(string.IsNullOrEmpty(m_strVersion)) return 0;
			return StrUtil.ParseVersion(m_strVersion);
		}
	}
}
