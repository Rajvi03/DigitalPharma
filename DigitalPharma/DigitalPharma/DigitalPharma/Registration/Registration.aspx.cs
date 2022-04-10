using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DigitalPharma.DigitalPharma.Registration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            #region server side validation

            if (txtUserName.Text.Trim() == "")
                lblErrorMessage.Text = "Enter UserName.";
            if (txtPassword.Text.Trim() == "")
                lblErrorMessage.Text = "Enter Password.";
            if (txtDisplayName.Text.Trim() == "")
                lblErrorMessage.Text = "Enter Display Name.";
            if (txtAddress.Text.Trim() == "")
                lblErrorMessage.Text = "Enter Address.";
            if (txtMobileNo.Text.Trim() == "")
                lblErrorMessage.Text = "Enter Mobile No.";

            #endregion server side validation

            #region read data

            UserENT entUser = new UserENT();

            if (txtUserName.Text.Trim() != "")
                entUser.UserName = txtUserName.Text.Trim();
            if (txtPassword.Text.Trim() != "")
                entUser.Password = txtPassword.Text.Trim();
            if (txtDisplayName.Text.Trim() != "")
                entUser.DisplayName = txtDisplayName.Text.Trim();
            if (txtAddress.Text.Trim() != "")
                entUser.Address = txtAddress.Text.Trim();
            if (txtMobileNo.Text.Trim() != "")
                entUser.MobileNO = txtMobileNo.Text.Trim();

            #endregion read data




            UserBAL balUser = new UserBAL();



            if (balUser.Insert(entUser))
            {
                // ClearControls();

                lblErrorMessage.Text = "Data Inserted Successfully";

            }
            else
            {
                lblErrorMessage.Text = balUser.Message;

            }



        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPanelGarage/User.aspx");
        }
    }
}