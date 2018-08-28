namespace PutridParrot.Windows
{
    /// <summary>
    /// Represents the different types of drives that may exist in a system.
    /// </summary>
    public enum VolumeTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,    // The drive type cannot be determined. 
        /// <summary>
        /// 
        /// </summary>
        Invalid,    // The root path is invalid. For example, no volume is mounted at the path. 
        /// <summary>
        /// 
        /// </summary>
        Removable,  // The disk can be removed from the drive. 
        /// <summary>
        /// 
        /// </summary>
        Fixed,      // The disk cannot be removed from the drive. 
        /// <summary>
        /// 
        /// </summary>
        Remote,     // The drive is a remote (network) drive. 
        /// <summary>
        /// 
        /// </summary>
        CDROM,      // The drive is a CD-ROM drive. 
        /// <summary>
        /// 
        /// </summary>
        RAMDisk     // The drive is a RAM disk. 
    };
}