﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class InventoryItem
    {
        // TODO: The other common properties go here!
        public String? Title { get; }
        public String? Brand { get; }
        public int Quantity { get; }
        public ProductTypes ProductType { get; }
        public float Price { get; } // Can only be assigned to in a constructor in this class

        public List<String> MiscAttributes { get; }
        public InventoryItem(Categorizer.Product product)
        {
            Title = product.title;
            Brand = product.brand;
            Quantity = product.quantityOnHand;
            ProductType = product.productType;
            Price = product.price;
            MiscAttributes = product.miscAttributes;
        }
        public virtual void DisplayItem()
        {
            // TODO: Implement the DisplayItem method
            Console.WriteLine($"Title: {Title}\n Brand: {Brand}\n QOH: {Quantity}\n Product Type: {ProductType}\n Price: ${Price.ToString("C2")}");
        }
    }
}
