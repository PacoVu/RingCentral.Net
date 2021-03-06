namespace RingCentral
{
    public class GetVersionsResponse
    {
        // Canonical URI of the API version
        public string uri;

        // Full API version information: uri, number, release date
        public VersionInfo[] apiVersions;

        // Server version
        public string serverVersion;

        // Server revision
        public string serverRevision;
    }
}