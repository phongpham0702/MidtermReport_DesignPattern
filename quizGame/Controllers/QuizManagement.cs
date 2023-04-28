using quizGame.Factory;
using quizGame.Models;
using quizGame.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using quizGame.Models.QuizMode.Decorator;

namespace quizGame.Controllers
{   
    public class QuizManagement
    {
        private static QuizManagement instance;
        private QuizFactory quizFactory;
        private Quiz currentQuiz;
        private Thread th;

        private QuizManagement() { 
            quizFactory = new QuizFactory();
        }

        public static QuizManagement getInstance()
        {
            if (instance == null)
            {
                instance = new QuizManagement();
            }
            return instance;
        }

        public void startQuiz(string quiz,string mode ,ChooseQuiz firstForm)
        {
            firstForm.Close();
            currentQuiz = quizFactory.CreateQuiz(quiz,mode);
            if (currentQuiz == null) { MessageBox.Show("Có lỗi xảy ra trong quá trình đọc dữ liệu và tạo quiz. Vui lòng cập nhật lại trò chơi hoặc liên hệ với quản trị viên để biết thêm thông tin."); }
            else
            {
                currentQuiz.start(); 
            }            
        }

        public int getQuizQuestionAmount()
        {
            return currentQuiz.getQuestionAmount();
        
        }

        public String getQuizTitle()
        {
            return currentQuiz.getTitle();
        }

        public Question getIndexQuenstion(int qNum)
        {
            return currentQuiz.getIndexQuestion(qNum);
        }

        public int getQuestionIndex(Question q)
        {
            return currentQuiz.getQuestionIndex(q);
        }

        public void recordUserAnswer(int QID,int answer)
        {
            currentQuiz.recordAnswer(new Answer(getIndexQuenstion(QID),answer));        
        }

        public void finishQuiz(Form form)
        {
           form.Close();
           backToHomePage();
           currentQuiz.finish();

        }

        private  void openChooseForm(object obj)
        {
            Application.Run(new ChooseQuiz());
        }
        private  void backToHomePage()
        {
            th = new Thread(openChooseForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void resetTime()
        {
            FastMode tmp = (FastMode)currentQuiz;
            tmp.resetTime();
        }
    }
}
