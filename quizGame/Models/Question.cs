using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public int CorrectChoiceIndex { get; set; }

        public Question()
        {
           Choices = new List<string>();
        }

        protected bool IsCorrect(int choiceIndex)
        {
            return CorrectChoiceIndex == choiceIndex;
        }

    }
}
