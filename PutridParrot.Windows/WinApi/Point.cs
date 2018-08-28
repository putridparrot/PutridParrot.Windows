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
        public struct Point
        {
            /// <summary>
            /// 
            /// </summary>
            public Int32 x;
            /// <summary>
            /// 
            /// </summary>
            public Int32 y;

            /// <summary>
            /// 
            /// </summary>
            public Point(Int32 x, Int32 y) { this.x = x; this.y = y; }
        }
    }
}
