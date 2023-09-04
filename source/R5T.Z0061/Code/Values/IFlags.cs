using System;
using System.IO;

using R5T.T0131;


namespace R5T.Z0061
{
    [ValuesMarker]
    public partial interface IFlags : IValuesMarker
    {
        public FileAttributes Flag_A => FileAttributes.ReadOnly;
        public FileAttributes Flag_B => FileAttributes.Hidden;
        public FileAttributes Flag_C => FileAttributes.System;
        public FileAttributes Flag_AB => this.Flag_A | this.Flag_B;
    }
}
