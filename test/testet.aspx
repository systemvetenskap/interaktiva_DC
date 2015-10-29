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
          
           <article class="topcontent">
               <!-- sektion 1 -->
                <asp:Repeater ID="Repeater1" runat="server">
          
              <headerTemplate>
                 
              </headerTemplate>
		      <itemTemplate>
                 
                <%--<div class = <%# (Container.ItemIndex+1)%2==0  ? "sekton sektion-mitten":"sektion" %> "sektion sektion-1a mobil" >
	           <img title ="en motorbåt i Smögens hamn" src="bilder/bat.jpg" alt="en motorbåt i Smögens hamn" ><!--width="100%" height="auto"-->--%>
		        
                <h2><%# Eval("question")%></h2>
		        <%--<p><%# Eval("answer1")%></p>
                <p><%# Eval("answer2")%></p>--%>

                  <form>
                       <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
                      <p> <input type="radio" name="group1" value="answer1"><%# Eval("answer1")%></p> 
                      <p> <input type="radio" name="group1" value="answer2"><%# Eval("answer2")%></p>
                  
                </form>
                  
 
                <%--//<p> <%#Container.ItemIndex %></p>
	            //</div>
                  --%>
		     </itemTemplate>
             <footerTemplate>
               
             </footerTemplate>
         </asp:Repeater>
               
             </article>

              <article class="middlecontent">
               <!-- sektion 1 -->
                <asp:Repeater ID="Repeater2" runat="server">
          
              <headerTemplate>
                 
              </headerTemplate>
		      <itemTemplate>
                 
                <%--<div class = <%# (Container.ItemIndex+1)%2==0  ? "sekton sektion-mitten":"sektion" %> "sektion sektion-1a mobil" >
	           <img title ="en motorbåt i Smögens hamn" src="bilder/bat.jpg" alt="en motorbåt i Smögens hamn" ><!--width="100%" height="auto"-->--%>
		        
                <h2><%# Eval("question")%></h2>
		        <%--<p><%# Eval("answer1")%></p>
                <p><%# Eval("answer2")%></p>--%>

                  <form>
                       <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
                      <p> <input type="radio" name="group1" value="answer1"><%# Eval("answer1")%></p> 
                      <p> <input type="radio" name="group1" value="answer2"><%# Eval("answer2")%></p>
                  
                </form>
                  
 
                <%--//<p> <%#Container.ItemIndex %></p>
	            //</div>
                  --%>
		     </itemTemplate>
             <footerTemplate>
               
             </footerTemplate>
         </asp:Repeater>
               
             </article>

              <article class="bottomcontent">
               <!-- sektion 1 -->
                <asp:Repeater ID="Repeater3" runat="server">
          
              <headerTemplate>
                 
              </headerTemplate>
		      <itemTemplate>
                 
                <%--<div class = <%# (Container.ItemIndex+1)%2==0  ? "sekton sektion-mitten":"sektion" %> "sektion sektion-1a mobil" >
	           <img title ="en motorbåt i Smögens hamn" src="bilder/bat.jpg" alt="en motorbåt i Smögens hamn" ><!--width="100%" height="auto"-->--%>
		        
                <h2><%# Eval("question")%></h2>
		        <%--<p><%# Eval("answer1")%></p>
                <p><%# Eval("answer2")%></p>--%>

                  <form>
                       
                      <p> <input type="radio" name="group1" value="answer1"><%# Eval("answer1")%></p> 
                      <p> <input type="radio" name="group1" value="answer2"><%# Eval("answer2")%></p>
                     
                </form>
                  
 
                <%--//<p> <%#Container.ItemIndex %></p>
	            //</div>
                  --%>
		     </itemTemplate>
             <footerTemplate>
               
             </footerTemplate>
         </asp:Repeater>
               
             </article>
             <article>
                 <form>  
                     
                   <button onclick="document.write(5 + 6)">Lämna in</button>

                 </form>
               

             </article> 

           </div> 
         </div>

              <div class="footer">
                 
                  
                  
                 <p title="© 2015 JE-Bank AB (publ)">© 2015 JE-Bank AB (publ) <br />Jill Lindqvist och Camilla Hoff</p>
              </div>

                
    </body>
</html>