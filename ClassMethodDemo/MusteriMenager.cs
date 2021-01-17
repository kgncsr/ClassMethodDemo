using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriMenager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müsteri eklendi : "+customer.Name);
        }

        public void List(Customer[] customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item.SurName);
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri Silindi : "+customer.Id);
        }
    }
}
