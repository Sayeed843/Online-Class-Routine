<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthorityCrudClassShedule.aspx.cs" Inherits="WebProject.AuthorityCrudClassShedule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="crud_class_shedule" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="crud_class_shedule_PageIndexChanging" OnRowCancelingEdit="crud_class_shedule_RowCancelingEdit" OnRowDeleting="crud_class_shedule_RowDeleting" OnRowEditing="crud_class_shedule_RowEditing" OnRowUpdating="crud_class_shedule_RowUpdating" style="margin-right: 0px">
            <Columns>
                <asp:TemplateField HeaderText="No">

                    <ItemTemplate>
                        <asp:Label ID="label_no" runat="server" Text='<%# Bind("Shedule_ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Day">
                    <EditItemTemplate>
                        <asp:TextBox ID="day_name_text" runat="server" Text='<%# Bind("Day_Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Day_Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Room">
                    <EditItemTemplate>
                        <asp:TextBox ID="room_number_text" runat="server" Text='<%# Bind("Room_Number") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Room_Number") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Course">
                    <EditItemTemplate>
                        <asp:TextBox ID="course_name_text" runat="server" Text='<%# Bind("Course_Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Course_Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Teacher">
                    <EditItemTemplate>
                        <asp:TextBox ID="teacher_initial_text" runat="server" Text='<%# Bind("Teacher_Initial") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Teacher_Initial") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
