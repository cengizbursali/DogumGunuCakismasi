using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1a
{
    class Program
    {
        static Random sayilar = new Random();
        public static int sayiAl()
        {
            Console.WriteLine("Kaç doğum tarihi üretileceğini giriniz:");
            int kisi = Convert.ToInt16(Console.ReadLine());

            return kisi;
        }
        public static string[] sayiUret()
        {
            int gun;
            string[] tarih = { "", "", "" };

            int yil = sayilar.Next(1995, 1998);
            int ay = sayilar.Next(1, 13);

            if (ay == 1 || ay == 3 || ay == 5 || ay == 7 || ay == 8 || ay == 10 || ay == 12)
                gun = sayilar.Next(1, 32);
            else if (ay == 4 || ay == 6 || ay == 9 || ay == 11)
                gun = sayilar.Next(1, 31);
            else if (yil == 1996 && ay == 2)
                gun = sayilar.Next(1, 30);
            else
                gun = sayilar.Next(1, 29);

            tarih[0] = gun.ToString();
            tarih[1] = ay.ToString();
            tarih[2] = yil.ToString();

            return tarih;
        }
        static void Main(string[] args)
        {
            string[] alinan;
            int[,] istatistik = new int[11, 4];
            int gun, ay, yil;

            int[][] dbesyili = new int[12][];
            int[][] daltiyili = new int[12][];
            int[][] dyediyili = new int[12][];

            for (int i = 0; i < 12; i++)
            {
                if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                {
                    dbesyili[i] = new int[31];
                    daltiyili[i] = new int[31];
                    dyediyili[i] = new int[31];
                }
                else if (i == 3 || i == 5 || i == 8 || i == 10 || i == 12)
                {
                    dbesyili[i] = new int[30];
                    daltiyili[i] = new int[30];
                    dyediyili[i] = new int[30];
                }
                else
                {
                    dbesyili[i] = new int[28];
                    daltiyili[i] = new int[29];
                    dyediyili[i] = new int[28];
                }
            }
            int secim;
            do
            {
                Console.WriteLine("50,100,500,1000 kişilik deneyleri görmek için 1'e basınız.");
                Console.WriteLine("Kişi sayısını elle girmek için 2'ye basınız.");
                 secim = Convert.ToInt16(Console.ReadLine());
            } while (secim != 1 && secim != 2);
            if (secim == 1)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\n" + (j + 1) + ".deney için veriler:\n");
                    Console.WriteLine("\n50 kişi için:\n");
                    for (int i = 0; i < 50; i++)
                    {
                        alinan = sayiUret();
                        yil = int.Parse(alinan[2]);
                        ay = int.Parse(alinan[1]);
                        gun = int.Parse(alinan[0]);
                        if (yil == 1995)
                            dbesyili[ay - 1][gun - 1]++;
                        else if (yil == 1996)
                            daltiyili[ay - 1][gun - 1]++;
                        else
                            dyediyili[ay - 1][gun - 1]++;
                    }
                    Console.WriteLine("\n1995 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < dbesyili[k].Length; m++)
                        {
                            Console.Write(dbesyili[k][m] + " ");
                            if (dbesyili[k][m] > 1)
                            {
                                istatistik[j, 0] += dbesyili[k][m] - 1;
                            }
                            dbesyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n1996 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < daltiyili[k].Length; m++)
                        {
                            Console.Write(daltiyili[k][m] + " ");
                            if (daltiyili[k][m] > 1)
                            {
                                istatistik[j, 0] += daltiyili[k][m] - 1;
                            }
                            daltiyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n1997 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < dyediyili[k].Length; m++)
                        {
                            Console.Write(dyediyili[k][m] + " ");
                            if (dyediyili[k][m] > 1)
                            {
                                istatistik[j, 0] += dyediyili[k][m] - 1;
                            }
                            dyediyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\n" + (j + 1) + ".deney için veriler:\n");
                    Console.WriteLine("\n100 kişi için:\n");
                    for (int i = 0; i < 100; i++)
                    {
                        alinan = sayiUret();
                        yil = int.Parse(alinan[2]);
                        ay = int.Parse(alinan[1]);
                        gun = int.Parse(alinan[0]);
                        if (yil == 1995)
                            dbesyili[ay - 1][gun - 1]++;
                        else if (yil == 1996)
                            daltiyili[ay - 1][gun - 1]++;
                        else
                            dyediyili[ay - 1][gun - 1]++;
                    }
                    Console.WriteLine("\n1995 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < dbesyili[k].Length; m++)
                        {
                            Console.Write(dbesyili[k][m] + " ");
                            if (dbesyili[k][m] > 1)
                            {
                                istatistik[j, 1] += dbesyili[k][m] - 1;
                            }
                            dbesyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n1996 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < daltiyili[k].Length; m++)
                        {
                            Console.Write(daltiyili[k][m] + " ");
                            if (daltiyili[k][m] > 1)
                            {
                                istatistik[j, 1] += daltiyili[k][m] - 1;
                            }
                            daltiyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n1997 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < dyediyili[k].Length; m++)
                        {
                            Console.Write(dyediyili[k][m] + " ");
                            if (dyediyili[k][m] > 1)
                            {
                                istatistik[j, 1] += dyediyili[k][m] - 1;
                            }
                            dyediyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\n" + (j + 1) + ".deney için veriler:\n");
                    Console.WriteLine("\n500 kişi için:\n");
                    for (int i = 0; i < 500; i++)
                    {
                        alinan = sayiUret();
                        yil = int.Parse(alinan[2]);
                        ay = int.Parse(alinan[1]);
                        gun = int.Parse(alinan[0]);
                        if (yil == 1995)
                            dbesyili[ay - 1][gun - 1]++;
                        else if (yil == 1996)
                            daltiyili[ay - 1][gun - 1]++;
                        else
                            dyediyili[ay - 1][gun - 1]++;
                    }
                    Console.WriteLine("\n1995 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < dbesyili[k].Length; m++)
                        {
                            Console.Write(dbesyili[k][m] + " ");
                            if (dbesyili[k][m] > 1)
                            {
                                istatistik[j, 2] += dbesyili[k][m] - 1;
                            }
                            dbesyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n1996 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < daltiyili[k].Length; m++)
                        {
                            Console.Write(daltiyili[k][m] + " ");
                            if (daltiyili[k][m] > 1)
                            {
                                istatistik[j, 2] += daltiyili[k][m] - 1;
                            }
                            daltiyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n1997 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < dyediyili[k].Length; m++)
                        {
                            Console.Write(dyediyili[k][m] + " ");
                            if (dyediyili[k][m] > 1)
                            {
                                istatistik[j, 2] += dyediyili[k][m] - 1;
                            }
                            dyediyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\n" + (j + 1) + ".deney için veriler:\n");
                    Console.WriteLine("\n1000 kişi için:\n");
                    for (int i = 0; i < 1000; i++)
                    {
                        alinan = sayiUret();
                        yil = int.Parse(alinan[2]);
                        ay = int.Parse(alinan[1]);
                        gun = int.Parse(alinan[0]);
                        if (yil == 1995)
                            dbesyili[ay - 1][gun - 1]++;
                        else if (yil == 1996)
                            daltiyili[ay - 1][gun - 1]++;
                        else
                            dyediyili[ay - 1][gun - 1]++;
                    }
                    Console.WriteLine("\n1995 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < dbesyili[k].Length; m++)
                        {
                            Console.Write(dbesyili[k][m] + " ");
                            if (dbesyili[k][m] > 1)
                            {
                                istatistik[j, 3] += dbesyili[k][m] - 1;
                            }
                            dbesyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n1996 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < daltiyili[k].Length; m++)
                        {
                            Console.Write(daltiyili[k][m] + " ");
                            if (daltiyili[k][m] > 1)
                            {
                                istatistik[j, 3] += daltiyili[k][m] - 1;
                            }
                            daltiyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n1997 yılı için:\n");
                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < dyediyili[k].Length; m++)
                        {
                            Console.Write(dyediyili[k][m] + " ");
                            if (dyediyili[k][m] > 1)
                            {
                                istatistik[j, 3] += dyediyili[k][m] - 1;
                            }
                            dyediyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (istatistik[i, j] == istatistik[10, j])
                        {
                            istatistik[i, j] = istatistik[i, j] / 10;
                            continue;
                        }
                        istatistik[10, j] += istatistik[i, j];
                    }
                }
                Console.WriteLine("\nİSTATİSTİK EKRANI:");
                Console.WriteLine("Doğum tarihleri 3 sene aralığında oluşturulursa..\n");
                Console.WriteLine("\nn=50\tn=100\tn=500\tn=1000\n");
                for (int i = 0; i < 11; i++)
                {
                    if (i == 10)
                        Console.WriteLine("\n---------------------------------->ORTALAMA:");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(istatistik[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nBütün doğum tarihleri 1996'da oluşturulursa..\n");
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        istatistik[i, j] = 0;
                    }
                }

                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\n" + (j + 1) + ".deney için veriler:\n");
                    Console.WriteLine("\n50 kişi için:\n");
                    for (int i = 0; i < 50; i++)
                    {
                        alinan = sayiUret();
                        ay = int.Parse(alinan[1]);
                        gun = int.Parse(alinan[0]);

                        daltiyili[ay - 1][gun - 1]++;
                    }

                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < daltiyili[k].Length; m++)
                        {
                            Console.Write(daltiyili[k][m] + " ");
                            if (daltiyili[k][m] > 1)
                            {
                                istatistik[j, 0] += daltiyili[k][m] - 1;
                            }
                            daltiyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\n" + (j + 1) + ".deney için veriler:\n");
                    Console.WriteLine("\n100 kişi için:\n");
                    for (int i = 0; i < 100; i++)
                    {
                        alinan = sayiUret();
                        ay = int.Parse(alinan[1]);
                        gun = int.Parse(alinan[0]);

                        daltiyili[ay - 1][gun - 1]++;
                    }

                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < daltiyili[k].Length; m++)
                        {
                            Console.Write(daltiyili[k][m] + " ");
                            if (daltiyili[k][m] > 1)
                            {
                                istatistik[j, 1] += daltiyili[k][m] - 1;
                            }
                            daltiyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\n" + (j + 1) + ".deney için veriler:\n");
                    Console.WriteLine("\n500 kişi için:\n");
                    for (int i = 0; i < 500; i++)
                    {
                        alinan = sayiUret();
                        ay = int.Parse(alinan[1]);
                        gun = int.Parse(alinan[0]);

                        daltiyili[ay - 1][gun - 1]++;
                    }

                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < daltiyili[k].Length; m++)
                        {
                            Console.Write(daltiyili[k][m] + " ");
                            if (daltiyili[k][m] > 1)
                            {
                                istatistik[j, 2] += daltiyili[k][m] - 1;
                            }
                            daltiyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\n" + (j + 1) + ".deney için veriler:\n");
                    Console.WriteLine("\n1000 kişi için:\n");
                    for (int i = 0; i < 1000; i++)
                    {
                        alinan = sayiUret();
                        ay = int.Parse(alinan[1]);
                        gun = int.Parse(alinan[0]);

                        daltiyili[ay - 1][gun - 1]++;
                    }

                    for (int k = 0; k < 12; k++)
                    {
                        for (int m = 0; m < daltiyili[k].Length; m++)
                        {
                            Console.Write(daltiyili[k][m] + " ");
                            if (daltiyili[k][m] > 1)
                            {
                                istatistik[j, 3] += daltiyili[k][m] - 1;
                            }
                            daltiyili[k][m] = 0;
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (istatistik[i, j] == istatistik[10, j])
                        {
                            istatistik[i, j] = istatistik[i, j] / 10;
                            continue;
                        }
                        istatistik[10, j] += istatistik[i, j];
                    }
                }
                Console.WriteLine("\nn=50\tn=100\tn=500\tn=1000\n");
                for (int i = 0; i < 11; i++)
                {
                    if (i == 10)
                        Console.WriteLine("\n---------------------------------->ORTALAMA:");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(istatistik[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else if (secim == 2)
            {
                int kisi = sayiAl();

                for (int i = 0; i < kisi; i++)
                {
                    alinan = sayiUret();
                    Console.WriteLine("\n" + alinan[0] + "." + alinan[1] + "." + alinan[2]);
                }
            }

            Console.ReadLine();
        }
    }
}