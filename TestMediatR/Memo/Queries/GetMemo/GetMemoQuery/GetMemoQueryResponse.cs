using MediatR;

namespace TestMediatR.Memo.Queries.GetMemo.GetMemoQuery
{
    public class GetMemoQueryRequest : IRequest<string>
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}";
        }
    }
}