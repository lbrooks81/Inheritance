/*
* Name: Logan Brooks
* South Hills Username: lbrooks81
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Categorizer
    {
        //Add inventory items here after they are created
        public static List<InventoryItem> InventoryItems { get; private set; } = [];
        public record Product(String title, String brand, int quantityOnHand, 
            ProductTypes productType, float price, List<String> miscAttributes);
        
        public static void Creator(ProductTypes productType, String brand, 
            String title, int quantityOnHand, float price, List<String> miscAttributes)
        {
            Product product = new(title, brand, quantityOnHand, productType, price, miscAttributes);

            switch (productType)
            {
                case ProductTypes.Laptop:       
                    Laptop laptop = new Laptop(product);
                    InventoryItems.Add(laptop);
                    break;
                case ProductTypes.Smartphone:
                    Smartphone smartphone = new Smartphone(product);
                    InventoryItems.Add(smartphone);
                    break;
                case ProductTypes.RoboticVacuum:
                    RoboticVacuum roboticVacuum = new RoboticVacuum(product);
                    InventoryItems.Add(roboticVacuum);
                    break;
                case ProductTypes.Camera:
                    Camera camera = new Camera(product);
                    InventoryItems.Add(camera);
                    break;
                case ProductTypes.AirFryer:
                    
                    AirFryer airFryer = new AirFryer(product);
                    InventoryItems.Add(airFryer);
                    break;
            }
        }
    }
}
