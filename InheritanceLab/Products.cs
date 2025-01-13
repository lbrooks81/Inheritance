using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Laptop : ITDevice
    { 
        public String ScreenSize { get; set; }
        public Laptop(String title, String brand, int quantity, ProductTypes productType, float price, 
            String resolution, String screenSize, String storage, String ram, String cpu)
            : base(title, brand, quantity, productType, price)
        {
            Resolution = resolution;
            ScreenSize = screenSize;
            Storage = storage;
            RAMSize = ram;
            CPU = cpu;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Screen Size: {ScreenSize}");
            Console.Write(Environment.NewLine);
        }
        //TODO: Finish this class. Hint: it needs a constructor and its unique properties.
    }

    public class Smartphone : ITDevice
    {
        public String CameraResolution { get; set; }
        public Smartphone(String title, String brand, int quantity, ProductTypes productType, float price, 
            String resolution, String storage, String ram, String cpu, String cameraResolution)
            : base(title, brand, quantity, productType, price)
        {
            Resolution = resolution;
            Storage = storage;
            RAMSize = ram;
            CPU = cpu;
            CameraResolution = resolution;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Camera Resolution: {CameraResolution}");
            Console.Write(Environment.NewLine);
        }
        //TODO: Finish this class. Hint: it needs a constructor and its unique properties.
    }

    public class RoboticVacuum : InventoryItem
    {
        public String CleaningPathWidth { get; set; }
        public bool Bagless { get; set; }
        public String Color { get; set; }
        public String Weight { get; set; }
        public RoboticVacuum(String title, String brand, int quantity, ProductTypes productType, float price,
            String cleaningPathWidth, bool bagless, String color, String weight) 
            : base(title, brand, quantity, productType, price)
        {

            CleaningPathWidth = cleaningPathWidth;
            Bagless = bagless;
            Color = color;
            Weight = weight;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Cleaning Path Width: {CleaningPathWidth}\n Bagless: {Bagless}\n Color: {Color}\n Weight: {Weight}");
            Console.Write(Environment.NewLine);
        }
        //TODO: Finish this class. Hint: it needs a constructor and its unique properties.
    }

    public class Camera : InventoryItem
    {
        public String ImageSensorType { get; set; }
        public String EffectivePixels { get; set; }
        public String VideoResolution { get; set; }
        public Camera(String title, String brand, int quantity, ProductTypes productType, float price,
            String imageSensorType, String effectivePixels, String videoResolution) 
            : base(title, brand, quantity, productType, price)
        {
            ImageSensorType = imageSensorType;
            EffectivePixels = effectivePixels;
            VideoResolution = videoResolution;
        }
        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Image Sensor Type: {ImageSensorType}\n Effective Pixels: {EffectivePixels}\n Video Resolution: {VideoResolution}");
            Console.Write(Environment.NewLine);
        }
        //TODO: Finish this class. Hint: it needs a constructor and its unique properties.
    }

    public class AirFryer : InventoryItem
    {
        public bool NonStick { get; set; }
        public String Color { get; set; }
        public String[] Functions { get; set; }

        public AirFryer(String title, String brand, int quantity, ProductTypes productType, float price, 
            bool nonStick, String color, String[] functions) 
            : base(title, brand, quantity, productType, price)
        {
            NonStick = nonStick;
            Color = color;
            Functions = functions;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" NonStick Interior: {NonStick}\n Color: {Color}\n Functions: {String.Join(", ", Functions)}");
            Console.Write(Environment.NewLine);
        }
        //TODO: Finish this class. Hint: it needs a constructor and its unique properties.
    }
}
