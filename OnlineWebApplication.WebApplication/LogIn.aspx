<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="OnlineWebApplication.WebApplication.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    LogIn
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content_Body" runat="server">
  
        <div align="center">
            <h1>Login</h1>
            <table class="auto-style">
                <tr>
                    <td>User Id</td>
                    <td>
                        <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvUserId" runat="server"
                            ErrorMessage="Invalid ID" ControlToValidate="txtuserId">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
                            ErrorMessage="Invalid password" ControlToValidate="txtPassword">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <asp:Button ID ="btnLogin" runat="server" Text="Login" OnClick = "btnLogin_Click" ></asp:Button> 
        </div>
    

</asp:Content>
