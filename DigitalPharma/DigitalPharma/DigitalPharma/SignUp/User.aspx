<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="DigitalPharma.DigitalPharma.SignUp.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <%--<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="../../Content/js/bootstrap.min.js"></script>
    <script src="../../Content/js/jquery.min.js"></script>


    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>--%>

      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

     
    <!--Fontawesome CDN-->
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

	<!--Custom styles-->
	<link rel="stylesheet" type="text/css" href="../content/Styles/Styles.css">

</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
	<div class="d-flex justify-content-center h-100">
		<div class="card">
			<div class="card-header">
				<h3 >Sign In</h3>
				<div class="d-flex justify-content-end social_icon">
					<span><i class="fab fa-facebook-square"></i></span>
					<span><i class="fab fa-google-plus-square"></i></span>
					<span><i class="fab fa-twitter-square"></i></span>
				</div>
			</div>
			<div class="card-body">
				<div class="row">
                    <asp:Label ID="lblErrorMessage" runat="server" Text="" Display="Dynamic" CssClass="text-danger" EnableViewState="false"></asp:Label>
                </div>
					<div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-user"></i></span>
						</div>
						<asp:TextBox CssClass="form-control" ID="txtUserName" runat="server" EnableViewState="false" type="text" name="username" placeholder="username" />
						
					</div>
                <asp:RequiredFieldValidator Display="Dynamic" ID="rfvUserName" runat="server" ControlToValidate="txtUserName" CssClass="text-danger" ErrorMessage="Enter UserName" ValidationGroup="Login"></asp:RequiredFieldValidator>
					<div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-key"></i></span>
						</div>
						<asp:TextBox class="text-center" ID="txtPassword" runat="server" CssClass="form-control" placeholder="password" TextMode="Password"></asp:TextBox>
                        
					</div>
                <asp:RequiredFieldValidator ID="rfvPassword"   runat="server" CssClass="text-danger" ErrorMessage="Enter Password" ControlToValidate="txtPassword" ValidationGroup="Login" Display="Dynamic"></asp:RequiredFieldValidator>
					<div class="row align-items-center remember">
						<input type="checkbox">Remember Me
					</div>
					<div class="form-group">
                        <asp:Button ID="btnLogin" runat="server" class="btn float-right login_btn" Text="Login" OnClick="btnLogin_Click"  ValidationGroup="Login" />
						
					</div>
				
			</div>
			<div class="card-footer">
				<div class="d-flex justify-content-center links">
					Don't have an account?<a href="#">
                            <asp:HyperLink ID="hlNewUser" runat="server" Text="Create New User" NavigateUrl="~/AdminPanelGarage/AddNewUser/CreateNewUser.aspx"></asp:HyperLink>
                        </a>
				</div>
				<div class="d-flex justify-content-center">
					<a href="#">Forgot your password?</a>
				</div>
			</div>
		</div>
	</div>
</div>
    </form>
</body>
</html>
