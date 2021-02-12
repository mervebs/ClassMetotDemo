using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customermanager

    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("müşteri eklendi:" + customer.Ad + customer.soyad + customer.Id);
        }
        public void Listcustomer(Customer customer)
        {
            Console.WriteLine("müşteri listelendi:" + customer.Ad + customer.soyad + customer.Id);

        }




        public void DeleteCustomer(Customer customer)
        {

            Console.WriteLine("müşteri silindi:" + customer.Ad + customer.soyad + customer.Id);
        }

    }
}
