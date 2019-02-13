using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public RestClient rc;
        public string groupId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string groupId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.groupId = groupId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && groupId != null)
            {
                return $"{parent.Path()}/call-queues/{groupId}";
            }

            return $"{parent.Path()}/call-queues";
        }

        public class GetQueryParams
        {
            // Indicates the page number to retrieve. Only positive number values are accepted
            public string page;

            // Indicates the page size (number of items)
            public string perPage;

            // Internal identifier of an extension that is a member of every group within the result
            public string memberExtensionId;
        }

        public async Task<RingCentral.CallQueues> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.CallQueues>(this.Path(false), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallQueues.Index CallQueues(string groupId = null)
        {
            return new Restapi.Account.CallQueues.Index(this, groupId);
        }
    }
}