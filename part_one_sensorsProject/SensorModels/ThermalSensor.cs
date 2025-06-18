namespace entities.SensorModels
{
    public class ThermalSensor : ISensor
    {
        public int SerialCode { get; } = 1;
        private bool Active = false;

        public void Activate()
        {
            if (!Active)
            {
                Active = true;
            }
        }

    }
}