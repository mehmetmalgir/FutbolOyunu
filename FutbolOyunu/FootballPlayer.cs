using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{

    abstract class FootballPlayer
    {
        private static readonly Random r = new Random();

        public FootballPlayer(string fullName, int shirtNumber)
        {
            FullName = fullName;
            ShirtNumber = shirtNumber;
           
        }       

        public string FullName { get; set; }
        public int ShirtNumber { get; set; }

        public int ShortPass
        {
            get
            {
                return GenerateNumber();
            }
        }

        public int Tackling
        {
            get
            {             
                return GenerateNumber();
            }
        }

        public int Shooting
        {
            get
            {
                return GenerateNumber();
            }
        }

        public int Decisions
        {
            get
            {
                return GenerateNumber();
            }
        }

        public int TeamWork
        {
            get
            {
                return GenerateNumber();
            }
        }

        public int Pace
        {
            get
            {
                return GenerateNumber();
            }
        }

        public int Stamina
        {
            get
            {
                return GenerateNumber();
            }
        }

        public int NaturalFitness
        {
            get
            {                
                return GenerateNumber();
            }
        }

        public double GeneralScore()
        {
            double generalScore = 0;
            int[] valueOfProperties = new int[] { ShortPass, Tackling, Shooting, Decisions, TeamWork, Pace, Stamina, NaturalFitness };

            foreach (var item in valueOfProperties)
            {
                Random random = new Random();
                int gRandom = random.Next(10, 41);
                generalScore += (item * gRandom) / 100;
            }

            return generalScore;
        }

        public virtual double PassingPlay()
        {
            int[] baseClValues = new int[] { ShortPass, Decisions, TeamWork };
            double passingPlay = 0;

            foreach (var item in baseClValues)
            {
                Random rr = new Random();
                int ppRandom = rr.Next(20, 31);

                passingPlay += ((item * ppRandom) / 100) + GeneralScore();
            }

            return passingPlay;

        }

        public virtual double TacklingPlay()
        {
            double tacklingPlay = 0;
            return tacklingPlay;
        }

        public virtual double FinishingPlay()
        {
            double finishingPlay = 0;
            return finishingPlay;
        }

        public virtual double SavingPlay()
        {
            double savingPlay = 0;
            return savingPlay;
        }

        public virtual int GenerateNumber() //https://stackoverflow.com/questions/5422141/how-to-generate-a-random-number-in-the-constructor-of-a-class-in-c-sharp
        {            
            return r.Next(50, 91);
        }

    }

}





