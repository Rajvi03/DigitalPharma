<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="DigitalPharma.DigitalPharma.Registration.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="../../Content/js/bootstrap.min.js"></script>
    <script src="../../Content/js/jquery.min.js"></script>


    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="padding-top: 50px;">


            <div class="card">
                <h1 class="card-header"><strong>Create Account</strong></h1>
                <div class="card-body">
                    <h2 class="card-title"><strong>Enter Your Details</strong></h2>



                    <div class="row">
                        <div class="col-md-12" style="padding-left: 15px;">
                            <asp:Label ID="lblErrorMessage" runat="server" Text="" CssClass="text-success"></asp:Label>
                        </div>
                    </div>
                    <div class="container">
                        <div class="row" style="padding-top: 15px;">
                            <div class="col-md-2 ">UserName</div>
                            <div class="col-md-1">:</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtUserName" runat="server" Text="" Placeholder="Enter User Name" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rfvUserName" ErrorMessage="Enter User Name" ControlToValidate="txtUserName" Display="Dynamic" CssClass="text-danger" ValidationGroup="Login"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row" style="padding-top: 15px;">
                            <div class="col-md-2">Password</div>
                            <div class="col-md-1">:</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtPassword" runat="server" Text="" TextMode="Password" Placeholder="Enter Password" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ErrorMessage="Enter Password" ControlToValidate="txtPassword" Display="Dynamic" CssClass="text-danger" ValidationGroup="Login"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row" style="padding-top: 15px;">
                            <div class="col-md-2">Display Name</div>
                            <div class="col-md-1">:</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtDisplayName" runat="server" Text="" Placeholder="Enter Display Name" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rfvDisplayName" ErrorMessage="Enter Display Name" ControlToValidate="txtDisplayName" Display="Dynamic" CssClass="text-danger" ValidationGroup="Login"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row" style="padding-top: 15px;">
                            <div class="col-md-2">Address</div>
                            <div class="col-md-1">:</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtAddress" runat="server" Text="" Placeholder="Enter Address" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rfvAddress" ErrorMessage="Enter Address" ControlToValidate="txtAddress" Display="Dynamic" CssClass="text-danger" ValidationGroup="Login"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row" style="padding-top: 15px;">
                            <div class="col-md-2">MobileNo</div>
                            <div class="col-md-1">:</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtMobileNo" runat="server" Text="" Placeholder="Enter Mobile Number" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rfvMobileNo" ErrorMessage="Enter MobileNo" ControlToValidate="txtMobileNo" Display="Dynamic" CssClass="text-danger" ValidationGroup="Login"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="revMobileNo" runat="server" ControlToValidate="txtMobileNo" ErrorMessage="enter correct Mobile no (10 digit)" CssClass="text-danger" ValidationGroup="Login" Display="Dynamic" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="row" style="padding-top: 15px;">
                            <div class="col-md-3"></div>
                            <div class="col-md-4" style="padding-bottom: 15px;">
                                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-info" ValidationGroup="Login" OnClick="btnLogin_Click" />&nbsp;&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-danger" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
