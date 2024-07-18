
using System;
using MediatR;

namespace taskManagement.Command
{
	public class DeleteTaskCommand : IRequest<int>
	{
		public int TaskId { get; set; }
	}
}

