using System;
using MediatR;
using Task = taskManagement.Models.Task;

namespace taskManagement.Query
{
	public class GetTaskByIdQuery : IRequest<Task>
	{
		public int TaskId { get; set; }
	}
}

