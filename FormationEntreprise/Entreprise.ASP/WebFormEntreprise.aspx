<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEntreprise.aspx.cs" Inherits="Entreprise.ASP.WebFormEntreprise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TBoxMatricule" runat="server" OnTextChanged="TBoxMatricule_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnEnvoyer" runat="server" OnClick="BtnEnvoyer_Click" Text="Envoyer" />
            <br />
            <br />
            <asp:Label ID="LblMatricule" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
