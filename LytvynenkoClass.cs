using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTeamLab
{
    partial class Program
    {
        static void LytvynenkoTest(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                double mathMark = Char.GetNumericValue(students[i].mathematicsMark);
                double infMark = Char.GetNumericValue(students[i].informaticsMark);
                double physicsMark = Char.GetNumericValue(students[i].physicsMark);
                int scholarship = students[i].scholarship;
                if (mathMark >= 3 && mathMark <= 5 && infMark >= 3 && infMark <= 5 && physicsMark >= 3 && physicsMark <= 5 && scholarship == 0)
                {
                    Console.WriteLine("\nСтудент:\n{0} {1} {2}\n", students[i].surName, students[i].firstName, students[i].patronymic);
                }
            }
        }
    }
}
