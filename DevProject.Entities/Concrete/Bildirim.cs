using DevProject.Core.Entities.Abstract;

namespace DevProject.Entities.Concrete
{
    public class Bildirim : IEntity
    {
        public int Id { get; set; }

        public string Aciqlama { get; set; }
        public bool Status { get; set; }

        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
