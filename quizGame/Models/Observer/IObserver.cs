using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame.CountdownTimer
{
    public interface IObserver
    {
        void UpdateTime(int timeLeft);
    }
}
