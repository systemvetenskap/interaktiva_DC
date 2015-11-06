<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testet.aspx.cs" Inherits="test.testet" %>

<!DOCTYPE html>

<html lang="sv">
<head>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="index.css">
    <link rel="stylesheet" type="text/css" href="responsiv.css" media="screen and (max-width: 900px)">



    <title>JE-bank-index</title>
</head>
<body>


    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <div class="container">

        <div class="header">
            <h1>Kompetensportalen</h1>
        </div>

        <div class="nav">
            <ul class="clearfix">
                <li><a href="#">Hem</a></li>
                <li><a href="#">Om JE-Bank</a></li>
                <li><a href="#">Admin</a></li>
                <li><a href="#">Kompetensportalen</a></li>
                <li><a href="#">Kontaktuppgifter</a></li>
                <li><a href="#">Personal</a></li>
            </ul>
        </div>

        <div class="maincontent">

            <asp:Panel ID="Panel1" runat="server">


                <asp:Repeater ID="Repeater1" runat="server">

                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>


                        <form>
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
                           
                            
                             <p>
                                <input type="radio" name="group1" value="answer1"><%# Eval("answer1")%></p>
                            <p>
                                <input type="radio" name="group1" value="answer2"><%# Eval("answer2")%></p>

                        </form>

                    </ItemTemplate>
                    <FooterTemplate>
                    </FooterTemplate>
                </asp:Repeater>
            </asp:Panel>
        </div>

        <div class="footer">
            <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>

        </div>
</body>
</html>
