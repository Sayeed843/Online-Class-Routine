<%@ Page Title="" Language="C#" MasterPageFile="~/NormalMasterPage.Master" AutoEventWireup="true" CodeBehind="TeacherRegistrationFrom.aspx.cs" Inherits="WebProject.TeacherRegistrationFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Web_Body" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
     <table class="Table">
        <tr align="Center">
            <td colspan="4" >
                <h1 style="height: 57px">Create your Account</h1>
            </td>
        </tr>

        <!--Name-->
        <tr>
            <td style="width: 201px; text-align: right; height: 58px;">

                Name:</td>
            <td style="height: 58px; width: 323px;">

                <asp:TextBox ID="name_text_box" runat="server" Width="309px" Height="31px" AutoPostBack="True" OnTextChanged="name_text_box_TextChanged"></asp:TextBox>

            </td>
            <td>

                <asp:Label ID="user_message_label" runat="server" Font-Size="17px"></asp:Label>
                <br />

                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name_text_box" ErrorMessage="Name is required." ForeColor="Red" Font-Size="17px"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <!--Email-->
        <tr>
            <td style="width: 201px; height: 58px; text-align: right;">

                Email:</td>
            <td style="height: 58px; width: 323px;">

                <asp:TextBox ID="email_text_box"  runat="server" Width="309px" Height="31px" AutoPostBack="True" OnTextChanged="email_text_box_TextChanged"></asp:TextBox>

            </td>

            <td>

                <asp:Label ID="email_message_label" runat="server" Font-Size="17px"></asp:Label>
                <br />

                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email_text_box" ErrorMessage="Email is required." ForeColor="Red" Font-Size="17px"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="You must enter the valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="email_text_box" ForeColor="Red" Font-Size="17px"></asp:RegularExpressionValidator>

            </td>
        </tr>

        <!--Password-->
        <tr>
            <td style="width: 201px; text-align: right; height: 57px;">

                Password:</td>
            <td style="height: 57px; width: 323px;">

                <asp:TextBox ID="password_text_box" runat="server" Width="309px" Height="31px" TextMode="Password"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;
                
            </td>
            <td>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password_text_box" ErrorMessage="Password is required." ForeColor="Red" Font-Size="17px"></asp:RequiredFieldValidator>
                
                <br />
                
            </td>
        </tr>
            <tr>
            <td style="width: 201px; text-align: right; height: 57px;">

                Confirm Password:</td>
            <td style="height: 57px; width: 323px;">

                <asp:TextBox ID="conf_pass_text" runat="server" Width="309px" Height="31px" TextMode="Password"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;

            </td>

                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="conf_pass_text" ErrorMessage="Confirm Password is required." ForeColor="Red" Font-Size="17px"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password_text_box" ControlToValidate="conf_pass_text" ErrorMessage="Both Password must be same" ForeColor="Red" Font-Size="17px"></asp:CompareValidator>

            </td>
        </tr>
            <!--Department-->
            <tr>
            <td style="width: 201px; text-align: right; height: 57px;">

                Department:</td>
            <td style="height: 57px; width: 323px;">

                <asp:TextBox ID="department_text_box" runat="server" Width="309px" Height="31px"></asp:TextBox>

            </td>
                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="department_text_box" ErrorMessage="Department is required." ForeColor="Red" Font-Size="17px"></asp:RequiredFieldValidator>

            </td>

        </tr>

            
            <!--ID-->
        <tr>
            <td style="width: 201px; text-align: right; height: 57px;">

                ID:</td>
            <td style="height: 57px; width: 323px;">

                <asp:TextBox ID="id_text_box" runat="server" Width="309px" Height="31px"></asp:TextBox>

            </td>
            <td>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="id_text_box" ErrorMessage="ID is required." ForeColor="Red" Font-Size="17px"></asp:RequiredFieldValidator>

            </td>
        </tr>
            

            
        <!--Gender-->
        <tr>
            <td style="width: 201px; text-align: right; height: 57px;">

                Gender:</td>
            <td style="height: 57px; width: 323px;">

                <asp:DropDownList ID="gender_drop_down" runat="server" Height="39px" Width="315px" BackColor="#99CCFF">
                    <asp:ListItem>I am...</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="gender_drop_down" ErrorMessage="Select your gender" ForeColor="Red" Font-Size="17px"></asp:RequiredFieldValidator>

            </td>
        </tr>

        
            <!--Label-->
        <tr>
            <td></td>
            <td style="height: 57px; width: 323px;">
                <asp:Label ID="message_label" runat="server" Text=""></asp:Label>
                

            </td>
            <td>

            </td>
        </tr>

            <!--Button-->
        <tr>
            <td style="width: 201px; height: 62px;">

            </td>
            <td style="height: 62px; width: 323px;">

                
                <input id="Reset1" type="reset" value="reset" style="width: 64px; height: 32px; color:white;background-color:#3333FF; border-style:solid; font-weight:bold; font-size:15px; "/>&nbsp;&nbsp;&nbsp;

                
<asp:Button ID="save_button" runat="server" BackColor="#3333FF" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial Black" Font-Overline="False" ForeColor="White" Height="32px" Text="Save" Width="80px" OnClick="save_button_Click"  />
            &nbsp;&nbsp;&nbsp;
            </td>
            <td>

            </td>
        </tr>

    </table>
        </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
