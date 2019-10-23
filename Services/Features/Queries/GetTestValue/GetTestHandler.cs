using System.Threading;
using System.Threading.Tasks;

namespace Expressbank.TestService.Features.Features.Queries.GetTestValue
{
    public class GetTestHandler
    {
        private readonly IMFTurboTeamsDbContext _context;



        public GetTestHandler(IMFTurboTeamsDbContext context)
        {
            _context = context;
        }



        public async Task<GetTestModel> Handle(GetTestQuery request, CancellationToken cancellationToken)
        {
            return ClubModel.Create(entity);
        }
    }
}