using entities.SensorModels;
namespace entities.agentModels
{
    public enum Ranks
    {
        Junior,
        Senior,
    }
public abstract class Agent

{
    public  Ranks Rank { get; set; }   
    public string Name { get; }

    public int Score { get; set; }                            // amount of sensibility sensor

    public  Dictionary<Enum, int> sensibilities = new Dictionary<Enum, int>();

    public Agent(string name = "agent_x")
    {
        this.Name = name;
    }

    public int GetSensibilitiesCount()
    {
        return this.sensibilities.Count;
    }
       
    public bool HasSensor(Enum sensor)
    {
        return this.sensibilities.ContainsKey(sensor);
    }

    public void AddSensibility(Enum sensor, int sum = 1)
        {
            if (this.sensibilities.ContainsKey(sensor))
            {
                sensibilities[sensor] += 1;
                Score += sensibilities[sensor];
            }
            else
            {
                sensibilities.Add(sensor, sum);
                Score += sum;

            }
        }

        //public void IncreaseSensorAmount(ISensor sensor, int sum)
        //{
        //    if (this.sensibilities.ContainsKey(sensor.SerialCode))
        //    {
        //        this.sensibilities[sensor.SerialCode] += sum;
        //        Score += sum;

        //    }
        //    else
        //    {
        //        Console.WriteLine("sensor was not found");
        //    }

        //}

        //public void RemoveSensibility(ISensor sensor)
        //{
        //    if (this.sensibilities.ContainsKey(sensor.SerialCode))
        //    {
        //        Score -= sensibilities[sensor.SerialCode];
        //        sensibilities.Remove(sensor.SerialCode);

        //    }
        //    else
        //    {
        //        { Console.WriteLine("sensor was not found"); }
        //    }
        //}
        //public void DecreaseSensorAmount(ISensor sensor,int sum = 1)
        //{
        //    if (this.sensibilities.ContainsKey(sensor.SerialCode) && this.sensibilities[sensor.SerialCode] > 1)
        //    {
        //        this.sensibilities[sensor.SerialCode] -= sum;
        //        Score -= sum;

        //    }
        //    else if (sensor.SerialCode == 1)
        //    {
        //        Score -= sensibilities[sensor.SerialCode];
        //        this.sensibilities.Remove(sensor.SerialCode);

        //    }
        //    else
        //    {
        //        Console.WriteLine("sensor not found");
        //    }
        //}


    }
}