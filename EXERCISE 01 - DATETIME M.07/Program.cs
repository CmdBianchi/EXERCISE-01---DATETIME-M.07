using System;
namespace EXERCISE_01___DATETIME_M._07 {
    /// -------> START / MAIN 
    /////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.Parse("2000-08-15");
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd");
            DateTime d9 = DateTime.ParseExact("15/08/200 13:05:58", "dd/MM/yyyy HH:mm:ss");
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////
    /// -------> END
}
