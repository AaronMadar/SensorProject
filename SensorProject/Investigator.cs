using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorProject
{
    static public class Investigator
    {
        public static List<string> Sensor = new List<string>
    {
        "Audio",
        "Thermal",
        "Pulse",
        "Motion",
        "Magnetic",
        "Signal",
        "Light",
        "Radar"
    };



        public static void ImplementOneSensor(string sensor, IranianAgent soldier)
        {
            if (soldier.ImplantedSensors.Contains(sensor))
            {
                Console.WriteLine($"The sensor \"{sensor}\" has already been implemented!");
                return;
            }

            soldier.ImplantedSensors.Add(sensor);

            if (soldier.Weaknesses.Contains(sensor))
            {
                soldier.count++;
                Console.WriteLine($"Success: The sensor \"{sensor}\" has revealed a weakness! {soldier.count}/{soldier.numOfWeakness} ");
                soldier.RevealAgent();
            }
            else
            {
                Console.WriteLine($"Failure: The sensor \"{sensor}\" did not match any weakness.  {soldier.count}/{soldier.numOfWeakness}");
            }
        }



    }
}
