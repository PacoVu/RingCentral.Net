using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Conferencing
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
            return $"{parent.Path()}/conferencing";
        }

        // Operation: Get User Conferencing Settings
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing
        public async Task<RingCentral.GetConferencingInfoResponse> Get(
            LoadConferencingInfoParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GetConferencingInfoResponse>(this.Path(), queryParams);
        }

        // Operation: Update User Conferencing Settings
        // Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing
        public async Task<RingCentral.GetConferencingInfoResponse> Put(
            RingCentral.UpdateConferencingInfoRequest updateConferencingInfoRequest)
        {
            return await rc.Put<RingCentral.GetConferencingInfoResponse>(this.Path(), updateConferencingInfoRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Conferencing.Index Conferencing()
        {
            return new Restapi.Account.Extension.Conferencing.Index(this);
        }
    }
}