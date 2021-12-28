using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SubjectManagementSystem.Domain;
using SubjectManagementSystem.Service;

namespace SubjectManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractController : ControllerBase
    {
        private readonly ILogger<ContractController> _logger;
        private readonly IContractService _contractService;

        public ContractController(ILogger<ContractController> logger, IContractService contractService)
        {
            _logger = logger;
            _contractService = contractService;
        }

        [HttpGet]
        public async Task<IEnumerable<Contract>> GetAll()
        {
            return await _contractService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Contract> Get(int id)
        {
            return await _contractService.GetOne(id);
        }

        [HttpPost]
        public async Task<Contract> Create(Contract contract)
        {
            return await _contractService.Insert(contract);
        }

        [HttpPut]
        public async Task<Contract> Update(Contract contract)
        {
            return await _contractService.Update(contract);
        }

        [HttpDelete("{id}")]
        public async Task<Contract> Delete(int id)
        {
            return await _contractService.Delete(id);
        }

        [HttpPost("ProposePartnership")]
        public async Task<Contract> ProposePartnership(Contract contract)
        {
            return await _contractService.ProposePartnership(contract);
        }
    }
}