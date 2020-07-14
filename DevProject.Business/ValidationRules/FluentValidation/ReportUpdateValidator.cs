using DevProject.DTO.DTOs.ReportDtos;
using FluentValidation;

namespace DevProject.Business.ValidationRules.FluentValidation
{
    public class ReportUpdateValidator : AbstractValidator<ReportUpdateDto>
    {
        public ReportUpdateValidator()
        {
            RuleFor(m => m.Basliq).NotNull().WithMessage("Zehmet olmasa,Basliq bolumunu doldurun");

            RuleFor(m => m.Detay).NotNull().WithMessage("Zehmet olmasa,Detay bolumunu doldurun");
        }
    }
}
