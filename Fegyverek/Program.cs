using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fegyverek
{
    class Program
    {
        enum fegyverek {apaökle, uzi, lángszoró, kézigránát, revolver, shotgun, deagle};
        static void Main(string[] args)
        {
            List<fegyverek> fegyvertár = new List<fegyverek>();
            //Egy fegyver csak egy példányba tárolható
            Felpakol(fegyvertár); //Az összes fegyvert berakja a fegyvertárba
            Listázó(fegyvertár);
            Console.WriteLine(FegyverSzám(fegyvertár));
            Kivesz(fegyvertár); //Egy fegyvert kivesz a fegyvertárból
            Listázó(fegyvertár);
            Felvesz(fegyvertár, fegyverek.shotgun); //Egy fegyvert berak a tár végére
            Listázó(fegyvertár);
            Felvesz2(fegyvertár,fegyverek.lángszoró); //Egy fegyvert berak a i. helyére
            Listázó(fegyvertár);
            int db = FegyverSzám(fegyvertár); //visszaadja hány fegyver van a listában éppen
            Listázó(fegyvertár);
            
            
            
            Console.ReadKey();
        }


        static void Felvesz2(List<fegyverek> fegyvertár, fegyverek lángszoró)
        {
            if (!fegyvertár.Contains(fegyverek.lángszoró))
            {
                fegyvertár.Insert(0, fegyverek.lángszoró);
                Listázó(fegyvertár);
            }
        }

        static void Felvesz(List<fegyverek> fegyvertár, fegyverek shotgun)
        {
            if (!fegyvertár.Contains(fegyverek.shotgun))
            {
                fegyvertár.Add(fegyverek.shotgun);
                Listázó(fegyvertár);
            }
        }

        static void Kivesz(List<fegyverek> fegyvertár, fegyverek fegyverek)
        {
            fegyvertár.Remove(fegyverek);
        }

        static int FegyverSzám(List<fegyverek> fegyvertár)
        {
            return fegyvertár.Count;
        }

        static void Listázó(List<fegyverek> fegyvertár)
        {
            foreach (fegyverek item in fegyvertár)
            {
                Console.WriteLine(item);
            }
        }

        static void Felpakol(List<fegyverek> fegyvertár)
        {
            fegyvertár.Add(fegyverek.apaökle);
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.lángszoró);
            fegyvertár.Add(fegyverek.kézigránát);
            fegyvertár.Add(fegyverek.revolver);
            fegyvertár.Add(fegyverek.shotgun);
            fegyvertár.Add(fegyverek.deagle);
        }
    }
}
