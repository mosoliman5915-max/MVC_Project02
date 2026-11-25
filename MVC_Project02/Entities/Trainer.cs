using MVC_Project02.Entities.Enums;

namespace MVC_Project02.Entities
{
    public class Trainer:GymUser
    {
        public DateTime HireDate { get; set; }
        public Specialities Specialities { get; set; }

        public ICollection<Session> Sessions { get; set; } = null!;


    }
}
