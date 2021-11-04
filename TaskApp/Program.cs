using System;
using ClassLibrary1;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obyekt = new ClassLibrary1.Class1();
            Console.WriteLine("cem "+obyekt.Topla(1, 2)+ obyekt.Cix(2, 1));
        }
    }
}
//Console app yaradın(İlk project), sonra ikinci project olaraq Class Library yaradın.
//Class Library-də hər hansı bir class yaradıb daxilində bir neçə method yaradın.
//Class library-nin referansını Console App-ə əlavə edin və Class Librarydə yaratdığınız methodları Cosole app-də istifadə edin.
