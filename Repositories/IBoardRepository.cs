using System;
using taskManagement.Models;

namespace taskManagement.Repositories
{
	public interface IBoardRepository
	{
		public Task<List<Board>> GetBoardListAsync();
		public Task<Board> GetBoardByIdAsync(int id);
		public Task<Board> AddBoardAsync(Board board);
		public Task<int> UpdateBoardAsync(Board board);
		public Task<int> DeleteBoardAsync(int id);
	}
}

