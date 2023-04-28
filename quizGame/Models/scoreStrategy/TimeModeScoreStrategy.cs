using quizGame.Models.Adapter;
using quizGame.Models.QuizMode.Decorator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame.Models.scoreStrategy
{
    public class TimeModeScoreStrategy:IscoreStrategy
    {
        private Dictionary<String, object> result = new Dictionary<String, object>();
        public TimeModeScoreStrategy() { }

        public Boolean calculateScore(Object obj)
        {

            TimeMode q = (TimeMode)obj;

            this.result.Add("Topic", q.getTitle());
            this.result.Add("Mode", q.Mode);
            this.result.Add("CorrectAnswer", "NA");
            this.result.Add("CorrectPercent", "NA");
            this.result.Add("Points", "NA");
            this.result.Add("TotalTime", "NA");
            this.result.Add("PerformTime", "NA");
            this.result.Add("RemainTime", "NA");
            try
            {
                ScoreToJsonAdapter adapter = new ScoreToJsonAdapter();
                int correctAnswer = 0;
                int score = 0;
                int percent;
                for (int i = 0; i < q.QuestionsAndAnswers.Count; i++)
                {
                    Answer a = q.QuestionsAndAnswers[i];
                    Question ques = a.getQuestion();

                    if (a.getChoice() == ques.CorrectChoiceIndex)
                    {
                        correctAnswer += 1;
                    }
                }

                score = correctAnswer * 10;
                percent = (correctAnswer * 100) / q.QuestionsAndAnswers.Count;

                result["CorrectAnswer"] = correctAnswer;
                result["CorrectPercent"] = percent + "%";
                result["Points"] = score + q.getTimeLeft();
                result["TotalTime"] = q.getTime();
                result["RemainTime"] = q.getTimeLeft();
                result["PerformTime"] = q.getTime() - q.getTimeLeft();

                adapter.WriteToFile(result);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
    }
}
