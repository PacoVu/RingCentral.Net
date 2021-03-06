using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.IvrMenus
{
    public partial class Index
    {
        public RestClient rc;
        public string ivrMenuId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string ivrMenuId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.ivrMenuId = ivrMenuId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ivrMenuId != null)
            {
                return $"{parent.Path()}/ivr-menus/{ivrMenuId}";
            }

            return $"{parent.Path()}/ivr-menus";
        }

        // Operation: Create IVR Menu
        // Http Post /restapi/v1.0/account/{accountId}/ivr-menus
        public async Task<RingCentral.IVRMenuInfo> Post(RingCentral.IVRMenuInfo iVRMenuInfo)
        {
            return await rc.Post<RingCentral.IVRMenuInfo>(this.Path(false), iVRMenuInfo);
        }

        // Operation: Get IVR Menu
        // Http Get /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}
        public async Task<RingCentral.IVRMenuInfo> Get()
        {
            if (this.ivrMenuId == null)
            {
                throw new System.ArgumentNullException("ivrMenuId");
            }

            return await rc.Get<RingCentral.IVRMenuInfo>(this.Path());
        }

        // Operation: Update IVR Menu
        // Http Put /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}
        public async Task<RingCentral.IVRMenuInfo> Put(RingCentral.IVRMenuInfo iVRMenuInfo)
        {
            if (this.ivrMenuId == null)
            {
                throw new System.ArgumentNullException("ivrMenuId");
            }

            return await rc.Put<RingCentral.IVRMenuInfo>(this.Path(), iVRMenuInfo);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.IvrMenus.Index IvrMenus(string ivrMenuId = null)
        {
            return new Restapi.Account.IvrMenus.Index(this, ivrMenuId);
        }
    }
}