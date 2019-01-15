using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AccountLimits : Serializable
    {
        // Max number of free softphone phone lines per user extension
        public long? freeSoftPhoneLinesPerExtension;
        // Max number of participants in RingCentral meeting hosted by this account's user
        public long? meetingSize;
        // Meetings recording cloud storage limitaion in Gb
        public long? cloudRecordingStorage;
        // Max number of extensions which can be included in the list of users monitored for Presence
        public long? maxMonitoredExtensionsPerUser;
        // Max length of extension numbers of an account; depends on account type
        public long? maxExtensionNumberLength;
        // Length of a site code
        public long? siteCodeLength;
        // Length of a short extension number
        public long? shortExtensionNumberLength;
    }
}