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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using quizGame.Models.scoreStrategy;

namespace quizGame.Models.QuizMode.Decorator
{
    public class FastMode : QuizDecorate, IObserver
    {
        private TimerSubject timer = new TimerSubject();
        private readonly int timePerQuestion = 30; //second
        private int timeLeft;
        private int bonusPoint = 0;
        public FastMode(Quiz activeQuiz) : base(activeQuiz)
        {
            this.Mode = "Fast";
            this.timer.Attach(this);
        }

        public int gettimePerQuestion()
        {
            return this.timePerQuestion;
        }

        public int getBonustPoint()
        {
            return this.bonusPoint;
        }

        public void addBonustPoint(int bonusPoint)
        {
            this.bonusPoint += bonusPoint;
        }
        protected override void openQuizForm(object obj)
        {
            Application.Run(new quizGame.Views.FastModeForm(timer));
        }

        public override void start()
        {
            th = new Thread(openQuizForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            timer.Start(timePerQuestion);
        }
        public void UpdateTime(int timeLeft)
        {
            if (timeLeft >= 0)
            {
                this.timeLeft = timeLeft;
            }
            else
            {
                this.timeLeft = 0;
                //this.timer.Detach(this);
            }
        }

        public void resetTime()
        {
            this.bonusPoint += timeLeft;
            this.timer.resetTime(timePerQuestion);
        }

        public override Boolean finish()
        {
            this.timer.Detach(this);
            this.bonusPoint += timeLeft;
            this.strategy = new FastModeScoreStrategy();
            return strategy.calculateScore(this);
        }

    }
}
