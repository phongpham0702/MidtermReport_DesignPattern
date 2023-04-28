using quizGame.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace quizGame.Models.QuizMode
{
    public class BasicQuiz : Quiz
    {
        public BasicQuiz():base() {
            this.Mode = "Basic";
        }
        protected override void openQuizForm(object obj)
        {
            Application.Run(new QuizForm());
        }
        public override void start()
        {
            th = new Thread(openQuizForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();         
        }

        public override Boolean finish()
        {
           return strategy.calculateScore(this);
        }
    }
}
