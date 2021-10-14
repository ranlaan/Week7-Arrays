using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajale hommikusöögi menüüd
            //programm palub kasutajal teha valikut
            //programm kuvab kasutaja valikut konsoolis

            string[] menu = { "omlett", "pannkoogid", "keedumuna", "neljavilja puder", "singivõileib" };
            Console.WriteLine($"Meie menüüs on {menu.Length} valikut.");

            //menu[4] = "juustuvõileib";
            //menu[3] = "kaerapuder";

            Console.WriteLine("Tänases menüüs: ");

            for (int i = 0; i < menu.Length; i++)
            {
                if(menu[i] == "neljavilja puder")
                {
                    menu[i] = "kaerapuder";
                }

                if(menu[i] == "singivõileib")
                {
                    menu[i] = "juustuvõileib";
                }
                Console.WriteLine(menu[i]);
            }

            Console.WriteLine("Tee oma valik (sisesta nimbrid 1-5): ");
            int choice = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine($"Olete valinud: {menu[choice]}");

            /*foreach(string menuelement in menu)
            {
                Console.WriteLine(menuelement);
            }*/

        }
    }
}
