// CRAPS
// Assignment 1 - 09/10/2021
// Developed by William Hutchison
// Version 1.0.3
// .NET 3.1 Windows Forms Application

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class window_Main : Form
    {
        //Globals
        private int chips = 100;
        private int wager = 0;
        private int point = 0;

        private int wins = 0;
        private int losses = 0;

        public window_Main()
        {
            InitializeComponent();
        }

        //On game startup, get Wager
        private void window_Main_Load(object sender, EventArgs e)
        {
            //Tutorial?
            string tutorial = "Welcome to the game of Craps!\n\nAll players start the game with 100 chips for wagers. Start your game by placing a wager.\n\nGameplay is determined by rolling two dice. If the sum of the dice is 7 or 11, you instantly win. " +
                "If the sum is a 2, 3, or 12 on the first throw; you instantly lose. Otherwise, the sum of the first throw becomes your objective. You win by rolling that sum again without rolling a 7 (you lose if you do).\n\nThe game will automatically " +
                "continue until you run out of chips (and choose not to buy more) or close the game.";
            MessageBox.Show(tutorial);

            //Get incoming wager
            determineWager();

            //Set chips
            Label_ChipCount.Text = chips.ToString();
        }

        private void Btn_RollDice_Click(object sender, EventArgs e)
        {
            //Start by generating a number between 1 and 12
            Random rnd = new Random();
            int rollSumA = rnd.Next(1, 6);
            int rollSumB = rnd.Next(1, 6);
            int rollSum = rollSumA + rollSumB;

            //Print the roll to the Roll History
            string rollHist = Tb_RollHistory.Text;
            Tb_RollHistory.Text = String.Concat(rollHist + $"\n{rollSum} ({rollSumA} + {rollSumB}) ");

            //Decide W/L or Point
            if (point != 0)
            {
                //Player point is in play (2nd or further throw)
                if (rollSum == 7)
                {
                    //Point is in play, instant loss
                    lose();
                }
                else if (rollSum == point)
                {
                    win();
                }
            }
            else
            {
                //First throw
                if (rollSum == 7 || rollSum == 11)
                {
                    //Instant win
                    win();

                }
                else if (rollSum == 2 || rollSum == 3 || rollSum == 12)
                {
                    //Instant loss
                    lose();
                }
                else
                {
                    //Set player point
                    Label_PointObj.Text = rollSum.ToString();
                    point = rollSum;
                }
            }
        }

        //Ask for wager on name game/load game
        private void determineWager()
        {
            //Determine wager
            WagerDialog wagerBox = new WagerDialog();
            wagerBox.ShowDialog();

            int incWager = WagerDialog.dWager;
            if (incWager > chips)
            {
                MessageBox.Show("You can't wager more chips than you have!");
                determineWager();
            }
            else
            {
                wager = WagerDialog.dWager;
                Label_Wager.Text = wager.ToString();
                chips -= wager;
                Label_ChipCount.Text = chips.ToString();
            }
        }

        //Lose game
        private void lose()
        {
            //Set loss labels to red and update
            Label_Losses.ForeColor = Color.FromName("Red");
            Label_LossesCount.ForeColor = Color.FromName("Red");

            losses = int.Parse(Label_LossesCount.Text);
            Label_LossesCount.Text = (++losses).ToString();

            //Add loss to history
            string rollHistL = Tb_RollHistory.Text;
            Tb_RollHistory.Text = String.Concat(rollHistL + "Loss!\nNew Round");

            //Reset wager
            wager = 0;
            Label_Wager.Text = wager.ToString();

            //Start a new round
            newGame(false);
        }

        //Win game
        private void win()
        {
            //Set win labels to green and update
            Label_Wins.ForeColor = Color.FromName("Green");
            Label_WinsCount.ForeColor = Color.FromName("Green");

            wins = int.Parse(Label_WinsCount.Text);
            Label_WinsCount.Text = (++wins).ToString();

            //Add win to history
            string rollHistL = Tb_RollHistory.Text;
            Tb_RollHistory.Text = String.Concat(rollHistL + "Win!\nNew Round");

            //Update chips
            chips = wager * 2;
            Label_ChipCount.Text = chips.ToString();

            //Start a round
            newGame(true);
        }

        private void newGame(bool wType)
        {
            //No chips, close game
            if (chips == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("You've run out of chips! Buy more?", "No Chips!", buttons);

                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    //Reset point/Wager
                    point = 0;
                    wager = 0;
                    chips = 100;
                    Label_PointObj.Text = point.ToString();
                    Label_Wager.Text = wager.ToString();
                    Label_ChipCount.Text = wager.ToString();

                    //Change win/loss label color depending on last round result
                    if (wType)
                    {
                        Label_Losses.ForeColor = Color.FromName("ControlText");
                        Label_LossesCount.ForeColor = Color.FromName("ControlText");
                    }
                    else
                    {
                        Label_Wins.ForeColor = Color.FromName("ControlText");
                        Label_WinsCount.ForeColor = Color.FromName("ControlText");
                    }

                    //Get a new round wager
                    determineWager();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                //Reset point/Wager
                point = 0;
                wager = 0;
                Label_PointObj.Text = point.ToString();
                Label_Wager.Text = wager.ToString();

                //Change win/loss label color depending on last round result
                if (wType)
                {
                    Label_Losses.ForeColor = Color.FromName("ControlText");
                    Label_LossesCount.ForeColor = Color.FromName("ControlText");
                }
                else
                {
                    Label_Wins.ForeColor = Color.FromName("ControlText");
                    Label_WinsCount.ForeColor = Color.FromName("ControlText");
                }

                //Get a new round wager
                determineWager();
            }
        }

        private void Tb_RollHistory_TextChanged(object sender, EventArgs e)
        {
            //Keep the roll history box scrolled to the bottom
            Tb_RollHistory.SelectionStart = Tb_RollHistory.Text.Length;
            Tb_RollHistory.ScrollToCaret();
        }
    }
}
