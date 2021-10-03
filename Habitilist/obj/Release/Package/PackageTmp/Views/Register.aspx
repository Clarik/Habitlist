<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Habitilist.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link rel="stylesheet" href="../CSS/LoginRegister.css"/>
    <script>
        function myFunction() {
            window.scroll({
              top: 180,
              behavior: 'smooth' 
            });
        }
    </script>
</head>
<body class="rgis" onload="myFunction()">
    <form id="form1" runat="server">
        <div class="bg"></div>
        <div class="register">
            <a href="Login.aspx">
                <img src="../Assets/Logo.png" width="100px"/>
            </a>

            <div class="field-container">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                <asp:TextBox CssClass="textbox rg" ID="nameTxt" runat="server"></asp:TextBox>
            </div>

            <div class="field-container">
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                <asp:TextBox CssClass="textbox rg" ID="emailTxt" runat="server"></asp:TextBox>
            </div>

            <div class="field-container">
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                <asp:TextBox CssClass="textbox rg" ID="passwordTxt" TextMode="Password" runat="server"></asp:TextBox>
            </div>

            <div class="field-container">
                <asp:Label ID="Label4" runat="server" Text="Confirmation Password"></asp:Label>
                <asp:TextBox CssClass="textbox rg" ID="confPassTxt" TextMode="Password" runat="server"></asp:TextBox>
            </div>

            <br />
            <asp:Label ID="error" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Button CssClass="btn- regis" ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click"/>
        </div>
    </form>
</body>
</html>
