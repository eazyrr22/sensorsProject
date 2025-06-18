
namespace entities.agentModels
{
    public class SeniorAgent : Agent
    {
        public Ranks Rank { get; set; } = Ranks.Senior;
        public string Name { get; } = "senior_agent";
        public int Score { get; set; } = 4;

    }
    
}