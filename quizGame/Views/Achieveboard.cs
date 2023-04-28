using Newtonsoft.Json;
using quizGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame.Views
{
    public partial class Achieveboard : Form
    {
        public Achieveboard()
        {
            InitializeComponent();
            String path = Path.Combine(Application.StartupPath, "scoredata.json");            
            String DataJson ="["+System.IO.File.ReadAllText(path)+"]";
            dynamic array = JsonConvert.DeserializeObject<dynamic>(DataJson);
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Topic",typeof(String));
            dataTable.Columns.Add("Mode", typeof(String));
            dataTable.Columns.Add("Correct Answer", typeof(String));
            dataTable.Columns.Add("Correct Percent", typeof(String));
            dataTable.Columns.Add("Correct Points", typeof(String));
            dataTable.Columns.Add("Total Time", typeof(String));
            dataTable.Columns.Add("Perform Time", typeof(String));
            dataTable.Columns.Add("Remain Time", typeof(String));

            foreach (var result in array)
            {
                dataTable.Rows.Add($"{result.Topic}", $"{result.Mode}", $"{result.CorrectAnswer}", $"{result.CorrectPercent}", $"{result.Points}", $"{result.TotalTime}", $"{result.PerformTime}", $"{result.RemainTime}");
                
            }

            dataGridView1.DataSource = dataTable;
            
        }

    }
}
