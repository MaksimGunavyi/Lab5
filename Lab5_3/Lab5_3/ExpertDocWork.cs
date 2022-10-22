using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    class ExpertDocWork : ProDocWork
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у новому форматі");
        }
    }
}