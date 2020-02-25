using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fegyverek
{
    class Program
    {
        enum fegyverek {apaökle, uzi, lángszoró, kézigránát};
        static void Main(string[] args)
        {
            fegyverek kezemben = fegyverek.kézigránát;
            List<fegyverek> fegyvertár = new List<fegyverek>();
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.lángszoró);
            foreach (fegyverek elem in fegyvertár)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();
        }
    }
}
