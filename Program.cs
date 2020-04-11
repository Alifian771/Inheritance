using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bambang", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Nyonya Puff", 35, 190302, "Guru Ekonomi");
            teacher.GetNameAndAge();

            Student student = new Student("Patrick", 21, 10506, "patrickstar@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
