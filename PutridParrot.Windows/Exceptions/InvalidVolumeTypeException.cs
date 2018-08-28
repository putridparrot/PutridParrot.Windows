using System;

namespace PutridParrot.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public class InvalidVolumeTypeException : ApplicationException
    {
        /// <summary>
        /// 
        /// </summary>
        public InvalidVolumeTypeException() : base("This action cannot be performed because of the volume is of the wrong type.") { }
    }

}
