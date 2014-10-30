using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MySqlMVCTemplate
{
	[Table("TestTable")]
	public class Messages
	{
		[Key]
		public string firstname { get; set; }
	}
}

