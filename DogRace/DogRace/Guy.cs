using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    class Guy
    {
        public string Name; // person's name
        public Bet MyBet; // Bet instance
        public int Cash; // current cash amount
        public int initial_cash; // initial cash amount : necessary when guys change dog number, it should set initial cash amount

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = MyBet.GetDescription();
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet()
            {
                Amount = BetAmount,
                Dog = DogToWin,
                Bettor = this
            };
            if (Cash >= MyBet.Amount)
            {
                return true;
            }
            return false;
        }
    }
}
