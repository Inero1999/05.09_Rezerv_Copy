using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _05._09_Rezerv_Kopy
{
    public class Flash : IStorage
    {
        //string IStorage.name {get;set;}
        //string IStorage.model{get;set;}
        //public string name { get { return name; } set { name = value; } }
        //public string model { get { return model; } set { model = value; } }
        public string name;
        public string model;
        public int volume;
        public  long speed=5;
        public int copyMemory = 0;
        public Flash() { string name; string model; int volume; long speed; } 
        


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

            while (copyMemory >volume);
            volume = volume - copyMemory;

            return copyMemory;
        }

        public int FreeMemory()
        {           
            
            return volume;
        }
               

        

        public void GetInfo()
        {
            Console.WriteLine($"Наименование носителя: {name}/ Модель: {model}/ Объем, Гб : {volume} /Скорость, Гбит/с : {speed} ");
        }

        public long GetTime()
        {
           
            long time = (copyMemory* 8589934592 )/ (speed * 1073741824);           

            return time;

        }
    }
}
