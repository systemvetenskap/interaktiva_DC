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

           <article class="topcontent">
               <!-- sektion 1 -->
            <%-- <asp:CheckBoxList ID="cbltestEkonomi" runat="server"></asp:CheckBoxList>--%>
               
               
                <asp:Repeater ID="Repeater1" runat="server">
          
              <headerTemplate>
                 
              </headerTemplate>
		      <itemTemplate>
               
              
		        
                <h2><%# Eval("question")%></h2>
		        <%--<p><%# Eval("answer1")%></p>
                <p><%# Eval("answer2")%></p>--%>
                           
                      <%--<asp:CheckBoxList ID="cbltestEkonomi" runat="server"></asp:CheckBoxList>--%>
                 <%--<asp:CheckBoxList ID="cbltestEkonomi" runat="server"></asp:CheckBoxList>--%>
               <%--  <form>--%>
     <%--<asp:ListItem Value="answer1">"answer1"</asp:ListItem>
                          <asp:ListItem Value="answer2">"answer2"</asp:ListItem><%--<%# Eval("answer2")%>--%>
                 
                  <%-- <form id="form1" runat="server" >--%>

<%--                       <asp:CheckBox ID="CheckBox1" runat="server" />
                       <asp:CheckBox ID="CheckBox2" runat="server" />--%>
                      
                       
                   <%--  <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>--%>
                      <p> <input type="radio" name="<%# Eval("question")%>" value="answer1"><%# Eval("answer1")%></p> 
                      <p> <input type="radio" name="<%# Eval("question")%>" value="answer2"><%# Eval("answer2")%></p>
                  
               <%-- </form>--%>
                  
<%-- här behöver jag skriva lämna in svar på radio och <%#Eval("rightanswer")%> till metod rätta. om radio.text???? == <%#Eval("rightanswer")%>    --%>
                  

                <%--//<p> <%#Container.ItemIndex %></p>
	            //</div>
                  --%>
		     </itemTemplate>
             <footerTemplate>
               
             </footerTemplate>
         </asp:Repeater>  
               <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
              <asp:Button ID="BtnLamnain" runat="server" Text="Lämna in" />   
               <asp:Button ID="Button1" runat="server" Text="Button" />
           
           </article>
              </form>

              <div class="footer">    
              <p title="© 2015 JE-Bank AB (publ)">© 2015 JE-Bank AB (publ) <br />Jill Lindqvist och Camilla Hoff</p>
              </div>

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
