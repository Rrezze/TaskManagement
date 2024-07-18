using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Repositories;
using Task = taskManagement.Models.Task;

namespace taskManagement.Handlers

{
	public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, int>
	{
		private readonly ITaskRepository _taskRepository;

		public UpdateTaskHandler(ITaskRepository taskRepository)
		{
			_taskRepository = taskRepository;
		}

        public async Task<int> Handle(UpdateTaskCommand command, CancellationToken cancellationToken)
        {
			var task = await _taskRepository.GetTaskByIdAsync(command.TaskId);
			if (task == null)
				return default;

			task.TaskName = command.TaskName;
			task.TaskDescription = command.TaskDescription;
			task.BoardId = command.BoardId;

			return await _taskRepository.UpdateTaskAsync(task);
        }
    }
}

