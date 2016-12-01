using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public partial class Form1 : Form
    {
        Greyhound[] greyhounds = new Greyhound[4];
        Guy[] guys = new Guy[4];
        private int current_guy;
        private int current_dog;
        Random MyRadomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            lblMinimum.Text = "Minimum bet: "+bettingAmount.Minimum+" bucks";
            init_dogs();
            init_guys();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyRadioButton.Checked)
                {
                    if (guys[i].MyBet.Dog != 1000 && guys[i].MyBet.Dog != current_dog)
                    {
                        guys[i].Cash = guys[i].initial_cash;
                        guys[i].UpdateLabels();
                    }

                    if (guys[i].PlaceBet((int) bettingAmount.Value, (int) dogNumber.Value))
                    {
                        
                        guys[i].Cash -= (int) bettingAmount.Value;
                        guys[i].UpdateLabels();
                    }
                    lblName.Text = guys[i].Name;
                }
            }
        }

        private void init_dogs()
        {
            greyhounds[0] = new Greyhound()
            {
                MyPictureBox = dog1,
                StartingPosition = dog1.Left,
                RacetrackLength = racetrackPictureBox.Width - dog1.Width,
                Radomizer = MyRadomizer
            };
            greyhounds[1] = new Greyhound()
            {
                MyPictureBox = dog2,
                StartingPosition = dog2.Left,
                RacetrackLength = racetrackPictureBox.Width - dog2.Width,
                Radomizer = MyRadomizer
            };
            greyhounds[2] = new Greyhound()
            {
                MyPictureBox = dog3,
                StartingPosition = dog3.Left,
                RacetrackLength = racetrackPictureBox.Width - dog3.Width,
                Radomizer = MyRadomizer
            };
            greyhounds[3] = new Greyhound()
            {
                MyPictureBox = dog4,
                StartingPosition = dog4.Left,
                RacetrackLength = racetrackPictureBox.Width - dog4.Width,
                Radomizer = MyRadomizer
            };
        }

        private void init_guys()
        {
            guys[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                initial_cash = 50,
                MyRadioButton = rdJoe,
                MyLabel = lblJoeBet
            };
            guys[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                initial_cash = 75,
                MyRadioButton = rdBob,
                MyLabel = lblBobBet
            };
            guys[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                initial_cash = 45,
                MyRadioButton = rdAl,
                MyLabel = lblAlBet
            };

            for (int i = 0; i < 3; i++)
            {
                guys[i].PlaceBet(0, 1000);
                guys[i].UpdateLabels();
            }
        }

        private void dogNumber_ValueChanged(object sender, EventArgs e)
        {
            current_dog = (int)dogNumber.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool noOneWin = false;

            for (int i = 0; i < 4; i++)
            {
                if (greyhounds[i].Run())
                {
                    timer1.Stop();
                    
                    for (int j = 0; j < 3; j++)
                    {
                        if (guys[j].MyBet.Dog == (i+1))
                        {
                            noOneWin = true;
                            MessageBox.Show(guys[i].Name+ " won","Race Result");
                            guys[j].Cash += guys[j].MyBet.PayOut(guys[j].MyBet.Dog);
                            guys[j].UpdateLabels();
                        }
                    }
                    if (!noOneWin)
                    {
                        MessageBox.Show("No one wons","Race Result");
                    }
                    return;
                }
            }
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dog1.Left = racetrackPictureBox.Left;
            dog2.Left = racetrackPictureBox.Left;
            dog3.Left = racetrackPictureBox.Left;
            dog4.Left = racetrackPictureBox.Left;

            init_dogs();

            for (int i = 0; i < 3; i++)
            {
                guys[i].MyBet.Dog = 1000;
                guys[i].MyBet.Amount = 0;
                guys[i].MyBet.GetDescription();

                guys[i].UpdateLabels();
            }
        }
    }
}
