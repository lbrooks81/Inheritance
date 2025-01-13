using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
   
    public abstract class ITDevice : InventoryItem
    {
        protected ITDevice(String title, String brand, int quantity, ProductTypes productType, float price)
            : base(title, brand, quantity, productType, price){}
        public String? Resolution { get; set; }
        public String Storage { get; set; }
        public String RAMSize { get; set; }
        public String CPU { get; set; }
        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Resolution: {Resolution}\n Storage: {Storage}\n RAM Size: {RAMSize}\n CPU: {CPU}");
        }
    }
}
