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
        public int AmountOfanswers { get; set; }
        public string Question { get; set; }
        public string Group { get; set; }
       
        List<ClassAnswers> answerlist = new List<ClassAnswers>();
        List<ClassRightAnswer> rightanswerlist = new List<ClassRightAnswer>();
    }
}
