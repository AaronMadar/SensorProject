using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SensorProject
{
    abstract public class IranianAgent
    {
        public List<string> Weaknesses;
        public List<string> ImplantedSensors;
        public int count = 0;
        public int numOfWeakness;

        public IranianAgent()
        {
            Weaknesses = new List<string>();
            ImplantedSensors = new List<string>();

            InitializeWeaknesses();  // Appelle une méthode pour remplir les faiblesses
        }

        protected abstract void InitializeWeaknesses();

        public abstract void RevealAgent();
    }






    class FootSoldier : IranianAgent
    {
        protected override void InitializeWeaknesses()
        {
            numOfWeakness = 2;
            Random rnd = new Random();
            List<string> copySensor = new List<string>(Investigator.Sensor);

            for (int i = 0; i < 2; i++)  // toujours 2 capteurs
            {
                int index = rnd.Next(copySensor.Count);
                Weaknesses.Add(copySensor[index]);
                copySensor.RemoveAt(index);

            }
        }

        public override void RevealAgent()
        {
            if (count == 2)
            {
                Console.WriteLine("The agent has been successfully unmasked !");

            }
        }

    }






    class SquadLeader : IranianAgent
    {
        // Chef d’escouade
        protected override void InitializeWeaknesses()
        {
            numOfWeakness = 4;
            Random rnd = new Random();
            List<string> copySensor = new List<string>(Investigator.Sensor);

            for (int i = 0; i < 4; i++)  
            {
                int index = rnd.Next(copySensor.Count);
                Weaknesses.Add(copySensor[index]);
                copySensor.RemoveAt(index);
            }
        }

        public override void RevealAgent()
        {
            if (count == 4)
            {
                Console.WriteLine("The agent has been successfully unmasked !");

            }
        }

    }





    class SeniorCommander : IranianAgent
    {
        // Commandant senior
        protected override void InitializeWeaknesses()
        {
            numOfWeakness = 6;
            Random rnd = new Random();
            List<string> copySensor = new List<string>(Investigator.Sensor);

            for (int i = 0; i < 6; i++)
            {
                int index = rnd.Next(copySensor.Count);
                Weaknesses.Add(copySensor[index]);
                copySensor.RemoveAt(index);
            }
        }

        public override void RevealAgent()
        {
            if (count == 6)
            {
                Console.WriteLine("The agent has been successfully unmasked !");

            }
        }


    }






    class OrganizationLeader : IranianAgent
    {
        // Leader d’organisation (haut gradé)
        protected override void InitializeWeaknesses()
        {
            numOfWeakness = 8;
            Random rnd = new Random();
            List<string> copySensor = new List<string>(Investigator.Sensor);

            for (int i = 0; i < 8; i++)
            {
                int index = rnd.Next(copySensor.Count);
                Weaknesses.Add(copySensor[index]);
                copySensor.RemoveAt(index);
            }
        }
        public override void RevealAgent()
        {
            if (count == 8)
            {
                Console.WriteLine("The agent has been successfully unmasked !");

            }
        }




    }









}



