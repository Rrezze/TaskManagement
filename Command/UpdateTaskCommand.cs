using System;
using MediatR;
using Task = taskManagement.Models.Task;

namespace taskManagement.Command
{
	public class UpdateTaskCommand : IRequest<int>
	{
		public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int BoardId { get; set; }

        public UpdateTaskCommand(int taskId , string taskName, string taskDescription, int boardId)
		{
			TaskId = taskId;
			TaskName = taskName;
			TaskDescription = taskDescription;
			BoardId = boardId;
		}
	}
}

