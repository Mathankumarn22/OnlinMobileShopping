<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="OnlineWebApplication.WebApplication.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Sign Up
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content_Body" runat="server">
  
            
       
        <div align="center">
            <table class="auto-style">
                
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server"
                            ErrorMessage="Name required" ControlToValidate="txtName">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email Id</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Type="Email"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server"
                            ErrorMessage="Incorrect Email Id" ControlToValidate="txtEmail"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td>Number</td>
                    <td>
                        <asp:TextBox ID="txtNumber" runat="server" Type="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                

            </table>
            <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" OnClick="SignUp_Click" Style="height: 26px"></asp:Button>
        </div>
   
</asp:Content>
