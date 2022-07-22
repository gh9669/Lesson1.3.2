using System;

namespace Lesson1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Character[] characters = new Character[3];
            characters[0] = new Knight();
            characters[1] = new Mage();
            characters[2] = new Archer();

            foreach (Character character in characters)
            {
                character.Attack();
            }
        }
    }

    public abstract class Character
    {
        private int _level;
        private float _experience;

        private int _money;

        public int Money { get => _money; private set => _money = value; }
        public int Level { get => _level; set => _level = value; }
        public float Experience { get => _experience; private set => _experience = value; }

        public float Health;
        public float Damage;

        public abstract void Attack();
    }

    public class Knight : Character
    {
        private string _swordItemId;
        private string _shielddItemId;
        private string _armorItemId;

        public float ShieldDurability;
        public float ArmorDurability;

        public string SwordItemId { get => _swordItemId; private set => _swordItemId = value; }
        public string ShielddItemId { get => _shielddItemId; private set => _shielddItemId = value; }
        public string ArmorItemId { get => _armorItemId; private set => _armorItemId = value; }

        public override void Attack()
        {
            Console.WriteLine("knight hits with a sword!");
        }

    }

    public class Mage : Character
    {
        private float _manaMax;
        private string _spellBookItemId;
        private string _staffItemId;
        private int _numberOfSpeels;

        public float Mana;

        public float ManaMax { get => _manaMax; private set => _manaMax = value; }
        public string SpellBookItemId { get => _spellBookItemId; private set => _spellBookItemId = value; }
        public string StaffItemId { get => _staffItemId; private set => _staffItemId = value; }
        public int NnumberOfSpeels { get => _numberOfSpeels; private set => _numberOfSpeels = value; }

        public override void Attack()
        {
            Console.WriteLine("Mage casts a speel!");
        }

    }

    public class Archer : Character
    {
        private string _bowItemId;
        private string _arrowItemId;
        private int _numberOfArrows;
        private int _maxnumberOfArrows;
        private bool _hasMeleeAttack;

        public string bowItemId { get => _bowItemId; private set => _bowItemId = value; }
        public string ArrowItemId { get => _arrowItemId; private set => _arrowItemId = value; }
        public int NumberOfArrows { get => _numberOfArrows; set => _numberOfArrows = value; }
        public int maxnumberOfArrows { get => _maxnumberOfArrows; private set => _maxnumberOfArrows = value; }
        public bool hasMeleeAttack { get => _hasMeleeAttack; private set => _hasMeleeAttack = value; }

        public override void Attack()
        {
            Console.WriteLine("Archer shoots with a bow!");
        }

    }

    public abstract class Enemy
    {
        private float _minCharacterLevelToSpawn;
        private bool _isRanged;
        private bool _hasMagicResistance;

        public float Health;
        public float Damage;

        public float minCharacterLevelToSpawn { get => _minCharacterLevelToSpawn; private set => _minCharacterLevelToSpawn = value; }
        public bool isRanged { get => _isRanged; private set => _isRanged = value; }
        public bool hasMagicResistance { get => _hasMagicResistance; set => _hasMagicResistance = value; }

        public abstract void Spawn();
    }

    public abstract class Boss : Enemy
    {
        private string _difficity;
        private string[] _lootIds;
        private string _location;

        public int NumberOfTimesKilled;
        public int NumberOfCharacterKilled;

        public string difficity { get => _difficity; private set => _difficity = value; }
        public string[] lootIds { get => _lootIds; private set => _lootIds = value; }
        public string location { get => _location; private set => _location = value; }

        public override void Spawn()
        {
            Console.WriteLine("A boss has been spawned");
        }
    }

    public abstract class Undead : Enemy
    {
        private int _maxresurrectionscount;
        private bool _hasrangeattackresistance;
        private bool _isspawnedbyboss;
        private Enemy _originalenemy;

        public int resurrectionscount;

        public int maxresurrectionscount { get => _maxresurrectionscount; private set => _maxresurrectionscount = value; }
        public bool hasrangeattackresistance { get => _hasrangeattackresistance; private set => _hasrangeattackresistance = value; }
        public bool isspawnedbyboss { get => _isspawnedbyboss; private set => _isspawnedbyboss = value; }
        public Enemy originalenemy { get => _originalenemy; private set => _originalenemy = value; }

        public override void Spawn()
        {
            Console.WriteLine("An Undead enemy has been spawned");
        }
    }

    public abstract class Wildboar : Enemy
    {
        private bool _dropsfood;

        public float Size;
        public float Weight;
        public float Speed;
        public bool isagressive;

        public bool dropsfood { get => _dropsfood; private set => _dropsfood = value; }
        
        public override void Spawn()
        {
            Console.WriteLine("A wild boar has been spawned");
        }
    }



}
