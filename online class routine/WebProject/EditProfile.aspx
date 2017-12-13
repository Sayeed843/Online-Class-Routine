<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="WebProject.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Web_Body" runat="server">
     <div class="Pro_img_left">

         <asp:Image ID="profile_image" runat="server" Height="142px" Width="217px"/>
         <br/> <br/>
         <asp:Label ID="upload_message_label" runat="server" ForeColor="Red"></asp:Label>
         <br/>
         <br/>

         <asp:FileUpload ID="profile_pic_file_upload" runat="server" Width="212px" />

    </div>

    <div class="Pro_left">
        <li><a href="~/Profile.aspx" runat="server">Cancel</a></li>
        <li><a href="#"> <asp:Button ID="Update_button" runat="server" Text="Update" BackColor="#DADADA" BorderStyle="None" Font-Names="Times New Roman" Font-Size="20px" Height="25px" Width="75px" OnClick="Update_button_Click" /></a></li>

        
        <br /> <br /> <br />
        <asp:Label ID="message_label" runat="server" Text=""></asp:Label>
    
    </div>

    <div class="Pro_table">
        <table style="width: 727px; height: 554px">
            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Name</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:Label ID="user_name_label" runat="server" Text="" Height="36px" Width="268"></asp:Label>
                </td>
                <td>

                    &nbsp;</td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Email</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:Label ID="email_label" runat="server" Text="" Height="36px" Width="268px"></asp:Label>
                </td>
                <td>

                    &nbsp;</td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Department</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="department_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="department_textbox" ErrorMessage="department can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Batch</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="batch_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator0" runat="server" ControlToValidate="batch_textbox" ErrorMessage="batch can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    ID</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="id_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="id_textbox" ErrorMessage="id can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

             <tr>
                <td style="text-align: center; width: 231px;">
                    
                    Date of birth</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="dob_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                 </td>
                 <td>

                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="dob_textbox" ErrorMessage="date of birth can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Gender</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="gender_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="gender_textbox" ErrorMessage="gender can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Marital Status</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="marital_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="marital_textbox" ErrorMessage="marital status can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Blood Group</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="blood_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="blood_textbox" ErrorMessage="blood group can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

           <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Place of birth</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="pob_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                </td>
               <td>

                   <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="pob_textbox" ErrorMessage="place of birth can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

           <tr>
                <td style="text-align: center; width: 231px;">
                    
                    Nationality</td>
                <td style="width: 303px">

                    &nbsp;&nbsp;<asp:TextBox ID="nationality_textbox" runat="server" Height="36px" Width="268px"></asp:TextBox>
                </td>
               <td>

                   <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="nationality_textbox" ErrorMessage="nationality can't null" ForeColor="#000066">*</asp:RequiredFieldValidator>

               </td>
            </tr>

            <tr>

                <td style="height: 47px; text-align: left; width: 231px;"></td>
                <td style="height: 47px"></td>
                <td style="height: 47px"></td>
            </tr>
        </table>
    </div>
</asp:Content>
