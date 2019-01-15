using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GreetingInfo : Serializable
    {
        // Type of a greeting, specifying the case when the greeting is played.
        // Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, InterruptPrompt, HoldMusic, Custom, Company, BlockedCallersSpecific, BlockedCallersAll, BlockedNoCallerId, BlockedPayPhones, StartRecording, StopRecording, AutomaticRecording
        public string type;
        // Usage type of a greeting, specifying if the greeting is applied to user extension or department extension.
        // Enum: UserExtensionAnsweringRule, ExtensionAnsweringRule, DepartmentExtensionAnsweringRule, CompanyAnsweringRule, CompanyAfterHoursAnsweringRule, VoicemailExtensionAnsweringRule, AnnouncementExtensionAnsweringRule
        public string usageType;
        public PresetInfo preset;
    }
}