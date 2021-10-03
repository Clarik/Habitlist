<%@ Page Title="Edit Profile" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="Habitilist.Views.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-update-profile"></div>
    <div class="update-profile">
        <asp:Label CssClass="label6" ID="Label6" runat="server" Text="Pick at least one of the field (name, email, or password) to be updated and insert your (old) password for authentication!"></asp:Label>

        <div class="field-container ins-field">
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox CssClass="textbox" ID="nameTxt" runat="server"></asp:TextBox>
        </div>

        <div class="field-container ins-field">
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox CssClass="textbox" ID="emailTxt" runat="server"></asp:TextBox>
        </div>

        <div class="field-container ins-field">
            <asp:Label ID="Label5" runat="server" Text=" Old Password"></asp:Label>
            <asp:TextBox CssClass="textbox" ID="oldPasswordTxt" TextMode="Password" runat="server"></asp:TextBox>
        </div>

        <div class="field-container ins-field">
            <asp:Label ID="Label3" runat="server" Text="New Password"></asp:Label>
            <asp:TextBox CssClass="textbox" ID="newPasswordTxt" TextMode="Password" runat="server"></asp:TextBox>
        </div>

        <div class="field-container ins-field">
            <asp:Label ID="Label4" runat="server" Text="Confirmation New Password"></asp:Label>
            <asp:TextBox CssClass="textbox" ID="confNewPassTxt" TextMode="Password" runat="server"></asp:TextBox>
        </div>

        <asp:Label ID="error" runat="server" Text="" ForeColor="Red"></asp:Label>

        <asp:Button CssClass="btn" ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click"/>
    </div>
</asp:Content>
