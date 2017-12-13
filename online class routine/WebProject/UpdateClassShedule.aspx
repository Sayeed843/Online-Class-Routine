<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateClassShedule.aspx.cs" Inherits="WebProject.UpdateClassShedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Web_Body" runat="server">

    <table style="width: 982px; height: 799px">
        <tr>
            <th colspan="1" align="center" style="height: 107px; width: 821px;">
                <h1>Class Shedule</h1>
                <td style="height: 107px"> <asp:Button ID="back_button" runat="server" Text="Back" Font-Bold="True" Height="33px"  Width="75px" OnClick="back_button_Click" />

                </td>
            </th>
        </tr>
        <tr>

            <td style="width: 821px">

                <asp:GridView ID="edit_class_shedule_gridview" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="143px" style="margin-top: 0px" Width="820px" AutoGenerateColumns="False" OnPageIndexChanging="edit_class_shedule_gridview_PageIndexChanging" OnRowCancelingEdit="edit_class_shedule_gridview_RowCancelingEdit"  OnRowEditing="edit_class_shedule_gridview_RowEditing" OnRowUpdating="edit_class_shedule_gridview_RowUpdating">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Day">
                            
                            <ItemTemplate>
                                <asp:Label ID="day_label" runat="server" Text='<%# Bind("day") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Time">
                            
                            <ItemTemplate>
                                <asp:Label ID="time_label" runat="server" Text='<%# Bind("time") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Class">

                            <ItemTemplate>
                                <asp:Label ID="class_label" runat="server" Text='<%# Bind("class") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Course">
                            <EditItemTemplate>
                                <asp:TextBox ID="course_textbox" runat="server" Text='<%# Bind("course") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="course_label" runat="server" Text='<%# Bind("course") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Teacher">
                            <EditItemTemplate>
                                <asp:TextBox ID="teacher_textbox" runat="server" Text='<%# Bind("teacher") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="teacher_label" runat="server" Text='<%# Bind("teacher") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
                        
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>

            </td>
            <td>

                &nbsp;</td>


        </tr>
    </table>

</asp:Content>
