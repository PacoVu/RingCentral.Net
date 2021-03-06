using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Entries
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Directory.Index parent;

        public Index(Restapi.Account.Directory.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/entries";
        }

        // Operation: Get Company Directory Entries
        // Http Get /restapi/v1.0/account/{accountId}/directory/entries
        public async Task<RingCentral.DirectoryResource> Get(ListDirectoryEntriesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.DirectoryResource>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Restapi.Account.Directory.Entries.Index Entries()
        {
            return new Restapi.Account.Directory.Entries.Index(this);
        }
    }
}