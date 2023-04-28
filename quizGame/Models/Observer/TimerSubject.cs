using quizGame.Models.ObserverInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace quizGame.CountdownTimer
{
    public class TimerSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int secondLeft;
        private Timer countdownTimer;
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer) { 
            observers.Remove(observer);
        }

        public void Start(int seconds) // in seconds
        {
            secondLeft = seconds;
            countdownTimer = new Timer(1000);
            countdownTimer.Elapsed += OnTimerElapsed;
            countdownTimer.Enabled = true;
        }

        private void OnTimerElapsed(object sender, EventArgs e)
        {
            if(secondLeft >= 0)
            {
                secondLeft--;
                 Notify();   
            }
            else
            {
                countdownTimer.Stop();
                Notify();
            }
           
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.UpdateTime(secondLeft);
            }
        }

        public void resetTime(int seconds)
        {
            this.secondLeft = seconds;
            Notify();
        }

    }
}
