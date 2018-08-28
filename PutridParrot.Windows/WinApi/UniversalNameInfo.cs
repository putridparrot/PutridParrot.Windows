using System.Runtime.InteropServices;

namespace PutridParrot.Windows
{
    public partial class VolumeInfo
    {
        [StructLayout(LayoutKind.Sequential)]
        private class UniversalNameInfo
        {
            public string NetworkPath = null;
        }
    }

}
