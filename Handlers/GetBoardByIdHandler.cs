using System;
using MediatR;
using taskManagement.Models;
using taskManagement.Query;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
	public class GetBoardByIdHandler: IRequestHandler<GetBoardByIdQuery, Board>
	{
        private readonly IBoardRepository _boardRepository;

		public GetBoardByIdHandler(IBoardRepository boardRepository)
		{
            _boardRepository = boardRepository;
		}

        public async Task<Board> Handle(GetBoardByIdQuery query, CancellationToken cancellationToken)
        {
            return await _boardRepository.GetBoardByIdAsync(query.Id);
        }
    }
}

