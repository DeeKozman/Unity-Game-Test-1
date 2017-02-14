namespace GameStuff.Interfaces
{
    // Player Stats floaterface

    public interface IPlayerStats
    {
        int IntellectBase { get; set; }
        int StrengthBase { get; set; }
        int AgilityBase { get; set; }
        int Intellect { get; set; }
        int Strength { get; set; }
        int Agility { get; set; }
        int IntellectModAmount { get; set; }
        int StrengthModAmount { get; set; }
        int AgilityModAmount { get; set; }

        void AddMods();
        void RemoveMods();
    }
}
