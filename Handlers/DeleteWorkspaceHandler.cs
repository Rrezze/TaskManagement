using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
	public class DeleteWorkspaceHandler : IRequestHandler<DeleteWorkspaceCommand,int>
	{
        private readonly IWorkspaceRepository _workspaceRepository;

		public DeleteWorkspaceHandler(IWorkspaceRepository workspaceRepository)
		{
            _workspaceRepository = workspaceRepository;
		}

        public async Task<int> Handle(DeleteWorkspaceCommand command, CancellationToken cancellationToken)
        {
            var workspace = await _workspaceRepository.GetWorkspaceByIdAsync(command.WorkspaceId);
            if (workspace == null)
                return default;

            return await _workspaceRepository.DeleteWorkspaceAsync(workspace.WorkspaceId);
        }
    }
}

