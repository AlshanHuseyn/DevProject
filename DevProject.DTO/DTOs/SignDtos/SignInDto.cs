namespace DevProject.DTO.DTOs.SignDtos
{
    public class SignInDto
    {
        //[Required(ErrorMessage = "Zəhmət olmasa, İstifadəçi Adı bölməsini doldurun")]
        //[Display(Name = "İstifadəçi Adı:")]
        public string Username { get; set; }

        //[Required(ErrorMessage = "Zəhmət olmasa,Şifrə bölməsini doldurun")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Şifrə:")]
        public string Password { get; set; }

        //[Display(Name = "Xatirla məni")]
        public bool RememberMe { get; set; }
    }
}
