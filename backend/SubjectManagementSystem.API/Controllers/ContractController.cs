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
        public IEnumerable<Contract> GetAll()
        {
            return _contractService.GetAll();
        }

        [HttpGet("{id}")]
        public Contract Get(int id)
        {
            return _contractService.GetOne(id);
        }

        [HttpPost]
        public Contract Create(Contract contract)
        {
            return _contractService.Insert(contract);
        }

        [HttpPut]
        public Contract Update(Contract contract)
        {
            return _contractService.Update(contract);
        }

        [HttpDelete("{id}")]
        public Contract Delete(int id)
        {
            return _contractService.Delete(id);
        }
    }
}