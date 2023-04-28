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
    public partial class ChooseMode : Form
    {
        private ChooseQuiz parentForm; 
        public ChooseMode(ChooseQuiz parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            basicMode.Checked = true;
            ModeDescription.Text = "Basic mode: No challenge, no time, suitable for new player.";
        }

        private void basicMode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            ModeDescription.Text = "Basic mode: No challenge, no time, suitable for new player.";
            parentForm.setMode(button.Tag.ToString());
        }

        private void timeMode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            ModeDescription.Text = "Time mode: 10 minutes for all questions.";
            parentForm.setMode(button.Tag.ToString());
        }

        private void fastMode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            ModeDescription.Text = "Fast mode: Each question has 30 seconds to answer.";
            parentForm.setMode(button.Tag.ToString());
        }
    }
}
