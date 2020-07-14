using DevProject.DTO.DTOs.UserDtos;
using FluentValidation;

namespace DevProject.Business.ValidationRules.FluentValidation
{
    public class AddUserValidator : AbstractValidator<AddUserDto>
    {
        public AddUserValidator()
        {
            RuleFor(m => m.UserName).NotNull().WithMessage("Zəhmət olmasa, İstifadəçi Adı bölməsini dolduru");

            RuleFor(m => m.Password).NotNull().WithMessage("Zəhmət olmasa,Şifrə bölməsini doldurun");

            RuleFor(m => m.ConfirmPassword).NotNull().WithMessage("Zəhmət olmasa,Şifrənizi təsdiqləyin bölməsini doldurun");

            RuleFor(m => m.ConfirmPassword).Equal(m => m.Password).WithMessage("Zəhmət olmasa,Şifrənizi təkrar edin");

            RuleFor(m => m.Email).NotNull().WithMessage("Zəhmət olmasa,Email bölməsini doldurun").EmailAddress()
                .WithMessage("Zəhmət olmasa,Doğru Email daxil edin");

            RuleFor(m => m.Name).NotNull().WithMessage("Zəhmət olmasa,Adınız bölməsini doldurun");

            RuleFor(m => m.SurName).NotNull().WithMessage("Zəhmət olmasa,Soyadınız bölməsini doldurun");

            RuleFor(m => m.Age).NotNull().WithMessage("Zəhmət olmasa,Yaşiniz bölməsini doldurun");

            RuleFor(m => m.Salary).NotNull().WithMessage("Zəhmət olmasa,Maas bölməsini doldurun");

        }
    }
}
