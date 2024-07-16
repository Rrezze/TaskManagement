using System;
using MediatR;
using taskManagement.Models;

namespace taskManagement.Query
{
	public class GetWorkspaceListQuery : IRequest<List<Workspace>>
	{
		
	}
}

