using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SensorProject
{
    abstract class IranianAgent
    {
        protected List<string> Weaknesses;
        protected List<string> ImplantedSensors;

        public IranianAgent()
        {
            Weaknesses = new List<string>();
            ImplantedSensors = new List<string>();
            InitializeWeaknesses();  // Appelle une méthode pour remplir les faiblesses
        }

        protected abstract void InitializeWeaknesses();
    }

    class FootSoldier : IranianAgent
    {
        protected override void InitializeWeaknesses()
        {
            Random rnd = new Random();
            List<string> copySensor = new List<string>(AllSensor.Sensor);

            for (int i = 0; i < 2; i++)  // toujours 2 capteurs
            {
                int index = rnd.Next(copySensor.Count);
                Weaknesses.Add(copySensor[index]);
                copySensor.RemoveAt(index);

            }
        }

    }

    class SquadLeader : IranianAgent
    {
        // Chef d’escouade
        protected override void InitializeWeaknesses()
        {
            Random rnd = new Random();
            List<string> copySensor = new List<string>(AllSensor.Sensor);

            for (int i = 0; i < 4; i++)  
            {
                int index = rnd.Next(copySensor.Count);
                Weaknesses.Add(copySensor[index]);
                copySensor.RemoveAt(index);
            }
        }

    }





    class SeniorCommander : IranianAgent
    {
        // Commandant senior
        protected override void InitializeWeaknesses()
        {
            Random rnd = new Random();
            List<string> copySensor = new List<string>(AllSensor.Sensor);

            for (int i = 0; i < 6; i++)
            {
                int index = rnd.Next(copySensor.Count);
                Weaknesses.Add(copySensor[index]);
                copySensor.RemoveAt(index);
            }
        }


    }

    class OrganizationLeader : IranianAgent
    {
        // Leader d’organisation (haut gradé)
        protected override void InitializeWeaknesses()
        {
            Random rnd = new Random();
            List<string> copySensor = new List<string>(AllSensor.Sensor);

            for (int i = 0; i < 8; i++)
            {
                int index = rnd.Next(copySensor.Count);
                Weaknesses.Add(copySensor[index]);
                copySensor.RemoveAt(index);
            }
        }




    }









}



