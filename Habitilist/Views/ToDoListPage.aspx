<%@ Page Title="ToDoList" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="ToDoListPage.aspx.cs" Inherits="Habitilist.Views.ToDoListPage" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="labels">
        <label id="label-name">Name </label>
        <label>Deadline </label>
        <label>Description </label>
        <label>Points </label>
        <label>Actions</label>
    </div>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="tdl-container1">
                <asp:Label ID="LblName" CssClass="tdl-label-name" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                
                <asp:Label ID="LblDeadline" CssClass="tdl-label" runat="server" Text='<%# Eval("Deadline") %>'></asp:Label>
                
                <asp:Label ID="LblDescription" CssClass="tdl-label" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                
                <asp:Label ID="LabelPoints" CssClass="tdl-label" runat="server" Text='<%# Eval("Points") %>'></asp:Label>

                <div class="action-buttons">
                    <asp:Button ID="doneBtn" CssClass="btn" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="BtnDone" OnClick="doneBtn_Click" Text="DONE" />
                    <asp:Button ID="deleteBtn" CssClass="btn" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="BtnDelete" OnClick="deleteBtn_Click" Text="DELETE" />
                </div>
                <br />
            </div>
            <hr class="line-break"/>
        </ItemTemplate>
    </asp:Repeater>

     <div class="btn-container">
        <asp:Button ID="insertTDLBtn" CssClass="btn-insert" runat="server" Text="Insert" OnClick="insertTDLBtn_Click"/>
    </div>
</asp:Content>
