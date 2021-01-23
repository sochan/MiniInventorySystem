using Blazor.CIMS.Data;
using FluentValidation;

namespace Blazor.CIMS.ViewModel
{
    public class BusinessValidator : AbstractValidator<Computer>
    {
        public BusinessValidator()
        {
            RuleFor(emp => emp.Brand).NotEmpty();
        }
    }
}
