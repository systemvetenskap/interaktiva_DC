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
           
             <div class="container">
                       
                       <div class="header">
                       <h1> Kompetensportalen</h1>
                       </div>
                
                <div class="nav">
                   <ul class="clearfix">
                        <li><a href="index.html">Hem</a></li>
                        <li><a href="om.html">Om JE-Bank</a></li>
                        <li><a href="admin.html">Admin</a></li>
	                <li><a href="kompetensportalen.html">Kompetensportalen</a></li>
                         <li><a href="kontaktuppgifter.html">Kontaktuppgifter</a></li>
                        <li><a href="personal.html">Personal</a></li>
                   </ul>
                </div>
          <div class="maincontent">
          
           <div class="content">
             <article class="topcontent">
               
               <header>
                  <h3 id="001"><a href="#" title="Årlig kunskaps uppdatering – ÅKU"><img src="goldenstatue.jpg" alt="Guldig staty" width="100%" height="auto">
                  Årlig kunskaps uppdatering – ÅKU </a></h3>
               </header>
               
               <footer>
                  <p class="post-info">Detta är skrivet av Jill Lindqvist 2015-10-14</p>
               </footer> 

               <content>
                 <p>Då var det dags att förgylla era kontorsväggar med ännu ett diplom. <br />Vi önskar alla lycka till med
                 <a href="read.html" title="Kunskapsprovet">kunskapsprovet!</a></p>
               </content>                  
             </article>

             <article class="bottom-content">
               
               <header>
                  <h3><a href="#" title="Tävling">Tävling</a></h3>
               </header>
               
               <footer>
                  <p class="post-info">Detta är skrivet av Jill Lindqvist 2015-10-14</p>
               </footer> 

               <content> 
                 <p>Tillbaka till kontoret och jaga era kollegor. Just nu kör vi en tävling<br />
                 med en spa-weekend som högsta vinst! Se <a href="read.html" title="Tävlingsregler">tävlingsregler</a> här.
                 </p>

                  

               </content>                  
             </article>  


           </div> 
         </div>

              <div class="footer">
                 
                  
                  <div><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
                 <p title="© 2015 JE-Bank AB (publ)">© 2015 JE-Bank AB (publ) <br />Jill Lindqvist jili1400@student.miun.se</p>
              </div>

           </div>     
    </body>
</html>