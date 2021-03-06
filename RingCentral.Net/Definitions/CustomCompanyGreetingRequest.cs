namespace RingCentral
{
    public class CustomCompanyGreetingRequest
    {
        // Type of a greeting
        // Enum: Company, StartRecording, StopRecording, AutomaticRecording
        public string type;

        // Information on an answering rule that the greeting is applied to
        public CustomCompanyGreetingAnsweringRuleInfo answeringRule;

        // Information on a greeting language. Supported for types 'StopRecording', 'StartRecording', 'AutomaticRecording'
        public CustomCompanyGreetingLanguageInfoRequest language;

        // Custom greeting audio
        public Attachment audio;
    }
}