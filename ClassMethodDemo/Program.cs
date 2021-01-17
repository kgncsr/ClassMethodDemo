using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yazılım Geliştirici Yetiştirme Kampı 3.gün ödevi
            //Bir bankada müşteri takibi yapmak istiyorsunuz.
            //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.

            Customer customer1 = new Customer();
            customer1.Id = 1001;
            customer1.Name = "Ali";
            customer1.SurName = "Yilmaz";
            customer1.Country = "Turkiye";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer() { Id = 1002, Name = "Alara", SurName = "Kenny", Country = "USA", City = "New York" };

            Customer[] customers = new Customer[]
            {
                customer1,customer2
            };


            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Add(customer1);
            musteriMenager.Add(customer2);
            musteriMenager.List(customers);
            musteriMenager.Delete(customer1);

        }
    }
}
