using System;
using System.Runtime.InteropServices;

namespace PutridParrot.Windows
{
    public partial class WinApi
    {
        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct TOOLINFO
        {
            /// <summary>
            /// 
            /// </summary>
            public int cbSize;
            /// <summary>
            /// 
            /// </summary>
            public int uFlags;
            /// <summary>
            /// 
            /// </summary>
            public IntPtr hwnd;
            /// <summary>
            /// 
            /// </summary>
            public IntPtr uId;
            /// <summary>
            /// 
            /// </summary>
            public RECT rect;
            /// <summary>
            /// 
            /// </summary>
            public IntPtr hinst;
            /// <summary>
            /// 
            /// </summary>
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpszText;
            /// <summary>
            /// 
            /// </summary>
            public uint lParam;
        }
    }
}
