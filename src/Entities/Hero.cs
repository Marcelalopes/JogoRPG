namespace JogoRPG.src.Entities
{
    public abstract class Hero
    {
        string Name;
        int Level;
        string Type;
        int Hearth;
        int PowerAttack;
        int TotalHeart;

        public string Name1 { get => Name; set => Name = value; }
        public int Level1 { get => Level; set => Level = value; }
        public string Type1 { get => Type; set => Type = value; }
        public int Hearth1 { get => Hearth; set => Hearth = value; }
        public int PowerAttack1 { get => PowerAttack; set => PowerAttack = value; }
        public int TotalHeart1 { get => TotalHeart; set => TotalHeart = value; }

        public Hero(string name, int level, string type, int hearth, int power){
            this.Name1 = name;
            this.Level1 = level;
            this.Type1 = type;
            this.Hearth1 = hearth;
            this.PowerAttack1 = power;
        }
        public Hero (){

        }

        public override string ToString()
        {
            return this.Name1 + " " + this.Level1 + " " + this.Type1;
        }
        public virtual string Attack(int power){
            return this.Name1 + " realizou um ataque de "+power+" contra seu oponente";
        }
    }
}