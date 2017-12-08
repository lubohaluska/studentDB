using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentDB
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentDB databaze = new StudentDB();
            databaze.LoadStudenty();

            
            Student[] setrideniStudenti;
            bool trideno =  databaze.Sestrid(databaze.poleStudentu, out setrideniStudenti);

  //takto si mozem urobit vypis prvkov
            foreach (Student s in setrideniStudenti)
            {
                Console.WriteLine(s.Jmeno + " " + s.Prijmeni + " " + s.Vek);
            }


            foreach (Student s in databaze.poleStudentu)
            {
                Console.WriteLine(s.Jmeno + " " + s.Prijmeni + " " + s.Vek);
            }

            Console.WriteLine();
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
