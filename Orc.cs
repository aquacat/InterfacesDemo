namespace InterfacesDemo
{
    public class Orc : Monster, IEquatable<Orc>, IAttack<Orc>
    {
        public double Health;
        public double Armour;
        private int Club;
        private double Damage;
        public Orc(string name, int level) : base(name, level)
        {
            this.Health = level * 1.5;
            this.Armour = Health * 1.2;
            this.Club = 5;
            this.Damage = level / Club;
        }

        public bool Equals(Orc other) => this.Level == other.Level;

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