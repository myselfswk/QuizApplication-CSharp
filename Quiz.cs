using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication_CSharp
{
    public partial class Quiz : Form
    {
        //private string[,] questions = new string[15, 5];
       public static int points = 0;

        private String question = "Which of the following keyword is used for including the namespaces in the program in C#?";
        private String op1 = "imports";
        private String op2 = "using";
        private String op3 = "exports";
        private String op4 = "None of the above";

        public Quiz()
        {
            InitializeComponent();
            //Question No 1
            //questions[0, 0] = "Which of the following keyword is used for including the namespaces in the program in C#?";
            //questions[0, 1] = "imports";
            //questions[0, 2] = "using";
            //questions[0, 3] = "exports";
            //questions[0, 4] = "None of the above";

            ////Show Question
            //lblQuestion.Text = questions[0, 0];
            //rbA.Text = questions[0, 1];
            //rbB.Text = questions[0, 2];
            //rbC.Text = questions[0, 3];
            //rbD.Text = questions[0, 4];


            lblQuestion.Text = question;
            rbA.Text = op1;
            rbB.Text = op2;
            rbC.Text = op3;
            rbD.Text = op4;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbB.Checked)
            {
                points++;
            }
            Quiz1 quiz1 = new Quiz1();
            quiz1.Show();
        }
    }
}
