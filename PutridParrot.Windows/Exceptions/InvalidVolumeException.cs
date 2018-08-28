using System;

namespace PutridParrot.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public class InvalidVolumeException : ApplicationException
    {
        /// <summary>
        /// 
        /// </summary>
        public InvalidVolumeException(Uri VolUri) : base("Volume information could not be retreived for the path '" + VolUri.LocalPath + "'. Verify that the path is valid and ends in a trailing backslash, and try again.") { }
    }

}
