using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PutridParrot.Windows
{
    public partial class Shell
    {
        [DllImport("shfolder.dll", CharSet = CharSet.Auto)]
        internal static extern int SHGetFolderPath(
            IntPtr hwndOwner, int nFolder, IntPtr hToken, 
            int dwFlags, StringBuilder lpszPath);

        public const int STGM_READ = 0;
        public const int MAX_PATH = 260;
    }
}
