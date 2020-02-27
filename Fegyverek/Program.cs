using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fegyverek
{
    class Program
    {
        enum fegyverek { Uzi, M4, Gránát, Lánszóró, Atombomba, FiNg, }

        static void Main(string[] args)
        {
            List<fegyverek> fegyvertáska = new List<fegyverek>();
            // Egy fegyvert csak egy példányban tárolhatunk.
            Felpakol(fegyvertáska); //Az összes fegyvert berakja a fegyvertárba.
            Kivesz(fegyvertáska, fegyverek.Lánszóró);   //Egy konkrét fegyvert kivesz a fegyvertárból.
            Felvesz(fegyvertáska, fegyverek.Lánszóró);  //Egy fegyvert betesz a fegyvertár végére.
            Felvesz_2(fegyvertáska, fegyverek.Lánszóró);//Egy fegyvert berak i. helyre
            Kiürít(fegyvertáska);   //Kiüríti a fegyvertárat.
            int db = Fegyverszám(fegyvertáska); // Visszaadja hány fegyver van a fegyvertárban.
            Listázó(fegyvertáska);  //Kiírja milyen fegyverek vannak nálam.
            Console.ReadKey();
        }

        private static int Fegyverszám(List<fegyverek> fegyvertáska)
        {
            int db = fegyvertáska.Count;
            Console.WriteLine($"{db} fegyver van nálad.");
            return db;
        }

        static void Kiürít(List<fegyverek> fegyvertáska)
        {
            fegyvertáska.Remove(fegyverek.Atombomba);
            fegyvertáska.Remove(fegyverek.Uzi);
            fegyvertáska.Remove(fegyverek.M4);
            fegyvertáska.Remove(fegyverek.Gránát);
            fegyvertáska.Remove(fegyverek.Lánszóró);
            fegyvertáska.Remove(fegyverek.FiNg);
            Listázó(fegyvertáska);
        }

        static void Felvesz_2(List<fegyverek> fegyvertáska, fegyverek lánszóró)
        {
            if (!fegyvertáska.Contains(fegyverek.Lánszóró))
            {
                fegyvertáska.Insert(0, fegyverek.Lánszóró);
                Listázó(fegyvertáska);
            }

        }

        static void Felvesz(List<fegyverek> fegyvertáska, fegyverek lánszóró)
        {
            if (!fegyvertáska.Contains(fegyverek.Lánszóró))
            {
                fegyvertáska.Add(fegyverek.Lánszóró);
                Listázó(fegyvertáska);
            }
        }

        static void Kivesz(List<fegyverek> fegyvertáska, fegyverek lánszóró)
        {
            fegyvertáska.Remove(fegyverek.Lánszóró);
            Listázó(fegyvertáska);
        }

        static void Listázó(List<fegyverek> fegyvertáska)
        {
            Console.WriteLine("Fegyvertáska: ");
            foreach (fegyverek elem in fegyvertáska)
            {
                Console.Write(elem + ", ");
            }
        }

        static void Felpakol(List<fegyverek> fegyvertáska)
        {
            fegyvertáska.Add(fegyverek.Atombomba);
            fegyvertáska.Add(fegyverek.Uzi);
            fegyvertáska.Add(fegyverek.M4);
            fegyvertáska.Add(fegyverek.Gránát);
            fegyvertáska.Add(fegyverek.Lánszóró);
            fegyvertáska.Add(fegyverek.FiNg);
            Listázó(fegyvertáska);
        }
    }
}
