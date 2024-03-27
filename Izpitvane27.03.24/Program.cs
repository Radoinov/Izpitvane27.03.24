using System.Reflection.Metadata.Ecma335;

namespace Izpitvane27._03._24
{
    internal class Program
    {
        static int[] ocenki = new int[26];
        static void Main(string[] args)
        {
            Ocenka();
            PrazniOcenki();
            Console.WriteLine(ocenki);
            ShesticiteVklasa();
            Console.WriteLine(Ocenkite);
            Console.WriteLine(GetGradesHigherThan);
            Console.WriteLine(MoqNomer);
            PrintYourGrade();
            PrintLastElement();
            MiddleAverage();
            Otlichie();
            

        }

        static void Ocenka()
        {
            Console.WriteLine("Vyvedi ocenki na nomerite ot 14 - 26:");
            for (int i = 13; i < 26; i++)
            {
                Console.Write($"Ocenka na nomer {i + 1}: ");
                ocenki[i] = int.Parse(Console.ReadLine());
            }
            return;

        }

        static void PrazniOcenki()
        {
            Console.WriteLine("Prazni ocenki:");
            for (int i = 13; i < ocenki.Length; i++)
            {
                if (ocenki[13] == 0)
                {
                    Console.WriteLine($"Uchenika s nomer {i + 1}");
                }
            }

            return;
        }

        static void ShesticiteVklasa()
        {
            int Shestici = Ocenkite(6);
            Console.WriteLine($"Broq na shesticite v klasa e: {Shestici}");
            
        }

        static int Ocenkite(int grade)
        {
            int count = 0;
            foreach (int g in ocenki)
            {
                if (g == grade)
                {
                    count++;
                }
            }
            return count;

        }

        static List<int> GetGradesHigherThan(int grade)
        {
            List<int> PoGolemi = new List<int>();
            foreach (int grades in ocenki)
            {
                if (grades > grade)
                {
                    PoGolemi.Add(grades);
                }
            }
            return PoGolemi;
        }

        static int MoqNomer()
        {
            Console.WriteLine("Vyvedi tvoq nomer: ");
            return int.Parse(Console.ReadLine());
        }

        static void PrintYourGrade()
        {
            int Moqtnomer = MoqNomer();
            Console.WriteLine($"Ocenkata na moq nomer ({Moqtnomer}): {ocenki[Moqtnomer - 1]}");
        }
        static void PrintLastElement()
        {
            int lastIndex = ocenki.Length - 1;
            Console.WriteLine($"Posledniq element na masiva e: {ocenki[lastIndex]}");
        }

        static void Otlichie() 
        {
            int moqnomer = MoqNomer();
            ocenki[moqnomer - 1] = 6; 
            Console.WriteLine($"Ocenkata na nomer ({moqnomer}) e Otlichen.");
            return;
        }
        static void PrintMiddleAverage()
        {
            double middleAverage = MiddleAverage();
            Console.WriteLine($"srednoaritmetichno e: {middleAverage}");
        }

        static double MiddleAverage()
        {
            int startIndex;
            int count;

            if (ocenki.Length % 2 == 0)
            {
                startIndex = ocenki.Length / 2 - 1;
                count = 2;
            }
            else
            {
                startIndex = ocenki.Length / 2;
                count = 1;
            }

            int sum = 0;
            for (int i = startIndex; i < startIndex + count; i++)
            {
                sum += ocenki[i];
            }

            return (double)sum / count;
        }
    }
}
