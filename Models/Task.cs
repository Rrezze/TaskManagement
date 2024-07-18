using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace taskManagement.Models
{
	public class Task
	{
		public int TaskId { get; set; }
		public string TaskName { get; set; }
		public string TaskDescription { get; set; }

		[ForeignKey("Board")]
		public int BoardId { get; set; }

		public Board Board { get; set; }
	}
}

