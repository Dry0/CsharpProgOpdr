namespace CsharpProgOpdr
{
    internal partial class Program
    {
        class Skill
        {
            internal int damage = 5;

            internal int energyCost = 5;

            internal string name = "name";


            internal void UseOn(ConsoleMon target, ConsoleMon caster) // dit zijn arguments (ConsoleMon target, ConsoleMon caster)
            {
                caster.DepleteEnergy(energyCost);
                target.TakeDamage(damage);
            }
        }
    }
}