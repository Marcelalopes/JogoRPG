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
            if (Bonus > 6)
                return this.Name1 + " lançou uma super magia com o bonus de ataque de "+Bonus;
            else
                return this.Name1 + " lançou uma magia de força fraca com um de ataque de "+Bonus;
        }
    }
}