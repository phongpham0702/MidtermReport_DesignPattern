using quizGame.Controllers;
using quizGame.Models;
using quizGame.Models.QuizMode;
using quizGame.Models.QuizMode.Decorator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame.Factory
{
    public class QuizFactory
    {
        public Quiz quiz = new BasicQuiz();
        public Quiz CreateQuiz(string quizId,string mode)
        {
            String path = quizId + ".json";

            switch (mode)
            {
                case "M02":
                    quiz = new TimeMode(quiz);
                    break;
                case "M03":
                    quiz = new FastMode(quiz);
                    break;
            }

            switch (quizId)
            {
                case "quiz1":
                    quiz.Id = 1;
                    quiz.Title = "Ẩm thực";
                    break;
                case "quiz2":
                    quiz.Id = 2;
                    quiz.Title = "Thời trang";
                    break;
                case "quiz3":
                    quiz.Id = 3;
                    quiz.Title = "Game";
                    break;
                case "quiz4":
                    quiz.Id = 4;
                    quiz.Title = "Máy tinh";
                    break;
                case "quiz5":
                    quiz.Id = 5;
                    quiz.Title = "Thần thoại Bắc Âu";
                    break;
                case "quiz6":
                    quiz.Id = 6;
                    quiz.Title = "Halloween";
                    break;
                case "quiz7":
                    quiz.Id = 7;
                    quiz.Title = "Lập trình";
                    break;
                case "quiz8":
                    quiz.Id = 8;
                    quiz.Title = "Vũ trụ";
                    break;
                case "quiz9":
                    quiz.Id = 9;
                    quiz.Title = "Khủng long";
                    break;
                case "quiz10":
                    quiz.Id = 10;
                    quiz.Title = "Hóa học";
                    break;
                // thêm các case khác tương ứng với các đối tượng Quiz khác
                default:
                    throw new ArgumentException("Lỗi: ID của quiz do client cung cấp không tồn tại. Vui lòng thử lại sau");
            }
         
            List<Question> Qlist = generateQuestionList(path);
            quiz.QuestionsAndAnswers = new List<Answer>();
            foreach (var item in Qlist)
            {
                quiz.AddQuestion(new Answer(item, -1));
            }

            
            if (quiz.QuestionsAndAnswers == null) return null;
            return quiz;
        }

        public List<Question> generateQuestionList(String path)
        {
            QuestionReader questionReader = new QuestionReader();
            List<Question> tmp = questionReader.readQuestionData(path);
            return tmp;

        }
    }
}
