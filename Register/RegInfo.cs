
namespace Register
{
    public class RegBaseInfo
    {
        public string OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
        public string MachineCode { get; set; }
        public string ExpiryDate { get; set; }
    }

    public class RegInfo
    {
        public RegBaseInfo RegBase { get; set; }
        public string Signature { get; set; }
    }
}
