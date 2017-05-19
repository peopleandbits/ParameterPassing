using System;

namespace ConsoleApplication3
{
    class Program
    {
        static Car _Car = new Car();
        static ATODParams _AtoD = new ATODParams(1, 2, 3, 4);
        static ETOIParams _EtoI = new ETOIParams(5, 6, 7, 8, 9);

        static void Main(string[] args)
        {
            var runner = new TimedTestRunner();
            var reporter = new TestReporter(runner);

            Console.WriteLine(reporter.Report("Dummy:", Dummy));
            Console.WriteLine(reporter.Report("0 parameters:", Run0));
            Console.WriteLine(reporter.Report("3 parameters:", Run3));
            Console.WriteLine(reporter.Report("9 parameters:", Run9));
            Console.WriteLine(reporter.Report("12 parameters (2 chunks):", Run12Chunked));
        }

        static void Dummy()
        {
        }

        static void Run0()
        {
            _Car.ZeroDrive();
        }

        static void Run3()
        {
            _Car.SimpleDrive(1, 2, 3);
        }

        static void Run9()
        {
            _Car.ComplexDrive(1, 2, 3, 4, 5, 6, 7, 8, 9);
        }

        static void Run12Chunked()
        {
            _Car.OptimalDrive(_AtoD, _EtoI);
        }
    }
}