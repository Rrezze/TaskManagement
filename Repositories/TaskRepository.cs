using System;
using Microsoft.EntityFrameworkCore;
using taskManagement.Data;
using Task = taskManagement.Models.Task;

namespace taskManagement.Repositories
{
	public class TaskRepository : ITaskRepository
	{
        private readonly DbContextClass _dbContext;

		public TaskRepository(DbContextClass dbContext)
		{
            _dbContext = dbContext;
		}

        public async Task<Models.Task> AddTaskAsync(Models.Task task)
        {
            var result = _dbContext.Tasks.Add(task);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteTaskAsync(int Id)
        {
            var filteredData = _dbContext.Tasks.Where(x => x.TaskId == Id).FirstOrDefault();
            _dbContext.Tasks.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Models.Task> GetTaskByIdAsync(int Id)
        {
            return await _dbContext.Tasks.Where(x => x.TaskId == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Models.Task>> GetTaskListAsync()
        {
            return await _dbContext.Tasks.ToListAsync();
        }

        public async Task<int> UpdateTaskAsync(Models.Task task)
        {
            _dbContext.Tasks.Update(task);
            return await _dbContext.SaveChangesAsync();
        }
    }
}

