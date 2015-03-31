/* 
 * Copyright (C) 2006,2007 David Riseley 
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using uk.org.riseley.puttySessionManager.model;

namespace uk.org.riseley.puttySessionManager.controller
{
    public class HotkeyController
    {
        private class User32
        {
            [DllImport("user32.dll")]
            public static extern bool RegisterHotKey(IntPtr hWnd,
              int id, int fsModifiers, int vlc);
            [DllImport("user32.dll")]
            public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

            public enum Modifiers { MOD_ALT = 0x0001, MOD_CONTROL = 0x0002, MOD_SHIFT = 0x0004, MOD_WIN = 0x0008 }
            public enum Msgs
            {
                WM_NULL = 0x0000,
                WM_CREATE = 0x0001,
                WM_DESTROY = 0x0002,
                WM_MOVE = 0x0003,
                WM_SIZE = 0x0005,
                WM_ACTIVATE = 0x0006,
                WM_SETFOCUS = 0x0007,
                WM_KILLFOCUS = 0x0008,
                WM_ENABLE = 0x000A,
                WM_SETREDRAW = 0x000B,
                WM_SETTEXT = 0x000C,
                WM_GETTEXT = 0x000D,
                WM_GETTEXTLENGTH = 0x000E,
                WM_PAINT = 0x000F,
                WM_CLOSE = 0x0010,
                WM_QUERYENDSESSION = 0x0011,
                WM_QUIT = 0x0012,
                WM_QUERYOPEN = 0x0013,
                WM_ERASEBKGND = 0x0014,
                WM_SYSCOLORCHANGE = 0x0015,
                WM_ENDSESSION = 0x0016,
                WM_SHOWWINDOW = 0x0018,
                WM_WININICHANGE = 0x001A,
                WM_SETTINGCHANGE = 0x001A,
                WM_DEVMODECHANGE = 0x001B,
                WM_ACTIVATEAPP = 0x001C,
                WM_FONTCHANGE = 0x001D,
                WM_TIMECHANGE = 0x001E,
                WM_CANCELMODE = 0x001F,
                WM_SETCURSOR = 0x0020,
                WM_MOUSEACTIVATE = 0x0021,
                WM_CHILDACTIVATE = 0x0022,
                WM_QUEUESYNC = 0x0023,
                WM_GETMINMAXINFO = 0x0024,
                WM_PAINTICON = 0x0026,
                WM_ICONERASEBKGND = 0x0027,
                WM_NEXTDLGCTL = 0x0028,
                WM_SPOOLERSTATUS = 0x002A,
                WM_DRAWITEM = 0x002B,
                WM_MEASUREITEM = 0x002C,
                WM_DELETEITEM = 0x002D,
                WM_VKEYTOITEM = 0x002E,
                WM_CHARTOITEM = 0x002F,
                WM_SETFONT = 0x0030,
                WM_GETFONT = 0x0031,
                WM_SETHOTKEY = 0x0032,
                WM_GETHOTKEY = 0x0033,
                WM_QUERYDRAGICON = 0x0037,
                WM_COMPAREITEM = 0x0039,
                WM_GETOBJECT = 0x003D,
                WM_COMPACTING = 0x0041,
                WM_COMMNOTIFY = 0x0044,
                WM_WINDOWPOSCHANGING = 0x0046,
                WM_WINDOWPOSCHANGED = 0x0047,
                WM_POWER = 0x0048,
                WM_COPYDATA = 0x004A,
                WM_CANCELJOURNAL = 0x004B,
                WM_NOTIFY = 0x004E,
                WM_INPUTLANGCHANGEREQUEST = 0x0050,
                WM_INPUTLANGCHANGE = 0x0051,
                WM_TCARD = 0x0052,
                WM_HELP = 0x0053,
                WM_USERCHANGED = 0x0054,
                WM_NOTIFYFORMAT = 0x0055,
                WM_CONTEXTMENU = 0x007B,
                WM_STYLECHANGING = 0x007C,
                WM_STYLECHANGED = 0x007D,
                WM_DISPLAYCHANGE = 0x007E,
                WM_GETICON = 0x007F,
                WM_SETICON = 0x0080,
                WM_NCCREATE = 0x0081,
                WM_NCDESTROY = 0x0082,
                WM_NCCALCSIZE = 0x0083,
                WM_NCHITTEST = 0x0084,
                WM_NCPAINT = 0x0085,
                WM_NCACTIVATE = 0x0086,
                WM_GETDLGCODE = 0x0087,
                WM_SYNCPAINT = 0x0088,
                WM_NCMOUSEMOVE = 0x00A0,
                WM_NCLBUTTONDOWN = 0x00A1,
                WM_NCLBUTTONUP = 0x00A2,
                WM_NCLBUTTONDBLCLK = 0x00A3,
                WM_NCRBUTTONDOWN = 0x00A4,
                WM_NCRBUTTONUP = 0x00A5,
                WM_NCRBUTTONDBLCLK = 0x00A6,
                WM_NCMBUTTONDOWN = 0x00A7,
                WM_NCMBUTTONUP = 0x00A8,
                WM_NCMBUTTONDBLCLK = 0x00A9,
                WM_KEYDOWN = 0x0100,
                WM_KEYUP = 0x0101,
                WM_CHAR = 0x0102,
                WM_DEADCHAR = 0x0103,
                WM_SYSKEYDOWN = 0x0104,
                WM_SYSKEYUP = 0x0105,
                WM_SYSCHAR = 0x0106,
                WM_SYSDEADCHAR = 0x0107,
                WM_KEYLAST = 0x0108,
                WM_IME_STARTCOMPOSITION = 0x010D,
                WM_IME_ENDCOMPOSITION = 0x010E,
                WM_IME_COMPOSITION = 0x010F,
                WM_IME_KEYLAST = 0x010F,
                WM_INITDIALOG = 0x0110,
                WM_COMMAND = 0x0111,
                WM_SYSCOMMAND = 0x0112,
                WM_TIMER = 0x0113,
                WM_HSCROLL = 0x0114,
                WM_VSCROLL = 0x0115,
                WM_INITMENU = 0x0116,
                WM_INITMENUPOPUP = 0x0117,
                WM_MENUSELECT = 0x011F,
                WM_MENUCHAR = 0x0120,
                WM_ENTERIDLE = 0x0121,
                WM_MENURBUTTONUP = 0x0122,
                WM_MENUDRAG = 0x0123,
                WM_MENUGETOBJECT = 0x0124,
                WM_UNINITMENUPOPUP = 0x0125,
                WM_MENUCOMMAND = 0x0126,
                WM_CTLCOLORMSGBOX = 0x0132,
                WM_CTLCOLOREDIT = 0x0133,
                WM_CTLCOLORLISTBOX = 0x0134,
                WM_CTLCOLORBTN = 0x0135,
                WM_CTLCOLORDLG = 0x0136,
                WM_CTLCOLORSCROLLBAR = 0x0137,
                WM_CTLCOLORSTATIC = 0x0138,
                WM_MOUSEMOVE = 0x0200,
                WM_LBUTTONDOWN = 0x0201,
                WM_LBUTTONUP = 0x0202,
                WM_LBUTTONDBLCLK = 0x0203,
                WM_RBUTTONDOWN = 0x0204,
                WM_RBUTTONUP = 0x0205,
                WM_RBUTTONDBLCLK = 0x0206,
                WM_MBUTTONDOWN = 0x0207,
                WM_MBUTTONUP = 0x0208,
                WM_MBUTTONDBLCLK = 0x0209,
                WM_MOUSEWHEEL = 0x020A,
                WM_PARENTNOTIFY = 0x0210,
                WM_ENTERMENULOOP = 0x0211,
                WM_EXITMENULOOP = 0x0212,
                WM_NEXTMENU = 0x0213,
                WM_SIZING = 0x0214,
                WM_CAPTURECHANGED = 0x0215,
                WM_MOVING = 0x0216,
                WM_DEVICECHANGE = 0x0219,
                WM_MDICREATE = 0x0220,
                WM_MDIDESTROY = 0x0221,
                WM_MDIACTIVATE = 0x0222,
                WM_MDIRESTORE = 0x0223,
                WM_MDINEXT = 0x0224,
                WM_MDIMAXIMIZE = 0x0225,
                WM_MDITILE = 0x0226,
                WM_MDICASCADE = 0x0227,
                WM_MDIICONARRANGE = 0x0228,
                WM_MDIGETACTIVE = 0x0229,
                WM_MDISETMENU = 0x0230,
                WM_ENTERSIZEMOVE = 0x0231,
                WM_EXITSIZEMOVE = 0x0232,
                WM_DROPFILES = 0x0233,
                WM_MDIREFRESHMENU = 0x0234,
                WM_IME_SETCONTEXT = 0x0281,
                WM_IME_NOTIFY = 0x0282,
                WM_IME_CONTROL = 0x0283,
                WM_IME_COMPOSITIONFULL = 0x0284,
                WM_IME_SELECT = 0x0285,
                WM_IME_CHAR = 0x0286,
                WM_IME_REQUEST = 0x0288,
                WM_IME_KEYDOWN = 0x0290,
                WM_IME_KEYUP = 0x0291,
                WM_MOUSEHOVER = 0x02A1,
                WM_MOUSELEAVE = 0x02A3,
                WM_CUT = 0x0300,
                WM_COPY = 0x0301,
                WM_PASTE = 0x0302,
                WM_CLEAR = 0x0303,
                WM_UNDO = 0x0304,
                WM_RENDERFORMAT = 0x0305,
                WM_RENDERALLFORMATS = 0x0306,
                WM_DESTROYCLIPBOARD = 0x0307,
                WM_DRAWCLIPBOARD = 0x0308,
                WM_PAINTCLIPBOARD = 0x0309,
                WM_VSCROLLCLIPBOARD = 0x030A,
                WM_SIZECLIPBOARD = 0x030B,
                WM_ASKCBFORMATNAME = 0x030C,
                WM_CHANGECBCHAIN = 0x030D,
                WM_HSCROLLCLIPBOARD = 0x030E,
                WM_QUERYNEWPALETTE = 0x030F,
                WM_PALETTEISCHANGING = 0x0310,
                WM_PALETTECHANGED = 0x0311,
                WM_HOTKEY = 0x0312,
                WM_PRINT = 0x0317,
                WM_PRINTCLIENT = 0x0318,
                WM_HANDHELDFIRST = 0x0358,
                WM_HANDHELDLAST = 0x035F,
                WM_AFXFIRST = 0x0360,
                WM_AFXLAST = 0x037F,
                WM_PENWINFIRST = 0x0380,
                WM_PENWINLAST = 0x038F,
                WM_APP = 0x8000,
                WM_USER = 0x0400,
                WM_DDE_INITIATE = 0x03E0,
                WM_DDE_TERMINATE,
                WM_DDE_ADVISE,
                WM_DDE_UNADVISE,
                WM_DDE_ACK,
                WM_DDE_DATA,
                WM_DDE_REQUEST,
                WM_DDE_POKE,
                WM_DDE_EXECUTE
            }
        }

        private enum Modifier
        {
            WIN = User32.Modifiers.MOD_WIN,
            CTRL_ALT = User32.Modifiers.MOD_CONTROL | User32.Modifiers.MOD_ALT,
            ALT = User32.Modifiers.MOD_ALT
        };

        private static HotkeyController instance = null;
        private SessionController sc;

        public event EventHandler HotkeysRefreshed;

        private Dictionary<char, HotKeyId> hotkeyDictionary;

        private Dictionary<Modifier, HotkeyModifier> modifierDictionary;

        private HotkeyModifier currentHotkeyModifier;

        private HotkeyController()
        {
            sc = SessionController.getInstance();
            intitialiseModifierDictionary();
            initialiseHotkeyDictionary();
            currentHotkeyModifier = getModifier();

        }

        public static HotkeyController getInstance()
        {
            if (instance == null)
                instance = new HotkeyController();
            return instance;
        }

        protected virtual void OnHotkeysRefreshed(Object sender, EventArgs e)
        {
            if (HotkeysRefreshed != null)
                HotkeysRefreshed(sender, e);
        }

        public bool RegisterHotkey(Form form, HotKeyId id)
        {
            return RegisterHotkey(form, getHotKeyCharFromId(id), id);
        }

        public bool RegisterHotkey(Form form, char key, HotKeyId id)
        {
            bool result = User32.RegisterHotKey(form.Handle, (int)id, getModifier().Modifier, (int)(Char.ToUpper(key)));
            if (result)
                saveHotkey(key, id);
            return result;
        }

        public bool UnregisterHotKey(Form form, HotKeyId id)
        {
            bool result = User32.UnregisterHotKey(form.Handle, (int)id);
            hotkeyDictionary.Remove(getHotKeyCharFromId(id));
            return result;
        }

        public bool UnregisterAllHotKeys(Form form)
        {
            foreach (HotKeyId hk in Enum.GetValues(typeof(HotKeyId)))
            {
                // Skip over any protected hotkey
                if (hk != HotKeyId.HKID_PROTECTED)
                    UnregisterHotKey(form, hk);
            }
            return true;
        }

        public Session getSessionFromHotkey(HotKeyId hkid)
        {
            return sc.findSessionByKey(getSessionKeyFromHotkey(hkid));
        }

        private String getSessionKeyFromHotkey(HotKeyId hkid)
        {
            switch (hkid)
            {
                case HotKeyId.HKID_SESSION_1:
                    return Properties.Settings.Default.FavouriteSession1;
                case HotKeyId.HKID_SESSION_2:
                    return Properties.Settings.Default.FavouriteSession2;
                case HotKeyId.HKID_SESSION_3:
                    return Properties.Settings.Default.FavouriteSession3;
                case HotKeyId.HKID_SESSION_4:
                    return Properties.Settings.Default.FavouriteSession4;
                case HotKeyId.HKID_SESSION_5:
                    return Properties.Settings.Default.FavouriteSession5;
                case HotKeyId.HKID_SESSION_6:
                    return Properties.Settings.Default.FavouriteSession6;
                case HotKeyId.HKID_SESSION_7:
                    return Properties.Settings.Default.FavouriteSession7;
                case HotKeyId.HKID_SESSION_8:
                    return Properties.Settings.Default.FavouriteSession8;
                case HotKeyId.HKID_SESSION_9:
                    return Properties.Settings.Default.FavouriteSession9;
                case HotKeyId.HKID_SESSION_10:
                    return Properties.Settings.Default.FavouriteSession10;
                default:
                    return "";
            }
        }

        public string getHotKeyFromId(HotKeyId hkid)
        {
            return getHotKeyCharFromId(hkid).ToString();
        }

        private char getHotKeyCharFromId(HotKeyId hkid)
        {
            switch (hkid)
            {
                case HotKeyId.HKID_NEW:
                    return Properties.Settings.Default.HotkeyNewSession;
                case HotKeyId.HKID_MINIMIZE:
                    return Properties.Settings.Default.HotkeyMinimize;
                case HotKeyId.HKID_SESSION_1:
                    return Properties.Settings.Default.HotkeySession1;
                case HotKeyId.HKID_SESSION_2:
                    return Properties.Settings.Default.HotkeySession2;
                case HotKeyId.HKID_SESSION_3:
                    return Properties.Settings.Default.HotkeySession3;
                case HotKeyId.HKID_SESSION_4:
                    return Properties.Settings.Default.HotkeySession4;
                case HotKeyId.HKID_SESSION_5:
                    return Properties.Settings.Default.HotkeySession5;
                case HotKeyId.HKID_SESSION_6:
                    return Properties.Settings.Default.HotkeySession6;
                case HotKeyId.HKID_SESSION_7:
                    return Properties.Settings.Default.HotkeySession7;
                case HotKeyId.HKID_SESSION_8:
                    return Properties.Settings.Default.HotkeySession8;
                case HotKeyId.HKID_SESSION_9:
                    return Properties.Settings.Default.HotkeySession9;
                case HotKeyId.HKID_SESSION_10:
                    return Properties.Settings.Default.HotkeySession10;
                default:
                    return Properties.Settings.Default.HotkeySession1;
            }
        }


        public bool saveSessionnameToHotkey(Form window, HotKeyId hkid, Session s)
        {
            return saveSessionnameToHotkey(window, hkid, s, false);
        }
        
        public bool saveSessionnameToHotkey(Form window, HotKeyId hkid, Session s, bool saveSettings)
        {
            bool result = false;
            UnregisterHotKey(window, hkid);
            if (RegisterHotkey(window, hkid))
            {
                String sessionKey = "";
                if (s != null)
                    sessionKey = s.SessionKey;

                switch (hkid)
                {
                    case HotKeyId.HKID_SESSION_1:
                        Properties.Settings.Default.FavouriteSession1 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_2:
                        Properties.Settings.Default.FavouriteSession2 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_3:
                        Properties.Settings.Default.FavouriteSession3 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_4:
                        Properties.Settings.Default.FavouriteSession4 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_5:
                        Properties.Settings.Default.FavouriteSession5 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_6:
                        Properties.Settings.Default.FavouriteSession6 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_7:
                        Properties.Settings.Default.FavouriteSession7 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_8:
                        Properties.Settings.Default.FavouriteSession8 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_9:
                        Properties.Settings.Default.FavouriteSession9 = sessionKey;
                        result = true; break;
                    case HotKeyId.HKID_SESSION_10:
                        Properties.Settings.Default.FavouriteSession10 = sessionKey;
                        result = true; break;
                    default:
                        result = false; break;
                }
            }

            // Fire the refresh event
            if (result)
            {
                refreshHotkeys();
                if (saveSettings)
                {
                    Properties.Settings.Default.Save();
                }
            }

            return result;
        }

        public bool isFavouriteSessionHotkeysEnabled()
        {
            return Properties.Settings.Default.HotkeyFavouriteEnabled;
        }

        public bool isSessionHotkeyEnabled(HotKeyId hkid)
        {
            bool result = false;
            switch (hkid)
            {
                case HotKeyId.HKID_SESSION_1:
                    result = Properties.Settings.Default.Hotkey1Enabled; break;
                case HotKeyId.HKID_SESSION_2:
                    result = Properties.Settings.Default.Hotkey2Enabled; break;
                case HotKeyId.HKID_SESSION_3:
                    result = Properties.Settings.Default.Hotkey3Enabled; break;
                case HotKeyId.HKID_SESSION_4:
                    result = Properties.Settings.Default.Hotkey4Enabled; break;
                case HotKeyId.HKID_SESSION_5:
                    result = Properties.Settings.Default.Hotkey5Enabled; break;
                case HotKeyId.HKID_SESSION_6:
                    result = Properties.Settings.Default.Hotkey6Enabled; break;
                case HotKeyId.HKID_SESSION_7:
                    result = Properties.Settings.Default.Hotkey7Enabled; break;
                case HotKeyId.HKID_SESSION_8:
                    result = Properties.Settings.Default.Hotkey8Enabled; break;
                case HotKeyId.HKID_SESSION_9:
                    result = Properties.Settings.Default.Hotkey9Enabled; break;
                case HotKeyId.HKID_SESSION_10:
                    result = Properties.Settings.Default.Hotkey10Enabled; break;
                default:
                    result = false; break;
            }
            return result;
        }

        public void setFavouriteSessionHotkeysEnabled(bool value)
        {
            Properties.Settings.Default.HotkeyFavouriteEnabled = value;
            refreshHotkeys();
        }

        public void refreshHotkeys()
        {
            OnHotkeysRefreshed(this, EventArgs.Empty);
        }

        public int WM_HOTKEY = (int)User32.Msgs.WM_HOTKEY;
        public int WM_KEYDOWN = (int)User32.Msgs.WM_KEYDOWN;
        public int WM_SYSCOMMAND = (int)User32.Msgs.WM_SYSCOMMAND;

        public enum HotKeyId
        {
            HKID_PROTECTED = -1,
            HKID_NEW = 0,
            HKID_SESSION_1 = 1,
            HKID_SESSION_2 = 2,
            HKID_SESSION_3 = 3,
            HKID_SESSION_4 = 4,
            HKID_SESSION_5 = 5,
            HKID_SESSION_6 = 6,
            HKID_SESSION_7 = 7,
            HKID_SESSION_8 = 8,
            HKID_SESSION_9 = 9,
            HKID_SESSION_10 = 10,
            HKID_MINIMIZE = 11
        }

        private void initialiseHotkeyDictionary()
        {
            hotkeyDictionary = new Dictionary<char, HotKeyId>();

            // Add any protected hotkeys
            addProtectedHotkeys(getModifier());

            // Add all the enabled hotkeys
            if (Properties.Settings.Default.HotkeyNewEnabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeyNewSession), HotKeyId.HKID_NEW);
            if (Properties.Settings.Default.HotkeyMinimizeEnabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeyMinimize), HotKeyId.HKID_MINIMIZE);
            if (Properties.Settings.Default.Hotkey1Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession1), HotKeyId.HKID_SESSION_1);
            if (Properties.Settings.Default.Hotkey2Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession2), HotKeyId.HKID_SESSION_2);
            if (Properties.Settings.Default.Hotkey3Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession3), HotKeyId.HKID_SESSION_3);
            if (Properties.Settings.Default.Hotkey4Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession4), HotKeyId.HKID_SESSION_4);
            if (Properties.Settings.Default.Hotkey5Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession5), HotKeyId.HKID_SESSION_5);
            if (Properties.Settings.Default.Hotkey6Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession6), HotKeyId.HKID_SESSION_6);
            if (Properties.Settings.Default.Hotkey7Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession7), HotKeyId.HKID_SESSION_7);
            if (Properties.Settings.Default.Hotkey8Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession8), HotKeyId.HKID_SESSION_8);
            if (Properties.Settings.Default.Hotkey9Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession9), HotKeyId.HKID_SESSION_9);
            if (Properties.Settings.Default.Hotkey10Enabled)
                hotkeyDictionary.Add(Char.ToUpper(Properties.Settings.Default.HotkeySession10), HotKeyId.HKID_SESSION_10);
        }

        private void intitialiseModifierDictionary()
        {
            modifierDictionary = new Dictionary<Modifier,HotkeyModifier>();

            modifierDictionary.Add(Modifier.CTRL_ALT, 
                                   new HotkeyModifier((int)Modifier.CTRL_ALT, 
                                                      "Ctrl+Alt +", 
                                                      new char[]{}));
            modifierDictionary.Add(Modifier.ALT,
                                   new HotkeyModifier((int)Modifier.ALT,
                                                      "Alt +",
                                                      new char[] { }));

            modifierDictionary.Add(Modifier.WIN,      
                                   new HotkeyModifier((int)Modifier.WIN,      
                                                       "Win +"    , 
                                                       new char[] {'D','E','F','L','M','R','U'} ));
        }

        public void registerAllEnabledHotkeys( Form form )
        {
            // Register all the enabled hotkeys
            if (Properties.Settings.Default.HotkeyNewEnabled)
                RegisterHotkey(form, HotKeyId.HKID_NEW);
            if (Properties.Settings.Default.HotkeyMinimizeEnabled)
                RegisterHotkey(form, HotKeyId.HKID_MINIMIZE);
            if (Properties.Settings.Default.Hotkey1Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_1);
            if (Properties.Settings.Default.Hotkey2Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_2);
            if (Properties.Settings.Default.Hotkey3Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_3);
            if (Properties.Settings.Default.Hotkey4Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_4);
            if (Properties.Settings.Default.Hotkey5Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_5);
            if (Properties.Settings.Default.Hotkey6Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_6);
            if (Properties.Settings.Default.Hotkey7Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_7);
            if (Properties.Settings.Default.Hotkey8Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_8);
            if (Properties.Settings.Default.Hotkey9Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_9);
            if (Properties.Settings.Default.Hotkey10Enabled)
                RegisterHotkey(form, HotKeyId.HKID_SESSION_10);
        }

        public bool isHotkeyAvailable(char hotkey)
        {
            return !(hotkeyDictionary.ContainsKey(Char.ToUpper(hotkey)));
        }

        private bool saveHotkey(char hotkey, HotKeyId hkid)
        {
            hotkey = Char.ToUpper(hotkey);
            bool result = false;

            // Check the hotkey is available
            if (isHotkeyAvailable(hotkey))
            {
                result = true;

                // Save the new value in the dictionary
                hotkeyDictionary[hotkey] = hkid;

                // And update the setting
                switch (hkid)
                {
                    case HotKeyId.HKID_NEW:
                        Properties.Settings.Default.HotkeyNewSession = hotkey;
                        break;
                    case HotKeyId.HKID_MINIMIZE:
                        Properties.Settings.Default.HotkeyMinimize = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_1:
                        Properties.Settings.Default.HotkeySession1 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_2:
                        Properties.Settings.Default.HotkeySession2 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_3:
                        Properties.Settings.Default.HotkeySession3 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_4:
                        Properties.Settings.Default.HotkeySession4 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_5:
                        Properties.Settings.Default.HotkeySession5 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_6:
                        Properties.Settings.Default.HotkeySession6 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_7:
                        Properties.Settings.Default.HotkeySession7 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_8:
                        Properties.Settings.Default.HotkeySession8 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_9:
                        Properties.Settings.Default.HotkeySession9 = hotkey;
                        break;
                    case HotKeyId.HKID_SESSION_10:
                        Properties.Settings.Default.HotkeySession10 = hotkey;
                        break;
                }               
            }
            return result;
        }

        public HotkeyModifier getModifier()
        {
            HotkeyModifier m = null;
            modifierDictionary.TryGetValue((Modifier)Properties.Settings.Default.HotkeyModifier,out m);
            return m;
        }

        public void setModifier(HotkeyModifier m)
        {
            // Remove any protected hotkeys for the old modifier
            removeProtectedHotkeys(currentHotkeyModifier);

            // Set the new modifier
            Properties.Settings.Default.HotkeyModifier = m.Modifier;

            // Save the current modifier
            currentHotkeyModifier = getModifier();

            // Add in any protected keys for the new modifier
            addProtectedHotkeys(currentHotkeyModifier);
        }

        public HotkeyModifier[] getAllModifiers()
        {
            HotkeyModifier[] array = new HotkeyModifier[modifierDictionary.Count];
            modifierDictionary.Values.CopyTo(array, 0);
            return array;
        }

        private void addProtectedHotkeys(HotkeyModifier modifier)
        {
            foreach ( char c in modifier.ProtectedKeys)
            {
                // Add the default system hotkeys so they can't be duplicated
                hotkeyDictionary.Add(c, HotKeyId.HKID_PROTECTED);
            }
        }

        private void removeProtectedHotkeys ( HotkeyModifier modifier )
        {
            if (modifier != null)
            {
                foreach (char c in modifier.ProtectedKeys)
                {
                    // Remove any protected keys
                    hotkeyDictionary.Remove(c);
                }
            }
        }

        /// <summary>
        /// Check to see if the exisiting set of hotkeys contains any protected
        /// hotkeys for the new modifier
        /// </summary>
        /// <param name="modifier"></param>
        /// <returns></returns>
        public bool validateNewModifier(HotkeyModifier modifier)
        {
            bool result = true;
            foreach (char c in modifier.ProtectedKeys)
            {
                if (hotkeyDictionary.ContainsKey(c))
                {
                    HotKeyId id;
                    hotkeyDictionary.TryGetValue(c, out id);
                    if (id != HotKeyId.HKID_PROTECTED)
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
    }
}
