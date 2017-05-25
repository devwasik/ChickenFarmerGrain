using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//BY: Nick Wasik
namespace FarmerGUI
{
    public partial class Form1 : Form
    {
        FarmerLogic game;

        public Form1()
        {
            InitializeComponent();

            game = new FarmerLogic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableAll();
            EnableAll();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info myInfo = new Info();

            MessageBox.Show(myInfo.DisplayInfo("Farmer Game"));
        }

        private void movesouth_Click(object sender, EventArgs e)
        {
            string move = "";

            if (rBchickensouth.Checked == true)
                move = "CHICKEN";

            if (rBgrainsouth.Checked == true)
                move = "GRAIN";

            if (rBfoxsouth.Checked == true)
                move = "FOX";

            if (rBfarmersouth.Checked == true)
                move = "";

            game.Move(move);

            bool win;
            
            win = game.DetermineWin();
            

            bool lose;
            lose = game.AnimalAteFood();

            if (lose == true)
            {
                MessageBox.Show("You lose! Chicken ate the grain!");
                PlayAgainPrompt();

            }
            lose = game.GameOver();
            if (lose == true)
            {
                MessageBox.Show("You lose! Fox at the chicken!");
                PlayAgainPrompt();
            }
            DisableAll();
            EnableAll();
        }
        private void movenorth_Click(object sender, EventArgs e)
        {
            string move = "";

            if (rBchickennorth.Checked == true)
                move = "CHICKEN";

            if (rBgrainnorth.Checked == true)
                move = "GRAIN";

            if (rBfoxnorth.Checked == true)
                move = "FOX";

            if (rBfarmernorth.Checked == true)
                move = "";

            game.Move(move);

            //MessageBox...Won or Lose.
            bool win;
            win = game.DetermineWin();
            if (win == true)
            {
                MessageBox.Show("You won!!");
                PlayAgainPrompt();
            }
            bool lose;
            lose = game.AnimalAteFood();

            if (lose == true)
            {
                MessageBox.Show("You lose! Chicken ate the grain!");
                PlayAgainPrompt();
            }
            lose = game.GameOver();
            if (lose == true)
            {
                MessageBox.Show("You lose! Fox at the chicken!");
                PlayAgainPrompt();
            }
            DisableAll();
            EnableAll();
            
        }

        void DisableAll()
        {
            rBchickennorth.Enabled = false;             //disable north
            rBgrainnorth.Enabled = false;
            rBfoxnorth.Enabled = false;
            rBfarmernorth.Enabled = false;

            rBchickensouth.Enabled = false;            //disable south
            rBgrainsouth.Enabled = false;
            rBfoxsouth.Enabled = false;
            rBfarmersouth.Enabled = false;

            rBchickennorth.Visible = false;            //hide north
            rBfarmernorth.Visible = false;
            rBfoxnorth.Visible = false;
            rBgrainnorth.Visible = false;

            rBchickensouth.Visible = false;             //hide south
            rBfarmersouth.Visible = false;
            rBfoxsouth.Visible = false;
            rBgrainsouth.Visible = false;
        }

        void EnableAll()
        {
            List<string> northBank;
            List<string> southBank;
            FarmerLogic.Direction theFarmer;
            theFarmer = game.Farmer;

            if (theFarmer == FarmerLogic.Direction.North)
            {
                rBfarmernorth.Visible = true;
                rBfarmernorth.Enabled = true;
                movesouth.Enabled = false;
                movenorth.Enabled = true;
            }
                northBank = game.NorthBank;
                if (northBank.Contains("CHICKEN"))
                {
                    rBchickennorth.Visible = true;
                    if (theFarmer == FarmerLogic.Direction.North)

                       rBchickennorth.Enabled = true;
                }
                if (northBank.Contains("GRAIN"))
                {
                    rBgrainnorth.Visible = true;
                    if (theFarmer == FarmerLogic.Direction.North)

                        rBgrainnorth.Enabled = true;
                }
                if (northBank.Contains("FOX"))
                {
                    rBfoxnorth.Visible = true;
                    if (theFarmer == FarmerLogic.Direction.North)
                    rBfoxnorth.Enabled = true;
                }



                if (theFarmer == FarmerLogic.Direction.South)
                {
                    rBfarmersouth.Visible = true;
                    rBfarmersouth.Enabled = true;
                    movenorth.Enabled = false;
                    movesouth.Enabled = true;
                }
            
                southBank = game.SouthBank;
                if (southBank.Contains("CHICKEN"))
                {
                    rBchickensouth.Visible = true;
                    if (theFarmer == FarmerLogic.Direction.South)
                    rBchickensouth.Enabled = true;
                }

                if (southBank.Contains("GRAIN"))
                {
                    rBgrainsouth.Visible = true;
                    if (theFarmer == FarmerLogic.Direction.South)
                    rBgrainsouth.Enabled = true;
                }
                if (southBank.Contains("FOX"))
                {
                    rBfoxsouth.Visible = true;
                    if (theFarmer == FarmerLogic.Direction.South)
                    rBfoxsouth.Enabled = true;
                }
            }

        void PlayAgainPrompt()
        {
            DialogResult dialog = MessageBox.Show("Do you want to play again?", "You lost!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                game = new FarmerLogic();
            }
            else if (dialog == DialogResult.No)
            {
                Application.Exit();
            }
        }

       


        

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t      **********************Instructions**********************\n\n" + Environment.NewLine + "Goal: To move the farmer and all of his items to " +
            "the south bank.\n\n" + Environment.NewLine + "You can move one item with each move. The farmer will move to the opposite on each turn. " +
            "To move nothing simply select the farmer and he will move to the opposite bank without taking anything. \n\nGood luck!");
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new FarmerLogic();
            DisableAll();
            EnableAll();
            
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing!");
            this.Close();
        }

        
    }
}
