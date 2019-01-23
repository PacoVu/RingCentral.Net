namespace RingCentral
{
    public class GetUserBusinessHoursResponse : Serializable
    {
        // Canonical URI of a business-hours resource
        public string uri;

        // Schedule when an answering rule is applied
        public ScheduleInfoUserBusinessHours schedule;
    }
}