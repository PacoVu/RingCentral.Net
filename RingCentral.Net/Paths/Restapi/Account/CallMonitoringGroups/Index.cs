using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
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
                return $"{parent.Path()}/call-monitoring-groups/{groupId}";
            }

            return $"{parent.Path()}/call-monitoring-groups";
        }

        // Operation: Create Call Monitoring Group
        // Http Post /restapi/v1.0/account/{accountId}/call-monitoring-groups
        public async Task<RingCentral.CallMonitoringGroup> Post(
            RingCentral.CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest)
        {
            return await rc.Post<RingCentral.CallMonitoringGroup>(this.Path(false), createCallMonitoringGroupRequest);
        }

        // Operation: Get Call Monitoring Groups
        // Http Get /restapi/v1.0/account/{accountId}/call-monitoring-groups
        public async Task<RingCentral.CallMonitoringGroups> Get(ListCallMonitoringGroupsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.CallMonitoringGroups>(this.Path(false), queryParams);
        }

        // Operation: Updates Call Monitoring Group
        // Http Put /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}
        public async Task<RingCentral.CallMonitoringGroup> Put(
            RingCentral.CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest)
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Put<RingCentral.CallMonitoringGroup>(this.Path(), createCallMonitoringGroupRequest);
        }

        // Operation: Remove Given Call Monitoring Group
        // Http Delete /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}
        public async Task<string> Delete()
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallMonitoringGroups.Index CallMonitoringGroups(string groupId = null)
        {
            return new Restapi.Account.CallMonitoringGroups.Index(this, groupId);
        }
    }
}