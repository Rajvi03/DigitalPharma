using System;
using System.Data.SqlTypes;

namespace DigitalPharma.DigitalPharma.Registration
{
    internal class UserENT
    {
        public UserENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        #region Local Variable

        protected String _Message;

        public String Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Local Variable

        #region UserID
        protected SqlInt32 _UserID;

        public SqlInt32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }

        #endregion UserID

        #region UserName

        protected SqlString _UserName;

        public SqlString UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        #endregion UserName

        #region Password

        protected SqlString _Password;

        public SqlString Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        #endregion Password

        #region DisplayName

        protected SqlString _DisplayName;

        public SqlString DisplayName
        {
            get
            {
                return _DisplayName;
            }
            set
            {
                _DisplayName = value;
            }
        }

        #endregion DisplayName

        #region Address

        protected SqlString _Address;

        public SqlString Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }

        #endregion Address

        #region MobileNO

        protected SqlString _MobileNO;

        public SqlString MobileNO
        {
            get
            {
                return _MobileNO;
            }
            set
            {
                _MobileNO = value;
            }
        }

        #endregion MobileNO
    }
}