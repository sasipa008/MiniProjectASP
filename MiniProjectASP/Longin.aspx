<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Longin.aspx.cs" Inherits="MiniProjectASP.Longin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 189px">
        <br />
        <asp:Label ID="Label1" runat="server" Text="Singin"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="User Name: "></asp:Label> 
        <asp:TextBox ID="Username" runat="server"></asp:TextBox><br />
        <br />       
        <asp:Label ID="Label3" runat="server" Text="Password:   "></asp:Label>
        <asp:TextBox ID="Password" runat="server" TextMode="Password" OnTextChanged="Password_TextChanged"></asp:TextBox>
        <br />
    
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    
    </div>
    </form>
</body>
</html>
