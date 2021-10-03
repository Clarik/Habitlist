<%@ Page Title="Home" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Habitilist.Views.Home" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Urgent To-Do-List</h1>
    <hr />
    <div class="tdl-container">
        <asp:Label ID="isEmpty" CssClass="isEmpty" runat="server" Visible="false" Text="Sweet! You have no urgent to-do-list!"></asp:Label>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="to-do-list-item">
                    <div class="to-do-list-title">
                        <asp:Label ID="LblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    </div>
                    <div class="tdl-desc">
                        <asp:Label CssClass="tdl-desc1" ID="Label1" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                    </div>
                    <div class="tdl-detail">
                        <label>Deadline: </label> <br />
                        <asp:Label ID="LblDeadline" runat="server" Text='<%# Eval("Deadline") %>'></asp:Label>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div class="btn-container">
        <asp:Button ID="inspectBtn" runat="server" CssClass="btn-inspect" OnClick="inspectBtn_Click" Text="INSPECT" /><br />
    </div>
    
    <h1>Ongoing Habit</h1>
    <hr />
    <div class="habit-container">
        <asp:Label ID="isEmpty2" CssClass="isEmpty" runat="server" Visible="false" Text="You currently have no habit to achieve!"></asp:Label>
        <%foreach (var habit in habitList)
        { %>
        <div class="habit-item">
            <div class="habit-desc">
                <div class="habit-desc-name">
                    <%=habit.Name %>
                </div>
                <div>
                    Day <%=habit.HabitDetails.FirstOrDefault().Day %>
                </div>
            </div>
            <div class="habit-action">
               <a href="home.aspx?id=<%=habit.HabitDetails.FirstOrDefault().Id%>">DONE</a>
            </div> 
        </div>
        <%} %>
    </div>
    <br />
</asp:Content>
