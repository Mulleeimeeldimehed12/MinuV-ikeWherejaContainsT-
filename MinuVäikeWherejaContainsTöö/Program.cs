using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        triangle();

        List<string> cities = new List<string>
        {
            "New York",
            "London",
            "Pariis",
            "Tokyo",
            "Berliin",
            "Sidney"
        };

        string searchTerm = "i";

        IEnumerable<string> filteredCities = cities.Where(city => city.Contains(searchTerm));

        foreach (string city in filteredCities)
        {
            Console.WriteLine(city);

        }

    }

    static void triangle()
    {
        int i, j, rows;

        Console.WriteLine("Numbri püramiid");

        Console.WriteLine("Sisesta ridade arv");

        rows = Convert.ToInt32(Console.ReadLine());


        for (i = 0; i <= rows; i++)
        {
            for (j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (j = 1; j <= 2 * i - 1; j++)
            {
                //Console.Write("{0} ", t++);
                Console.Write("*"); //kui paned selle, siis saad püramiidi
            }
            Console.Write("\n");
        }

        for (i = rows - 1; i >= 1; i--)
        {
            for (j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kui url on vale, siis annab" +
                "veateate. Kui on õige, siis ütleb, " +
                "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            

            string wrongPath = "V:/Users/opilane/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/opilane/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");


            }
        }
    }
}
       