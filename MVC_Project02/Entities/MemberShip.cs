namespace MVC_Project02.Entities
{
    public class MemberShip: BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = null!;

        public string Status => StartDate>DateTime.Now? "UpComing" 
            : EndDate > DateTime.Now ? "Active" : "Expired";
    }
}
