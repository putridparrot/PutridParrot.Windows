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
        public struct Size
        {
            /// <summary>
            /// 
            /// </summary>
            public Int32 cx;
            /// <summary>
            /// 
            /// </summary>
            public Int32 cy;

            /// <summary>
            /// 
            /// </summary>
            public Size(Int32 cx, Int32 cy) { this.cx = cx; this.cy = cy; }
        }
    }
}
