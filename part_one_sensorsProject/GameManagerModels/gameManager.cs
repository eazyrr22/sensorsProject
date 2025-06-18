using entities.agentModels;
using entities.SensorModels;
using gameFactory;


namespace GameManagement
{
    public class GameManager
    {

        public static void StartGame() 
        {
            List<ISensor> SensorsList = gameFactory.GameFactory.Sensors;
            Agent agent = gameFactory.GameFactory.GenerateJuniorAgent();
            Menu(agent);
        }

        public static void Menu(Agent agent)
        {
            bool win = false;
            Console.WriteLine("Let's start playing!\nyou are interviewing an enemy's agent\n and you have to activate all his sensors\n to discover all the information you need\nin every round you can choose only one sensor\n be careful you have a limit amount of try");
            do
            {
                Console.WriteLine($"what's your guess?\n1.{gameFactory.SensorsBank.ThermalSensor}\n2.{gameFactory.SensorsBank.AudioSensor}");
                bool Parsed = int.TryParse(Console.ReadLine(), out int input);
                if (Parsed)
                {
                    switch (input)
                    {
                        case 1:
                          win =  gameFactory.GameFactory.Attack(gameFactory.SensorsBank.ThermalSensor,agent);
                            break;
                            case 2:
                           win =  gameFactory.GameFactory.Attack(gameFactory.SensorsBank.AudioSensor, agent);
                            break;
                    }
                }
            }
            while (!win);
        }   
        //public static void AgentExposed(ISensor sensor, Agent agent, int sum = 1)
        //{
        //    if (agent.HasSensor(sensor) && agent.Score > 0)
        //    {
        //        agent.DecreaseSum(sensor, 1);
        //        Console.WriteLine($"good job! you have uncovered {sum}/{agent.Score} sensors");
        //    }
        //    else
        //    {
        //        Console.WriteLine("this agent does not have this sensor try another one");
        //    }
        //}
    }
}