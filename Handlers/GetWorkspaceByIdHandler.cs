using System;
using MediatR;
using taskManagement.Models;
using taskManagement.Query;
using taskManagement.Repositories;

namespace taskManagement.Handlers
{
	public class GetWorkspaceByIdHandler : IRequestHandler<GetWorkspaceByIdQuery, Workspace>
	{
        private readonly IWorkspaceRepository _workspaceRepository;

		public GetWorkspaceByIdHandler(IWorkspaceRepository workspaceRepository)
		{
            _workspaceRepository = workspaceRepository;
		}

        public async Task<Workspace> Handle(GetWorkspaceByIdQuery query, CancellationToken cancellationToken)
        {
            return await _workspaceRepository.GetWorkspaceByIdAsync(query.Id);
        }
    }
}

