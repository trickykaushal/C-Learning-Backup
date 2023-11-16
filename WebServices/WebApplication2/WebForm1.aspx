<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #btnadd1 {
            width: 224px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <table>
            <tr>
                <td>First Number</td>
                <td>
                    <asp:TextBox ID="Val1" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Second Number</td>
                <td>
                    <asp:TextBox ID="Val2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="result" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn1" runat="server" value="Add" OnClick="btn1_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
