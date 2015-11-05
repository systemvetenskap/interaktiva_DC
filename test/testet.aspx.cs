using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace test
{
    public partial class testet : System.Web.UI.Page
    {
        List<TestClass> testclasslist = new List<TestClass>();
        List<TestClass> testlista = new List<TestClass>();
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    BindXmlToCheckBoxList();

            //}

            //LoadTestProdukterClass();
            LoadTestEkonomiClass();
            //LoadTestEtikClass();
            //CreateAndLoadInToXML();

        }

        //private void BindXmlToCheckBoxList()
        //{
        //    string filepath = Server.MapPath("~/testEkonomi.xml");
        //    using (DataSet ds = new DataSet())
        //    {
        //        ds.ReadXml(filepath);

        //        cbltestEkonomi.DataSource = ds;
        //        cbltestEkonomi.DataValueField = "id";
        //        cbltestEkonomi.DataTextField = "question";
        //        cbltestEkonomi.DataTextField = "answer1";
        //        cbltestEkonomi.DataTextField = "answer2";
        //        //cbltestEkonomi.DataSource = "id";
        //        cbltestEkonomi.DataBind();

        //    }

        //}

        private void LoadTestEkonomiClass()
        {
            string xmlfil = Server.MapPath("testEkonomi.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);

            XmlNodeList xmlLista = doc.SelectNodes("/testekonomi/testquestion");

            foreach (XmlNode nod in xmlLista)
            {
                TestClass testet = new TestClass();

                testet.id = nod.Attributes["id"].Value;
                testet.Group = nod["group"].InnerText;
                testet.Question = nod["question"].InnerText;
                testet.Answer1 = nod["answer1"].InnerText;
                testet.Answer2 = nod["answer2"].InnerText;
                testet.Rightanswer = nod["rightanswer"].InnerText;

                testlista.Add(testet);
                Response.Write("HEJ");
            }

            Repeater1.DataSource = testlista;
            Repeater1.DataBind();
        }

        public int hello(int y)
        {
            int x = y;
            int z = 3 * x;
            return z;
           
        }

        private void LoadTestEtikClass()
        {
            string xmlfil = Server.MapPath("testEtik.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);

            XmlNodeList xmlLista = doc.SelectNodes("/testetik/testquestion");


            foreach (XmlNode nod in xmlLista)
            {
                TestClass testet = new TestClass();

                testet.id = nod.Attributes["id"].Value;
                testet.Group = nod["group"].InnerText;
                testet.Question = nod["question"].InnerText;
                testet.Answer1 = nod["answer1"].InnerText;
                testet.Answer2 = nod["answer2"].InnerText;
                testet.Rightanswer = nod["rightanswer"].InnerText;


                testlista.Add(testet);
            }


            //Repeater2.DataSource = testlista;
            //Repeater2.DataBind();
        }

        //private void JillCreateXML()
        //{

        //    //Create the XmlDocument.
        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(("<Student type='regular' Section='B'><Name>Tommy ex </ Name ></ Student > ")); 
        //    //Save the document to a file.
        //    doc.Save("C:\\Users\\Jillsan\\Source\\Repos\\interaktiva_DC\test\\jilltest.xml");

        //    //You can also use Save method to display contents on console if you pass Console.Out as a
        //    //arameter.For example: 
        //    //doc.Save(Console.Out);


        //}

        private void CreateAndLoadInToXML()   //denna metod är under uppbyggnad inte alls klar!!!!!
        {
           // (källa : http://visualcsharptutorials.com/net-framework/writing-xml-file)

            //Create an xml document
        XmlDocument doc = new XmlDocument();

            //If there is no current file, then create a new one
            if (!System.IO.File.Exists("C:\\Users\\Jillsan\\Source\\Repos\\interaktiva_DC\test\\jilltest.xml")) // denna path mäste vara beroende av den person som gör provet behöver kopplas till person id i databasen. 
            {
                //Create neccessary nodes
                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                XmlComment comment = doc.CreateComment("This is an XML Generated File");
                XmlElement root = doc.CreateElement("answertest");
                XmlElement testquestion = doc.CreateElement("testquestion");
                XmlAttribute id = doc.CreateAttribute("id");
                XmlElement question = doc.CreateElement("question");
                XmlElement answer1 = doc.CreateElement("answer1");
                XmlElement answer2 = doc.CreateElement("answer2");
                //XmlElement rightanswer1 = doc.CreateElement("rightanswer");

                //Add the values for each nodes

               
                
                //answer1.InnerText = radioObject.answer1;
                //answer2.InnerText = radioObject.answer2; 

                //Construct the document
                doc.AppendChild(declaration);
                doc.AppendChild(comment);
                doc.AppendChild(root);
                root.AppendChild(testquestion);
                testquestion.Attributes.Append(id);
                testquestion.AppendChild(answer1);
                testquestion.AppendChild(answer2);

                doc.Save(@"C:\Users\Jillsan\Source\Repos\interaktiva_DC\test\jilltest.xml");
            }
            else //If there is already a file
            {
                //Load the XML File
                doc.Load(@"C:\Users\Jillsan\Source\Repos\interaktiva_DC\test\jilltest.xml");

        //(källa : http://visualcsharptutorials.com/net-framework/writing-xml-file)

        //Create an xml document
        //XmlDocument doc = new XmlDocument();

        //If there is no current file, then create a new one
        //    if (!System.IO.File.Exists(PATH)) // denna path mäste vara beroende av den person som gör provet behöver kopplas till person id i databasen. 
        //    {
        //        //Create neccessary nodes
        //        XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
        //        XmlComment comment = doc.CreateComment("This is an XML Generated File");
        //        XmlElement root = doc.CreateElement("answertest");
        //        XmlElement testquestion = doc.CreateElement("testquestion");
        //        XmlAttribute id = doc.CreateAttribute("id");
        //        XmlElement question = doc.CreateElement("question");
        //        XmlElement answer1 = doc.CreateElement("answer1");
        //        XmlElement answer2 = doc.CreateElement("answer2");
        //        XmlElement rightanswer1 = doc.CreateElement("rightanswer");
        //        XmlElement gender = doc.CreateElement("Gender");

        //        //Add the values for each nodes
        //        name.Value = textBoxName.Text;
        //        age.InnerText = textBoxAge.Text;
        //        gender.InnerText = textBoxGender.Text;

        //        //Construct the document
        //        doc.AppendChild(declaration);
        //        doc.AppendChild(comment);
        //        doc.AppendChild(root);
        //        root.AppendChild(person);
        //        person.Attributes.Append(name);
        //        person.AppendChild(age);
        //        person.AppendChild(gender);

        //        doc.Save(PATH);
        //    }
        //    else //If there is already a file
        //    {
        //        //Load the XML File
        //        doc.Load(PATH);


                //Get the root element
                XmlElement root = doc.DocumentElement;

                XmlElement testquestion = doc.CreateElement("testquestion");
                XmlAttribute id = doc.CreateAttribute("id");
                XmlElement question = doc.CreateElement("question");
                XmlElement answer1 = doc.CreateElement("answer1");
                XmlElement answer2 = doc.CreateElement("answer2");
                XmlElement rightanswer1 = doc.CreateElement("rightanswer");


                //Lägg till värdet till varje node

                //answer2.InnerText = 


                //Construct the testquestion element

                testquestion.AppendChild(answer1);
                testquestion.AppendChild(answer2);

                //Lägg till element till slutet av xml:en
                //root.AppendChild(testquestion) - behöver vi inte

                //Spara dokumen
                doc.Save(@"C:\Users\Jillsan\Source\Repos\interaktiva_DC\test\jilltest.xml");
            }
            //ge någon input om att xml-filen skapats

           //reset alla knappar
        }

        List<TestClass> answerlist = new List<TestClass>();

        private void PutTestIntoList(string id, string question, string answer1, string answer2, string answer3, string rightAnswer, string theAnswer, string group, List<TestClass> objektslista)
        {
            
            string nyid = id;
            string nyQuestion= question;
            string nyAnswer1 = answer1;
            string nyAnswer2= answer2 ;
            string nyAnswer3= answer3;
            string nyRightanswer = rightAnswer;
            string nyTheAnswer= theAnswer;
            string nyGroup = group;
            

            // out objektslista...

            //skapa ett objekt av detta och lägg i en lista.

       }


    private void TestCheck(List<TestClass> objektslista)//måste skicka in en objektslista med group,svar och rätt svar
        {
            int sumTotal = 0;  // kan itne ligga här för då nollas de varje gång denan körs... jo nu...
            int sumEtik = 0;
            int sumEkonomi = 0;
            int sumProdukter = 0;


            foreach (TestClass objekt in objektslista)
                {

                string answer = objekt.TheAnswer;
                string rightanswer = objekt.Rightanswer;
                string group = objekt.Group;                



            if (answer == rightanswer && group == "Etik och regelverk")
                {
                    sumEtik++;
                    sumTotal++;

                }
                else if (answer == rightanswer && group == "Ekonomi")
                {
                    sumEkonomi++;
                    sumTotal++;
                }
                else if (answer == rightanswer && group == "Produkter och hantering")
                {
                    sumProdukter++;
                    sumTotal++;
                }
                else
                {
                    //  sumTotal = sumTotal; skriver inte ut detta
                }
            }



            //ev sumTotal = sumEktik+sumEkonomi+sumProdukter;

            if (sumTotal >= 70 && sumEtik >= 60 && sumEkonomi >= 60 && sumProdukter >= 60)  /// procent!!!!!!!!!!
            {
                //Grattis du klarade provet
            }
            else
            {
                //du klarade dessvärre inte provet. Vill du se de rätta svaren?
            }


        }

        private void CollectAnsweList()
        {

        }

        private void LoadTestProdukterClass()
        {
            string xmlfil = Server.MapPath("testProdukter.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);

            XmlNodeList xmlLista = doc.SelectNodes("/testprodukter/testquestion");

            foreach (XmlNode nod in xmlLista)
            {
                TestClass testet = new TestClass();

                testet.id = nod.Attributes["id"].Value;
                testet.Group = nod["group"].InnerText;
                testet.Question = nod["question"].InnerText;
                testet.Answer1 = nod["answer1"].InnerText;
                testet.Answer2 = nod["answer2"].InnerText;
                testet.Rightanswer = nod["rightanswer"].InnerText;

                testlista.Add(testet);

            }


            //Repeater3.DataSource = testlista;
            //Repeater3.DataBind();
        }

        private void AmountOfQuestion(int sumquestions)
        {
            int SumQuestions = 1;
            int SumPages = SumQuestions / sumquestions;


            List<ListItem> questions = new List<ListItem>();
            for (int i = 1; i <= SumQuestions; i++)
            {
                ListItem item = new ListItem();
                item.Text = i.ToString();
                item.Value = i.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hej");
            Label1.Text = "hej";
        }

        protected void BtnLamnain_Click(Object sender, EventArgs e)
        {
            Label1.Text = "hej";
            int testSum = 0;
            foreach (Control radiobutton in Repeater1.Controls)
            {
                if (radiobutton.GetType() == typeof(CheckBoxList))
                {
                    Response.Write(radiobutton.ID);
                    CheckBoxList cbl = new CheckBoxList();
                    cbl = (CheckBoxList)radiobutton;

                    foreach (ListItem chkitem in cbl.Items)
                    {
                        if (chkitem.Selected)
                        {
                            Response.Write(chkitem.Text);

                            TestClass correctanswer = new TestClass();

                            correctanswer.id = radiobutton.ID;
                            correctanswer.chkanswer = chkitem.ToString();
                            //correctanswer.Rightanswer = "Dollar";  // ska vi prova att hämta hem denna från xml?

                            testclasslist.Add(correctanswer);
                        }

                    }

                    for (int i = 0; i < testlista.Count; i++)
                    {
                        if (testlista[i].Rightanswer == testclasslist[i].chkanswer)
                        {
                            Response.Write("Rätt");   //får utt dubbelrätt varför får vi in 2 korrekta objekt i listan, borde bara vara ett == dollar?
                            testSum++;
                        }
                        else
                        {
                            Response.Write("fel");
                        }


                    }

                   // Label1.Text = testSum.ToString();

                }
            }Response.Write(testSum); 
        }
      
        //  private void TestCheck(List<TestClass> objektslista)//måste skicka in en objektslista med group,svar och rätt svar
        //{
        //    int sumTotal = 0;  // kan itne ligga här för då nollas de varje gång denan körs... jo nu...
        //    int sumEtik = 0;
        //    int sumEkonomi = 0;
        //    int sumProdukter = 0;




        //    foreach (TestClass objekt in objektslista)
        //    {

        //        string answer = objekt.chkanswer;
        //        string rightanswer = objekt.Rightanswer;
        //        string group = objekt.Group;



        //        //    if (answer == rightanswer && group == "Etik och regelverk")
        //        //    {
        //        //        sumEtik++;
        //        //        sumTotal++;

        //        //    }
        //        //    else if (answer == rightanswer && group == "Ekonomi")
        //        //    {
        //        //        sumEkonomi++;
        //        //        sumTotal++;
        //        //    }
        //        //    else if (answer == rightanswer && group == "Produkter och hantering")
        //        //    {
        //        //        sumProdukter++;
        //        //        sumTotal++;
        //        //    }
        //        //    else
        //        //    {
        //        //        //  sumTotal = sumTotal; skriver inte ut detta
        //        //    }
        //        //}

        //    };
                    

        private void getXML()
        {
            string xmlfil = Server.MapPath("test.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);


            XmlNodeList test = doc.SelectNodes("/test/testquestion");
            //Label1.Text = test.InnerText;

            //Label1.Text = "frågor: ";


            //foreach (XmlNode nod in test)
            //{

            //    Label1.Text += nod["question"].InnerText + " " ;
            //}


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