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

namespace AdventureGame
{
    public partial class gameSpace : Form
    {
        int pageNumber = 1;
        Random chanceMaker = new Random();
        bool breakfast = false;
        int soufflait;
        int hipBreak;
        SoundPlayer alarm = new SoundPlayer(Properties.Resources.sirenCut);
        public gameSpace()
        {
            InitializeComponent();
            output();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1)
            {
                pageNumber = 3;
                
            }
            else if (pageNumber == 2)
            {
                pageNumber = 4;
            }
            else if (pageNumber == 3)
            {
                pageNumber = 4;
            }
            else if (pageNumber == 4)
            {
                if (breakfast == true)
                {
                    pageNumber = 9;
                }
                else
                {
                    pageNumber = 7;
                }
            }
            else if (pageNumber == 5)
            {
                if (breakfast == true)
                {
                    pageNumber = 9;
                }
                else
                {
                    pageNumber = 7;
                }
            }
            else if (pageNumber == 6)
            {
                
                if (soufflait > 5)
                {
                    pageNumber = 15;
                }
            else
                {
                    pageNumber = 17;
                }
            }
            else if (pageNumber == 7)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 8)
            {
                pageNumber = 11;
            }
            else if (pageNumber == 9)
            {
                pageNumber = 12;
            }
            else if (pageNumber == 10)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 11)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 12)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 13)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 14)
            {
                pageNumber = 21;
            }
            else if (pageNumber == 15)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 16)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 17)
            {
                pageNumber = 19;
            }
            else if (pageNumber == 18)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 19)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 20)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 21)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 22)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 30)
            {
                pageNumber = 31;
            }
            output();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1)
            {
                pageNumber = 2;
            }
            else if (pageNumber == 2)
            {
                hipBreak = chanceMaker.Next(1, 13);
                if (hipBreak == 1)
                {
                    pageNumber = 22;
                }
                else
                {
                    pageNumber = 4;
                }
            }
            else if (pageNumber == 3)
            {
                pageNumber = 5;
                breakfast = true;
            }
            else if (pageNumber == 4)
            {
                pageNumber = 14;
            }
            else if (pageNumber == 5)
            {
                pageNumber = 8;
            }
            else if (pageNumber == 6)
            {
                
                
                
                    pageNumber = 16;
                
            }
            else if (pageNumber == 7)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 8)
            {
                pageNumber = 10;
            }
            else if (pageNumber == 9)
            {
                pageNumber = 13;
            }
            else if (pageNumber == 10)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 11)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 12)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 13)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 14)
            {
                pageNumber = 20;
            }
            else if (pageNumber == 15)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 16)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 17)
            {
                pageNumber = 18;
            }
            else if (pageNumber == 18)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 19)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 20)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 21)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 22)
            {
                pageNumber = 30;
            }
            else if (pageNumber == 30)
            {
                pageNumber = 1;
            }
            output();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pageNumber == 2)
            {
                pageNumber = 5;
                breakfast = true;
            }
            else if (pageNumber == 4)
            {
                pageNumber = 6;
                soufflait = chanceMaker.Next(1, 10);
                if (soufflait > 5)
                {
                    pageNumber = 15;
                }
            }
            output();
        }
        private void output()
        {
            switch (pageNumber)
            {
                case 1:
                    pictureBox.BackgroundImage = Properties.Resources.Bed_Morning;
                    outputLabel.Text = "You wake up, the sun is shining and birds are singing.";
                    outputLabel.Text += $"\nToday is your date! You have to make\n a dessert for this afternoon.";
                    button1.Text = "Stay in bed";
                    button2.Text = "Get up";
                    break;
                case 2:
                    outputLabel.Text = "Best to start your day early, after all there is much to do.";
                    outputLabel.Text = $"\nWhat should you do first?";
                    Refresh();
                    Thread.Sleep(1000);
                    button1.Text = "Get dressed.";
                    button2.Text = "Shower";
                    button3.Visible = true;
                    button3.Enabled = true;
                    button3.Text = "Eat breakfast";
                    break;
                case 3:
                    outputLabel.Text = "You enjoy an extra ten minutes in bed,\nbut you have a lot to do today so you get up.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "Should you eat breakfast?";
                    button1.Text = "No";
                    button2.Text = "Yes";
                    break;
                case 4:
                    pictureBox.BackgroundImage = Properties.Resources.Kitchen;
                    outputLabel.Text = "You throw on some clothes and begin to survey your kitchen";
                    outputLabel.Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "Which dish should you make?";
                    button1.Text = "Brownies";
                    button2.Text = "Nanaimo bars";
                    button3.Visible = true;
                    button3.Enabled = true;
                    button3.Text = "soufflé";
                    break;
                case 5:
                    pictureBox.BackgroundImage = Properties.Resources.breakfast;
                    button3.Visible = false;
                    button3.Enabled = false;
                    outputLabel.Text = "You eat a quick breakfast before continuing your preparations";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "Which dish should you make?";
                    button1.Text = "Brownies";
                    button2.Text = "Parfait";
                    break;
                case 6:
                    button3.Visible = false;
                    button3.Enabled = false;
                    outputLabel.Text = "It seems you have all the ingredients for this highly difficult dessert";
                    Refresh();
                    Thread.Sleep(5000);
                    
                    if (soufflait < 5)
                    {
                        alarm.Play();
                        outputLabel.Text = "The soufflé fell! \nWhat should you do?";
                        button1.Text = "Fake death, flee country";
                        button2.Text = "serve it anyways";
                    }
                    
                    break;
                case 7:
                    pictureBox.BackgroundImage = Properties.Resources.Brownies;
                    outputLabel.Text = "You make brownies for your date, but you do not get a second one.";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 8:
                    outputLabel.Text = "Simple and delicious";
                    outputLabel.Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "Which fruits should you put in it?";
                    button1.Text = "Strawberries, raspberries, blueberries";
                    button2.Text = "Mango, Peach, Banana";
                    break;
                case 9:
                    alarm.Play();
                    outputLabel.Text = "You are out of ingredients! \n You'll have to go to the store";
                    outputLabel.Refresh();
                    Thread.Sleep(3000);
                    alarm.Stop();
                    pictureBox.BackgroundImage = Properties.Resources.wine;
                    outputLabel.Text = "While at store you see some wine, should you buy it?";
                    button1.Text = "yes";
                    button2.Text = "no";
                    break;
                case 10:
                    pictureBox.BackgroundImage = Properties.Resources.Hospital;
                    outputLabel.Text = "you are allergic to bananas, \nand spend the night in the hospital";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 11:
                    pictureBox.BackgroundImage = Properties.Resources.parfait;
                    outputLabel.Text = "Your date goes ok thanks to the perfect parfait, but you do not get a second";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 12:
                    pictureBox.BackgroundImage = Properties.Resources.browniesWine;
                    outputLabel.Text = "You and your date enjoy a bottle of wine and brownies, \nand you make plans for a second";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 13:
                    outputLabel.Text = "Nice warm brownies provide the perfect experience, \nsecond date";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 14:
                    outputLabel.Text = "This classic Canadian dessert should be pretty easy to make";
                    button3.Enabled = false;
                    button3.Visible = false;
                    outputLabel.Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "Should you put hearts on the chocolate?";
                    button1.Text = "No";
                    button2.Text = "Yes";
                    break;
                case 15:
                    pictureBox.BackgroundImage = Properties.Resources.souffle;
                    button3.Visible = false;
                    button3.Enabled = false;
                    outputLabel.Text = "You two share a lovely soufflé, you get a second date.";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 16:
                    pictureBox.BackgroundImage = Properties.Resources.fallen_souffle;
                    outputLabel.Text = "It seems that even a fallen soufflé is impressive,\n and you get a second date thanks to it.";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 17:
                    button3.Visible = false;
                    button3.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.houseFire;
                    outputLabel.Text = "you light your house on fire and take all your cash";
                    outputLabel.Text = $"\nWhere will you go?";
                    button1.Text = "Mexico, by plane";
                    button2.Text = $"Lithuania, \nby boat";
                    break;
                case 18:
                    outputLabel.Text = "You escape to Lithuania and start a new life.";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 19:
                    
                    pictureBox.BackgroundImage = Properties.Resources.airport;
                    outputLabel.Text = "you are arrested at the airport for travelling without a passport.";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 20:
                    pictureBox.BackgroundImage = Properties.Resources.nanaimoHeart;
                    outputLabel.Text = "Your efforts with the nanaimo bars \nwere not unappreciated, you get a second date.";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 21:
                    pictureBox.BackgroundImage = Properties.Resources.nanaimoTwo;
                    
                    outputLabel.Text = $"Your nanaimo bars were not up to the task, \nyou do not get another date.";
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 22:
                    pictureBox.BackgroundImage = Properties.Resources.Bathroom;
                    SoundPlayer shower = new SoundPlayer(Properties.Resources.showerTrim);
                    pictureBox.Refresh();
                    Thread.Sleep(6500);
                    outputLabel.Text = $"You slip in the shower and break your hip \nyou spend the next 2 weeks in the hospital.";
                    pictureBox.BackgroundImage = Properties.Resources.Hospital;
                    button1.Text = "Continue";
                    button2.Text = "Also continue";
                    break;
                case 30:
                    outputLabel.Text = "The End";
                    button1.Text = "finish";
                    button2.Text = "Play again";
                        break;
                case 31:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    outputLabel.Text = "Thanks for Playing";
                    Thread.Sleep(4000);
                    Application.Exit();
                    break;
            }

        }

    }
}
