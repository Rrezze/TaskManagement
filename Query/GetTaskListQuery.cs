using System;
using MediatR;
using Task = taskManagement.Models.Task;

namespace taskManagement.Query
{
	public class GetTaskListQuery : IRequest<List<Task>>
	{
		
	}
}

