using System.Runtime.InteropServices;

namespace PutridParrot.Windows
{
    public partial class WinApi
    {
        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            /// <summary>
            /// 
            /// </summary>
            public byte BlendOp;
            /// <summary>
            /// 
            /// </summary>
            public byte BlendFlags;
            /// <summary>
            /// 
            /// </summary>
            public byte SourceConstantAlpha;
            /// <summary>
            /// 
            /// </summary>
            public byte AlphaFormat;
        }
    }
}
