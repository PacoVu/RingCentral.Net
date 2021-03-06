namespace RingCentral
{
    public class GetCallRecordingResponse
    {
        // Internal identifier of a call recording
        public string id;

        // Link to a call recording binary content
        public string contentUri;

        // Call recording file format. Supported format is audio/x-wav
        public string contentType;

        // Recorded call duration
        public long? duration;
    }
}