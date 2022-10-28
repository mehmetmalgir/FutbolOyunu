using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    internal class Midfielder : FootballPlayer
    {
        private static readonly Random r = new Random();
        public Midfielder(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
           
        }

        public int Technique
        {
            get 
            {  
                return GenerateNumber(); 
            }
        }

        public int LongPass
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public int FirstTouch
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public int Positioning
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public override double PassingPlay()
        {
            int[] mValues = new int[] { Technique, LongPass, FirstTouch, Positioning };
            double passingPlay = 0;

            foreach(var item in mValues)
            {
                Random rM = new Random();
                int midRandom = rM.Next(30, 61);

                passingPlay += ((item * midRandom) / 100) + GeneralScore();
            }

            return passingPlay;
        }

        public override double TacklingPlay()
        {
            int[] tpMid = new int[] {Tackling,Stamina,NaturalFitness };
            double tacklingPlay = 0;

            foreach(var item in tpMid)
            {
                Random rTpMid = new Random();
                int rTpMidValue = rTpMid.Next(20, 31);
                tacklingPlay += ((item * rTpMidValue) / 100) + GeneralScore();
            }

            return tacklingPlay;
        }

        public override double FinishingPlay()
        {
            int[] bValues = new int[] { Shooting, Pace, TeamWork };
            double finishingPlay = 0;

            foreach (var item in bValues)
            {
                Random fRandom = new Random();
                int f = fRandom.Next(10, 21);
                finishingPlay += ((item * f) / 100) + GeneralScore();
            }

            return finishingPlay;
        }

        public override int GenerateNumber()
        {
            return r.Next(50, 81);
        }

    }
}
