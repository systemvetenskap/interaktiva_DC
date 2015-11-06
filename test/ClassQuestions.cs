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
        public int Nr { get; set; }
        public int AmountOfAnswers { get; set; }
        public string Question { get; set; }
        public string Group { get; set; }

        public List<ClassAnswers> answerlist;
        public List<ClassRightAnswer> rightanswerlist;



        public ClassQuestions(string id, int nr, int amountofanswers , string question, string group)
        {
            Id = id;
            Nr = nr;
            AmountOfAnswers = amountofanswers;
            Question = question;
            Group = group;

            answerlist = new List<ClassAnswers>();
            rightanswerlist = new List<ClassRightAnswer>();
        }



    }
}
