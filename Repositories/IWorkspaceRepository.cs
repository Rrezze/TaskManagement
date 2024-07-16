using System;
using taskManagement.Models;

namespace taskManagement.Repositories
{
	public interface IWorkspaceRepository
	{
		 Task<List<Workspace>> GetWorkspaceListAsync();
		 Task <Workspace> GetWorkspaceByIdAsync(int Id);
		 Task <Workspace> AddWorkspaceAsync(Workspace workspace);
		 Task <int> UpdateWorkspaceAsync(Workspace workspace);
		 Task<int> DeleteWorkspaceAsync(int Id);
    }
}

