namespace RingCentral
{
    public class ExtensionRegionalSettingRequest
    {
        public ExtensionCountryInfoRequest homeCountry;

        public ExtensionTimezoneInfoRequest timezone;

        public ExtensionLanguageInfoRequest language;

        public ExtensionGreetingLanguageInfoRequest greetingLanguage;

        public ExtensionFormattingLocaleInfoRequest formattingLocale;

        // Time format setting
        // Default: 12h
        // Enum: 12h, 24h
        public string timeFormat;
    }
}