using System;


namespace R5T.Z0061.Platform
{
    public class TextValues : ITextValues
    {
        #region Infrastructure

        public static ITextValues Instance { get; } = new TextValues();


        private TextValues()
        {
        }

        #endregion
    }
}


namespace R5T.Z0061.Platform.Raw
{
    public class TextValues : ITextValues
    {
        #region Infrastructure

        public static ITextValues Instance { get; } = new TextValues();


        private TextValues()
        {
        }

        #endregion
    }
}
