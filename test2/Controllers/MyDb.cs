using System;
using System.Data.Entity;

namespace MySqlMVCTemplate
{
	public class MyDb: DbContext
	{
		public MyDb (): base("name=MySqlTest")
		{
		}

		public DbSet<Messages> Messages { get; set; }
	}
}

