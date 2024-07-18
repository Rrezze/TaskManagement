using System;
using taskManagement.Models;
using Task = taskManagement.Models.Task;

namespace taskManagement.Repositories
{
	public interface ITaskRepository
	{
		public Task<List<Task>> GetTaskListAsync();
		public Task<Task> GetTaskByIdAsync(int Id);
		public Task<Task> AddTaskAsync(Task task);
		public Task<int> UpdateTaskAsync(Task task);
		public Task<int> DeleteTaskAsync(int Id);
	}
}

