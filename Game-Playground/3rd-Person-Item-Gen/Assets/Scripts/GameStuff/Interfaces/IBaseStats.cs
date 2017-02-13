namespace ItemGen.floaterfaces
{
    // Player Stats floaterface

    public interface IBaseStats
    {
        float IntellectBase { get;}
        float StrengthBase { get;  }
        float AgilityBase { get;}
        float Intellect { get; set; }
        float Strength { get; set; }
        float Agility { get; set; }
        float IntellectModAmount { get; set; }
        float StrengthModAmount { get; set; }
        float AgilityModAmount { get; set; }

    }
}
