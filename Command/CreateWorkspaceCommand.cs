using System;
using MediatR;
using taskManagement.Models;

namespace taskManagement.Command
{
	public class CreateWorkspaceCommand : IRequest<Workspace>
	{
		public string WorkspaceName { get; set; }

        public CreateWorkspaceCommand(string workspaceName)
		{
			WorkspaceName = workspaceName;
		}
	}
}

