using BaseLib;

namespace AggregationLib
{
    public static class Worker
    {
        public static string GetBaseLibVersion()
        {
            return VersionInfo.CurrentVersion;
        }

        public static string GetBaseLibV2Description()
        {
            return VersionInfo.V2;
        }
    }
}
