<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pastebin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Querystring i url: 
            <asp:Label ID="LabelQS" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxMsg" runat="server" Rows="10" TextMode="MultiLine" Width="704px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonCreatePaste" runat="server" Text="Create Paste" />
        </div>
    </form>
</body>
</html>
