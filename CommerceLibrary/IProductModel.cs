using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceLibrary
{
    public interface IProductModel
    {
        string Title { get; set; }

        int price { get; }

        bool OrderCompleted { get; }

        void DispatchItem(CustomerModel customer);
    }
}
