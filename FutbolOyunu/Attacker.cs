using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{    
    internal class Attacker : FootballPlayer
    {
        private static readonly Random r = new Random();
        public Attacker(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            
        }               

        public int Finishing
        {
            get 
            { 
                return GenerateNumber(); 
            }
        }

        public int Dribbling
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public int OffTheBall
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public int Acceleration
        {
            get 
            {
                return GenerateNumber();
            }
        }


        public override double FinishingPlay()
        {
            int[] attacValue = new int[] { Finishing, Dribbling, OffTheBall, Acceleration };
            double finishingPlay = 0;

            foreach (var item in attacValue)
            {
                Random aR = new Random();
                int atackRandom = aR.Next(30, 61);
                finishingPlay += ((item * atackRandom) / 100) + GeneralScore();
            }

            return finishingPlay;
        }

        // passingplay metodu virtual olarak base sınıftan aynen alındığı için yazılmadı.

        public override double TacklingPlay()
        {
            int[] tpAttac = new int[] { Tackling, Stamina, NaturalFitness };
            double tacklingPlay = 0;

            foreach (var item in tpAttac)
            {
                Random rTpMid = new Random();
                int rTpMidValue = rTpMid.Next(10, 21);
                tacklingPlay += ((item * rTpMidValue) / 100) + GeneralScore();
            }

            return tacklingPlay;
        }

        public override int GenerateNumber()
        {
            return r.Next(50, 81);
        }

    }
}
