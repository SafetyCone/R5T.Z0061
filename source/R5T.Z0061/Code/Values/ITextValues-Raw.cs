using System;

using R5T.T0131;
using R5T.T0185;
using R5T.T0185.Extensions;


namespace R5T.Z0061.Raw
{
    /// <summary>
    /// Raw <see cref="IText"/>-based text values.
    /// </summary>
    [ValuesMarker]
    public partial interface ITextValues : IValuesMarker
    {
        private static Platform.Raw.ITextValues Platform => Z0061.Platform.Raw.TextValues.Instance;


        /// <inheritdoc cref="Platform.Raw.ITextValues.N_001"/>
        public IText N_001 => Platform.N_001.ToText();
    }
}
