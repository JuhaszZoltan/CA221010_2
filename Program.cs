namespace CA221010_2
{
    public abstract class Jarmu
    {
        public int TankMeret { get; set; }
        public float BenzinMennyiseg { get; set; } = 0;
        public int SzallithatoSzemelyekSzama { get; set; }

        public abstract void Tankol(float benzin);
    }

    public class Gepkocsi : Jarmu
    {
        public override void Tankol(float benzin)
        {
            BenzinMennyiseg += benzin;
        }

        public Gepkocsi()
        {
            TankMeret = 80;
            SzallithatoSzemelyekSzama = 5;
        }
    }

    public class Motorkerekpar : Jarmu
    {
        public override void Tankol(float benzin)
        {
            if (BenzinMennyiseg + benzin <= TankMeret)
                BenzinMennyiseg += benzin;
            else
            {
                Console.WriteLine($"Tank tele," +
                    $" maradt még {BenzinMennyiseg + benzin - TankMeret} liter benzin!");
                BenzinMennyiseg = TankMeret;
            }
        }

        public Motorkerekpar()
        {
            TankMeret = 10;
            SzallithatoSzemelyekSzama = 2;
        }
    }

    public class Tesla : Jarmu
    {
        public override void Tankol(float benzin)
        {
            Console.WriteLine($"nem kell a {benzin} liter benzin,\nDugd be a konektorba!");
            BenzinMennyiseg = TankMeret;
        }
    }


    internal class Program
    {
        static void Main()
        {
            Jarmu g1 = new Gepkocsi();
            Jarmu m1 = new Motorkerekpar();
            Jarmu t1 = new Tesla();


            List<Jarmu> jarmuvek = new List<Jarmu>() { g1, m1, t1, };

            foreach (var j in jarmuvek)
            {
                j.Tankol(10f);
            }

            ValamelyikFeladat();
        }

        private static void ValamelyikFeladat()
        {
            Console.WriteLine("hello world!");
        }
    }
}