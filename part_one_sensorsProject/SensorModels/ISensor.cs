namespace entities.SensorModels
{
    
    public interface ISensor
    {
        public int SerialCode { get; }
        public void Activate();

    }
}
