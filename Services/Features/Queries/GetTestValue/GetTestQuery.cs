using MediatR;

namespace Expressbank.TestService.Features.Features.Queries.GetTestValue
{
    public class GetTestQuery : IRequest<GetTestModel>
    {
        public int testId { get; set; }
    }
}