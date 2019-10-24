using FluentValidation;

namespace Expressbank.TestService.Features.Features.Queries.GetTestValue
{
    public class GetTestQueryValidator : AbstractValidator<GetTestQuery>
    {
        public GetTestQueryValidator()
        {
            RuleFor(v => v.testId).NotNull();
        }
    }
}