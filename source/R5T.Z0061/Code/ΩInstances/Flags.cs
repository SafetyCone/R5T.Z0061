using System;


namespace R5T.Z0061
{
    public class Flags : IFlags
    {
        #region Infrastructure

        public static IFlags Instance { get; } = new Flags();


        private Flags()
        {
        }

        #endregion
    }
}
