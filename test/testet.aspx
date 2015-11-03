<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testet.aspx.cs" Inherits="test.testet" %>

<!DOCTYPE html>

   <html lang="sv">
     <head>
            <meta charset="utf-8" />
            <link rel="stylesheet" type="text/css" href="indextest.css">
            <link rel="stylesheet" type="text/css" href="responsiv.css" media="screen and (max-width: 900px)">
            


            <title>JE-bank-index</title>
     </head>
     <body>

         
          
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
              <div class="test">
              
                  <div class="question">

                           <p>Vilken ekonomi är bäst?</p>
                      <asp:CheckBoxList ID="QuestionList1" runat="server" CssClass="question">
                         
                          <asp:ListItem Value="answer1">Dollar</asp:ListItem>
                          <asp:ListItem Value="answer2">Skr</asp:ListItem>

                      </asp:CheckBoxList>
                      
                          <p>Vilken ekonomi är bäst?</p>
                      <asp:CheckBoxList ID="QuestionList2" runat="server" CssClass="question">

                          <asp:ListItem Value="answer1">Svar 1</asp:ListItem>
                          <asp:ListItem Value="answer2">Svar 2</asp:ListItem>


                      </asp:CheckBoxList>


                      
                      

                  


                  </div>
                      
                      
              
              </div>
               <asp:Button ID="BtnLamnain" runat="server" Text="Lämna in" OnClick="BtnLamnain_Click"/>
                <br />

               

                </form>
                </div>
                 

              <div class="footer">
                 
                  
                  
                 <p title="© 2015 JE-Bank AB (publ)">© 2015 JE-Bank AB (publ) <br />Jill Lindqvist och Camilla Hoff</p>
              </div>

              </div>  
    </body>
</html>


<%--                 <script>
                     function myFunction(CreateAndLoadInToXML) {
                 var x = document.getElementById("myanswer1").value;
                 document.getElementById("demo").innerHTML = x;
                
                window.alert("Du har nu lagt till demo");--%>
            <%--     
                 }
                 </script>--%>