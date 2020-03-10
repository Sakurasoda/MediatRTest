using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TestMediatR.Interface;

namespace TestMediatR.Memo.Queries.GetMemo.GetMemoQuery
{
    public class GetMemoQueryHandler : IRequestHandler<GetMemoQueryRequest,string>
    {
        private readonly IMemoLogic _memoLogic;

        public GetMemoQueryHandler(IMemoLogic memoLogic)
        {
            _memoLogic = memoLogic;
        }
        
        public Task<string> Handle(GetMemoQueryRequest request, CancellationToken cancellationToken)
        {
            
            return Task.FromResult($"Test; Request: {request}; Time : {_memoLogic.GetNow()}");
        }
    }
}