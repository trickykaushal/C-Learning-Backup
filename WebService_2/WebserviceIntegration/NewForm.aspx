<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewForm.aspx.cs" Inherits="WebserviceIntegration.NewForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Value1</td>
                <td>
                    <input id="Text1" type="text" />
                </td>
            </tr>
            <tr>
                <td>Value2</td>
                <td>
                    <input id="Text2" type="text" />
                </td>
            </tr>
            <tr>
                <td>Sum
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Btn1" type="submit" runat="server" value="Add" />
                </td>
            </tr>

        </table>

    </form>
</body>
</html>
