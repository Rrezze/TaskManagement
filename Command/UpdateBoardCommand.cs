using System;
using MediatR;

namespace taskManagement.Command
{
	public class UpdateBoardCommand : IRequest<int>
	{
		public int BoardId { get; set; }
		public string BoardName { get; set; }
		public int WorkspaceId { get; set; }

		public UpdateBoardCommand(int boardId, string boardName, int workspaceId)
		{
			BoardId = boardId;
			BoardName = boardName;
			WorkspaceId = workspaceId;
		}
	}

}

