using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopExample._5._ApplicationAndDomainServices
{
    public class Ticket
    {
        public Ticket(int price)
        {
            Price = price;
        }

        public int Price { get; }
    }
}
