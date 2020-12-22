using parseCSV;
using System;
using System.IO;
using System.Linq;

namespace ParseCSV
{
    class Program
    { 
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"planets.csv");
            lines = lines.ToArray();

            string planetString = string.Join(Environment.NewLine, lines);

            //allows me to format the string as it is in the given example
            planetString = planetString.Replace("\r\n", "\n");

            Planet[] planets = PlanetParser.ParseCSV(planetString);            

            for (int i = 0; i < planets.Length; i++)
            {
                Console.WriteLine("Id: {0}, Name: \"{1}\" ", planets[i].id, planets[i].name);
            }
        }
    }
}
