using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_200306382
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            Program.character.FirstName = firstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
            Program.character.Race = RaceTextBox.Text;
            Program.character.Strength = StrengthTextBox.Text;
            Program.character.Dexterity = DexterityTextBox.Text;
            Program.character.Constitution = ConstitutionTextBox.Text;
            Program.character.Intelligence = IntelligenceTextBox.Text;
            Program.character.Wisdom = WisdomTextBox.Text;
            Program.character.Charisma = CharismaTextBox.Text;
        }
    }
}
