using System;
using MediatR;
using taskManagement.Models;
using taskManagement.Query;
using taskManagement.Repositories;using System.Numerics;

namespace taskManagement.Handlers
{
	public class GetWorkspaceListHandler : IRequestHandler<GetWorkspaceListQuery, List<Workspace>>
	{
		private readonly IWorkspaceRepository _workspaceRepository;

		public GetWorkspaceListHandler(IWorkspaceRepository workspaceRepository)
		{
			_workspaceRepository = workspaceRepository;
		}

        public async Task<List<Workspace>> Handle(GetWorkspaceListQuery query, CancellationToken cancellationToken)
        {
			return await _workspaceRepository.GetWorkspaceListAsync();
        }
    }
}

