using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    internal class Defender : FootballPlayer
    {
        private static readonly Random r = new Random();
        public Defender(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {            

        }        

        public int Strength
        {
            get 
            {
                return GenerateNumber();
            }
        }

        public int Marking
        {
            get 
            {
                return GenerateNumber();
            }
        }

        public int Heading
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public int Jumping
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public override double TacklingPlay()
        {
            int[] valueOfDefender = new int[] { Strength, Marking, Heading, Jumping };
            Random rTack = new Random();
            int rTackling = rTack.Next(30, 61);
            double tacklingPlay = 0;

            foreach (var item in valueOfDefender)
            {
                tacklingPlay += ((item * rTackling) / 100) + GeneralScore();
            }

            return tacklingPlay;
        }

        // passingplay metodu virtual olarak base sınıftan aynen alındığı için yazılmadı.

        public override double FinishingPlay()
        {
            int[] bValues = new int[] { Shooting, Pace, TeamWork };            
            double finishingPlay = 0;

            foreach(var item in bValues)
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
