using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { GroupName = "LP1", Name = "Павло" };
            Student student2 = new Student() { GroupName = "LP2", Name = "Катерина" };

            Pupil pupil1 = new Pupil() { ClassName = "1B", Name = "Денис" };
            Pupil pupil2 = new Pupil() { ClassName = "2B", Name = "John" };

            Student[] students = new Student[10];
            students[0] = student1;
            students[1] = student2;
            


            students[2] = new Student() { GroupName = "LP4", Name = "John" };

            Console.Read();
        }
    }
}
