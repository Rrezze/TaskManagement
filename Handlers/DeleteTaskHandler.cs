using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Repositories;
using Task = taskManagement.Models.Task;

namespace taskManagement.Handlers

{
	public class DeleteTaskHandler : IRequestHandler<DeleteTaskCommand, int>
	{
		private readonly ITaskRepository _taskRepository;

		public DeleteTaskHandler(ITaskRepository taskRepository)
		{
			_taskRepository = taskRepository;
		}

        public async Task<int> Handle(DeleteTaskCommand command, CancellationToken cancellationToken)
        {
			var task = await _taskRepository.GetTaskByIdAsync(command.TaskId);
			if (task == null)
				return default;

			return await _taskRepository.DeleteTaskAsync(task.TaskId);
        }
    }
}

