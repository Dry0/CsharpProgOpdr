namespace CsharpProgOpdr
{
    internal partial class Program
    {
        private const string V = "name";

        class Conslemon 
        {
            int health;

            int energy;

            string name = V;

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