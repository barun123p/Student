<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayStudent.aspx.cs" Inherits="StudentDetails.DisplayStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                  <td>
                      Student ID
                  </td>
                    <td>

                        <asp:DropDownList ID="ddlStudentID" runat="server" Height="21px" Width="167px" OnSelectedIndexChanged="ddlStudentID_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                       <%-- <asp:TextBox ID="txtStudentId" runat="server"></asp:TextBox>--%>

                    </td>
                    </tr>

                 <tr>
                  <td>
                      FirstName
                  </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>

                    </td>
                    </tr>

                 <tr>
                  <td>
                      LLastName
                  </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>

                    </td>
                    </tr>
                <tr>
                <td>
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" Width="147px" />
                </td>
                </tr>
                <tr>
                <td>
                    <asp:Button ID="btndisplay" runat="server" Text="Display" OnClick="btndisplay_Click" Width="147px" />
                </td>
                </tr>

                <tr>
                <td>
                   <asp:Button ID="btnupdate" runat="server" Text="update" Width="145px" OnClick="btnupdate_Click" />
                    
                </td>
                </tr>

                <tr>
                <td>

                    <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="149px" OnClick="btnDelete_Click1" />
                   
                   
                </td>
                </tr>
                </table>
            
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                
        </div>
    </form>
</body>
</html>
