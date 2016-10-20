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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        /*
         * generate random data by looping through listbox
        */
        public void GenerateNames ()
        {
            // grab a random string for firstnametextbox
            Random random = new Random();
            int randomNumber = random.Next(1, FirstNameListBox.Items.Count);
            FirstNameListBox.Select();
            FirstNameListBox.SelectedItem = FirstNameListBox.Items[randomNumber];
            var str = FirstNameListBox.SelectedItem;
            FirstNameTextBox.Text = str.ToString();
            // grab a random string for lastnametextbox
            
            int randomNumber2 = random.Next(1, lastNameListBox.Items.Count);
            lastNameListBox.Select();
            lastNameListBox.SelectedItem = lastNameListBox.Items[randomNumber];
            var str2 = lastNameListBox.SelectedItem;
            LastNameTextBox.Text = str2.ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // call random method
            GenerateNames();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
            
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            //call random method
            GenerateNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // close current form and display ability form
            AbilityGeneratorForm AbilityGeneratorForm = new AbilityGeneratorForm();
            AbilityGeneratorForm.Show();
            this.Hide();
        }
    }
}
