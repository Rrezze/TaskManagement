using System;
using MediatR;
using taskManagement.Command;
using taskManagement.Repositories;
using Task = taskManagement.Models.Task;

namespace taskManagement.Handlers
{
	public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, Task>
	{
        private readonly ITaskRepository _taskRepository;

		public CreateTaskHandler(ITaskRepository taskRepository)
		{
            _taskRepository = taskRepository;
		}

        public async Task<Task> Handle(CreateTaskCommand command, CancellationToken cancellationToken)
        {
            var task = new Task()
            {
                TaskName = command.TaskName,
                TaskDescription = command.TaskDescription,
                BoardId = command.BoardId
            };
            return await _taskRepository.AddTaskAsync(task);
        }
    }
}

