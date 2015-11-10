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

         
           <asp:Label ID = "Label1" runat="server" Text="Label"></asp:Label>
             <div class="container">
                       
                       <div class="header">
                       <h1> Kompetensportalen</h1>
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
                  <form id="form1" runat="server">
               <asp:Repeater ID="Repeater1" runat="server">
          
              <headerTemplate>
                 
              </headerTemplate>
                
		      <itemTemplate>
              
             <asp:CheckBoxList ID="ID1" runat="server" CssClass="fraga">
              <asp:ListItem text="text" Value="nr">"test.Nr"</asp:ListItem>
              <asp:ListItem Value="group">"test.Question"</asp:ListItem>
              <asp:ListItem text="text" Value="amountofanswers">"test.Amountofanswers"</asp:ListItem>
              <asp:ListItem Value="answer1">"test.Answer1"</asp:ListItem>
             </asp:CheckBoxList>             
         
             <asp:CheckBoxList ID="ID2" runat="server">
              <asp:ListItem text="text" Value="nr">"test.Nr"</asp:ListItem>
              <asp:ListItem Value="group">"test.Question"</asp:ListItem>
              <asp:ListItem text="text" Value="amountofanswers">"test.Amountofanswers"</asp:ListItem>
              <asp:ListItem Value="answer1">"test.Answer1"</asp:ListItem>
             </asp:CheckBoxList>


		     </itemTemplate>
                
             
                <footerTemplate>
               
             </footerTemplate>
         </asp:Repeater>  
               
            </form>
           </div> 


         </div>

              <div class="footer">
                 
                  
                  
                 <p title="© 2015 JE-Bank AB (publ)">© 2015 JE-Bank AB (publ) <br />Jill Lindqvist och Camilla Hoff</p>
              </div>

                
    </body>
</html>