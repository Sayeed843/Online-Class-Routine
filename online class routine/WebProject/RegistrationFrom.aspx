<%@ Page Title="" Language="C#" MasterPageFile="~/NormalMasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrationFrom.aspx.cs" Inherits="WebProject.RegistrationFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Web_Body" runat="server">
 
    <table class="Reg_Table" style="height: 250px">
        <tr align="Center">
            <td style="height: 71px"><h2>Create your Account by</h2></td>
        </tr>

        <!--Teacher-->
        <tr>
            <td align="Center" class="reg_from_table" style="height: 97px" ><a  href="~/TeacherRegistrationFrom.aspx" runat="server">Teacher</a></td>
        </tr>

        <!--Student-->
        <tr>
            <td align="Center" class="reg_from_table"><a href="~/StudentRegistrationFrom.aspx" runat="server">Student</a></td>
        </tr>
    </table>

</asp:Content>
