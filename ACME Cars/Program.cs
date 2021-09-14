using System;
using System.Collections.Generic;

namespace ACME_Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>();

            bool loop = true;
            do
            {
                Console.WriteLine("Välj mellan:\n X\tAvsluta\n N\tLägg till en bil\n E\t Ändra på en bil\n D\tTa bort en bil");
                string val = Console.ReadLine();
                
                Console.WriteLine();

                switch (val)
                {
                    case "X":
                        loop = false;
                        break;

                    case "N":
                        Console.Write("Regnummer: ");
                        string regNummer = Console.ReadLine();
                        Console.Write("Tillverkare: ");
                        string maker = Console.ReadLine();
                        Console.Write("Modell: ");
                        string model = Console.ReadLine();
                        Console.Write("Färj: ");
                        string color = Console.ReadLine();

                        Cars.Add(new Car { regNummer = regNummer, maker = maker, model = model, color = color });
                        break;

                    case "E":

                        Console.Write("Ange registreringsniumret för den du vill ändra på: ");
                        string chose = Console.ReadLine();
                        int index = getIndex(chose);


                        //while (true)
                        //{


                            Console.Write("Vad vill du ändra på: ");
                            string change = Console.ReadLine();
                            switch (change)
                            {
                                case "regnummer":
                                    Console.Write($"Ändra {Cars[index].regNummer} till: ");
                                    Cars[index].regNummer = Console.ReadLine();
                                    break;
                                case "tillverkare":
                                    Console.Write($"Ändra {Cars[index].maker} till: ");
                                    Cars[index].maker = Console.ReadLine();
                                    break;
                                case "modell":
                                    Console.Write($"Ändra {Cars[index].model} till: ");
                                    Cars[index].model = Console.ReadLine();
                                    break;
                                case "color":
                                    Console.Write($"Ändra {Cars[index].color} till: ");
                                    Cars[index].color = Console.ReadLine();
                                    break;
                                case "allt":
                                    Console.Write($"Ändra {Cars[index].regNummer} till: ");
                                    Cars[index].regNummer = Console.ReadLine();

                                    Console.Write($"Ändra {Cars[index].maker} till: ");
                                    Cars[index].maker = Console.ReadLine();

                                    Console.Write($"Ändra {Cars[index].model} till: ");
                                    Cars[index].model = Console.ReadLine();

                                    Console.Write($"Ändra {Cars[index].color} till: ");
                                    Cars[index].color = Console.ReadLine();
                                    break;
                                default:
                                    break;
                            }
                        //}
                        break;

                    case "D":
                        Console.Write("Ange Registreringsnumret på den bil du vill ta bort: ");
                        string choise = Console.ReadLine();
                        index = getIndex(choise);

                        Cars.RemoveAt(index);

                        break;

                    case "S":
                        foreach (var item in Cars)
                        {
                            Console.WriteLine($"{item.regNummer} \t {item.maker} \t {item.model} \t {item.color}\n");
                        }

                        break;

                    default:
                        Console.WriteLine("Ej giltig val, testa igen.\n");
                        break;
                }




            } while (loop);

            int getIndex(string find)
            {
                int found = -1;

                for (int i = 0; i < Cars.Count; i++)
                {
                    if (Cars[i].regNummer == find)
                    {
                        found = i;
                    }
                }
                return found;
            }
        }
    }




    class Car
    {
        public string regNummer { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public string color { get; set; }
    }

}
