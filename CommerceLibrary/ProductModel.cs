using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceLibrary
{
    public class ProductModel : IProductModel
    {
        public string Title { get; set; }

        public int price { get; set; }

        public bool OrderCompleted { get; private set; }

        public void DispatchItem(CustomerModel customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"The item {Title} has been dispatched to {customer.FullName} at {customer.City}");
                OrderCompleted = true;
            }
        }
    }
}
