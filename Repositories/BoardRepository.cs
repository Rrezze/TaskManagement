using System;
using Microsoft.EntityFrameworkCore;
using taskManagement.Data;
using taskManagement.Models;
using System.Numerics;

namespace taskManagement.Repositories
{
	public class BoardRepository : IBoardRepository
	{
        private readonly DbContextClass _dbContext;

		public BoardRepository(DbContextClass dbContext)
		{
            _dbContext = dbContext;
		}

        public async Task<Board> AddBoardAsync(Board board)
        {
            var result = _dbContext.Boards.Add(board);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteBoardAsync(int id)
        {
            var filteredData = _dbContext.Boards.Where(x => x.BoardId == id).FirstOrDefault();
            _dbContext.Boards.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Board> GetBoardByIdAsync(int id)
        {
            return await _dbContext.Boards.Where(x => x.BoardId == id).FirstOrDefaultAsync();
        }

        public async Task<List<Board>> GetBoardListAsync()
        {
            return await _dbContext.Boards.ToListAsync();
        }

        public async Task<int> UpdateBoardAsync(Board board)
        {
            _dbContext.Boards.Update(board);
            return await _dbContext.SaveChangesAsync();
        }
    }
}

