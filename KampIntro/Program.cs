using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safetyn - tip güvenliği
            //Do not repeat yourself - Kendini Tekrarla
            //Değer tutucu, alias
            string kategorilerEtiketi = "Kategoeriler";
            int ogrenciSayisi = 32000; //int tam sayılarıu tutmak için
            double faizOrani = 1.65; //ondalklı sayılarda double kullanılmakta
            bool sistemeGirisYapmısmı = true; // veya false dogru yada yanlış olarak döndürür.
            
            
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if(sistemeGirisYapmısmı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
           
            Console.WriteLine(kategorilerEtiketi);

         
        }
    }
}
