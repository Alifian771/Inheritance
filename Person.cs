using System;
namespace LatihanInheritanceReal
{
    internal class Person
    {
        private string Jeneng;
        private int Umur;
        private int Id;
        private string Status;
        private string Email;

        public void GetNameAndAge() => Console.WriteLine("Nama: {0} Umurnya: {1} ", Jeneng, Umur, Id, Status, Email);
        public Person(string Jeneng, int Umur)
        {
            this.Jeneng = Jeneng;
            this.Umur = Umur;
        }
    }
}