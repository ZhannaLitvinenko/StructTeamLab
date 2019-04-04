using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StructTeamLab
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
            Student[] students = new Student[] { };
            StreamReader reader = new StreamReader(fileName);
            for (int i = 0; reader.Peek() > -1; i++)
            {
                Array.Resize(ref students, students.Length + 1);
                students[i] = new Student(reader.ReadLine());                
            }
            reader.Close();
            return students;
        }

        static void runMenu(Student[] studs)
        {
            Console.WriteLine("Ввести номер варiанту для виконання\n(1 - Митренко, 2 - Вакулiнський, 3 - Литвиненко)\nДля виходу натиснiть \"0\"\nНомер:");
            switch (int.Parse(Console.ReadLine()))
            {
                case (1):
                    Test(studs);
                    break;
                case (2):
                    //Add methods
                    break;
                case (3):
                    //Add methods
                    break;
                case (0):
                    System.Environment.Exit(0);
                    break;
            }
            runMenu(studs);
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}
