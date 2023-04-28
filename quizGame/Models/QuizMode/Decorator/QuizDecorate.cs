using quizGame.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame.Models.QuizMode.Decorator
{
    public abstract class QuizDecorate : Quiz
    {
        public Quiz activeQuiz;

        public QuizDecorate(Quiz activeQuiz)
        {
            this.activeQuiz = activeQuiz;
        }

        public override void start()
        {
            activeQuiz.start();
        }

        public override Boolean finish()
        {
            return activeQuiz.finish();
        }
    }
}
