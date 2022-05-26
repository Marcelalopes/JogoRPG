namespace JogoRPG.src.Entities
{
    public class Knigth : Hero
    {
        public Knigth(string name, int level, string type)
        {
            this.Name1 = name;
            this.Level1 = level;
            this.Type1 = type;
        }
        public override string Attack(){
            return this.Name1 + " realizou um ataque com sua espada";
        }
    }
}