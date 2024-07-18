using MediatR;
using Microsoft.AspNetCore.Mvc;
using taskManagement.Command;
using taskManagement.Models;
using Task = taskManagement.Models.Task;
using taskManagement.Query;

namespace taskManagement.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class TaskController : ControllerBase
	{
		private readonly IMediator mediator;

		public TaskController(IMediator mediator)
		{
			this.mediator = mediator;
		}

		[HttpGet]
		public async Task<List<Task>> GetTaskListAsync()
		{
			var task = await mediator.Send(new GetTaskListQuery());
			return task;
		}

		[HttpGet("taskId")]
		public async Task<Task> GetTaskByIdAsync(int taskId)
		{
			var task = await mediator.Send(new GetTaskByIdQuery() { TaskId = taskId });
				return task;
		}

		[HttpPost]
		public async Task<Task> AddTaskAsync(Task task)
		{
			var tasks = await mediator.Send(new CreateTaskCommand(
					task.TaskName,
					task.TaskDescription, task.BoardId
				));
			return task;
		}

		[HttpPut]
		public async Task<int> UpdateTaskAsync(Task task)
		{
			var isTaskUpdated = await mediator.Send(new UpdateTaskCommand(
				task.TaskId,
				task.TaskName,
				task.TaskDescription,
				task.BoardId
				));

			return isTaskUpdated;
		}

		[HttpDelete]
		public async Task<int> DeleteTaskAsync(int Id)
		{
			return await mediator.Send(new DeleteTaskCommand() { TaskId = Id });
		}
	}
}

