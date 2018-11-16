namespace InterfacesDemo
{
    public class Monster : IEquatable<Monster>
    {
        public int Level;
        public string Name;
        public Monster(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public bool Equals(Monster other)
        {
            return this.Level == other.Level;
        }

        override public string ToString(){
            return this.Name;
        }
    }
}
