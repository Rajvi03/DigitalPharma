using DigitalPharma.DigitalPharma.Registration;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DigitalPharma.DigitalPharma.SignUp
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { //if (!IsPostBack)
          //{
          //    Session.Clear();
          //}
        }
        #region Button Click :- Login
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            selectbyuname(txtUserName.Text.ToString(), txtPassword.Text.ToString());
        }
        #endregion Button Click :- Login 
        public void selectbyuname(SqlString UserName, SqlString Password)
        {

            #region Server Side Validation
            if (txtUserName.Text == "")
                lblErrorMessage.Text = "Enter User Name.";
            if (txtPassword.Text == "")
                lblErrorMessage.Text = "Enter Password";
            #endregion Server Side Validation

            #region read data

            UserENT entUser = new UserENT();


            if (txtUserName.Text != "")
                entUser.UserName = txtUserName.Text.ToString();
            if (txtPassword.Text != "")
                entUser.Password = txtPassword.Text.ToString();
            #endregion read data

            UserBAL balUser = new UserBAL();

            if (balUser.SelectByUserID(UserName, Password))
            {
                entUser = balUser.SelectUserID(UserName, Password);

                if (!entUser.UserID.IsNull)
                {
                    Session["UserID"] = entUser.UserID.Value;
                }
                if (!entUser.DisplayName.IsNull)
                {
                    Session["DisplayName"] = entUser.DisplayName.Value;
                }
                Response.Redirect("~/AdminPanelGarage/Default.aspx");

            }
            else
            {
                lblErrorMessage.Text = "fsgs";
                return;
            }

        }
    }
}