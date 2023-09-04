using System;

using R5T.T0131;


namespace R5T.Z0061.Platform
{
    /// <summary>
    /// <see cref="string"/>-based text values.
    /// </summary>
    [ValuesMarker]
    public partial interface ITextValues : IValuesMarker
    {
        private static Raw.ITextValues Raw => Platform.Raw.TextValues.Instance;


        /// <inheritdoc cref="Raw.ITextValues.N_001"/>
        public string Basic_Text => Raw.N_001;
    }
}
