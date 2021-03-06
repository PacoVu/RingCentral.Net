using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public RestClient rc;
        public string meetingId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string meetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.meetingId = meetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && meetingId != null)
            {
                return $"{parent.Path()}/meeting/{meetingId}";
            }

            return $"{parent.Path()}/meeting";
        }

        // Operation: Get Scheduled Meetings
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting
        public async Task<RingCentral.MeetingsResource> List()
        {
            return await rc.Get<RingCentral.MeetingsResource>(this.Path(false));
        }

        // Operation: Create Meetings
        // Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting
        public async Task<string> Post(RingCentral.MeetingRequestResource meetingRequestResource)
        {
            return await rc.Post<string>(this.Path(false), meetingRequestResource);
        }

        // Operation: Get Meeting Info
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        public async Task<RingCentral.MeetingResponseResource> Get()
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
            }

            return await rc.Get<RingCentral.MeetingResponseResource>(this.Path());
        }

        // Operation: Update Meeting
        // Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        public async Task<RingCentral.MeetingResponseResource> Put(
            RingCentral.MeetingRequestResource meetingRequestResource)
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
            }

            return await rc.Put<RingCentral.MeetingResponseResource>(this.Path(), meetingRequestResource);
        }

        // Operation: Delete Meeting
        // Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        public async Task<string> Delete()
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Meeting.Index Meeting(string meetingId = null)
        {
            return new Restapi.Account.Extension.Meeting.Index(this, meetingId);
        }
    }
}