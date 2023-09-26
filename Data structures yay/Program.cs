using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_yay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp1
    {
        internal class Program
        {
            struct Town //collection of properties of town of different data types
            {
                public string townName;
                public int population;
                public double area;
                public string county;

                public Town(string tName, int tPop, double tArea, string tCounty) //we can add parameters
                {
                    townName = tName;
                    population = tPop;
                    area = tArea;
                    county = tCounty;
                }
            }

            static void Main(string[] args)
            {
                Town t; //we have defined a town in our main program
                t.townName = "Heckmondwike";
                t.population = 100;
                t.area = 52.9;
                t.county = "West Yorkshire";
                //we have set the properties of the town by using t.

                Town t1 = new Town("Batley", 12, 4.5, "West Yorkshire");

                string[] strings = { "This", "is", "an", "array", "of", "strings" };
                int[] nums = new int[10]; //this array has a length of 10, meaning the last index is index 9
                nums[9] = 0;
            }
        }
    }

}
