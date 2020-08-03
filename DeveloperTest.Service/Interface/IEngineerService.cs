using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;

namespace DeveloperTest.Service.Interface
{
    public interface IEngineerService
    {
        Task<List<Engineer>> GetAllEngineers();
    }
}
