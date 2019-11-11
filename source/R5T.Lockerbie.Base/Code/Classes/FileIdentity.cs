using System;

using R5T.Guide;


namespace R5T.Lockerbie
{
    public class FileIdentity : TypedGuid
    {
        #region Static

        public static FileIdentity New(Guid value)
        {
            var output = new FileIdentity(value);
            return output;
        }

        #endregion


        public FileIdentity(Guid value)
            : base(value)
        {
        }
    }
}
