using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;


namespace test
{
    public partial class testet : System.Web.UI.Page
    {
        List<ClassQuestions> testlista;
        List<ClassAnswers> answerlist;
        List<ClassRightAnswer> rightanswerlist;

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTestClass();
         
        }

        private void LoadTestClass()
        {
            string xmlfil = Server.MapPath("test.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);
            
            testlista = new List<ClassQuestions>();
            XmlNodeList xmlLista = doc.SelectNodes("/test/testquestion");

            foreach (XmlNode nod in xmlLista)
            {
                ClassQuestions test = new ClassQuestions(nod.Attributes["id"].Value, Convert.ToInt32(nod["nr"].Value), Convert.ToInt32(nod["amountofanswers"].Value), nod["question"].InnerText, nod["group"].InnerText, Convert.ToInt32(nod["amountofrightanswers"].Value) );
                ClassAnswers answer = new ClassAnswers();
                ClassRightAnswer rightanswer = new ClassRightAnswer();

                test.Id = nod.Attributes["id"].Value;
                test.Nr = Convert.ToInt32(nod["nr"].Value);
                test.Group = nod["group"].InnerText;
                test.Question = nod["question"].InnerText;
                test.AmountOfAnswers = Convert.ToInt32(nod["amountofanswers"].Value);
                test.Group = nod["group"].InnerText;
                test.AmountOfRightAnswers = Convert.ToInt32(nod["amountofrightanswers"].Value);

              
                if (test.AmountOfAnswers  == 1)
                {
                    answer.Answer1 = nod["answer1"].InnerText;
                }

               else if (test.AmountOfAnswers == 2)
                {
                    answer.Answer1 = nod["answer1"].InnerText;
                    answer.Answer2 = nod["answer2"].InnerText;
                }
                else if (test.AmountOfAnswers == 3)
                {
                    answer.Answer1 = nod["answer1"].InnerText;
                    answer.Answer2 = nod["answer2"].InnerText;
                    answer.Answer3 = nod["answer3"].InnerText;
                }

                else if (test.AmountOfAnswers == 4)
                {
                    answer.Answer1 = nod["answer1"].InnerText;
                    answer.Answer2 = nod["answer2"].InnerText;
                    answer.Answer3 = nod["answer3"].InnerText;
                    answer.Answer4 = nod["answer4"].InnerText;
                }

                else
                {
                    Response.Write("Felmeddelande: För många svar att hämat hem från xml, kontakta din IT support!");
                }


                if (test.AmountOfRightAnswers == 1)
                {
                    rightanswer.Rightanswer1 = nod["rightanswer1"].InnerText;
                }
                else if (test.AmountOfRightAnswers == 2)
                {
                    rightanswer.Rightanswer1 = nod["rightanswer1"].InnerText;
                    rightanswer.Rightanswer2 = nod["rightanswer2"].InnerText;
                }
                else
                {
                    Response.Write("Felmeddelande: För många rättasvar att hämat hem från xml, kontakta din IT support!");
                }



                testlista.Add(test);
                test.answerlist.Add(answer);
                test.rightanswerlist.Add(rightanswer);
                
            }

            Repeater1.DataSource = testlista;
            Repeater1.DataBind();
        }

        private void Loadtest()
        {
            Response.Write("det gick!");
            //ListItem item = new ListItem();
            //Panel panel = new Panel();
            //CheckBoxList cblist = new CheckBoxList();

            //for (int i = 0; i < testlista.Count ; i++)
            //{
            //    foreach (ClassQuestions fraga in testlista)
            //    {
            //        panel = new Panel();
            //        //panel.CssClass = "checkbox";
            //        panel.GroupingText = fraga.Question;

                    
            //        cblist = new CheckBoxList();

            //        cblist.ID = fraga.Nr.ToString();
            //        cblist.CssClass = "checkbox checkboxlist col-sm-9";


            //        foreach (ClassAnswers svar in answerlist)
            //        {
            //            if (//här vill jag får ut om classQuestion amountofanswers ==1 )
            //            {
            //                item.Text = svar.Answer1;
            //            }

            //            else if (test.AmountOfAnswers == 2)
            //            {
            //                answer.Answer1 = nod["answer1"].InnerText;
            //                answer.Answer2 = nod["answer2"].InnerText;
            //            }
            //            else if (test.AmountOfAnswers == 3)
            //            {
            //                answer.Answer1 = nod["answer1"].InnerText;
            //                answer.Answer2 = nod["answer2"].InnerText;
            //                answer.Answer3 = nod["answer3"].InnerText;
            //            }

            //            else if (test.AmountOfAnswers == 4)
            //            {
            //                answer.Answer1 = nod["answer1"].InnerText;
            //                answer.Answer2 = nod["answer2"].InnerText;
            //                answer.Answer3 = nod["answer3"].InnerText;
            //                answer.Answer4 = nod["answer4"].InnerText;
            //            }

            //            else
            //            {
            //                Response.Write("Felmeddelande: För många svar att hämat hem från xml, kontakta din IT support!");
            //            }




            //            item = new ListItem();
            //            item.Text = svar.Answer1;
            //            item.Value = svar.Nummer.ToString();
            //            item.Text = svar.Text;
            //            cb.Items.Add(item);
            //        }

            //        panel.Controls.Add(cb);
            //        this.Panel1.Controls.Add(panel);

            //    }
            //}
        }

        private void LoadTestEtikClass()
        {
            string xmlfil = Server.MapPath("testEtik.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);




            List<TestClass> testlista = new List<TestClass>();

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

       



            

        private void LoadTestProdukterClass()
        {
            string xmlfil = Server.MapPath("testProdukter.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfil);



            List<TestClass> testlista = new List<TestClass>();

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


    }
}

        //private void CreateAndLoadInToXML(string personId)   //denna metod är under uppbyggnad inte alls klar!!!!!
        //{
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

        //        //Get the root element
        //        XmlElement root = doc.DocumentElement;

        //        XmlElement person = doc.CreateElement("Person");
        //        XmlAttribute name = doc.CreateAttribute("name");
        //        XmlElement age = doc.CreateElement("Age");
        //        XmlElement gender = doc.CreateElement("Gender");

        //        //Add the values for each nodes
        //        name.Value = textBoxName.Text;
        //        age.InnerText = textBoxAge.Text;
        //        gender.InnerText = textBoxGender.Text;

        //        //Construct the Person element
        //        person.Attributes.Append(name);
        //        person.AppendChild(age);
        //        person.AppendChild(gender);

        //        //Add the New person element to the end of the root element
        //        root.AppendChild(person);

        //        //Save the document
        //        doc.Save(PATH);
        //    }

        //    //Show confirmation message
        //    MessageBox.Show("Details have been added to the XML File.");

        //    //Reset text fields for new input
        //    textBoxName.Text = String.Empty;
        //    textBoxAge.Text = String.Empty;
        //    textBoxGender.Text = String.Empty;
        //}





        //private void getXML()
        //{
        //    string xmlfil = Server.MapPath("test.xml");
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(xmlfil);


        //    XmlNodeList test = doc.SelectNodes("/test/testquestion");
        //    //Label1.Text = test.InnerText;

        //    //Label1.Text = "frågor: ";


        //    //foreach (XmlNode nod in test)
        //    //{

        //    //    Label1.Text += nod["question"].InnerText + " " ;
        //    //}


        //    /*string xmlfil = Server.MapPath("aktielista.xml");
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(xmlfil);

        //    XmlNode foretag = doc.SelectSingleNode("/aktiebolag/foretag/namn");
        //    Label1.Text = foretag.InnerText;

        //    Label2.Text = "Aktiebolag: ";
        //    XmlNodeList foretagsnamnlista = doc.SelectNodes("/aktiebolag/foretag");
        //    foreach (XmlNode nod in foretagsnamnlista)
        //    {
        //        Label2.Text += nod["namn"].InnerText + " ";
        //    }*/
        //}

  