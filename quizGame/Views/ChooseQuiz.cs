using quizGame.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace quizGame.Views
{
    public partial class ChooseQuiz : Form
    {
        private string selectedQuiz = "quiz1";
        private QuizManagement controller;
        private ChooseMode mode;
        private string selectedMode = "M01";
        public ChooseQuiz()
        {
            InitializeComponent();
            controller = QuizManagement.getInstance();
            mode = new ChooseMode(this);
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            selectedQuiz = button.Name;
        }

        private void start_Click(object sender, EventArgs e)
        {
            controller.startQuiz(selectedQuiz,selectedMode ,this);
        }

        private void select_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mode.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(mode);
            mode.Show();
            button.Visible = false;
            startButton.Visible = true;
        }

        public void setMode(String mode)
        {
            this.selectedMode = mode;
        }

        private void gotoAchieve_Click(object sender, EventArgs e)
        {
            Form achieveForm = new Achieveboard();
            achieveForm.ShowDialog();   
        }
    }
}
