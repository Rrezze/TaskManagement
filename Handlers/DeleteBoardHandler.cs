using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
    public class DeleteBoardHandler : IRequestHandler<DeleteBoardCommand, int>
	{
		private readonly IBoardRepository _boardRepository;

		public DeleteBoardHandler(IBoardRepository boardRepository)
		{
            _boardRepository = boardRepository;
		}

        public async Task<int> Handle(DeleteBoardCommand command, CancellationToken cancellationToken)
        {
            var board = await _boardRepository.GetBoardByIdAsync(command.BoardId);
            if (board == null)
                return default;

            return await _boardRepository.DeleteBoardAsync(board.BoardId);
        }
    }
}

