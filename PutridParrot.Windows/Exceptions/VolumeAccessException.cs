using System;

namespace PutridParrot.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public class VolumeAccessException : ApplicationException
    {
        /// <summary>
        /// 
        /// </summary>
        public VolumeAccessException() : base("The volume could not be accessed and may be offline.") { }
    }

}
