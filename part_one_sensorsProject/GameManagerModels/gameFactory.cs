using entities.agentModels;
using entities.SensorModels;

namespace gameFactory
{
    public enum SensorsBank
    {
        ThermalSensor,
        AudioSensor
    }
    public class GameFactory
    {
        public static ThermalSensor ThermalSensor =  new ThermalSensor();
        public static AudioSensor AudioSensor = new AudioSensor();
        public static List<ISensor> Sensors = new(){ThermalSensor,AudioSensor };
        
        public static void UpdateSensorsSet(List<ISensor> sensors)
        {
            foreach (ISensor sensor in sensors)
            {

                Sensors.Add(sensor);
            }
        }

        public static SensorsBank GetEnumSensorByIndex(int index)
        {
            SensorsBank[] values = (SensorsBank[])Enum.GetValues(typeof(SensorsBank));

            return values[index];

        }
        public static SeniorAgent GenerateSeniorAgent()
        {
            Random rnd = new Random();
            SeniorAgent agent = new SeniorAgent();
            for (int i = 0; i < agent.Score; i++)
            {                                                           
                int index = rnd.Next(0, Sensors.Count);                    // choosing a random sensor by lotting its index in sensors list
                SensorsBank sensor = GetEnumSensorByIndex(index);
                agent.AddSensibility(sensor);
            }
            return agent;

        }

       

        public static JuniorAgent GenerateJuniorAgent() 
        {
            Random rnd = new Random();
            JuniorAgent agent = new JuniorAgent();
            for (int i = 0; i < agent.Score; i++)
            {
                int index = rnd.Next(0, Sensors.Count);
                SensorsBank sensor = GetEnumSensorByIndex(index); 
                agent.AddSensibility(sensor);
            }
            return agent;
        }


        public static bool Attack(Enum sensor,Agent agent)
        {
            if (agent.HasSensor(sensor) && agent.sensibilities[sensor] >1 && agent.Score == 1)
            {
                agent.Score--;
                agent.sensibilities[sensor]--;
                Console.WriteLine(" good job! you have discovered all sensors on this agent and complete the mission");
                return true;
            }
            else if (agent.HasSensor(sensor) && agent.sensibilities[sensor] > 1)
            {
                agent.Score--;
                agent.sensibilities[sensor]--;
                Console.WriteLine($"good job! you have discovered an important intelligence information of the agent you have {agent.Score - 1} sensors left to discover");
            }
            else { Console.WriteLine("not one of his sensors, try another one"); }
            return false;
        }
    }


}