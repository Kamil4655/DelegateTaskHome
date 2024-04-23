using DelegateTAskTwo.Models;
using System;

namespace DelegateTAskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person kamil = new Person("Kamil", "Qehremanov", 20);

            Person anar = new Person("Anar", "Amanli", 19);

            Person nezrin = new Person("Nezrin", "Eliyeva", 20);

            Person inare = new Person("Inare", "Huseynova", 19);

            List<Person> people = new List<Person>();

           
            
            people.Add(kamil);
            people.Add(anar);
            people.Add(nezrin);
            people.Add(inare);


           

            
            Console.WriteLine(" ");
            Console.WriteLine("Yaşı 20+ olanlar");
            people.FindAll(s => s.Age >= 20)
                .ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));




            Console.WriteLine(" ");
            Console.WriteLine("Soyadı ov ve ova ile biten telebeler.");
            people.FindAll(s => s.Surname.ToLower().Contains("ov") || s.Surname.ToLower().Contains("ova"))
                .ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));
        }
    }
}
