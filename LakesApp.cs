

using System;

namespace Lakes;

internal class LakesApp
{
    public void Run()
    {
        bool proceed = true;
        while (proceed)
        {
            var p = "./lakes.txt";
            var data2 = GetData2(p);
            Console.WriteLine("Zadejte okres");
            var okres = Console.ReadLine();
            Console.WriteLine("_____________________________");
            int a = 0;
            for (int i = 0; i < data2.Length; i++)
            {
                var line = data2[i].Split('/');


                if (line[4].Trim() == okres)
                {
                    Console.WriteLine($"{line[1]}");
                    
                }
             
                
                //Console.WriteLine(line[2].Max(a => a.Max()));



            }

            Console.WriteLine("_____________________________");
            Console.WriteLine("Chcete pokračovat? (ano/ne)");
            string g = Console.ReadLine();
            if (g == "ano")
            {
                proceed = true;
                Console.WriteLine("_____________________________");
            }
            else proceed = false;
        }

            /*
            bool proceed = true;
            var p = "./lakes.txt";
            var data = GetData(p);
            while (proceed)
            {
                Console.WriteLine("Zadejte jméno rybníka");
                var jmeno = Console.ReadLine();
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[4] == jmeno)
                    {
                        Console.WriteLine($"Tvoje zkurvena věc {data[i]} za {data[i]} Kč.");

                    }
                }


            }
            */
        


    }





        public string[] GetData2(string path)
        {
            var content = File.ReadAllLines(path);
            return content;
        }
        /*
        public Oop[] GetData(string path)
        {
            var content = File.ReadAllLines(path);
            var logs = new Oop[content.Length];

            for (int i = 0; i < content.Length; i++)
            {
                var line = content[i].Split('/');
                var p = new Oop
                {
                    poradi = line[0].Trim(),
                    nazev = line[1].Trim(),
                    rozloha = line[2].Trim(),
                    objem = line[3].Trim(),
                    okres = line[4].Trim(), 
                };
                logs[i] = p;
            }
            return logs;
        }*/
}

