using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace taskManagement.Models
{
	public class Board
	{
		public int BoardId { get; set; }

		public string BoardName { get; set; }

		[ForeignKey("Workspace")]

		public int WorkspaceId { get; set; }

		public Workspace Workspace { get; set; }
	}
}

