namespace InterfacesDemo
{
    public class Elf : Monster, IEquatable<Elf>, IAttack<Elf>
    {
        public double Health;

        public double Armour;
        private int Bow;
        private double Damage;

        public Elf(string name, int level) : base(name, level)
        {
            this.Health = level * 0.8;
            this.Armour = Health * 1.8;
            this.Bow = 4;
            this.Damage = level / Bow;
        }

        public bool Equals(Elf other) => this.Level == other.Level;

        override public string ToString()
        {
            return this.Name;
        }
        public double Attack(double armour)
        {
            return this.Damage;
        }
        public void TakeDamage(double damage)
        {
            if (this.Armour > 0)
            {
                this.Armour = this.Armour - damage;
            }
            else if (this.Health > 0)
            {
                this.Health = this.Health - damage;
            }
        }
    }
}