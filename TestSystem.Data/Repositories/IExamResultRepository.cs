using System.Collections.Generic;
using System.Threading.Tasks;
using TestSystem.Data.Entites;

namespace TestSystem.Data.Repositories
{
    public interface IExamResultRepository
    {
        Task AddAsync(ExamResult entity);

        Task<IEnumerable<ExamResult>> GetAllAsync();

        Task<IEnumerable<ExamResult>> GetAllAsync(string userId);
    }
}
