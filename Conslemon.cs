namespace CsharpProgOpdr
{
    internal partial class Program
    {
        

        class ConsoleMon 
        {
            private List<Skill> skills;
            internal int health;

            internal int energy;

            readonly string name ;

            internal void TakeDamage(int damage)
            {
                health -= damage;
            }

            internal void DepleteEnergy(int energy)
            {
                this.energy -= energy;
            }


        }
    }

}