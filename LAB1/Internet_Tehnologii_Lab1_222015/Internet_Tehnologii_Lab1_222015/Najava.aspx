<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="Internet_Tehnologii_Lab1_222015.Najava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Najava</title>
</head>
<body>
    <div style="display:flex;justify-content:center;align-items:center;width:100%;margin-top:200px">
        <form id="form1" runat="server" style="font-size: 1.6em; width:450px;">
            <div>
                <div style="margin-top: 20px; display: flex;flex-wrap:wrap; justify-content: space-between;align-items: center;">
                    <asp:Label ID="lblUsername" runat="server" Text="Корисничко име:"></asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" required></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server"
                        ControlToValidate="txtUsername"
                        ErrorMessage="Внесете корисничко име." Display="Dynamic" ForeColor="Red" style="display: block;">
                    </asp:RequiredFieldValidator>
                </div>
                <div style="margin-top: 20px; display: flex;flex-wrap:wrap; justify-content: space-between;align-items: center;">
                    <asp:Label ID="lblPassword" runat="server" Text="Лозинка:"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" required></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
                        ControlToValidate="txtPassword"
                        ErrorMessage="Внесете лозинка." Display="Dynamic"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
                <div style="margin-top: 20px; display: flex; flex-wrap:wrap; justify-content: space-between;align-items: center;">
                    <asp:Label ID="lblEmail" runat="server" Text="Е-маил адреса:"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" required></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtEmail"
                        ErrorMessage="Внесете е-маил." Display="Dynamic"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server"
                        ControlToValidate="txtEmail"
                        ErrorMessage="Внесете валидна е-маил адреса."
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" ForeColor="Red"
                        style="display: block;">
                    </asp:RegularExpressionValidator>
                </div>
                <div style="margin-top: 20px; padding: 20px;margin-inline: auto; width: 50%;">
                    <asp:Button ID="btnSubmit" runat="server" Text="Најавете се" OnClick="btnSubmit_Click" Style="padding: 10px 20px; font-size: 30px; font-weight: bold;" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
