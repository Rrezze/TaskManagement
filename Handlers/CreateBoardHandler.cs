using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Models;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
	public class CreateBoardHandler : IRequestHandler<CreateBoardCommand, Board>
	{
        private readonly IBoardRepository _boardRepository;

		public CreateBoardHandler(IBoardRepository boardRepository)
		{
            _boardRepository = boardRepository;
		}

        public async Task<Board> Handle(CreateBoardCommand command, CancellationToken cancellationToken)
        {
            var board = new Board()
            {
                BoardName = command.BoardName,
                WorkspaceId = command.WorkspaceId
            };
            return await _boardRepository.AddBoardAsync(board);
        }
    }
}

