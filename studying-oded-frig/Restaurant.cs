using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_oded_frig
{
    internal class Restaurant
    {
        string Name = null;
        string Location = null;
        Table[] tabel1 = new Table[10];
        Chair[] chair1;

        public Restaurant()
        {
            for (int i = 0; i < tabel1.Length; i++)
                tabel1[i] = new Table();

            chair1 = new Chair[this.tabel1.Length * 4];

            for (int i = 0; i < chair1.Length; i++)
                chair1[i] = new Chair();

        }

        public Restaurant(string name, string location)
        {

            this.Name = name;
            this.Location = location;

            for (int i = 0; i < tabel1.Length; i++)
                tabel1[i] = new Table();

            chair1 = new Chair[this.tabel1.Length * 4];

            for (int i = 0; i < chair1.Length; i++)
                chair1[i] = new Chair();

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
