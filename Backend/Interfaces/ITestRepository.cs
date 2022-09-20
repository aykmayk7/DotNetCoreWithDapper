using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TestModel>> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TestModel> Get(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> Add(TestModel model);
    }
}
