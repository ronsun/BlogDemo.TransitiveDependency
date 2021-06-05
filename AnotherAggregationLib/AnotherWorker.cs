using BaseLib;

namespace AnotherAggregationLib
{
    public class AnotherWorker
    {
        public static string GetBaseLibVersion()
        {
            return VersionInfo.CurrentVersion;
        }

        public static string GetBaseLibV1Description()
        {
            return VersionInfo.V1;
        }
    }
}
