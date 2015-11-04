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
<<<<<<< HEAD
            <form id="form1" runat="server">
              <div class="test">
              
                  <div class="question">

                           <p>Vilken ekonomi är bäst?</p>
                      <asp:CheckBoxList ID="QuestionList1" runat="server" CssClass="question" Value="Fråga1">
                         
                          <asp:ListItem Value="answer1">Dollar</asp:ListItem>
                          <asp:ListItem Value="answer2">Skr</asp:ListItem>

                      </asp:CheckBoxList>
                      
                          <p>Vilken ekonomi är bäst?</p>
                      <asp:CheckBoxList ID="QuestionList2" runat="server" CssClass="question" Value="Fråga 2">

                          <asp:ListItem Value="answer1">Svar 1</asp:ListItem>
                          <asp:ListItem Value="answer2">Svar 2</asp:ListItem>


                      </asp:CheckBoxList>


                      
                      

=======
          
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
                       <%--<asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>--%>
                      <p> <input type="radio" name="group1" value="answer1"><%# Eval("answer1")%></p> 
                      <p> <input type="radio" name="group1" value="answer2"><%# Eval("answer2")%></p>
                  
                </form>
                  
<%-- här behöver jag skriva lämna in svar på radio och <%#Eval("rightanswer")%> till metod rätta. om radio.text???? == <%#Eval("rightanswer")%>    --%>
                  

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
                    <%--   <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>--%>
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
                       
                     <%-- <p> <input type="radio" name="group1" value="answer1"><%# Eval("answer1")%></p> 
                      <p> <input type="radio" name="group1" value="answer2"><%# Eval("answer2")%></p>--%>
                      <if answer2.checked></if>
                      <asp:RadioButton ID="RadioButton1" runat="server" />
                  </form>
>>>>>>> refs/remotes/origin/camillasfirstbranch
                  


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
