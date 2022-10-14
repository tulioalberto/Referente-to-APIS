using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientAPI.Models;

namespace ClientAPI.Repository
{
	public interface IClientRepository
	{
		Task<List<Client>> Get();
		Task<Client> Get(int Id);
		Task<Client> Create(Client client);
		Task<Client> Update(Client client);
		Task<Client> Delete(int Id);
	}
}
