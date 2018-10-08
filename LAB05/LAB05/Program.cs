using System;
using LAB05.App_Code;

namespace LAB05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio #5!\n");

            Console.WriteLine("INHERITANCE");
            PrintPerson(new Student());

            Console.WriteLine("COMPOSITION");
            PrintPerson(new StudentC(new Person()));

            Console.ReadKey();
        }

        public static void PrintPerson(Student student)
        {
            Console.WriteLine(student.FormatNameAndID("Diego", 1));
        }

        public static void PrintPerson(StudentC student)
        {
            Console.WriteLine(student.FormatNameAndID("Diego", 1));
        }
    }
}
