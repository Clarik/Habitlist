<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Habitilist.Views.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-prof">
        
    </div>
    <div class="prof-container">
        <div class="profile">
            <asp:Label CssClass="username" ID="nameTxt" runat="server" Text=""></asp:Label>
            <asp:Label CssClass="email" ID="emailTxt" runat="server" Text=""></asp:Label>
            <asp:Label ID="pointsTxt" runat="server" Text=""></asp:Label>

            <div class="button">
                <asp:Button CssClass="btn pr" ID="editBtn" runat="server" Text="Edit Profile" OnClick="editBtn_Click"/>
                <asp:Button CssClass="btn pr lg" ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
