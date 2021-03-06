using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public RestClient rc;
        public string chatId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string chatId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.chatId = chatId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null)
            {
                return $"{parent.Path()}/chats/{chatId}";
            }

            return $"{parent.Path()}/chats";
        }

        // Operation: Get Chat List
        // Http Get /restapi/v1.0/glip/chats
        public async Task<RingCentral.GlipChatsList> List(ListGlipChatsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipChatsList>(this.Path(false), queryParams);
        }

        // Operation: Get Chat
        // Http Get /restapi/v1.0/glip/chats/{chatId}
        public async Task<RingCentral.GlipChatInfo> Get()
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipChatInfo>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Index Chats(string chatId = null)
        {
            return new Restapi.Glip.Chats.Index(this, chatId);
        }
    }
}