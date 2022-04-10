
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DigitalPharma.DigitalPharma.Registration
{
    internal class UserDAL : DatabaseConfig2
    {
        public UserDAL()
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

        #region Insert User

        public Boolean Insert(UserENT entUser)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                {
                    objConn.Open();
                }
                // UserENT entUsers = new UserENT();


                using (SqlCommand objCmd = objConn.CreateCommand())
                {

                    try
                    {
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_User_Insert";
                        //objCmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

                        objCmd.Parameters.Add("@UserID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        objCmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = entUser.UserName;
                        objCmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = entUser.Password;
                        objCmd.Parameters.Add("@DisplayName", SqlDbType.VarChar).Value = entUser.DisplayName;
                        objCmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = entUser.Address;
                        objCmd.Parameters.Add("@MobileNO", SqlDbType.VarChar).Value = entUser.MobileNO;


                        objCmd.ExecuteNonQuery();

                        if (objCmd.Parameters["@UserID"].Value != null)
                            entUser.UserID = Convert.ToInt32(objCmd.Parameters["@UserID"].Value);


                        return true;


                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }

            }
        }

        #endregion Insert User

        public Boolean SelectByUserID(SqlString UserName, SqlString Password)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                {
                    objConn.Open();
                }
                UserENT entUser = new UserENT();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_User_SelectByUsernamePassword";

                        objCmd.Parameters.AddWithValue("@Username", UserName);
                        objCmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            if (objSDR.HasRows)
                            {

                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    catch (SqlException sqlex)
                    {
                        entUser.Message = sqlex.Message;
                        return false;
                    }
                    catch (Exception ex)
                    {
                        entUser.Message = ex.Message;
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                        {
                            objConn.Close();
                        }
                    }
                }
            }
        }
        public UserENT SelectUserID(SqlString UserName, SqlString Password)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                if (objConn.State != ConnectionState.Open)
                {
                    objConn.Open();
                }
                UserENT entUser = new UserENT();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_User_SelectByUsernamePassword";

                        objCmd.Parameters.AddWithValue("@Username", UserName);
                        objCmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            if (objSDR.HasRows)
                            {
                                while (objSDR.Read())
                                {
                                    if (!objSDR["UserID"].Equals(DBNull.Value))
                                    {
                                        entUser.UserID = Convert.ToInt32(objSDR["UserID"]);
                                    }
                                    if (!objSDR["DisplayName"].Equals(DBNull.Value))
                                    {
                                        entUser.DisplayName = objSDR["DisplayName"].ToString().Trim();
                                    }
                                }
                                return entUser;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                    catch (SqlException sqlex)
                    {
                        entUser.Message = sqlex.Message;
                        return null;
                    }
                    catch (Exception ex)
                    {
                        entUser.Message = ex.Message;
                        return null;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                        {
                            objConn.Close();
                        }
                    }
                }
            }
        }
    }
}
