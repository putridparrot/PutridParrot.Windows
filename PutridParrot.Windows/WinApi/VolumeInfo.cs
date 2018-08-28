using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace PutridParrot.Windows
{

    /// <summary>
    /// Presents information about a volume.
    /// </summary>
    public partial class VolumeInfo
    {
        private const int NAMESIZE = 80;
        private const int MAX_PATH = 256;
        private const int FILE_ATTRIBUTE_NORMAL = 128;
        private const int SHGFI_USEFILEATTRIBUTES = 16;
        private const int SHGFI_ICON = 256;
        private const int SHGFI_LARGEICON = 0;
        private const int SHGFI_SMALLICON = 1;

        [DllImport("mpr.dll")]
        private static extern UInt32 WNetGetUniversalName(string driveLetter, UniInfoLevels InfoLevel, IntPtr Ptr, ref UInt32 UniSize);
        [DllImport("kernel32.dll")]
        private static extern long GetDriveType(string driveLetter);
        [DllImport("Shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);
        [DllImport("kernel32.dll")]
        private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, UInt32 VolumeNameSize, ref UInt32 VolumeSerialNumber, ref UInt32 MaximumComponentLength, ref UInt32 FileSystemFlags, StringBuilder FileSystemNameBuffer, UInt32 FileSystemNameSize);

        private Uri uri;
        private Icon largeIcon;
        private Icon smallIcon;
        private string volLabel;
        private VolumeTypes volType;
        private UInt32 serNum;
        private UInt32 maxCompLen;
        private VolumeFlags volFlags;
        private string fsName;

        /// <summary>
        /// 
        /// </summary>
        public VolumeInfo(Uri uri)
        {
            // Make sure we were passed something
            if (uri == null) throw new ArgumentNullException();

            // Make sure we can handle this type of uri
            if (!uri.IsFile) throw new InvalidVolumeException(uri);

            // Make sure Uri is trailed properly
            if (!uri.LocalPath.EndsWith("\\")) throw new InvalidVolumeException(uri);

            // Store the Uri
            this.uri = uri;

            // Build information. 
            Refresh();
        }

        private bool FlagSet(VolumeFlags Flag)
        {
            return ((volFlags & Flag) == Flag);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Refresh()
        {
            // Set defaults
            largeIcon = null;
            smallIcon = null;
            volLabel = "";
            volType = VolumeTypes.Invalid;
            serNum = 0;
            maxCompLen = 0;
            volFlags = VolumeFlags.Unknown;
            fsName = "";

            // Get the volume type
            volType = (VolumeTypes)GetDriveType(uri.LocalPath);

            // If not successful, throw an exception
            if (volType == VolumeTypes.Invalid) throw new InvalidVolumeException(uri);

            // Declare Receiving Variables
            StringBuilder VolLabel = new StringBuilder(256);    // Label
            UInt32 VolFlags = new UInt32();
            StringBuilder FSName = new StringBuilder(256);  // File System Name

            // Attempt to retreive the information
            long Ret = GetVolumeInformation(uri.LocalPath, VolLabel, (UInt32)VolLabel.Capacity, ref serNum, ref maxCompLen, ref VolFlags, FSName, (UInt32)FSName.Capacity);
            // if (Ret != 0) throw new VolumeAccessException();

            // Move to regular variables
            volLabel = VolLabel.ToString();
            volFlags = (VolumeFlags)VolFlags;
            fsName = FSName.ToString();

            // Attempt to get icons
            largeIcon = GetIcon(true);
            smallIcon = GetIcon(false);
        }

        private Icon GetIcon(bool Large)
        {
            // Holder
            Icon Ret = null;

            // Attempt
            try
            {
                // Create structure
                SHFILEINFO shfi = new SHFILEINFO();

                // Calc Flags
                uint flgs = SHGFI_USEFILEATTRIBUTES | SHGFI_ICON;
                if (!Large) flgs |= SHGFI_SMALLICON;

                // Call method
                SHGetFileInfo(uri.LocalPath, FILE_ATTRIBUTE_NORMAL, ref shfi, (uint)Marshal.SizeOf(shfi), flgs);

                // Return the icon
                Ret = Icon.FromHandle(shfi.hIcon);
            }
            catch { }

            // Return icon.
            return Ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public Uri Uri
        {
            get
            {
                return uri;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public VolumeTypes VolumeType
        {
            get
            {
                return volType;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UncPath
        {
            get
            {
                // Make sure it's the right type
                if (volType != VolumeTypes.Remote) throw new InvalidVolumeTypeException();

                // If it is a Unc path, just return the root
                if (uri.IsUnc) return uri.LocalPath;

                // It's a mapped drive letter, we have to perform the lookup
                // Allocate Memory
                uint Sze = 255;
                IntPtr Buff = Marshal.AllocCoTaskMem((int)Sze);

                // Call API to perform lookup
                uint Ret = WNetGetUniversalName(uri.LocalPath, UniInfoLevels.Universal, Buff, ref Sze);

                if (Ret != 0)
                {
                    Marshal.FreeCoTaskMem(Buff);
                    throw new VolumeAccessException();
                }

                // Get the result
                UniversalNameInfo Result = (UniversalNameInfo)Marshal.PtrToStructure(Buff, typeof(UniversalNameInfo));

                // Free the memory
                Marshal.FreeCoTaskMem(Buff);

                // Get result
                string sRes = Result.NetworkPath;
                if (!sRes.EndsWith("\\")) sRes += "\\";

                // Return the result
                return sRes;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Icon LargeIcon
        {
            get
            {
                return largeIcon;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Icon SmallIcon => smallIcon;

        /// <summary>
        /// 
        /// </summary>
        public string Label => volLabel;

        /// <summary>
        /// 
        /// </summary>
        public UInt32 SerialNumber => serNum;

        /// <summary>
        /// 
        /// </summary>
        public UInt32 MaxComponentLen => maxCompLen;

        /// <summary>
        /// 
        /// </summary>
        public VolumeFlags Flags => volFlags;

        /// <summary>
        /// 
        /// </summary>
        public bool CaseSensitive => FlagSet(VolumeFlags.CaseSensitive);

        /// <summary>
        /// 
        /// </summary>
        public bool Compressed => FlagSet(VolumeFlags.Compressed);

        /// <summary>
        /// 
        /// </summary>
        public bool PersistentACLS => FlagSet(VolumeFlags.PersistentACLS);


        /// <summary>
        /// 
        /// </summary>
        public bool PreservesCase => FlagSet(VolumeFlags.PreservesCase);

        /// <summary>
        /// 
        /// </summary>
        public bool ReadOnly => FlagSet(VolumeFlags.ReadOnly);

        /// <summary>
        /// 
        /// </summary>
        public bool SupportsEncryption => FlagSet(VolumeFlags.SupportsEncryption);

        /// <summary>
        /// 
        /// </summary>
        public bool SupportsFileCompression => FlagSet(VolumeFlags.SupportsFileCompression);

        /// <summary>
        /// 
        /// </summary>
        public bool SupportsNamedStreams => FlagSet(VolumeFlags.SupportsNamedStreams);

        /// <summary>
        /// 
        /// </summary>
        public bool SupportsObjectIDs => FlagSet(VolumeFlags.SupportsObjectIDs);

        /// <summary>
        /// 
        /// </summary>
        public bool SupportsQuotas => FlagSet(VolumeFlags.SupportsQuotas);

        /// <summary>
        /// 
        /// </summary>
        public bool SupportsReparsePoints => FlagSet(VolumeFlags.SupportsReparsePoints);

        /// <summary>
        /// 
        /// </summary>
        public bool SupportsSparseFiles => FlagSet(VolumeFlags.SupportsSparseFiles);

        /// <summary>
        /// 
        /// </summary>
        public bool SupportsUnicodeOnVolume => FlagSet(VolumeFlags.SupportsUnicodeOnVolume);


        /// <summary>
        /// 
        /// </summary>
        static public VolumeInfo CurrentVolume => 
            new VolumeInfo(new Uri(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())));
    }

}
