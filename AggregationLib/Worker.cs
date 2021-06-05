using BaseLib;

namespace AggregationLib
{
    public static class Worker
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
