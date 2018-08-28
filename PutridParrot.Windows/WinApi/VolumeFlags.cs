using System;

namespace PutridParrot.Windows
{
    /// <summary>
    /// Represents the different supporting flags that may be set on a file system.
    /// </summary>
    [Flags]
    public enum VolumeFlags
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown = 0x0,
        /// <summary>
        /// 
        /// </summary>
        CaseSensitive = 0x00000001,
        /// <summary>
        /// 
        /// </summary>
        Compressed = 0x00008000,
        /// <summary>
        /// 
        /// </summary>
        PersistentACLS = 0x00000008,
        /// <summary>
        /// 
        /// </summary>
        PreservesCase = 0x00000002,
        /// <summary>
        /// 
        /// </summary>
        ReadOnly = 0x00080000,
        /// <summary>
        /// 
        /// </summary>
        SupportsEncryption = 0x00020000,
        /// <summary>
        /// 
        /// </summary>
        SupportsFileCompression = 0x00000010,
        /// <summary>
        /// 
        /// </summary>
        SupportsNamedStreams = 0x00040000,
        /// <summary>
        /// 
        /// </summary>
        SupportsObjectIDs = 0x00010000,
        /// <summary>
        /// 
        /// </summary>
        SupportsQuotas = 0x00000020,
        /// <summary>
        /// 
        /// </summary>
        SupportsReparsePoints = 0x00000080,
        /// <summary>
        /// 
        /// </summary>
        SupportsSparseFiles = 0x00000040,
        /// <summary>
        /// 
        /// </summary>
        SupportsUnicodeOnVolume = 0x00000004
    };
}