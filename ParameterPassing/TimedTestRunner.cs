using System;
using System.Diagnostics;

namespace ConsoleApplication3
{
    public class TimedTestRunner
    {
        public TimedTestRunner(int iterationsPerTest = 100000000)
        {
            _Iterations = iterationsPerTest;
            _Clock = new Stopwatch();
        }

        public int Result { get; set; }

        Stopwatch _Clock;
        int _Iterations;

        public void Run(Action action)
        {
            _Clock.Reset();
            _Clock.Start();

            for (int i = 0; i < _Iterations; i++)
                action();

            _Clock.Stop();

            Result = (int)_Clock.ElapsedMilliseconds;
        }
    }
}
