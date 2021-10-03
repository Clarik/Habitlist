<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Habitilist.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="../CSS/LoginRegister.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <img src="../Assets/Logo.png" width="100px"/>
            
            <div class="field-container">
                <asp:Label CssClass="username-txt" ID="Label1" runat="server" Text="Username"></asp:Label>
                <asp:TextBox CssClass="textbox" ID="nameTxt" runat="server"></asp:TextBox>
            </div>

            <div class="field-container">
                <asp:Label CssClass="password-txt" ID="Label3" runat="server" Text="Password"></asp:Label>
                <asp:TextBox CssClass="textbox" ID="passwordTxt" runat="server"></asp:TextBox>
            </div>

            <br />
            <asp:Label ID="error" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Button CssClass="btn-" ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click"/> <br /> <br />

            <asp:Label ID="registerTxt" runat="server" Text="Don't have an account yet? Register Now!"></asp:Label> <br />
            <asp:Button CssClass="btn- regis" ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click"/>
        </div>
    </form>
</body>
</html>
