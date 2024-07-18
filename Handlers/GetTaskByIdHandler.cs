using System;
using MediatR;
using taskManagement.Query;
using taskManagement.Repositories;
using Task = taskManagement.Models.Task;


namespace taskManagement.Handlers
{
	public class GetTaskByIdHandler : IRequestHandler<GetTaskByIdQuery, Task>
	{
        private readonly ITaskRepository _taskRepository;

		public GetTaskByIdHandler(ITaskRepository taskRepository)
		{
            _taskRepository = taskRepository;
		}

        public async Task<Task> Handle(GetTaskByIdQuery query, CancellationToken cancellationToken)
        {
            return await _taskRepository.GetTaskByIdAsync(query.TaskId);
        }
    }
}

