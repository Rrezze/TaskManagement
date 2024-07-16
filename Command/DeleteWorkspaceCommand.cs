using System;
using MediatR;

namespace taskManagement.Command
{
	public class DeleteWorkspaceCommand : IRequest<int>
	{
		public int WorkspaceId { get; set; }
	}
}

