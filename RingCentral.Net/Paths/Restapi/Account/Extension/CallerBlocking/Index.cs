using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/caller-blocking";
        }

        // Operation: Get Caller Blocking Settings
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking
        public async Task<RingCentral.CallerBlockingSettings> Get()
        {
            return await rc.Get<RingCentral.CallerBlockingSettings>(this.Path());
        }

        // Operation: Update Caller Blocking Settings
        // Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking
        public async Task<RingCentral.CallerBlockingSettings> Put(
            RingCentral.CallerBlockingSettingsUpdate callerBlockingSettingsUpdate)
        {
            return await rc.Put<RingCentral.CallerBlockingSettings>(this.Path(), callerBlockingSettingsUpdate);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallerBlocking.Index CallerBlocking()
        {
            return new Restapi.Account.Extension.CallerBlocking.Index(this);
        }
    }
}