using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Models;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
	public class CreateWorkspaceHandler : IRequestHandler<CreateWorkspaceCommand, Workspace>
	{
        private readonly IWorkspaceRepository _workspaceRepository;

		public CreateWorkspaceHandler(IWorkspaceRepository workspaceRepository)
		{
            _workspaceRepository = workspaceRepository;
		}

        public async Task<Workspace> Handle(CreateWorkspaceCommand command, CancellationToken cancellationToken)
        {
            var workspace = new Workspace()
            {
                WorkspaceName = command.WorkspaceName
            };
            return await _workspaceRepository.AddWorkspaceAsync(workspace);
        }
    }
}

