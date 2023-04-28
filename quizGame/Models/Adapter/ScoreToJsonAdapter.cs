using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame.Models.Adapter
{
    public class ScoreToJsonAdapter : IJsonAdapter
    {
        public string ToJsonString(object obj)
        {
            Dictionary<string, object> dictionary = obj as Dictionary<string, object>;
            if (dictionary != null)
            {
                return JsonConvert.SerializeObject(dictionary, Formatting.Indented);
            }
            return null; ;
        }

        public void WriteToFile(Dictionary<String,object> scoreResult )
        {
            IJsonAdapter adapter = new ScoreToJsonAdapter();
            string jsonData = adapter.ToJsonString(scoreResult);

            WriteResult outputData = new WriteResult();
            outputData.WriteToFile(jsonData);
        }
    }
}
