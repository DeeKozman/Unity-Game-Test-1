namespace ItemGen
{
    public class GameItem


    {
/*
            private bool _agilityMod;
    
            private float _attackSpeed;
            private float _chanceToHit;
            private float _damageOnHit;
            private float _damagePerSecond;
    
            private bool _hasModifier;
            private bool _intellectMod;
            private int _itemCostToBuy;
            private int _itemCostToSell;
            private ItemKind _itemKind;
            private int _itemLevel;
            private string _itemNameModified;
            private string _itemSlug;
            private ItemTypes _itemTypes;
            private int _modifierAmount;
    
            private Random _rando;
            private bool _strengthMod;
    
            public GameItem()
            {
                _itemLevel = 1;
                ItemName = "";
                _itemTypes = 0;
                _itemKind = 0;
                _itemSlug = "";
            }
    
            public GameItem(string name, string nameMod, int level, ItemTypes type, ItemKind subKind, string slug,
                int costBuy, int costSell, bool hasMod, int modAmount, bool strengthMod, bool agilityMod, bool intellectMod,
                float attackSpeed, float damageOnHit, float chanceToHit, float damagePS)
            {
                ItemName = name;
                _itemLevel = level;
                _itemTypes = type;
                _itemKind = subKind;
                _itemSlug = slug;
                _itemCostToBuy = costBuy;
                _itemCostToSell = costSell;
                _hasModifier = hasMod;
                _modifierAmount = modAmount;
                _strengthMod = strengthMod;
                _agilityMod = agilityMod;
                _intellectMod = intellectMod;
                _attackSpeed = attackSpeed;
                _damageOnHit = damageOnHit;
                _chanceToHit = chanceToHit;
                _damagePerSecond = damagePS;
            }
    
            public ItemTypes ItemType { get; set; }
            public ItemKind ItemSubKind { get; set; }
    
    
            public int ItemLevel
            {
                get
                {
                    _itemLevel = _rando.Next(1, 11);
                    return _itemLevel;
                }
                set { _itemLevel = value; }
            }
    
    
            public string ItemNameModified
            {
                get { return _itemNameModified = "nothing"; }
                set { _itemNameModified = value; }
            }
    
            public string ItemName { get; set; }
    
    
            public string ItemSlug { get; set; }
    
            public int ItemCostToBuy
            {
                get { return _itemCostToBuy = 200; }
                set { _itemCostToBuy = value; }
            }
    
            public int ItemCostToSell
            {
                get { return _itemCostToSell = 100; }
                set { _itemCostToSell = value; }
            }
    
            public bool HasModifier
            {
                get
                {
                    var x = _rando.Next(0, 1);
                    _hasModifier = x > 0 ? true : false;
                    return _hasModifier;
                }
            }
    
            public int ModifierAmount
            {
                get
                {
                    var randomfactor = _rando.Next(1, 5);
                    _modifierAmount = _itemLevel / 2 * randomfactor;
    
                    return _modifierAmount;
                }
            }
    
            public bool StrengthMod
            {
                get { return _strengthMod = false; }
                set { _strengthMod = value; }
            }
    
            public bool AgilityMod
            {
                get { return _agilityMod = false; }
                set { _agilityMod = value; }
            }
    
            public bool IntellectMod
            {
                get { return _intellectMod = false; }
                set { _intellectMod = value; }
            }
    
            public float AttackSpeed
            {
                get { return _attackSpeed = 2f; }
                set { _attackSpeed = value; }
            }
    
            public float DamageOnHit
            {
                get { return _damageOnHit = 2f; }
                set { _damageOnHit = value; }
            }
    
            public float ChanceToHit
            {
                get { return _chanceToHit = 2f; }
                set { _chanceToHit = value; }
            }
    
            public float DamagePerSecond
            {
                get { return _damagePerSecond = 2f; }
                set { _damagePerSecond = value; }
            }
        }*/
    }
}