using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Everyone
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/everyone";
        }

        // Operation: Get Everyone Chat Info
        // Http Get /restapi/v1.0/glip/everyone
        public async Task<RingCentral.GlipEveryoneInfo> Get()
        {
            return await rc.Get<RingCentral.GlipEveryoneInfo>(this.Path());
        }

        // Operation: Update Everyone Сhat Info
        // Http Patch /restapi/v1.0/glip/everyone
        public async Task<RingCentral.GlipEveryoneInfo> Patch(
            RingCentral.UpdateGlipEveryoneRequest updateGlipEveryoneRequest)
        {
            return await rc.Patch<RingCentral.GlipEveryoneInfo>(this.Path(), updateGlipEveryoneRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Everyone.Index Everyone()
        {
            return new Restapi.Glip.Everyone.Index(this);
        }
    }
}