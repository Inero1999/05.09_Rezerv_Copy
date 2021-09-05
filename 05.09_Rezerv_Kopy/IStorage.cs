using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._09_Rezerv_Kopy
{
    interface IStorage
    {
        //string name { get; set; }
        //string model { get; set; }

        long GetTime();
        int FreeMemory();
        int Copy();
        
        void GetInfo();

    }
}
