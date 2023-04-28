using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame.Models
{
    public class Answer
    {
        private Question question;
        private int choice;
        public Answer(Question q, int choice) { 
        
            this.question = q;
            this.choice = choice;
            
        }

        public Question getQuestion() { return question; }
        public int getChoice() { return choice; }
        public void setChoice(int choice) { this.choice = choice; }
        public int getQuestionID()
        {
            return question.Id;
        }

        public String getQuestionText()
        {
            return question.Text;
        }
    }
}
