namespace RingCentral
{
    public class ExtensionResource : Serializable
    {
        public string uri;
        public string id;
        public string partnerId;
        public string extensionNumber;
        public string loginName;
        public ContactInfo contact;
        public Reference[] references;

        public string name;

        // Enum: Unknown, User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup, IvrMenu, ApplicationExtension, ParkLocation
        public string type;

        // Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        public string status;
        public StatusInfo statusInfo;
        public DepartmentResource[] departments;
        public ServiceFeatureValue[] serviceFeatures;

        public RegionalSettingsResource regionalSettings;

        // Enum: NotStarted, Incomplete, Completed, Unknown
        public string setupWizardState;
        public ExtensionPermissionsResource permissions;
        public string password;
        public string ivrPin;
        public ProfileImageResource profileImage;
    }
}