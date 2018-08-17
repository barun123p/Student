<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="StudentDetails.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 268px;
            width: 1393px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome Admin
            </h1>
            <h3>Enter Username and Password
            </h3>

            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="UserName"></asp:Label>
                    </td>
                    <td>

                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Password" Textmode="Password"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>

            
            <asp:Label ID="errorMessage" runat="server" style="color:red" Text=" "></asp:Label>
               
            
        </div>
    </form>
</body>
</html>
