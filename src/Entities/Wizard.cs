namespace JogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string type, int hearth, int power)
        {
            this.Name1 = name;
            this.Level1 = level;
            this.Type1 = type;
            this.Hearth1 = hearth;
            this.PowerAttack1 = power;
        }
        public override string Attack(int power){
            return this.Name1 + " lançou magia e tirou "+power+" vida(s) do seu oponente";
        }
    }
}