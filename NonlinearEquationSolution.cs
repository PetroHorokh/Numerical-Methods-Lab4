namespace Lab4;

public static class NonlinearEquationSolution
{
    public static void DivisionInHalf(double x0, double x1, double e, double x)
    {
        var a = x0;
        var b = x1;
        double root;
        int counter = 0;
        do
        {
            var c = (a + b) / 2;

            if (Function(c) * Function(a) < 0) b = c;
            else a = c;

            counter++;

            root = (a + b) / 2;

            Console.WriteLine($"Iteration {counter}");
            Console.WriteLine($"Left edge: {(a > b ? a : b)}; middle: {root}; right edge: {(a < b ? a : b)}\n");

        } while (Math.Abs(a - b) >= e);

        Console.WriteLine($"Root: {root}");
        Console.WriteLine($"Incoherency: {Math.Abs(x - root)}\n");
    }

    public static void SecantAlgorithm(double x0, double x1, double root, double e)
    {
        var counter = 0;
        var priorX0 = x0;
        var priorX1 = x0;
        var newX = x1;

        do
        {
            priorX0 = priorX1;
            priorX1 = newX;
            
            newX = priorX1 - ((priorX1 - priorX0) * Function(priorX1)) / (Function(priorX1) - Function(priorX0));

            counter++;

            Console.WriteLine($"Iteration: {counter}");
            Console.WriteLine($"Root: {newX}\n");

        } while (Math.Abs(newX - priorX1) >= e || Math.Abs(Function(newX)) >= e);

        Console.WriteLine($"Amount of iterations: {counter}");
        Console.WriteLine($"Incoherency: {Math.Abs(newX - root)}\n");
    }

    private static double Function(double x) => (Math.Pow(x, 3) - 10 - Math.Sqrt(x - 2));
}