using System;
using System.Text;

namespace ConsoleApplication3
{
    public class TestReporter
    {
        public TestReporter(TimedTestRunner tr)
        {
            _Runner = tr;
            _SB = new StringBuilder();
        }

        TimedTestRunner _Runner;
        StringBuilder _SB;

        public string Report(string header, Action action = null)
        {
            _SB.Clear();
            _SB.AppendLine(header);

            if (action != null)
                _Runner.Run(action);

            _SB.AppendLine($"{_Runner.Result}ms");
            return _SB.ToString();
        }
    }
}
