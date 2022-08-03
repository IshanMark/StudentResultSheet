using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResult1
{

    public partial class Form1 : Form
    {
        int total = 0;
        float average = 0;


       
        public Form1()
        {
            InitializeComponent();
            
        }

        public void DefineVariable() {
           int Sinhala = Convert.ToInt32(txtSinhala.Text);
           int English = Convert.ToInt32(txtEnglish.Text);
           int Matha = Convert.ToInt32(txtMatha.Text);
           int Science = Convert.ToInt32(txtScience.Text);
           int History = Convert.ToInt32(txtHistory.Text);
           int Religion = Convert.ToInt32(txtReligion.Text);

             total = Sinhala + English + Matha + Science + History + Religion;

             average = total / 6;
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStuName.Text = String.Empty;
            txtStuNo.Text = String.Empty;

            txtSinhala.Text = String.Empty;
            txtEnglish.Text = String.Empty;
            txtMatha.Text = String.Empty;
            txtScience.Text = String.Empty;
            txtHistory.Text = String.Empty;
            txtReligion.Text = String.Empty;

            labTotal.Text = String.Empty;
            labAverage.Text = String.Empty;

            labSinhala.Text = String.Empty;
            labEnglish.Text = String.Empty;
            labMatha.Text = String.Empty;
            labScience.Text = String.Empty;
            labHistory.Text = String.Empty;
            labReligion.Text = String.Empty;

            txtReligion.Clear();

        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            int Sinhala = Convert.ToInt32(txtSinhala.Text);
            int English = Convert.ToInt32(txtEnglish.Text);
            int Matha = Convert.ToInt32(txtMatha.Text);
            int Science = Convert.ToInt32(txtScience.Text);
            int History = Convert.ToInt32(txtHistory.Text);
            int Religion = Convert.ToInt32(txtReligion.Text);

            if (Sinhala < 35)
            {
                labSinhala.Text = "F";
            }
            else if (Sinhala < 55) {
                labSinhala.Text = "S";
            }
            else if (Sinhala < 65)
            {
                labSinhala.Text = "C";
            }
            else if (Sinhala < 75)
            {
                labSinhala.Text = "B";
            }
            else
            {
                labSinhala.Text = "A";
            }

            
            if (English < 35)
            {
                labEnglish.Text = "F";
            }
            else if (English < 55)
            {
                labEnglish.Text = "S";
            }
            else if (English < 65)
            {
                labEnglish.Text = "C";
            }
            else if (English < 75)
            {
                labEnglish.Text = "B";
            }
            else
            {
                labEnglish.Text = "A";
            }

            
            if (Matha < 35)
            {
                labMatha.Text = "F";
            }
            else if (Matha < 55)
            {
                labMatha.Text = "S";
            }
            else if (Matha < 65)
            {
                labMatha.Text = "C";
            }
            else if (Matha < 75)
            {
                labMatha.Text = "B";
            }
            else
            {
                labMatha.Text = "A";
            }

            
            if (Science < 35)
            {
                labScience.Text = "F";
            }
            else if (Science < 55)
            {
                labScience.Text = "S";
            }
            else if (Science < 65)
            {
                labScience.Text = "C";
            }
            else if (Science < 75)
            {
                labScience.Text = "B";
            }
            else
            {
                labScience.Text = "A";
            }

            
            if (History < 35)
            {
                labHistory.Text = "F";
            }
            else if (History < 55)
            {
                labHistory.Text = "S";
            }
            else if (History < 65)
            {
                labHistory.Text = "C";
            }
            else if (History < 75)
            {
                labHistory.Text = "B";
            }
            else
            {
                labHistory.Text = "A";
            }

            
            if (Religion < 35)
            {
                labReligion.Text = "F";
            }
            else if (Religion < 55)
            {
                labReligion.Text = "S";
            }
            else if (Religion < 65)
            {
                labReligion.Text = "C";
            }
            else if (Religion < 75)
            {
                labReligion.Text = "B";
            }
            else
            {
                labReligion.Text = "A";
            }
        }


        private void btnTotal_Click(object sender, EventArgs e)
        {
            DefineVariable();
            labTotal.Text = total.ToString();



        }

        public void btnAverage_Click(object sender, EventArgs e)
        {
            DefineVariable();
            labAverage.Text = average.ToString();

        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            DefineVariable();
            string name = txtStuName.Text;
            string stuNo = txtStuNo.Text;
            string message ="Student Name: " +name+" Student No: "+stuNo+" Total : "+ total+" Average : "+ average ;
            string title = "Student Result Report!";
            MessageBox.Show(message,title);
        }
    }
}
