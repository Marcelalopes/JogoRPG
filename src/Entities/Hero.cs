namespace JogoRPG.src.Entities
{
    public class Hero
    {
        string Name;
        int Level;
        string Type;

        public Hero(string name, int level, string type){
            this.Name = name;
            this.Level = level;
            this.Type = type;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Type;
        }
        public string Attack(){
            return this.Name + " realizou um ataque contra seu oponente";
        }
    }
}