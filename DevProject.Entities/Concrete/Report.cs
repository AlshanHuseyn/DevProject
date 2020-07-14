using DevProject.Core.Entities.Abstract;

namespace DevProject.Entities.Concrete
{
    public class Report : IEntity
    {
        public int Id { get; set; }
        public string Basliq { get; set; }
        public string Detay { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
