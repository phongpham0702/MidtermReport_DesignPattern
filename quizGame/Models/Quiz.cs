using quizGame.Factory;
using quizGame.Models.scoreStrategy;
using quizGame.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace quizGame.Models
{
    public abstract class Quiz
    {
        protected Thread th;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Mode { get; set; }

        protected IscoreStrategy strategy;
        public List<Answer> QuestionsAndAnswers { get; set; }

        public Quiz() { 
            strategy = new basicScoreStrategy();
        }

        public String getTitle()
        {
            return Title;
        }
        public void AddQuestion(Answer question)
        {

            QuestionsAndAnswers.Add(question);
        }
        public Question getIndexQuestion(int i)
        {
            return QuestionsAndAnswers.ElementAt(i).getQuestion();
        }

        public int getQuestionAmount()
        {
            return QuestionsAndAnswers.Count;
        }

        public void recordAnswer(Answer answer)
        {
            int answerIndex = QuestionsAndAnswers.FindIndex(a => (a.getQuestionID() == answer.getQuestionID() && a.getQuestionText() == answer.getQuestionText()));
            if (answerIndex == -1)
            {
                QuestionsAndAnswers[answerIndex] = answer;
            }
            else
            {
                QuestionsAndAnswers[answerIndex].setChoice(answer.getChoice()) ;
            }
        }

        public int getQuestionIndex(Question question)
        {
            int answerIndex = QuestionsAndAnswers.FindIndex(a => (a.getQuestionID() == question.Id && a.getQuestionText() == question.Text));
            if (answerIndex == -1)
            {
                return 0;
            }
            
            return answerIndex;
        }
        protected abstract void openQuizForm(object obj);
        
        public abstract void start();

        public abstract Boolean finish();
        
           //return strategy.calculateScore(this);
        
        

        //public Question getEmptyAnswerQuestion();
        //{
        //    int answerIndex = userAnswer.FindIndex(a => (a.getQuestionID() == answer.getQuestionID() && a.getQuestionText() == answer.getQuestionText()));
        //    if (answerIndex == -1) {
        //        return null;
        //    }
        //    return userAnswer[answerIndex];
        //}
        //public abstract void StartQuiz();
        //    public void StartQuiz()
        //    {
        //        ShuffleQuestions();
        //        DisplayQuestions();
        //        DisplayResults();
        //    }

        //    protected abstract void ShuffleQuestions();
        //    protected abstract void DisplayQuestions();
        //    protected abstract void DisplayResults();
    }
}
