namespace JogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string type)
        {
            this.Name1 = name;
            this.Level1 = level;
            this.Type1 = type;
        }
        public override string Attack(){
            return this.Name1 + " lançou magia";
        }

        public string Attack(int Bonus){
            return this.Name1 + " lançou magia com o bonus de ataque de "+Bonus;
        }
    }
}