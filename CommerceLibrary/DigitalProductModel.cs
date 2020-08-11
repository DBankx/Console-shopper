using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceLibrary
{
    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }

        public int price { get; set; }

        public bool OrderCompleted {get; private set;}

        public int ItemsRemaining { get; private set; } = 5;

        public void DispatchItem(CustomerModel customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Item {Title} has been emailed to ${customer.Email}");

                if(ItemsRemaining < 1)
                {
                    Console.WriteLine($"{Title} has {ItemsRemaining} left in stock");

                    ItemsRemaining -= 1;
                }
            }
        }
    }
}
