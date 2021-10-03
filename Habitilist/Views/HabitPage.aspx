<%@ Page Title="Habit" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="HabitPage.aspx.cs" Inherits="Habitilist.Views.HabitPage" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="habit-labels">
        <label id="target">Target</label>
        <label id="details">Details</label>
        <label id="action">Action</label>
    </div>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="habit-page-container">
                <div class="habit-target">
                    <div class="field-container">
                        <asp:Label ID="LblTarget" runat="server" Text='<%# Eval("Target") %>'></asp:Label>
                    </div>
                </div>
                <div class="habit-details">
                    <div class="name-field-container">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    </div>
                    <div class="points-field-container">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Points") %>'></asp:Label>
                        <label> Points</label>
                    </div>
                </div>
                <div class="action-button">
                    <asp:Button CssClass="btn-delete" ID="deleteBtn" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="BtnDelete" OnClick="deleteBtn_Click" Text="DELETE" />
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div class="btn-insert-habit">
        <asp:Button CssClass="btn-insert" ID="insertBtn" runat="server" Text="INSERT" OnClick="insertBtn_Click" />
    </div>
</asp:Content>
