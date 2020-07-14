using DevProject.DTO.DTOs.DepartmentDtos;
using FluentValidation;

namespace DevProject.Business.ValidationRules.FluentValidation
{
    public class DepartmentAddValidator : AbstractValidator<DepartmetAddDto>
    {
        public DepartmentAddValidator()
        {
            RuleFor(m => m.DepartmentName).NotNull().WithMessage("Zehmet olmasa,DepartmentName alanini doldurun");
        }
    }
}
