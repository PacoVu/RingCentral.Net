using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class IVRMenuPromptInfo : Serializable
    {
        // Prompt mode: custom media or text
        // Enum: Audio, TextToSpeech
        public string mode;
        // For 'Audio' mode only. Prompt media reference
        public PromptLanguageInfo audio;
        // For 'TextToSpeech' mode only. Prompt text
        public string text;
        // For 'TextToSpeech' mode only. Prompt language metadata
        public AudioPromptInfo language;
    }
}