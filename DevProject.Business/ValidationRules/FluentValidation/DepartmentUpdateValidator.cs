using DevProject.DTO.DTOs.DepartmentDtos;
using FluentValidation;

namespace DevProject.Business.ValidationRules.FluentValidation
{
    public class DepartmentUpdateValidator : AbstractValidator<DepartmentUpdateDto>
    {
        public DepartmentUpdateValidator()
        {
            RuleFor(m => m.DepartmentName).NotNull().WithMessage("Zehmet olmasa,DepartmentName alanini doldurun");
        }
    }
}
