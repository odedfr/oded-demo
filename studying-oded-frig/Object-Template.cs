using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studying_oded_frig
{
    internal class Object_Template
    {
        public int num = 10;
        public string name = "oded";
        public bool quest = false;

        public void toggele()
        {
            quest = !quest;
        }
        public void SetName(string Nname)
        {
            this.name = Nname;
        }
        public string GetName()
        {
            return this.name;
        }
    }

    public class TestBasicObject
    {
        public static void Demo()
        {
            /*
            Object_Template template1 = new Object_Template();

            Console.WriteLine($"deafult name is {template1.GetName()} defult number is {template1.num} and bool is {template1.quest}");
            template1.toggele();
            Console.WriteLine("put new name");
            template1.SetName(Console.ReadLine());
            template1.num *= 2;
            Console.WriteLine($"new name is {template1.GetName()} new number is {template1.num} and bool is {template1.quest}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            */

            RestaurantChain temp2 = new RestaurantChain("OdedChain");



        }

    }

    public class Helper
    {
        public static void ToEnterName()
        {
            Console.WriteLine("please enter the name and the location of the Restaurant");
        }

        


    }

    

 


    public class RestaurantChain
    {
        public string NameChain;
        public string Name;
        public string Location;

        Restaurant[] restaurant = new Restaurant[3];

        public RestaurantChain(string nameChain)
        {
            this.NameChain = nameChain;
            for (int i = 0; i < restaurant.Length; i++)
            {
                ToEnterName();
                Name=Console.ReadLine();
                ToEnterLocation();
                Location=Console.ReadLine();

                restaurant[i] = new Restaurant(Name, Location);
            }
            
        }

        public static void ToEnterName()
        {
            Console.WriteLine("please enter the name of the Restaurant");
        }
        public static void ToEnterLocation()
        {
            Console.WriteLine("please enter location of the Restaurant");
        }
    }

}
