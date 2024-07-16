using System;
using Microsoft.EntityFrameworkCore;
using taskManagement.Data;
using taskManagement.Models;

namespace taskManagement.Repositories
{
	public class WorkspaceRepository : IWorkspaceRepository
	{
		private readonly DbContextClass _dbContext;

		public WorkspaceRepository(DbContextClass dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Workspace> AddWorkspaceAsync(Workspace workspace)
		{
			var result = _dbContext.Workspaces.Add(workspace);
			await _dbContext.SaveChangesAsync();
			return result.Entity;
		}

		public async Task<int> DeleteWorkspaceAsync(int Id)
		{
			var filteredData = _dbContext.Workspaces.Where(x => x.WorkspaceId == Id).FirstOrDefault();
			_dbContext.Workspaces.Remove(filteredData);
			return await _dbContext.SaveChangesAsync();
		}

		public async Task<Workspace> GetWorkspaceByIdAsync(int Id)
		{
			return await _dbContext.Workspaces.Where(x => x.WorkspaceId == Id).FirstOrDefaultAsync();
		}

		public async Task<List<Workspace>> GetWorkspaceListAsync()
		{
			return await _dbContext.Workspaces.ToListAsync();
		}

		public async Task<int> UpdateWorkspaceAsync(Workspace workspace)
		{
			_dbContext.Workspaces.Update(workspace);
			return await _dbContext.SaveChangesAsync();
		}
    }
}

