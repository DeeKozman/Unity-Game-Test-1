namespace GameStuff.Interfaces
{

    public interface IPlayer 
    {
        int Experience { get; set; }
        int Level { get; set; }
        int MaxHealth { get;}
        int CurrentHealth { get; set; }


        void GenerateStats();

    }
}