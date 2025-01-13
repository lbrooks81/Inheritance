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

        public static void Creator(ProductTypes productType, String brand, 
            String title, int quantityOnHand, float price, List<String> miscAttributes)
        {
            String[] attributes = miscAttributes.ToArray();
            switch (productType)
            {
                case ProductTypes.Laptop:       
                    Laptop laptop = new Laptop(title, brand, quantityOnHand, ProductTypes.Laptop, 
                        price, attributes[0], attributes[1], attributes[2], attributes[3], attributes[4]);
                    // TODO get each element in miscAttributes as a property in the constructor
                    InventoryItems.Add(laptop);
                    break;
                case ProductTypes.Smartphone:
                    Smartphone smartphone = new Smartphone(title, brand, quantityOnHand, ProductTypes.Smartphone,
                        price, attributes[0], attributes[1], attributes[2], attributes[3], attributes[4]);
                    InventoryItems.Add(smartphone);
                    break;
                case ProductTypes.RoboticVacuum:
                    bool bagless = attributes[1] == "yes" ? true : false;
                    RoboticVacuum roboticVacuum = new RoboticVacuum(title, brand, quantityOnHand, ProductTypes.RoboticVacuum,
                        price, attributes[0], bagless, attributes[2], attributes[3]);
                    InventoryItems.Add(roboticVacuum);
                    break;
                case ProductTypes.Camera:
                    Camera camera = new Camera(title, brand, quantityOnHand, ProductTypes.Camera,
                        price, attributes[0], attributes[1], attributes[2]);
                    InventoryItems.Add(camera);
                    break;
                case ProductTypes.AirFryer:
                    String[] functions = attributes[2].Split('/');
                    bool nonStick = attributes[0] == "yes" ? true : false;
                    AirFryer airFryer = new AirFryer(title, brand, quantityOnHand, ProductTypes.AirFryer,
                        price, nonStick, attributes[1], functions);
                    InventoryItems.Add(airFryer);
                    break;
            }
            //TODO: Create new objects based on the productType and store them in the InventoryItems list
        }
    }
}
