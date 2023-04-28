using quizGame.Controllers;
using quizGame.CountdownTimer;
using quizGame.Models;
using quizGame.Models.QuizMode.Decorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame.Views
{
    public partial class TimeModeForm : Form, IObserver
    {
        private TimerSubject timer;
        private QuizManagement controller;
        private int qAmount;
        private int QIndex;
        private Question currentQuestion;
        public TimeModeForm(TimerSubject timer = null)
        {
            InitializeComponent();
            this.timer = timer;
            this.timer.Attach(this);

            controller = QuizManagement.getInstance();
            qAmount = controller.getQuizQuestionAmount();
            label2.Text += " " + controller.getQuizTitle();
            currentQuestion = controller.getIndexQuenstion(0);
            QIndex = controller.getQuestionIndex(currentQuestion);
            askQuestion(currentQuestion);
              
        }

        private void askQuestion(Question q)
        {
            if (q != null)
            {
                label1.Text = q.Text;
                questionCount.Text = $"{QIndex + 1}/{qAmount}";
                button1.Text = q.Choices[0];
                button2.Text = q.Choices[1];
                button3.Text = q.Choices[2];
                button4.Text = q.Choices[3];
            }
        }

        private void chooseAnswer(object sender, EventArgs e)
        {
            Button senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            controller.recordUserAnswer(QIndex, buttonTag);

            if (QIndex + 1 == qAmount)
            {

                controller.finishQuiz(this);

            }
            else
            {
                QIndex += 1;
                currentQuestion = controller.getIndexQuenstion(QIndex);
                QIndex = controller.getQuestionIndex(currentQuestion);
                askQuestion(currentQuestion);
            }

        }
        public void UpdateTime(int seconds)
        {
            if (seconds >= 0)
            {

                if (InvokeRequired)
                {
                    Invoke(new Action(() => { clock.Text = $"{seconds / 60:00}:{seconds % 60:00}"; }));
                    return;
                }
                else
                {
                    clock.Text = $"{seconds / 60:00}:{seconds % 60:00}";
                }
            }
            else
            {

                this.timer.Detach(this);
                Debug.WriteLine("Out of time");
                controller.finishQuiz(this);
            }
        }
    }
}
