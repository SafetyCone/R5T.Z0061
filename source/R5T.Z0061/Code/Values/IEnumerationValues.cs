using System;
using System.IO;

using R5T.T0131;
using R5T.T0225.T000;


namespace R5T.Z0061
{
    [ValuesMarker]
    public partial interface IEnumerationValues : IValuesMarker
    {
        /// <summary>
        /// An <see cref="int"/>-based (default) enumeration value.
        /// </summary>
        public Enumeration_000 IntBased => Enumeration_000.Value_000;

        /// <summary>
        /// A <see cref="uint"/>-based enumeration value.
        /// </summary>
        public Enumeration_001 UIntBased => Enumeration_001.Value_000;

        /// <summary>
        /// A <see cref="byte"/>-based enumeration value.
        /// </summary>
        public Enumeration_002 ByteBased => Enumeration_002.Value_000;

        /// <summary>
        /// A <see cref="sbyte"/>-based enumeration value.
        /// </summary>
        public Enumeration_003 SbyteBased => Enumeration_003.Value_000;

        /// <summary>
        /// A <see cref="short"/>-based enumeration value.
        /// </summary>
        public Enumeration_004 ShortBased => Enumeration_004.Value_000;

        /// <summary>
        /// A <see cref="ushort"/>-based enumeration value.
        /// </summary>
        public Enumeration_005 UShortBased => Enumeration_005.Value_000;

        /// <summary>
        /// A <see cref="long"/>-based enumeration value.
        /// </summary>
        public Enumeration_006 LongBased => Enumeration_006.Value_000;

        /// <summary>
        /// A <see cref="ulong"/>-based enumeration value.
        /// </summary>
        public Enumeration_007 UshortBased => Enumeration_007.Value_000;

        /// <summary>
        /// A flag enumeration value that is all zeros.
        /// </summary>
        public Enumeration_100 Flag_0 => Enumeration_100.Value_0;

        /// <summary>
        /// A flag enumeration value of 1.
        /// </summary>
        public Enumeration_100 Flag_1 => Enumeration_100.Value_1;

        /// <summary>
        /// A flag enumeration value of 2.
        /// </summary>
        public Enumeration_100 Flag_2 => Enumeration_100.Value_2;
    }
}
