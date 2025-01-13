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
        public Laptop(Categorizer.Product product)
            : base(product)
        {
            Resolution = product.miscAttributes[0];
            ScreenSize = product.miscAttributes[1];
            Storage = product.miscAttributes[2];
            RAMSize = product.miscAttributes[3];
            CPU = product.miscAttributes[4];
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Screen Size: {ScreenSize}");
            Console.Write(Environment.NewLine);
        }
    }

    public class Smartphone : ITDevice
    {
        public String CameraResolution { get; set; }
        public Smartphone(Categorizer.Product product)
            : base(product)
        {
            Resolution = product.miscAttributes[0];
            Storage = product.miscAttributes[1];
            RAMSize = product.miscAttributes[2];
            CPU = product.miscAttributes[3];
            CameraResolution = product.miscAttributes[4];
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Camera Resolution: {CameraResolution}");
            Console.Write(Environment.NewLine);
        }
    }

    public class RoboticVacuum : InventoryItem
    {
        public String CleaningPathWidth { get; set; }
        public bool Bagless { get; set; }
        public String Color { get; set; }
        public String Weight { get; set; }
        public RoboticVacuum(Categorizer.Product product) 
            : base(product)
        {
            CleaningPathWidth = product.miscAttributes[0];
            Bagless = product.miscAttributes[1] == "yes" ? true : false; ;
            Color = product.miscAttributes[2];
            Weight = product.miscAttributes[3];
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Cleaning Path Width: {CleaningPathWidth}\n Bagless: {Bagless}\n Color: {Color}\n Weight: {Weight}");
            Console.Write(Environment.NewLine);
        }
    }

    public class Camera : InventoryItem
    {
        public String ImageSensorType { get; set; }
        public String EffectivePixels { get; set; }
        public String VideoResolution { get; set; }
        public Camera(Categorizer.Product product) 
            : base(product)
        {
            ImageSensorType = product.miscAttributes[0];
            EffectivePixels = product.miscAttributes[1];
            VideoResolution = product.miscAttributes[2];
        }
        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" Image Sensor Type: {ImageSensorType}\n Effective Pixels: {EffectivePixels}\n Video Resolution: {VideoResolution}");
            Console.Write(Environment.NewLine);
        }
    }

    public class AirFryer : InventoryItem
    {
        public bool NonStick { get; set; }
        public String Color { get; set; }
        public String[] Functions { get; set; }

        public AirFryer(Categorizer.Product product) 
            : base(product)
        {
            NonStick = product.miscAttributes[0] == "yes" ? true : false;
            Color = product.miscAttributes[1];
            Functions = product.miscAttributes[2].Split('/');
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.WriteLine($" NonStick Interior: {NonStick}\n Color: {Color}\n Functions: {String.Join(", ", Functions)}");
            Console.Write(Environment.NewLine);
        }
    } 

}
