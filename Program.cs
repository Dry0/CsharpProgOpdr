namespace CsharpProgOpdr
{

    internal class ConsoleMon 
    {
        internal int health;
        internal int energy;
        public ConsoleMon() 
        {
         
        }
        internal void TakeDamage (int damage) 
        {

        }
        internal void DepleteEnergy(int energy) 
        {

        }
    }
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.health == -100);

            Console.WriteLine(mon.energy == -20);
        }
    }
}