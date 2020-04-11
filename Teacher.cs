using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritanceReal
{
    internal class Teacher
    {
        private string Jeneng;
        private int Umur;
        private int Id;
        private string Status;

        public void GetNameAndAge() => Console.WriteLine("Nama: {0} Umurnya: {1} ID: {2} Status: {3} ", Jeneng, Umur, Id, Status);
        public Teacher(string Jeneng, int Umur, int Id, string Status)
        {
            this.Jeneng = Jeneng;
            this.Umur = Umur;
            this.Id = Id;
            this.Status = Status;
        }
    }
}















