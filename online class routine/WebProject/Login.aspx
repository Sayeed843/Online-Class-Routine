<%@ Page Title="" Language="C#" MasterPageFile="~/NormalMasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebProject.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Web_Body" runat="server">
    
    <div>
        <h2>Login!!!</h2>
        <asp:TextBox ID="l_email_text" placeholder="email" runat="server" Height="28px" Width="222px"></asp:TextBox>
        <br/> <br/>
        <asp:TextBox ID="l_pass_text" placeholder="password" runat="server" Height="28px" Width="222px" TextMode="Password"></asp:TextBox>
        <br/> <br/>
        <asp:Label ID="message_label" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Button ID="login_button" runat="server" Text="Login" Height="24px" style="margin-top: 0px" Width="78px" OnClick="login_button_click" />
<br/>
    
        <p>Don't have an account? <strong><a href="~/RegistrationFrom.aspx" runat="server"> Sing up </a></strong></p>

    </div>
</asp:Content>

