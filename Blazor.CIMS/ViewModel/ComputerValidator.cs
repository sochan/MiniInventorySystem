using Blazor.CIMS.Data;
using FluentValidation;

namespace Blazor.CIMS.ViewModel
{
    public class ComputerValidator : AbstractValidator<Computer>
    {
        public ComputerValidator()
        {
            RuleFor(emp => emp.Brand).NotEmpty();
        }
    }
}
