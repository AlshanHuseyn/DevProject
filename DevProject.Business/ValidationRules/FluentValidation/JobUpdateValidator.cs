using DevProject.DTO.DTOs.JobDtos;
using FluentValidation;

namespace DevProject.Business.ValidationRules.FluentValidation
{
    public class JobUpdateValidator : AbstractValidator<JobUpdateDto>
    {
        public JobUpdateValidator()
        {
            RuleFor(m => m.Name).NotNull().WithMessage("Zehmet olmasa,Is Adi bolumunu doldurun");

            RuleFor(m => m.Description).NotNull().WithMessage("Zehmet olmasa,Aciqlama bolumunu doldurun");

            RuleFor(m => m.DepartmentId).ExclusiveBetween(0, int.MaxValue).WithMessage("Zehmet olmasa,bir Department secin");
        }
    }
}
