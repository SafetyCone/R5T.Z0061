using System;

using R5T.T0131;
using R5T.T0185;


namespace R5T.Z0061
{
    /// <summary>
    /// <see cref="IText"/>-based text values.
    /// </summary>
    [ValuesMarker]
    public partial interface ITextValues : IValuesMarker
    {
        private static Raw.ITextValues Raw => Z0061.Raw.TextValues.Instance;


        /// <inheritdoc cref="Raw.ITextValues.N_001"/>
        public IText Basic_Text => Raw.N_001;
    }
}
