namespace Fours_HW
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter amount of Cubes\n-> ");
            double Cube = Convert.ToDouble (Console.ReadLine());
            //Console.WriteLine(Cube);
            Construct(Cube);
            Console.WriteLine($"Count: {Result(Cube)}");
            
        }
        static void Construct(double Cube, double CubeTest = -2, int count = 0)
        {
            if (CubeTest == -2)
                CubeTest = Math.Floor(Cube / 2);

            for (double i = CubeTest; i <= Math.Floor(Cube / 2) && count < Cube && i >= 0; i++)
            {
                Console.Write("[:]");
                count++;
            }
            Console.WriteLine();
            //Console.WriteLine(count);
            if (CubeTest <= Cube && CubeTest > 0) { Construct(Cube, CubeTest - 1, count); }
        }

        static double Result(double a, double i = 2, double count = 0)
        {
            if (a > 0) { return Result(a - i, i + 2, count + 1); }
            else { return count; }
        }
    }
}
