using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using quizGame.Models;

namespace quizGame.Controllers
{
    public class QuestionReader
    {
        public QuestionReader() { }

        public List<Question> readQuestionData(String path)
        {
            List<Question> result = new List<Question>();
            try
            {
                String DataJson = System.IO.File.ReadAllText($"../../Models/Quizes/{path}");
                dynamic array = JsonConvert.DeserializeObject<dynamic>(DataJson);
                
                foreach (var question in array )
                {
                    Question q = new Question();
                    q.Id = question.id;
                    q.Text = question.text;
                    q.CorrectChoiceIndex = question.correctAnswerIndex;
                    foreach (String item in question.choices)
                    {
                        q.Choices.Add(item);
                    }

                    result.Add(q);
                }

                return result;

            }catch (Exception e) { 
                
                return null;
            }
        }
    }
}
