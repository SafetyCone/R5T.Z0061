using System;


namespace R5T.Z0061
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


namespace R5T.Z0061.Raw
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
