namespace DevProject.DTO.DTOs.SignDtos
{
    public class SignUpDto
    {
        //[Required(ErrorMessage = "Zəhmət olmasa, İstifadəçi Adı bölməsini doldurun")]
        //[Display(Name = "İstifadəçi Adı:")]
        public string Username { get; set; }

        //[Required(ErrorMessage = "Zəhmət olmasa,Şifrə bölməsini doldurun")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Şifrə:")]
        public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Zəhmət olmasa,Şifrənizi təkrar edin")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Şifrənizi təsdiqləyin:")]
        public string ConfirmPassword { get; set; }

        //[EmailAddress(ErrorMessage = "Zəhmət olmasa,Doğru Email daxil edin")]
        //[Required(ErrorMessage = "Zəhmət olmasa,Email bölməsini doldurun")]
        //[Display(Name = "Email:")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Zəhmət olmasa,Adınız bölməsini doldurun")]
        //[Display(Name = "Adınız:")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Zəhmət olmasa,Soyadınız bölməsini doldurun")]
        //[Display(Name = "Soyadınız :")]
        public string Surname { get; set; }

        //[Required(ErrorMessage = "Zəhmət olmasa,Yaşiniz bölməsini doldurun")]
        //[Display(Name = "Yaşiniz ")]
        public int Age { get; set; }
    }
}
