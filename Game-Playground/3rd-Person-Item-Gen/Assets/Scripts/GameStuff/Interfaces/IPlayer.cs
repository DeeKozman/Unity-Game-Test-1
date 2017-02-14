namespace GameStuff.Interfaces
{

    public interface IPlayer 
    {
        int Experience { get; set; }
        int Level { get; set; }
        int MaxHealth { get; set; }
        int CurrentHealth { get; set; }


        void GenerateStats();

    }
}