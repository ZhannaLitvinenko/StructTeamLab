using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTeamLab
{
    partial class Program
    {
        static void Test(Student[] students)
        {
            int countOfStraightA = 0;
            for (int i = 0; i < students.Length; i++)
            {
                int infMark = Convert.ToInt32(students[i].informaticsMark);
                int mathMark = Convert.ToInt32(students[i].mathematicsMark);
                int physicsMark = Convert.ToInt32(students[i].physicsMark);
                if (infMark == 53 && mathMark == 53 && physicsMark == 53)
                {
                    countOfStraightA++;
                    Console.WriteLine("\nСтудент:\n{0} {1} {2}\nРозмiр стипендiї = {3} грн.", students[i].surName, students[i].firstName, students[i].patronymic, students[i].scholarship);
                }
            }
            Console.WriteLine("\nУсього студентiв - вiдмiнникiв - {0} осiб.\n", countOfStraightA);
        }
    }
}
