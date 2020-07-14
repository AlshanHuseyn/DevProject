using DevProject.DTO.DTOs.ReportDtos;
using FluentValidation;

namespace DevProject.Business.ValidationRules.FluentValidation
{
    public class ReportAddValidator : AbstractValidator<ReportAddDto>
    {
        public ReportAddValidator()
        {
            RuleFor(m => m.Basliq).NotNull().WithMessage("Zehmet olmasa,Basliq bolumunu doldurun");

            RuleFor(m => m.Detay).NotNull().WithMessage("Zehmet olmasa,Detay bolumunu doldurun");
        }
    }
}
