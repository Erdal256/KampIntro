using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erdal Sarışen Customer 1
            GercekMusteri customer1 = new GercekMusteri();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Erdal";
            customer1.Surname = "Sarışen";
            customer1.TcNo = "12345678912";


            //Kodlama.io

            TuzelMusteri customer2 = new TuzelMusteri();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.SirketAdi = "Kodlama.io";
            customer2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID


            Customer customer3 = new GercekMusteri(); // new bellekteki referans nosu olarak aklımızda kalmalı.
            Customer customer4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        
            
        }
    }
}
