using System;
using MediatR;
using taskManagement.Models;

namespace taskManagement.Query
{
	public class GetWorkspaceByIdQuery : IRequest<Workspace>
	{
		public int Id { get; set; }
	}
}

