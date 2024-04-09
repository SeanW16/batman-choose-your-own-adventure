using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace batman_choose_your_own_adventure
{
    public partial class Form1 : Form
    {
        int page = 0;
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DisplayPage();
            startButton.Visible = false;
            option1Button.Visible = true;
            option2Button.Visible = true;
            option3Button.Visible = false;
            pictureBox1.Visible = true;
            this.BackgroundImage = null;
            this.BackColor = Color.Black;
            titleLabel.Text = "";  
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                page = 26;
            }
            else if (page == 1)
            {
                page = 11;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 9;
            }
            else if (page == 5)
            {
                page = 0;
            }
            else if (page == 6)
            {
                page = 0;
            }
            else if (page == 7)
            {
                page = 13;
            }
            else if (page == 8)
            {
                page = 0;
            }
            else if (page == 9)
            {
                page = 0;
            }
            else if (page == 10)
            {
                page = 15;
            }
            else if (page == 11)
            {
                page = 17;
            }
            else if (page == 12)
            {
                page = 21;
            }
            else if (page == 13)
            {
                page = 0;
            }
            else if (page == 14)
            {
                page = 19;
            }
            else if (page == 15)
            {
                page = 0;
            }
            else if (page == 16)
            {
                page = 0;
            }
            else if (page == 17)
            {
                page = 0;
            }
            else if (page == 18)
            {
                page = 0;
            }
            else if (page == 19)
            {
                page = 0;
            }
            else if (page == 20)
            {
                page = 0;
            }
            else if (page == 21)
            {
                page = 0;
            }
            else if (page == 22)
            {
                page = 0;
            }
            else if (page == 23)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 15)
                {
                    page = 24;
                }
                else
                {
                    page = 25;
                }
            }
            else if (page == 24)
            {
                page = 0;
            }
            else if (page == 25)
            {
                page = 0;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 3;
            }
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                page = 27;
            }
            else if (page == 1)
            {
                page = 12;
            }
            else if (page == 2)
            {
                page = 6;
            }
            else if (page == 3)
            {
                page = 8;
            }
            else if (page == 4)
            {
                page = 10;
            }
            else if (page == 5)
            {
                Application.Exit();
            }
            else if (page == 6)
            {
                Application.Exit();
            }
            else if (page == 7)
            {
                page = 14;
            }
            else if (page == 8)
            {
                Application.Exit();
            }
            else if (page == 9)
            {
                Application.Exit();
            }
            else if (page == 10)
            {
                page = 16;
            }
            else if (page == 11)
            {
                page = 18;
            }
            else if (page == 12)
            {
                page = 23;
            }
            else if (page == 13)
            {
                Application.Exit();
            }
            else if (page == 14)
            {
                page = 20;
            }
            else if (page == 15)
            {
                Application.Exit();
            }
            else if (page == 16)
            {
                Application.Exit();
            }
            else if (page == 17)
            {
                Application.Exit();
            }
            else if (page == 18)
            {
                Application.Exit();
            }
            else if (page == 19)
            {
                Application.Exit();
            }
            else if (page == 20)
            {
                Application.Exit();
            }
            else if (page == 21)
            {
                Application.Exit();
            }
            else if (page == 22)
            {
                Application.Exit();
            }
            else if (page == 23)
            {
               
            }
            else if (page == 24)
            {
                Application.Exit();
            }
            else if (page == 25)
            {
                Application.Exit();
            }
            else if (page == 26)
            {
                page = 2;
            }
            else if (page == 27)
            {
                page = 4;
            }
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 12)
            {
                page = 22;
            }
            DisplayPage();
        }

        private void DisplayPage()
        {
            switch (page)
            {
                case 0:
                    outputLabel.Text = "You are the batman";
                    questionLabel.Text = "Go out tonight to patrol the streets?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.Batcycle;
                    break;
                case 1:
                    outputLabel.Text = "As your driving around you see a weird substance coming out of the sewer";
                    questionLabel.Text = "Explore the sewer?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.sewer;
                    break;
                case 2:
                    outputLabel.Text = "As your driving down a back alleyway the batcycle breaks down, as your fixing the engine a group of thugs sneak up on you";
                    questionLabel.Text = "How do you deal with this situation?";
                    option1Button.Text = "Fight them";
                    option2Button.Text = "Escape to roof";
                    pictureBox1.Image = Properties.Resources.alley;
                    break;
                case 3:
                    outputLabel.Text = "You find one detaling how the joker took hostages at gotham bank";
                    questionLabel.Text = "Leave to attack?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.jokerHostage;
                    break;
                case 4:
                    outputLabel.Text = "Your batsuit got broken on your last misson your fixing it when a loud boom comes from upstairs";
                    questionLabel.Text = "What do you do?";
                    option1Button.Text = "Wait and find a weapon";
                    option2Button.Text = "Rush upstairs";
                    pictureBox1.Image = Properties.Resources.batsuit;
                    break;
                case 5:
                    outputLabel.Text = "Being the better fighter you easiler defeat your attackers";
                    questionLabel.Text = "You win! Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.batmanFighting;
                    break;
                case 6:
                    outputLabel.Text = "Your rope breaks as your halfway up the wall and you fall backwards onto your enemies";
                    questionLabel.Text = "You lose. Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.batmanFalling;
                    break;
                case 7:
                    outputLabel.Text = "You get to the bank and the Joker is demanding a chance to talk to you";
                    questionLabel.Text = "Agree to his demands?";
                    option1Button.Text = "No";
                    option2Button.Text = "Yes";
                    pictureBox1.Image = Properties.Resources.joker;
                    break;
                case 8:
                    outputLabel.Text = "Your not a true hero";
                    questionLabel.Text = "You lose. Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.BatmanRain;
                    break;
                case 9:
                    outputLabel.Text = "Its the Penguin! he's trying to rob your safes, you use the grapping gun you found in the batcave to take him down and protect your money";
                    questionLabel.Text = "You win! Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.batmanPenguin;
                    break;
                case 10:
                    outputLabel.Text = "Its the penguin and hes trying to rob your safes!";
                    questionLabel.Text = "Attack?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.penguin;
                    break;
                case 11:
                    outputLabel.Text = "You find one of your enemies, Clayface!";
                    questionLabel.Text = "How will you fight him?";
                    option1Button.Text = "Freezing gel";
                    option2Button.Text = "Batarangs";
                    pictureBox1.Image = Properties.Resources.clayface;
                    break;
                case 12:
                    option3Button.Visible = true;
                    outputLabel.Text = "Suddenly your car starts to slow down you look behind you and see Mr. Freeze is freezing your tires";
                    questionLabel.Text = "What do you do?";
                    option1Button.Text = "Get out and fight";
                    option2Button.Text = "Reverse back at him";
                    option3Button.Text = "Try and keep driving";
                    pictureBox1.Image = Properties.Resources.Mr_Freeze;
                    break;
                case 13:
                    outputLabel.Text = "The Joker triggers bombs and kills all the hostages and escapes into the smoke";
                    questionLabel.Text = "You lose, Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.jokerSmoke;
                    break;
                case 14:
                    outputLabel.Text = "Joker infects all the hostages with a deadly strain of the flu, he tells you that you can either save the hosatges or capture him";
                    questionLabel.Text = "Find the cure or capture Joker?";
                    option1Button.Text = "Find the cure";
                    option2Button.Text = "Capture the Joker";
                    pictureBox1.Image = Properties.Resources.batmanJoker;
                    break;
                case 15:
                    outputLabel.Text = "Your rush in to attack the Penguin but he shoots you throught the heart";
                    questionLabel.Text = "You lose, Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.PenguinGun;
                    break;
                case 16:
                    outputLabel.Text = "You retreat to the batcave but by the time you find a weapon and come back upstairs the penguin is already gone with all your money";
                    questionLabel.Text = "You lose, Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.batcave;
                    break;
                case 17:
                    outputLabel.Text = "Good job! you used the right weapon clayface froze to the ground";
                    questionLabel.Text = "You win! Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.clayfaceFrozen;
                    break;
                case 18:
                    outputLabel.Text = "Oh no! your batarangs went right through Clayface";
                    questionLabel.Text = "You lose, Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.clayfaceWin;
                    break;
                case 19:
                    outputLabel.Text = "The Joker gets away but you save the hostages, you made the morally corret choice";
                    questionLabel.Text = "Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.jokerRunning;
                    break;
                case 20:
                    outputLabel.Text = "All the hosatges die and you capture the Joker, but at what cost?";
                    questionLabel.Text = "Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    pictureBox1.Image = Properties.Resources.jokerCaptured;
                    break;
                case 21:
                    outputLabel.Text = "As your stepping out of the car Mr. Freeze throws a freeze bomb and freezes you in place";
                    questionLabel.Text = "You lose, Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Visible = false;
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.carCrash);
                    player3.Play();
                    break;
                case 22:
                    outputLabel.Text = "Your car completly freezes with you inside";
                    questionLabel.Text = " You lose, Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Visible = false;
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.carCrash);
                    player2.Play();
                    break;
                case 23:
                    outputLabel.Text = "15% that his freeze gun malfunctions as your backing up at him";
                    questionLabel.Text = "";
                    option1Button.Text = "Continue?";
                    option2Button.Text = "";
                    option3Button.Visible = false;
                    pictureBox1.Image = Properties.Resources.freezeGun;
                    break;
                case 24:
                    outputLabel.Text = "Your car freezes completly with you insde, You lose";
                    questionLabel.Text = "Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Visible = false;
                    pictureBox1.Image = Properties.Resources.batmanFrozen;
                    break;
                case 25:
                    outputLabel.Text = "you back up at hit him with your car knocking him unconsions";
                    questionLabel.Text = "You win! Play agian?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Visible = false;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.carCrash);
                    player.Play();
                    break;
                case 26:
                    outputLabel.Text = "you need a vechicle";
                    questionLabel.Text = "Which vechicle do you select";
                    option1Button.Text = "Batmobile";
                    option2Button.Text = "Batcycle";
                    pictureBox1.Image = Properties.Resources.batmobile;
                    break;
                case 27:
                    outputLabel.Text = "what are you going to do instead";
                    questionLabel.Text = "What do you choose";
                    option1Button.Text = "look at recent police reports ";
                    option2Button.Text = "fix your weapons";
                    pictureBox1.Image = Properties.Resources.bruceWayne;
                    break;
                default:
                    break;
            }
        }
    }
}
