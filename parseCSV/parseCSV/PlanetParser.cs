using parseCSV;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ParseCSV
{
    public static class PlanetParser
    {
        public static Planet[] ParseCSV(string csv)
        {
            // TODO: Add logic here           
            string[] planetArray = csv.Split('\n');

            Planet planet = new Planet();

            List<Planet> planetList = new List<Planet>();

            foreach (var p in planetArray)
            {
                string[] currentPlanet = p.Split(',');
                
                if (!currentPlanet[0].Contains("id"))
                {
                    planet = new Planet
                    {
                        id = Int32.Parse(currentPlanet[0]),
                        name = currentPlanet[1]
                    };

                    planetList.Add(planet);
                }                
            }
            return planetList.ToArray();
        }
    }    
}
