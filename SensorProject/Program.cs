using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SquadLeader s1 = new SquadLeader();

            //foreach (string wk in s1.Weaknesses)
            //{
            //    Console.WriteLine(wk);
            //}

            Investigator.ImplementOneSensor("Audio", s1);
            Investigator.ImplementOneSensor("Audio", s1);
            Investigator.ImplementOneSensor("Audio", s1);
            Investigator.ImplementOneSensor("Audio", s1);
        }

    }
}
