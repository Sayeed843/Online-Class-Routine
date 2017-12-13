<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebProject.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Web_Body" runat="server">

         <div class="Pro_img_left">

             <asp:Image ID="profile_image" runat="server" Height="142px" Width="217px"/>

    </div>

    <div class="Pro_left">
         
        <li><a href="~/EditProfile.aspx" runat="server">Edit</a></li>
        <br />
        <br />
             
        
    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:Label ID="tea_initial_label" runat="server" Text=""></asp:Label>
        
    </div>

    <div class="Pro_table">
        <table style="width: 586px; height: 554px">
            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Name</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="name_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Email</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="email_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Department</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="department_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    Batch
                </td>
                <td>
                    &nbsp;&nbsp;<asp:Label ID="batch_label" runat="server" Text=""></asp:Label>
                </td>

            </tr>
            
            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    ID</td>
                <td>

                    &nbsp;&nbsp; <asp:Label ID="id_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>

             <tr>
                <td style="text-align: center; width: 231px;">
                    
                    Date of birth</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="dob_label" runat="server" Font-Size="22px"></asp:Label>
                 </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Gender</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="gender_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Marital Status</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="marital_status_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>

            <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Blood Group</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="blood_group_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>

           <tr>
                <td style="width: 231px; text-align: center;">
                    
                    Place of birth</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="pob_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>

           <tr>
                <td style="text-align: center; width: 231px;">
                    
                    Nationality</td>
                <td>

                    &nbsp;&nbsp;<asp:Label ID="natiobality_label" runat="server" Font-Size="22px"></asp:Label>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
