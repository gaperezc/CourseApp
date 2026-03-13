using FluentValidation;

namespace CoursesApp.Domain.Security.RoleAggregate
{
    public class RoleValidation : AbstractValidator<Role>
    {
        public RoleValidation()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("Id cannot be null");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Code cannot be null")
                .NotEmpty().WithMessage("Code cannot be empty")
                .MaximumLength(20).WithMessage("Code cannot exceed 20 characters");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null")
                .NotEmpty().WithMessage("Name cannot be empty")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters");

            RuleFor(x => x.status)
                .NotNull().WithMessage("Status cannot be null");

            RuleFor(x => x.Description)
                .NotNull().WithMessage("Description cannot be null")
                .MaximumLength(500).WithMessage("Description cannot exceed 500 characters");



        }
    }
}
