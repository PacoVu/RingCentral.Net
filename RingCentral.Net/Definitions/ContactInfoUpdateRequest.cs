namespace RingCentral
{
    public class ContactInfoUpdateRequest
    {
        // For User extension type only. Extension user first name
        public string firstName;

        // For User extension type only. Extension user last name
        public string lastName;

        // Extension user company name
        public string company;

        public string jobTitle;

        // Email of extension user
        public string email;

        // Extension user contact phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        public string businessPhone;

        // Extension user mobile (**non** Toll Free) phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with '+' sign) format
        public string mobilePhone;

        public ContactBusinessAddressInfo businessAddress;

        // If 'True' then contact email is enabled as login name for this user. Please note that email should be unique in this case. The default value is 'False'
        public bool? emailAsLoginName;

        public PronouncedNameInfo pronouncedName;

        // Extension user department, if any
        public string department;
    }
}