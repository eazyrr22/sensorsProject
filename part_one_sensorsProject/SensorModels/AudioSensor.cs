namespace entities.SensorModels
{
    public class AudioSensor : ISensor
    {
        public int SerialCode { get; } = 2;

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