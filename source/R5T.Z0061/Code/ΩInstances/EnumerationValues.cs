using System;


namespace R5T.Z0061
{
    public class EnumerationValues : IEnumerationValues
    {
        #region Infrastructure

        public static IEnumerationValues Instance { get; } = new EnumerationValues();


        private EnumerationValues()
        {
        }

        #endregion
    }
}
