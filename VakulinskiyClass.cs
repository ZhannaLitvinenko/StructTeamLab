using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTeamLab
{
	partial class Program
	{
		static void VakulinskiyTest(Student[] students)
		{
			for (int i = 0; i < students.Length; i++)
			{
				if (students[i].informaticsMark.Equals('-'))
					students[i].mathematicsMark = '2';

				if (students[i].mathematicsMark.Equals('-'))
					students[i].mathematicsMark = '2';

				if (students[i].physicsMark.Equals('-'))
					students[i].physicsMark = '2';

				if (students[i].informaticsMark.Equals('5'))
				{
					double mathMark = Char.GetNumericValue(students[i].mathematicsMark);
					double infMark = Char.GetNumericValue(students[i].informaticsMark);
					double physicsMark = Char.GetNumericValue(students[i].physicsMark);
					// Finding of grade point avarage
					double GPA = (mathMark + infMark + physicsMark) / 3;
					Console.WriteLine("\nСтудент:\n{0} {1} {2}\n Середнiй бал:\n {3}\n", students[i].surName, students[i].firstName, students[i].patronymic, GPA);
				}

			}

		}
	}
}
