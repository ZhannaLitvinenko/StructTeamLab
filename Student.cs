using System;
using System.Text;
using System.Linq;

namespace StructTeamLab
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            while (lineWithAllData.Contains("  "))
                lineWithAllData = lineWithAllData.Replace("  ", " ");

            string[] data = lineWithAllData.Split();
            surName = data[0];
            firstName = data[1];
            patronymic = data[2];
            sex = char.Parse(data[3]);
            dateOfBirth = data[4];
            mathematicsMark = char.Parse(data[5]);
            physicsMark = char.Parse(data[6]);
            informaticsMark = char.Parse(data[7]);
            scholarship = int.Parse(data[8]);
        }


    }
}
