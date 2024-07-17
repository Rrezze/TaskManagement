using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
	public class UpdateBoardHandler : IRequestHandler<UpdateBoardCommand, int>
	{
        private readonly IBoardRepository _boardRepository;

		public UpdateBoardHandler(IBoardRepository boardRepository)
		{
            _boardRepository = boardRepository;
		}

        public async Task<int> Handle(UpdateBoardCommand command, CancellationToken cancellationToken)
        {
            var board = await _boardRepository.GetBoardByIdAsync(command.BoardId);
            if (board == null)
                return default;

            board.BoardName = command.BoardName;
            board.WorkspaceId = command.WorkspaceId;

            return await _boardRepository.UpdateBoardAsync(board);
        }
    }
}

