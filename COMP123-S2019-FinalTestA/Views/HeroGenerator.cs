using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: TANAY KAPOOR
 * STUDENT ID:301044399
 * DESCRIPTION: This is the Here Generator Form
 */

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        Random rand = new Random();
        

        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
        /// <summary>
        /// This is the event handler for GerenateNameButton Click Event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }
        /// <summary>
        /// This the method for LoadNames .
        /// </summary>
        public void loadnames()
        {
            //Inputing Last Name
            var lastName = File.ReadAllLines(@"..\..\Data\lastNames.txt");
            var lastNameList = new List<string>(lastName);

            //Inputing First Name
            var firstName = File.ReadAllLines(@"..\..\Data\firstNames.txt");
            var firstNameList = new List<string>(firstName);
        }

       
        /// <summary>
        /// This is the method for GenerateNames
        /// </summary>
        public void GenerateNames()
        {
            //Inputing First Name
            var firstName = File.ReadAllLines(@"..\..\Data\firstNames.txt");
            var firstNameList = new List<string>(firstName);
            Random rand = new Random();
            int index = rand.Next(firstNameList.Count);
            FirstNameDataLabel.Text = firstNameList[index];

            //Inputing Last Name
            var lastName = File.ReadAllLines(@"..\..\Data\lastNames.txt");
            var lastNameList = new List<string>(lastName);
            Random random = new Random();
            int indexs = random.Next(lastNameList.Count);
            LastNameDataLabel.Text = lastNameList[indexs];
        }
        /// <summary>
        /// This is the event handler for HeroGenerator Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            //For Random Names
            loadnames();
            GenerateNames();

            //For Random Powers
            loadPowers();
            GeneratePowers();
        }
        /// <summary>
        /// This is th event handler for GenerateAbilitiesButton click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            FightingDataLabel.Text = rand.Next(1, 50).ToString();
            AgilityDataLabel.Text = rand.Next(1, 50).ToString();
            StrengthDataLabel.Text = rand.Next(1, 50).ToString();
            EnduranceDataLabel.Text = rand.Next(1, 50).ToString();
            ReasonDataLabel.Text = rand.Next(1, 50).ToString();
            IntuitionDataLabel.Text = rand.Next(1, 50).ToString();
            PsycheDataLabel.Text = rand.Next(1, 50).ToString();
            PopularityDataLabel.Text = rand.Next(1, 50).ToString();

        }
        /// <summary>
        /// This is the event handler for About Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void GeneratePowersButton_Click(object sender, EventArgs e)
        {
            GeneratePowers();
        }
        public void loadPowers()
        {
            //Inputing Powers
            var Powers = File.ReadAllLines(@"..\..\Data\powers.txt");
            var PowersList = new List<string>(Powers);

            
        }
        /// <summary>
        /// This the method for generating powers.
        /// </summary>
        public void GeneratePowers()
        {

            //GenerateRandomPowers();

            //Inputing Powers
            var Powers = File.ReadAllLines(@"..\..\Data\powers.txt");
            var PowersList = new List<string>(Powers);
            Random rand = new Random();
            int index = rand.Next(PowersList.Count);
            
            PowerDataLabel1.Text = PowersList[index];
            PowerDataLabel2.Text = PowersList[index];
            PowerDataLabel3.Text = PowersList[index];
            PowerDataLabel4.Text = PowersList[index];


        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        

    }

}

