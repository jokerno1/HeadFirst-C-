using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    class Bet
    {
        public int Amount; // Betting amount
        public int Dog; // dog number
        public Guy Bettor;

        public string GetDescription()
        {
            if (Amount > 0)
            {
                return Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            }
            return Bettor.Name + " hasn't placed a bet";
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
