<%@ Page Title="Insert ToDoList" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="InsertTDLPage.aspx.cs" Inherits="Habitilist.Views.InsertTDLPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tdl-insert">
        <div class="field-container ins-field">
            <asp:Label ID="Label1" runat="server" Text="ToDoList Name "></asp:Label>
            <asp:TextBox CssClass="textbox" ID="nameTxt" runat="server"></asp:TextBox>
        </div>
        <div class="field-container ins-field">
            <asp:Label ID="Label2" runat="server" Text="Deadline "></asp:Label>
            <asp:TextBox CssClass="textbox" ID="deadlineTxt" runat="server" placeholder="dd/mm/yyyy"></asp:TextBox>
        </div>
        <div class="field-container ins-field">
            <asp:Label ID="Label3" runat="server" Text="Description "></asp:Label>
            <asp:TextBox CssClass="textbox desc-box" ID="descriptionTxt" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
        <asp:Button CssClass="btn-insert" ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click"/>
    </div>
</asp:Content>
