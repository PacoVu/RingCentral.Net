using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Recording
{
    public partial class Index
    {
        public RestClient rc;
        public string recordingId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string recordingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.recordingId = recordingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && recordingId != null)
            {
                return $"{parent.Path()}/recording/{recordingId}";
            }

            return $"{parent.Path()}/recording";
        }

        // Operation: Get Call Recording(s)
        // Http Get /restapi/v1.0/account/{accountId}/recording/{recordingId}
        public async Task<RingCentral.GetCallRecordingResponse> Get()
        {
            if (this.recordingId == null)
            {
                throw new System.ArgumentNullException("recordingId");
            }

            return await rc.Get<RingCentral.GetCallRecordingResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Recording.Index Recording(string recordingId = null)
        {
            return new Restapi.Account.Recording.Index(this, recordingId);
        }
    }
}