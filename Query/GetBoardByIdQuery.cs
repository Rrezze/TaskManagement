using System;
using MediatR;
using taskManagement.Models;

namespace taskManagement.Query
{
	public class GetBoardByIdQuery : IRequest<Board>
	{
		public int Id { get; set; }
	}
}

