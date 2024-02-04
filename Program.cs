namespace Fours_HW
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter amount of Cubes\n-> ");
            double Cube = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine(Cube);
            Construct(Cube);
        }
        static void Construct(double Cube, double CubeTest = -2, int count = 0)
        {
            if (CubeTest == -2)
                CubeTest = Math.Floor(Cube / 2 - 1);

            for (double i = CubeTest; i < Cube / 2 - 1 && count < Cube; i++)
            {
                Console.Write("[:]");
                count++;
            }
            Console.WriteLine();
            //Console.WriteLine(count);
            if (CubeTest <= Cube && CubeTest > 0) { Construct(Cube, CubeTest - 1, count); }
        }
    }
}
