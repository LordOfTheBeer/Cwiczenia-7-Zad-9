namespace Cwiczenia_7_Zad_9
{
    class Funkcje
    {
        public void Zamiana(ref int x,ref int y)
        {
            int tmp;
            tmp = x;
            x = y;
            y = tmp;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Funkcje f1 = new Funkcje();
            Console.WriteLine(a + " " + b);
            f1.Zamiana(ref a,ref b);
            Console.WriteLine(a + " " + b);

        }
    }
}