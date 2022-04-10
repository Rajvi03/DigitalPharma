using DigitalPharma;
using System;
using System.Data.SqlTypes;

namespace DigitalPharma.DigitalPharma.Registration
{
    internal class UserBAL
    {
        public UserBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Local Variable
        protected string _Message;

        public string Message
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

        #region Insert Operation

        public Boolean Insert(UserENT entUser)
        {
            UserDAL dalService = new UserDAL();

            if (dalService.Insert(entUser))
            {
                return true;
            }
            else
            {
                Message = dalService.Message;
                return false;
            }
        }

        #endregion Insert Operation

        public Boolean SelectByUserID(SqlString UserName, SqlString Password)
        {
            UserDAL dalUser = new UserDAL();
            if (dalUser.SelectByUserID(UserName, Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public UserENT SelectUserID(SqlString UserName, SqlString Password)
        {
            UserDAL dalUser = new UserDAL();

            return dalUser.SelectUserID(UserName, Password);
        }

    }
}