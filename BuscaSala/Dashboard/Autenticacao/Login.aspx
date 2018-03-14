<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Dashboard.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>Login:</div>
            <asp:TextBox ID="txbUsuario" runat="server"></asp:TextBox>
        </div>
        <div>Senha:</div>
        <asp:TextBox ID="txbSenha" runat="server" TextMode="Password"></asp:TextBox>
        <div><asp:Button ID="txbLogin" Text="Login" runat="server" OnClick="txbLogin_Click" /></div>
    </form>
</body>
</html>