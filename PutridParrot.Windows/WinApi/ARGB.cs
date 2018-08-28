using System.Runtime.InteropServices;

namespace PutridParrot.Windows
{
    public partial class WinApi
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct ARGB
        {
            public byte Blue;
            public byte Green;
            public byte Red;
            public byte Alpha;
        }
    }
}
