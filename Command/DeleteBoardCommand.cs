using System;
using MediatR;

namespace taskManagement.Command
{
	public class DeleteBoardCommand : IRequest<int>
	{
		public int BoardId { get; set; }
	}
}

