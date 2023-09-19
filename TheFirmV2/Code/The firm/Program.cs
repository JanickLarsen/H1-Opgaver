using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_firm.Model;

namespace The_firm
{
    internal class Program
    {
        private static string[] Names = {"Ole", "Jasmin", "Peter", "Nicklas", "Janick", "jasper", "Jonas", "Matias", "lærke"};
        private static Random rng = new Random();
        static void Main()
        {
            CEO ceo = new CEO(GetRandomName(), rng.Next(50000, 250000), "12434123-1234", "12345678", "Test@gmail.com", true);
            CFO cfo = new CFO(GetRandomName(), rng.Next(20000, 150000), "12434123-1234", "12345678", "Test@gmail.com", true);
            COO coo = new COO(GetRandomName(), rng.Next(20000, 150000), "12434123-1234", "12345678", "Test@gmail.com", true);

            HR hr = new HR(GetRandomName(), rng.Next(25000, 120000), "12434123-1234", "12345678", "Test@gmail.com", true);
            Administration admin = new Administration(GetRandomName(), rng.Next(35000, 140000), "12434123-1234", "12345678", "Test@gmail.com", true);

            for (int i = 0; i < 2; i++)
            {
                coo.Boss.Add(MakeTeam());
                cfo.Boss.Add(MakeTeam());
            }

            foreach (Boss boss in coo.Boss) 
            {
                Console.WriteLine("Boss:");
                Console.WriteLine(boss.ToString());
                foreach (Leader leader in boss.Leaders)
                {
                    Console.WriteLine("Leader:");
                    Console.WriteLine(leader.ToString());
                    foreach (Worker worker in leader.Workers)
                    {
                        Console.WriteLine("worker:");
                        Console.WriteLine(worker.ToString());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static Boss MakeTeam()
        {
            Boss boss = new Boss(GetRandomName(), rng.Next(10000,150000),"12434123-1234", "12345678", "Test@gmail.com");
            for (int i = 0; i < 3; i++)
            {
                Leader leader = new Leader(GetRandomName(), rng.Next(10000, 150000), "12434123-1234", "Test@gmail.com");
                for (int j = 0; j < 6; j++)
                {
                    Worker worker = new Worker(GetRandomName(), rng.Next(10000, 150000), "12434123-1234");
                    leader.Workers.Add(worker);
                }
                boss.Leaders.Add(leader);
            }
            return boss;
        }
        static string GetRandomName()
        {
            return Names[rng.Next(0, Names.Length)];
        }
    }
}
