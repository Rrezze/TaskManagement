using System;
using MediatR;

namespace taskManagement.Command
{
	public class UpdateWorkspaceCommand : IRequest<int>
	{
		public int WorkspaceId { get; set; }
		public string WorkspaceName { get; set; }

		public UpdateWorkspaceCommand(int id,string workSpace)
		{
			WorkspaceId = id;
			WorkspaceName = workSpace;
		}

    }
}

