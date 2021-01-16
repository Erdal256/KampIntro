using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım yetiştirme kampı";
            string kurs2 = "Programlama kursu temel";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array - dizi [] yaparan birden fazla string yazabiliriz.
            string[] kurslar = new string[] { "Yazılım yetiştirme kampı", "Programlama kursu temel", "Java", "Python"};


            for (int i = 0; i < kurslar.Length; i++)//(i yi iki iki artık demek)  //döngü  //1 den başlayacak i < 10 şarttın i i ise birer birer artık 1 den başla 10 dan küçük olduuğu için bir bir başla 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) // dizi temelli yapıları tek tek yazmaya yarıyor yani yukarıdakş arrayy[] kısmını.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
           
        }
    }
}
