namespace RingCentral
{
    public class GlipNoteCreate
    {
        // Title of a note
        public string title; // Required

        // If a note should be immediately published then pass 'Active' value. This doesn't create a new post in the current group but as a result the note can be read by members of this group
        // Default: Draft
        // Enum: Active, Draft
        public string status;

        // Contents of a note
        public string body;
    }
}