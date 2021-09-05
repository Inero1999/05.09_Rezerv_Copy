using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _05._09_Rezerv_Kopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash f = new Flash();
           // f.GetInfo();
            f.name = "Flash";
            f.model = "Samsung";
            f.volume = 32;            
            f.GetInfo();
            f.Copy();
            WriteLine($"Свободный объем памяти на устройстве {f.volume} Гб. ");
            WriteLine($"Для копирования {f.copyMemory} Гб необходимо {f.GetTime()} секунд");
            WriteLine();
            HDD h = new HDD();
            // f.GetInfo();
            h.name = "HDD диск";
            h.model = "Toshiba";
            h.volume = 512;
            h.GetInfo();
            h.Copy();
            WriteLine($"Свободный объем памяти на устройстве {h.volume} Гб. ");
            WriteLine($"Для копирования {h.copyMemory} Гб необходимо {h.GetTime()} секунд");



        }
    }
}

