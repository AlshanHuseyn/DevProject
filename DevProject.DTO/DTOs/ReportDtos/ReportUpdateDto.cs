using DevProject.Entities.Concrete;

namespace DevProject.DTO.DTOs.ReportDtos
{
    public class ReportUpdateDto
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Zehmet olmasa,Basliq bolumunu doldurun")]
        //[Display(Name = "Basliq")]
        public string Basliq { get; set; }
        //[Required(ErrorMessage = "Zehmet olmasa,Detay bolumunu doldurun")]
        //[Display(Name = "Detay")]
        public string Detay { get; set; }

        public Job Job { get; set; }
        public int JobId { get; set; }
    }
}
