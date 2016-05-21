using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FNQ
{
    public class QuizQuestion
    {
        public QuizQuestion()
        {
            enabled = false;
            questionBody = ans1 = ans2 = ans3 = ans4 = "";
            answerIndex = 1;
        }
        public bool enabled { get; set; }
        public string questionBody { get; set; }
        //public string[] questionAnswers = { "", "", "", "" };
        public int answerIndex { get; set; }

        //dirty, but i can't fully understand non type used to bind with data grid view so not arrays
        public string ans1 { get; set; }
        public string ans2 { get; set; }
        public string ans3 { get; set; }
        public string ans4 { get; set; }

        public bool validate(string ans)
        {
            if (answerIndex == 1 && ans == ans1) return true;
            if (answerIndex == 2 && ans == ans2) return true;
            if (answerIndex == 3 && ans == ans3) return true;
            if (answerIndex == 4 && ans == ans4) return true;

            return false;
        }
    }
}
