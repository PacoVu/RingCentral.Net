using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-recording";
        }

        // Operation: Get Call Recording Settings
        // Http Get /restapi/v1.0/account/{accountId}/call-recording
        public async Task<RingCentral.CallRecordingSettingsResource> Get()
        {
            return await rc.Get<RingCentral.CallRecordingSettingsResource>(this.Path());
        }

        // Operation: Update Call Recording Settings
        // Http Put /restapi/v1.0/account/{accountId}/call-recording
        public async Task<RingCentral.CallRecordingSettingsResource> Put(
            RingCentral.CallRecordingSettingsResource callRecordingSettingsResource)
        {
            return await rc.Put<RingCentral.CallRecordingSettingsResource>(this.Path(), callRecordingSettingsResource);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallRecording.Index CallRecording()
        {
            return new Restapi.Account.CallRecording.Index(this);
        }
    }
}