using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scenario:
            // Client --> AnotherggregationLib 1.0.0 --> BaseLib 1.0.0
            // Client --> AggregationLib 2.0.0 --> BaseLib 2.0.0

            // Actually use BaseLib 2.0.0
            Console.WriteLine(BaseLib.VersionInfo.CurrentVersion);

            // In AnotherAggregationLib 1.0.0, call to BaseLib 2.0.0 instead the BaseLib 1.0.0 it should be dependent to.
            // The problem is, the result of AggregationLib.Worker.GetBaseLibVersion() actually be "2.0.0" instead of expected "1.0.0".
            Console.WriteLine(AnotherAggregationLib.AnotherWorker.GetBaseLibVersion());

            // In AnotherAggregationLib 1.0.0, call to BaseLib 2.0.0 instead the BaseLib 1.0.0 it should be dependent to.
            // The problem is, BaseLib.VersionInfo.V1 have removed since BaseLib 2.0.0, so exception occurs at runtime once the 
            // AggregationLib.Worker.GetBaseLibV1Description() try to get BaseLib.VersionInfo.V1 which not exist, and I believe it will make
            // programers to waste much time to find the root cause out.
            Console.WriteLine(AnotherAggregationLib.AnotherWorker.GetBaseLibV1Description());

            Console.Read();
        }
    }
}
