using System;
using System.Runtime.InteropServices;

namespace PutridParrot.Windows
{
    public partial class VolumeInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct SHFILEINFOA
        {
            /// <summary>
            /// 
            /// </summary>
            public IntPtr hIcon;
            /// <summary>
            /// 
            /// </summary>
            public int iIcon;
            /// <summary>
            /// 
            /// </summary>
            public uint dwAttributes;
            /// <summary>
            /// 
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szDisplayName;
            /// <summary>
            /// 
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NAMESIZE)]
            public string szTypeName;
        };
    }

}
