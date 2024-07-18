using System;
using MediatR;
using taskManagement.Query;
using taskManagement.Repositories;
using Task = taskManagement.Models.Task;


namespace taskManagement.Handlers
{
	public class GetTaskListHandler : IRequestHandler<GetTaskListQuery, List<Task>>
	{
        private readonly ITaskRepository _taskRepository;

		public GetTaskListHandler(ITaskRepository taskRepository)
		{
            _taskRepository = taskRepository;
		}

        public async Task<List<Task>> Handle(GetTaskListQuery query, CancellationToken cancellationToken)
        {
            return await _taskRepository.GetTaskListAsync();
        }
    }
}

