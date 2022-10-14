using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientAPI.Context
{
	public class ClientContext : DbContext
	{
		public ClientContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Client> clients { get; set; }

	}
}
