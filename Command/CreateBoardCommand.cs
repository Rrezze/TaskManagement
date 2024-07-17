using System;
using MediatR;
using taskManagement.Models;

namespace taskManagement.Command
{
	public class CreateBoardCommand : IRequest<Board>
	{
		public string BoardName { get; set; }
		public int WorkspaceId { get; set; }

		public CreateBoardCommand(string boardName, int workspaceId)
		{
			BoardName = boardName;
			WorkspaceId = workspaceId;
		}
	}
}

