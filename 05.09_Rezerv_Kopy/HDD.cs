using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _05._09_Rezerv_Kopy
{
    class HDD : IStorage
    {
        public string name;
        public string model;
        public int volume;
        public long speed = 480;
        public int copyMemory = 0;
        public HDD() { string name; string model; int volume; long speed; }
        public int Copy()
        {
            WriteLine("Введите количество Гб, которое хотите скопировать : ");
            do
            {
                string N;
                N = ReadLine();
                copyMemory = Convert.ToInt32(N);
                if (copyMemory > volume)
                {
                    WriteLine($"Объем свободной памяти накопителя всего {volume} Гб. Введите меньший объем для передачи данных ");
                }
            }

            while (copyMemory > volume);
            volume = volume - copyMemory;

            return copyMemory;
        }

        public int FreeMemory()
        {
            return volume;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Наименование носителя: {name}/ Модель: {model}/ Объем, Гб : {volume}/ Скорость, Мбит/с : {speed} ");
        }

        public long GetTime()
        {
            long time = (copyMemory * 8589934592) / (speed * 8388608);

            return time;
        }
    }
}
