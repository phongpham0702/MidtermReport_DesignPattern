using quizGame.CountdownTimer;
using quizGame.Models.ObserverInterface;
using quizGame.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using quizGame.Models.scoreStrategy;

namespace quizGame.Models.QuizMode.Decorator
{
    public class TimeMode : QuizDecorate,IObserver
    {
        private TimerSubject timer = new TimerSubject();
        //private System.Windows.Forms.Timer timer;
        private readonly int time = 600; //second
        private int timeLeft;
        public TimeMode(Quiz activeQuiz):base(activeQuiz) {
            this.Mode = "Time";
            this.timer.Attach(this);
        }

        public int getTime() { return time; }

        public int getTimeLeft() { return timeLeft; }
        protected override void openQuizForm(object obj)
        {
            Application.Run(new TimeModeForm(timer));
        }

        public override void start()
        {
            th = new Thread(openQuizForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            timer.Start(time);
        }

        public void UpdateTime(int timeLeft)
        {
            if(timeLeft >= 0) { 
                this.timeLeft = timeLeft;
            }
            else
            {
                this.timeLeft = 0;
                this.timer.Detach(this); 
            }
            
        }

        public override Boolean finish()
        {
            this.strategy = new TimeModeScoreStrategy();
            return strategy.calculateScore(this);
        }
    }
}
