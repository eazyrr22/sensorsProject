
namespace entities.agentModels
{
    public class JuniorAgent : Agent
    {
        public Ranks Rank { get; set; } = Ranks.Junior;
        public string Name { get; } = "junior_agent";
        public int Score { get; set; } = 2;

    }


    
}
