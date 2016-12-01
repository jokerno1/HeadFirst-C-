using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Radomizer;

        public bool Run()
        {
            Location += Radomizer.Next(1, 5);
            //            Location += Radomizer.Next(100, 200);

            MyPictureBox.Left = StartingPosition + Location;

            if (MyPictureBox.Right >= MyPictureBox.Parent.Width - MyPictureBox.Width)
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            StartingPosition = 0;
            Location = 0;
        }
    }
}
