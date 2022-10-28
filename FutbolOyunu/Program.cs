using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Takım için 1 GoalKeeper, 4 Defender, 6 Midfielder, 3 Attacker Oluşturulacak!!! (taktiklere göre diziden çekilecek)

            GoalKeeper gkTeam1 = new GoalKeeper("Berkay", 30);

            Defender df1Team1 = new Defender("Ahmet", 25);
            Defender df2Team1 = new Defender("Salih", 26);
            Defender df3Team1 = new Defender("Tehtap", 27);
            Defender df4Team1 = new Defender("Ömer", 28);

            Midfielder mf1Team1 = new Midfielder("Hüseyin", 58);
            Midfielder mf2Team1 = new Midfielder("Onur", 59);
            Midfielder mf3Team1 = new Midfielder("Türkel", 60);
            Midfielder mf4Team1 = new Midfielder("Hasan", 61);
            Midfielder mf5Team1 = new Midfielder("Arjin", 62);
            Midfielder mf6Team1 = new Midfielder("Durukan", 63);

            Attacker at1Team1 = new Attacker("Kemal", 66);
            Attacker at2Team1 = new Attacker("Burak", 67);
            Attacker at3Team1 = new Attacker("Talas", 68);

            // 1. Takım Oluşturuldu.

            //-----------------------------------------------------------------------------//

            // 2. Takım için 1 GoalKeeper, 4 Defender, 6 Midfielder, 3 Attacker Oluşturulacak!!! (taktiklere göre diziden çekilecek)

            GoalKeeper gkTeam2 = new GoalKeeper("Rüştü", 30);

            Defender df1Team2 = new Defender("Levent", 25);
            Defender df2Team2 = new Defender("Sergen", 26);
            Defender df3Team2 = new Defender("Tekin", 27);
            Defender df4Team2 = new Defender("Metin", 28);

            Midfielder mf1Team2 = new Midfielder("Tümer", 58);
            Midfielder mf2Team2 = new Midfielder("Hikmet", 59);
            Midfielder mf3Team2 = new Midfielder("Halit", 60);
            Midfielder mf4Team2 = new Midfielder("Talip", 61);
            Midfielder mf5Team2 = new Midfielder("İbrahim", 62);
            Midfielder mf6Team2 = new Midfielder("Gökhan", 63);

            Attacker at1Team2 = new Attacker("Cem", 66);
            Attacker at2Team2 = new Attacker("Cenk", 67);
            Attacker at3Team2 = new Attacker("Mehmet", 68);

            // 2. Takım Oluşturuldu.

            // Girilen taktiğe göre takımlara ilişkin dizi oluşturulacak!!

            // 1. Takım

            FootballPlayer[] team1 = new FootballPlayer[] { gkTeam1, df1Team1, df2Team1, df3Team1, df4Team1, mf1Team1, mf2Team1, mf3Team1, mf4Team1, mf5Team1, mf6Team1, at1Team1, at2Team1, at3Team1 };

            FootballPlayer[] team1T442 = new FootballPlayer[] { gkTeam1, df1Team1, df2Team1, df3Team1, df4Team1, mf1Team1, mf2Team1, mf3Team1, mf4Team1, at1Team1, at2Team1 };
            FootballPlayer[] team1T433 = new FootballPlayer[] { gkTeam1, df1Team1, df2Team1, df3Team1, df4Team1, mf1Team1, mf2Team1, mf3Team1, at1Team1, at2Team1, at3Team1 };
            FootballPlayer[] team1T343 = new FootballPlayer[] { gkTeam1, df1Team1, df2Team1, df3Team1, mf1Team1, mf2Team1, mf3Team1, mf4Team1, at1Team1, at2Team1, at3Team1 };
            FootballPlayer[] team1T352 = new FootballPlayer[] { gkTeam1, df1Team1, df2Team1, df3Team1, mf1Team1, mf2Team1, mf3Team1, mf4Team1, mf5Team1, at1Team1, at2Team1 };
            FootballPlayer[] team1T361 = new FootballPlayer[] { gkTeam1, df1Team1, df2Team1, df3Team1, mf1Team1, mf2Team1, mf3Team1, mf4Team1, mf5Team1, mf6Team1, at1Team1 };

            // Girilen taktiğe göre takım 1 oluşturuldu.

            // 2. Takım

            FootballPlayer[] team2 = new FootballPlayer[] { gkTeam2, df1Team2, df2Team2, df3Team2, df4Team2, mf1Team2, mf2Team2, mf3Team2, mf4Team2, mf5Team2, mf6Team2, at1Team2, at2Team2, at3Team2 };

            FootballPlayer[] team2T442 = new FootballPlayer[] { gkTeam2, df1Team2, df2Team2, df3Team2, df4Team2, mf1Team2, mf2Team2, mf3Team2, mf4Team2, at1Team2, at2Team2 };
            FootballPlayer[] team2T433 = new FootballPlayer[] { gkTeam2, df1Team2, df2Team2, df3Team2, df4Team2, mf1Team2, mf2Team2, mf3Team2, at1Team2, at2Team2, at3Team2 };
            FootballPlayer[] team2T343 = new FootballPlayer[] { gkTeam2, df1Team2, df2Team2, df3Team2, mf1Team2, mf2Team2, mf3Team2, mf4Team2, at1Team2, at2Team2, at3Team2 };
            FootballPlayer[] team2T352 = new FootballPlayer[] { gkTeam2, df1Team2, df2Team2, df3Team2, mf1Team2, mf2Team2, mf3Team2, mf4Team2, mf5Team2, at1Team2, at2Team2 };
            FootballPlayer[] team2T361 = new FootballPlayer[] { gkTeam2, df1Team2, df2Team2, df3Team2, mf1Team2, mf2Team2, mf3Team2, mf4Team2, mf5Team2, mf6Team2, at1Team2 };

            // Girilen taktiğe göre takım 2 oluşturuldu.          

            FootballPlayer[] takim1 = new FootballPlayer[11];
            FootballPlayer[] takim2 = new FootballPlayer[11];

            Console.WriteLine("1. Takım İçin Taktiğinizi Seçiniz : ");
            Console.WriteLine("1 --> 4-4-2");
            Console.WriteLine("2 --> 4-3-3");
            Console.WriteLine("3 --> 3-4-3");
            Console.WriteLine("4 --> 3-5-2");
            Console.WriteLine("5 --> 3-6-1");

            Console.WriteLine("---------------------------------");
            int takim1Taktik = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            Console.WriteLine("2. Takım İçin Taktiğinizi Seçiniz : ");
            Console.WriteLine("1 --> 4-4-2");
            Console.WriteLine("2 --> 4-3-3");
            Console.WriteLine("3 --> 3-4-3");
            Console.WriteLine("4 --> 3-5-2");
            Console.WriteLine("5 --> 3-6-1");
            Console.WriteLine("---------------------------------");
            int takim2Taktik = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            Console.WriteLine("1. Takımın Adını Giriniz : ");
            string takim1Adi = Console.ReadLine().ToUpper();
            Console.WriteLine("2. Takımın Adını Giriniz : ");
            string takim2Adi = Console.ReadLine().ToUpper();
            Console.WriteLine("---------------------------------");

            // Aşağıdaki vereceğim genel koşulu yazması rahat olsun diye taktikleri int olarak tanımladım...            

            if ((takim1Taktik >= 1 && takim1Taktik <= 5) && (takim2Taktik >= 1 && takim2Taktik <= 5))
            {

                if (takim1Taktik == 1)
                    takim1 = team1T442;
                else if (takim1Taktik == 2)
                    takim1 = team1T433;
                else if (takim1Taktik == 3)
                    takim1 = team1T343;
                else if (takim1Taktik == 4)
                    takim1 = team1T352;
                else if (takim1Taktik == 5)
                    takim1 = team1T361;

                if (takim2Taktik == 1)
                    takim2 = team2T442;
                else if (takim2Taktik == 2)
                    takim2 = team2T433;
                else if (takim2Taktik == 3)
                    takim2 = team2T343;
                else if (takim2Taktik == 4)
                    takim2 = team2T352;
                else if (takim2Taktik == 5)
                    takim2 = team2T361;

                Console.WriteLine("Seçiminize Göre Takımlar Oluşturuluyor...");
                Console.WriteLine(" ");

                Thread.Sleep(2000); // girilen milisaniye kadar askıya alıyor!!! parantez içine int değer olarak milisaniye yazılır!!! 
                /* https://learn.microsoft.com/tr-tr/dotnet/api/system.threading.thread.sleep?view=net-6.0 */
                // SpinWait ile farkını öğren!!!! (kullanım alanı anlaşılmadı...)

                Console.WriteLine($"{takim1Adi} Takımının Oyuncuları : ");
                Console.WriteLine(" ");
                foreach (var item in takim1)
                    Console.WriteLine($"İsim : {item.FullName} - Forma Numarası : {item.ShirtNumber} + {item.FinishingPlay()} + {item.GeneralScore()} + {item.PassingPlay()} + {item.TacklingPlay()}");

                Console.WriteLine("------------------------------------");

                Console.WriteLine($"{takim2Adi} Takımının Oyuncuları : ");
                Console.WriteLine(" ");
                foreach (var item in takim2)
                    Console.WriteLine($"İsim : {item.FullName} - Forma Numarası : {item.ShirtNumber}+ {item.FinishingPlay()} + {item.GeneralScore()} + {item.PassingPlay()}+ {item.TacklingPlay()}");

                Console.WriteLine("------------------------------------");

                Console.WriteLine(" ");
                Console.WriteLine("...MAÇ BAŞLIYOR...");
                Console.WriteLine(" ");

                Thread.Sleep(3000);
                int team1Score = 0;
                int team2Score = 0;

                Stopwatch s = new Stopwatch(); // döngünün 120 saniye boyunca dönmesi için
                s.Start();
                while (s.Elapsed < TimeSpan.FromSeconds(120))
                {
                    for (; ; )
                    {
                        Random random1 = new Random();
                        int r1 = random1.Next(1, 11);
                        int r2 = random1.Next(1, 11);
                        int r3 = random1.Next(1, 11);

                        if ((r1 == r3) || (r1 == r2))
                        {
                            r3 = random1.Next(1, 11);
                            r2 = random1.Next(1, 11);
                        }

                        if (takim1[r1].PassingPlay() > takim2[r2].TacklingPlay())
                        {
                            Console.WriteLine($"{takim1[r1].FullName} atağa çıktı...");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{takim1[r1].FullName} ile {takim2[r2].FullName} karşı karşıya");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{takim1[r1].FullName} topu kazandı...");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{takim1[r1].FullName}, {takim1[r3].FullName} oyuncusuna pas verdi...");
                            Thread.Sleep(2000);

                            if (takim1[r3].PassingPlay() > takim2[r1].TacklingPlay())
                            {
                                Console.WriteLine($"{takim1[r3].FullName} atağa çıktı...");
                                Thread.Sleep(2000);
                                Console.WriteLine($"{takim1[r3].FullName} ile {takim2[r1].FullName} karşı karşıya");
                                Thread.Sleep(2000);
                                Console.WriteLine($"{takim1[r3].FullName} topu kazandı...");
                                Thread.Sleep(2000);
                                Console.WriteLine($"{takim1[r3].FullName}, {takim1[r2].FullName} oyuncusuna pas verdi...");
                                Thread.Sleep(2000);

                                if (takim1[r2].FinishingPlay() > takim2[0].SavingPlay())
                                {
                                    Console.WriteLine($"GOOOOOOOOLLLLLLLLLL!!!!!!!!!!! - {takim1[r2].FullName} - {takim1[r2].ShirtNumber}");
                                    Thread.Sleep(2000);
                                    team1Score++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{takim1[r2].FullName} golü kaçırdı. {takim2[0].FullName} kurtardı... ");
                                    Thread.Sleep(2000);
                                    break;
                                }

                            }
                            else
                            {
                                Console.WriteLine($"{takim1[r3].FullName} topu kaybetti...");
                            }

                            break;
                        }

                        if (takim2[r2].PassingPlay() > takim1[r1].TacklingPlay())
                        {
                            Thread.Sleep(2000);
                            Console.WriteLine($"{takim1[r1].FullName} ile {takim2[r2].FullName} karşı karşıya");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{takim2[r2].FullName} topu kazandı...");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{takim2[r2].FullName}, {takim2[r3].FullName} oyuncusuna pas verdi...");
                            Thread.Sleep(2000);

                            if (takim2[r3].PassingPlay() > takim1[r2].TacklingPlay())
                            {
                                Console.WriteLine($"{takim2[r3].FullName} atağa çıktı...");
                                Thread.Sleep(2000);
                                Console.WriteLine($"{takim2[r3].FullName} ile {takim1[r2].FullName} karşı karşıya");
                                Thread.Sleep(2000);
                                Console.WriteLine($"{takim2[r3].FullName} topu kazandı...");
                                Thread.Sleep(2000);
                                Console.WriteLine($"{takim2[r3].FullName}, {takim2[r1].FullName} oyuncusuna pas verdi...");
                                Thread.Sleep(2000);

                                if (takim2[r1].FinishingPlay() > takim1[0].SavingPlay())
                                {
                                    Console.WriteLine($"GOOOOOOOOLLLLLLLLLL!!!!!!!!!!! - {takim2[r1].FullName} - {takim2[r1].ShirtNumber}");
                                    Thread.Sleep(2000);
                                    team2Score++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{takim2[r1].FullName} golü kaçırdı. {takim1[0].FullName} kurtardı... ");
                                    Thread.Sleep(2000);
                                    break;
                                }

                            }
                            else
                            {
                                Console.WriteLine($"{takim2[r3].FullName} topu kaybetti...");
                            }

                            break;
                        }
                    }
                }
                s.Stop();
                Console.WriteLine(" ");
                Console.WriteLine("...Maç Sona Erdi...");
                Console.WriteLine(" ");
                Console.WriteLine("MAÇ SONUCU");
                Console.WriteLine($"{takim1Adi} : {team1Score} - {takim2Adi} : {team2Score}");
            }
            else
            {
                Console.WriteLine("Eksik veya Hatalı Bir Giriş Yaptınız!!!");
            }

            Console.ReadLine();
        }
    }
}
