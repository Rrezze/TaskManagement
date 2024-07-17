using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using taskManagement.Command;
using taskManagement.Models;
using taskManagement.Query;

namespace taskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
	{
		private readonly IMediator mediator;

		public BoardController(IMediator mediator)
		{
			this.mediator = mediator;
		}

		[HttpGet]
		public async Task<List<Board>> GetBoardListAsync()
		{
			var board = await mediator.Send(new GetBoardListQuery());
			return board;
		}

		[HttpGet("boardId")]
		public async Task<Board> GetBoardByIdAsync(int boardId)
		{
			var board = await mediator.Send(new GetBoardByIdQuery() { Id = boardId });
			return board;
		}

		[HttpPost]
		public async Task<Board> AddBoardAsync(Board board)
		{
			var boards = await mediator.Send(new CreateBoardCommand(
				board.BoardName,
				board.WorkspaceId
				));
			return boards;
		}

		[HttpPut]

		public async Task<int> UpdateBoardAsync(Board board)
		{
			var isBoardUpdated = await mediator.Send(new UpdateBoardCommand(
				board.BoardId,
				board.BoardName,
				board.WorkspaceId
				));

			return isBoardUpdated;
		}


		[HttpDelete]

		public async Task<int> DeleteBoardAsync(int Id)
		{
			return await mediator.Send(new DeleteBoardCommand() { BoardId = Id });
		}
	}
}

