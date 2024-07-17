using System;
using MediatR;
using taskManagement.Models;
using taskManagement.Query;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
	public class GetBoardListHandler : IRequestHandler<GetBoardListQuery, List<Board>>
	{
		private readonly IBoardRepository _boardRepository;

		public GetBoardListHandler(IBoardRepository boardRepository)
		{
			_boardRepository = boardRepository;
		}
		public async Task<List<Board>> Handle(GetBoardListQuery query, CancellationToken cancellationToken)
		{
			return await _boardRepository.GetBoardListAsync();
		}
	}
}

