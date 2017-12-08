using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentDB
{
    class StudentDB
    {
        string[] jmena = new string[5] {"Fero","Jan","Duro","Peter", "Ondrej" };

        string[] prijmeni = new string[5] { "Chleb", "Fico", "Zeman", "Danko", "Bugar" };

        public Student[] poleStudentu = new Student[10];

        public ArrayList SeznamStudentu = new ArrayList();

        public void LoadStudenty()
        {

            Random nahodneCislo = new Random();
            const int delkaPole = 10;

            for (int i = 0; i < poleStudentu.Length; i++ )
            {
                Student student;

                student.Jmeno = jmena[nahodneCislo.Next(5)];
                student.Prijmeni = prijmeni[nahodneCislo.Next(5)];
                student.Vek = nahodneCislo.Next(15, 80);
                Student[] polesStudentu = new Student[delkaPole];
                poleStudentu[i] = student;
                SeznamStudentu.Add(student);


            }

        }

        public bool Sestrid(Student[] studenti, out Student[] setridenePole)
        {

            // tu je to pretypovanez objektu na typy Studenta
            setridenePole = (Student[])studenti.Clone();
            bool byloTrideno = false;
            for (int i = 0; i < setridenePole.Length; i++)
            {
                for (int j = 0; j < setridenePole.Length-1; j++)
                {


                    if (setridenePole[j].Vek > setridenePole[j+1].Vek)
                    {
                        Student docasna = setridenePole[j];
                        setridenePole[j] = setridenePole[j+1];
                        setridenePole[j + 1] = docasna;
                        byloTrideno = true;
                    }
                }
                

            }
            return byloTrideno;

        }
    }
}
