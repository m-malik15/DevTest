using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;
using DeveloperTest.Data.Repositories.Interface;
using DeveloperTest.Service.Interface;

namespace DeveloperTest.Service
{
    public class EngineerService : IEngineerService
    {
        private readonly IEngineerRepository _engineerRepository;

        public EngineerService(IEngineerRepository engineerRepository)
        {
            _engineerRepository = engineerRepository;
        }

        public async Task<List<Engineer>> GetAllEngineers()
        {
            return await _engineerRepository.GetAll();
        }
    }
}
