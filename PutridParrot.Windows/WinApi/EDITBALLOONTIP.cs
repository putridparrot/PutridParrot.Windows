using System.Runtime.InteropServices;

namespace PutridParrot.Windows
{
    public partial class WinApi
    {
        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct EDITBALLOONTIP
        {
            /// <summary>
            /// 
            /// </summary>
            public int cbStruct;
            /// <summary>
            /// 
            /// </summary>
            public string pszTitle;
            /// <summary>
            /// 
            /// </summary>
            public string pszText;
            /// <summary>
            /// 
            /// </summary>
            public int ttiIcon;
        }
    }
}
