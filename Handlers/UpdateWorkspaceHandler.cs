using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
	public class UpdateWorkspaceHandler : IRequestHandler<UpdateWorkspaceCommand, int>
	{
        private readonly IWorkspaceRepository _workspaceRepository;

		public UpdateWorkspaceHandler(IWorkspaceRepository workspaceRepository)
		{
            _workspaceRepository = workspaceRepository;
		}

        public async Task<int> Handle(UpdateWorkspaceCommand command, CancellationToken cancellationToken)
        {
            var workspace = await _workspaceRepository.GetWorkspaceByIdAsync(command.WorkspaceId);

            if (workspace == null)
                return default;

            workspace.WorkspaceName = command.WorkspaceName;

            return await _workspaceRepository.UpdateWorkspaceAsync(workspace);
        }
    }
}

