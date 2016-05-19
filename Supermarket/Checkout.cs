﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Checkout
    {
        public Bill ProcessBasket(Basket basket)
        {
            var bill = new Bill();
            for (var i = 0; i < basket.Items.Count; i++)
            {
                // add bill line for basket item i
                // line should look like: Book 20.99 for example
                var itemType = basket.Items[i].ItemType;
                var itemPrice = basket.Items[i].Price.ToString();
                bill.Lines.Add(itemType + " " + itemPrice);
            }

            bill.Lines.Add(string.Empty);
            bill.Lines.Add("Sub Total: " + basket.SubTotal());
            bill.Lines.Add("Tax: " + basket.Tax());
            bill.Lines.Add("Discount: " + basket.Discount());
            bill.Lines.Add("Total: " + basket.Total());

            return bill;
        }
    }
}
