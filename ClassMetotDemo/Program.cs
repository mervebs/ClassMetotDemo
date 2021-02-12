using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customermanager1 = new Customer();
            customermanager1.Ad = "fatih";
            customermanager1.soyad = "kara";
            customermanager1.Id = 4554654;


            Customermanager customerManager = new Customermanager();

            customerManager.AddCustomer(customermanager1);
            customerManager.DeleteCustomer(customermanager1);
            customerManager.Listcustomer(customermanager1);







        }

    }
}
