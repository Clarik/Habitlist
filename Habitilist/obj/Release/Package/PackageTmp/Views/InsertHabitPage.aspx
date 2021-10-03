<%@ Page Title="Insert Habit" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="InsertHabitPage.aspx.cs" Inherits="Habitilist.Views.InsertHabitPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="habit-insert">
        <div class="field-container ins-field">
            <asp:Label ID="Label3" runat="server" Text="Habit Name "></asp:Label>
            <asp:TextBox CssClass="textbox" ID="nameTxt" runat="server"></asp:TextBox>
        </div>
        <div class="field-container ins-field">
            <asp:Label ID="Label2" runat="server" Text="Target "></asp:Label>
            <asp:TextBox CssClass="textbox" ID="targetTxt" runat="server" placeholder="dd/mm/yyyy"></asp:TextBox>
        </div>
        <asp:Button CssClass="btn-insert" ID="insertBtn" runat="server" Text="INSERT" OnClick="insertBtn_Click" />
    </div>
</asp:Content>
