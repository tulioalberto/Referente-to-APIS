using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientAPI.Repository;
using ClientAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientAPI.Controllers
{
	public class ClientController : ControllerBase
	{
		private readonly IClientRepository _clientRepository;

		public ClientController(IClientRepository clientRepository)
		{
			_clientRepository = clientRepository;
		}
		
		[HttpGet]
		public async Task<List<Client>> Get()
		{
			return await _clientRepository.Get();
		}

		[HttpGet("{Id}")]
		public async Task<ActionResult<Client>> GetById(int Id) 
		{
			return await _clientRepository.Get(Id);
		}
		
		[HttpPut]
		public async Task<ActionResult<Client>> PutEmployee(int Id, [FromBody] Client client) 
		{
			if (Id != client.Id)
			{
				return BadRequest();
			}
			await _clientRepository.Update(client);

			return NoContent();
		}

		[HttpDelete("{Id}")]
		public async Task<ActionResult<Client>> Delete(int Id) 
		{
			var clientToDelete = await _clientRepository.Get(Id);

			if (clientToDelete == null) 
			{
				return NotFound();
			}
			await _clientRepository.Delete(clientToDelete.Id);

			return NoContent();
		}
	}
}
