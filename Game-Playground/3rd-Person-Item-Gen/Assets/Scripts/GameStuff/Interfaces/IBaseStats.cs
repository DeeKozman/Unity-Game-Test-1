namespace GameStuff.Interfaces
{
    // Player Stats floaterface

    public interface IBaseStats
    {
        int IntellectBase { get; set; }
        int StrengthBase { get;  }
        int AgilityBase { get; set; }
        int Intellect { get; set; }
        int Strength { get; set; }
        int Agility { get; set; }
        int IntellectModAmount { get; set; }
        int StrengthModAmount { get; set; }
        int AgilityModAmount { get; set; }

    }
}
