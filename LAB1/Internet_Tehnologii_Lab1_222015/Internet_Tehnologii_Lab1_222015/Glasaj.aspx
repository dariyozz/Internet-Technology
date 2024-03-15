<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Internet_Tehnologii_Lab1_222015.Glasaj" EnableViewState="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="display: flex; justify-content: center; align-items: center">
        <form id="form1" runat="server" style="font-size: 1.5em; margin-top: 100px;">
            <div>
                <div style="margin-top: 20px;">
                    <asp:Image ID="imgLogo" runat="server" ImageUrl="~/Images/finki_logo.jpg" AlternateText="ФИНКИ лого" />
                </div>

                <div style="margin-top: 20px;">
                    <asp:Label ID="LabelProfesor" runat="server" Text=""></asp:Label >
                </div>

                <div style="margin-top: 20px;">
                    <asp:Label ID="lblProfesor" runat="server" Text="Професор:" Style="display: inline-block; margin-right: 30px" AutoPostBack="True"></asp:Label>

                    <div style="display: inline-block; margin-right: 20px;">
                        <asp:ListBox ID="ddlPredmeti" runat="server" OnSelectedIndexChanged="ddlPredmeti_SelectedIndexChanged" AutoPostBack="True">
                            
                        </asp:ListBox>
                    </div>
                    <div style="display: inline-block; margin-right: 20px">
                        <asp:ListBox ID="ddlKrediti" runat="server" AutoPostBack="True" >
                            
                        </asp:ListBox>
                    </div>
                </div>
                <div style="margin-top: 20px;">
                    <asp:Button ID="btnVote" runat="server" Text="Гласај" OnClick="btnVote_Click" Style="font-weight: bold; font-size: 25px; padding: 8px 35px;" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
