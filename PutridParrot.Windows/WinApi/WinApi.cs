using System;
using System.Runtime.InteropServices;

namespace PutridParrot.Windows
{
    public static partial class WinApi
    {
        /// <summary>
        /// 
        /// </summary>
        public const int TTS_ALWAYSTIP = 0x01;
        /// <summary>
        /// 
        /// </summary>
        public const int TTS_NOPREFIX = 0x02;
        /// <summary>
        /// 
        /// </summary>
        public const int TTS_BALLOON = 0x40;
        /// <summary>
        /// 
        /// </summary>
        public const int TTF_SUBCLASS = 0x0010;
        /// <summary>
        /// 
        /// </summary>
        public const int TTF_TRANSPARENT = 0x0100;
        /// <summary>
        /// 
        /// </summary>
        public const int TTF_LEFTTIP = 0x0002;
        /// <summary>
        /// 
        /// </summary>
        public const int TTF_CENTERTIP = 0x0002;

        /// <summary>
        /// 
        /// </summary>
        public const int ECM_FIRST = 0x1500;
        /// <summary>
        /// 
        /// </summary>
        public const int EM_SHOWBALLOONTIP = ECM_FIRST + 3;

        /// <summary>
        /// 
        /// </summary>
        public const int SW_HIDE = 0;
        /// <summary>
        /// 
        /// </summary>
        public const int SW_SHOW = 5;

        /// <summary>
        /// 
        /// </summary>
        public const int LB_ADDSTRING = 0x0180;
        /// <summary>
        /// 
        /// </summary>
        public const int LB_INSERTSTRING = 0x0181;
        /// <summary>
        /// 
        /// </summary>
        public const int LB_DELETESTRING = 0x0182;

        /// <summary>
        /// 
        /// </summary>
        public const int LB_OKAY = 0;
        /// <summary>
        /// 
        /// </summary>
        public const int LB_ERR = -1;
        /// <summary>
        /// 
        /// </summary>
        public const int LB_ERRSPACE = -2;

        /// <summary>
        /// 
        /// </summary>
        public const int WM_PASTE = 0x0302;
        /// <summary>
        /// 
        /// </summary>
        public const int WM_USER = 0x0400;
        /// <summary>
        /// 
        /// </summary>
        public const int WM_SETTEXT = 0x000C;
        /// <summary>
        /// 
        /// </summary>
        public const int WM_GETTEXT = 0x000D;
        /// <summary>
        /// 
        /// </summary>
        public const int WM_GETTEXTLENGTH = 0x000E;
        /// <summary>
        /// 
        /// </summary>
        public const int WM_HSCROLL = 0x0114;
        /// <summary>
        /// 
        /// </summary>
        public const int WM_VSCROLL = 0x0115;

        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_DLGMODALFRAME = unchecked((int)0x00000001);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_NOPARENTNOTIFY = unchecked((int)0x00000004);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_TOPMOST = unchecked((int)0x00000008);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_ACCEPTFILES = unchecked((int)0x00000010);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_TRANSPARENT = unchecked((int)0x00000020);
        //#if(WINVER >= 0x0400)
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_MDICHILD = unchecked((int)0x00000040);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_TOOLWINDOW = unchecked((int)0x00000080);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_WINDOWEDGE = unchecked((int)0x00000100);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_CLIENTEDGE = unchecked((int)0x00000200);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_CONTEXTHELP = unchecked((int)0x00000400);
        //#endif /* WINVER >= 0x0400 */
        //#if(WINVER >= 0x0400)
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_RIGHT = unchecked((int)0x00001000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_LEFT = unchecked((int)0x00000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_RTLREADING = unchecked((int)0x00002000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_LTRREADING = unchecked((int)0x00000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_LEFTSCROLLBAR = unchecked((int)0x00004000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_RIGHTSCROLLBAR = unchecked((int)0x00000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_CONTROLPARENT = unchecked((int)0x00010000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_STATICEDGE = unchecked((int)0x00020000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_APPWINDOW = unchecked((int)0x00040000);
        //#endif
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_LAYERED = unchecked((int)0x00080000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_OVERLAPPED = unchecked((int)0x00000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_POPUP = unchecked((int)0x80000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_CHILD = unchecked((int)0x40000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_MINIMIZE = unchecked((int)0x20000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_VISIBLE = unchecked((int)0x10000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_DISABLED = unchecked((int)0x08000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_CLIPSIBLINGS = unchecked((int)0x04000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_CLIPCHILDREN = unchecked((int)0x02000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_MAXIMIZE = unchecked((int)0x01000000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_CAPTION = unchecked((int)0x00C00000);     /* WS_BORDER | WS_DLGFRAME  */
                                                                      /// <summary>
                                                                      /// 
                                                                      /// </summary>
        public const int WS_BORDER = unchecked((int)0x00800000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_DLGFRAME = unchecked((int)0x00400000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_VSCROLL = unchecked((int)0x00200000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_HSCROLL = unchecked((int)0x00100000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_SYSMENU = unchecked((int)0x00080000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_THICKFRAME = unchecked((int)0x00040000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_GROUP = unchecked((int)0x00020000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_TABSTOP = unchecked((int)0x00010000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_MINIMIZEBOX = unchecked((int)0x00020000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_MAXIMIZEBOX = unchecked((int)0x00010000);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_TILED = WS_OVERLAPPED;
        /// <summary>
        /// 
        /// </summary>
        public const int WS_ICONIC = WS_MINIMIZE;
        /// <summary>
        /// 
        /// </summary>
        public const int WS_SIZEBOX = WS_THICKFRAME;
        /// <summary>
        /// 
        /// </summary>
        public const int WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW;
        /// <summary>
        /// 
        /// </summary>
        public const int WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU);
        /// <summary>
        /// 
        /// </summary>
        public const int WS_CHILDWINDOW = WS_CHILD;

        /// <summary>
        /// 
        /// </summary>
        public const int TTDT_AUTOMATIC = 0;
        /// <summary>
        /// 
        /// </summary>
        public const int TTDT_RESHOW = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int TTDT_AUTOPOP = 2;
        /// <summary>
        /// 
        /// </summary>
        public const int TTDT_INITIAL = 3;

        /// <summary>
        /// 
        /// </summary>
        public const int TTM_ADDTOOL = 0x0400 + 50;
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_SETTIPBKCOLOR = 0x0400 + 19;
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_SETTIPTEXTCOLOR = 0x0400 + 20;
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_GETDELAYTIME = (WM_USER + 21);
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_ACTIVATE = (WM_USER + 1);
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_SETDELAYTIME = (WM_USER + 3);
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_WINDOWFROMPOINT = 0x0400 + 21;
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_GETTEXT = (WM_USER + 56);

        /// <summary>
        /// 
        /// </summary>
        public const int ICC_WIN95_CLASSES = 0x000000FF;
        /// <summary>
        /// 
        /// </summary>
        public const int SWP_NOSIZE = 0x0001;
        /// <summary>
        /// 
        /// </summary>
        public const int SWP_NOMOVE = 0x0002;
        /// <summary>
        /// 
        /// </summary>
        public const int SWP_NOACTIVATE = 0x0010;
        /// <summary>
        /// 
        /// </summary>
        public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        /// <summary>
        /// 
        /// </summary>
        public const string TOOLTIPS_CLASS = "TOOLTIPS_CLASS32";
        /// <summary>
        /// 
        /// </summary>
        public const int SWP_NOZORDER = 0x0004;

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern int SetWindowPos(
            IntPtr hWnd,
            IntPtr hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            int uFlags);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern int GetClientRect(
            IntPtr hWnd,
            ref RECT lpRect);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern int ClientToScreen(
            IntPtr hWnd,
            ref RECT lpRect);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            IntPtr lParam);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern int GetWindowText(
            IntPtr hWnd,
            string lpString,
            int nMaxCount);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern int SetWindowText(
            IntPtr hWnd,
            string lpString);

        /// <summary>
        /// 
        /// </summary>
        public const int TTS_CLOSE = 0x80;
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_TRACKPOSITION = WM_USER + 18;
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_SETMAXTIPWIDTH = WM_USER + 24;
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_TRACKACTIVATE = WM_USER + 17;
        /// <summary>
        /// 
        /// </summary>
        public const int TTM_SETTITLE = WM_USER + 33;

        /// <summary>
        /// 
        /// </summary>
        public const int TTF_IDISHWND = 0x0001;
        /// <summary>
        /// 
        /// </summary>
        public const int TTF_TRACK = 0x0020;
        /// <summary>
        /// 
        /// </summary>
        public const int TTF_ABSOLUTE = 0x0080;
        /// <summary>
        /// 
        /// </summary>
        public const int TTF_PARSELINKS = 0x1000;

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            ref TOOLINFO lParam);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            long lParam);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// 
        /// </summary>
        public const Int32 ULW_COLORKEY = 0x00000001;
        /// <summary>
        /// 
        /// </summary>
        public const Int32 ULW_ALPHA = 0x00000002;
        /// <summary>
        /// 
        /// </summary>
        public const Int32 ULW_OPAQUE = 0x00000004;

        /// <summary>
        /// 
        /// </summary>
        public const byte AC_SRC_OVER = 0x00;
        /// <summary>
        /// 
        /// </summary>
        public const byte AC_SRC_ALPHA = 0x01;

        /// <summary>
        /// 
        /// </summary>
        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pprSrc, Int32 crKey, ref BLENDFUNCTION pblend, Int32 dwFlags);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DeleteDC(IntPtr hdc);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DeleteObject(IntPtr hObject);

        /// <summary>
        /// 
        /// </summary>
        public static uint MAKELONG(ushort wLow, ushort wHigh)
        {
            return (uint)(wHigh << 16) | wLow;
        }
        /// <summary>
        /// 
        /// </summary>
        public static int MAKELONG(int wLow, int wHigh)
        {
            return (int)(wHigh << 16) | wLow;
        }
    }
}
