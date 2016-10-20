using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 	App name = Race and class
    Author's name = Dilpreet Singh
    Student	ID = 200306382
    App	Creation Date = 20/10/2016
    App description = This program generate random names display abilities and race
 */
namespace COMP1004_F2016_Mid_Term_Exam_200306382
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = false;

            GenerateNameForm GenerateNameForm = new GenerateNameForm();
            GenerateNameForm.Show();
            this.Hide();
        }
    }
}
