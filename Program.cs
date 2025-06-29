using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sydno
{
    //Скадовск 10 20 1000 4
    //Orientor2 8 25 1 25 1
    //ЭммануилНобель 9 26 1 1000
    //SalicaFrigo 10 20 1000 -5
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            StringBuilder er = new StringBuilder();
            try
            {             
                using (var sr = new StreamReader("input.txt"))
                {
                    text = sr.ReadToEnd();
                }
                var separators = new char[] { '\r', '\n', ' ' };
                var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                var ships = new Sydno[4];
                
                ships[0] = new Drycargoship(words[0], int.Parse(words[1]), int.Parse(words[2]), double.Parse(words[3]), int.Parse(words[4]));
                ships[1] = new Balker(words[5], int.Parse(words[6]), int.Parse(words[7]), double.Parse(words[8]), int.Parse(words[10]), int.Parse(words[10]));
                ships[2] = new Tanker(words[11], int.Parse(words[12]), int.Parse(words[13]), double.Parse(words[14]), int.Parse(words[15]));
                ships[3] = new Refrigerator(words[16], int.Parse(words[17]), int.Parse(words[18]), double.Parse(words[19]), int.Parse(words[20]));
                for (int i = 0; i < 4; i++)
                {
                    ships[i].Procces();
                    ships[i].ShowStats();
                    ships[i].IncreaseCrew(5);
                    ships[i].TakeCargo(23);
                    ships[i].ShowStats();
                }
                for (int i = 0; i < 4; i++)
                {
                    ships[i].ShowStats();
                }
                Console.WriteLine("!");

                Array.Sort(ships);
                for (int i = 0; i < 4; i++)
                {
                    ships[i].ShowStats();
                }
                Array.Sort(ships, Sydno.NameSort);
                Console.WriteLine("!");
                for (int i = 0; i < 4; i++)
                {
                    ships[i].ShowStats();
                }

                var theships = new List<Tanker>
                    {
                        new Tanker("Pervui", 10, 10, 100, 1),
                        new Tanker("Vtoroi", 20, 20 ,200, 2),
                        new Tanker("Tretiy", 30, 30 ,300, 3),
                        new Tanker("Chetvertui", 40, 40 ,400, 4),
                    };
                theships.Add(new Tanker("ЭммануилНобель", 9, 26, 1, 1000));
                foreach (Tanker tanker in theships)
                {
                    Console.WriteLine(tanker);
                }
                Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&");
                if (theships.Contains(ships[1]))
                {
                    Console.WriteLine("Contains");
                }
                else
                {
                    Console.WriteLine("Not Contains");
                }
                theships.RemoveAt(1);
                theships.Insert(1, new Tanker("ЭммануилНобель2", 9, 26, 1, 1000));
                theships.Reverse();
                foreach (Tanker tanker in theships)
                {
                    Console.WriteLine(tanker);
                }
                Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&");

                var Theships = new SortedSet<Sydno>();
                Theships.Add(ships[0]);
                Theships.Add(ships[1]);
                foreach (var s in Theships)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("*");
                Theships.Remove(ships[0]);
                foreach (var s in Theships)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("&");
                Theships.Clear();
                Theships.Add(ships[2]);
                Theships.Contains(ships[2]);
                Theships.Add(ships[3]);
                Theships.Add(ships[0]);
                Console.WriteLine("В Theships {0} кораблей", Theships.Count());
                foreach (var s in Theships)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("&");
                Console.WriteLine(Theships.First());
                Console.WriteLine(Theships.Last());
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Неправильное название файла, введите новое название:");
                string s = Console.ReadLine();
                using (var sr = new StreamReader(s))
                {
                    text = sr.ReadToEnd();
                }
                Console.ReadKey();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Отказано в доступе к файлу");
            }
            catch (CrewException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка в изменении параметров корабля");
            }
            catch (Exception Error)
            {
                Console.WriteLine("Что-то пошло не так...");
                er.AppendLine(Error.Message);
                Er(er);
            }
            Console.ReadKey();
        }

        private static void Er(StringBuilder er)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                sw.WriteLine(er);
                sw.Close();
            }
        }
    }   
}
