using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FutbolOyunu
{
    internal class GoalKeeper : FootballPlayer
    {
        private static readonly Random r = new Random();
        public GoalKeeper(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            FullName = fullName;
            ShirtNumber = shirtNumber;       

        }

        public int Handling
        {
            get
            {
                return GenerateNumber(); 
            }
        }

        public int Reflexes
        {
            get
            {
                return GenerateNumber();
            }
        }

        public int AerialAbility
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public int OneAndOnes
        {
            get 
            {
                return GenerateNumber(); 
            }
        }

        public override double SavingPlay()
        {
            int[] valueOfGoallKeeper = new int[] { Handling, Reflexes, AerialAbility, OneAndOnes };
            double savigPlay = 0;

            foreach (var item in valueOfGoallKeeper)
            {
                Random rr = new Random();
                int goadlKeeperRandom = rr.Next(30, 41);

                savigPlay += ((item * goadlKeeperRandom) / 100) + GeneralScore();
            }

            return savigPlay;
        }

        // passingplay metodu virtual olarak base sınıftan aynen alındığı için yazılmadı.

        public override int GenerateNumber()
        {
            return r.Next(60, 101);
        }

    }
}
