using DelegateTaskHomeWork.Models;

namespace DelegateTaskHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();
            
            Exam codeAcademy = new Exam(4, "Code academy c# Exam", DateTime.Now);

            Exam matrix = new Exam( 2, "Matrix Exam", DateTime.Now);

            Exam bdu = new Exam(140, "Bdu Exam", DateTime.Now);

            exams.Add(codeAcademy);
            exams.Add(matrix);
            exams.Add(bdu);
            codeAcademy.Start();
            


            Console.WriteLine("son 1 hefte erzinde olan  exam");
            exams.FindAll(s => s.StartDate <= s.StartDate.AddDays(9))
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));




            Console.WriteLine(" ");
            Console.WriteLine("2 saatdan uzun ceken exam ");
            exams.FindAll(s => s.ExamDuration > 100)
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));





            Console.WriteLine(" ");
            Console.WriteLine("hal-hazirda devam eden");
            exams.FindAll(s => DateTime.Now >= s.StartDate && DateTime.Now < s.EndDate)
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
           
        }
    }
}
