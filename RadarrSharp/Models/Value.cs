using System.Collections.Generic;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial struct Value
    {
        /// <summary>
        /// The bool
        /// </summary>
        public bool? Bool;

        /// <summary>
        /// The integer
        /// </summary>
        public long? Integer;

        /// <summary>
        /// The integer array
        /// </summary>
        public IList<long> IntegerArray;

        /// <summary>
        /// The string
        /// </summary>
        public string String;
    }
}
