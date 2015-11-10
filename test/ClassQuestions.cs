using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ClassQuestions
    {

        public string Id { get; set; }
        public string Nr { get; set; }
        public string AmountOfAnswers { get; set; }
        public string Question { get; set; }
        public string Group { get; set; }
        public string AmountOfRightAnswers { get; set; }

        public List<ClassAnswers> answerlist;
        public List<ClassRightAnswer> rightanswerlist;



        public ClassQuestions(string id, string nr, string amountofanswers , string question, string group, string amountofrightanswers)
        {
            Id = id;
            Nr = nr;
            AmountOfAnswers = amountofanswers;
            Question = question;
            Group = group;
            AmountOfRightAnswers = amountofrightanswers;

            answerlist = new List<ClassAnswers>();
            rightanswerlist = new List<ClassRightAnswer>();
        }



    }
}
