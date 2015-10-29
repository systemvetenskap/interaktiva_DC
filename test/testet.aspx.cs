using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace test
{
    public partial class testet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            getXML();
        }

        private void getXML()
        {
            string xmlfil = Server.MapPath("test.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);
            

            XmlNodeList test = doc.SelectNodes("/test/testquestion");
            //Label1.Text = test.InnerText;

            Label1.Text = "frågor: ";
    

            foreach (XmlNode nod in test)
            {

                Label1.Text += nod["question"].InnerText + " " ;
            }


            /*string xmlfil = Server.MapPath("aktielista.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);

            XmlNode foretag = doc.SelectSingleNode("/aktiebolag/foretag/namn");
            Label1.Text = foretag.InnerText;

            Label2.Text = "Aktiebolag: ";
            XmlNodeList foretagsnamnlista = doc.SelectNodes("/aktiebolag/foretag");
            foreach (XmlNode nod in foretagsnamnlista)
            {
                Label2.Text += nod["namn"].InnerText + " ";
            }*/
        }

    }
}