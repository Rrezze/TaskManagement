using System;
using MediatR;
using taskManagement.Models;

namespace taskManagement.Query
{
	public class GetBoardListQuery : IRequest<List<Board>>
	{
		
	}
}

