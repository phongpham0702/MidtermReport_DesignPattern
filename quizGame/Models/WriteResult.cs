using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame.Models
{
    public class WriteResult
    {
        public void WriteToFile(string jsonData)
        {
            // Mở file với chế độ ghi nối tiếp
            using (var writer = new StreamWriter("scoredata.json", true))
            {
                // Chuyển đổi đối tượng thành chuỗi JSON và ghi vào file
                writer.WriteLine(jsonData+",");
            }
        }
    }
}
