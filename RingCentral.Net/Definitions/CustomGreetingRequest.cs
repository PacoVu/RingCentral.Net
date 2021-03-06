namespace RingCentral
{
    public class CustomGreetingRequest
    {
        // Type of a greeting, specifying the case when the greeting is played.
        // Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic
        public string type;

        // Information on an answering rule that the greeting is applied to
        public CustomGreetingAnsweringRuleInfoRequest answeringRule;

        // Custom greeting audio
        public Attachment audio;
    }
}