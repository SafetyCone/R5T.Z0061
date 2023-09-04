using System;

using R5T.T0131;


namespace R5T.Z0061.Platform.Raw
{
    /// <summary>
    /// Raw <see cref="string"/>-based text values.
    /// </summary>
    [ValuesMarker]
    public partial interface ITextValues : IValuesMarker
    {
        /// <summary>
        /// <para>"This is some text."</para>
        /// Basic text.
        /// </summary>
        public string N_001 => "This is some text.";
    }
}
