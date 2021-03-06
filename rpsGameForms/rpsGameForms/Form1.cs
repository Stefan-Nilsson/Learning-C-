﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpsGameForms
{
    public partial class Form1 : Form
    {

        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;

        string[] CpuChoiceList = {"rock","paper","scissors","rock","paper","scissors" };


        int randomNumber = 0;

        Random rnd = new Random();

        string cpuChoice;

        string playerChoice;

        int playerScore;
        int cpuScore;

        public Form1()
        {
            InitializeComponent();

            TimerCountDownEvent.Enabled = true;

            playerChoice = "none";

            txtCountDown.Text = "5";
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissors";
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            cpuScore = 0;
            rounds = 3;


            txtScore.Text = "Player: " + playerScore + " - " + cpuScore;

            playerChoice = "none";

            TimerCountDownEvent.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picCpu.Image = Properties.Resources.qq;

            gameOver = false;

        }

        private void TimerCountDownEvent_Tick(object sender, EventArgs e)
        {
            timerPerRound -= 1;

            txtCountDown.Text = timerPerRound.ToString();

            txtRounds.Text = "Rounds " + rounds;

            if (timerPerRound < 1)
            {
                TimerCountDownEvent.Enabled = false;

                timerPerRound = 6;

                randomNumber = rnd.Next(0, CpuChoiceList.Length);

                cpuChoice = CpuChoiceList[randomNumber];

                switch (cpuChoice)
                {

                    case "rock":
                        picCpu.Image = Properties.Resources.rock;

                        break;

                    case "paper":

                        picCpu.Image = Properties.Resources.paper;
                        break;

                    case "scissors":

                        picCpu.Image = Properties.Resources.paper;
                        break;
                }
                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if(playerScore > cpuScore)
                    {
                        MessageBox.Show("Player won the game");
                    }
                    else
                    {
                        MessageBox.Show("CPU won the game");
                    }

                    gameOver = true;
                }

            }
            
        }
        private void checkGame()
        {
            if (playerChoice == "rock" && cpuChoice == "paper")
            {
                cpuScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU wins, paper covers rock");
            }
            else if (playerChoice == "scissors" && cpuChoice == "rock")
            {
                cpuScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU wins, rock breaks scissors");
            }
            else if (playerChoice == "paper" && cpuChoice == "scissors")
            {
                cpuScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU wins, scissors cut paper");
            }

            else if (playerChoice == "rock" && cpuChoice == "scissors")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player wins, rock breaks scissors");
            }
            else if (playerChoice == "paper" && cpuChoice == "rock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player wins, paper covers rock");
            }
            else if (playerChoice == "scissors" && cpuChoice == "paper")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player wins, scissors cut paper");
            }

            else if (playerChoice == "rock" && cpuChoice == "rock")
            {
                rounds -= 1;
                MessageBox.Show("It's a tie");

            }
            else if (playerChoice == "paper" && cpuChoice == "paper")
            {
                rounds -= 1;
                MessageBox.Show("It's a tie");

            }
            else if (playerChoice == "scissors" && cpuChoice == "scissors")
            {
                rounds -= 1;
                MessageBox.Show("It's a tie");

            }
            else
            {
                MessageBox.Show("Make a choice");
            }

            startNextRound();

        }

        private void startNextRound()
        {
            // if gameOver = true then it will not run anything underneath the return line.
           
            if(gameOver == true)
            {
                return;
            }

            txtScore.Text = "Player: " + playerScore + " - " + cpuScore;

            playerChoice = "none";

            TimerCountDownEvent.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picCpu.Image = Properties.Resources.qq;



        }
    }
}
