namespace JogoRPG.src.Entities
{
    public abstract class Hero
    {
        string Name;
        int Level;
        string Type;

        public string Name1 { get => Name; set => Name = value; }
        public int Level1 { get => Level; set => Level = value; }
        public string Type1 { get => Type; set => Type = value; }

        public Hero(string name, int level, string type){
            this.Name1 = name;
            this.Level1 = level;
            this.Type1 = type;
        }
        public Hero (){

        }

        public override string ToString()
        {
            return this.Name1 + " " + this.Level1 + " " + this.Type1;
        }
        public virtual string Attack(){
            return this.Name1 + " realizou um ataque contra seu oponente";
        }
    }
}