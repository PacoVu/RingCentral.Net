using Newtonsoft.Json;

namespace RingCentral
{
    public class CustomCompanyGreetingRequest : Serializable
    {
        // Type of a greeting
        public string type;
        // Information on an answering rule that the greeting is applied to
        public CustomCompanyGreetingAnsweringRuleInfo answeringRule;
        // Information on a greeting language. Supported for types 'StopRecording', 'StartRecording', 'AutomaticRecording'
        public CustomCompanyGreetingLanguageInfoRequest language;
    }
}