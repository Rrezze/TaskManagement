using System;
using MediatR;
using Task = taskManagement.Models.Task;

namespace taskManagement.Command
{
	public class CreateTaskCommand  : IRequest<Task>
	{
		public string TaskName { get; set; }
		public string TaskDescription { get; set; }
		public int BoardId { get; set; }

		public CreateTaskCommand(string taskName, string taskDescription, int boardId)
		{
			TaskName = taskName;
			TaskDescription = taskDescription;
			BoardId = boardId;
		}
	}
}

