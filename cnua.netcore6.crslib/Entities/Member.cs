
namespace CSR.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public Guid MemberGuid { get; init; } = Guid.NewGuid();
        public virtual string? First { get; set; }
        public virtual string? Last { get; set; }
        public virtual string? MemberHandle { get; set; }
        public int NameId { get; set; }
        public string? Phone { get; set; }
        public string? Message { get; set; }
    }
}
