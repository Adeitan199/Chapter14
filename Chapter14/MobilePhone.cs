using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoOnClasses
{
    class MobilePhone
    {
        //Field for mobile phone
        public string model;
        public string manufacturer;
        public int price;
        public string owner;

        //Properties for MobilePhone

        private string Model { get; set; }
        private string Manufacturer { get; set; }
        private int Price { get; set; }
        private string Owner { get; set; }

        //Static field for NokiaN95
        private string Nokia = "NokiaN95";
        private string NokiaOwner = "Ola";
        private string Manufactur = "Nokia LTD";
        private int Phoneprice = 95000;

        //Constructor for MobilePhone
        public MobilePhone(string aModel, string aManufacturer, int aPrice, string aOwner)
        {
            model = aModel;
            manufacturer = aManufacturer;
            price = aPrice;
            owner = aOwner;
        }

        //Method for MobilePhone
        public void PrintGSMInfo()
        {
            Console.WriteLine(model);
        }


        //No 12. Method that returns information about object as ToString

        public override string ToString()
        {
            return $"{Model}\t{Manufacturer}\t{Price}\t{Owner}";
        }
    }


    public class MobilePhoneBattery
    {
        // Field for MobilePhoneBattery
        public string batteryModel;
        public bool batteryIdle;
        public int batterytimeOfTalk;
        Battery battery1;

        //Properties for Phonebattery
        private string BatteryModel { get; set; }
        private bool BatteryIdle { get; set; }
        private int BatterytimeOfTalk { get; set; }
        private Battery Battery1 { get; set; }


        public MobilePhoneBattery(string aModel, bool aIdle, int aTime, Battery battery)
        {
            //Constructor for battery
            batteryModel = aModel;
            batteryIdle = aIdle;
            batterytimeOfTalk = aTime;
            Battery1 = battery;

        }
    }

    public class MobileScreen
    {
        //fields for mobilescreen
        public int screenSize;
        public string screenColor;

        //properties for Mobilescreen
        private int ScreenSize { get; set; }
        public  string ScreenColor { get; set; }

        public MobileScreen(int aScreenSize, string aScreenColor)
        {
            //constructor for mobilescreen
            screenSize = aScreenSize;
            screenColor = aScreenColor;
        }
    }

    public static class NokiaN95
    {

    }




















}
