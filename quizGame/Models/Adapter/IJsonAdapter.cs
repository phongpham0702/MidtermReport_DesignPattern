using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame.Models.Adapter
{
    public interface IJsonAdapter
    {
        string ToJsonString(object obj);
    }
}
